//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LegendInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class LegendInfo : ValuesObject
	{

		public LegendInfo():base()		{		}

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

		public GroupClickOptions? GroupClick
		{
			get { return EnumerationStatic.GetValueFromDescription<GroupClickOptions> ((ValueItems as dynamic).groupclick); }
			set { (ValueItems as dynamic).groupclick = value?.GetDescription(); }
		}

		GroupTitleFontInfo? _GroupTitleFont = null;
		public GroupTitleFontInfo? GroupTitleFont
		{
			get { return _GroupTitleFont; }
			set
			{
				_GroupTitleFont = value;
				(ValueItems as dynamic).grouptitlefont = _GroupTitleFont?.ValueItems;
			}
		}

		public ItemClickOptions? ItemClick
		{
			get { return EnumerationStatic.GetValueFromDescription<ItemClickOptions> ((ValueItems as dynamic).itemclick); }
			set { (ValueItems as dynamic).itemclick = value?.GetDescription(); }
		}

		public ItemClickOptions? ItemDoubleClick
		{
			get { return EnumerationStatic.GetValueFromDescription<ItemClickOptions> ((ValueItems as dynamic).itemdoubleclick); }
			set { (ValueItems as dynamic).itemdoubleclick = value?.GetDescription(); }
		}

		public ItemSizingOptions? ItemSizing
		{
			get { return EnumerationStatic.GetValueFromDescription<ItemSizingOptions> ((ValueItems as dynamic).itemsizing); }
			set { (ValueItems as dynamic).itemsizing = value?.GetDescription(); }
		}

		public double? ItemWidth
		{
			get { return (ValueItems as dynamic).itemwidth; }
			set { (ValueItems as dynamic).itemwidth = value; }
		}

		public OrientationOptions? Orientation
		{
			get { return EnumerationStatic.GetValueFromDescription<OrientationOptions> ((ValueItems as dynamic).orientation); }
			set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
		}

		TitleLegendInfo? _Title = null;
		public TitleLegendInfo? Title
		{
			get { return _Title; }
			set
			{
				_Title = value;
				(ValueItems as dynamic).title = _Title?.ValueItems;
			}
		}

		public double? TraceGroupGap
		{
			get { return (ValueItems as dynamic).tracegroupgap; }
			set { (ValueItems as dynamic).tracegroupgap = value; }
		}

		TraceOrderOptions[]? _TraceOrder = null;
		public TraceOrderOptions[]? TraceOrder
		{
			get { return _TraceOrder; }
			set
			{
				_TraceOrder = value;
				if (value != null)
				{
					(ValueItems as dynamic).traceorder = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		public TopMiddleBottomOptions? VAlign
		{
			get { return EnumerationStatic.GetValueFromDescription<TopMiddleBottomOptions> ((ValueItems as dynamic).valign); }
			set { (ValueItems as dynamic).valign = value?.GetDescription(); }
		}

		public double? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public XAutoAlignOptions? XAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<XAutoAlignOptions> ((ValueItems as dynamic).xanchor); }
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

