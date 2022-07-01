//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: RangeSliderAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class RangeSliderAxisInfo : ValuesObject
	{

		public RangeSliderAxisInfo():base()		{		}

		public object? Range
		{
			get { return (ValueItems as dynamic).range; }
			set { (ValueItems as dynamic).range = value; }
		}

		public RangeModeSliderOptions? RangeMode
		{
			get { return EnumerationStatic.GetValueFromDescription<RangeModeSliderOptions> ((ValueItems as dynamic).rangemode); }
			set { (ValueItems as dynamic).rangemode = value?.GetDescription(); }
		}

	}
}

