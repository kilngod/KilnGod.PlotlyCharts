//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FunnelAreaTrace.cs
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
    public class FunnelAreaTrace : Trace
    {
        public FunnelAreaTrace() : base(Enumerations.TraceTypeOptions.Finance_FunnelArea) { }


        public object? Values
        {
            get { return (ValueItems as dynamic).values; }
            set { (ValueItems as dynamic).values = value; }
        }

       

    }
}
