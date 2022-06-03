//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AggregationItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{
	public class AggregationItem : ValuesObject
	{

		public AggregationItem() : base() { }

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}
		
		public FuncOptions? Func
		{
			get { return EnumerationStatic.GetValueFromDescription<FuncOptions>((ValueItems as dynamic).func); }
			set { (ValueItems as dynamic).func = value?.GetDescription(); }
		}
		

		public FuncModeOptions? FuncMode
		{
			get { return EnumerationStatic.GetValueFromDescription<FuncModeOptions>((ValueItems as dynamic).funcmode); }
			set { (ValueItems as dynamic).funcmode = value?.GetDescription(); }
		}
		

		public string? Target
		{
			get { return (ValueItems as dynamic).target; }
			set { (ValueItems as dynamic).target = value; }
		}

	}

}
