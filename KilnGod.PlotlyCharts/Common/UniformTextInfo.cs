//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: UniformTextInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class UniformTextInfo : ValuesObject
	{

		public UniformTextInfo():base()		{		}

		public double? MinSize
		{
			get { return (ValueItems as dynamic).minsize; }
			set { (ValueItems as dynamic).minsize = value; }
		}

		public ModeUniformTextOptions? Mode
		{
			get { return EnumerationStatic.GetValueFromDescription<ModeUniformTextOptions> ((ValueItems as dynamic).mode); }
			set { (ValueItems as dynamic).mode = value?.GetDescription(); }
		}

	}
}

