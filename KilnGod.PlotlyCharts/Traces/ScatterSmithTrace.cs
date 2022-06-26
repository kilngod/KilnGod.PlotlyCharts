//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterSmithTrace.cs
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
    public class ScatterSmithTrace : Trace
    {
        public ScatterSmithTrace() : base(TraceTypeOptions.Specialized_ScatterSmith)
        {
        }

        public object? Real
        {
            get { return (ValueItems as dynamic).real; }
            set { (ValueItems as dynamic).real = value; }
        }

        public object? Imaginary
        {
            get { return (ValueItems as dynamic).imag; }
            set { (ValueItems as dynamic).imag = value; }
        }
    }
}
