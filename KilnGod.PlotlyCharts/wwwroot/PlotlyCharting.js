//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyCharting.js
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See License.txt for details.
//***********************************************************************************

const plotlyAssetUrl = new URL("./plotly.min.js", import.meta.url);
let plotlyLoad;
const hostIsLittleEndian = new Uint16Array(new Uint8Array([1, 0]).buffer)[0] === 1;
const chartResources = new WeakMap();

// Plotly v4.2.0 is vendored as its official UMD distribution. The loader converts
// its intentional UMD global into one canonical namespace for this thin adapter.
function loadPlotly() {
    if (globalThis.Plotly) {
        return Promise.resolve(globalThis.Plotly);
    }

    if (!plotlyLoad) {
        plotlyLoad = new Promise((resolve, reject) => {
            const existingScript = document.querySelector("script[data-kilngod-plotly]");
            if (existingScript) {
                if (globalThis.Plotly || globalThis.moduleName) {
                    resolvePlotly(resolve, reject);
                    return;
                }
                existingScript.addEventListener("load", () => resolvePlotly(resolve, reject), { once: true });
                existingScript.addEventListener("error", () => reject(new Error("Unable to load the vendored Plotly.js asset.")), { once: true });
                return;
            }

            const script = document.createElement("script");
            script.src = plotlyAssetUrl.href;
            script.dataset.kilngodPlotly = "true";
            script.onload = () => resolvePlotly(resolve, reject);
            script.onerror = () => reject(new Error(`Unable to load ${plotlyAssetUrl.href}.`));
            document.head.appendChild(script);
        });
    }

    return plotlyLoad;
}

function resolvePlotly(resolve, reject) {
    const plotly = globalThis.Plotly ?? globalThis.moduleName;
    if (!plotly) {
        reject(new Error("The vendored Plotly.js asset did not expose its UMD runtime."));
        return;
    }

    // v4.2.0's UMD bundle exposes `moduleName`; use Plotly as the adapter's
    // canonical name after the one-time normalization.
    globalThis.Plotly = plotly;
    resolve(plotly);
}

function getArguments(values) {
    if (values === undefined || values === null) {
        return [];
    }

    return Array.isArray(values) ? values : [values];
}

function requireFunction(target, functionName, ownerName) {
    const fn = target?.[functionName];
    if (typeof fn !== "function") {
        throw new TypeError(`${ownerName} does not expose a '${functionName}' function.`);
    }

    return fn;
}

function invokeFunction(target, functionName, values, ownerName) {
    const fn = requireFunction(target, functionName, ownerName);
    return fn.apply(target, getArguments(values));
}

function getPropertyValue(values) {
    const args = getArguments(values);
    return args.length === 1 ? args[0] : args;
}

function getEventHandlerCount(plotlyChart) {
    const events = plotlyChart?._ev?._events;
    if (!events || typeof events !== "object") {
        return 0;
    }

    return Object.values(events).reduce((count, handlers) => {
        if (Array.isArray(handlers)) return count + handlers.length;
        return count + (typeof handlers === "function" ? 1 : 0);
    }, 0);
}

function getBrowserMemory() {
    const memory = globalThis.performance?.memory;
    if (!memory) {
        return null;
    }

    return {
        usedJSHeapSize: memory.usedJSHeapSize,
        totalJSHeapSize: memory.totalJSHeapSize,
        jsHeapSizeLimit: memory.jsHeapSizeLimit
    };
}

function getRenderingMetrics(plotlyChart) {
    const elements = plotlyChart?.querySelectorAll?.("*");
    const canvases = plotlyChart?.querySelectorAll?.("canvas") ?? [];
    const svgs = plotlyChart?.querySelectorAll?.("svg") ?? [];
    const layoutStart = performance.now();
    const rect = plotlyChart?.getBoundingClientRect?.();
    const layoutDurationMs = performance.now() - layoutStart;

    return {
        domNodeCount: elements?.length ?? 0,
        svgCount: svgs.length,
        canvasCount: canvases.length,
        webglCanvasCount: Array.from(canvases).filter(canvas =>
            canvas.classList.contains("gl-canvas") || canvas.classList.contains("gl-canvas-context")).length,
        width: rect?.width ?? 0,
        height: rect?.height ?? 0,
        layoutDurationMs,
        eventHandlerCount: getEventHandlerCount(plotlyChart),
        memory: getBrowserMemory()
    };
}

