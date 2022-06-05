﻿//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ColorScalesItem.cs
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

    public class ColorScalesItem : ValuesObject
    {

        public ColorScalesItem() : base() { }

        public double? Cmax
        {
            get { return (ValueItems as dynamic).cmax; }
            set { (ValueItems as dynamic).cmax = value; }
        }

        public double? Cmin
        {
            get { return (ValueItems as dynamic).cmin; }
            set { (ValueItems as dynamic).cmin = value; }
        }

        public object? ColorScale
        {
            get { return (ValueItems as dynamic).colorscale; }
            set { (ValueItems as dynamic).colorscale = value; }
        }

        public string? Label
        {
            get { return (ValueItems as dynamic).label; }
            set { (ValueItems as dynamic).label = value; }
        }

        public string? Name
        {
            get { return (ValueItems as dynamic).name; }
            set { (ValueItems as dynamic).name = value; }
        }

        public string? TemplateItemName
        {
            get { return (ValueItems as dynamic).templateitemname; }
            set { (ValueItems as dynamic).templateitemname = value; }
        }

    }
}