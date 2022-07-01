//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FunnelLayout.cs
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

	public class FunnelLayout : Layout
	{

		public FunnelLayout():base()		{		}

		public double? FunnelGap
		{
			get { return (ValueItems as dynamic).funnelgap; }
			set { (ValueItems as dynamic).funnelgap = value; }
		}

		public double? FunnelGroupGap
		{
			get { return (ValueItems as dynamic).funnelgroupgap; }
			set { (ValueItems as dynamic).funnelgroupgap = value; }
		}

		public FunnelModeOptions? FunnelMode
		{
			get { return EnumerationStatic.GetValueFromDescription<FunnelModeOptions> ((ValueItems as dynamic).funnelmode); }
			set { (ValueItems as dynamic).funnelmode = value?.GetDescription(); }
		}

	}
}

