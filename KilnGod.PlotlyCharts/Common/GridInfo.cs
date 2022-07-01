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
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class GridInfo : ValuesObject
	{

		public GridInfo():base()		{		}

		public int? Columns
		{
			get { return (ValueItems as dynamic).columns; }
			set { (ValueItems as dynamic).columns = value; }
		}

		GridDomainInfo? _Domain = null;
		public GridDomainInfo? Domain
		{
			get { return _Domain; }
			set
			{
				_Domain = value;
				(ValueItems as dynamic).domain = _Domain?.ValueItems;
			}
		}

		public GridPatternOptions? Pattern
		{
			get { return EnumerationStatic.GetValueFromDescription<GridPatternOptions> ((ValueItems as dynamic).pattern); }
			set { (ValueItems as dynamic).pattern = value?.GetDescription(); }
		}

		public RowOrderOptions? RowOrder
		{
			get { return EnumerationStatic.GetValueFromDescription<RowOrderOptions> ((ValueItems as dynamic).roworder); }
			set { (ValueItems as dynamic).roworder = value?.GetDescription(); }
		}

		public int? Rows
		{
			get { return (ValueItems as dynamic).rows; }
			set { (ValueItems as dynamic).rows = value; }
		}

		public double? XGap
		{
			get { return (ValueItems as dynamic).xgap; }
			set { (ValueItems as dynamic).xgap = value; }
		}

		public XSideOptions? XSide
		{
			get { return EnumerationStatic.GetValueFromDescription<XSideOptions> ((ValueItems as dynamic).xside); }
			set { (ValueItems as dynamic).xside = value?.GetDescription(); }
		}

		public double? YGap
		{
			get { return (ValueItems as dynamic).ygap; }
			set { (ValueItems as dynamic).ygap = value; }
		}

		public YSideOptions? YSide
		{
			get { return EnumerationStatic.GetValueFromDescription<YSideOptions> ((ValueItems as dynamic).yside); }
			set { (ValueItems as dynamic).yside = value?.GetDescription(); }
		}

	}
}

