//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TransformTypeOptions.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Wrappers
{
    public enum TransformOptions
    {
        [Description("aggregate")]
        Aggregate,
        [Description("filter")]
        Filter,
        [Description("groupby")]
        GroupBy,
        [Description("Sort")]
        Sort
    }
}
