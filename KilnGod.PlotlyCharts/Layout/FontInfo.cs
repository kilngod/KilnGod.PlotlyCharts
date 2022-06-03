//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FontInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.Layout
{
    public class FontInfo : ValuesObject
    {
        public FontInfo()
        {
        }

        public object? Color
        {
            get { return (ValueItems as dynamic).color; }
            set { (ValueItems as dynamic).color = value; }
        }

        public string? Family
        {
            get { return (ValueItems as dynamic).family; }
            set { (ValueItems as dynamic).family = value; }
        }

        public int? Size
        {
            get { return (ValueItems as dynamic).size; }
            set { (ValueItems as dynamic).size = value; }
        }
    }
}
