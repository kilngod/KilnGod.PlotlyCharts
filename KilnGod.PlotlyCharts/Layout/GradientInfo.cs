//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GradientInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Layout;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layout
{

    public class GradientInfo : ValuesObject
    {

        public GradientInfo() : base() { }

        public object? Color
        {
            get { return (ValueItems as dynamic).color; }
            set { (ValueItems as dynamic).color = value; }
        }

        public GradientTypeOptions? XAnchor
        {
            get { return EnumerationStatic.GetValueFromDescription<GradientTypeOptions>((ValueItems as dynamic).xanchor); }
            set { (ValueItems as dynamic).xanchor = value?.GetDescription(); }
        }

        public GradientTypeOptions? YAnchor
        {
            get { return EnumerationStatic.GetValueFromDescription<GradientTypeOptions>((ValueItems as dynamic).yanchor); }
            set { (ValueItems as dynamic).yanchor = value?.GetDescription(); }
        }

    

    }
}
