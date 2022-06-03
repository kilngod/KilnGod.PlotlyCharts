//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ParallelCategoriesTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Layout;

namespace KilnGod.PlotlyCharts.Traces
{
    public class ParallelCategoriesTrace : Trace
    {
        public ParallelCategoriesTrace() : base(TraceTypeOptions.Specialized_ParCats)
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

        public ArrangementOptions? Arrangement
        {
            get { return EnumerationStatic.GetValueFromDescription<ArrangementOptions>((ValueItems as dynamic).arrangement); }
            set { (ValueItems as dynamic).arrangement = value?.GetDescription(); }
        }

        public HoverOnOptions? HoverOn
        {
            get { return EnumerationStatic.GetValueFromDescription<ArrangementOptions>((ValueItems as dynamic).hoveron); }
            set { (ValueItems as dynamic).hoveron = value?.GetDescription(); }
        }

        public HoverInfoOptions? HoverInfo
        {
            get { return EnumerationStatic.GetValueFromDescription<ArrangementOptions>((ValueItems as dynamic).hoverinfo); }
            set { (ValueItems as dynamic).hoverinfo = value?.GetDescription(); }
        }

        FontInfo? _LabelFont = null;
        public FontInfo? LabelFont
        {
            get { return _LabelFont; }
            set
            {
                _LabelFont = value;
                (ValueItems as dynamic).labelfont = _LabelFont?.ValueItems;
            }
        }
    }
}
