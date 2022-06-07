//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: DimensionsInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layout
{
    public class DimensionsInfo : ValuesObject
    {

        public DimensionsInfo() : base() { }

        private List<DimensionItem> _Items = new List<DimensionItem>();

        public object? Value
        {
            get
            {
                object? result = null;
                if (_Items != null)
                {
                    bool hasValues = false;
                    List<object> results = new List<object>();

                    foreach (var item in _Items)
                    {
                        results.Add(item.ValueItems);
                        hasValues = true;
                    }
                    if (hasValues)
                    {
                        result = results;
                    }

                }
                return result;
            }
        }
        public List<DimensionItem> Items
        {
            get
            {
                return _Items;
            }

        }


    }
}
