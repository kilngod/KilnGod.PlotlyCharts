//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TilingInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;


namespace KilnGod.PlotlyCharts.Layout
{
    public class TilingInfo : ValuesObject
    {

        public TilingInfo() : base() { }

        public FlipOptions? Flip
        {
            get { return EnumerationStatic.GetValueFromDescription<FlipOptions>((ValueItems as dynamic).flip); }
            set { (ValueItems as dynamic).flip = value?.GetDescription(); }
        }

        public OrientationOptions? Orientation
        {
            get { return EnumerationStatic.GetValueFromDescription<OrientationOptions>((ValueItems as dynamic).orientation); }
            set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
        }

        public double? Pad
        {
            get { return (ValueItems as dynamic).pad; }
            set { (ValueItems as dynamic).pad = value; }
        }

    }

}
