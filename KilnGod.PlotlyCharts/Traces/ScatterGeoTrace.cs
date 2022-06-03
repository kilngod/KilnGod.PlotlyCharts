//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterGeoTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ScatterGeoTrace : Trace
    {
        public ScatterGeoTrace() : base(TraceTypeOptions.Map_ScatterGeo)
        {

        }

        public object? Latitue
        {
            get { return (ValueItems as dynamic).lat; }
            set { (ValueItems as dynamic).lat = value; }
        }

        public object? Longitude
        {
            get { return (ValueItems as dynamic).lon; }
            set { (ValueItems as dynamic).lon = value; }
        }

        public object? Locations
        {
            get { return (ValueItems as dynamic).locations; }
            set { (ValueItems as dynamic).locations = value; }
        }

        public LocationModeOptions? LocationMode
        {
            get { return EnumerationStatic.GetValueFromDescription<LocationModeOptions>((ValueItems as dynamic).locationmode); }
            set { (ValueItems as dynamic).locationmode = value?.GetDescription(); }

        }
    }
}
