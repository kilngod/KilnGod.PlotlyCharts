//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BinInfo.cs
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
    public class BinInfo : ValuesObject
    {
        public BinInfo() : base() { }

        public double? End
        {
            get { return (ValueItems as dynamic).end; }
            set { (ValueItems as dynamic).end = value; }
        }

        public double? Size
        {
            get { return (ValueItems as dynamic).size; }
            set { (ValueItems as dynamic).size = value; }
        }

        public double? Start
        {
            get { return (ValueItems as dynamic).start; }
            set { (ValueItems as dynamic).start = value; }
        }
    }
}
