//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterTernyTrace.cs
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
    public class ScatterTernyTrace : Trace
    {
        public ScatterTernyTrace(): base(TraceTypeOptions.Specialized_ScatterTernary) { }

        public object? A
        {
            get { return (ValueItems as dynamic).a; }
            set { (ValueItems as dynamic).a = value; }
        }


        public object? B
        {
            get { return (ValueItems as dynamic).b; }
            set { (ValueItems as dynamic).b = value; }
        }

        public object? C
        {
            get { return (ValueItems as dynamic).c; }
            set { (ValueItems as dynamic).c = value; }
        }
    }
}
