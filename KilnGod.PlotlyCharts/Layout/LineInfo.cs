//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LineInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations;

namespace KilnGod.PlotlyCharts.Layout
{
    public class LineInfo : ValuesObject
    {
        public LineInfo() : base()
        {

        }

        public bool? AutoColorScale
        {
            get { return (ValueItems as dynamic).autocolorscale; }
            set { (ValueItems as dynamic).autocolorscale = value; }
        }

        public bool? Cauto
        {
            get { return (ValueItems as dynamic).cauto; }
            set { (ValueItems as dynamic).cauto = value; }
        }

        public float? Cmax
        {
            get { return (ValueItems as dynamic).cmax; }
            set { (ValueItems as dynamic).cmax = value; }
        }

        public float? Cmid
        {
            get { return (ValueItems as dynamic).cmid; }
            set { (ValueItems as dynamic).cmid = value; }
        }

        public float? Cmin
        {
            get { return (ValueItems as dynamic).cmin; }
            set { (ValueItems as dynamic).cmin = value; }
        }
        public object? Color
        {
            get { return (ValueItems as dynamic).color; }
            set { (ValueItems as dynamic).color = value; }
        }




        public object? ColorAxis
        {
            get { return (ValueItems as dynamic).coloraxis; }
            set { (ValueItems as dynamic).coloraxis = value; }
        }

        public object? ColorScale
        {
            get { return (ValueItems as dynamic).colorscale; }
            set { (ValueItems as dynamic).colorscale = value; }
        }

        GradientInfo? _Gradient = null;
        public GradientInfo? Gradient
        {
            get { return _Gradient; }
            set
            {
                _Gradient = value;
                (ValueItems as dynamic).gradient = _Gradient?.ValueItems;
            }
        }

        public LineShapeOptions? Shape
        {
            get { return EnumerationStatic.GetValueFromDescription<LineShapeOptions>((ValueItems as dynamic).shape); }
            set { (ValueItems as dynamic).shape = value?.GetDescription(); }
        }

        public DashOptions? Dash
        {
            get { return (ValueItems as dynamic).dash; }
            set { (ValueItems as dynamic).dash = value; }
        }

   

        public bool? ReverseScale
        {
            get { return (ValueItems as dynamic).reversescale; }
            set { (ValueItems as dynamic).reversescale = value; }
        }

        public object? Smoothing
        {
            get { return (ValueItems as dynamic).smoothing; }
            set { (ValueItems as dynamic).smoothing = value; }
        }

        public bool? Visible
        {
            get { return (ValueItems as dynamic).visible; }
            set { (ValueItems as dynamic).visible = value; }
        }


        public object? Width
        {
            get { return (ValueItems as dynamic).width; }
            set { (ValueItems as dynamic).width = value; }
        }
    }

}