function waitForNextFrame() {
    return new Promise(resolve => requestAnimationFrame(() => resolve()));
}

///
export async function initializePlotlyChart(plotlyId, isWebassemblyClient) {
    // strict mode on by default in modules


    await loadPlotly();
    const plotlyChart = window.document.getElementById(plotlyId); // this is a div

    if (!plotlyChart) {
        throw new Error(`Unable to find Plotly chart element '${plotlyId}'.`);
    }

    const existingResources = chartResources.get(plotlyChart);
    if (existingResources?.active) {
        return;
    }

    const plotly = await loadPlotly();
    // A DOM container can be reused by a route/component replacement. Purge any
    // prior Plotly-owned state before attaching the new lightweight basis object.
    if (plotlyChart._fullData || plotlyChart._fullLayout || plotlyChart.data) {
        if (typeof plotly.purge === "function") {
            await plotly.purge(plotlyChart);
        }
    }

    plotlyChart.plotlyBasis = new PlotlyBasis(plotlyChart, isWebassemblyClient);
    chartResources.set(plotlyChart, {
        active: true,
        adapterEventHandlerCount: 0,
        resizeObserverCount: 0,
        windowHandlerCount: 0,
        timerCount: 0
    });

    return;
}


export function setValuePlotlyChart(plotlyChart, valueName, values) {
    // strict mode on by default in modules
    if (plotlyChart) {

        plotlyChart[valueName] = getPropertyValue(values);
    }
}

export function getValuePlotlyChart(plotlyChart, valueName, values) {
    if (!plotlyChart) {
        return undefined;
    }

    const value = plotlyChart[valueName];
    return typeof value === "function"
        ? invokeFunction(plotlyChart, valueName, values, "Plotly chart")
        : value;
}

export async function setFunctionPlotlyChart(plotlyChart, functionName, values) {
    // strict mode on by default in modules
    if (plotlyChart) {
        const plotly = await loadPlotly();

        return invokeFunction(plotly, functionName, [plotlyChart, ...getArguments(values)], "Plotly");
    }
}

export async function resizePlotlyChart(plotlyChart) {
    if (!plotlyChart) {
        return;
    }

    const plotly = await loadPlotly();
    const resize = plotly?.Plots?.resize;
    if (typeof resize !== "function") {
        throw new TypeError("Plotly.Plots.resize is not available.");
    }

    return resize(plotlyChart);
}

function getTypedArray(bytes, elementType, elementCount) {
    if (bytes === undefined || bytes === null || elementCount === 0) {
        return undefined;
    }

    const source = bytes instanceof Uint8Array ? bytes : new Uint8Array(bytes);
    const bytesPerElement = elementType === "Float64" ? 8 : 4;
    if (source.byteLength !== elementCount * bytesPerElement) {
        throw new RangeError(`Invalid ${elementType} byte length.`);
    }

    // Blazor byte-array interop supplies a Uint8Array. Plotly consumes ordinary
    // JavaScript typed arrays directly, avoiding a per-point JS number array.
    if (hostIsLittleEndian && source.byteOffset % bytesPerElement === 0) {
        const view = source.buffer;
        const offset = source.byteOffset;
        switch (elementType) {
            case "Int32": return new Int32Array(view, offset, elementCount);
            case "Float32": return new Float32Array(view, offset, elementCount);
            case "Float64": return new Float64Array(view, offset, elementCount);
            default: throw new TypeError(`Unsupported numeric array type '${elementType}'.`);
        }
    }

    // Portable fallback for an unusual byte order or unaligned source view.
    const dataView = new DataView(source.buffer, source.byteOffset, source.byteLength);
    switch (elementType) {
        case "Int32": {
            const result = new Int32Array(elementCount);
            for (let index = 0; index < elementCount; index++) result[index] = dataView.getInt32(index * 4, true);
            return result;
        }
        case "Float32": {
            const result = new Float32Array(elementCount);
            for (let index = 0; index < elementCount; index++) result[index] = dataView.getFloat32(index * 4, true);
            return result;
        }
        case "Float64": {
            const result = new Float64Array(elementCount);
            for (let index = 0; index < elementCount; index++) result[index] = dataView.getFloat64(index * 8, true);
            return result;
        }
        default: throw new TypeError(`Unsupported numeric array type '${elementType}'.`);
    }
}

