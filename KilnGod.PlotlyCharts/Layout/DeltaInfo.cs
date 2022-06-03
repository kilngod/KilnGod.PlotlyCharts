//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: DeltaInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layout
{
    public class DeltaInfo : ValuesObject
	{

		public DeltaInfo() : base() { }

		AreaChangeInfo? _Decreasing = null;
		public AreaChangeInfo? Decreasing
		{
			get { return _Decreasing; }
			set
			{
				_Decreasing = value;
				(ValueItems as dynamic).decreasing = _Decreasing?.ValueItems;
			}
		}

		FontInfo? _Font = null;
		public FontInfo? Font
		{
			get { return _Font; }
			set
			{
				_Font = value;
				(ValueItems as dynamic).font = _Font?.ValueItems;
			}
		}

		AreaChangeInfo? _Increasing = null;
		public AreaChangeInfo? Increasing
		{
			get { return _Increasing; }
			set
			{
				_Increasing = value;
				(ValueItems as dynamic).increasing = _Increasing?.ValueItems;
			}
		}

		public PositionOptions? Position
		{
			get { return EnumerationStatic.GetValueFromDescription<PositionOptions>((ValueItems as dynamic).position); }
			set { (ValueItems as dynamic).position = value?.GetDescription(); }
		}

		public float? Reference
		{
			get { return (ValueItems as dynamic).reference; }
			set { (ValueItems as dynamic).reference = value; }
		}

		public bool? Relative
		{
			get { return (ValueItems as dynamic).relative; }
			set { (ValueItems as dynamic).relative = value; }
		}

		public string? ValueFormat
		{
			get { return (ValueItems as dynamic).valueformat; }
			set { (ValueItems as dynamic).valueformat = value; }
		}

	}

}
