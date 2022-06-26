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

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class LegendInfo : ValuesObject
	{

		public LegendInfo() : base() { }

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

		public double? Borderwidth
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
			get { return EnumerationStatic.GetValueFromDescription<GroupClickOptions>((ValueItems as dynamic).groupclick); }
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
			get { return EnumerationStatic.GetValueFromDescription<ItemClickOptions>((ValueItems as dynamic).itemclick); }
			set { (ValueItems as dynamic).itemclick = value?.GetDescription(); }
		}

		public ItemDoubleClickOptions? ItemDoubleClick
		{
			get { return EnumerationStatic.GetValueFromDescription<ItemDoubleClickOptions>((ValueItems as dynamic).itemdoubleclick); }
			set { (ValueItems as dynamic).itemdoubleclick = value?.GetDescription(); }
		}

		public ItemSizingOptions? ItemSizing
		{
			get { return EnumerationStatic.GetValueFromDescription<ItemSizingOptions>((ValueItems as dynamic).itemsizing); }
			set { (ValueItems as dynamic).itemsizing = value?.GetDescription(); }
		}

		public double? Itemwidth
		{
			get { return (ValueItems as dynamic).itemwidth; }
			set { (ValueItems as dynamic).itemwidth = value; }
		}

		public OrientationOptions? Orientation
		{
			get { return EnumerationStatic.GetValueFromDescription<OrientationOptions>((ValueItems as dynamic).orientation); }
			set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
		}

		TitleInfo? _Title = null;
		public TitleInfo? Title
		{
			get { return _Title; }
			set
			{
				_Title = value;
				(ValueItems as dynamic).title = _Title?.ValueItems;
			}
		}

		public double? Tracegroupgap
		{
			get { return (ValueItems as dynamic).tracegroupgap; }
			set { (ValueItems as dynamic).tracegroupgap = value; }
		}

		public TraceOrderOptions? TraceOrder
		{
			get { return EnumerationStatic.GetValueFromDescription<TraceOrderOptions>((ValueItems as dynamic).traceorder); }
			set { (ValueItems as dynamic).traceorder = value?.GetDescription(); }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		public VAlignOptions? VAlign
		{
			get { return EnumerationStatic.GetValueFromDescription<VAlignOptions>((ValueItems as dynamic).valign); }
			set { (ValueItems as dynamic).valign = value?.GetDescription(); }
		}

		public double? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public XAnchorOptions? XAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<XAnchorOptions>((ValueItems as dynamic).xanchor); }
			set { (ValueItems as dynamic).xanchor = value?.GetDescription(); }
		}

		public double? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

		public YAnchorOptions? YAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<YAnchorOptions>((ValueItems as dynamic).yanchor); }
			set { (ValueItems as dynamic).yanchor = value?.GetDescription(); }
		}

	}




}
