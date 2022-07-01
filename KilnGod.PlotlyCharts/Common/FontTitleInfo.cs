//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FontTitleInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class FontTitleInfo : ValuesObject
	{

		public FontTitleInfo():base()		{		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public string? Family
		{
			get { return (ValueItems as dynamic).family; }
			set { (ValueItems as dynamic).family = value; }
		}

		public object? Size
		{
			get { return (ValueItems as dynamic).size; }
			set { (ValueItems as dynamic).size = value; }
		}

	}
}

