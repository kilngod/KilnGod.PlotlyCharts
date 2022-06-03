//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: NewShapeInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;



namespace KilnGod.PlotlyCharts.Layout
{
    public class NewShapeInfo : ValuesObject
	{

		public NewShapeInfo() : base() { }

		public DrawDirectionOptions? DrawDirection
		{
			get { return EnumerationStatic.GetValueFromDescription<DrawDirectionOptions>((ValueItems as dynamic).drawdirection); }
			set { (ValueItems as dynamic).drawdirection = value?.GetDescription(); }
		}

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		public FillRuleOptions? FillRule
		{
			get { return EnumerationStatic.GetValueFromDescription<FillRuleOptions>((ValueItems as dynamic).fillrule); }
			set { (ValueItems as dynamic).fillrule = value?.GetDescription(); }
		}

		public LayerOptions? Layer
		{
			get { return EnumerationStatic.GetValueFromDescription<LayerOptions>((ValueItems as dynamic).layer); }
			set { (ValueItems as dynamic).layer = value?.GetDescription(); }
		}

		LineInfo? _Line = null;
		public LineInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		public object? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

	}

}
