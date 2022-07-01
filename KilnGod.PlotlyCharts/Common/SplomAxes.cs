//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SplomAxes.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SplomAxes : ValuesObject
	{

		public SplomAxes():base()		{		}

		public object? ValType
		{
			get { return (ValueItems as dynamic).valtype; }
			set { (ValueItems as dynamic).valtype = value; }
		}

	}
}

