//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CapsInfo.cs
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
    public class CapsInfo : ValuesObject
    {

        public CapsInfo() : base() { }

        CapRenderInfo? _X = null;
        public CapRenderInfo? X
        {
            get { return _X; }
            set
            {
                _X = value;
                (ValueItems as dynamic).x = _X?.ValueItems;
            }
        }

        CapRenderInfo? _Y = null;
        public CapRenderInfo? Y
        {
            get { return _Y; }
            set
            {
                _Y = value;
                (ValueItems as dynamic).y = _Y?.ValueItems;
            }
        }

        CapRenderInfo? _Z = null;
        public CapRenderInfo? Z
        {
            get { return _Z; }
            set
            {
                _Z = value;
                (ValueItems as dynamic).z = _Z?.ValueItems;
            }
        }
    }
}
