//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FrameInfo.cs
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
	public class FrameInfo : ValuesObject
	{

		public FrameInfo() : base() { }

		public float? Duration
		{
			get { return (ValueItems as dynamic).duration; }
			set { (ValueItems as dynamic).duration = value; }
		}

		public bool? Redraw
		{
			get { return (ValueItems as dynamic).redraw; }
			set { (ValueItems as dynamic).redraw = value; }
		}

	}
}
