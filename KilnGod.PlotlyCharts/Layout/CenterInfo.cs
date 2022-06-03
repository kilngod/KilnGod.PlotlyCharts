//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CenterInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{

	public class CenterInfo : ValuesObject
	{

		public CenterInfo() : base() { }

		public float? Lat
		{
			get { return (ValueItems as dynamic).lat; }
			set { (ValueItems as dynamic).lat = value; }
		}

		public float? Lon
		{
			get { return (ValueItems as dynamic).lon; }
			set { (ValueItems as dynamic).lon = value; }
		}

	}


}
