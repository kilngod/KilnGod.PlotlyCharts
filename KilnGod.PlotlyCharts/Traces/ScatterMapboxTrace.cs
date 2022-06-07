//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterMapbox.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ScatterMapboxTrace : Trace
    {
        public ScatterMapboxTrace() : base(TraceTypeOptions.Map_ScatterMapBox)
        {

        }
        public object? Lat
        {
            get { return (ValueItems as dynamic).lat; }
            set { (ValueItems as dynamic).lat = value; }
        }

        public object? Lon
        {
            get { return (ValueItems as dynamic).lon; }
            set { (ValueItems as dynamic).lon = value; }
        }

    }
}
