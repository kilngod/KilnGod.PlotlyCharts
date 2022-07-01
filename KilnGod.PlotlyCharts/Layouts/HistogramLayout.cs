//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HistogramLayout.cs
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

	public class HistogramLayout : Layout
	{

		public HistogramLayout():base()		{		}

		public double? BarGap
		{
			get { return (ValueItems as dynamic).bargap; }
			set { (ValueItems as dynamic).bargap = value; }
		}

		public double? BarGroupGap
		{
			get { return (ValueItems as dynamic).bargroupgap; }
			set { (ValueItems as dynamic).bargroupgap = value; }
		}

		public BarModeOptions? BarMode
		{
			get { return EnumerationStatic.GetValueFromDescription<BarModeOptions> ((ValueItems as dynamic).barmode); }
			set { (ValueItems as dynamic).barmode = value?.GetDescription(); }
		}

		public NormalizationOptions? BarNorm
		{
			get { return EnumerationStatic.GetValueFromDescription<NormalizationOptions> ((ValueItems as dynamic).barnorm); }
			set { (ValueItems as dynamic).barnorm = value?.GetDescription(); }
		}

	}
}

