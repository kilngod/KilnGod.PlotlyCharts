//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: VolumeTraceTrace.cs
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

	public class VolumeTrace : Trace
	{

		public VolumeTrace():base(TraceOptions.Volume)		{		}

		public bool? AutoColorScale
		{
			get { return (ValueItems as dynamic).autocolorscale; }
			set { (ValueItems as dynamic).autocolorscale = value; }
		}

		CapsInfo? _Caps = null;
		public CapsInfo? Caps
		{
			get { return _Caps; }
			set
			{
				_Caps = value;
				(ValueItems as dynamic).caps = _Caps?.ValueItems;
			}
		}

		public bool? CAuto
		{
			get { return (ValueItems as dynamic).cauto; }
			set { (ValueItems as dynamic).cauto = value; }
		}

		public double? CMax
		{
			get { return (ValueItems as dynamic).cmax; }
			set { (ValueItems as dynamic).cmax = value; }
		}

		public double? CMid
		{
			get { return (ValueItems as dynamic).cmid; }
			set { (ValueItems as dynamic).cmid = value; }
		}

		public double? CMin
		{
			get { return (ValueItems as dynamic).cmin; }
			set { (ValueItems as dynamic).cmin = value; }
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

		ContourInfo? _Contour = null;
		public ContourInfo? Contour
		{
			get { return _Contour; }
			set
			{
				_Contour = value;
				(ValueItems as dynamic).contour = _Contour?.ValueItems;
			}
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		public bool? FlatShading
		{
			get { return (ValueItems as dynamic).flatshading; }
			set { (ValueItems as dynamic).flatshading = value; }
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

		public double? IsoMax
		{
			get { return (ValueItems as dynamic).isomax; }
			set { (ValueItems as dynamic).isomax = value; }
		}

		public double? IsoMin
		{
			get { return (ValueItems as dynamic).isomin; }
			set { (ValueItems as dynamic).isomin = value; }
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

		SurfaceLightingInfo? _Lighting = null;
		public SurfaceLightingInfo? Lighting
		{
			get { return _Lighting; }
			set
			{
				_Lighting = value;
				(ValueItems as dynamic).lighting = _Lighting?.ValueItems;
			}
		}

		PositionInfo? _LightPosition = null;
		public PositionInfo? LightPosition
		{
			get { return _LightPosition; }
			set
			{
				_LightPosition = value;
				(ValueItems as dynamic).lightposition = _LightPosition?.ValueItems;
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

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public object? OpacityScale
		{
			get { return (ValueItems as dynamic).opacityscale; }
			set { (ValueItems as dynamic).opacityscale = value; }
		}

		public bool? ReverseScale
		{
			get { return (ValueItems as dynamic).reversescale; }
			set { (ValueItems as dynamic).reversescale = value; }
		}

		public object? Scene
		{
			get { return (ValueItems as dynamic).scene; }
			set { (ValueItems as dynamic).scene = value; }
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

		SlicesInfo? _Slices = null;
		public SlicesInfo? Slices
		{
			get { return _Slices; }
			set
			{
				_Slices = value;
				(ValueItems as dynamic).slices = _Slices?.ValueItems;
			}
		}

		SpaceframeInfo? _Spaceframe = null;
		public SpaceframeInfo? Spaceframe
		{
			get { return _Spaceframe; }
			set
			{
				_Spaceframe = value;
				(ValueItems as dynamic).spaceframe = _Spaceframe?.ValueItems;
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

		SurfaceInfo? _Surface = null;
		public SurfaceInfo? Surface
		{
			get { return _Surface; }
			set
			{
				_Surface = value;
				(ValueItems as dynamic).surface = _Surface?.ValueItems;
			}
		}

		public object? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
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

		public object? Value
		{
			get { return (ValueItems as dynamic).value; }
			set { (ValueItems as dynamic).value = value; }
		}

		public string? ValueHoverFormat
		{
			get { return (ValueItems as dynamic).valuehoverformat; }
			set { (ValueItems as dynamic).valuehoverformat = value; }
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

		public string? ZHoverFormat
		{
			get { return (ValueItems as dynamic).zhoverformat; }
			set { (ValueItems as dynamic).zhoverformat = value; }
		}

	}
}

