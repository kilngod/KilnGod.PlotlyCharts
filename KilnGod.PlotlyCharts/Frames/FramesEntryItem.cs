//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FramesEntryItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Frames
{

	public class FramesEntryItem : ValuesObject
	{

		public FramesEntryItem():base()		{		}

		public string? Baseframe
		{
			get { return (ValueItems as dynamic).baseframe; }
			set { (ValueItems as dynamic).baseframe = value; }
		}

		public object? Data
		{
			get { return (ValueItems as dynamic).data; }
			set { (ValueItems as dynamic).data = value; }
		}

		public string? Group
		{
			get { return (ValueItems as dynamic).group; }
			set { (ValueItems as dynamic).group = value; }
		}

		public object? Layout
		{
			get { return (ValueItems as dynamic).layout; }
			set { (ValueItems as dynamic).layout = value; }
		}

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public object? Traces
		{
			get { return (ValueItems as dynamic).traces; }
			set { (ValueItems as dynamic).traces = value; }
		}

	}
}

