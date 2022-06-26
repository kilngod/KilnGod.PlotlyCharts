//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ConnectorInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layout
{
    public class ConnectorInfo : ValuesObject
    {

        public ConnectorInfo() : base() { }


        public ConnectorModeOptions? Mode
        {
            get { return EnumerationStatic.GetValueFromDescription<ConnectorModeOptions>((ValueItems as dynamic).mode); }
            set { (ValueItems as dynamic).mode = value?.GetDescription(); }
        }
        public object? FillColor
        {
            get { return (ValueItems as dynamic).fillcolor; }
            set { (ValueItems as dynamic).fillcolor = value; }
        }

        LineInfo? _Line = null;
        public LineInfo? Line
        {
            get { return _Line; }
            set
            {
                _Line = value;
                (ValueItems as dynamic).line = _Line?.ValueItems;
            }
        }

        public bool? Visible
        {
            get { return (ValueItems as dynamic).visible; }
            set { (ValueItems as dynamic).visible = value; }
        }

    }
}
