//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ContourCarpetTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ContourCarpetTrace : Trace
    {
        public ContourCarpetTrace() : base(TraceTypeOptions.Specialized_ContourCarpet)
        {

        }

        public bool? AutoContour
        {
            get { return (ValueItems as dynamic).autocontour; }
            set { (ValueItems as dynamic).autocontour = value; }
        }

        
        public object? A
        {
            get { return (ValueItems as dynamic).a; }
            set { (ValueItems as dynamic).a = value; }
        }

        public object? B
        {
            get { return (ValueItems as dynamic).b; }
            set { (ValueItems as dynamic).b = value; }
        }

        ABAxisInfo? _AAxis = null;
        public ABAxisInfo? AAxis
        {
            get { return _AAxis; }
            set
            {
                _AAxis = value;
                (ValueItems as dynamic).aaxis = _AAxis?.ValueItems;
            }
        }

       


      

        ABAxisInfo? _BAxis = null;
        public ABAxisInfo? BAxis
        {
            get { return _BAxis; }
            set
            {
                _BAxis = value;
                (ValueItems as dynamic).baxis = _BAxis?.ValueItems;
            }
        }

        ColorBarInfo? _ColorBar = null;
        public ColorBarInfo? ColorBar
        {
            get { return _ColorBar; }
            set
            {
                _ColorBar = value;
                (ValueItems as dynamic).colorbar = _ColorBar?.ValueItems;
            }
        }

        ContoursInfo? _Contours = null;
        public ContoursInfo? Contours
        {
            get { return _Contours; }
            set
            {
                _Contours = value;
                (ValueItems as dynamic).contours = _Contours?.ValueItems;
            }
        }

   
        public object? Z
        {
            get { return (ValueItems as dynamic).z; }
            set { (ValueItems as dynamic).z = value; }
        }
    }
}
