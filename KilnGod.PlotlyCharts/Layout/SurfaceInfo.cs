//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SurfaceInfo.cs
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

    public class SurfaceInfo : ValuesObject
    {

        public SurfaceInfo() : base() { }

        public int? Count
        {
            get { return (ValueItems as dynamic).count; }
            set { (ValueItems as dynamic).count = value; }
        }

        public double? Fill
        {
            get { return (ValueItems as dynamic).fill; }
            set { (ValueItems as dynamic).fill = value; }
        }

        public PatternOptions? Pattern
        {
            get { return EnumerationStatic.GetValueFromDescription<PatternOptions>((ValueItems as dynamic).pattern); }
            set { (ValueItems as dynamic).pattern = value?.GetDescription(); }
        }

        public bool? Show
        {
            get { return (ValueItems as dynamic).show; }
            set { (ValueItems as dynamic).show = value; }
        }

    }

}
