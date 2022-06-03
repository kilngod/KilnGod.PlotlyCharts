//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SlicesInfo.cs
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
    public class SlicesInfo : ValuesObject
    {

        public SlicesInfo() : base() { }

        SliceRenderInfo? _X = null;
        public SliceRenderInfo? X
        {
            get { return _X; }
            set
            {
                _X = value;
                (ValueItems as dynamic).x = _X?.ValueItems;
            }
        }

        SliceRenderInfo? _Y = null;
        public SliceRenderInfo? Y
        {
            get { return _Y; }
            set
            {
                _Y = value;
                (ValueItems as dynamic).y = _Y?.ValueItems;
            }
        }

        SliceRenderInfo? _Z = null;
        public SliceRenderInfo? Z
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
