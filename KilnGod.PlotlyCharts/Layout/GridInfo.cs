//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GridInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
	public class GridInfo : ValuesObject
	{

		public GridInfo() : base() { }

		public int? Columns
		{
			get { return (ValueItems as dynamic).columns; }
			set { (ValueItems as dynamic).columns = value; }
		}

		DomainInfo? _Domain = null;
		public DomainInfo? Domain
		{
			get { return _Domain; }
			set
			{
				_Domain = value;
				(ValueItems as dynamic).domain = _Domain?.ValueItems;
			}
		}

		public PatternOptions? Pattern
		{
			get { return EnumerationStatic.GetValueFromDescription<PatternOptions>((ValueItems as dynamic).pattern); }
			set { (ValueItems as dynamic).pattern = value?.GetDescription(); }
		}

		public RowOrderOptions? RowOrder
		{
			get { return EnumerationStatic.GetValueFromDescription<RowOrderOptions>((ValueItems as dynamic).roworder); }
			set { (ValueItems as dynamic).roworder = value?.GetDescription(); }
		}

		public int? Rows
		{
			get { return (ValueItems as dynamic).rows; }
			set { (ValueItems as dynamic).rows = value; }
		}

		public object? Subplots
		{
			get { return (ValueItems as dynamic).subplots; }
			set { (ValueItems as dynamic).subplots = value; }
		}

		public object? Xaxes
		{
			get { return (ValueItems as dynamic).xaxes; }
			set { (ValueItems as dynamic).xaxes = value; }
		}

		public double? Xgap
		{
			get { return (ValueItems as dynamic).xgap; }
			set { (ValueItems as dynamic).xgap = value; }
		}

		public XSideOptions? XSide
		{
			get { return EnumerationStatic.GetValueFromDescription<XSideOptions>((ValueItems as dynamic).xside); }
			set { (ValueItems as dynamic).xside = value?.GetDescription(); }
		}

		public object? Yaxes
		{
			get { return (ValueItems as dynamic).yaxes; }
			set { (ValueItems as dynamic).yaxes = value; }
		}

		public double? Ygap
		{
			get { return (ValueItems as dynamic).ygap; }
			set { (ValueItems as dynamic).ygap = value; }
		}

		public YSideOptions? YSide
		{
			get { return EnumerationStatic.GetValueFromDescription<YSideOptions>((ValueItems as dynamic).yside); }
			set { (ValueItems as dynamic).yside = value?.GetDescription(); }
		}

	}
}
