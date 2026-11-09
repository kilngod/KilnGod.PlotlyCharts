//***********************************************************************************
// KilnGod.PlotlyCharts
//
// File: ScatterMapTrace.cs
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    /// <summary>MapLibre scatter trace supported by Plotly.js 4.2.0.</summary>
    public class ScatterMapTrace : Trace
    {
        public ScatterMapTrace() : base(TraceOptions.ScatterMap) { }
        public object? Lon { get => (ValueItems as dynamic).lon; set => (ValueItems as dynamic).lon = value; }
        public object? Lat { get => (ValueItems as dynamic).lat; set => (ValueItems as dynamic).lat = value; }
        public object? Mode { get => (ValueItems as dynamic).mode; set => (ValueItems as dynamic).mode = value; }
        public object? Marker { get => (ValueItems as dynamic).marker; set => (ValueItems as dynamic).marker = value; }
        public object? Line { get => (ValueItems as dynamic).line; set => (ValueItems as dynamic).line = value; }
        public string? Name { get => (ValueItems as dynamic).name; set => (ValueItems as dynamic).name = value; }
        public object? Text { get => (ValueItems as dynamic).text; set => (ValueItems as dynamic).text = value; }
        public string? HoverTemplate { get => (ValueItems as dynamic).hovertemplate; set => (ValueItems as dynamic).hovertemplate = value; }
        public double? Opacity { get => (ValueItems as dynamic).opacity; set => (ValueItems as dynamic).opacity = value; }
        public string? Subplot { get => (ValueItems as dynamic).subplot; set => (ValueItems as dynamic).subplot = value; }
    }
}
