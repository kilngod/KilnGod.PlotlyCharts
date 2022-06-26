//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    internal class ScatterPolarGLTrace : Trace
    {
        public ScatterPolarGLTrace() : base(TraceTypeOptions.Specialized_ScatterPolarGl)
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
