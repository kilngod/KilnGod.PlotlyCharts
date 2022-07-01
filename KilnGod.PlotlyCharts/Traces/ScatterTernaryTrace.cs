//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterTernaryTrace.cs
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

	public class ScatterTernaryTrace : Trace
	{

		public ScatterTernaryTrace():base(TraceOptions.ScatterTernary)		{		}

		public object? A
		{
			get { return (ValueItems as dynamic).a; }
			set { (ValueItems as dynamic).a = value; }
		}

		public object? B
		{
			get { return (ValueItems as dynamic).b; }
			set { (ValueItems as dynamic).b = value; }
		}

		public object? C
		{
			get { return (ValueItems as dynamic).c; }
			set { (ValueItems as dynamic).c = value; }
		}

		public bool? CliponAxis
		{
			get { return (ValueItems as dynamic).cliponaxis; }
			set { (ValueItems as dynamic).cliponaxis = value; }
		}

		public bool? ConnectGaps
		{
			get { return (ValueItems as dynamic).connectgaps; }
			set { (ValueItems as dynamic).connectgaps = value; }
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		public FillSubsetOptions? Fill
		{
			get { return EnumerationStatic.GetValueFromDescription<FillSubsetOptions> ((ValueItems as dynamic).fill); }
			set { (ValueItems as dynamic).fill = value?.GetDescription(); }
		}

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		TernaryHoverOptions[]? _HoverInfo = null;
		public TernaryHoverOptions[]? HoverInfo
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

		HoverOnOptions[]? _HoverOn = null;
		public HoverOnOptions[]? HoverOn
		{
			get { return _HoverOn; }
			set
			{
				_HoverOn = value;
				if (value != null)
				{
					(ValueItems as dynamic).hoveron = EnumerationStatic.MakeFlagList(value);
				}
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

		public string? LegendGroup
		{
			get { return (ValueItems as dynamic).legendgroup; }
			set { (ValueItems as dynamic).legendgroup = value; }
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

		LineColorDashShapeSmoothingWidthInfo? _Line = null;
		public LineColorDashShapeSmoothingWidthInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		MarkerScatterInfo? _Marker = null;
		public MarkerScatterInfo? Marker
		{
			get { return _Marker; }
			set
			{
				_Marker = value;
				(ValueItems as dynamic).marker = _Marker?.ValueItems;
			}
		}

		public object? Meta
		{
			get { return (ValueItems as dynamic).meta; }
			set { (ValueItems as dynamic).meta = value; }
		}

		ModeScatterOptions[]? _Mode = null;
		public ModeScatterOptions[]? Mode
		{
			get { return _Mode; }
			set
			{
				_Mode = value;
				if (value != null)
				{
					(ValueItems as dynamic).mode = EnumerationStatic.MakeFlagList(value);
				}
			}
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

		SelectionInfo? _Selected = null;
		public SelectionInfo? Selected
		{
			get { return _Selected; }
			set
			{
				_Selected = value;
				(ValueItems as dynamic).selected = _Selected?.ValueItems;
			}
		}

		public object? SelectedPoints
		{
			get { return (ValueItems as dynamic).selectedpoints; }
			set { (ValueItems as dynamic).selectedpoints = value; }
		}

		public bool? ShowLegend
		{
			get { return (ValueItems as dynamic).showlegend; }
			set { (ValueItems as dynamic).showlegend = value; }
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

		public object? Subplot
		{
			get { return (ValueItems as dynamic).subplot; }
			set { (ValueItems as dynamic).subplot = value; }
		}

		public double? Sum
		{
			get { return (ValueItems as dynamic).sum; }
			set { (ValueItems as dynamic).sum = value; }
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

		public ScatterTextPositionOptions? TextPosition
		{
			get { return EnumerationStatic.GetValueFromDescription<ScatterTextPositionOptions> ((ValueItems as dynamic).textposition); }
			set { (ValueItems as dynamic).textposition = value?.GetDescription(); }
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

		SelectionInfo? _Unselected = null;
		public SelectionInfo? Unselected
		{
			get { return _Unselected; }
			set
			{
				_Unselected = value;
				(ValueItems as dynamic).unselected = _Unselected?.ValueItems;
			}
		}

		public VisibleOptions? Visible
		{
			get { return EnumerationStatic.GetValueFromDescription<VisibleOptions> ((ValueItems as dynamic).visible); }
			set { (ValueItems as dynamic).visible = value?.GetDescription(); }
		}

	}
}