export async function setFunctionPlotlyChartNumericArrays(
    plotlyChart,
    traceIndex,
    xBytes,
    xType,
    xCount,
    yBytes,
    yType,
    yCount) {
    if (!plotlyChart) {
        return;
    }

    const plotly = await loadPlotly();
    const update = {};
    const x = getTypedArray(xBytes, xType, xCount);
    const y = getTypedArray(yBytes, yType, yCount);
    if (x !== undefined) update.x = x;
    if (y !== undefined) update.y = y;

    return invokeFunction(plotly, "restyle", [plotlyChart, update, traceIndex], "Plotly");
}

export async function setFunctionPlotlyChartNumericFields(
    plotlyChart,
    traceIndex,
    fields,
    matrixField,
    matrixRows,
    matrixColumns) {
    if (!plotlyChart) {
        return;
    }

    const plotly = await loadPlotly();
    const update = {};
    for (const [fieldName, payload] of Object.entries(fields ?? {})) {
        const values = getTypedArray(payload.bytes, payload.elementType, payload.elementCount);
        if (fieldName === matrixField) {
            if (!Number.isInteger(matrixRows) || !Number.isInteger(matrixColumns) ||
                matrixRows <= 0 || matrixColumns <= 0 ||
                matrixRows * matrixColumns !== payload.elementCount) {
                throw new RangeError(`Invalid matrix dimensions for '${fieldName}'.`);
            }

            update[fieldName] = Array.from(
                { length: matrixRows },
                (_, row) => values.subarray(row * matrixColumns, (row + 1) * matrixColumns));
        } else {
            update[fieldName] = values;
        }
    }

    return invokeFunction(plotly, "restyle", [plotlyChart, update, traceIndex], "Plotly");
}

export async function setFunctionPlotlyChartNumericStream(plotlyChart, traceIndex, streamReference) {
    if (!plotlyChart) {
        return;
    }

    const plotly = await loadPlotly();
    const bytes = new Uint8Array(await streamReference.arrayBuffer());
    const view = new DataView(bytes.buffer, bytes.byteOffset, bytes.byteLength);
    let offset = 0;
    const readUInt8 = () => view.getUint8(offset++);
    const readUInt16 = () => { const value = view.getUint16(offset, true); offset += 2; return value; };
    const readInt32 = () => { const value = view.getInt32(offset, true); offset += 4; return value; };
    const magic = view.getUint32(offset, true); offset += 4;
    const version = readUInt8();
    const fieldCount = readUInt16();
    if (magic !== 0x504e474b || version !== 1 || fieldCount === 0) {
        throw new RangeError("Invalid Plotly numeric stream header.");
    }

    const update = {};
    const decoder = new TextDecoder();
    for (let fieldIndex = 0; fieldIndex < fieldCount; fieldIndex++) {
        const nameLength = readUInt16();
        if (offset + nameLength > bytes.byteLength) throw new RangeError("Invalid Plotly numeric field name.");
        const name = decoder.decode(bytes.subarray(offset, offset + nameLength));
        offset += nameLength;
        const elementType = ["Int32", "Float32", "Float64"][readUInt8()];
        const elementCount = readInt32();
        const rows = readInt32();
        const columns = readInt32();
        const byteLength = readInt32();
        if (!elementType || elementCount < 0 || byteLength < 0 || offset + byteLength > bytes.byteLength) {
            throw new RangeError(`Invalid Plotly numeric field '${name}'.`);
        }

        const values = getTypedArray(bytes.subarray(offset, offset + byteLength), elementType, elementCount);
        offset += byteLength;
        if (rows === 0 && columns === 0) {
            update[name] = values;
        } else {
            if (rows <= 0 || columns <= 0 || rows * columns !== elementCount) {
                throw new RangeError(`Invalid matrix dimensions for '${name}'.`);
            }
            update[name] = Array.from(
                { length: rows },
                (_, row) => values.subarray(row * columns, (row + 1) * columns));
        }
    }

    if (offset !== bytes.byteLength) {
        throw new RangeError("Unexpected trailing bytes in Plotly numeric stream.");
    }

    return invokeFunction(plotly, "restyle", [plotlyChart, update, traceIndex], "Plotly");
}

