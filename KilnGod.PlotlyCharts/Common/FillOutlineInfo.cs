//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FillOutlineInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class FillOutlineInfo : ValuesObject
	{

		public FillOutlineInfo():base()		{		}

		public object? OutLineColor
		{
			get { return (ValueItems as dynamic).outlinecolor; }
			set { (ValueItems as dynamic).outlinecolor = value; }
		}

	}
}

