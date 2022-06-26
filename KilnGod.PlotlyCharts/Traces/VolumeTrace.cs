//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: VolumeTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Layout;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class VolumeTrace : Trace
    {

        //https://metacpan.org/pod/Chart::Plotly::Trace::Volume

          //  https://plotly.com/python/3d-volume-plots/
        public VolumeTrace() : base(TraceTypeOptions.ThreeD_Volume)
        {

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


        public bool? AutoColorScale
        {
            get { return (ValueItems as dynamic).autocolorscale; }
            set { (ValueItems as dynamic).autocolorscale = value; }
        }

        public object? ColorScale
        {
            get { return (ValueItems as dynamic).colorscale; }
            set { (ValueItems as dynamic).colorscale = value; }
        }


        ContourInfo? _Contour = null;
        public ContourInfo? Contour
        {
            get { return _Contour; }
            set
            {
                _Contour = value;
                (ValueItems as dynamic).contour = _Contour?.ValueItems;
            }
        }

        public bool? FlatShading
        {
            get { return (ValueItems as dynamic).flatshading; }
            set { (ValueItems as dynamic).flatshading = value; }
        }

        LightingInfo? _LightingInfo = null;
        public LightingInfo? Lighting
        {
            get { return _LightingInfo; }
            set
            {
                _LightingInfo = value;
                (ValueItems as dynamic).lighting = _LightingInfo?.ValueItems;
            }
        }

        public object? OpacityScale
        {
            get { return (ValueItems as dynamic).opacityscale; }
            set { (ValueItems as dynamic).opacityscale = value; }
        }


        public bool? ReverseScale
        {
            get { return (ValueItems as dynamic).reversescale; }
            set { (ValueItems as dynamic).reversescale = value; }
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

        SpaceFrameInfo? _SpaceFrameInfo = null;
        public SpaceFrameInfo? SpaceFrame
        {
            get { return _SpaceFrameInfo; }
            set
            {
                _SpaceFrameInfo = value;
                (ValueItems as dynamic).spaceframe = _SpaceFrameInfo?.ValueItems;
            }
        }

        SurfaceInfo? _SurfaceInfo = null;
        public SurfaceInfo? Surface
        {
            get { return _SurfaceInfo; }
            set
            {
                _SurfaceInfo = value;
                (ValueItems as dynamic).surface = _SurfaceInfo?.ValueItems;
            }
        }

        public object? Value
        {
            get { return (ValueItems as dynamic).value; }
            set { (ValueItems as dynamic).value = value; }
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
       

    }
}
