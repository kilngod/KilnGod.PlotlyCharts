#if false // Disabled developer-only interop audit; keep out of the sample app.
//***********************************************************************************
// KilnGod.PlotlyCharts
//
// File: PlotlyUpdateAudit.razor.cs
//***********************************************************************************

using System.Diagnostics;
using System.Dynamic;
using System.Text.Json.Nodes;
using KilnGod.PlotlyCharts.Diagnostics;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Configuration;
using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Layouts;
using KilnGod.PlotlyCharts.Traces;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Interop;

namespace KilnGod.PlotlyCharts.DemoTest.Pages;

public partial class PlotlyUpdateAudit : DemoBaseComponent
{
    private readonly List<PlotlyInteropMeasurement> _measurements = [];
    private readonly List<PlotlyInteropMeasurement> _threeDMeasurements = [];
    private Dictionary<string, PlotlyNumericArray>? _reusableThreeDFields;
    private PlotlyNumericBinaryField[]? _reusableThreeDStreamFields;
    private int _revision;

    public PlotlyChart Chart { get; set; } = null!;

    public PlotlyChart ThreeDChart { get; set; } = null!;

    public bool Ready { get; private set; }

    public string Status { get; private set; } = "Waiting for chart initialization.";

    public string ThreeDStatus { get; private set; } = "Waiting for 3D chart initialization.";

    public string NumericStatus { get; private set; } = "Waiting for numeric field audit.";

    public PlotlyInteropDiagnostics Diagnostics { get; }

    public PlotlyInteropDiagnostics ThreeDDiagnostics { get; }

