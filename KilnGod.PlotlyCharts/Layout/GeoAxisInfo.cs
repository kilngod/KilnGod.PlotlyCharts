//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GeoAxisInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;


namespace KilnGod.PlotlyCharts.Layout
{

	public class GeoAxisInfo : ValuesObject
	{

		public GeoAxisInfo() : base() { }

		public double? DTick
		{
			get { return (ValueItems as dynamic).dtick; }
			set { (ValueItems as dynamic).dtick = value; }
		}

		public object? GridColor
		{
			get { return (ValueItems as dynamic).gridcolor; }
			set { (ValueItems as dynamic).gridcolor = value; }
		}

		public double? Gridwidth
		{
			get { return (ValueItems as dynamic).gridwidth; }
			set { (ValueItems as dynamic).gridwidth = value; }
		}

		public object? Range
		{
			get { return (ValueItems as dynamic).range; }
			set { (ValueItems as dynamic).range = value; }
		}

		public bool? Showgrid
		{
			get { return (ValueItems as dynamic).showgrid; }
			set { (ValueItems as dynamic).showgrid = value; }
		}

		public double? Tick0
		{
			get { return (ValueItems as dynamic).tick0; }
			set { (ValueItems as dynamic).tick0 = value; }
		}

	}


}
