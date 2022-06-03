//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Contours3DInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{

    public class Contours3DInfo : ValuesObject
    {

        public Contours3DInfo() : base() { }

 
        Contour3DLineInfo? _X = null;
        public Contour3DLineInfo? X
        {
            get { return _X; }
            set
            {
                _X = value;
                (ValueItems as dynamic).x = _X?.ValueItems;
            }
        }

        Contour3DLineInfo? _Y = null;
        public Contour3DLineInfo? Y
        {
            get { return _Y; }
            set
            {
                _Y = value;
                (ValueItems as dynamic).y = _Y?.ValueItems;
            }
        }

        Contour3DLineInfo? _Z = null;
        public Contour3DLineInfo? Z
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