export async function getFunctionPlotlyChart(plotlyChart, functionName, values) {
    if (!plotlyChart) {
        return undefined;
    }

    const plotly = await loadPlotly();
    return invokeFunction(plotly, functionName, [plotlyChart, ...getArguments(values)], "Plotly");
}

// Read-only audit snapshot. It intentionally returns counts, stable trace uids, and
// interaction state only; it does not retain chart data or create a second model.
export function getPlotlyChartAuditState(plotlyChart) {
    if (!plotlyChart) {
        return undefined;
    }

    const data = Array.isArray(plotlyChart.data) ? plotlyChart.data : [];
    const layout = plotlyChart._fullLayout ?? plotlyChart.layout ?? {};
    const events = plotlyChart._ev?._events;
    const eventNames = events && typeof events === "object" ? Object.keys(events) : [];
    const resources = chartResources.get(plotlyChart);
    return {
        traceCount: data.length,
        traceUids: data.map(trace => trace?.uid ?? null),
        pointCounts: data.map(trace => typeof trace?.x?.length === "number" ? trace.x.length : null),
        xRange: layout.xaxis?.range ?? null,
        yRange: layout.yaxis?.range ?? null,
        sceneCamera: layout.scene?.camera ?? null,
        uiRevision: layout.uirevision ?? null,
        eventNames,
        eventHandlerCount: getEventHandlerCount(plotlyChart),
        adapterResources: {
            initialized: resources?.active === true,
            adapterEventHandlerCount: resources?.adapterEventHandlerCount ?? 0,
            resizeObserverCount: resources?.resizeObserverCount ?? 0,
            windowHandlerCount: resources?.windowHandlerCount ?? 0,
            timerCount: resources?.timerCount ?? 0,
            moduleReferenceOwnedByAdapter: true
        },
        rendering: getRenderingMetrics(plotlyChart)
    };
}

export async function measureFunctionPlotlyChart(plotlyChart, functionName, values) {
    if (!plotlyChart) {
        return undefined;
    }

    const plotly = await loadPlotly();
    const before = getRenderingMetrics(plotlyChart);
    const start = performance.now();
    const result = invokeFunction(plotly, functionName, [plotlyChart, ...getArguments(values)], "Plotly");
    if (result && typeof result.then === "function") {
        await result;
    }
    const plotlyEnd = performance.now();
    await waitForNextFrame();
    const after = getRenderingMetrics(plotlyChart);

    return {
        functionName,
        plotlyDurationMs: plotlyEnd - start,
        frameDurationMs: performance.now() - start,
        layoutDurationMs: after.layoutDurationMs,
        before,
        after,
        domNodeDelta: after.domNodeCount - before.domNodeCount,
        svgDelta: after.svgCount - before.svgCount,
        canvasDelta: after.canvasCount - before.canvasCount,
        eventHandlerDelta: after.eventHandlerCount - before.eventHandlerCount,
        memoryBefore: before.memory,
        memoryAfter: after.memory
    };
}

