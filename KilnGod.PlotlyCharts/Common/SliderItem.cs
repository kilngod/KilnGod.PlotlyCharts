//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SliderItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SliderItem : ValuesObject
	{

		public SliderItem():base()		{		}

		public double? Active
		{
			get { return (ValueItems as dynamic).active; }
			set { (ValueItems as dynamic).active = value; }
		}

		public object? ActivebgColor
		{
			get { return (ValueItems as dynamic).activebgcolor; }
			set { (ValueItems as dynamic).activebgcolor = value; }
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		public object? BorderColor
		{
			get { return (ValueItems as dynamic).bordercolor; }
			set { (ValueItems as dynamic).bordercolor = value; }
		}

		public double? BorderWidth
		{
			get { return (ValueItems as dynamic).borderwidth; }
			set { (ValueItems as dynamic).borderwidth = value; }
		}

		CurrentValueInfo? _CurrentValue = null;
		public CurrentValueInfo? CurrentValue
		{
			get { return _CurrentValue; }
			set
			{
				_CurrentValue = value;
				(ValueItems as dynamic).currentvalue = _CurrentValue?.ValueItems;
			}
		}

		FontInfo? _Font = null;
		public FontInfo? Font
		{
			get { return _Font; }
			set
			{
				_Font = value;
				(ValueItems as dynamic).font = _Font?.ValueItems;
			}
		}

		public double? Len
		{
			get { return (ValueItems as dynamic).len; }
			set { (ValueItems as dynamic).len = value; }
		}

		public MeasureModeOptions? LenMode
		{
			get { return EnumerationStatic.GetValueFromDescription<MeasureModeOptions> ((ValueItems as dynamic).lenmode); }
			set { (ValueItems as dynamic).lenmode = value?.GetDescription(); }
		}

		public double? MinorTickLen
		{
			get { return (ValueItems as dynamic).minorticklen; }
			set { (ValueItems as dynamic).minorticklen = value; }
		}

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		PadInfo? _Pad = null;
		public PadInfo? Pad
		{
			get { return _Pad; }
			set
			{
				_Pad = value;
				(ValueItems as dynamic).pad = _Pad?.ValueItems;
			}
		}

		ItemList<SliderStepItem>? _Steps = null;
		public ItemList<SliderStepItem>? Steps
		{
			get
			{ 
				return _Steps;
			}
			set
			{ 
				_Steps = value;
				(ValueItems as dynamic).steps = _Steps?.Values;
			}
		}

		public string? TemplateItemName
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public object? TickColor
		{
			get { return (ValueItems as dynamic).tickcolor; }
			set { (ValueItems as dynamic).tickcolor = value; }
		}

		public double? TickLen
		{
			get { return (ValueItems as dynamic).ticklen; }
			set { (ValueItems as dynamic).ticklen = value; }
		}

		public double? TickWidth
		{
			get { return (ValueItems as dynamic).tickwidth; }
			set { (ValueItems as dynamic).tickwidth = value; }
		}

		TransitionSliderInfo? _Transition = null;
		public TransitionSliderInfo? Transition
		{
			get { return _Transition; }
			set
			{
				_Transition = value;
				(ValueItems as dynamic).transition = _Transition?.ValueItems;
			}
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		public double? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public XAnchorOptions? XAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<XAnchorOptions> ((ValueItems as dynamic).xanchor); }
			set { (ValueItems as dynamic).xanchor = value?.GetDescription(); }
		}

		public double? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

		public AutoTopMiddleBottomOptions? YAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoTopMiddleBottomOptions> ((ValueItems as dynamic).yanchor); }
			set { (ValueItems as dynamic).yanchor = value?.GetDescription(); }
		}

	}
}

