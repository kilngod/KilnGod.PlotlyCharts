//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Trace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Common;
using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Wrappers
{


    public class Trace : ValuesObject
    {
      
        public Trace(TraceOptions traceType)
        {
            TraceType = traceType.GetDescription();
        }


        /* its a bad idea to include every trace option on the same object as it will cause confusion.*/
        public string? TraceType
        {
            get { return (ValueItems as dynamic).type; }
            private set { (ValueItems as dynamic).type = value; }
        }


        public string? UIRevision
        {
            get { return (ValueItems as dynamic).uirevision; }
            set { (ValueItems as dynamic).uirevision = value; }
        }
    }
}
