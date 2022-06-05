//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PatternInfo.cs
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

    public class PatternInfo : ValuesObject
    {

        public PatternInfo() : base() { }

        public object? BgColor
        {
            get { return (ValueItems as dynamic).bgcolor; }
            set { (ValueItems as dynamic).bgcolor = value; }
        }

        public object? FgColor
        {
            get { return (ValueItems as dynamic).fgcolor; }
            set { (ValueItems as dynamic).fgcolor = value; }
        }

        public object? FgOpacity
        {
            get { return (ValueItems as dynamic).fgopacity; }
            set { (ValueItems as dynamic).fgopacity = value; }
        }

        public FillModeOptions? FillMode
        {
            get { return EnumerationStatic.GetValueFromDescription<FillModeOptions>((ValueItems as dynamic).fillmode); }
            set { (ValueItems as dynamic).fillmode = value?.GetDescription(); }
        }

        public ShapeOptions? Shape
        {
            get { return EnumerationStatic.GetValueFromDescription<ShapeOptions>((ValueItems as dynamic).shape); }
            set { (ValueItems as dynamic).shape = value?.GetDescription(); }
        }

        public double? Size
        {
            get { return (ValueItems as dynamic).size; }
            set { (ValueItems as dynamic).size = value; }
        }

        public double? Solidity
        {
            get { return (ValueItems as dynamic).solidity; }
            set { (ValueItems as dynamic).solidity = value; }
        }

    }
}
