//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SceneInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SceneInfo : ValuesObject
	{

		public SceneInfo():base()		{		}

		ItemList<AnnotationItem>? _Annotations = null;
		public ItemList<AnnotationItem>? Annotations
		{
			get
			{ 
				return _Annotations;
			}
			set
			{ 
				_Annotations = value;
				(ValueItems as dynamic).annotations = _Annotations?.Values;
			}
		}

		public AspectModeOptions? AspectMode
		{
			get { return EnumerationStatic.GetValueFromDescription<AspectModeOptions> ((ValueItems as dynamic).aspectmode); }
			set { (ValueItems as dynamic).aspectmode = value?.GetDescription(); }
		}

		AspectRatioInfo? _AspectRatio = null;
		public AspectRatioInfo? AspectRatio
		{
			get { return _AspectRatio; }
			set
			{
				_AspectRatio = value;
				(ValueItems as dynamic).aspectratio = _AspectRatio?.ValueItems;
			}
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		CameraInfo? _Camera = null;
		public CameraInfo? Camera
		{
			get { return _Camera; }
			set
			{
				_Camera = value;
				(ValueItems as dynamic).camera = _Camera?.ValueItems;
			}
		}

		DomainInfo? _Domain = null;
		public DomainInfo? Domain
		{
			get { return _Domain; }
			set
			{
				_Domain = value;
				(ValueItems as dynamic).domain = _Domain?.ValueItems;
			}
		}

		public DragModeOptions? DragMode
		{
			get { return EnumerationStatic.GetValueFromDescription<DragModeOptions> ((ValueItems as dynamic).dragmode); }
			set { (ValueItems as dynamic).dragmode = value?.GetDescription(); }
		}

		public SceneHoverModeOptions? HoverMode
		{
			get { return EnumerationStatic.GetValueFromDescription<SceneHoverModeOptions> ((ValueItems as dynamic).hovermode); }
			set { (ValueItems as dynamic).hovermode = value?.GetDescription(); }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		SceneAxisInfo? _XAxis = null;
		public SceneAxisInfo? XAxis
		{
			get { return _XAxis; }
			set
			{
				_XAxis = value;
				(ValueItems as dynamic).xaxis = _XAxis?.ValueItems;
			}
		}

		SceneYAxisInfo? _YAxis = null;
		public SceneYAxisInfo? YAxis
		{
			get { return _YAxis; }
			set
			{
				_YAxis = value;
				(ValueItems as dynamic).yaxis = _YAxis?.ValueItems;
			}
		}

		SceneAxisInfo? _ZAxis = null;
		public SceneAxisInfo? ZAxis
		{
			get { return _ZAxis; }
			set
			{
				_ZAxis = value;
				(ValueItems as dynamic).zaxis = _ZAxis?.ValueItems;
			}
		}

	}
}

