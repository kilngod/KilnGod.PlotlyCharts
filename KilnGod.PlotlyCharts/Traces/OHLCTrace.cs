//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: OHLCTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.Traces
{

    public class OHLCTrace : Trace
    {
        public OHLCTrace() : base(Enumerations.TraceTypeOptions.Finance_Ohlc)
        {

        }

        public object? X
        {
            get { return (ValueItems as dynamic).x; }
            set { (ValueItems as dynamic).x = value; }
        }

        public object? Close
        {
            get { return (ValueItems as dynamic).close; }
            set { (ValueItems as dynamic).close = value; }
        }


        public object? High
        {
            get { return (ValueItems as dynamic).high; }
            set { (ValueItems as dynamic).high = value; }
        }


        public object? Low
        {
            get { return (ValueItems as dynamic).low; }
            set { (ValueItems as dynamic).low = value; }
        }

        public object? Open
        {
            get { return (ValueItems as dynamic).open; }
            set { (ValueItems as dynamic).open = value; }
        }


    }
}
