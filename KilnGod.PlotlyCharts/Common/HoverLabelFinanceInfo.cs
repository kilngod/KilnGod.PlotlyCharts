//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HoverLabelFinanceInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class HoverLabelFinanceInfo : ValuesObject
	{

		public HoverLabelFinanceInfo():base()		{		}

		public HoverLabelAlignOptions? Align
		{
			get { return EnumerationStatic.GetValueFromDescription<HoverLabelAlignOptions> ((ValueItems as dynamic).align); }
			set { (ValueItems as dynamic).align = value?.GetDescription(); }
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

		FontLabelInfo? _Font = null;
		public FontLabelInfo? Font
		{
			get { return _Font; }
			set
			{
				_Font = value;
				(ValueItems as dynamic).font = _Font?.ValueItems;
			}
		}

		public int? NameLength
		{
			get { return (ValueItems as dynamic).namelength; }
			set { (ValueItems as dynamic).namelength = value; }
		}

		public bool? Split
		{
			get { return (ValueItems as dynamic).split; }
			set { (ValueItems as dynamic).split = value; }
		}

	}
}

