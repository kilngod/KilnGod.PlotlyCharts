//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ViolinTrace.cs
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
    public class ViolinTrace : Trace
    {
        public ViolinTrace() : base(TraceTypeOptions.Distribution_Violin)
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

        BoxInfo? _Box = null;
        public BoxInfo? Box
        {
            get { return _Box; }
            set
            {
                _Box = value;
                (ValueItems as dynamic).box = _Box?.ValueItems;
            }
        }

        LineInfo? _MeanLine = null;
        public LineInfo? MeanLine
        {
            get { return _MeanLine; }
            set
            {
                _MeanLine = value;
                (ValueItems as dynamic).meanline = _MeanLine?.ValueItems;
            }
        }

        public DensitySideOptions? Side
        {
            get
            {
                var result = (ValueItems as dynamic).side;
                return EnumerationStatic.GetValueFromDescription(result) as DensitySideOptions?;

            }
            set { (ValueItems as dynamic).side = value?.GetDescription(); }
        }

    }
}
