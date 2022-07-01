//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TitleFontPositionInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class TitleFontPositionInfo : ValuesObject
	{

		public TitleFontPositionInfo():base()		{		}

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

		public TitlePositionOptions? Position
		{
			get { return EnumerationStatic.GetValueFromDescription<TitlePositionOptions> ((ValueItems as dynamic).position); }
			set { (ValueItems as dynamic).position = value?.GetDescription(); }
		}

		public string? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

	}
}

