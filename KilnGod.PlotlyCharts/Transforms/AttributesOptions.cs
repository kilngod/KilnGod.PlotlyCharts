//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AttributesOptions.cs
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
	public class AttributesOptions : ValuesObject
	{

		public AttributesOptions() : base() { }

		AggregationsOptions? _Aggregations = null;
		public AggregationsOptions? Aggregations
		{
			get { return _Aggregations; }
			set
			{
				_Aggregations = value;
				(ValueItems as dynamic).aggregations = _Aggregations?.ValueItems;
			}
		}

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}

		public string? Groups
		{
			get { return (ValueItems as dynamic).groups; }
			set { (ValueItems as dynamic).groups = value; }
		}

	}
}
