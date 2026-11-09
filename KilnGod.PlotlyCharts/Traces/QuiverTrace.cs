//***********************************************************************************
// KilnGod.PlotlyCharts
//
// File: QuiverTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See License.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    /// <summary>A two-dimensional vector-field trace supported by Plotly.js 4.2.0.</summary>
    public class QuiverTrace : Trace
    {
        public QuiverTrace() : base(TraceOptions.Quiver) { }

        public object? X { get => (ValueItems as dynamic).x; set => (ValueItems as dynamic).x = value; }
        public object? Y { get => (ValueItems as dynamic).y; set => (ValueItems as dynamic).y = value; }
        public object? U { get => (ValueItems as dynamic).u; set => (ValueItems as dynamic).u = value; }
        public object? V { get => (ValueItems as dynamic).v; set => (ValueItems as dynamic).v = value; }

        public object? X0 { get => (ValueItems as dynamic).x0; set => (ValueItems as dynamic).x0 = value; }
        public object? Y0 { get => (ValueItems as dynamic).y0; set => (ValueItems as dynamic).y0 = value; }
        public double? DX { get => (ValueItems as dynamic).dx; set => (ValueItems as dynamic).dx = value; }
        public double? DY { get => (ValueItems as dynamic).dy; set => (ValueItems as dynamic).dy = value; }

        public double? LengthFactor { get => (ValueItems as dynamic).lengthfactor; set => (ValueItems as dynamic).lengthfactor = value; }
        public object? LengthMode { get => (ValueItems as dynamic).lengthmode; set => (ValueItems as dynamic).lengthmode = value; }
        public object? Anchor { get => (ValueItems as dynamic).anchor; set => (ValueItems as dynamic).anchor = value; }
        public object? ArrowRef { get => (ValueItems as dynamic).arrowref; set => (ValueItems as dynamic).arrowref = value; }

        public object? CustomData { get => (ValueItems as dynamic).customdata; set => (ValueItems as dynamic).customdata = value; }
        public object? HoverInfo { get => (ValueItems as dynamic).hoverinfo; set => (ValueItems as dynamic).hoverinfo = value; }
        public object? HoverLabel { get => (ValueItems as dynamic).hoverlabel; set => (ValueItems as dynamic).hoverlabel = value; }
        public object? HoverTemplate { get => (ValueItems as dynamic).hovertemplate; set => (ValueItems as dynamic).hovertemplate = value; }
        public object? Text { get => (ValueItems as dynamic).text; set => (ValueItems as dynamic).text = value; }
        public string? Name { get => (ValueItems as dynamic).name; set => (ValueItems as dynamic).name = value; }
        public double? Opacity { get => (ValueItems as dynamic).opacity; set => (ValueItems as dynamic).opacity = value; }
        public bool? ShowLegend { get => (ValueItems as dynamic).showlegend; set => (ValueItems as dynamic).showlegend = value; }
        public object? Visible { get => (ValueItems as dynamic).visible; set => (ValueItems as dynamic).visible = value; }
        public object? Marker { get => (ValueItems as dynamic).marker; set => (ValueItems as dynamic).marker = value; }
    }
}
