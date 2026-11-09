//***********************************************************************************
// KilnGod.PlotlyCharts
//
// File: DensityMapTrace.cs
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    /// <summary>MapLibre density trace supported by Plotly.js 4.2.0.</summary>
    public class DensityMapTrace : Trace
    {
        public DensityMapTrace() : base(TraceOptions.DensityMap) { }
        public object? Lon { get => (ValueItems as dynamic).lon; set => (ValueItems as dynamic).lon = value; }
        public object? Lat { get => (ValueItems as dynamic).lat; set => (ValueItems as dynamic).lat = value; }
        public object? Z { get => (ValueItems as dynamic).z; set => (ValueItems as dynamic).z = value; }
        public double? Radius { get => (ValueItems as dynamic).radius; set => (ValueItems as dynamic).radius = value; }
        public object? ColorScale { get => (ValueItems as dynamic).colorscale; set => (ValueItems as dynamic).colorscale = value; }
        public bool? ShowScale { get => (ValueItems as dynamic).showscale; set => (ValueItems as dynamic).showscale = value; }
        public string? Name { get => (ValueItems as dynamic).name; set => (ValueItems as dynamic).name = value; }
        public double? Opacity { get => (ValueItems as dynamic).opacity; set => (ValueItems as dynamic).opacity = value; }
        public string? Subplot { get => (ValueItems as dynamic).subplot; set => (ValueItems as dynamic).subplot = value; }
    }
}
