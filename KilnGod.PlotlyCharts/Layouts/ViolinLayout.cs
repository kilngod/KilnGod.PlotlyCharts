//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ViolinLayout.cs
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

	public class ViolinLayout : Layout
	{

		public ViolinLayout():base()		{		}

		public double? ViolinGap
		{
			get { return (ValueItems as dynamic).violingap; }
			set { (ValueItems as dynamic).violingap = value; }
		}

		public double? ViolinGroupGap
		{
			get { return (ValueItems as dynamic).violingroupgap; }
			set { (ValueItems as dynamic).violingroupgap = value; }
		}

		public GroupOverlayBoxModeOptions? ViolinMode
		{
			get { return EnumerationStatic.GetValueFromDescription<GroupOverlayBoxModeOptions> ((ValueItems as dynamic).violinmode); }
			set { (ValueItems as dynamic).violinmode = value?.GetDescription(); }
		}

	}
}

