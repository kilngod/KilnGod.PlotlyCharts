//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BoxLayout.cs
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

	public class BoxLayout : Layout
	{

		public BoxLayout():base()		{		}

		public double? BoxGap
		{
			get { return (ValueItems as dynamic).boxgap; }
			set { (ValueItems as dynamic).boxgap = value; }
		}

		public double? BoxGroupGap
		{
			get { return (ValueItems as dynamic).boxgroupgap; }
			set { (ValueItems as dynamic).boxgroupgap = value; }
		}

		public GroupOverlayBoxModeOptions? BoxMode
		{
			get { return EnumerationStatic.GetValueFromDescription<GroupOverlayBoxModeOptions> ((ValueItems as dynamic).boxmode); }
			set { (ValueItems as dynamic).boxmode = value?.GetDescription(); }
		}

	}
}

