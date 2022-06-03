//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BarInfo.cs
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
    public class BarInfo : ValuesObject
    {

        public BarInfo() : base() { }


        public object? Color
        {
            get { return (ValueItems as dynamic).color; }
            set { (ValueItems as dynamic).color = value; }
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

        public double? Thickness
        {
            get { return (ValueItems as dynamic).thickness; }
            set { (ValueItems as dynamic).thickness = value; }
        }

    }
}
