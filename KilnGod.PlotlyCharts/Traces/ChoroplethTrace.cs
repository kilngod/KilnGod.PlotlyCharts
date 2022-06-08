//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ChoroplethTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layout;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ChoroplethTrace : Trace
    {
        public ChoroplethTrace() : base(TraceTypeOptions.Map_Choropleth)
        {

        }

        public object? Z
        {
            get { return (ValueItems as dynamic).z; }
            set { (ValueItems as dynamic).z = value; }
        }

        public object? AutoColorScale
        {
            get { return (ValueItems as dynamic).autocolorscale; }
            set { (ValueItems as dynamic).autocolorscale = value; }
        }

   

        public object? ColorScale
        {
            get { return (ValueItems as dynamic).colorscale; }
            set { (ValueItems as dynamic).colorscale = value; }
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

        public object? ReverseScale
        {
            get { return (ValueItems as dynamic).reversescale; }
            set { (ValueItems as dynamic).reversescale = value; }
        }


        ItemList<TransformsItem>? _TransformsItems = null;
        public ItemList<TransformsItem>? Transforms
        {
            get
            {
                return _TransformsItems;
            }
            set
            {
                _TransformsItems = value;
                if (value != null)
                {
                    (ValueItems as dynamic).transforms = _TransformsItems?.Values;
                }
            }
        }

     
    }
}

