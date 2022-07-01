//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ScatterGeoTrace.cs
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

	public class ScatterGeoTrace : Trace
	{

		public ScatterGeoTrace():base(TraceOptions.ScatterGeo)		{		}

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

		public string? FeatureIDKey
		{
			get { return (ValueItems as dynamic).featureidkey; }
			set { (ValueItems as dynamic).featureidkey = value; }
		}

		public FillOptions? Fill
		{
			get { return EnumerationStatic.GetValueFromDescription<FillOptions> ((ValueItems as dynamic).fill); }
			set { (ValueItems as dynamic).fill = value?.GetDescription(); }
		}

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		public object? Geo
		{
			get { return (ValueItems as dynamic).geo; }
			set { (ValueItems as dynamic).geo = value; }
		}

		public object? GeoJson
		{
			get { return (ValueItems as dynamic).geojson; }
			set { (ValueItems as dynamic).geojson = value; }
		}

		GeoHoverOptions[]? _HoverInfo = null;
		public GeoHoverOptions[]? HoverInfo
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

		public object? Lat
		{
			get { return (ValueItems as dynamic).lat; }
			set { (ValueItems as dynamic).lat = value; }
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

		LineInfo? _Line = null;
		public LineInfo? Line
		{
			get { return _Line; }
			set
			{
				_Line = value;
				(ValueItems as dynamic).line = _Line?.ValueItems;
			}
		}

		public LocationModeOptions? LocationMode
		{
			get { return EnumerationStatic.GetValueFromDescription<LocationModeOptions> ((ValueItems as dynamic).locationmode); }
			set { (ValueItems as dynamic).locationmode = value?.GetDescription(); }
		}

		public object? Locations
		{
			get { return (ValueItems as dynamic).locations; }
			set { (ValueItems as dynamic).locations = value; }
		}

		public object? Lon
		{
			get { return (ValueItems as dynamic).lon; }
			set { (ValueItems as dynamic).lon = value; }
		}

		MarkerScatterGeoInfo? _Marker = null;
		public MarkerScatterGeoInfo? Marker
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

