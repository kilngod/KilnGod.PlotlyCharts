//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: StyleItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{
	public class StyleItem : ValuesObject
	{

		public StyleItem() : base() { }

		public string? Target
		{
			get { return (ValueItems as dynamic).target; }
			set { (ValueItems as dynamic).target = value; }
		}

		public object? Value
		{
			get { return (ValueItems as dynamic).value; }
			set { (ValueItems as dynamic).value = value; }
		}

	}


}
