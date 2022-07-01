//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MarkerMapboxInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class MarkerMapboxInfo : ValuesObject
	{

		public MarkerMapboxInfo():base()		{		}

		public bool? Allowoverlap
		{
			get { return (ValueItems as dynamic).allowoverlap; }
			set { (ValueItems as dynamic).allowoverlap = value; }
		}

		public double? Angle
		{
			get { return (ValueItems as dynamic).angle; }
			set { (ValueItems as dynamic).angle = value; }
		}

		public bool? AutoColorScale
		{
			get { return (ValueItems as dynamic).autocolorscale; }
			set { (ValueItems as dynamic).autocolorscale = value; }
		}

		public bool? CAuto
		{
			get { return (ValueItems as dynamic).cauto; }
			set { (ValueItems as dynamic).cauto = value; }
		}

		public double? CMax
		{
			get { return (ValueItems as dynamic).cmax; }
			set { (ValueItems as dynamic).cmax = value; }
		}

		public double? CMid
		{
			get { return (ValueItems as dynamic).cmid; }
			set { (ValueItems as dynamic).cmid = value; }
		}

		public double? CMin
		{
			get { return (ValueItems as dynamic).cmin; }
			set { (ValueItems as dynamic).cmin = value; }
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public object? ColorAxis
		{
			get { return (ValueItems as dynamic).coloraxis; }
			set { (ValueItems as dynamic).coloraxis = value; }
		}

		ColorBarInfo? _ColorBar = null;
		public ColorBarInfo? ColorBar
		{
			get { return _ColorBar; }
			set
			{
				_ColorBar = value;
				(ValueItems as dynamic).colorbar = _ColorBar?.ValueItems;
			}
		}

		public object? ColorScale
		{
			get { return (ValueItems as dynamic).colorscale; }
			set { (ValueItems as dynamic).colorscale = value; }
		}

		public object? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public bool? ReverseScale
		{
			get { return (ValueItems as dynamic).reversescale; }
			set { (ValueItems as dynamic).reversescale = value; }
		}

		public bool? ShowScale
		{
			get { return (ValueItems as dynamic).showscale; }
			set { (ValueItems as dynamic).showscale = value; }
		}

		public object? Size
		{
			get { return (ValueItems as dynamic).size; }
			set { (ValueItems as dynamic).size = value; }
		}

		public double? SizeMin
		{
			get { return (ValueItems as dynamic).sizemin; }
			set { (ValueItems as dynamic).sizemin = value; }
		}

		public SizeModeOptions? SizeMode
		{
			get { return EnumerationStatic.GetValueFromDescription<SizeModeOptions> ((ValueItems as dynamic).sizemode); }
			set { (ValueItems as dynamic).sizemode = value?.GetDescription(); }
		}

		public double? SizeRef
		{
			get { return (ValueItems as dynamic).sizeref; }
			set { (ValueItems as dynamic).sizeref = value; }
		}

		public string? Symbol
		{
			get { return (ValueItems as dynamic).symbol; }
			set { (ValueItems as dynamic).symbol = value; }
		}

	}
}

