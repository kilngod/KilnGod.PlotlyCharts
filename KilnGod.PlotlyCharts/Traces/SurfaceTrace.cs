//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SurfaceTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class SurfaceTrace : Trace
    {
        public SurfaceTrace():base(TraceTypeOptions.ThreeD_Surface)
        {

        }


        public object? Z
        {
            get { return (ValueItems as dynamic).z; }
            set { (ValueItems as dynamic).z = value; }
        }

        Contours3DInfo? _Contours = null;
        public Contours3DInfo? Contours
        {
            get { return _Contours; }
            set
            {
                _Contours = value;
                (ValueItems as dynamic).contours = _Contours?.ValueItems;
            }
        }
    }
}
