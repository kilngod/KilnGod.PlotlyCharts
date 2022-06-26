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

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class UniformTextInfo : ValuesObject
	{

		public UniformTextInfo() : base() { }

		public double? Minsize
		{
			get { return (ValueItems as dynamic).minsize; }
			set { (ValueItems as dynamic).minsize = value; }
		}
		
		public FontModeOptions? Mode
		{
			get { return EnumerationStatic.GetValueFromDescription<FontModeOptions>((ValueItems as dynamic).mode); }
			set { (ValueItems as dynamic).mode = value?.GetDescription(); }
		}
		
	}

}
