//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TableTrace.cs
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
    public class TableTrace : Trace
    {
        public TableTrace() : base(TraceTypeOptions.Specialized_Table)
        {
        }


        HeaderInfo? _Header = null;
        public HeaderInfo? Header
        {
            get { return _Header; }
            set
            {
                _Header = value;
                (ValueItems as dynamic).header = _Header?.ValueItems;
            }
        }

        CellsInfo? _Cells = null;
        public CellsInfo? Cells
        {
            get { return _Cells; }
            set
            {
                _Cells = value;
                (ValueItems as dynamic).cells = _Cells?.ValueItems;
            }
        }

       


    }
}
