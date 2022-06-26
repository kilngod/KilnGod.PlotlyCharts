//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SankeyTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Traces
{
    public class SankeyTrace : Trace
    {
        public SankeyTrace() : base(TraceTypeOptions.Specialized_Sankey)
        {

        }


        public ArrangementOptions? Arrangement
        {
            get { return EnumerationStatic.GetValueFromDescription<ArrangementOptions>((ValueItems as dynamic).arrangement); }
            set { (ValueItems as dynamic).arrangement = value?.GetDescription(); }
        }

        NodeInfo? _Node = null;
        public NodeInfo? Node
        {
            get { return _Node; }
            set
            {
                _Node = value;
                (ValueItems as dynamic).node = _Node?.ValueItems;
            }
        }

        LinkInfo? _Link = null;
        public LinkInfo? Link
        {
            get { return _Link; }
            set
            {
                _Link = value;
                (ValueItems as dynamic).link = _Link?.ValueItems;
            }
        }

    }
}
