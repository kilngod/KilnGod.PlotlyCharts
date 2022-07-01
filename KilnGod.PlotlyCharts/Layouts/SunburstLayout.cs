//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SunburstLayout.cs
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

	public class SunburstLayout : Layout
	{

		public SunburstLayout():base()		{		}

		public bool? ExtendSunburstColors
		{
			get { return (ValueItems as dynamic).extendsunburstcolors; }
			set { (ValueItems as dynamic).extendsunburstcolors = value; }
		}

		public object? SunburstColorway
		{
			get { return (ValueItems as dynamic).sunburstcolorway; }
			set { (ValueItems as dynamic).sunburstcolorway = value; }
		}

	}
}