    public PlotlyUpdateAudit()
    {
        Diagnostics = new PlotlyInteropDiagnostics { MeasurementRecorded = RecordMeasurement };
        ThreeDDiagnostics = new PlotlyInteropDiagnostics { MeasurementRecorded = RecordThreeDMeasurement };
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Chart.PlotlyInitComplete += ChartInitialized;
            ThreeDChart.PlotlyInitComplete += ThreeDChartInitialized;
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async void ChartInitialized(PlotlyChart chart)
    {
        Ready = true;
        await RunNewPlot();
        await InvokeAsync(StateHasChanged);
    }

    private async void ThreeDChartInitialized(PlotlyChart chart)
    {
        ThreeDReady = true;
        await Run3DNewPlot();
        await InvokeAsync(StateHasChanged);
    }

    public bool ThreeDReady { get; private set; }

    private async Task RunNewPlot()
    {
        var data = CreateData();
        var layout = CreateLayout();
        var config = CreateConfig();
        await Measure("newPlot", () => Chart.MeasurePlotlyFunction("newPlot", data.Values, layout.ValueItems, config.ValueItems));
    }

    private async Task RunReact()
    {
        var data = CreateData();
        var layout = CreateLayout();
        var config = CreateConfig();
        await Measure("react", () => Chart.MeasurePlotlyFunction("react", data.Values, layout.ValueItems, config.ValueItems));
    }

    private async Task RunDataUpdate()
    {
        dynamic update = new ExpandoObject();
        update.x = new[] { CreateX() };
        update.y = new[] { CreateY(1.0) };
        await Measure("update:data-only", () => Chart.MeasurePlotlyFunction("update", update, new Layout().ValueItems));
    }

    private async Task RunRestyle()
    {
        dynamic marker = new ExpandoObject();
        marker.color = "crimson";
        marker.size = 10;
        dynamic update = new ExpandoObject();
        update.marker = marker;
        await Measure("restyle:trace-style", () => Chart.MeasurePlotlyFunction("restyle", update, 0));
    }

    private async Task RunRelayout()
    {
        await Measure(
            "relayout:layout-only",
            () => Chart.MeasurePlotlyFunction("relayout", new Layout
            {
                Title = new TitleLayoutInfo { Text = $"Layout revision {++_revision}" },
                UiRevision = "plotly-update-audit"
            }.ValueItems));
    }

    private async Task RunMixedUpdate()
    {
        dynamic update = new ExpandoObject();
        update.x = new[] { CreateX() };
        update.y = new[] { CreateY(2.0) };
        await Measure(
            "update:mixed",
            () => Chart.MeasurePlotlyFunction("update", update, new Layout
            {
                Title = new TitleLayoutInfo { Text = $"Mixed revision {++_revision}" },
                UiRevision = "plotly-update-audit"
            }.ValueItems));
    }

    private async Task RunResize()
    {
        var before = _measurements.Count;
        await Chart.ResizePlotlyChart();
        var measurement = GetLatestMeasurement(before);
        Status = measurement is null
            ? "Resize completed."
            : $"resize: interop={measurement.Elapsed.TotalMilliseconds:F1} ms, payload={measurement.PayloadBytes} B";
        await InvokeAsync(StateHasChanged);
    }

    private async Task RunResizeBurst()
    {
        const int requested = 25;
        var before = Diagnostics.CallCount;
        var stopwatch = Stopwatch.StartNew();
        var requests = Enumerable.Range(0, requested)
            .Select(_ => Chart.ResizePlotlyChart().AsTask())
            .ToArray();
        var canceled = 0;
        try
        {
            await Task.WhenAll(requests);
        }
        catch (OperationCanceledException)
        {
            canceled = requests.Count(static request => request.IsCanceled);
        }

        stopwatch.Stop();
        var issued = Diagnostics.CallCount - before;
        Status = $"resize burst: requested={requested}, issued={issued}, canceled={canceled}, " +
            $"wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms";
        await InvokeAsync(StateHasChanged);
    }

    private async Task RunLosslessTraceBurst()
    {
        var trace = new Dictionary<string, object>
        {
            ["x"] = new[] { 0d, 1d },
            ["y"] = new[] { 0d, 1d },
            ["name"] = "queued-trace"
        };
        var before = Diagnostics.CallCount;
        var stopwatch = Stopwatch.StartNew();
        var addOne = Chart.SetFunctionPlotlyChart("addTraces", new object[] { trace });
        var addTwo = Chart.SetFunctionPlotlyChart("addTraces", new object[] { trace });
        var remove = Chart.SetFunctionPlotlyChart("deleteTraces", new[] { 1, 2 });
        await Task.WhenAll(addOne.AsTask(), addTwo.AsTask(), remove.AsTask());
        stopwatch.Stop();
        var issued = Diagnostics.CallCount - before;
        var state = await Chart.GetPlotlyChartAuditState();
        Status = $"lossless trace burst: issued={issued}, wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"finalTraces={state?["traceCount"] ?? "unknown"}";
        await InvokeAsync(StateHasChanged);
    }

    private async Task RunResourceAudit()
    {
        var state = await Chart.GetPlotlyChartAuditState();
        var resources = state?["adapterResources"]?.AsObject();
        Status = resources is null
            ? "Resource audit unavailable."
            : $"adapter: initialized={resources["initialized"]}, handlers={resources["adapterEventHandlerCount"]}, " +
              $"resizeObservers={resources["resizeObserverCount"]}, windowHandlers={resources["windowHandlerCount"]}, " +
              $"timers={resources["timerCount"]}; Plotly handlers={state?["eventHandlerCount"]}";
        await InvokeAsync(StateHasChanged);
    }

    private async Task RunLifecycleCycles()
    {
        var result = await Chart.MeasurePlotlyLifecycle(5);
        Status = $"lifecycle: cycles={result?["cycles"]}, " +
            $"retainedDomDelta={result?["retainedDomNodeDelta"]}, " +
            $"retainedSvgDelta={result?["retainedSvgDelta"]}, " +
            $"retainedCanvasDelta={result?["retainedCanvasDelta"]}, " +
            $"memoryBefore={result?["memoryBefore"]}, memoryAfter={result?["memoryAfter"]}";
        await InvokeAsync(StateHasChanged);
    }

    private async Task Run3DNewPlot()
    {
        var data = Create3DData();
        var layout = Create3DLayout();
        var config = CreateConfig();
        await Measure3D("3D newPlot", () => ThreeDChart.MeasurePlotlyFunction("newPlot", data.Values, layout.ValueItems, config.ValueItems));
    }

    private async Task Seed3DCamera()
    {
        await Measure3D(
            "3D camera",
            () => ThreeDChart.MeasurePlotlyFunction("relayout", new Layout
            {
                Scene = new SceneInfo
                {
                    UiRevision = "plotly-3d-audit",
                    Camera = new CameraInfo
                    {
                        Eye = new PositionInfo { X = 1.45, Y = 1.25, Z = 0.85 }
                    }
                }
            }.ValueItems));
    }

    private async Task Run3DRestyle()
    {
        dynamic marker = new ExpandoObject();
        marker.size = 8;
        marker.color = "darkorange";
        dynamic update = new ExpandoObject();
        update.marker = marker;
        await Measure3D("3D restyle", () => ThreeDChart.MeasurePlotlyFunction("restyle", update, 0));
    }

    private async Task Run3DRelayout()
    {
        await Measure3D(
            "3D relayout",
            () => ThreeDChart.MeasurePlotlyFunction("relayout", new Layout
            {
                Title = new TitleLayoutInfo { Text = "3D camera preserved" },
                UiRevision = "plotly-3d-audit"
            }.ValueItems));
    }

    private async Task Run3DAnimate()
    {
        dynamic frameTrace = new ExpandoObject();
        frameTrace.z = new[] { new[] { 0.5, 1.5, 2.5, 3.5, 4.5 } };
        dynamic frame = new ExpandoObject();
        frame.data = new[] { frameTrace };
        dynamic animation = new ExpandoObject();
        animation.frame = new ExpandoObject();
        animation.frame.duration = 150;
        animation.transition = new ExpandoObject();
        animation.transition.duration = 150;
        await Measure3D("3D animate", () => ThreeDChart.MeasurePlotlyFunction("animate", frame, animation));
    }

    private async Task Run3DNumericFields()
    {
        var fields = GetReusableThreeDFields();
        var before = _threeDMeasurements.Count;
        var stopwatch = Stopwatch.StartNew();
        await ThreeDChart.RestyleNumericFields(0, fields);
        stopwatch.Stop();
        var measurement = GetLatestThreeDMeasurement(before);
        NumericStatus = $"3D x/y/z byte fields (reused): wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"alloc={measurement?.AllocatedBytes ?? -1} bytes, payload={measurement?.PayloadBytes ?? -1} bytes";
        await InvokeAsync(StateHasChanged);
    }

    private async Task Run3DGenericFields()
    {
        const int count = 10_000;
        var x = Enumerable.Range(0, count).Select(static index => (double)index).ToArray();
        var y = x.Select(static value => Math.Sin(value / 35d)).ToArray();
        var z = x.Select(static value => Math.Cos(value / 45d)).ToArray();
        dynamic update = new ExpandoObject();
        update.x = x;
        update.y = y;
        update.z = z;
        await Measure3D(
            "3D generic x/y/z 10K",
            () => ThreeDChart.MeasurePlotlyFunction("restyle", update, 0));
    }

    private async Task Run3DXOnlyNumericArray()
    {
        const int count = 10_000;
        var x = Enumerable.Range(0, count).Select(static index => (double)index).ToArray();
        var before = _threeDMeasurements.Count;
        var stopwatch = Stopwatch.StartNew();
        await ThreeDChart.RestyleNumericArrays(0, PlotlyNumericArray.FromDouble(x));
        stopwatch.Stop();
        var measurement = GetLatestThreeDMeasurement(before);
        NumericStatus = $"3D x-only optional payload: wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"alloc={measurement?.AllocatedBytes ?? -1} bytes, payload={measurement?.PayloadBytes ?? -1} bytes";
        await InvokeAsync(StateHasChanged);
    }

    private async Task Run3DHostTunedFields()
    {
        var fields = GetReusableThreeDStreamFields();
        var before = _threeDMeasurements.Count;
        var stopwatch = Stopwatch.StartNew();
        var packetBytes = await ThreeDChart.RestyleNumericFieldsForHost(0, fields);
        stopwatch.Stop();
        var measurement = GetLatestThreeDMeasurement(before);
        var transport = ThreeDChart.IsWebAssembly ? "WebAssembly byte" : "Server stream";
        NumericStatus = $"3D host-tuned ({transport}): wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"alloc={measurement?.AllocatedBytes ?? -1} bytes, " +
            $"payload={(packetBytes >= 0 ? $"{packetBytes} packet bytes" : $"{measurement?.PayloadBytes ?? -1} bytes")}";
        await InvokeAsync(StateHasChanged);
    }

    private async Task Run3DStreamFields()
    {
        var fields = GetReusableThreeDStreamFields();
        var before = _threeDMeasurements.Count;
        var stopwatch = Stopwatch.StartNew();
        var packetBytes = await ThreeDChart.RestyleNumericStream(0, fields);
        stopwatch.Stop();
        var measurement = GetLatestThreeDMeasurement(before);
        NumericStatus = $"3D x/y/z stream (reused): wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"alloc={measurement?.AllocatedBytes ?? -1} bytes, packet={packetBytes} bytes";
        await InvokeAsync(StateHasChanged);
    }

    private Dictionary<string, PlotlyNumericArray> GetReusableThreeDFields()
    {
        if (_reusableThreeDFields is not null)
        {
            return _reusableThreeDFields;
        }

        const int count = 10_000;
        var x = Enumerable.Range(0, count).Select(static index => (double)index).ToArray();
        var y = x.Select(static value => Math.Sin(value / 35d)).ToArray();
        var z = x.Select(static value => Math.Cos(value / 45d)).ToArray();
        return _reusableThreeDFields = new Dictionary<string, PlotlyNumericArray>(StringComparer.Ordinal)
        {
            ["x"] = PlotlyNumericArray.FromDouble(x),
            ["y"] = PlotlyNumericArray.FromDouble(y),
            ["z"] = PlotlyNumericArray.FromDouble(z)
        };
    }

    private PlotlyNumericBinaryField[] GetReusableThreeDStreamFields()
    {
        if (_reusableThreeDStreamFields is not null)
        {
            return _reusableThreeDStreamFields;
        }

        var fields = GetReusableThreeDFields();
        return _reusableThreeDStreamFields =
        [
            new PlotlyNumericBinaryField("x", fields["x"]),
            new PlotlyNumericBinaryField("y", fields["y"]),
            new PlotlyNumericBinaryField("z", fields["z"])
        ];
    }

    private async Task RunHeatmapMatrix()
    {
        const int rows = 128;
        const int columns = 128;
        var matrix = Enumerable.Range(0, rows)
            .Select(row => Enumerable.Range(0, columns)
                .Select(column => Math.Sin(row / 12d) * Math.Cos(column / 14d))
                .ToArray())
            .ToArray();
        dynamic trace = new ExpandoObject();
        trace.type = "heatmap";
        trace.z = matrix;
        var layout = new Layout { Title = new TitleLayoutInfo { Text = "Numeric matrix audit" } };
        await Chart.SetFunctionPlotlyChart("newPlot", new object[] { trace }, layout.ValueItems);

        var flat = matrix.SelectMany(static row => row).ToArray();
        var before = _measurements.Count;
        var stopwatch = Stopwatch.StartNew();
        await Chart.RestyleNumericMatrix(0, "z", PlotlyNumericArray.FromDouble(flat), rows, columns);
        stopwatch.Stop();
        var measurement = GetLatestMeasurement(before);
        NumericStatus = $"heatmap z matrix {rows}x{columns}: wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, payload={measurement?.PayloadBytes ?? -1} bytes";
        await InvokeAsync(StateHasChanged);
    }

    private async Task RunFinancialNumericFields()
    {
        const int count = 10_000;
        var x = Enumerable.Range(0, count).Select(static index => $"2026-01-{(index % 28) + 1:00}").ToArray();
        var open = Enumerable.Range(0, count).Select(static index => 100d + index / 100d).ToArray();
        var high = open.Select(static value => value + 2d).ToArray();
        var low = open.Select(static value => value - 2d).ToArray();
        var close = open.Select(static value => value + 0.5d).ToArray();
        dynamic trace = new ExpandoObject();
        trace.type = "ohlc";
        trace.x = x;
        trace.open = open;
        trace.high = high;
        trace.low = low;
        trace.close = close;
        await Chart.SetFunctionPlotlyChart("newPlot", new object[] { trace }, new Layout().ValueItems);

        var before = _measurements.Count;
        var stopwatch = Stopwatch.StartNew();
        await Chart.RestyleNumericFields(0, new Dictionary<string, PlotlyNumericArray>
        {
            ["open"] = PlotlyNumericArray.FromDouble(open),
            ["high"] = PlotlyNumericArray.FromDouble(high),
            ["low"] = PlotlyNumericArray.FromDouble(low),
            ["close"] = PlotlyNumericArray.FromDouble(close)
        });
        stopwatch.Stop();
        var measurement = GetLatestMeasurement(before);
        NumericStatus = $"financial OHLC 10K fields: wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, payload={measurement?.PayloadBytes ?? -1} bytes";
        await InvokeAsync(StateHasChanged);
    }

    private async Task RunQuiverNumericFields()
    {
        const int count = 2_500;
        var x = Enumerable.Range(0, count).Select(static index => (double)(index % 50)).ToArray();
        var y = Enumerable.Range(0, count).Select(static index => (double)(index / 50)).ToArray();
        var u = x.Select(static value => Math.Cos(value / 8d)).ToArray();
        var v = y.Select(static value => Math.Sin(value / 8d)).ToArray();
        dynamic trace = new ExpandoObject();
        trace.type = "quiver";
        trace.x = x;
        trace.y = y;
        trace.u = u;
        trace.v = v;
        await Chart.SetFunctionPlotlyChart("newPlot", new object[] { trace }, new Layout().ValueItems);

        var before = _measurements.Count;
        var stopwatch = Stopwatch.StartNew();
        await Chart.RestyleNumericFields(0, new Dictionary<string, PlotlyNumericArray>
        {
            ["x"] = PlotlyNumericArray.FromDouble(x),
            ["y"] = PlotlyNumericArray.FromDouble(y),
            ["u"] = PlotlyNumericArray.FromDouble(u),
            ["v"] = PlotlyNumericArray.FromDouble(v)
        });
        stopwatch.Stop();
        var measurement = GetLatestMeasurement(before);
        NumericStatus = $"Quiver 2.5K x/y/u/v fields: wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, payload={measurement?.PayloadBytes ?? -1} bytes";
        await InvokeAsync(StateHasChanged);
    }

    private async Task Measure(string operation, Func<ValueTask<JsonObject?>> action)
    {
        var before = _measurements.Count;
        var stopwatch = Stopwatch.StartNew();
        var browserMeasurement = await action();
        stopwatch.Stop();

        var measurement = GetLatestMeasurement(before);
        var state = await Chart.GetPlotlyChartAuditState();
        Status = $"{operation}: wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"payload={measurement?.PayloadBytes ?? -1} bytes, " +
            $"browser={FormatBrowserMeasurement(browserMeasurement)}, state={FormatState(state)}";
        await InvokeAsync(StateHasChanged);
    }

    private void RecordMeasurement(PlotlyInteropMeasurement measurement)
    {
        lock (_measurements)
        {
            _measurements.Add(measurement);
            if (_measurements.Count > 64)
            {
                _measurements.RemoveAt(0);
            }
        }
    }

    private void RecordThreeDMeasurement(PlotlyInteropMeasurement measurement)
    {
        lock (_threeDMeasurements)
        {
            _threeDMeasurements.Add(measurement);
            if (_threeDMeasurements.Count > 32)
            {
                _threeDMeasurements.RemoveAt(0);
            }
        }
    }

    private PlotlyInteropMeasurement? GetLatestMeasurement(int before)
    {
        lock (_measurements)
        {
            return _measurements.Count > before ? _measurements[^1] : null;
        }
    }

    private PlotlyInteropMeasurement? GetLatestThreeDMeasurement(int before)
    {
        lock (_threeDMeasurements)
        {
            return _threeDMeasurements.Count > before ? _threeDMeasurements[^1] : null;
        }
    }

    private async Task Measure3D(string operation, Func<ValueTask<JsonObject?>> action)
    {
        var before = _threeDMeasurements.Count;
        var stopwatch = Stopwatch.StartNew();
        var browserMeasurement = await action();
        stopwatch.Stop();

        var measurement = GetLatestThreeDMeasurement(before);
        var state = await ThreeDChart.GetPlotlyChartAuditState();
        ThreeDStatus = $"{operation}: wall={stopwatch.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"interop={measurement?.Elapsed.TotalMilliseconds:0.##} ms, " +
            $"alloc={measurement?.AllocatedBytes ?? -1} bytes, " +
            $"payload={measurement?.PayloadBytes ?? -1} bytes, " +
            $"browser={FormatBrowserMeasurement(browserMeasurement)}, state={FormatState(state)}";
        await InvokeAsync(StateHasChanged);
    }

    private static string FormatState(JsonObject? state)
    {
        if (state is null)
        {
            return "unavailable";
        }

        return $"traces={state["traceCount"]}, points={state["pointCounts"]}, " +
            $"uids={state["traceUids"]}, xRange={state["xRange"]}, " +
            $"yRange={state["yRange"]}, camera={state["sceneCamera"]}, " +
            $"events={state["eventNames"]}";
    }

    private static string FormatBrowserMeasurement(JsonObject? measurement)
    {
        if (measurement is null)
        {
            return "unavailable";
        }

        return $"plotly={measurement["plotlyDurationMs"]}ms, " +
            $"frame={measurement["frameDurationMs"]}ms, " +
            $"reflow={measurement["layoutDurationMs"]}ms, " +
            $"domΔ={measurement["domNodeDelta"]}, canvasΔ={measurement["canvasDelta"]}, " +
            $"handlersΔ={measurement["eventHandlerDelta"]}";
    }

    private TraceList CreateData()
    {
        var trace = new ScatterTrace
        {
            X = CreateX(),
            Y = CreateY(_revision),
            Mode = [ModeScatterOptions.Lines, ModeScatterOptions.Markers],
            Name = "audit-trace",
            UIRevision = "audit-trace"
        };
        (trace.ValueItems as dynamic).uid = "audit-trace-0";
        return new TraceList(trace);
    }

    private Layout CreateLayout() => new()
    {
        Title = new TitleLayoutInfo { Text = "Plotly update-shape audit" },
        UiRevision = "plotly-update-audit"
    };

    private static ConfigInfo CreateConfig() => new() { Responsive = true };

    private static TraceList Create3DData()
    {
        var trace = new Scatter3DTrace
        {
            X = new[] { 0d, 1d, 2d, 3d, 4d },
            Y = new[] { 0d, 1d, 0d, 1d, 0d },
            Z = new[] { 0d, 1d, 2d, 3d, 4d },
            Mode = [ModeScatterOptions.Lines, ModeScatterOptions.Markers],
            Name = "audit-3d-trace",
            UIRevision = "audit-3d-trace"
        };
        (trace.ValueItems as dynamic).uid = "audit-3d-trace-0";
        return new TraceList(trace);
    }

    private static Layout Create3DLayout() => new()
    {
        Title = new TitleLayoutInfo { Text = "3D/WebGL update audit" },
        UiRevision = "plotly-3d-audit",
        Scene = new SceneInfo
        {
            UiRevision = "plotly-3d-audit",
            Camera = new CameraInfo
            {
                Eye = new PositionInfo { X = 1.25, Y = 1.25, Z = 0.8 }
            }
        }
    };

    private static double[] CreateX() => Enumerable.Range(0, 1000).Select(index => (double)index).ToArray();

    private static double[] CreateY(double offset) => Enumerable.Range(0, 1000)
        .Select(index => Math.Sin(index / 35d) + offset)
        .ToArray();
}
#endif
