//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AggregationsOptions.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{
	public class AggregationsOptions : ValuesObject
	{

		public AggregationsOptions() : base() { }

		ItemList<AggregationItem>? _AggregationItems = null;
		public ItemList<AggregationItem>? AggregationItems
		{
			get { return _AggregationItems; }
			set
			{
				_AggregationItems = value;
				(ValueItems as dynamic).aggregations = _AggregationItems?.Values;
			}			
		}

	}

}
