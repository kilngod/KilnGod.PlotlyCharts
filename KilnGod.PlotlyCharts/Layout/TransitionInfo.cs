//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TransitionInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{

    public class TransitionInfo : ValuesObject
	{

		public TransitionInfo() : base() { }

		public double? Duration
		{
			get { return (ValueItems as dynamic).duration; }
			set { (ValueItems as dynamic).duration = value; }
		}

		public EasingOptions? Easing
		{
			get { return EnumerationStatic.GetValueFromDescription<EasingOptions>((ValueItems as dynamic).easing); }
			set { (ValueItems as dynamic).easing = value?.GetDescription(); }
		}

	}



}
