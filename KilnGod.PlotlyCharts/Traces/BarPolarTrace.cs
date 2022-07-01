//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: BarPolarTrace.cs
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

	public class BarPolarTrace : Trace
	{

		public BarPolarTrace():base(TraceOptions.BarPolar)		{		}

		public object? Base
		{
			get { return (ValueItems as IDictionary<string, Object?>)["base"]; }
			set { (ValueItems as IDictionary<string, Object?>)["base"] = value; }
		}

		public object? CustomData
		{
			get { return (ValueItems as dynamic).customdata; }
			set { (ValueItems as dynamic).customdata = value; }
		}

		public double? DR
		{
			get { return (ValueItems as dynamic).dr; }
			set { (ValueItems as dynamic).dr = value; }
		}

		public double? DTheta
		{
			get { return (ValueItems as dynamic).dtheta; }
			set { (ValueItems as dynamic).dtheta = value; }
		}

		BarPolarHoverOptions[]? _HoverInfo = null;
		public BarPolarHoverOptions[]? HoverInfo
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

		MarkerBarPolarInfo? _Marker = null;
		public MarkerBarPolarInfo? Marker
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

		public double? Offset
		{
			get { return (ValueItems as dynamic).offset; }
			set { (ValueItems as dynamic).offset = value; }
		}

		public double? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public object? R
		{
			get { return (ValueItems as dynamic).r; }
			set { (ValueItems as dynamic).r = value; }
		}

		public object? R0
		{
			get { return (ValueItems as dynamic).r0; }
			set { (ValueItems as dynamic).r0 = value; }
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

		public object? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

		public object? Theta
		{
			get { return (ValueItems as dynamic).theta; }
			set { (ValueItems as dynamic).theta = value; }
		}

		public object? Theta0
		{
			get { return (ValueItems as dynamic).theta0; }
			set { (ValueItems as dynamic).theta0 = value; }
		}

		public BarPolarThetaUnitOptions? ThetaUnit
		{
			get { return EnumerationStatic.GetValueFromDescription<BarPolarThetaUnitOptions> ((ValueItems as dynamic).thetaunit); }
			set { (ValueItems as dynamic).thetaunit = value?.GetDescription(); }
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

		public object? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

	}
}

