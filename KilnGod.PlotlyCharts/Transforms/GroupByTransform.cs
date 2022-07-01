//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GroupByTransform.cs
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

	public class GroupByTransform : Transform
	{

		public GroupByTransform():base(TransformOptions.GroupBy)		{		}

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}

		public object? Groups
		{
			get { return (ValueItems as dynamic).groups; }
			set { (ValueItems as dynamic).groups = value; }
		}

		public string? NameFormat
		{
			get { return (ValueItems as dynamic).nameformat; }
			set { (ValueItems as dynamic).nameformat = value; }
		}

		ItemList<StyleItem>? _Styles = null;
		public ItemList<StyleItem>? Styles
		{
			get
			{ 
				return _Styles;
			}
			set
			{ 
				_Styles = value;
				(ValueItems as dynamic).styles = _Styles?.Values;
			}
		}

	}
}

