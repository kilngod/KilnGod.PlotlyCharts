//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HistogramTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;

namespace KilnGod.PlotlyCharts.Traces
{
    internal class Histogram2D : Trace
    {
        public Histogram2D() : base(TraceTypeOptions.Distribution_Histogram2D)
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

    }
}
