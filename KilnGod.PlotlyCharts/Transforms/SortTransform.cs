//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SortTransform.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{

	public class SortTransform : Transform
	{

		public SortTransform():base(TransformOptions.Sort)		{		}

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}

		public OrderOptions? Order
		{
			get { return EnumerationStatic.GetValueFromDescription<OrderOptions> ((ValueItems as dynamic).order); }
			set { (ValueItems as dynamic).order = value?.GetDescription(); }
		}

		public string? Target
		{
			get { return (ValueItems as dynamic).target; }
			set { (ValueItems as dynamic).target = value; }
		}

	}
}

