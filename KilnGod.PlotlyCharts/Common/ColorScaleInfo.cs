//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ColorScaleInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class ColorScaleInfo : ValuesObject
	{

		public ColorScaleInfo():base()		{		}

		public object? Diverging
		{
			get { return (ValueItems as dynamic).diverging; }
			set { (ValueItems as dynamic).diverging = value; }
		}

		public object? Sequential
		{
			get { return (ValueItems as dynamic).sequential; }
			set { (ValueItems as dynamic).sequential = value; }
		}

		public object? SequentialMinus
		{
			get { return (ValueItems as dynamic).sequentialminus; }
			set { (ValueItems as dynamic).sequentialminus = value; }
		}

	}
}

