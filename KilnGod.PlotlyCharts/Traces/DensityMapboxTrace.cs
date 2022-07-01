//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: DensityMapboxTrace.cs
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

	public class DensityMapboxTrace : Trace
	{

		public DensityMapboxTrace():base(TraceOptions.DensityMapbox)		{		}

		public bool? AutoColorScale
		{
			get { return (ValueItems as dynamic).autocolorscale; }
			set { (ValueItems as dynamic).autocolorscale = value; }
		}

		public string? Below
		{
			get { return (ValueItems as dynamic).below; }
			set { (ValueItems as dynamic).below = value; }
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

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		DensityMapboxHoverOptions[]? _HoverInfo = null;
		public DensityMapboxHoverOptions[]? HoverInfo
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

		public object? Lon
		{
			get { return (ValueItems as dynamic).lon; }
			set { (ValueItems as dynamic).lon = value; }
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

		public double? Radius
		{
			get { return (ValueItems as dynamic).radius; }
			set { (ValueItems as dynamic).radius = value; }
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

		public object? Subplot
		{
			get { return (ValueItems as dynamic).subplot; }
			set { (ValueItems as dynamic).subplot = value; }
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

		public VisibleOptions? Visible
		{
			get { return EnumerationStatic.GetValueFromDescription<VisibleOptions> ((ValueItems as dynamic).visible); }
			set { (ValueItems as dynamic).visible = value?.GetDescription(); }
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

