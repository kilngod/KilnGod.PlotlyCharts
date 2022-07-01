//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: HistogramTrace.cs
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

	public class HistogramTrace : Trace
	{

		public HistogramTrace():base(TraceOptions.Histogram)		{		}

		public string? AlignmentGroup
		{
			get { return (ValueItems as dynamic).alignmentgroup; }
			set { (ValueItems as dynamic).alignmentgroup = value; }
		}

		public bool? AutoBinX
		{
			get { return (ValueItems as dynamic).autobinx; }
			set { (ValueItems as dynamic).autobinx = value; }
		}

		public bool? AutoBinY
		{
			get { return (ValueItems as dynamic).autobiny; }
			set { (ValueItems as dynamic).autobiny = value; }
		}

		public string? BinGroup
		{
			get { return (ValueItems as dynamic).bingroup; }
			set { (ValueItems as dynamic).bingroup = value; }
		}

		public bool? CliponAxis
		{
			get { return (ValueItems as dynamic).cliponaxis; }
			set { (ValueItems as dynamic).cliponaxis = value; }
		}

		public ConstrainTextOptions? ConstrainText
		{
			get { return EnumerationStatic.GetValueFromDescription<ConstrainTextOptions> ((ValueItems as dynamic).constraintext); }
			set { (ValueItems as dynamic).constraintext = value?.GetDescription(); }
		}

		CumulativeInfo? _Cumulative = null;
		public CumulativeInfo? Cumulative
		{
			get { return _Cumulative; }
			set
			{
				_Cumulative = value;
				(ValueItems as dynamic).cumulative = _Cumulative?.ValueItems;
			}
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		ErrorXInfo? _ErrorX = null;
		public ErrorXInfo? ErrorX
		{
			get { return _ErrorX; }
			set
			{
				_ErrorX = value;
				(ValueItems as dynamic).error_x = _ErrorX?.ValueItems;
			}
		}

		ErrorYInfo? _ErrorY = null;
		public ErrorYInfo? ErrorY
		{
			get { return _ErrorY; }
			set
			{
				_ErrorY = value;
				(ValueItems as dynamic).error_y = _ErrorY?.ValueItems;
			}
		}

		public HistFuncOptions? HistFunc
		{
			get { return EnumerationStatic.GetValueFromDescription<HistFuncOptions> ((ValueItems as dynamic).histfunc); }
			set { (ValueItems as dynamic).histfunc = value?.GetDescription(); }
		}

		public HistNormOptions? HistNorm
		{
			get { return EnumerationStatic.GetValueFromDescription<HistNormOptions> ((ValueItems as dynamic).histnorm); }
			set { (ValueItems as dynamic).histnorm = value?.GetDescription(); }
		}

		HoverInfoOptions[]? _HoverInfo = null;
		public HoverInfoOptions[]? HoverInfo
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

		public StartMiddleEndOptions? InsideTextAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<StartMiddleEndOptions> ((ValueItems as dynamic).insidetextanchor); }
			set { (ValueItems as dynamic).insidetextanchor = value?.GetDescription(); }
		}

		TextFontSizeInfo? _InsideTextFont = null;
		public TextFontSizeInfo? InsideTextFont
		{
			get { return _InsideTextFont; }
			set
			{
				_InsideTextFont = value;
				(ValueItems as dynamic).insidetextfont = _InsideTextFont?.ValueItems;
			}
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

		MarkerHistogramInfo? _Marker = null;
		public MarkerHistogramInfo? Marker
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

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public int? NBinsX
		{
			get { return (ValueItems as dynamic).nbinsx; }
			set { (ValueItems as dynamic).nbinsx = value; }
		}

		public int? NBinsY
		{
			get { return (ValueItems as dynamic).nbinsy; }
			set { (ValueItems as dynamic).nbinsy = value; }
		}

		public string? OffsetGroup
		{
			get { return (ValueItems as dynamic).offsetgroup; }
			set { (ValueItems as dynamic).offsetgroup = value; }
		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public OrientationOptions? Orientation
		{
			get { return EnumerationStatic.GetValueFromDescription<OrientationOptions> ((ValueItems as dynamic).orientation); }
			set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
		}

		TextFontSizeInfo? _OutsideTextFont = null;
		public TextFontSizeInfo? OutsideTextFont
		{
			get { return _OutsideTextFont; }
			set
			{
				_OutsideTextFont = value;
				(ValueItems as dynamic).outsidetextfont = _OutsideTextFont?.ValueItems;
			}
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

		public object? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

		public double? TextAngle
		{
			get { return (ValueItems as dynamic).textangle; }
			set { (ValueItems as dynamic).textangle = value; }
		}

		TextFontSizeInfo? _TextFont = null;
		public TextFontSizeInfo? TextFont
		{
			get { return _TextFont; }
			set
			{
				_TextFont = value;
				(ValueItems as dynamic).textfont = _TextFont?.ValueItems;
			}
		}

		public TextPositionOptions? TextPosition
		{
			get { return EnumerationStatic.GetValueFromDescription<TextPositionOptions> ((ValueItems as dynamic).textposition); }
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

		BinsInfo? _XBins = null;
		public BinsInfo? XBins
		{
			get { return _XBins; }
			set
			{
				_XBins = value;
				(ValueItems as dynamic).xbins = _XBins?.ValueItems;
			}
		}

		public CalendarOptions? XCalendar
		{
			get { return EnumerationStatic.GetValueFromDescription<CalendarOptions> ((ValueItems as dynamic).xcalendar); }
			set { (ValueItems as dynamic).xcalendar = value?.GetDescription(); }
		}

		public string? XHoverFormat
		{
			get { return (ValueItems as dynamic).xhoverformat; }
			set { (ValueItems as dynamic).xhoverformat = value; }
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

		BinsInfo? _YBins = null;
		public BinsInfo? YBins
		{
			get { return _YBins; }
			set
			{
				_YBins = value;
				(ValueItems as dynamic).ybins = _YBins?.ValueItems;
			}
		}

		public CalendarOptions? YCalendar
		{
			get { return EnumerationStatic.GetValueFromDescription<CalendarOptions> ((ValueItems as dynamic).ycalendar); }
			set { (ValueItems as dynamic).ycalendar = value?.GetDescription(); }
		}

		public string? YHoverFormat
		{
			get { return (ValueItems as dynamic).yhoverformat; }
			set { (ValueItems as dynamic).yhoverformat = value; }
		}

	}
}

