//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: RangeSliderInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;



namespace KilnGod.PlotlyCharts.Layout
{


	public class RangeSliderInfo : ValuesObject
	{

		public RangeSliderInfo() : base() { }

		public bool? AutoRange
		{
			get { return (ValueItems as dynamic).autorange; }
			set { (ValueItems as dynamic).autorange = value; }
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		public object? BorderColor
		{
			get { return (ValueItems as dynamic).bordercolor; }
			set { (ValueItems as dynamic).bordercolor = value; }
		}

		public int? Borderwidth
		{
			get { return (ValueItems as dynamic).borderwidth; }
			set { (ValueItems as dynamic).borderwidth = value; }
		}

		public object? Range
		{
			get { return (ValueItems as dynamic).range; }
			set { (ValueItems as dynamic).range = value; }
		}

		public float? Thickness
		{
			get { return (ValueItems as dynamic).thickness; }
			set { (ValueItems as dynamic).thickness = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		RangeSliderYAxisInfo? _YAxis = null;
		public RangeSliderYAxisInfo? YAxis
		{
			get { return _YAxis; }
			set
			{
				_YAxis = value;
				(ValueItems as dynamic).yaxis = _YAxis?.ValueItems;
			}
		}

	}


}
