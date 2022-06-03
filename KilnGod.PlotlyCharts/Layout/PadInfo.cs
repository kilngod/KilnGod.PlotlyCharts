//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PadInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{

	public class PadInfo : ValuesObject
	{

		public PadInfo() : base() { }

		public float? B
		{
			get { return (ValueItems as dynamic).b; }
			set { (ValueItems as dynamic).b = value; }
		}

		public float? L
		{
			get { return (ValueItems as dynamic).l; }
			set { (ValueItems as dynamic).l = value; }
		}

		public float? R
		{
			get { return (ValueItems as dynamic).r; }
			set { (ValueItems as dynamic).r = value; }
		}

		public float? T
		{
			get { return (ValueItems as dynamic).t; }
			set { (ValueItems as dynamic).t = value; }
		}

	}

}
