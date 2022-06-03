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

using System.Dynamic;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.AnimationEnums;

namespace KilnGod.PlotlyCharts.Animations
{

	public class TransitionInfo : ValuesObject
	{

		public TransitionInfo() : base() { }

		public float? Duration
		{
			get { return (ValueItems as dynamic).duration; }
			set { (ValueItems as dynamic).duration = value; }
		}

		public EasingOptions? Easing
		{
			get { return EnumerationStatic.GetValueFromDescription<EasingOptions>((ValueItems as dynamic).easing); }
			set { (ValueItems as dynamic).easing = value?.GetDescription(); }
		}

		public OrderingOptions? Ordering
		{
			get { return EnumerationStatic.GetValueFromDescription<OrderingOptions>((ValueItems as dynamic).ordering); }
			set { (ValueItems as dynamic).ordering = value?.GetDescription(); }
		}

	}




}
