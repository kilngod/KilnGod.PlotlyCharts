//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ActiveShapeInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
	public class ActiveShapeInfo : ValuesObject
	{

		public ActiveShapeInfo() : base() { }

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		public object? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

	}



}
