//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TitleAlignFontInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class TitleAlignFontInfo : ValuesObject
	{

		public TitleAlignFontInfo():base()		{		}

		public XAlignOptions? Align
		{
			get { return EnumerationStatic.GetValueFromDescription<XAlignOptions> ((ValueItems as dynamic).align); }
			set { (ValueItems as dynamic).align = value?.GetDescription(); }
		}

		FontTitleInfo? _Font = null;
		public FontTitleInfo? Font
		{
			get { return _Font; }
			set
			{
				_Font = value;
				(ValueItems as dynamic).font = _Font?.ValueItems;
			}
		}

		public string? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

	}
}

