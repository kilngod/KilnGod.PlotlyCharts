//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ShapeItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class ShapeItem : ValuesObject
	{

		public ShapeItem():base()		{		}

		public bool? Editable
		{
			get { return (ValueItems as dynamic).editable; }
			set { (ValueItems as dynamic).editable = value; }
		}

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		public FillRuleOptions? FillRule
		{
			get { return EnumerationStatic.GetValueFromDescription<FillRuleOptions> ((ValueItems as dynamic).fillrule); }
			set { (ValueItems as dynamic).fillrule = value?.GetDescription(); }
		}

		public LayerOptions? Layer
		{
			get { return EnumerationStatic.GetValueFromDescription<LayerOptions> ((ValueItems as dynamic).layer); }
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

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public string? Path
		{
			get { return (ValueItems as dynamic).path; }
			set { (ValueItems as dynamic).path = value; }
		}

		public string? TemplateItemName
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public ShapeTypeOptions? Type
		{
			get { return EnumerationStatic.GetValueFromDescription<ShapeTypeOptions> ((ValueItems as dynamic).type); }
			set { (ValueItems as dynamic).type = value?.GetDescription(); }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		public object? X0
		{
			get { return (ValueItems as dynamic).x0; }
			set { (ValueItems as dynamic).x0 = value; }
		}

		public object? X1
		{
			get { return (ValueItems as dynamic).x1; }
			set { (ValueItems as dynamic).x1 = value; }
		}

		public object? XAnchor
		{
			get { return (ValueItems as dynamic).xanchor; }
			set { (ValueItems as dynamic).xanchor = value; }
		}

		public XRefOptions? XRef
		{
			get { return EnumerationStatic.GetValueFromDescription<XRefOptions> ((ValueItems as dynamic).xref); }
			set { (ValueItems as dynamic).xref = value?.GetDescription(); }
		}

		public ShapeSizeModeOptions? XSizeMode
		{
			get { return EnumerationStatic.GetValueFromDescription<ShapeSizeModeOptions> ((ValueItems as dynamic).xsizemode); }
			set { (ValueItems as dynamic).xsizemode = value?.GetDescription(); }
		}

		public object? Y0
		{
			get { return (ValueItems as dynamic).y0; }
			set { (ValueItems as dynamic).y0 = value; }
		}

		public object? Y1
		{
			get { return (ValueItems as dynamic).y1; }
			set { (ValueItems as dynamic).y1 = value; }
		}

		public object? YAnchor
		{
			get { return (ValueItems as dynamic).yanchor; }
			set { (ValueItems as dynamic).yanchor = value; }
		}

		public YRefOptions? YRef
		{
			get { return EnumerationStatic.GetValueFromDescription<YRefOptions> ((ValueItems as dynamic).yref); }
			set { (ValueItems as dynamic).yref = value?.GetDescription(); }
		}

		public ShapeSizeModeOptions? YSizeMode
		{
			get { return EnumerationStatic.GetValueFromDescription<ShapeSizeModeOptions> ((ValueItems as dynamic).ysizemode); }
			set { (ValueItems as dynamic).ysizemode = value?.GetDescription(); }
		}

	}
}

