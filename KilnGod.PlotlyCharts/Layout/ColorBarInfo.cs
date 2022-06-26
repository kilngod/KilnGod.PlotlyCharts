//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ColorBarInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{


    public class ColorBarInfo : ValuesObject
	{

		public ColorBarInfo() : base() { }

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		public object? BorderColor
		{
			get { return (ValueItems as dynamic).bordercolor; }
			set { (ValueItems as dynamic).bordercolor = value; }
		}

		public double? Borderwidth
		{
			get { return (ValueItems as dynamic).borderwidth; }
			set { (ValueItems as dynamic).borderwidth = value; }
		}

		public object? DTick
		{
			get { return (ValueItems as dynamic).dtick; }
			set { (ValueItems as dynamic).dtick = value; }
		}

		public ShowLabelOptions? ExponentFormat
		{
			get { return EnumerationStatic.GetValueFromDescription<ShowLabelOptions>((ValueItems as dynamic).exponentformat); }
			set { (ValueItems as dynamic).exponentformat = value?.GetDescription(); }
		}

		public double? Len
		{
			get { return (ValueItems as dynamic).len; }
			set { (ValueItems as dynamic).len = value; }
		}

		public LenModeOptions? LenMode
		{
			get { return EnumerationStatic.GetValueFromDescription<LenModeOptions>((ValueItems as dynamic).lenmode); }
			set { (ValueItems as dynamic).lenmode = value?.GetDescription(); }
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

		public OrientationOptions? Orientation
		{
			get { return EnumerationStatic.GetValueFromDescription<OrientationOptions>((ValueItems as dynamic).orientation); }
			set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
		}

		public object? OutLineColor
		{
			get { return (ValueItems as dynamic).outlinecolor; }
			set { (ValueItems as dynamic).outlinecolor = value; }
		}

		public double? OutLinewidth
		{
			get { return (ValueItems as dynamic).outlinewidth; }
			set { (ValueItems as dynamic).outlinewidth = value; }
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

		public double? Thickness
		{
			get { return (ValueItems as dynamic).thickness; }
			set { (ValueItems as dynamic).thickness = value; }
		}

		public ThicknessModeOptions? ThicknessMode
		{
			get { return EnumerationStatic.GetValueFromDescription<ThicknessModeOptions>((ValueItems as dynamic).thicknessmode); }
			set { (ValueItems as dynamic).thicknessmode = value?.GetDescription(); }
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
		public ItemList<TickFormatStopItem>? TickFormatStopsItems
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

		public TickLabelOverflowOptions? TickLabelOverflow
		{
			get { return EnumerationStatic.GetValueFromDescription<TickLabelOverflowOptions>((ValueItems as dynamic).ticklabeloverflow); }
			set { (ValueItems as dynamic).ticklabeloverflow = value?.GetDescription(); }
		}

		public TickLabelPositionOptions? TickLabelPosition
		{
			get { return EnumerationStatic.GetValueFromDescription<TickLabelPositionOptions>((ValueItems as dynamic).ticklabelposition); }
			set { (ValueItems as dynamic).ticklabelposition = value?.GetDescription(); }
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

		public double? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public XAnchorOptions? XAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<XAnchorOptions>((ValueItems as dynamic).xanchor); }
			set { (ValueItems as dynamic).xanchor = value?.GetDescription(); }
		}

		public double? Xpad
		{
			get { return (ValueItems as dynamic).xpad; }
			set { (ValueItems as dynamic).xpad = value; }
		}

		public double? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

		public YAnchorOptions? YAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<YAnchorOptions>((ValueItems as dynamic).yanchor); }
			set { (ValueItems as dynamic).yanchor = value?.GetDescription(); }
		}

		public double? Ypad
		{
			get { return (ValueItems as dynamic).ypad; }
			set { (ValueItems as dynamic).ypad = value; }
		}

	}

}
