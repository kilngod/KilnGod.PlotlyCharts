//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AnimationsEnums.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Enumerations.AnimationEnums
{
	/******************************
	*** Enum Name: direction

	*** Description: The direction in which to play the frames triggered by the animation call
	******************************/

	public enum DirectionOptions
	{
		[Description("forward")]
		Forward,
		[Description("reverse")]
		Reverse
	}

	/******************************
	*** Enum Name: easing

	*** Description: The easing function used for the transition
	******************************/

	public enum EasingOptions
	{
		[Description("linear")]
		Linear,
		[Description("quad")]
		Quad,
		[Description("cubic")]
		Cubic,
		[Description("sin")]
		Sin,
		[Description("exp")]
		Exp,
		[Description("circle")]
		Circle,
		[Description("elastic")]
		Elastic,
		[Description("back")]
		Back,
		[Description("bounce")]
		Bounce,
		[Description("linear-in")]
		LinearIn,
		[Description("quad-in")]
		QuadIn,
		[Description("cubic-in")]
		CubicIn,
		[Description("sin-in")]
		SinIn,
		[Description("exp-in")]
		ExpIn,
		[Description("circle-in")]
		CircleIn,
		[Description("elastic-in")]
		ElasticIn,
		[Description("back-in")]
		BackIn,
		[Description("bounce-in")]
		BounceIn,
		[Description("linear-out")]
		LinearOut,
		[Description("quad-out")]
		QuadOut,
		[Description("cubic-out")]
		CubicOut,
		[Description("sin-out")]
		SinOut,
		[Description("exp-out")]
		ExpOut,
		[Description("circle-out")]
		CircleOut,
		[Description("elastic-out")]
		ElasticOut,
		[Description("back-out")]
		BackOut,
		[Description("bounce-out")]
		BounceOut,
		[Description("linear-in-out")]
		LinearInOut,
		[Description("quad-in-out")]
		QuadInOut,
		[Description("cubic-in-out")]
		CubicInOut,
		[Description("sin-in-out")]
		SinInOut,
		[Description("exp-in-out")]
		ExpInOut,
		[Description("circle-in-out")]
		CircleInOut,
		[Description("elastic-in-out")]
		ElasticInOut,
		[Description("back-in-out")]
		BackInOut,
		[Description("bounce-in-out")]
		BounceInOut
	}

	/******************************
	*** Enum Name: mode

	*** Description: Describes how a new animate call interacts with currently-running animations. If `immediate`, current animations are interrupted and the new animation is started. If `next`, the current frame is allowed to complete, after which the new animation is started. If `afterall` all existing frames are animated to completion before the new animation is started.
	******************************/

	public enum ModeOptions
	{
		[Description("immediate")]
		Immediate,
		[Description("next")]
		Next,
		[Description("afterall")]
		Afterall
	}

	/******************************
	*** Enum Name: ordering

	*** Description: Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
	******************************/

	public enum OrderingOptions
	{
		[Description("layout first")]
		LayoutFirst,
		[Description("traces first")]
		TracesFirst
	}


}
