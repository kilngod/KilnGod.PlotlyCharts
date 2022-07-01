//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PieLayout.cs
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

	public class PieLayout : Layout
	{

		public PieLayout():base()		{		}

		public bool? ExtendPieColors
		{
			get { return (ValueItems as dynamic).extendpiecolors; }
			set { (ValueItems as dynamic).extendpiecolors = value; }
		}

		public object? HiddenLabels
		{
			get { return (ValueItems as dynamic).hiddenlabels; }
			set { (ValueItems as dynamic).hiddenlabels = value; }
		}

		public object? PieColorway
		{
			get { return (ValueItems as dynamic).piecolorway; }
			set { (ValueItems as dynamic).piecolorway = value; }
		}

	}
}

