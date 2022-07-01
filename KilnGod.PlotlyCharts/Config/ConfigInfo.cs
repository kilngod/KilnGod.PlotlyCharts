//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ConfigInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Configuration
{

	public class ConfigInfo : ValuesObject
	{

		public ConfigInfo():base()		{		}

		public bool? AutoSizable
		{
			get { return (ValueItems as dynamic).autosizable; }
			set { (ValueItems as dynamic).autosizable = value; }
		}

		public bool? DisplayLogo
		{
			get { return (ValueItems as dynamic).displaylogo; }
			set { (ValueItems as dynamic).displaylogo = value; }
		}

		public DisplayModeBarOptions? DisplayModeBar
		{
			get { return EnumerationStatic.GetValueFromDescription<DisplayModeBarOptions> ((ValueItems as dynamic).displaymodebar); }
			set { (ValueItems as dynamic).displaymodebar = value?.GetDescription(); }
		}

		public DoubleClickOptions? DoubleClick
		{
			get { return EnumerationStatic.GetValueFromDescription<DoubleClickOptions> ((ValueItems as dynamic).doubleclick); }
			set { (ValueItems as dynamic).doubleclick = value?.GetDescription(); }
		}

		public double? DoubleClickDelay
		{
			get { return (ValueItems as dynamic).doubleclickdelay; }
			set { (ValueItems as dynamic).doubleclickdelay = value; }
		}

		public bool? Editable
		{
			get { return (ValueItems as dynamic).editable; }
			set { (ValueItems as dynamic).editable = value; }
		}

		EditsInfo? _Edits = null;
		public EditsInfo? Edits
		{
			get { return _Edits; }
			set
			{
				_Edits = value;
				(ValueItems as dynamic).edits = _Edits?.ValueItems;
			}
		}

		public bool? FillFrame
		{
			get { return (ValueItems as dynamic).fillframe; }
			set { (ValueItems as dynamic).fillframe = value; }
		}

		public double? FrameMargins
		{
			get { return (ValueItems as dynamic).framemargins; }
			set { (ValueItems as dynamic).framemargins = value; }
		}

		public object? GlobalTransforms
		{
			get { return (ValueItems as dynamic).globaltransforms; }
			set { (ValueItems as dynamic).globaltransforms = value; }
		}

		public string? LinkText
		{
			get { return (ValueItems as dynamic).linktext; }
			set { (ValueItems as dynamic).linktext = value; }
		}

		public string? Locale
		{
			get { return (ValueItems as dynamic).locale; }
			set { (ValueItems as dynamic).locale = value; }
		}

		public object? Locales
		{
			get { return (ValueItems as dynamic).locales; }
			set { (ValueItems as dynamic).locales = value; }
		}

		public int? Logging
		{
			get { return (ValueItems as dynamic).logging; }
			set { (ValueItems as dynamic).logging = value; }
		}

		public string? MapboxAccessToken
		{
			get { return (ValueItems as dynamic).mapboxaccesstoken; }
			set { (ValueItems as dynamic).mapboxaccesstoken = value; }
		}

		public object? ModeBarButtons
		{
			get { return (ValueItems as dynamic).modebarbuttons; }
			set { (ValueItems as dynamic).modebarbuttons = value; }
		}

		public object? ModeBarButtonsToAdd
		{
			get { return (ValueItems as dynamic).modebarbuttonstoadd; }
			set { (ValueItems as dynamic).modebarbuttonstoadd = value; }
		}

		public object? ModeBarButtonsToRemove
		{
			get { return (ValueItems as dynamic).modebarbuttonstoremove; }
			set { (ValueItems as dynamic).modebarbuttonstoremove = value; }
		}

		public int? NotifyOnLogging
		{
			get { return (ValueItems as dynamic).notifyonlogging; }
			set { (ValueItems as dynamic).notifyonlogging = value; }
		}

		public double? PlotGlPixelRatio
		{
			get { return (ValueItems as dynamic).plotglpixelratio; }
			set { (ValueItems as dynamic).plotglpixelratio = value; }
		}

		public string? PlotlyServerURL
		{
			get { return (ValueItems as dynamic).plotlyserverurl; }
			set { (ValueItems as dynamic).plotlyserverurl = value; }
		}

		public int? QueueLength
		{
			get { return (ValueItems as dynamic).queuelength; }
			set { (ValueItems as dynamic).queuelength = value; }
		}

		public bool? Responsive
		{
			get { return (ValueItems as dynamic).responsive; }
			set { (ValueItems as dynamic).responsive = value; }
		}

		ScrollZoomOptions[]? _ScrollZoom = null;
		public ScrollZoomOptions[]? ScrollZoom
		{
			get { return _ScrollZoom; }
			set
			{
				_ScrollZoom = value;
				if (value != null)
				{
					(ValueItems as dynamic).scrollzoom = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public bool? SendData
		{
			get { return (ValueItems as dynamic).senddata; }
			set { (ValueItems as dynamic).senddata = value; }
		}

		public object? SetBackground
		{
			get { return (ValueItems as dynamic).setbackground; }
			set { (ValueItems as dynamic).setbackground = value; }
		}

		public bool? ShowAxisDragHandles
		{
			get { return (ValueItems as dynamic).showaxisdraghandles; }
			set { (ValueItems as dynamic).showaxisdraghandles = value; }
		}

		public bool? ShowAxisRangeEntryBoxes
		{
			get { return (ValueItems as dynamic).showaxisrangeentryboxes; }
			set { (ValueItems as dynamic).showaxisrangeentryboxes = value; }
		}

		public bool? ShowLink
		{
			get { return (ValueItems as dynamic).showlink; }
			set { (ValueItems as dynamic).showlink = value; }
		}

		public bool? ShowSendToCloud
		{
			get { return (ValueItems as dynamic).showsendtocloud; }
			set { (ValueItems as dynamic).showsendtocloud = value; }
		}

		public object? ShowSources
		{
			get { return (ValueItems as dynamic).showsources; }
			set { (ValueItems as dynamic).showsources = value; }
		}

		public bool? ShowTips
		{
			get { return (ValueItems as dynamic).showtips; }
			set { (ValueItems as dynamic).showtips = value; }
		}

		public bool? StaticPlot
		{
			get { return (ValueItems as dynamic).staticplot; }
			set { (ValueItems as dynamic).staticplot = value; }
		}

		public object? ToImageButtonOptions
		{
			get { return (ValueItems as dynamic).toimagebuttonoptions; }
			set { (ValueItems as dynamic).toimagebuttonoptions = value; }
		}

		public string? TopoJsonURL
		{
			get { return (ValueItems as dynamic).topojsonurl; }
			set { (ValueItems as dynamic).topojsonurl = value; }
		}

		public bool? TypesetMath
		{
			get { return (ValueItems as dynamic).typesetmath; }
			set { (ValueItems as dynamic).typesetmath = value; }
		}

		public bool? Watermark
		{
			get { return (ValueItems as dynamic).watermark; }
			set { (ValueItems as dynamic).watermark = value; }
		}

	}
}