export async function measurePlotlyChartLifecycle(plotlyChart, cycles = 5) {
    if (!plotlyChart?.parentElement) {
        return undefined;
    }

    const plotly = await loadPlotly();
    const parent = plotlyChart.parentElement;
    const count = Math.max(1, Math.min(20, Number(cycles) || 5));
    const samples = [];
    const before = getRenderingMetrics(plotlyChart);

    for (let index = 0; index < count; index++) {
        const temporary = document.createElement("div");
        temporary.style.width = "320px";
        temporary.style.height = "240px";
        parent.appendChild(temporary);
        const start = performance.now();
        await plotly.newPlot(
            temporary,
            [{ x: [0, 1, 2], y: [index, index + 1, index + 2], type: "scatter" }],
            { uirevision: "lifecycle-audit" },
            { responsive: false });
        const rendered = getRenderingMetrics(temporary);
        await plotly.purge(temporary);
        temporary.remove();
        samples.push({
            cycle: index + 1,
            durationMs: performance.now() - start,
            domNodeCount: rendered.domNodeCount,
            svgCount: rendered.svgCount,
            canvasCount: rendered.canvasCount,
            memory: rendered.memory
        });
    }

    const after = getRenderingMetrics(plotlyChart);
    return {
        cycles: count,
        samples,
        before,
        after,
        retainedDomNodeDelta: after.domNodeCount - before.domNodeCount,
        retainedSvgDelta: after.svgCount - before.svgCount,
        retainedCanvasDelta: after.canvasCount - before.canvasCount,
        memoryBefore: before.memory,
        memoryAfter: after.memory
    };
}

function invokeBasisFunction(plotlyChart, functionName, values) {
    const basis = plotlyChart?.plotlyBasis;
    if (!basis) {
        throw new Error("The PlotlyBasis object has not been initialized.");
    }

    if (typeof basis[functionName] === "function") {
        return invokeFunction(basis, functionName, values, "PlotlyBasis");
    }

    // Plotly operations such as newPlot belong to the Plotly namespace, while
    // validation/template operations belong to PlotlyBasis. Keep this fallback
    // generic so the adapter does not need one wrapper per Plotly API function.
    return invokeFunction(globalThis.Plotly, functionName, [plotlyChart, ...getArguments(values)], "Plotly");
}

export function setFunctionPlotlyBasis(plotlyChart, functionName, values) {
    if (!plotlyChart) {
        return;
    }

    return invokeBasisFunction(plotlyChart, functionName, values);
}

export function getFunctionPlotlyBasis(plotlyChart, functionName, values) {
    if (!plotlyChart) {
        return undefined;
    }

    return invokeBasisFunction(plotlyChart, functionName, values);
}


export function disposePlotlyChart(plotlyChart) {
    if (!plotlyChart) {
        return;
    }

    const plotly = globalThis.Plotly;
    if (plotly && typeof plotly.purge === "function") {
        plotly.purge(plotlyChart);
    }

    delete plotlyChart.plotlyBasis;
    chartResources.delete(plotlyChart);
}


/// <summary>
/// PlotlyBasis
///
/// This is a browser object which hosts local storage to interaction with plotly.js we do not want to round trip to the server for every plotly call
/// therefor we want to move data to and from the browser and call plotly.js with references to browser stored objects.
/// </summary>
export class PlotlyBasis {
    // strict mode on by default in modules
    constructor(plotlyCanvas, isWebAssemblyClient) {

        this.plotlyCanvas = plotlyCanvas;
        this.isWebassemblyClient = isWebAssemblyClient;

        this.templateStorage = [];
    }

    async validate(data, layout) {
        const plotly = await loadPlotly();
        return plotly.validate(data, layout);

    }

    async makeTemplate(templateName, plotObject) {
        const plotly = await loadPlotly();
        this.templateStorage[templateName] = plotly.makeTemplate(plotObject);
    }

    async validateTemplate(templateName, plotObject) {
        const plotly = await loadPlotly();
        return plotly.validateTemplate(plotObject, this.templateStorage[templateName]);
    }



}


