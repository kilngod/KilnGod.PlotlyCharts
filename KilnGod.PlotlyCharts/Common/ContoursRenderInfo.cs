//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ContoursRenderInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class ContoursRenderInfo : ValuesObject
	{

		public ContoursRenderInfo():base()		{		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public double? End
		{
			get { return (ValueItems as dynamic).end; }
			set { (ValueItems as dynamic).end = value; }
		}

		public bool? Highlight
		{
			get { return (ValueItems as dynamic).highlight; }
			set { (ValueItems as dynamic).highlight = value; }
		}

		public object? HighlightColor
		{
			get { return (ValueItems as dynamic).highlightcolor; }
			set { (ValueItems as dynamic).highlightcolor = value; }
		}

		public double? HighlightWidth
		{
			get { return (ValueItems as dynamic).highlightwidth; }
			set { (ValueItems as dynamic).highlightwidth = value; }
		}

		ProjectInfo? _Project = null;
		public ProjectInfo? Project
		{
			get { return _Project; }
			set
			{
				_Project = value;
				(ValueItems as dynamic).project = _Project?.ValueItems;
			}
		}

		public bool? Show
		{
			get { return (ValueItems as dynamic).show; }
			set { (ValueItems as dynamic).show = value; }
		}

		public double? Size
		{
			get { return (ValueItems as dynamic).size; }
			set { (ValueItems as dynamic).size = value; }
		}

		public double? Start
		{
			get { return (ValueItems as dynamic).start; }
			set { (ValueItems as dynamic).start = value; }
		}

		public bool? UseColorMap
		{
			get { return (ValueItems as dynamic).usecolormap; }
			set { (ValueItems as dynamic).usecolormap = value; }
		}

		public double? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

	}
}

