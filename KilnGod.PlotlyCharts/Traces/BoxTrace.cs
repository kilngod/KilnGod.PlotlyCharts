//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BoxTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class BoxTrace : Trace
    {
        public BoxTrace(): base (TraceTypeOptions.Distribution_Box)
        {

        }

        public object? Y
        {
            get { return (ValueItems as dynamic).y; }
            set { (ValueItems as dynamic).y = value; }
        }


        public object? Jitter
        {
            get { return (ValueItems as dynamic).jitter; }
            set { (ValueItems as dynamic).jitter = value; }
        }

        public object? WhiskerWidth
        {
            get { return (ValueItems as dynamic).whiskerwidth; }
            set { (ValueItems as dynamic).whiskerwidth = value; }
        }

        public BoxPointsOptions? BoxPoints
        {
            get { return EnumerationStatic.GetValueFromDescription<BoxPointsOptions>((ValueItems as dynamic).boxpoints); }
            set { (ValueItems as dynamic).boxpoints = value?.GetDescription(); }
        }
    }
}
