//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GaugeInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class GaugeInfo : ValuesObject
	{

		public GaugeInfo():base()		{		}

		GaugeAxisInfo? _Axis = null;
		public GaugeAxisInfo? Axis
		{
			get { return _Axis; }
			set
			{
				_Axis = value;
				(ValueItems as dynamic).axis = _Axis?.ValueItems;
			}
		}

		BarInfo? _Bar = null;
		public BarInfo? Bar
		{
			get { return _Bar; }
			set
			{
				_Bar = value;
				(ValueItems as dynamic).bar = _Bar?.ValueItems;
			}
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		public object? BorderColor
		{
			get { return (ValueItems as dynamic).bordercolor; }
			set { (ValueItems as dynamic).bordercolor = value; }
		}

		public double? BorderWidth
		{
			get { return (ValueItems as dynamic).borderwidth; }
			set { (ValueItems as dynamic).borderwidth = value; }
		}

		public ShapeGaugeOptions? Shape
		{
			get { return EnumerationStatic.GetValueFromDescription<ShapeGaugeOptions> ((ValueItems as dynamic).shape); }
			set { (ValueItems as dynamic).shape = value?.GetDescription(); }
		}

		ItemList<GaugeStepItem>? _Steps = null;
		public ItemList<GaugeStepItem>? Steps
		{
			get
			{ 
				return _Steps;
			}
			set
			{ 
				_Steps = value;
				(ValueItems as dynamic).steps = _Steps?.Values;
			}
		}

		ThresholdInfo? _Threshold = null;
		public ThresholdInfo? Threshold
		{
			get { return _Threshold; }
			set
			{
				_Threshold = value;
				(ValueItems as dynamic).threshold = _Threshold?.ValueItems;
			}
		}

	}
}

