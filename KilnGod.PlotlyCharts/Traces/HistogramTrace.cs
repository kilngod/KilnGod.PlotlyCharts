//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HistogramTrace.cs
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
    public class HistogramTrace : Trace
    {
        public HistogramTrace() : base(TraceTypeOptions.Distribution_Histogram) 
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

        public bool? AutoBinX
        {
            get { return (ValueItems as dynamic).autobinx; }
            set { (ValueItems as dynamic).autobinx = value; }
        }



        BinInfo? _XBins = null;
        public BinInfo? XBins
        {
            get { return _XBins; }
            set
            {
                _XBins = value;
                (ValueItems as dynamic).xbins = _XBins?.ValueItems;
            }
        }

    }
}
