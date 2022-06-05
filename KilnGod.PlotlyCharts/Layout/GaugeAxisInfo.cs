//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;


namespace KilnGod.PlotlyCharts.Layout
{
    public class GaugeAxisInfo : ValuesObject
    {

        public GaugeAxisInfo() : base() { }

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

        public object? Range
        {
            get { return (ValueItems as dynamic).range; }
            set { (ValueItems as dynamic).range = value; }
        }

        public bool? SeparateThousands
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
                    (ValueItems as dynamic).tickformatstops = value.Values;
                }
            }
        }

        public double? TickLabelStep
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

        public double? TickWidth
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
