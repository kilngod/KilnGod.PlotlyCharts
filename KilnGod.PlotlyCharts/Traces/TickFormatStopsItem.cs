//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TickFormatStopsItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;


namespace KilnGod.PlotlyCharts.Traces
{

    public class TickFormatStopsItem : ValuesObject
    {

        public TickFormatStopsItem() : base() { }

        public object? DTickRange
        {
            get { return (ValueItems as dynamic).dtickrange; }
            set { (ValueItems as dynamic).dtickrange = value; }
        }

        public bool? Enabled
        {
            get { return (ValueItems as dynamic).enabled; }
            set { (ValueItems as dynamic).enabled = value; }
        }

        public string? Name
        {
            get { return (ValueItems as dynamic).name; }
            set { (ValueItems as dynamic).name = value; }
        }

        public string? Templateitemname
        {
            get { return (ValueItems as dynamic).templateitemname; }
            set { (ValueItems as dynamic).templateitemname = value; }
        }

        public string? Value
        {
            get { return (ValueItems as dynamic).value; }
            set { (ValueItems as dynamic).value = value; }
        }

    }

}
