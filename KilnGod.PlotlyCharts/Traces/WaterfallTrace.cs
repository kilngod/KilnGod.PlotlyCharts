//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: WaterfallTrace.cs
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

	public class WaterfallTrace : Trace
	{

		public WaterfallTrace():base(TraceOptions.Waterfall)		{		}

		public string? AlignmentGroup
		{
			get { return (ValueItems as dynamic).alignmentgroup; }
			set { (ValueItems as dynamic).alignmentgroup = value; }
		}

		public object? Base
		{
			get { return (ValueItems as IDictionary<string, Object?>)["base"]; }
			set { (ValueItems as IDictionary<string, Object?>)["base"] = value; }
		}

		public bool? CliponAxis
		{
			get { return (ValueItems as dynamic).cliponaxis; }
			set { (ValueItems as dynamic).cliponaxis = value; }
		}

		WaterfallConnectorInfo? _Connector = null;
		public WaterfallConnectorInfo? Connector
		{
			get { return _Connector; }
			set
			{
				_Connector = value;
				(ValueItems as dynamic).connector = _Connector?.ValueItems;
			}
		}

		public ConstrainTextOptions? ConstrainText
		{
			get { return EnumerationStatic.GetValueFromDescription<ConstrainTextOptions> ((ValueItems as dynamic).constraintext); }
			set { (ValueItems as dynamic).constraintext = value?.GetDescription(); }
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		MarkerChangeInfo? _Decreasing = null;
		public MarkerChangeInfo? Decreasing
		{
			get { return _Decreasing; }
			set
			{
				_Decreasing = value;
				(ValueItems as dynamic).decreasing = _Decreasing?.ValueItems;
			}
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

		WaterfallHoverOptions[]? _HoverInfo = null;
		public WaterfallHoverOptions[]? HoverInfo
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

		MarkerChangeInfo? _Increasing = null;
		public MarkerChangeInfo? Increasing
		{
			get { return _Increasing; }
			set
			{
				_Increasing = value;
				(ValueItems as dynamic).increasing = _Increasing?.ValueItems;
			}
		}

		public StartMiddleEndOptions? InsideTextAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<StartMiddleEndOptions> ((ValueItems as dynamic).insidetextanchor); }
			set { (ValueItems as dynamic).insidetextanchor = value?.GetDescription(); }
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

		public object? Measure
		{
			get { return (ValueItems as dynamic).measure; }
			set { (ValueItems as dynamic).measure = value; }
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

		public double? Offset
		{
			get { return (ValueItems as dynamic).offset; }
			set { (ValueItems as dynamic).offset = value; }
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

		WaterfallTextInfoOptions[]? _TextInfo = null;
		public WaterfallTextInfoOptions[]? TextInfo
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

		TotalsInfo? _Totals = null;
		public TotalsInfo? Totals
		{
			get { return _Totals; }
			set
			{
				_Totals = value;
				(ValueItems as dynamic).totals = _Totals?.ValueItems;
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

		public object? Width
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

