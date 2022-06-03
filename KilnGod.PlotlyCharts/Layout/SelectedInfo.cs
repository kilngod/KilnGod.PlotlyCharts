//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SelectedInfo.cs
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

    public class SelectedInfo : ValuesObject
    {

        public SelectedInfo() : base() { }

        MarkerInfo? _Marker = null;
        public MarkerInfo? Marker
        {
            get { return _Marker; }
            set
            {
                _Marker = value;
                (ValueItems as dynamic).marker = _Marker?.ValueItems;
            }
        }

        public object? TextFontColor
        {
            get { return (ValueItems as dynamic).color; }
            set { (ValueItems as dynamic).color = value; }
        }


    }

}
