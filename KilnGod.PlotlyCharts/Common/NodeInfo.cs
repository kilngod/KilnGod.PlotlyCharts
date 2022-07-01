//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: NodeInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class NodeInfo : ValuesObject
	{

		public NodeInfo():base()		{		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		public NodeHoverInfoOptions? HoverInfo
		{
			get { return EnumerationStatic.GetValueFromDescription<NodeHoverInfoOptions> ((ValueItems as dynamic).hoverinfo); }
			set { (ValueItems as dynamic).hoverinfo = value?.GetDescription(); }
		}

		HoverLabelInfo? _HoverLabel = null;
		public HoverLabelInfo? HoverLabel
		{
			get { return _HoverLabel; }
			set
			{
				_HoverLabel = value;
				(ValueItems as dynamic).hoverlabel = _HoverLabel?.ValueItems;
			}
		}

		public string? HoverTemplate
		{
			get { return (ValueItems as dynamic).hovertemplate; }
			set { (ValueItems as dynamic).hovertemplate = value; }
		}

		public object? Label
		{
			get { return (ValueItems as dynamic).label; }
			set { (ValueItems as dynamic).label = value; }
		}

		LineColorWidthsInfo? _Line = null;
		public LineColorWidthsInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		public double? Pad
		{
			get { return (ValueItems as dynamic).pad; }
			set { (ValueItems as dynamic).pad = value; }
		}

		public double? Thickness
		{
			get { return (ValueItems as dynamic).thickness; }
			set { (ValueItems as dynamic).thickness = value; }
		}

		public object? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public object? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

	}
}

