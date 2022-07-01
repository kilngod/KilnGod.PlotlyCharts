//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PathBarInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class PathBarInfo : ValuesObject
	{

		public PathBarInfo():base()		{		}

		public EdgeShapeOptions? EdgeShape
		{
			get { return EnumerationStatic.GetValueFromDescription<EdgeShapeOptions> ((ValueItems as dynamic).edgeshape); }
			set { (ValueItems as dynamic).edgeshape = value?.GetDescription(); }
		}

		public TopBottomOptions? Side
		{
			get { return EnumerationStatic.GetValueFromDescription<TopBottomOptions> ((ValueItems as dynamic).side); }
			set { (ValueItems as dynamic).side = value?.GetDescription(); }
		}

		TextFontSizesInfo? _TextFont = null;
		public TextFontSizesInfo? TextFont
		{
			get { return _TextFont; }
			set
			{
				_TextFont = value;
				(ValueItems as dynamic).textfont = _TextFont?.ValueItems;
			}
		}

		public double? Thickness
		{
			get { return (ValueItems as dynamic).thickness; }
			set { (ValueItems as dynamic).thickness = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

	}
}

