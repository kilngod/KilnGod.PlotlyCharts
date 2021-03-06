//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: RangeBreakItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class RangeBreakItem : ValuesObject
	{

		public RangeBreakItem():base()		{		}

		public object? Bounds
		{
			get { return (ValueItems as dynamic).bounds; }
			set { (ValueItems as dynamic).bounds = value; }
		}

		public double? DValue
		{
			get { return (ValueItems as dynamic).dvalue; }
			set { (ValueItems as dynamic).dvalue = value; }
		}

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public RangeBreakPatternOptions? Pattern
		{
			get { return EnumerationStatic.GetValueFromDescription<RangeBreakPatternOptions> ((ValueItems as dynamic).pattern); }
			set { (ValueItems as dynamic).pattern = value?.GetDescription(); }
		}

		public string? TemplateItemName
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

	}
}

