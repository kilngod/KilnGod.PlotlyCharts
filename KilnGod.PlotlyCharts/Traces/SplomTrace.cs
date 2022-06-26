//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SplomTrace.cs
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
    public class SplomTrace : Trace
    {
        public SplomTrace() : base(TraceTypeOptions.Specialized_Splom)
        {

        }


        ItemList<DimensionItem>? _DimensionsItems = null;
        public ItemList<DimensionItem>? Dimensions
        {
            get
            {
                return _DimensionsItems;
            }
            set
            {
                _DimensionsItems = value;
                (ValueItems as dynamic).dimensions = _DimensionsItems?.Values;
            }
        }

    }
}
