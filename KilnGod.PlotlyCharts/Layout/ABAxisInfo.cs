//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ABAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class ABAxisInfo : ValuesObject
    {

        public ABAxisInfo() : base() { }


		public ABAxisTypeOptions? AxisType
		{
			get { return EnumerationStatic.GetValueFromDescription<ABAxisTypeOptions>((ValueItems as dynamic).aaxistype); }
			set { (ValueItems as dynamic).aaxistype = value?.GetDescription(); }
		}

		public int? ArraydTick
		{
			get { return (ValueItems as dynamic).arraydtick; }
			set { (ValueItems as dynamic).arraydtick = value; }
		}

		public int? ArrayTick0
		{
			get { return (ValueItems as dynamic).arraytick0; }
			set { (ValueItems as dynamic).arraytick0 = value; }
		}

		public AutoRangeOptions? AutoRange
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoRangeOptions>((ValueItems as dynamic).autorange); }
			set { (ValueItems as dynamic).autorange = value?.GetDescription(); }
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

		public CheaterTypeOptions? CheaterType
		{
			get { return EnumerationStatic.GetValueFromDescription<CheaterTypeOptions>((ValueItems as dynamic).cheatertype); }
			set { (ValueItems as dynamic).cheatertype = value?.GetDescription(); }
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public float? DTick
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

		public float? EndLinewidth
		{
			get { return (ValueItems as dynamic).endlinewidth; }
			set { (ValueItems as dynamic).endlinewidth = value; }
		}

		public ShowLabelOptions? ExponentFormat
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowLabelOptions>((ValueItems as dynamic).exponentformat); }
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

		public float? Gridwidth
		{
			get { return (ValueItems as dynamic).gridwidth; }
			set { (ValueItems as dynamic).gridwidth = value; }
		}

		public int? Labelpadding
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

		public float? Linewidth
		{
			get { return (ValueItems as dynamic).linewidth; }
			set { (ValueItems as dynamic).linewidth = value; }
		}

		public float? MinExponent
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

		public float? MinorGridWidth
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
			get { return EnumerationStatic.GetValueFromDescription<RangeModeOptions>((ValueItems as dynamic).rangemode); }
			set { (ValueItems as dynamic).rangemode = value?.GetDescription(); }
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

		public ShowLabelOptions? ShowTickLabels
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowLabelOptions>((ValueItems as dynamic).showticklabels); }
			set { (ValueItems as dynamic).showticklabels = value?.GetDescription(); }
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

		public float? Smoothing
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

		public float? StartLinewidth
		{
			get { return (ValueItems as dynamic).startlinewidth; }
			set { (ValueItems as dynamic).startlinewidth = value; }
		}

		public float? Tick0
		{
			get { return (ValueItems as dynamic).tick0; }
			set { (ValueItems as dynamic).tick0 = value; }
		}

		public float? TickAngle
		{
			get { return (ValueItems as dynamic).tickangle; }
			set { (ValueItems as dynamic).tickangle = value; }
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
		

		ItemList<TickFormatStopItem>? _TickFormatStopsItemss = null;
		public ItemList<TickFormatStopItem> TickFormatStopsItemss
		{
			get
			{
				if (_TickFormatStopsItemss == null)
				{
					_TickFormatStopsItemss = new ItemList<TickFormatStopItem>();
				}
				return _TickFormatStopsItemss;
			}
		}


		ItemList<TickFormatStopItem>? _TickFormatStopsItems = null;
		public ItemList<TickFormatStopItem>? Steps
		{
			get
			{
				return _TickFormatStopsItems;
			}
			set
			{
				_TickFormatStopsItemss = value;
				if (value != null)
				{
					(ValueItems as dynamic).tickformatstops = value.Values;
				}
			}
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

		TitleInfo? _Title = null;
		public TitleInfo? Title
		{
			get { return _Title; }
			set
			{
				_Title = value;
				(ValueItems as dynamic).title = _Title?.ValueItems;
			}
		}

	}
}
