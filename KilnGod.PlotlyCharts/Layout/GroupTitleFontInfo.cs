//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GroupTitleFontInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{

	public class GroupTitleFontInfo : ValuesObject
	{

		public GroupTitleFontInfo() : base() { }

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

		public float? Size
		{
			get { return (ValueItems as dynamic).size; }
			set { (ValueItems as dynamic).size = value; }
		}

	}

}
