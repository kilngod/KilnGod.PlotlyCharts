//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TransformsOptions.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{
	public class TransformsOptions : ValuesObject
	{

		public TransformsOptions() : base() { }

		AggregateOptions? _Aggregate = null;
		public AggregateOptions? Aggregate
		{
			get { return _Aggregate; }
			set
			{
				_Aggregate = value;
				(ValueItems as dynamic).aggregate = _Aggregate?.ValueItems;
			}
		}

		FilterOptions? _Filter = null;
		public FilterOptions? Filter
		{
			get { return _Filter; }
			set
			{
				_Filter = value;
				(ValueItems as dynamic).filter = _Filter?.ValueItems;
			}
		}

		GroupbyOptions? _Groupby = null;
		public GroupbyOptions? Groupby
		{
			get { return _Groupby; }
			set
			{
				_Groupby = value;
				(ValueItems as dynamic).groupby = _Groupby?.ValueItems;
			}
		}

		SortOptions? _Sort = null;
		public SortOptions? Sort
		{
			get { return _Sort; }
			set
			{
				_Sort = value;
				(ValueItems as dynamic).sort = _Sort?.ValueItems;
			}
		}

	}


}
