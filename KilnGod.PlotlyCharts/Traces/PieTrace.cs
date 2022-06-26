//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PieTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class PieTrace : Trace
    {
        public PieTrace(): base(TraceTypeOptions.Simple_Pie)
        {
            
        }
        public object? Labels
        {
            get { return (ValueItems as dynamic).labels; }
            set { (ValueItems as dynamic).labels = value; }
        }
        public object? Values
        {
            get { return (ValueItems as dynamic)?.values; }
            set { (ValueItems as dynamic).values = value; }
        }


    }
}
