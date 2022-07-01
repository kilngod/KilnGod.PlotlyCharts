//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LayoutYAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class LayoutYAxisInfo : ValuesObject
	{

		public LayoutYAxisInfo():base()		{		}

		public AnchorAxisOptions? Anchor
		{
			get { return EnumerationStatic.GetValueFromDescription<AnchorAxisOptions> ((ValueItems as dynamic).anchor); }
			set { (ValueItems as dynamic).anchor = value?.GetDescription(); }
		}

		public bool? AutoMargin
		{
			get { return (ValueItems as dynamic).automargin; }
			set { (ValueItems as dynamic).automargin = value; }
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

		public CalendarOptions? Calendar
		{
			get { return EnumerationStatic.GetValueFromDescription<CalendarOptions> ((ValueItems as dynamic).calendar); }
			set { (ValueItems as dynamic).calendar = value?.GetDescription(); }
		}

		public object? CategoryArray
		{
			get { return (ValueItems as dynamic).categoryarray; }
			set { (ValueItems as dynamic).categoryarray = value; }
		}

		public CategoryOrderLayoutOptions? CategoryOrder
		{
			get { return EnumerationStatic.GetValueFromDescription<CategoryOrderLayoutOptions> ((ValueItems as dynamic).categoryorder); }
			set { (ValueItems as dynamic).categoryorder = value?.GetDescription(); }
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public ConstrainOptions? Constrain
		{
			get { return EnumerationStatic.GetValueFromDescription<ConstrainOptions> ((ValueItems as dynamic).constrain); }
			set { (ValueItems as dynamic).constrain = value?.GetDescription(); }
		}

		public ConstrainTowardOptions? ConstrainToward
		{
			get { return EnumerationStatic.GetValueFromDescription<ConstrainTowardOptions> ((ValueItems as dynamic).constraintoward); }
			set { (ValueItems as dynamic).constraintoward = value?.GetDescription(); }
		}

		public object? DividerColor
		{
			get { return (ValueItems as dynamic).dividercolor; }
			set { (ValueItems as dynamic).dividercolor = value; }
		}

		public double? DividerWidth
		{
			get { return (ValueItems as dynamic).dividerwidth; }
			set { (ValueItems as dynamic).dividerwidth = value; }
		}

		public object? Domain
		{
			get { return (ValueItems as dynamic).domain; }
			set { (ValueItems as dynamic).domain = value; }
		}

		public object? DTick
		{
			get { return (ValueItems as dynamic).dtick; }
			set { (ValueItems as dynamic).dtick = value; }
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

		public string? HoverFormat
		{
			get { return (ValueItems as dynamic).hoverformat; }
			set { (ValueItems as dynamic).hoverformat = value; }
		}

		public AxisLayerOptions? Layer
		{
			get { return EnumerationStatic.GetValueFromDescription<AxisLayerOptions> ((ValueItems as dynamic).layer); }
			set { (ValueItems as dynamic).layer = value?.GetDescription(); }
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

		public MatchesOptions? Matches
		{
			get { return EnumerationStatic.GetValueFromDescription<MatchesOptions> ((ValueItems as dynamic).matches); }
			set { (ValueItems as dynamic).matches = value?.GetDescription(); }
		}

		public double? MinExponent
		{
			get { return (ValueItems as dynamic).minexponent; }
			set { (ValueItems as dynamic).minexponent = value; }
		}

		public MirrorOptions? Mirror
		{
			get { return EnumerationStatic.GetValueFromDescription<MirrorOptions> ((ValueItems as dynamic).mirror); }
			set { (ValueItems as dynamic).mirror = value?.GetDescription(); }
		}

		public int? NTicks
		{
			get { return (ValueItems as dynamic).nticks; }
			set { (ValueItems as dynamic).nticks = value; }
		}

		public OverlayingOptions? Overlaying
		{
			get { return EnumerationStatic.GetValueFromDescription<OverlayingOptions> ((ValueItems as dynamic).overlaying); }
			set { (ValueItems as dynamic).overlaying = value?.GetDescription(); }
		}

		public double? Position
		{
			get { return (ValueItems as dynamic).position; }
			set { (ValueItems as dynamic).position = value; }
		}

		public object? Range
		{
			get { return (ValueItems as dynamic).range; }
			set { (ValueItems as dynamic).range = value; }
		}

		ItemList<RangeBreakItem>? _RangeBreaks = null;
		public ItemList<RangeBreakItem>? RangeBreaks
		{
			get
			{ 
				return _RangeBreaks;
			}
			set
			{ 
				_RangeBreaks = value;
				(ValueItems as dynamic).rangebreaks = _RangeBreaks?.Values;
			}
		}

		public RangeModeOptions? RangeMode
		{
			get { return EnumerationStatic.GetValueFromDescription<RangeModeOptions> ((ValueItems as dynamic).rangemode); }
			set { (ValueItems as dynamic).rangemode = value?.GetDescription(); }
		}

		public ScaleAnchorOptions? ScaleAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<ScaleAnchorOptions> ((ValueItems as dynamic).scaleanchor); }
			set { (ValueItems as dynamic).scaleanchor = value?.GetDescription(); }
		}

		public double? ScaleRatio
		{
			get { return (ValueItems as dynamic).scaleratio; }
			set { (ValueItems as dynamic).scaleratio = value; }
		}

		public bool? SeparateThousands
		{
			get { return (ValueItems as dynamic).separatethousands; }
			set { (ValueItems as dynamic).separatethousands = value; }
		}

		public bool? ShowDividers
		{
			get { return (ValueItems as dynamic).showdividers; }
			set { (ValueItems as dynamic).showdividers = value; }
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

		public bool? ShowSpikes
		{
			get { return (ValueItems as dynamic).showspikes; }
			set { (ValueItems as dynamic).showspikes = value; }
		}

		public bool? ShowTickLabels
		{
			get { return (ValueItems as dynamic).showticklabels; }
			set { (ValueItems as dynamic).showticklabels = value; }
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

		public PositionOptions? Side
		{
			get { return EnumerationStatic.GetValueFromDescription<PositionOptions> ((ValueItems as dynamic).side); }
			set { (ValueItems as dynamic).side = value?.GetDescription(); }
		}

		public object? SpikeColor
		{
			get { return (ValueItems as dynamic).spikecolor; }
			set { (ValueItems as dynamic).spikecolor = value; }
		}

		public SpikeDashOptions? SpikeDash
		{
			get { return EnumerationStatic.GetValueFromDescription<SpikeDashOptions> ((ValueItems as dynamic).spikedash); }
			set { (ValueItems as dynamic).spikedash = value?.GetDescription(); }
		}

		SpikeModeOptions[]? _SpikeMode = null;
		public SpikeModeOptions[]? SpikeMode
		{
			get { return _SpikeMode; }
			set
			{
				_SpikeMode = value;
				if (value != null)
				{
					(ValueItems as dynamic).spikemode = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public SpikeSnapOptions? SpikeSnap
		{
			get { return EnumerationStatic.GetValueFromDescription<SpikeSnapOptions> ((ValueItems as dynamic).spikesnap); }
			set { (ValueItems as dynamic).spikesnap = value?.GetDescription(); }
		}

		public double? SpikeThickness
		{
			get { return (ValueItems as dynamic).spikethickness; }
			set { (ValueItems as dynamic).spikethickness = value; }
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

		public TickLabelModeOptions? TickLabelMode
		{
			get { return EnumerationStatic.GetValueFromDescription<TickLabelModeOptions> ((ValueItems as dynamic).ticklabelmode); }
			set { (ValueItems as dynamic).ticklabelmode = value?.GetDescription(); }
		}

		public TickLabelOverflowOptions? TickLabelOverflow
		{
			get { return EnumerationStatic.GetValueFromDescription<TickLabelOverflowOptions> ((ValueItems as dynamic).ticklabeloverflow); }
			set { (ValueItems as dynamic).ticklabeloverflow = value?.GetDescription(); }
		}

		public TickLabelPositionOptions? TickLabelPosition
		{
			get { return EnumerationStatic.GetValueFromDescription<TickLabelPositionOptions> ((ValueItems as dynamic).ticklabelposition); }
			set { (ValueItems as dynamic).ticklabelposition = value?.GetDescription(); }
		}

		public int? TickLabelstep
		{
			get { return (ValueItems as dynamic).ticklabelstep; }
			set { (ValueItems as dynamic).ticklabelstep = value; }
		}

		public double? TickLen
		{
			get { return (ValueItems as dynamic).ticklen; }
			set { (ValueItems as dynamic).ticklen = value; }
		}

		public AutoLinearArrayTickModeOptions? TickMode
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoLinearArrayTickModeOptions> ((ValueItems as dynamic).tickmode); }
			set { (ValueItems as dynamic).tickmode = value?.GetDescription(); }
		}

		public string? TickPrefix
		{
			get { return (ValueItems as dynamic).tickprefix; }
			set { (ValueItems as dynamic).tickprefix = value; }
		}

		public TicksOptions? Ticks
		{
			get { return EnumerationStatic.GetValueFromDescription<TicksOptions> ((ValueItems as dynamic).ticks); }
			set { (ValueItems as dynamic).ticks = value?.GetDescription(); }
		}

		public TicksOnOptions? TicksOn
		{
			get { return EnumerationStatic.GetValueFromDescription<TicksOnOptions> ((ValueItems as dynamic).tickson); }
			set { (ValueItems as dynamic).tickson = value?.GetDescription(); }
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

		public double? TickWidth
		{
			get { return (ValueItems as dynamic).tickwidth; }
			set { (ValueItems as dynamic).tickwidth = value; }
		}

		TitleFontStandoffInfo? _Title = null;
		public TitleFontStandoffInfo? Title
		{
			get { return _Title; }
			set
			{
				_Title = value;
				(ValueItems as dynamic).title = _Title?.ValueItems;
			}
		}

		public AxisTypeOptions? Type
		{
			get { return EnumerationStatic.GetValueFromDescription<AxisTypeOptions> ((ValueItems as dynamic).type); }
			set { (ValueItems as dynamic).type = value?.GetDescription(); }
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

		public bool? ZeroLine
		{
			get { return (ValueItems as dynamic).zeroline; }
			set { (ValueItems as dynamic).zeroline = value; }
		}

		public object? ZeroLineColor
		{
			get { return (ValueItems as dynamic).zerolinecolor; }
			set { (ValueItems as dynamic).zerolinecolor = value; }
		}

		public double? ZeroLineWidth
		{
			get { return (ValueItems as dynamic).zerolinewidth; }
			set { (ValueItems as dynamic).zerolinewidth = value; }
		}

	}
}

