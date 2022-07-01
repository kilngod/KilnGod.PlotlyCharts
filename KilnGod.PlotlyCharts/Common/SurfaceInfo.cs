//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SurfaceInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SurfaceInfo : ValuesObject
	{

		public SurfaceInfo():base()		{		}

		public int? Count
		{
			get { return (ValueItems as dynamic).count; }
			set { (ValueItems as dynamic).count = value; }
		}

		public double? Fill
		{
			get { return (ValueItems as dynamic).fill; }
			set { (ValueItems as dynamic).fill = value; }
		}

		SurfacePatternOptions[]? _Pattern = null;
		public SurfacePatternOptions[]? Pattern
		{
			get { return _Pattern; }
			set
			{
				_Pattern = value;
				if (value != null)
				{
					(ValueItems as dynamic).pattern = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public bool? Show
		{
			get { return (ValueItems as dynamic).show; }
			set { (ValueItems as dynamic).show = value; }
		}

	}
}

