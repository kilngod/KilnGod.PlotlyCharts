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
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
	public class MarginInfo : ValuesObject
	{

		public MarginInfo() : base() { }

		public bool? Autoexpand
		{
			get { return (ValueItems as dynamic).autoexpand; }
			set { (ValueItems as dynamic).autoexpand = value; }
		}

		public int? Bottom
		{
			get { return (ValueItems as dynamic).b; }
			set { (ValueItems as dynamic).b = value; }
		}

		public int? Left
		{
			get { return (ValueItems as dynamic).l; }
			set { (ValueItems as dynamic).l = value; }
		}

		public int? Pad
		{
			get { return (ValueItems as dynamic).pad; }
			set { (ValueItems as dynamic).pad = value; }
		}

		public int? Right
		{
			get { return (ValueItems as dynamic).r; }
			set { (ValueItems as dynamic).r = value; }
		}

		public int? Top
		{
			get { return (ValueItems as dynamic).t; }
			set { (ValueItems as dynamic).t = value; }
		}

	}


}
