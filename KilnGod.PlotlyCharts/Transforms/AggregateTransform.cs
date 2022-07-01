//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AggregateTransform.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{

	public class AggregateTransform : Transform
	{

		public AggregateTransform():base(TransformOptions.Aggregate)		{		}

		ItemList<AggregationItem>? _Aggregations = null;
		public ItemList<AggregationItem>? Aggregations
		{
			get
			{ 
				return _Aggregations;
			}
			set
			{ 
				_Aggregations = value;
				(ValueItems as dynamic).aggregations = _Aggregations?.Values;
			}
		}

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}

		public object? Groups
		{
			get { return (ValueItems as dynamic).groups; }
			set { (ValueItems as dynamic).groups = value; }
		}

	}
}

