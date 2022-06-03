//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TreeMapTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
namespace KilnGod.PlotlyCharts.Traces
{
    public class TreeMapTrace : Trace
    {
        public TreeMapTrace() : base(TraceTypeOptions.Specialized_TreeMap)
        {
        }


        public object? Ids
        {
            get { return (ValueItems as dynamic).ids; }
            set { (ValueItems as dynamic).ids = value; }
        }

        public object? Labels
        {
            get { return (ValueItems as dynamic).labels; }
            set { (ValueItems as dynamic).labels = value; }
        }

        public object? Parents
        {
            get { return (ValueItems as dynamic).parents; }
            set { (ValueItems as dynamic).parents = value; }
        }

    }

}
