//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: StreamInfo.cs
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
    public class StreamInfo : ValuesObject
    {

        public StreamInfo() : base() { }

        public double? MaxPoints
        {
            get { return (ValueItems as dynamic).maxpoints; }
            set { (ValueItems as dynamic).maxpoints = value; }
        }

        public string? Token
        {
            get { return (ValueItems as dynamic).token; }
            set { (ValueItems as dynamic).token = value; }
        }

    }
}
