//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ModeBarInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
	public class ModeBarInfo : ValuesObject
	{

		public ModeBarInfo() : base() { }

		public object? ActiveColor
		{
			get { return (ValueItems as dynamic).activecolor; }
			set { (ValueItems as dynamic).activecolor = value; }
		}

		public string? Add
		{
			get { return (ValueItems as dynamic).add; }
			set { (ValueItems as dynamic).add = value; }
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public OrientationOptions? Orientation
		{
			get { return EnumerationStatic.GetValueFromDescription<OrientationOptions>((ValueItems as dynamic).orientation); }
			set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
		}

		public string? Remove
		{
			get { return (ValueItems as dynamic).remove; }
			set { (ValueItems as dynamic).remove = value; }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

	}


}
