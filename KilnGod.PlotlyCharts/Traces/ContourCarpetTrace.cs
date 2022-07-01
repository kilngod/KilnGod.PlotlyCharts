//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ContourCarpetTrace.cs
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

	public class ContourCarpetTrace : Trace
	{

		public ContourCarpetTrace():base(TraceOptions.ContourCarpet)		{		}

		public object? A
		{
			get { return (ValueItems as dynamic).a; }
			set { (ValueItems as dynamic).a = value; }
		}

		public object? A0
		{
			get { return (ValueItems as dynamic).a0; }
			set { (ValueItems as dynamic).a0 = value; }
		}

		public ArrayTypeOptions? AType
		{
			get { return EnumerationStatic.GetValueFromDescription<ArrayTypeOptions> ((ValueItems as dynamic).atype); }
			set { (ValueItems as dynamic).atype = value?.GetDescription(); }
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

		public object? B
		{
			get { return (ValueItems as dynamic).b; }
			set { (ValueItems as dynamic).b = value; }
		}

		public object? B0
		{
			get { return (ValueItems as dynamic).b0; }
			set { (ValueItems as dynamic).b0 = value; }
		}

		public ArrayTypeOptions? BType
		{
			get { return EnumerationStatic.GetValueFromDescription<ArrayTypeOptions> ((ValueItems as dynamic).btype); }
			set { (ValueItems as dynamic).btype = value?.GetDescription(); }
		}

		public string? Carpet
		{
			get { return (ValueItems as dynamic).carpet; }
			set { (ValueItems as dynamic).carpet = value; }
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

		public double? DA
		{
			get { return (ValueItems as dynamic).da; }
			set { (ValueItems as dynamic).da = value; }
		}

		public double? DB
		{
			get { return (ValueItems as dynamic).db; }
			set { (ValueItems as dynamic).db = value; }
		}

		public object? FillColor
		{
			get { return (ValueItems as dynamic).fillcolor; }
			set { (ValueItems as dynamic).fillcolor = value; }
		}

		public object? HoverText
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

		public object? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

		public bool? Transpose
		{
			get { return (ValueItems as dynamic).transpose; }
			set { (ValueItems as dynamic).transpose = value; }
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

		public object? XAxis
		{
			get { return (ValueItems as dynamic).xaxis; }
			set { (ValueItems as dynamic).xaxis = value; }
		}

		public object? YAxis
		{
			get { return (ValueItems as dynamic).yaxis; }
			set { (ValueItems as dynamic).yaxis = value; }
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

