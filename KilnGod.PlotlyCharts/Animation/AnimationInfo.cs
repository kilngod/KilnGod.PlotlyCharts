//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AnimationInfo.cs
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

	public class AnimationInfo : ValuesObject
	{

		public AnimationInfo():base()		{		}

		public DirectionAnimationOptions? Direction
		{
			get { return EnumerationStatic.GetValueFromDescription<DirectionAnimationOptions> ((ValueItems as dynamic).direction); }
			set { (ValueItems as dynamic).direction = value?.GetDescription(); }
		}

		FrameInfo? _Frame = null;
		public FrameInfo? Frame
		{
			get { return _Frame; }
			set
			{
				_Frame = value;
				(ValueItems as dynamic).frame = _Frame?.ValueItems;
			}
		}

		public bool? FromCurrent
		{
			get { return (ValueItems as dynamic).fromcurrent; }
			set { (ValueItems as dynamic).fromcurrent = value; }
		}

		public ModeAnimationOptions? Mode
		{
			get { return EnumerationStatic.GetValueFromDescription<ModeAnimationOptions> ((ValueItems as dynamic).mode); }
			set { (ValueItems as dynamic).mode = value?.GetDescription(); }
		}

		AnimationTransitionInfo? _Transition = null;
		public AnimationTransitionInfo? Transition
		{
			get { return _Transition; }
			set
			{
				_Transition = value;
				(ValueItems as dynamic).transition = _Transition?.ValueItems;
			}
		}

	}
}

