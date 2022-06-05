//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CarpetTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class CarpetTrace : Trace
    {
        public CarpetTrace() : base(TraceTypeOptions.Specialized_Carpet)
        {

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
    }
}
