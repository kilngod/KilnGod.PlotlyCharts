//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HoverLabelInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class HoverLabelInfo : ValuesObject
	{

		public HoverLabelInfo() : base() { }

		public AlignOptions? Align
		{
			get { return EnumerationStatic.GetValueFromDescription<AlignOptions>((ValueItems as dynamic).align); }
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

		public int? Namelength
		{
			get { return (ValueItems as dynamic).namelength; }
			set { (ValueItems as dynamic).namelength = value; }
		}


	}


}
