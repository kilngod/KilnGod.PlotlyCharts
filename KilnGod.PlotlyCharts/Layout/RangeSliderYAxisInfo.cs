//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: RangeSliderYAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;


namespace KilnGod.PlotlyCharts.Layout
{
    public class RangeSliderYAxisInfo : ValuesObject
    {

        public RangeSliderYAxisInfo() : base() { }


		public object? Range
		{
			get { return (ValueItems as dynamic).range; }
			set { (ValueItems as dynamic).range = value; }
		}


		public RangeModeOptions? RangeMode
		{
			get { return EnumerationStatic.GetValueFromDescription<RangeModeOptions>((ValueItems as dynamic).rangemode); }
            set { (ValueItems as dynamic).rangemode = value?.GetDescription();}
		}
    }
}
