//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TreemapLayout.cs
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

	public class TreemapLayout : Layout
	{

		public TreemapLayout():base()		{		}

		public bool? ExtendTreemapColors
		{
			get { return (ValueItems as dynamic).extendtreemapcolors; }
			set { (ValueItems as dynamic).extendtreemapcolors = value; }
		}

		public object? TreemapColorway
		{
			get { return (ValueItems as dynamic).treemapcolorway; }
			set { (ValueItems as dynamic).treemapcolorway = value; }
		}

	}
}

