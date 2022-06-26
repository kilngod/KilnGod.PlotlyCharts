//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyChartExtensions.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.Text.Json.Nodes;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Configuration;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts
{
    public static class PlotlyChartExtensions
    {

        public async static ValueTask<JsonObject> validate(this PlotlyChart chart, object data, LayoutInfo layout) => await chart.GetFunctionPlotlyBasis<JsonObject>("validate", data, layout.ValueItems);

        public async static ValueTask<JsonObject> validateTemplate(this PlotlyChart chart, string templateName, object plotObject ) => await chart.GetFunctionPlotlyBasis<JsonObject>("validateTemplate", templateName, plotObject);

        public async static ValueTask makeTemplate(this PlotlyChart chart, string templateName, object plotObject) => await chart.SetFunctionPlotlyBasis("makeTemplate", templateName, plotObject);


        public async static ValueTask newPlot(this PlotlyChart chart, string templateName, object plotObject) => await chart.SetFunctionPlotlyBasis("newPlot", templateName, plotObject);


        public async static ValueTask react(this PlotlyChart chart, object data_or_plotObject) => await chart.SetFunctionPlotlyChart("react", data_or_plotObject);

        public async static ValueTask react(this PlotlyChart chart, TraceList data, LayoutInfo layout) => await chart.SetFunctionPlotlyChart("react", data.Values, layout.ValueItems);

        public async static ValueTask react(this PlotlyChart chart, TraceList data, LayoutInfo layout, ConfigInfo config) => await chart.SetFunctionPlotlyChart("react", data.Values, layout.ValueItems, config.ValueItems);


        public async static ValueTask newPlot(this PlotlyChart chart, TraceList data) => await chart.SetFunctionPlotlyChart("newPlot", data.Values);

        public async static ValueTask newPlot(this PlotlyChart chart, TraceList data, LayoutInfo layout) => await chart.SetFunctionPlotlyChart("newPlot", data.Values, layout.ValueItems);

        public async static ValueTask newPlot(this PlotlyChart chart, TraceList data, LayoutInfo layout, ConfigInfo config) => await chart.SetFunctionPlotlyChart("newPlot", data.Values, layout.ValueItems, config.ValueItems);

        public async static ValueTask purge(this PlotlyChart chart) => await chart.SetFunctionPlotlyChart("purge");

        public async static ValueTask update(this PlotlyChart chart, object data_update, LayoutInfo layout_update) => await chart.SetFunctionPlotlyChart("update", data_update, layout_update.ValueItems);

        public async static ValueTask relayout(this PlotlyChart chart, LayoutInfo layout_update) => await chart.SetFunctionPlotlyChart("relayout", layout_update.ValueItems);

        public async static ValueTask restyle(this PlotlyChart chart, object trace_update) => await chart.SetFunctionPlotlyChart("restyle", trace_update);
        public async static ValueTask restyle(this PlotlyChart chart, object trace_update, int trace) => await chart.SetFunctionPlotlyChart("restyle", trace_update, trace);
        public async static ValueTask restyle(this PlotlyChart chart, object trace_update, int[] traces) => await chart.SetFunctionPlotlyChart("restyle", trace_update, traces);

        public async static ValueTask animate(this PlotlyChart chart, object target_update, object animation_update) => await chart.SetFunctionPlotlyChart("animate", target_update, animation_update);


        // reorder traces
        public async static ValueTask moveTrace(this PlotlyChart chart, int traceIndex) => await chart.SetFunctionPlotlyChart("moveTrace", traceIndex);

        public async static ValueTask moveTrace(this PlotlyChart chart, int[] traceIndices) => await chart.SetFunctionPlotlyChart("moveTrace", traceIndices);

        public async static ValueTask moveTrace(this PlotlyChart chart, int fromTraceIndex, int toTraceIndex) => await chart.SetFunctionPlotlyChart("moveTrace", fromTraceIndex, toTraceIndex);

        public async static ValueTask moveTrace(this PlotlyChart chart, int[] fromTraceIndices, int[] toTraceIndices) => await chart.SetFunctionPlotlyChart("moveTrace", fromTraceIndices, toTraceIndices);


        public async static ValueTask addTraces(this PlotlyChart chart, object trace) => await chart.SetFunctionPlotlyChart("addTraces", trace);


        public async static ValueTask addTraces(this PlotlyChart chart, object[] traces) => await chart.SetFunctionPlotlyChart("addTraces", traces);


        public async static ValueTask addTraces(this PlotlyChart chart, object trace, int traceIndex) => await chart.SetFunctionPlotlyChart("addTraces", trace, traceIndex);

        public async static ValueTask deleteTraces(this PlotlyChart chart, int traceIndex) => await chart.SetFunctionPlotlyChart("deleteTraces", traceIndex);


        public async static ValueTask deleteTraces(this PlotlyChart chart, int[] traceIndices) => await chart.SetFunctionPlotlyChart("deleteTraces", traceIndices);


        public async static ValueTask extendTraces(this PlotlyChart chart, object[] traces , int[] traceIndices) => await chart.SetFunctionPlotlyChart("extendTraces", traces, traceIndices);

        public async static ValueTask extendTraces(this PlotlyChart chart, object[] traces, int[] traceIndices, int points) => await chart.SetFunctionPlotlyChart("extendTraces", traces, traceIndices, points);

        public async static ValueTask prependTraces(this PlotlyChart chart, object[] traces, int[] traceIndices) => await chart.SetFunctionPlotlyChart("prependTraces", traces, traceIndices);

        public async static ValueTask prependTraces(this PlotlyChart chart, object[] traces, int[] traceIndices, int points) => await chart.SetFunctionPlotlyChart("prependTraces", traces, traceIndices, points);

    }
}
