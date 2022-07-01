//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BarPolarLyout.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layouts
{

	public class BarPolarLayout : Layout
	{

		public BarPolarLayout():base()		{		}

		public double? BarGap
		{
			get { return (ValueItems as dynamic).bargap; }
			set { (ValueItems as dynamic).bargap = value; }
		}

		public BarPolarBarModeOptions? BarMode
		{
			get { return EnumerationStatic.GetValueFromDescription<BarPolarBarModeOptions> ((ValueItems as dynamic).barmode); }
			set { (ValueItems as dynamic).barmode = value?.GetDescription(); }
		}

	}
}

