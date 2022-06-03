//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LayersItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class LayersItem : ValuesObject
	{

		public LayersItem() : base() { }

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

		FillInfo? _Fill = null;
		public FillInfo? Fill
		{
			get { return _Fill; }
			set
			{
				_Fill = value;
				(ValueItems as dynamic).fill = _Fill?.ValueItems;
			}
		}

		public LayerTypeOptions? LayersItemsType
		{
			get { return EnumerationStatic.GetValueFromDescription<LayerTypeOptions>((ValueItems as dynamic).layersitemstype); }
			set { (ValueItems as dynamic).layersitemstype = value?.GetDescription(); }
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

		public float? Maxzoom
		{
			get { return (ValueItems as dynamic).maxzoom; }
			set { (ValueItems as dynamic).maxzoom = value; }
		}

		public float? Minzoom
		{
			get { return (ValueItems as dynamic).minzoom; }
			set { (ValueItems as dynamic).minzoom = value; }
		}

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public object? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public object? Source
		{
			get { return (ValueItems as dynamic).source; }
			set { (ValueItems as dynamic).source = value; }
		}

		public string? Sourceattribution
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
			get { return EnumerationStatic.GetValueFromDescription<SourceTypeOptions>((ValueItems as dynamic).sourcetype); }
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

		public string? Templateitemname
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

	}

}
