//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: IcicleLayout.cs
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

	public class IcicleLayout : Layout
	{

		public IcicleLayout():base()		{		}

		public bool? ExtendIcicleColors
		{
			get { return (ValueItems as dynamic).extendiciclecolors; }
			set { (ValueItems as dynamic).extendiciclecolors = value; }
		}

		public object? IcicleColorway
		{
			get { return (ValueItems as dynamic).iciclecolorway; }
			set { (ValueItems as dynamic).iciclecolorway = value; }
		}

	}
}

