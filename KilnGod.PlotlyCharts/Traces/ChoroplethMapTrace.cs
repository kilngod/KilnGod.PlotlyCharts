//***********************************************************************************
// KilnGod.PlotlyCharts
//
// File: ChoroplethMapTrace.cs
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    /// <summary>MapLibre choropleth trace supported by Plotly.js 4.2.0.</summary>
    public class ChoroplethMapTrace : Trace
    {
        public ChoroplethMapTrace() : base(TraceOptions.ChoroplethMap) { }
        public object? GeoJson { get => (ValueItems as dynamic).geojson; set => (ValueItems as dynamic).geojson = value; }
        public object? Locations { get => (ValueItems as dynamic).locations; set => (ValueItems as dynamic).locations = value; }
        public object? Z { get => (ValueItems as dynamic).z; set => (ValueItems as dynamic).z = value; }
        public string? FeatureIdKey { get => (ValueItems as dynamic).featureidkey; set => (ValueItems as dynamic).featureidkey = value; }
        public object? ColorScale { get => (ValueItems as dynamic).colorscale; set => (ValueItems as dynamic).colorscale = value; }
        public bool? ShowScale { get => (ValueItems as dynamic).showscale; set => (ValueItems as dynamic).showscale = value; }
        public string? HoverTemplate { get => (ValueItems as dynamic).hovertemplate; set => (ValueItems as dynamic).hovertemplate = value; }
        public string? Name { get => (ValueItems as dynamic).name; set => (ValueItems as dynamic).name = value; }
        public string? Subplot { get => (ValueItems as dynamic).subplot; set => (ValueItems as dynamic).subplot = value; }
    }
}
