//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BoxInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class BoxInfo : ValuesObject
	{

		public BoxInfo():base()		{		}

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		LineColorWidthInfo? _Line = null;
		public LineColorWidthInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		public double? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

	}
}

