//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LineMarkerViolinInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class LineMarkerViolinInfo : ValuesObject
	{

		public LineMarkerViolinInfo():base()		{		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public object? OutlierColor
		{
			get { return (ValueItems as dynamic).outliercolor; }
			set { (ValueItems as dynamic).outliercolor = value; }
		}

		public double? OutlierWidth
		{
			get { return (ValueItems as dynamic).outlierwidth; }
			set { (ValueItems as dynamic).outlierwidth = value; }
		}

		public double? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

	}
}

