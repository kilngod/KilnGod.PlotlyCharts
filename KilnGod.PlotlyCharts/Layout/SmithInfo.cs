//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SmithInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
	public class SmithInfo : ValuesObject
	{

		public SmithInfo() : base() { }

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		DomainInfo? _Domain = null;
		public DomainInfo? Domain
		{
			get { return _Domain; }
			set
			{
				_Domain = value;
				(ValueItems as dynamic).domain = _Domain?.ValueItems;
			}
		}

		SmithAxisInfo? _ImaginaryAxis = null;
		public SmithAxisInfo? ImaginaryAxis
		{
			get { return _ImaginaryAxis; }
			set
			{
				_ImaginaryAxis = value;
				(ValueItems as dynamic).imaginaryaxis = _ImaginaryAxis?.ValueItems;
			}
		}

		SmithAxisInfo? _RealAxis = null;
		public SmithAxisInfo? RealAxis
		{
			get { return _RealAxis; }
			set
			{
				_RealAxis = value;
				(ValueItems as dynamic).realaxis = _RealAxis?.ValueItems;
			}
		}

	}

}
