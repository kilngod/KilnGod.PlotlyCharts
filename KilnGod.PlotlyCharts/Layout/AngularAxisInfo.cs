﻿//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AngularAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{


	public class AngularAxisInfo : ValuesObject
	{

		public AngularAxisInfo() : base() { }

		public AngularAxisTypeOptions? AngularAxisType
		{
			get { return EnumerationStatic.GetValueFromDescription<AngularAxisTypeOptions>((ValueItems as dynamic).angularaxistype); }
			set { (ValueItems as dynamic).angularaxistype = value?.GetDescription(); }
		}

		public AutoTypeNumbersOptions? AutoTypeNumbers
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoTypeNumbersOptions>((ValueItems as dynamic).autotypenumbers); }
			set { (ValueItems as dynamic).autotypenumbers = value?.GetDescription(); }
		}

		public object? CategoryArray
		{
			get { return (ValueItems as dynamic).categoryarray; }
			set { (ValueItems as dynamic).categoryarray = value; }
		}

		public CategoryOrderOptions? CategoryOrder
		{
			get { return EnumerationStatic.GetValueFromDescription<CategoryOrderOptions>((ValueItems as dynamic).categoryorder); }
			set { (ValueItems as dynamic).categoryorder = value?.GetDescription(); }
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public DirectionOptions? Direction
		{
			get { return EnumerationStatic.GetValueFromDescription<DirectionOptions>((ValueItems as dynamic).direction); }
			set { (ValueItems as dynamic).direction = value?.GetDescription(); }
		}

		public object? DTick
		{
			get { return (ValueItems as dynamic).dtick; }
			set { (ValueItems as dynamic).dtick = value; }
		}

		public ExponentFormatOptions? ExponentFormat
		{
			get { return EnumerationStatic.GetValueFromDescription<ExponentFormatOptions>((ValueItems as dynamic).exponentformat); }
			set { (ValueItems as dynamic).exponentformat = value?.GetDescription(); }
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

		public double? MinExponent
		{
			get { return (ValueItems as dynamic).minexponent; }
			set { (ValueItems as dynamic).minexponent = value; }
		}

		public int? NTicks
		{
			get { return (ValueItems as dynamic).nticks; }
			set { (ValueItems as dynamic).nticks = value; }
		}

		public double? Period
		{
			get { return (ValueItems as dynamic).period; }
			set { (ValueItems as dynamic).period = value; }
		}

		public double? Rotation
		{
			get { return (ValueItems as dynamic).rotation; }
			set { (ValueItems as dynamic).rotation = value; }
		}

		public bool? Separatethousands
		{
			get { return (ValueItems as dynamic).separatethousands; }
			set { (ValueItems as dynamic).separatethousands = value; }
		}

		public ShowLabelOptions? ShowExponent
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowLabelOptions>((ValueItems as dynamic).showexponent); }
			set { (ValueItems as dynamic).showexponent = value?.GetDescription(); }
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

		public ThetaUnitOptions? ThetaUnit
		{
			get { return EnumerationStatic.GetValueFromDescription<ThetaUnitOptions>((ValueItems as dynamic).thetaunit); }
			set { (ValueItems as dynamic).thetaunit = value?.GetDescription(); }
		}

		public object? Tick0
		{
			get { return (ValueItems as dynamic).tick0; }
			set { (ValueItems as dynamic).tick0 = value; }
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

		ItemList<TickFormatStopItem>? _TickFormatStopsItems = null;
		public ItemList<TickFormatStopItem>? TickFormatStops
		{
			get
			{
				return _TickFormatStopsItems;
			}
			set
			{
				_TickFormatStopsItems = value;
				if (value != null)
				{
					(ValueItems as dynamic).tickformatstops = _TickFormatStopsItems?.Values;
				}
			}
		}

		public int? TickLabelstep
		{
			get { return (ValueItems as dynamic).ticklabelstep; }
			set { (ValueItems as dynamic).ticklabelstep = value; }
		}

		public double? Ticklen
		{
			get { return (ValueItems as dynamic).ticklen; }
			set { (ValueItems as dynamic).ticklen = value; }
		}

		public TickModeOptions? TickMode
		{
			get { return EnumerationStatic.GetValueFromDescription<TickModeOptions>((ValueItems as dynamic).tickmode); }
			set { (ValueItems as dynamic).tickmode = value?.GetDescription(); }
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

		public object? TickText
		{
			get { return (ValueItems as dynamic).ticktext; }
			set { (ValueItems as dynamic).ticktext = value; }
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

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

	}





}
