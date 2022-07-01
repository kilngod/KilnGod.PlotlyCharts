//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: WaterfallLayout.cs
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

	public class WaterfallLayout : Layout
	{

		public WaterfallLayout():base()		{		}

		public double? WaterfallGap
		{
			get { return (ValueItems as dynamic).waterfallgap; }
			set { (ValueItems as dynamic).waterfallgap = value; }
		}

		public double? WaterfallGroupGap
		{
			get { return (ValueItems as dynamic).waterfallgroupgap; }
			set { (ValueItems as dynamic).waterfallgroupgap = value; }
		}

		public GroupOverlayBoxModeOptions? WaterfallMode
		{
			get { return EnumerationStatic.GetValueFromDescription<GroupOverlayBoxModeOptions> ((ValueItems as dynamic).waterfallmode); }
			set { (ValueItems as dynamic).waterfallmode = value?.GetDescription(); }
		}

	}
}

