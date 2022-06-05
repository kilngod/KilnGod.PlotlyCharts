//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: IndicatorTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layout;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ChoroplethMapboxTrace : Trace
    {
        public ChoroplethMapboxTrace() : base(TraceTypeOptions.Map_ChoroplethMapBox)
        {

        }

        //https://plotly.com/python/mapbox-county-choropleth/


        public object? FeatureIdKey
        {
            get { return (ValueItems as dynamic).featureidkey; }
            set { (ValueItems as dynamic).featureidkey = value; }

        }


        CenterInfo? _CenterInfo = null;
        public CenterInfo? Center
        {
            get { return _CenterInfo; }
            set
            {
                _CenterInfo = value;
                (ValueItems as dynamic).center = _CenterInfo?.ValueItems;
            }

        }      

        public object? GeoJson
        {
            get { return (ValueItems as dynamic).geojson; }
            set { (ValueItems as dynamic).geojson = value; }
        }

        
        public object? Labels
        {
            get { return (ValueItems as dynamic).labels; }
            set { (ValueItems as dynamic).labels = value; }
        }


        public object? Locations
        {
            get { return (ValueItems as dynamic).locations; }
            set { (ValueItems as dynamic).locations = value; }
        }
        

        public object? Z
        {
            get { return (ValueItems as dynamic).z; }
            set { (ValueItems as dynamic).z = value; }
        }

        public double? Zmin
        {
            get { return (ValueItems as dynamic).zmin; }
            set { (ValueItems as dynamic).zmin = value; }
        }

        public double? Zmax
        {
            get { return (ValueItems as dynamic).zmax; }
            set { (ValueItems as dynamic).zmax = value; }
        }

    }
}
