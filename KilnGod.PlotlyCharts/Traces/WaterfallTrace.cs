//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: WaterfallTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;


namespace KilnGod.PlotlyCharts.Traces
{
    public class WaterfallTrace : Trace
    {
        public WaterfallTrace() : base (TraceTypeOptions.Finance_Waterfall)
        {

        }

        public OrientationOptions? Orientation
        {
            get { return EnumerationStatic.GetValueFromDescription<OrientationOptions>((ValueItems as dynamic).orientation); }
            set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
        }

        public object? X
        {
            get { return (ValueItems as dynamic).x; }
            set { (ValueItems as dynamic).x = value; }
        }
        public object? Y
        {
            get { return (ValueItems as dynamic).y; }
            set { (ValueItems as dynamic).y = value; }
        }

        public object? Measure
        {
            get { return (ValueItems as dynamic).measure; }
            set { (ValueItems as dynamic).measure = value; }
        }

       
    }
}
