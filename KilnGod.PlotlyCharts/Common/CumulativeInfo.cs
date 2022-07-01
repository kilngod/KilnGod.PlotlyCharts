//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CumulativeInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class CumulativeInfo : ValuesObject
	{

		public CumulativeInfo():base()		{		}

		public CurrentBinOptions? CurrentBin
		{
			get { return EnumerationStatic.GetValueFromDescription<CurrentBinOptions> ((ValueItems as dynamic).currentbin); }
			set { (ValueItems as dynamic).currentbin = value?.GetDescription(); }
		}

		public CumulativeDirectionOptions? Direction
		{
			get { return EnumerationStatic.GetValueFromDescription<CumulativeDirectionOptions> ((ValueItems as dynamic).direction); }
			set { (ValueItems as dynamic).direction = value?.GetDescription(); }
		}

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}

	}
}

