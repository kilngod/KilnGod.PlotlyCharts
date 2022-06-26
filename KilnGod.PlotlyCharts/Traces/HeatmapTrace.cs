//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HeatmapTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class HeatmapTrace:Trace
    {
        public HeatmapTrace() : base(TraceTypeOptions.Simple_Heatmap)
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

    }
}

