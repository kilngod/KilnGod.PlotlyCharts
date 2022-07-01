//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AnimationTransitionInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Animations
{

	public class AnimationTransitionInfo : ValuesObject
	{

		public AnimationTransitionInfo():base()		{		}

		public double? Duration
		{
			get { return (ValueItems as dynamic).duration; }
			set { (ValueItems as dynamic).duration = value; }
		}

		public EasingOptions? Easing
		{
			get { return EnumerationStatic.GetValueFromDescription<EasingOptions> ((ValueItems as dynamic).easing); }
			set { (ValueItems as dynamic).easing = value?.GetDescription(); }
		}

		public OrderingOptions? Ordering
		{
			get { return EnumerationStatic.GetValueFromDescription<OrderingOptions> ((ValueItems as dynamic).ordering); }
			set { (ValueItems as dynamic).ordering = value?.GetDescription(); }
		}

	}
}

