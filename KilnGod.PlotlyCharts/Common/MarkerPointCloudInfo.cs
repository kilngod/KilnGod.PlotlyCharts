//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MarkerPointCloudInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class MarkerPointCloudInfo : ValuesObject
	{

		public MarkerPointCloudInfo():base()		{		}

		public bool? Blend
		{
			get { return (ValueItems as dynamic).blend; }
			set { (ValueItems as dynamic).blend = value; }
		}

		BorderInfo? _Border = null;
		public BorderInfo? Border
		{
			get { return _Border; }
			set
			{
				_Border = value;
				(ValueItems as dynamic).border = _Border?.ValueItems;
			}
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public double? SizeMax
		{
			get { return (ValueItems as dynamic).sizemax; }
			set { (ValueItems as dynamic).sizemax = value; }
		}

		public double? SizeMin
		{
			get { return (ValueItems as dynamic).sizemin; }
			set { (ValueItems as dynamic).sizemin = value; }
		}

	}
}

