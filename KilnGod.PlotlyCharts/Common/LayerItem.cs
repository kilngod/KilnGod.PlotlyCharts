//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LayerItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class LayerItem : ValuesObject
	{

		public LayerItem():base()		{		}

		public string? Below
		{
			get { return (ValueItems as dynamic).below; }
			set { (ValueItems as dynamic).below = value; }
		}

		CircleInfo? _Circle = null;
		public CircleInfo? Circle
		{
			get { return _Circle; }
			set
			{
				_Circle = value;
				(ValueItems as dynamic).circle = _Circle?.ValueItems;
			}
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public object? Coordinates
		{
			get { return (ValueItems as dynamic).coordinates; }
			set { (ValueItems as dynamic).coordinates = value; }
		}

		FillOutlineInfo? _Fill = null;
		public FillOutlineInfo? Fill
		{
			get { return _Fill; }
			set
			{
				_Fill = value;
				(ValueItems as dynamic).fill = _Fill?.ValueItems;
			}
		}

		LineDashesWidthInfo? _Line = null;
		public LineDashesWidthInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		public double? MaxZoom
		{
			get { return (ValueItems as dynamic).maxzoom; }
			set { (ValueItems as dynamic).maxzoom = value; }
		}

		public double? MinZoom
		{
			get { return (ValueItems as dynamic).minzoom; }
			set { (ValueItems as dynamic).minzoom = value; }
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

		public object? Source
		{
			get { return (ValueItems as dynamic).source; }
			set { (ValueItems as dynamic).source = value; }
		}

		public string? SourceAttribution
		{
			get { return (ValueItems as dynamic).sourceattribution; }
			set { (ValueItems as dynamic).sourceattribution = value; }
		}

		public string? SourceLayer
		{
			get { return (ValueItems as dynamic).sourcelayer; }
			set { (ValueItems as dynamic).sourcelayer = value; }
		}

		public SourceTypeOptions? SourceType
		{
			get { return EnumerationStatic.GetValueFromDescription<SourceTypeOptions> ((ValueItems as dynamic).sourcetype); }
			set { (ValueItems as dynamic).sourcetype = value?.GetDescription(); }
		}

		SymbolInfo? _Symbol = null;
		public SymbolInfo? Symbol
		{
			get { return _Symbol; }
			set
			{
				_Symbol = value;
				(ValueItems as dynamic).symbol = _Symbol?.ValueItems;
			}
		}

		public string? TemplateItemName
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public LayerTypeOptions? Type
		{
			get { return EnumerationStatic.GetValueFromDescription<LayerTypeOptions> ((ValueItems as dynamic).type); }
			set { (ValueItems as dynamic).type = value?.GetDescription(); }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

	}
}

