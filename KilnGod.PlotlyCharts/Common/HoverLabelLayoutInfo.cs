//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HoverLabelLayoutInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class HoverLabelLayoutInfo : ValuesObject
	{

		public HoverLabelLayoutInfo():base()		{		}

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

		GroupTitleFontInfo? _GroupTitleFont = null;
		public GroupTitleFontInfo? GroupTitleFont
		{
			get { return _GroupTitleFont; }
			set
			{
				_GroupTitleFont = value;
				(ValueItems as dynamic).grouptitlefont = _GroupTitleFont?.ValueItems;
			}
		}

		public int? NameLength
		{
			get { return (ValueItems as dynamic).namelength; }
			set { (ValueItems as dynamic).namelength = value; }
		}

	}
}

