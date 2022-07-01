//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GeoCenterInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class GeoCenterInfo : ValuesObject
	{

		public GeoCenterInfo():base()		{		}

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

	}
}

