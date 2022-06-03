//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BarPolarTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;


namespace KilnGod.PlotlyCharts.Traces
{
    public class BarPolarTrace : Trace
    {
        public BarPolarTrace() : base(TraceTypeOptions.Specialized_BarPolar)
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
