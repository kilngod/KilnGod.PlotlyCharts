//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ProjectionRenderInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class ProjectionRenderInfo : ValuesObject
	{

		public ProjectionRenderInfo():base()		{		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public double? Scale
		{
			get { return (ValueItems as dynamic).scale; }
			set { (ValueItems as dynamic).scale = value; }
		}

		public bool? Show
		{
			get { return (ValueItems as dynamic).show; }
			set { (ValueItems as dynamic).show = value; }
		}

	}
}

