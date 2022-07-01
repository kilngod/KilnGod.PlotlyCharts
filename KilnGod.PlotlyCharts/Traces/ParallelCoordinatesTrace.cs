//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ParallelCoordinatesTrace.cs
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

	public class ParallelCoordinatesTrace : Trace
	{

		public ParallelCoordinatesTrace():base(TraceOptions.ParallelCoordinates)		{		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		ItemList<ParCoordsDimensionItem>? _Dimensions = null;
		public ItemList<ParCoordsDimensionItem>? Dimensions
		{
			get
			{ 
				return _Dimensions;
			}
			set
			{ 
				_Dimensions = value;
				(ValueItems as dynamic).dimensions = _Dimensions?.Values;
			}
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

		public object? IDs
		{
			get { return (ValueItems as dynamic).ids; }
			set { (ValueItems as dynamic).ids = value; }
		}

		public double? LabelAngle
		{
			get { return (ValueItems as dynamic).labelangle; }
			set { (ValueItems as dynamic).labelangle = value; }
		}

		LabelFontInfo? _LabelFont = null;
		public LabelFontInfo? LabelFont
		{
			get { return _LabelFont; }
			set
			{
				_LabelFont = value;
				(ValueItems as dynamic).labelfont = _LabelFont?.ValueItems;
			}
		}

		public TopBottomOptions? Labelside
		{
			get { return EnumerationStatic.GetValueFromDescription<TopBottomOptions> ((ValueItems as dynamic).labelside); }
			set { (ValueItems as dynamic).labelside = value?.GetDescription(); }
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

		LineParCoordsInfo? _Line = null;
		public LineParCoordsInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
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

		RangeFontInfo? _RangeFont = null;
		public RangeFontInfo? RangeFont
		{
			get { return _RangeFont; }
			set
			{
				_RangeFont = value;
				(ValueItems as dynamic).rangefont = _RangeFont?.ValueItems;
			}
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

		TickFontInfo? _TickFont = null;
		public TickFontInfo? TickFont
		{
			get { return _TickFont; }
			set
			{
				_TickFont = value;
				(ValueItems as dynamic).tickfont = _TickFont?.ValueItems;
			}
		}

		ItemList<Transform>? _Transforms = null;
		public ItemList<Transform>? Transforms
		{
			get
			{ 
				return _Transforms;
			}
			set
			{ 
				_Transforms = value;
				(ValueItems as dynamic).transforms = _Transforms?.Values;
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

	}
}

