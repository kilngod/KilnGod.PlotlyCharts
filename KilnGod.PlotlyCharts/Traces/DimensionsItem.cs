//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: DimensionItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;


namespace KilnGod.PlotlyCharts.Traces
{
	public class DimensionItem : ValuesObject
	{

		public DimensionItem() : base() { }

		public object? CategoryArray
		{
			get { return (ValueItems as dynamic).categoryarray; }
			set { (ValueItems as dynamic).categoryarray = value; }
		}

		public CategoryOrderOptions? CategoryOrder
		{
			get { return EnumerationStatic.GetValueFromDescription<CategoryOrderOptions>((ValueItems as dynamic).categoryorder); }
			set { (ValueItems as dynamic).categoryorder = value?.GetDescription(); }
		}

		public object? ConstraintRange
		{
			get { return (ValueItems as dynamic).constraintrange; }
			set { (ValueItems as dynamic).constraintrange = value; }
		}
		public int? Displayindex
		{
			get { return (ValueItems as dynamic).displayindex; }
			set { (ValueItems as dynamic).displayindex = value; }
		}

		public string? Label
		{
			get { return (ValueItems as dynamic).label; }
			set { (ValueItems as dynamic).label = value; }
		}

		public object? Range
		{
			get { return (ValueItems as dynamic).range; }
			set { (ValueItems as dynamic).range = value; }
		}

		public object? TickVals
		{
			get { return (ValueItems as dynamic).tickvals; }
			set { (ValueItems as dynamic).tickvals = value; }
		}

		public object? TickText
		{
			get { return (ValueItems as dynamic).ticktext; }
			set { (ValueItems as dynamic).ticktext = value; }
		}

		public object? Values
		{
			get { return (ValueItems as dynamic).values; }
			set { (ValueItems as dynamic).values = value; }
		}

	}
}
