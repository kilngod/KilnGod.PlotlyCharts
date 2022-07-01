//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: DimensionAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class DimensionAxisInfo : ValuesObject
	{

		public DimensionAxisInfo():base()		{		}

		public bool? Matches
		{
			get { return (ValueItems as dynamic).matches; }
			set { (ValueItems as dynamic).matches = value; }
		}

		public CategoryDateLinearLogAxisTypeOptions? Type
		{
			get { return EnumerationStatic.GetValueFromDescription<CategoryDateLinearLogAxisTypeOptions> ((ValueItems as dynamic).type); }
			set { (ValueItems as dynamic).type = value?.GetDescription(); }
		}

	}
}

