//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ParallelCategoriesTrace.cs
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

	public class ParallelCategoriesTrace : Trace
	{

		public ParallelCategoriesTrace():base(TraceOptions.ParallelCategories)		{		}

		public ParCatsArrangementOptions? Arrangement
		{
			get { return EnumerationStatic.GetValueFromDescription<ParCatsArrangementOptions> ((ValueItems as dynamic).arrangement); }
			set { (ValueItems as dynamic).arrangement = value?.GetDescription(); }
		}

		public bool? BundleColors
		{
			get { return (ValueItems as dynamic).bundlecolors; }
			set { (ValueItems as dynamic).bundlecolors = value; }
		}

		public double? Counts
		{
			get { return (ValueItems as dynamic).counts; }
			set { (ValueItems as dynamic).counts = value; }
		}

		ItemList<ParCatsDimensionItem>? _Dimensions = null;
		public ItemList<ParCatsDimensionItem>? Dimensions
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

		ParallelCatsHoverOptions[]? _HoverInfo = null;
		public ParallelCatsHoverOptions[]? HoverInfo
		{
			get { return _HoverInfo; }
			set
			{
				_HoverInfo = value;
				if (value != null)
				{
					(ValueItems as dynamic).hoverinfo = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public ParCatsHoverOnOptions? HoverOn
		{
			get { return EnumerationStatic.GetValueFromDescription<ParCatsHoverOnOptions> ((ValueItems as dynamic).hoveron); }
			set { (ValueItems as dynamic).hoveron = value?.GetDescription(); }
		}

		public string? HoverTemplate
		{
			get { return (ValueItems as dynamic).hovertemplate; }
			set { (ValueItems as dynamic).hovertemplate = value; }
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

		LineParCatsInfo? _Line = null;
		public LineParCatsInfo? Line
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

		public SortPathsOptions? SortPaths
		{
			get { return EnumerationStatic.GetValueFromDescription<SortPathsOptions> ((ValueItems as dynamic).sortpaths); }
			set { (ValueItems as dynamic).sortpaths = value?.GetDescription(); }
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

