//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TitleInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class TitleInfo : ValuesObject
	{

		public TitleInfo() : base() { }

		FontInfo? _Font = null;
		public FontInfo? Font
		{
			get { return _Font; }
			set
			{
				_Font = value;
				(ValueItems as dynamic).font = _Font?.ValueItems;
			}
		}

		public SideOptions? Side
		{
			get { return EnumerationStatic.GetValueFromDescription<SideOptions>((ValueItems as dynamic).side); }
			set { (ValueItems as dynamic).side = value?.GetDescription(); }
		}

		public string? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

	}
}
