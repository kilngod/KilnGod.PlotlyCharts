//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: IsoSurfaceTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class IsoSurfaceTrace : Trace
    {
        public IsoSurfaceTrace() : base(TraceTypeOptions.ThreeD_IsoSurface)
        {

        }

        public object? X
        {
            get { return (ValueItems as dynamic).x; }
            set { (ValueItems as dynamic).x = value; }
        }


        public object? Y
        {
            get { return (ValueItems as dynamic).y; }
            set { (ValueItems as dynamic).y = value; }
        }

        public object? Z
        {
            get { return (ValueItems as dynamic).z; }
            set { (ValueItems as dynamic).z = value; }
        }

        public object? Value
        {
            get { return (ValueItems as dynamic).value; }
            set { (ValueItems as dynamic).value = value; }
        }

        CapsInfo? _caps = null;
        public CapsInfo? Caps
        {
            get { return _caps; }
            set
            {
                _caps = value;
                (ValueItems as dynamic).caps = _caps?.ValueItems;
            }
        }


        public object? IsoMin
        {
            get { return (ValueItems as dynamic).isomin; }
            set { (ValueItems as dynamic).isomin = value; }
        }


        public object? IsoMax
        {
            get { return (ValueItems as dynamic).isomax; }
            set { (ValueItems as dynamic).isomax = value; }
        }

        SlicesInfo? _slices = null;
        public SlicesInfo? Slices
        {
            get { return _slices; }
            set
            {
                _slices = value;
                (ValueItems as dynamic).slices = _slices?.ValueItems;
            }
        }

        SurfaceInfo? _surface = null;
        public SurfaceInfo? Surface
        {
            get { return _surface; }
            set
            {
                _surface = value;
                (ValueItems as dynamic).surface = _surface?.ValueItems;
            }
        }
    }
}
