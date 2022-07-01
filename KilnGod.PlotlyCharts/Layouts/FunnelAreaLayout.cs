//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FunnelAreaLayout.cs
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

	public class FunnelAreaLayout : Layout
	{

		public FunnelAreaLayout():base()		{		}

		public bool? ExtendFunnelAreaColors
		{
			get { return (ValueItems as dynamic).extendfunnelareacolors; }
			set { (ValueItems as dynamic).extendfunnelareacolors = value; }
		}

		public object? FunnelAreaColorway
		{
			get { return (ValueItems as dynamic).funnelareacolorway; }
			set { (ValueItems as dynamic).funnelareacolorway = value; }
		}

		public object? HiddenLabels
		{
			get { return (ValueItems as dynamic).hiddenlabels; }
			set { (ValueItems as dynamic).hiddenlabels = value; }
		}

	}
}

