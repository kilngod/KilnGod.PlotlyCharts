//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Histogram2DContourTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;

namespace KilnGod.PlotlyCharts.Traces
{
    public class Histogram2DContourTrace : Trace
    {
        public Histogram2DContourTrace() : base(TraceTypeOptions.Distribution_Histogram2DContour)
        {

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

        HoverLabelInfo? _HoverLabel = null;
        public HoverLabelInfo? HoverLabel
        {
            get { return _HoverLabel; }
            set
            {
                _HoverLabel = value;
                (ValueItems as dynamic).hoverlabel = _HoverLabel?.ValueItems;
            }
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

       


    }
}
