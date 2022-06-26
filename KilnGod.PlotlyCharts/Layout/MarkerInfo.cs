//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MarkerInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layout
{

    public class MarkerInfo : ValuesObject
    {

        public MarkerInfo() : base() { }

        public bool? AutoColorScale
        {
            get { return (ValueItems as dynamic).autocolorscale; }
            set { (ValueItems as dynamic).autocolorscale = value; }
        }

        public object? AreaRatio
        {
            get { return (ValueItems as dynamic).arearatio; }
            set { (ValueItems as dynamic).arearatio = value; }
        }

        BorderInfo? _BorderInfo = null;
        public BorderInfo? Border
        {
            get { return _BorderInfo; }
            set
            {
                _BorderInfo = value;
                (ValueItems as dynamic).border = _BorderInfo?.ValueItems;
            }
        }

        public bool? Blend
        {
            get { return (ValueItems as dynamic).blend; }
            set { (ValueItems as dynamic).blend = value; }
        }
        public bool? Cauto
        {
            get { return (ValueItems as dynamic).cauto; }
            set { (ValueItems as dynamic).cauto = value; }
        }

        public double? Cmax
        {
            get { return (ValueItems as dynamic).cmax; }
            set { (ValueItems as dynamic).cmax = value; }
        }

        public double? Cmid
        {
            get { return (ValueItems as dynamic).cmid; }
            set { (ValueItems as dynamic).cmid = value; }
        }

        public double? Cmin
        {
            get { return (ValueItems as dynamic).cmin; }
            set { (ValueItems as dynamic).cmin = value; }
        }

        public object? Color
        {
            get { return (ValueItems as dynamic).color; }
            set { (ValueItems as dynamic).color = value; }
        }

        public object? ColorAxis
        {
            get { return (ValueItems as dynamic).coloraxis; }
            set { (ValueItems as dynamic).coloraxis = value; }
        }

        ColorBarInfo? _ColorBar = null;
        public ColorBarInfo? ColorBar
        {
            get { return _ColorBar; }
            set
            {
                _ColorBar = value;
                (ValueItems as dynamic).colorbar = _ColorBar?.ValueItems;
            }
        }

        public object? ColorScale
        {
            get { return (ValueItems as dynamic).colorscale; }
            set { (ValueItems as dynamic).colorscale = value; }
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

        public object? Opacity
        {
            get { return (ValueItems as dynamic).opacity; }
            set { (ValueItems as dynamic).opacity = value; }
        }

        PatternInfo? _Pattern = null;
        public PatternInfo? Pattern
        {
            get { return _Pattern; }
            set
            {
                _Pattern = value;
                (ValueItems as dynamic).pattern = _Pattern?.ValueItems;
            }
        }

        public bool? ReverseScale
        {
            get { return (ValueItems as dynamic).reversescale; }
            set { (ValueItems as dynamic).reversescale = value; }
        }



        public object? Size
        {
            get { return (ValueItems as dynamic).size; }
            set { (ValueItems as dynamic).size = value; }
        }

        public object? SizeMin
        {
            get { return (ValueItems as dynamic).sizemin; }
            set { (ValueItems as dynamic).sizemin = value; }
        }

        public object? SizeMax
        {
            get { return (ValueItems as dynamic).sizemax; }
            set { (ValueItems as dynamic).sizemax = value; }
        }


        public SizeModeOptions? SizeMode
        {
            get { return EnumerationStatic.GetValueFromDescription<SizeModeOptions>((ValueItems as dynamic).sizemode); }
            set { (ValueItems as dynamic).sizemode = value?.GetDescription(); }
        }

        public bool? ShowScale
        {
            get { return (ValueItems as dynamic).showscale; }
            set { (ValueItems as dynamic).showscale = value; }
        }

        public SymbolOptions? Symbol
        {
            get { return EnumerationStatic.GetValueFromDescription<SymbolOptions>((ValueItems as dynamic).symbol); }
            set { (ValueItems as dynamic).symbol = value?.GetDescription(); }
        }

        public object? Width
        {
            get { return (ValueItems as dynamic).width; }
            set { (ValueItems as dynamic).width = value; }
        }
    }

}
