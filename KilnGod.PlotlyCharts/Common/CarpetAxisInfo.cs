//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CarpetAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class CarpetAxisInfo : ValuesObject
	{

		public CarpetAxisInfo():base()		{		}

		public int? ArrayDTick
		{
			get { return (ValueItems as dynamic).arraydtick; }
			set { (ValueItems as dynamic).arraydtick = value; }
		}

		public int? Arraytick0
		{
			get { return (ValueItems as dynamic).arraytick0; }
			set { (ValueItems as dynamic).arraytick0 = value; }
		}

		public AutoRangeOptions? AutoRange
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoRangeOptions> ((ValueItems as dynamic).autorange); }
			set { (ValueItems as dynamic).autorange = value?.GetDescription(); }
		}

		public AutoTypeNumbersOptions? AutoTypeNumbers
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoTypeNumbersOptions> ((ValueItems as dynamic).autotypenumbers); }
			set { (ValueItems as dynamic).autotypenumbers = value?.GetDescription(); }
		}

		public object? CategoryArray
		{
			get { return (ValueItems as dynamic).categoryarray; }
			set { (ValueItems as dynamic).categoryarray = value; }
		}

		public CategoryOrderOptions? CategoryOrder
		{
			get { return EnumerationStatic.GetValueFromDescription<CategoryOrderOptions> ((ValueItems as dynamic).categoryorder); }
			set { (ValueItems as dynamic).categoryorder = value?.GetDescription(); }
		}

		public CheaterTypeOptions? CheaterType
		{
			get { return EnumerationStatic.GetValueFromDescription<CheaterTypeOptions> ((ValueItems as dynamic).cheatertype); }
			set { (ValueItems as dynamic).cheatertype = value?.GetDescription(); }
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public double? DTick
		{
			get { return (ValueItems as dynamic).dtick; }
			set { (ValueItems as dynamic).dtick = value; }
		}

		public bool? EndLine
		{
			get { return (ValueItems as dynamic).endline; }
			set { (ValueItems as dynamic).endline = value; }
		}

		public object? EndLineColor
		{
			get { return (ValueItems as dynamic).endlinecolor; }
			set { (ValueItems as dynamic).endlinecolor = value; }
		}

		public double? EndLineWidth
		{
			get { return (ValueItems as dynamic).endlinewidth; }
			set { (ValueItems as dynamic).endlinewidth = value; }
		}

		public ExponentFormatOptions? ExponentFormat
		{
			get { return EnumerationStatic.GetValueFromDescription<ExponentFormatOptions> ((ValueItems as dynamic).exponentformat); }
			set { (ValueItems as dynamic).exponentformat = value?.GetDescription(); }
		}

		public bool? FixedRange
		{
			get { return (ValueItems as dynamic).fixedrange; }
			set { (ValueItems as dynamic).fixedrange = value; }
		}

		public object? GridColor
		{
			get { return (ValueItems as dynamic).gridcolor; }
			set { (ValueItems as dynamic).gridcolor = value; }
		}

		public double? GridWidth
		{
			get { return (ValueItems as dynamic).gridwidth; }
			set { (ValueItems as dynamic).gridwidth = value; }
		}

		public int? LabelPadding
		{
			get { return (ValueItems as dynamic).labelpadding; }
			set { (ValueItems as dynamic).labelpadding = value; }
		}

		public string? LabelPrefix
		{
			get { return (ValueItems as dynamic).labelprefix; }
			set { (ValueItems as dynamic).labelprefix = value; }
		}

		public string? LabelSuffix
		{
			get { return (ValueItems as dynamic).labelsuffix; }
			set { (ValueItems as dynamic).labelsuffix = value; }
		}

		public object? LineColor
		{
			get { return (ValueItems as dynamic).linecolor; }
			set { (ValueItems as dynamic).linecolor = value; }
		}

		public double? LineWidth
		{
			get { return (ValueItems as dynamic).linewidth; }
			set { (ValueItems as dynamic).linewidth = value; }
		}

		public double? MinExponent
		{
			get { return (ValueItems as dynamic).minexponent; }
			set { (ValueItems as dynamic).minexponent = value; }
		}

		public object? MinorGridColor
		{
			get { return (ValueItems as dynamic).minorgridcolor; }
			set { (ValueItems as dynamic).minorgridcolor = value; }
		}

		public int? MinorGridCount
		{
			get { return (ValueItems as dynamic).minorgridcount; }
			set { (ValueItems as dynamic).minorgridcount = value; }
		}

		public double? MinorGridWidth
		{
			get { return (ValueItems as dynamic).minorgridwidth; }
			set { (ValueItems as dynamic).minorgridwidth = value; }
		}

		public int? NTicks
		{
			get { return (ValueItems as dynamic).nticks; }
			set { (ValueItems as dynamic).nticks = value; }
		}

		public object? Range
		{
			get { return (ValueItems as dynamic).range; }
			set { (ValueItems as dynamic).range = value; }
		}

		public RangeModeOptions? RangeMode
		{
			get { return EnumerationStatic.GetValueFromDescription<RangeModeOptions> ((ValueItems as dynamic).rangemode); }
			set { (ValueItems as dynamic).rangemode = value?.GetDescription(); }
		}

		public bool? SeparateThousands
		{
			get { return (ValueItems as dynamic).separatethousands; }
			set { (ValueItems as dynamic).separatethousands = value; }
		}

		public ShowExponentOptions? ShowExponent
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowExponentOptions> ((ValueItems as dynamic).showexponent); }
			set { (ValueItems as dynamic).showexponent = value?.GetDescription(); }
		}

		public bool? ShowGrid
		{
			get { return (ValueItems as dynamic).showgrid; }
			set { (ValueItems as dynamic).showgrid = value; }
		}

		public bool? ShowLine
		{
			get { return (ValueItems as dynamic).showline; }
			set { (ValueItems as dynamic).showline = value; }
		}

		public ShowTickLabelsOptions? ShowTickLabels
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowTickLabelsOptions> ((ValueItems as dynamic).showticklabels); }
			set { (ValueItems as dynamic).showticklabels = value?.GetDescription(); }
		}

		public ShowTickOptions? ShowTickPrefix
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowTickOptions> ((ValueItems as dynamic).showtickprefix); }
			set { (ValueItems as dynamic).showtickprefix = value?.GetDescription(); }
		}

		public ShowTickOptions? ShowTickSuffix
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowTickOptions> ((ValueItems as dynamic).showticksuffix); }
			set { (ValueItems as dynamic).showticksuffix = value?.GetDescription(); }
		}

		public double? Smoothing
		{
			get { return (ValueItems as dynamic).smoothing; }
			set { (ValueItems as dynamic).smoothing = value; }
		}

		public bool? StartLine
		{
			get { return (ValueItems as dynamic).startline; }
			set { (ValueItems as dynamic).startline = value; }
		}

		public object? StartLineColor
		{
			get { return (ValueItems as dynamic).startlinecolor; }
			set { (ValueItems as dynamic).startlinecolor = value; }
		}

		public double? StartLineWidth
		{
			get { return (ValueItems as dynamic).startlinewidth; }
			set { (ValueItems as dynamic).startlinewidth = value; }
		}

		public double? Tick0
		{
			get { return (ValueItems as dynamic).tick0; }
			set { (ValueItems as dynamic).tick0 = value; }
		}

		public double? TickAngle
		{
			get { return (ValueItems as dynamic).tickangle; }
			set { (ValueItems as dynamic).tickangle = value; }
		}

		TickFontInfo? _TickFont = null;
		public TickFontInfo? TickFont
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

		ItemList<TickFormatStopItem>? _TickFormatStops = null;
		public ItemList<TickFormatStopItem>? TickFormatStops
		{
			get
			{ 
				return _TickFormatStops;
			}
			set
			{ 
				_TickFormatStops = value;
				(ValueItems as dynamic).tickformatstops = _TickFormatStops?.Values;
			}
		}

		public LinearArrayTickModeOptions? TickMode
		{
			get { return EnumerationStatic.GetValueFromDescription<LinearArrayTickModeOptions> ((ValueItems as dynamic).tickmode); }
			set { (ValueItems as dynamic).tickmode = value?.GetDescription(); }
		}

		public string? TickPrefix
		{
			get { return (ValueItems as dynamic).tickprefix; }
			set { (ValueItems as dynamic).tickprefix = value; }
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

		public object? TickVals
		{
			get { return (ValueItems as dynamic).tickvals; }
			set { (ValueItems as dynamic).tickvals = value; }
		}

		TitleFontOffsetInfo? _Title = null;
		public TitleFontOffsetInfo? Title
		{
			get { return _Title; }
			set
			{
				_Title = value;
				(ValueItems as dynamic).title = _Title?.ValueItems;
			}
		}

		public AutoDateCategoryLinearTypeOptions? Type
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoDateCategoryLinearTypeOptions> ((ValueItems as dynamic).type); }
			set { (ValueItems as dynamic).type = value?.GetDescription(); }
		}

	}
}

