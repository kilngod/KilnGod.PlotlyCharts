//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CellsInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layout
{

    public class CellsInfo : ValuesObject
    {

        public CellsInfo() : base() { }


        public object? Align
        {
            get { return (ValueItems as dynamic).align; }
            set { (ValueItems as dynamic).align = value; }
        }

        /*
        public AlignOptions? Align
        {
            get { return EnumerationStatic.GetValueFromDescription<AlignOptions>((ValueItems as dynamic).align); }
            set { (ValueItems as dynamic).align = value?.GetDescription(); }
        }
        */


        public object? Fill
        {
            get { return (ValueItems as dynamic).fill; }
            set { (ValueItems as dynamic).fill = value; }
        }

        FontInfo? _Font = null;
        public FontInfo? Font
        {
            get { return _Font; }
            set
            {
                _Font = value;
                (ValueItems as dynamic).font = _Font?.ValueItems;
            }
        }

        public object? Format
        {
            get { return (ValueItems as dynamic).format; }
            set { (ValueItems as dynamic).format = value; }
        }

        public double? Height
        {
            get { return (ValueItems as dynamic).height; }
            set { (ValueItems as dynamic).height = value; }
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

        public string? Prefix
        {
            get { return (ValueItems as dynamic).prefix; }
            set { (ValueItems as dynamic).prefix = value; }
        }

        public string? Suffix
        {
            get { return (ValueItems as dynamic).suffix; }
            set { (ValueItems as dynamic).suffix = value; }
        }

        public object? Values
        {
            get { return (ValueItems as dynamic).values; }
            set { (ValueItems as dynamic).values = value; }
        }

    }

}
