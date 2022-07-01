//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SunburstTrace.cs
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

	public class SunburstTrace : Trace
	{

		public SunburstTrace():base(TraceOptions.Sunburst)		{		}

		public BranchValuesOptions? BranchValues
		{
			get { return EnumerationStatic.GetValueFromDescription<BranchValuesOptions> ((ValueItems as dynamic).branchvalues); }
			set { (ValueItems as dynamic).branchvalues = value?.GetDescription(); }
		}

		CountOptions[]? _Count = null;
		public CountOptions[]? Count
		{
			get { return _Count; }
			set
			{
				_Count = value;
				if (value != null)
				{
					(ValueItems as dynamic).count = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
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

		SunburstHoverOptions[]? _HoverInfo = null;
		public SunburstHoverOptions[]? HoverInfo
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

		public string? HoverText
		{
			get { return (ValueItems as dynamic).hovertext; }
			set { (ValueItems as dynamic).hovertext = value; }
		}

		public object? IDs
		{
			get { return (ValueItems as dynamic).ids; }
			set { (ValueItems as dynamic).ids = value; }
		}

		InsideTextFontInfo? _InsideTextFont = null;
		public InsideTextFontInfo? InsideTextFont
		{
			get { return _InsideTextFont; }
			set
			{
				_InsideTextFont = value;
				(ValueItems as dynamic).insidetextfont = _InsideTextFont?.ValueItems;
			}
		}

		public InsideTextOrientationOptions? InsideTextOrientation
		{
			get { return EnumerationStatic.GetValueFromDescription<InsideTextOrientationOptions> ((ValueItems as dynamic).insidetextorientation); }
			set { (ValueItems as dynamic).insidetextorientation = value?.GetDescription(); }
		}

		public object? Labels
		{
			get { return (ValueItems as dynamic).labels; }
			set { (ValueItems as dynamic).labels = value; }
		}

		LeafInfo? _Leaf = null;
		public LeafInfo? Leaf
		{
			get { return _Leaf; }
			set
			{
				_Leaf = value;
				(ValueItems as dynamic).leaf = _Leaf?.ValueItems;
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

		public double? LegendRank
		{
			get { return (ValueItems as dynamic).legendrank; }
			set { (ValueItems as dynamic).legendrank = value; }
		}

		public object? Level
		{
			get { return (ValueItems as dynamic).level; }
			set { (ValueItems as dynamic).level = value; }
		}

		MarkerSunburstInfo? _Marker = null;
		public MarkerSunburstInfo? Marker
		{
			get { return _Marker; }
			set
			{
				_Marker = value;
				(ValueItems as dynamic).marker = _Marker?.ValueItems;
			}
		}

		public int? MaxDepth
		{
			get { return (ValueItems as dynamic).maxdepth; }
			set { (ValueItems as dynamic).maxdepth = value; }
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

		OutsideTextFontInfo? _OutsideTextFont = null;
		public OutsideTextFontInfo? OutsideTextFont
		{
			get { return _OutsideTextFont; }
			set
			{
				_OutsideTextFont = value;
				(ValueItems as dynamic).outsidetextfont = _OutsideTextFont?.ValueItems;
			}
		}

		public object? Parents
		{
			get { return (ValueItems as dynamic).parents; }
			set { (ValueItems as dynamic).parents = value; }
		}

		RootInfo? _Root = null;
		public RootInfo? Root
		{
			get { return _Root; }
			set
			{
				_Root = value;
				(ValueItems as dynamic).root = _Root?.ValueItems;
			}
		}

		public double? Rotation
		{
			get { return (ValueItems as dynamic).rotation; }
			set { (ValueItems as dynamic).rotation = value; }
		}

		public bool? Sort
		{
			get { return (ValueItems as dynamic).sort; }
			set { (ValueItems as dynamic).sort = value; }
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

		public object? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

		TextFontInfo? _TextFont = null;
		public TextFontInfo? TextFont
		{
			get { return _TextFont; }
			set
			{
				_TextFont = value;
				(ValueItems as dynamic).textfont = _TextFont?.ValueItems;
			}
		}

		SunburstTextInfoOptions[]? _TextInfo = null;
		public SunburstTextInfoOptions[]? TextInfo
		{
			get { return _TextInfo; }
			set
			{
				_TextInfo = value;
				if (value != null)
				{
					(ValueItems as dynamic).textinfo = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public string? TextTemplate
		{
			get { return (ValueItems as dynamic).texttemplate; }
			set { (ValueItems as dynamic).texttemplate = value; }
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

		public object? Values
		{
			get { return (ValueItems as dynamic).values; }
			set { (ValueItems as dynamic).values = value; }
		}

		public VisibleOptions? Visible
		{
			get { return EnumerationStatic.GetValueFromDescription<VisibleOptions> ((ValueItems as dynamic).visible); }
			set { (ValueItems as dynamic).visible = value?.GetDescription(); }
		}

	}
}

