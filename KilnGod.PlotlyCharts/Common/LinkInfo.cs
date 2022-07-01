//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LinkInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class LinkInfo : ValuesObject
	{

		public LinkInfo():base()		{		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		ItemList<ConcentrationScalesItem>? _ColorScales = null;
		public ItemList<ConcentrationScalesItem>? ColorScales
		{
			get
			{ 
				return _ColorScales;
			}
			set
			{ 
				_ColorScales = value;
				(ValueItems as dynamic).colorscales = _ColorScales?.Values;
			}
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		public LinkHoverOptions? HoverInfo
		{
			get { return EnumerationStatic.GetValueFromDescription<LinkHoverOptions> ((ValueItems as dynamic).hoverinfo); }
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

		public object? Source
		{
			get { return (ValueItems as dynamic).source; }
			set { (ValueItems as dynamic).source = value; }
		}

		public object? Target
		{
			get { return (ValueItems as dynamic).target; }
			set { (ValueItems as dynamic).target = value; }
		}

		public object? Value
		{
			get { return (ValueItems as dynamic).value; }
			set { (ValueItems as dynamic).value = value; }
		}

	}
}

