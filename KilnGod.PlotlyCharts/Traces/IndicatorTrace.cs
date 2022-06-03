//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: IndicatorTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layout;
using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class IndicatorTrace : Trace
    {
        public IndicatorTrace() : base(TraceTypeOptions.Finance_Indicator)
        {

        }

        DeltaInfo? _DeltaInfo = null;
        public DeltaInfo? Delta
        {
            get { return _DeltaInfo; }
            set
            {
                _DeltaInfo = value;
                (ValueItems as dynamic).delta = _DeltaInfo?.ValueItems;
            }
        }


        DomainInfo? _Domain = null;
        public DomainInfo? Domain
        {
            get { return _Domain; }
            set
            {
                _Domain = value;
                (ValueItems as dynamic).domain = _Domain?.ValueItems;
            }
        }

        GaugeInfo? _Gauge = null;
        public GaugeInfo? Gauge
        {
            get { return _Gauge; }
            set
            {
                _Gauge = value;
                (ValueItems as dynamic).guage = _Gauge?.ValueItems;
            }
        }

        public object? Value
        {
            get { return (ValueItems as dynamic).value; }
            set { (ValueItems as dynamic).value = value; }
        }
    }
}
