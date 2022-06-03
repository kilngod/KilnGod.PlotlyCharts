//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SliceRenderInfo.cs
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
    public class SliceRenderInfo : ValuesObject
    {

        public SliceRenderInfo() : base() { }

        public double? Fill
        {
            get { return (ValueItems as dynamic).fill; }
            set { (ValueItems as dynamic).fill = value; }
        }

        public object? Locations
        {
            get { return (ValueItems as dynamic).location; }
            set { (ValueItems as dynamic).locations = value; }
        }

        public bool? Show
        {
            get { return (ValueItems as dynamic).show; }
            set { (ValueItems as dynamic).show = value; }
        }
    }
}
