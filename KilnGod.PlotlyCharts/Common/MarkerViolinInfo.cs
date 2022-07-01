//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MarkerViolinInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class MarkerViolinInfo : ValuesObject
	{

		public MarkerViolinInfo():base()		{		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		LineMarkerViolinInfo? _Line = null;
		public LineMarkerViolinInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public object? OutlierColor
		{
			get { return (ValueItems as dynamic).outliercolor; }
			set { (ValueItems as dynamic).outliercolor = value; }
		}

		public double? Size
		{
			get { return (ValueItems as dynamic).size; }
			set { (ValueItems as dynamic).size = value; }
		}

		public SymbolOptions? Symbol
		{
			get { return EnumerationStatic.GetValueFromDescription<SymbolOptions> ((ValueItems as dynamic).symbol); }
			set { (ValueItems as dynamic).symbol = value?.GetDescription(); }
		}

	}
}

