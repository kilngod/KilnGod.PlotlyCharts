//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SpaceframeInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SpaceframeInfo : ValuesObject
	{

		public SpaceframeInfo():base()		{		}

		public double? Fill
		{
			get { return (ValueItems as dynamic).fill; }
			set { (ValueItems as dynamic).fill = value; }
		}

		public bool? Show
		{
			get { return (ValueItems as dynamic).show; }
			set { (ValueItems as dynamic).show = value; }
		}

	}
}

