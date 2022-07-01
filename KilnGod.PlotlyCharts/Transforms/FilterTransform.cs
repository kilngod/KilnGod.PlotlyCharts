//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FilterTransform.cs
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

	public class FilterTransform : Transform
	{

		public FilterTransform():base(TransformOptions.Filter)		{		}

		public bool? Enabled
		{
			get { return (ValueItems as dynamic).enabled; }
			set { (ValueItems as dynamic).enabled = value; }
		}

		public OperationOptions? Operation
		{
			get { return EnumerationStatic.GetValueFromDescription<OperationOptions> ((ValueItems as dynamic).operation); }
			set { (ValueItems as dynamic).operation = value?.GetDescription(); }
		}

		public bool? PreserveGaps
		{
			get { return (ValueItems as dynamic).preservegaps; }
			set { (ValueItems as dynamic).preservegaps = value; }
		}

		public string? Target
		{
			get { return (ValueItems as dynamic).target; }
			set { (ValueItems as dynamic).target = value; }
		}

		public CalendarOptions? TargetCalendar
		{
			get { return EnumerationStatic.GetValueFromDescription<CalendarOptions> ((ValueItems as dynamic).targetcalendar); }
			set { (ValueItems as dynamic).targetcalendar = value?.GetDescription(); }
		}

		public object? Value
		{
			get { return (ValueItems as dynamic).value; }
			set { (ValueItems as dynamic).value = value; }
		}

		public CalendarOptions? ValueCalendar
		{
			get { return EnumerationStatic.GetValueFromDescription<CalendarOptions> ((ValueItems as dynamic).valuecalendar); }
			set { (ValueItems as dynamic).valuecalendar = value?.GetDescription(); }
		}

	}
}

