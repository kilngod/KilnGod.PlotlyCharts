//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SymbolInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SymbolInfo : ValuesObject
	{

		public SymbolInfo():base()		{		}

		public string? Icon
		{
			get { return (ValueItems as dynamic).icon; }
			set { (ValueItems as dynamic).icon = value; }
		}

		public double? IconSize
		{
			get { return (ValueItems as dynamic).iconsize; }
			set { (ValueItems as dynamic).iconsize = value; }
		}

		public PlacementOptions? Placement
		{
			get { return EnumerationStatic.GetValueFromDescription<PlacementOptions> ((ValueItems as dynamic).placement); }
			set { (ValueItems as dynamic).placement = value?.GetDescription(); }
		}

		public string? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

		TextFontSymbolInfo? _TextFont = null;
		public TextFontSymbolInfo? TextFont
		{
			get { return _TextFont; }
			set
			{
				_TextFont = value;
				(ValueItems as dynamic).textfont = _TextFont?.ValueItems;
			}
		}

		public SymbolTextPositionOptions? TextPosition
		{
			get { return EnumerationStatic.GetValueFromDescription<SymbolTextPositionOptions> ((ValueItems as dynamic).textposition); }
			set { (ValueItems as dynamic).textposition = value?.GetDescription(); }
		}

	}
}

