//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Histogram2DContourTrace.cs
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

	public class Histogram2DContourTrace : Trace
	{

		public Histogram2DContourTrace():base(TraceOptions.Histogram2DContour)		{		}

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

		public bool? AutoColorScale
		{
			get { return (ValueItems as dynamic).autocolorscale; }
			set { (ValueItems as dynamic).autocolorscale = value; }
		}

		public bool? AutoContour
		{
			get { return (ValueItems as dynamic).autocontour; }
			set { (ValueItems as dynamic).autocontour = value; }
		}

		public string? BinGroup
		{
			get { return (ValueItems as dynamic).bingroup; }
			set { (ValueItems as dynamic).bingroup = value; }
		}

		public object? ColorAxis
		{
			get { return (ValueItems as dynamic).coloraxis; }
			set { (ValueItems as dynamic).coloraxis = value; }
		}

		ColorBarInfo? _ColorBar = null;
		public ColorBarInfo? ColorBar
		{
			get { return _ColorBar; }
			set
			{
				_ColorBar = value;
				(ValueItems as dynamic).colorbar = _ColorBar?.ValueItems;
			}
		}

		public object? ColorScale
		{
			get { return (ValueItems as dynamic).colorscale; }
			set { (ValueItems as dynamic).colorscale = value; }
		}

		ContoursInfo? _Contours = null;
		public ContoursInfo? Contours
		{
			get { return _Contours; }
			set
			{
				_Contours = value;
				(ValueItems as dynamic).contours = _Contours?.ValueItems;
			}
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
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

		LineColorDashSmoothingWidthInfo? _Line = null;
		public LineColorDashSmoothingWidthInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		MarkerHistogram2DInfo? _Marker = null;
		public MarkerHistogram2DInfo? Marker
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

		public int? NContours
		{
			get { return (ValueItems as dynamic).ncontours; }
			set { (ValueItems as dynamic).ncontours = value; }
		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public bool? ReverseScale
		{
			get { return (ValueItems as dynamic).reversescale; }
			set { (ValueItems as dynamic).reversescale = value; }
		}

		public bool? ShowLegend
		{
			get { return (ValueItems as dynamic).showlegend; }
			set { (ValueItems as dynamic).showlegend = value; }
		}

		public bool? ShowScale
		{
			get { return (ValueItems as dynamic).showscale; }
			set { (ValueItems as dynamic).showscale = value; }
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

		public string? XBinGroup
		{
			get { return (ValueItems as dynamic).xbingroup; }
			set { (ValueItems as dynamic).xbingroup = value; }
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

		public string? YBinGroup
		{
			get { return (ValueItems as dynamic).ybingroup; }
			set { (ValueItems as dynamic).ybingroup = value; }
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

		public object? Z
		{
			get { return (ValueItems as dynamic).z; }
			set { (ValueItems as dynamic).z = value; }
		}

		public bool? ZAuto
		{
			get { return (ValueItems as dynamic).zauto; }
			set { (ValueItems as dynamic).zauto = value; }
		}

		public string? ZHoverFormat
		{
			get { return (ValueItems as dynamic).zhoverformat; }
			set { (ValueItems as dynamic).zhoverformat = value; }
		}

		public double? ZMax
		{
			get { return (ValueItems as dynamic).zmax; }
			set { (ValueItems as dynamic).zmax = value; }
		}

		public double? ZMid
		{
			get { return (ValueItems as dynamic).zmid; }
			set { (ValueItems as dynamic).zmid = value; }
		}

		public double? ZMin
		{
			get { return (ValueItems as dynamic).zmin; }
			set { (ValueItems as dynamic).zmin = value; }
		}

	}
}

