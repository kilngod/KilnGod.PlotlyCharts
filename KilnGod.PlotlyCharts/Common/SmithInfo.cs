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
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SmithInfo : ValuesObject
	{

		public SmithInfo():base()		{		}

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

		ImaginaryAxisInfo? _ImaginaryAxis = null;
		public ImaginaryAxisInfo? ImaginaryAxis
		{
			get { return _ImaginaryAxis; }
			set
			{
				_ImaginaryAxis = value;
				(ValueItems as dynamic).imaginaryaxis = _ImaginaryAxis?.ValueItems;
			}
		}

		RealAxisInfo? _RealAxis = null;
		public RealAxisInfo? RealAxis
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

