//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BoxTrace.cs
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

	public class BoxTrace : Trace
	{

		public BoxTrace():base(TraceOptions.Box)		{		}

		public string? AlignmentGroup
		{
			get { return (ValueItems as dynamic).alignmentgroup; }
			set { (ValueItems as dynamic).alignmentgroup = value; }
		}

		public BoxMeanOptions? BoxMean
		{
			get { return EnumerationStatic.GetValueFromDescription<BoxMeanOptions> ((ValueItems as dynamic).boxmean); }
			set { (ValueItems as dynamic).boxmean = value?.GetDescription(); }
		}

		public BoxPointsOptions? BoxPoints
		{
			get { return EnumerationStatic.GetValueFromDescription<BoxPointsOptions> ((ValueItems as dynamic).boxpoints); }
			set { (ValueItems as dynamic).boxpoints = value?.GetDescription(); }
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		public double? DX
		{
			get { return (ValueItems as dynamic).dx; }
			set { (ValueItems as dynamic).dx = value; }
		}

		public double? DY
		{
			get { return (ValueItems as dynamic).dy; }
			set { (ValueItems as dynamic).dy = value; }
		}

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		HoverOptions[]? _HoverInfo = null;
		public HoverOptions[]? HoverInfo
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

		BoxHoverOnOptions[]? _HoverOn = null;
		public BoxHoverOnOptions[]? HoverOn
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

		public double? Jitter
		{
			get { return (ValueItems as dynamic).jitter; }
			set { (ValueItems as dynamic).jitter = value; }
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

		LineColorWidthInfo? _Line = null;
		public LineColorWidthInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		public object? LowerFence
		{
			get { return (ValueItems as dynamic).lowerfence; }
			set { (ValueItems as dynamic).lowerfence = value; }
		}

		MarkerBoxInfo? _Marker = null;
		public MarkerBoxInfo? Marker
		{
			get { return _Marker; }
			set
			{
				_Marker = value;
				(ValueItems as dynamic).marker = _Marker?.ValueItems;
			}
		}

		public object? Mean
		{
			get { return (ValueItems as dynamic).mean; }
			set { (ValueItems as dynamic).mean = value; }
		}

		public object? Median
		{
			get { return (ValueItems as dynamic).median; }
			set { (ValueItems as dynamic).median = value; }
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

		public bool? Notched
		{
			get { return (ValueItems as dynamic).notched; }
			set { (ValueItems as dynamic).notched = value; }
		}

		public object? NotchSpan
		{
			get { return (ValueItems as dynamic).notchspan; }
			set { (ValueItems as dynamic).notchspan = value; }
		}

		public double? NotchWidth
		{
			get { return (ValueItems as dynamic).notchwidth; }
			set { (ValueItems as dynamic).notchwidth = value; }
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

		public double? PointPosition
		{
			get { return (ValueItems as dynamic).pointpos; }
			set { (ValueItems as dynamic).pointpos = value; }
		}

		public object? Q1
		{
			get { return (ValueItems as dynamic).q1; }
			set { (ValueItems as dynamic).q1 = value; }
		}

		public object? Q3
		{
			get { return (ValueItems as dynamic).q3; }
			set { (ValueItems as dynamic).q3 = value; }
		}

		public QuartileMethodOptions? QuartileMethod
		{
			get { return EnumerationStatic.GetValueFromDescription<QuartileMethodOptions> ((ValueItems as dynamic).quartilemethod); }
			set { (ValueItems as dynamic).quartilemethod = value?.GetDescription(); }
		}

		public object? SD
		{
			get { return (ValueItems as dynamic).sd; }
			set { (ValueItems as dynamic).sd = value; }
		}

		SelectionBoxInfo? _Selected = null;
		public SelectionBoxInfo? Selected
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

		SelectionBoxInfo? _Unselected = null;
		public SelectionBoxInfo? Unselected
		{
			get { return _Unselected; }
			set
			{
				_Unselected = value;
				(ValueItems as dynamic).unselected = _Unselected?.ValueItems;
			}
		}

		public object? UpperFence
		{
			get { return (ValueItems as dynamic).upperfence; }
			set { (ValueItems as dynamic).upperfence = value; }
		}

		public VisibleOptions? Visible
		{
			get { return EnumerationStatic.GetValueFromDescription<VisibleOptions> ((ValueItems as dynamic).visible); }
			set { (ValueItems as dynamic).visible = value?.GetDescription(); }
		}

		public double? WhiskerWidth
		{
			get { return (ValueItems as dynamic).whiskerwidth; }
			set { (ValueItems as dynamic).whiskerwidth = value; }
		}

		public double? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

		public object? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public object? X0
		{
			get { return (ValueItems as dynamic).x0; }
			set { (ValueItems as dynamic).x0 = value; }
		}

		public object? XAxis
		{
			get { return (ValueItems as dynamic).xaxis; }
			set { (ValueItems as dynamic).xaxis = value; }
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

		public object? XPeriod
		{
			get { return (ValueItems as dynamic).xperiod; }
			set { (ValueItems as dynamic).xperiod = value; }
		}

		public object? XPeriod0
		{
			get { return (ValueItems as dynamic).xperiod0; }
			set { (ValueItems as dynamic).xperiod0 = value; }
		}

		public StartMiddleEndOptions? XPeriodAlignment
		{
			get { return EnumerationStatic.GetValueFromDescription<StartMiddleEndOptions> ((ValueItems as dynamic).xperiodalignment); }
			set { (ValueItems as dynamic).xperiodalignment = value?.GetDescription(); }
		}

		public object? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

		public object? Y0
		{
			get { return (ValueItems as dynamic).y0; }
			set { (ValueItems as dynamic).y0 = value; }
		}

		public object? YAxis
		{
			get { return (ValueItems as dynamic).yaxis; }
			set { (ValueItems as dynamic).yaxis = value; }
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

		public object? YPeriod
		{
			get { return (ValueItems as dynamic).yperiod; }
			set { (ValueItems as dynamic).yperiod = value; }
		}

		public object? YPeriod0
		{
			get { return (ValueItems as dynamic).yperiod0; }
			set { (ValueItems as dynamic).yperiod0 = value; }
		}

		public StartMiddleEndOptions? YPeriodAlignment
		{
			get { return EnumerationStatic.GetValueFromDescription<StartMiddleEndOptions> ((ValueItems as dynamic).yperiodalignment); }
			set { (ValueItems as dynamic).yperiodalignment = value?.GetDescription(); }
		}

	}
}

