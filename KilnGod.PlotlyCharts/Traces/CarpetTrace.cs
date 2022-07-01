//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CarpetTrace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Traces
{

	public class CarpetTrace : Trace
	{

		public CarpetTrace():base(TraceOptions.Carpet)		{		}

		public object? A
		{
			get { return (ValueItems as dynamic).a; }
			set { (ValueItems as dynamic).a = value; }
		}

		public double? A0
		{
			get { return (ValueItems as dynamic).a0; }
			set { (ValueItems as dynamic).a0 = value; }
		}

		CarpetAxisInfo? _AAxis = null;
		public CarpetAxisInfo? AAxis
		{
			get { return _AAxis; }
			set
			{
				_AAxis = value;
				(ValueItems as dynamic).aaxis = _AAxis?.ValueItems;
			}
		}

		public object? B
		{
			get { return (ValueItems as dynamic).b; }
			set { (ValueItems as dynamic).b = value; }
		}

		public double? B0
		{
			get { return (ValueItems as dynamic).b0; }
			set { (ValueItems as dynamic).b0 = value; }
		}

		CarpetAxisInfo? _BAxis = null;
		public CarpetAxisInfo? BAxis
		{
			get { return _BAxis; }
			set
			{
				_BAxis = value;
				(ValueItems as dynamic).baxis = _BAxis?.ValueItems;
			}
		}

		public string? Carpet
		{
			get { return (ValueItems as dynamic).carpet; }
			set { (ValueItems as dynamic).carpet = value; }
		}

		public double? CheaterSlope
		{
			get { return (ValueItems as dynamic).cheaterslope; }
			set { (ValueItems as dynamic).cheaterslope = value; }
		}

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

		public double? DA
		{
			get { return (ValueItems as dynamic).da; }
			set { (ValueItems as dynamic).da = value; }
		}

		public double? DB
		{
			get { return (ValueItems as dynamic).db; }
			set { (ValueItems as dynamic).db = value; }
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

		public object? IDs
		{
			get { return (ValueItems as dynamic).ids; }
			set { (ValueItems as dynamic).ids = value; }
		}

		LegendGroupTitleInfo? _LegendGroupTitle = null;
		public LegendGroupTitleInfo? LegendGroupTitle
		{
			get { return _LegendGroupTitle; }
			set
			{
				_LegendGroupTitle = value;
				(ValueItems as dynamic).legendgrouptitle = _LegendGroupTitle?.ValueItems;
			}
		}

		public double? LegendRank
		{
			get { return (ValueItems as dynamic).legendrank; }
			set { (ValueItems as dynamic).legendrank = value; }
		}

		public object? Meta
		{
			get { return (ValueItems as dynamic).meta; }
			set { (ValueItems as dynamic).meta = value; }
		}

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		StreamInfo? _Stream = null;
		public StreamInfo? Stream
		{
			get { return _Stream; }
			set
			{
				_Stream = value;
				(ValueItems as dynamic).stream = _Stream?.ValueItems;
			}
		}

		public string? UID
		{
			get { return (ValueItems as dynamic).uid; }
			set { (ValueItems as dynamic).uid = value; }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		public VisibleOptions? Visible
		{
			get { return EnumerationStatic.GetValueFromDescription<VisibleOptions> ((ValueItems as dynamic).visible); }
			set { (ValueItems as dynamic).visible = value?.GetDescription(); }
		}

		public object? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public object? XAxis
		{
			get { return (ValueItems as dynamic).xaxis; }
			set { (ValueItems as dynamic).xaxis = value; }
		}

		public object? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

		public object? YAxis
		{
			get { return (ValueItems as dynamic).yaxis; }
			set { (ValueItems as dynamic).yaxis = value; }
		}

	}
}

