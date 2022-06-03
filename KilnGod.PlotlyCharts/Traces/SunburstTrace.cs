//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SunburstTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;

namespace KilnGod.PlotlyCharts.Traces
{
    public class SunburstTrace : Trace
    {
        public SunburstTrace() : base(TraceTypeOptions.Specialized_Sunburst)
        {
        }

        public object? Ids
        {
            get { return (ValueItems as dynamic).ids; }
            set { (ValueItems as dynamic).ids = value; }
        }

        public object? Labels
        {
            get { return (ValueItems as dynamic).labels; }
            set { (ValueItems as dynamic).labels = value; }
        }

        public int? MaxDepth
        {
            get { return (ValueItems as dynamic).maxdepth; }
            set { (ValueItems as dynamic).maxdepth = value; }
        }
        public object? Parents
        {
            get { return (ValueItems as dynamic).parents; }
            set { (ValueItems as dynamic).parents = value; }
        }

        public TextPositionOptions? Side
        {
            get
            {
                var result = (ValueItems as dynamic).textposition;
                return EnumerationStatic.GetValueFromDescription(result) as TextPositionOptions?;

            }
            set { (ValueItems as dynamic).textposition = value?.GetDescription(); }
        }
        public InsideTextOrientationOptions? InsideTextOrientation
        {
            get
            {
                var result = (ValueItems as dynamic).insidetextorientation;
                return EnumerationStatic.GetValueFromDescription(result) as InsideTextOrientationOptions?;

            }
            set { (ValueItems as dynamic).insidetextorientation = value?.GetDescription(); }
        }
    }
}

