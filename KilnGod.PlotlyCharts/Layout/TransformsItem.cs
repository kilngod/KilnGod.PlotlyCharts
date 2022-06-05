//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ShapeItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Transforms;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class TransformsItem : ValuesObject
    {

        public TransformsItem() : base() { }



        ItemList<AggregationItem>? _AggregationItems = null;
        public ItemList<AggregationItem>? Aggregations
        {
            get { return _AggregationItems; }
            set
            {
                _AggregationItems = value;
                (ValueItems as dynamic).aggregations = _AggregationItems?.Values;
            }
        }

        public object? Groups
        {
            get { return (ValueItems as dynamic).groups; }
            set { (ValueItems as dynamic).groups = value; }
        }

        public TransformTypeOptions? TransformsType
        {
			get { return EnumerationStatic.GetValueFromDescription<TransformTypeOptions>((ValueItems as dynamic).type); }
            set { (ValueItems as dynamic).type = value?.GetDescription(); }
        }

       

    }
}
