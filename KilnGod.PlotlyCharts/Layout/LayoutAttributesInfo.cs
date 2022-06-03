//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LayoutAttributesInfo.cs
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
    public class LayoutAttributesInfo : ValuesObject
    {

        public LayoutAttributesInfo() : base() { }

        public float? Bargap
        {
            get { return (ValueItems as dynamic).bargap; }
            set { (ValueItems as dynamic).bargap = value; }
        }

        public float? Bargroupgap
        {
            get { return (ValueItems as dynamic).bargroupgap; }
            set { (ValueItems as dynamic).bargroupgap = value; }
        }

        public BarModeOptions? BarMode
        {
            get { return EnumerationStatic.GetValueFromDescription<BarModeOptions>((ValueItems as dynamic).barmode); }
            set { (ValueItems as dynamic).barmode = value?.GetDescription(); }
        }

        public BarNormOptions? BarNorm
        {
            get { return EnumerationStatic.GetValueFromDescription<BarNormOptions>((ValueItems as dynamic).barnorm); }
            set { (ValueItems as dynamic).barnorm = value?.GetDescription(); }
        }

    }

}
