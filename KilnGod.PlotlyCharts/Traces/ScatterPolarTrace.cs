//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterPolarTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ScatterPolarTrace : Trace
    {
        public ScatterPolarTrace() : base(TraceTypeOptions.Specialized_ScatterPolar)
        {

        }
        public object? R
        {
            get { return (ValueItems as dynamic).r; }
            set { (ValueItems as dynamic).r = value; }
        }

        public object? Theta
        {
            get { return (ValueItems as dynamic).theta; }
            set { (ValueItems as dynamic).theta = value; }
        }

    }
}
