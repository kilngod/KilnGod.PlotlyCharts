//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LineColorDashSmoothingWidthInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class LineColorDashSmoothingWidthInfo : ValuesObject
	{

		public LineColorDashSmoothingWidthInfo():base()		{		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public DashOptions? Dash
		{
			get { return EnumerationStatic.GetValueFromDescription<DashOptions> ((ValueItems as dynamic).dash); }
			set { (ValueItems as dynamic).dash = value?.GetDescription(); }
		}

		public double? Smoothing
		{
			get { return (ValueItems as dynamic).smoothing; }
			set { (ValueItems as dynamic).smoothing = value; }
		}

		public double? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

	}
}

