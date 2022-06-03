//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AggregationOption.cs
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
	public class AggregateOptions : ValuesObject
	{

		public AggregateOptions() : base() { }

		AttributesOptions? _Attributes = null;
		public AttributesOptions? Attributes
		{
			get { return _Attributes; }
			set
			{
				_Attributes = value;
				(ValueItems as dynamic).attributes = _Attributes?.ValueItems;
			}
		}

	}
}
