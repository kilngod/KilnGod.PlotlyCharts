﻿//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LegendGroupTitleInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;

namespace KilnGod.PlotlyCharts.Traces
{
    public class LegendGroupTitleInfo : ValuesObject
    {

        public LegendGroupTitleInfo() : base() { }

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

        public string? Text
        {
            get { return (ValueItems as dynamic).text; }
            set { (ValueItems as dynamic).text = value; }
        }

    }

}
