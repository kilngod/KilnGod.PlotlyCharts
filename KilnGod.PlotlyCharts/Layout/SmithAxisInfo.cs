//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SmithAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;


namespace KilnGod.PlotlyCharts.Layout
{

    public class SmithAxisInfo : ValuesObject
	{

		public SmithAxisInfo() : base() { }

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public object? GridColor
		{
			get { return (ValueItems as dynamic).gridcolor; }
			set { (ValueItems as dynamic).gridcolor = value; }
		}

		public double? Gridwidth
		{
			get { return (ValueItems as dynamic).gridwidth; }
			set { (ValueItems as dynamic).gridwidth = value; }
		}

		public string? HoverFormat
		{
			get { return (ValueItems as dynamic).hoverformat; }
			set { (ValueItems as dynamic).hoverformat = value; }
		}

		public LayerOptions? Layer
		{
			get { return EnumerationStatic.GetValueFromDescription<LayerOptions>((ValueItems as dynamic).layer); }
			set { (ValueItems as dynamic).layer = value?.GetDescription(); }
		}

		public object? LineColor
		{
			get { return (ValueItems as dynamic).linecolor; }
			set { (ValueItems as dynamic).linecolor = value; }
		}

		public double? Linewidth
		{
			get { return (ValueItems as dynamic).linewidth; }
			set { (ValueItems as dynamic).linewidth = value; }
		}

		public bool? Showgrid
		{
			get { return (ValueItems as dynamic).showgrid; }
			set { (ValueItems as dynamic).showgrid = value; }
		}

		public bool? ShowLine
		{
			get { return (ValueItems as dynamic).showline; }
			set { (ValueItems as dynamic).showline = value; }
		}

		public bool? ShowTickLabels
		{
			get { return (ValueItems as dynamic).showticklabels; }
			set { (ValueItems as dynamic).showticklabels = value; }
		}

		public ShowLabelOptions? ShowTickPrefix
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowLabelOptions>((ValueItems as dynamic).showtickprefix); }
			set { (ValueItems as dynamic).showtickprefix = value?.GetDescription(); }
		}

		public ShowLabelOptions? ShowTickSuffix
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowLabelOptions>((ValueItems as dynamic).showticksuffix); }
			set { (ValueItems as dynamic).showticksuffix = value?.GetDescription(); }
		}

		public SideOptions? Side
		{
			get { return EnumerationStatic.GetValueFromDescription<SideOptions>((ValueItems as dynamic).side); }
			set { (ValueItems as dynamic).side = value?.GetDescription(); }
		}

		public double? TickAngle
		{
			get { return (ValueItems as dynamic).tickangle; }
			set { (ValueItems as dynamic).tickangle = value; }
		}

		public object? TickColor
		{
			get { return (ValueItems as dynamic).tickcolor; }
			set { (ValueItems as dynamic).tickcolor = value; }
		}

		FontInfo? _TickFont = null;
		public FontInfo? TickFont
		{
			get { return _TickFont; }
			set
			{
				_TickFont = value;
				(ValueItems as dynamic).tickfont = _TickFont?.ValueItems;
			}
		}

		public string? TickFormat
		{
			get { return (ValueItems as dynamic).tickformat; }
			set { (ValueItems as dynamic).tickformat = value; }
		}

		public double? Ticklen
		{
			get { return (ValueItems as dynamic).ticklen; }
			set { (ValueItems as dynamic).ticklen = value; }
		}

		public string? TickPrefix
		{
			get { return (ValueItems as dynamic).tickprefix; }
			set { (ValueItems as dynamic).tickprefix = value; }
		}

		public TicksOptions? Ticks
		{
			get { return EnumerationStatic.GetValueFromDescription<TicksOptions>((ValueItems as dynamic).ticks); }
			set { (ValueItems as dynamic).ticks = value?.GetDescription(); }
		}

		public string? TickSuffix
		{
			get { return (ValueItems as dynamic).ticksuffix; }
			set { (ValueItems as dynamic).ticksuffix = value; }
		}

		public object? Tickvals
		{
			get { return (ValueItems as dynamic).tickvals; }
			set { (ValueItems as dynamic).tickvals = value; }
		}

		public double? Tickwidth
		{
			get { return (ValueItems as dynamic).tickwidth; }
			set { (ValueItems as dynamic).tickwidth = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

	}



}
