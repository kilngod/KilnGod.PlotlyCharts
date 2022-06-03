//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SunburstTrace.cs
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
    public class IcicleTrace : Trace
    {
        public IcicleTrace() : base(TraceTypeOptions.Specialized_Icicle)
        { }



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

        public int? MaxDepth
        {
            get { return (ValueItems as dynamic).maxdepth; }
            set { (ValueItems as dynamic).maxdepth = value; }
        }
        public object? Parents
        {
            get { return (ValueItems as dynamic).parents; }
            set { (ValueItems as dynamic).parents = value; }
        }

       

        TilingInfo? _Tiling = null;
        public TilingInfo? Tiling
        {
            get { return _Tiling; }
            set
            {
                _Tiling = value;
                (ValueItems as dynamic).tiling = _Tiling?.ValueItems;
            }
        }
    }

}
