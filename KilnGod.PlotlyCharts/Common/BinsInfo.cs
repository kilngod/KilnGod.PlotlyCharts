//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BinsInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class BinsInfo : ValuesObject
	{

		public BinsInfo():base()		{		}

		public object? End
		{
			get { return (ValueItems as dynamic).end; }
			set { (ValueItems as dynamic).end = value; }
		}

		public object? Size
		{
			get { return (ValueItems as dynamic).size; }
			set { (ValueItems as dynamic).size = value; }
		}

		public object? Start
		{
			get { return (ValueItems as dynamic).start; }
			set { (ValueItems as dynamic).start = value; }
		}

	}
}

