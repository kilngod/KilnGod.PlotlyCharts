//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MarginInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class MarginInfo : ValuesObject
	{

		public MarginInfo():base()		{		}

		public bool? AutoExpand
		{
			get { return (ValueItems as dynamic).autoexpand; }
			set { (ValueItems as dynamic).autoexpand = value; }
		}

		public double? B
		{
			get { return (ValueItems as dynamic).b; }
			set { (ValueItems as dynamic).b = value; }
		}

		public double? L
		{
			get { return (ValueItems as dynamic).l; }
			set { (ValueItems as dynamic).l = value; }
		}

		public double? Pad
		{
			get { return (ValueItems as dynamic).pad; }
			set { (ValueItems as dynamic).pad = value; }
		}

		public double? R
		{
			get { return (ValueItems as dynamic).r; }
			set { (ValueItems as dynamic).r = value; }
		}

		public double? T
		{
			get { return (ValueItems as dynamic).t; }
			set { (ValueItems as dynamic).t = value; }
		}

	}
}

