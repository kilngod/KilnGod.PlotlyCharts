//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: IndicatorTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layout;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class StreamTubeTrace : Trace
    {
        //https://plotly.com/javascript/streamtube-plot/
        public StreamTubeTrace() : base(TraceTypeOptions.ThreeD_StreamTube)
        {

        }

        public object? X
        {
            get { return (ValueItems as dynamic).x; }
            set { (ValueItems as dynamic).x = value; }
        }


        public object? Y
        {
            get { return (ValueItems as dynamic).y; }
            set { (ValueItems as dynamic).y = value; }
        }

        public object? Z
        {
            get { return (ValueItems as dynamic).z; }
            set { (ValueItems as dynamic).z = value; }
        }
        public object? U
        {
            get { return (ValueItems as dynamic).u; }
            set { (ValueItems as dynamic).u = value; }
        }


        public object? V
        {
            get { return (ValueItems as dynamic).v; }
            set { (ValueItems as dynamic).v = value; }
        }

        public object? W
        {
            get { return (ValueItems as dynamic).w; }
            set { (ValueItems as dynamic).w = value; }
        }

        public bool? AutoColorScale
        {
            get { return (ValueItems as dynamic).autocolorscale; }
            set { (ValueItems as dynamic).autocolorscale = value; }
        }
        public object? ColorScale
        {
            get { return (ValueItems as dynamic).colorscale; }
            set { (ValueItems as dynamic).colorscale = value; }
        }

        public int? MaxDisplayed
        {
            get { return (ValueItems as dynamic).maxdisplayed; }
            set { (ValueItems as dynamic).maxdisplayed = value; }
        }

        public double? SizeRef
        {
            get { return (ValueItems as dynamic).sizeref; }
            set { (ValueItems as dynamic).sizeref = value; }
        }

        PositionInfo? _Starts = null;
        public PositionInfo? Starts
        {
            get { return _Starts; }
            set
            {
                _Starts = value;
                (ValueItems as dynamic).starts = _Starts?.ValueItems;
            }
        }


        public bool? ShowScale
        {
            get { return (ValueItems as dynamic).showscale; }
            set { (ValueItems as dynamic).showscale = value; }
        }
    }
}
