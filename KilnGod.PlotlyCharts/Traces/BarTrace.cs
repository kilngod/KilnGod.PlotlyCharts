//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BarTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class BarTrace : Trace
    {
        public BarTrace() : base(TraceTypeOptions.Simple_Bar)
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
