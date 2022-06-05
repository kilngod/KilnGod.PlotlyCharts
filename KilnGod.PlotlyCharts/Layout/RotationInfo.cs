//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: RotationInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;



namespace KilnGod.PlotlyCharts.Layout
{
	public class RotationInfo : ValuesObject
	{

		public RotationInfo() : base() { }

		public double? Lat
		{
			get { return (ValueItems as dynamic).lat; }
			set { (ValueItems as dynamic).lat = value; }
		}

		public double? Lon
		{
			get { return (ValueItems as dynamic).lon; }
			set { (ValueItems as dynamic).lon = value; }
		}

		public double? Roll
		{
			get { return (ValueItems as dynamic).roll; }
			set { (ValueItems as dynamic).roll = value; }
		}

	}

}
