//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ButtonsItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{

	public class ButtonsItem : ValuesObject
	{

		public ButtonsItem() : base() { }

		public object? Args
		{
			get { return (ValueItems as dynamic).args; }
			set { (ValueItems as dynamic).args = value; }
		}

		public object? Args2
		{
			get { return (ValueItems as dynamic).args2; }
			set { (ValueItems as dynamic).args2 = value; }
		}

		public bool? Execute
		{
			get { return (ValueItems as dynamic).execute; }
			set { (ValueItems as dynamic).execute = value; }
		}

		public string? Label
		{
			get { return (ValueItems as dynamic).label; }
			set { (ValueItems as dynamic).label = value; }
		}

		public MethodOptions? Method
		{
			get { return EnumerationStatic.GetValueFromDescription<MethodOptions>((ValueItems as dynamic).method); }
			set { (ValueItems as dynamic).method = value?.GetDescription(); }
		}

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public string? Templateitemname
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

	}

}
