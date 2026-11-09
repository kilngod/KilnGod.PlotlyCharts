//***********************************************************************************
// KilnGod.PlotlyCharts
//
// File: MapInfo.cs
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Common
{
    /// <summary>MapLibre layout configuration for Plotly.js map subplots.</summary>
    public class MapInfo : ValuesObject
    {
        public object? Center { get => (ValueItems as dynamic).center; set => (ValueItems as dynamic).center = value is ValuesObject item ? item.ValueItems : value; }
        public object? Domain { get => (ValueItems as dynamic).domain; set => (ValueItems as dynamic).domain = value is ValuesObject item ? item.ValueItems : value; }
        public object? FitBounds { get => (ValueItems as dynamic).fitbounds; set => (ValueItems as dynamic).fitbounds = value; }
        public double? Bearing { get => (ValueItems as dynamic).bearing; set => (ValueItems as dynamic).bearing = value; }
        public double? Pitch { get => (ValueItems as dynamic).pitch; set => (ValueItems as dynamic).pitch = value; }
        public object? Style { get => (ValueItems as dynamic).style; set => (ValueItems as dynamic).style = value; }
        public double? Zoom { get => (ValueItems as dynamic).zoom; set => (ValueItems as dynamic).zoom = value; }
    }
}
