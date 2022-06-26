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

        public object? BranchValues
        {
            get { return (ValueItems as dynamic).branchvalues; }
            set { (ValueItems as dynamic).branchvalues = value; }
        }

        public object? Count
        {
            get { return (ValueItems as dynamic).count; }
            set { (ValueItems as dynamic).count = value; }
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

        public object? Leaf
        {
            get { return (ValueItems as dynamic).leaf; }
            set { (ValueItems as dynamic).leaf = value; }
        }

        public int? MaxDepth
        {
            get { return (ValueItems as dynamic).maxdepth; }
            set { (ValueItems as dynamic).maxdepth = value; }
        }
        public object? PathBar
        {
            get { return (ValueItems as dynamic).pathbar; }
            set { (ValueItems as dynamic).pathbar = value; }
        }

        public object? Parents
        {
            get { return (ValueItems as dynamic).parents; }
            set { (ValueItems as dynamic).parents = value; }
        }

        public object? Sort
        {
            get { return (ValueItems as dynamic).sort; }
            set { (ValueItems as dynamic).sort = value; }
        }

        public object? Root
        {
            get { return (ValueItems as dynamic).root; }
            set { (ValueItems as dynamic).root = value; }
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

        public object? Values
        {
            get { return (ValueItems as dynamic).values; }
            set { (ValueItems as dynamic).values = value; }
        }
    }

}
