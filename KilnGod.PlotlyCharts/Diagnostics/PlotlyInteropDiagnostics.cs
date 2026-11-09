//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyInteropDiagnostics.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.Diagnostics;
using System.Collections.Concurrent;
using System.Text.Json;

namespace KilnGod.PlotlyCharts.Diagnostics;

public enum PlotlyInteropCallKind
{
    Unknown,
    Initialization,
    ValueAccess,
    GenericChartFunction,
    GenericBasisFunction,
    ChartUpdate,
    Event,
    Resize,
    Purge,
    Disposal
}

/// <summary>
/// Receives opt-in measurements for calls from a <see cref="PlotlyChart"/> into its
/// existing JavaScript module. The diagnostics object is supplied by the consumer so
/// normal charts pay no measurement or serialization cost.
/// </summary>
public sealed class PlotlyInteropDiagnostics
{
    private long _callCount;
    private long _payloadBytes;
    private long _allocatedBytes;
    private readonly ConcurrentDictionary<PlotlyInteropCallKind, long> _callsByKind = new();

    public bool IsEnabled { get; set; } = true;

    public string RunId { get; init; } = Guid.NewGuid().ToString("N");

    /// <summary>
    /// Called once after each measured module call. The callback must not mutate chart
    /// state or call back into the chart.
    /// </summary>
    public Action<PlotlyInteropMeasurement>? MeasurementRecorded { get; init; }

    public long CallCount => Interlocked.Read(ref _callCount);

    public long PayloadBytes => Interlocked.Read(ref _payloadBytes);

    public long AllocatedBytes => Interlocked.Read(ref _allocatedBytes);


    public IReadOnlyDictionary<PlotlyInteropCallKind, long> CallsByKind =>
        _callsByKind.ToDictionary(pair => pair.Key, pair => pair.Value);

    internal void Record(PlotlyInteropMeasurement measurement)
    {
        if (!IsEnabled)
        {
            return;
        }

        Interlocked.Increment(ref _callCount);
        Interlocked.Add(ref _payloadBytes, Math.Max(0, measurement.PayloadBytes));
        Interlocked.Add(ref _allocatedBytes, measurement.AllocatedBytes);
        _callsByKind.AddOrUpdate(measurement.Kind, 1, static (_, count) => count + 1);
        MeasurementRecorded?.Invoke(measurement);
    }

}

/// <summary>
/// One C#-side measurement for an invocation of the existing JavaScript module.
/// PayloadBytes is the UTF-8 JSON size of the arguments supplied by C#; it excludes
/// browser protocol framing and is -1 when an argument cannot be serialized by the
/// diagnostic estimator.
/// </summary>
public sealed record PlotlyInteropMeasurement(
    string RunId,
    string ChartId,
    long Revision,
    string Operation,
    PlotlyInteropCallKind Kind,
    int ArgumentCount,
    long PayloadBytes,
    long AllocatedBytes,
    TimeSpan Elapsed,
    bool Succeeded,
    string? ExceptionType);

internal static class PlotlyInteropMeasurementHelper
{
    internal static long GetPayloadBytes(object?[] arguments)
    {
        try
        {
            return JsonSerializer.SerializeToUtf8Bytes(arguments).LongLength;
        }
        catch (NotSupportedException)
        {
            return -1;
        }
        catch (JsonException)
        {
            return -1;
        }
        catch (InvalidOperationException)
        {
            // DotNetStreamReference intentionally is not a JSON payload. Its stream
            // is transferred by the Blazor transport after the invocation metadata.
            return -1;
        }
    }

    // JS interop awaits may resume on a different thread. Per-thread allocation
    // counters therefore produce zero or negative deltas for a single call. The
    // diagnostics path uses the process counter so async measurements remain stable.
    internal static long GetAllocatedBytes() => GC.GetTotalAllocatedBytes(precise: true);

    internal static Stopwatch StartTimer() => Stopwatch.StartNew();

    internal static PlotlyInteropCallKind Classify(string operation, object?[] arguments)
    {
        return operation switch
        {
            "initializePlotlyChart" => PlotlyInteropCallKind.Initialization,
            "setValuePlotlyChart" or "getValuePlotlyChart" => PlotlyInteropCallKind.ValueAccess,
            "disposePlotlyChart" => PlotlyInteropCallKind.Disposal,
            "setFunctionPlotlyBasis" or "getFunctionPlotlyBasis" => PlotlyInteropCallKind.GenericBasisFunction,
            "setFunctionPlotlyChart" or "getFunctionPlotlyChart" or "measureFunctionPlotlyChart" => ClassifyPlotlyFunction(arguments),
            "setFunctionPlotlyChartNumericArrays" or
                "setFunctionPlotlyChartNumericFields" or
                "setFunctionPlotlyChartNumericStream" => PlotlyInteropCallKind.ChartUpdate,
            _ => PlotlyInteropCallKind.Unknown
        };
    }

    private static PlotlyInteropCallKind ClassifyPlotlyFunction(object?[] arguments)
    {
        var functionName = arguments.Length > 1 ? arguments[1] as string : null;
        return functionName switch
        {
            "newPlot" or "react" or "update" or "restyle" or "relayout" or "animate" or
                "addTraces" or "deleteTraces" or "extendTraces" or "prependTraces" or
                "moveTrace" => PlotlyInteropCallKind.ChartUpdate,
            "purge" => PlotlyInteropCallKind.Purge,
            "resize" => PlotlyInteropCallKind.Resize,
            _ when functionName is not null &&
                (functionName.Contains("event", StringComparison.OrdinalIgnoreCase) ||
                 functionName.StartsWith("on", StringComparison.OrdinalIgnoreCase)) => PlotlyInteropCallKind.Event,
            _ => PlotlyInteropCallKind.GenericChartFunction
        };
    }
}
