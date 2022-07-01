//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MarkerFunnelAreaInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class MarkerFunnelAreaInfo : ValuesObject
	{

		public MarkerFunnelAreaInfo():base()		{		}

		public object? Colors
		{
			get { return (ValueItems as dynamic).colors; }
			set { (ValueItems as dynamic).colors = value; }
		}

		LineColorWidthsInfo? _Line = null;
		public LineColorWidthsInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

	}
}

