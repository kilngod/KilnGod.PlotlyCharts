//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CircleInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{

	public class CircleInfo : ValuesObject
	{

		public CircleInfo() : base() { }

		public float? Radius
		{
			get { return (ValueItems as dynamic).radius; }
			set { (ValueItems as dynamic).radius = value; }
		}

	}




}
