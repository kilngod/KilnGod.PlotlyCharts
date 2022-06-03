//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AnnotationItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class AnnotationItem : ValuesObject
	{

		public AnnotationItem() : base() { }

		public AlignOptions? Align
		{
			get { return EnumerationStatic.GetValueFromDescription<AlignOptions>((ValueItems as dynamic).align); }
			set { (ValueItems as dynamic).align = value?.GetDescription(); }
		}

		public object? ArrowColor
		{
			get { return (ValueItems as dynamic).arrowcolor; }
			set { (ValueItems as dynamic).arrowcolor = value; }
		}

		public int? Arrowhead
		{
			get { return (ValueItems as dynamic).arrowhead; }
			set { (ValueItems as dynamic).arrowhead = value; }
		}

		public ArrowSideOptions? ArrowSide
		{
			get { return EnumerationStatic.GetValueFromDescription<ArrowSideOptions>((ValueItems as dynamic).arrowside); }
			set { (ValueItems as dynamic).arrowside = value?.GetDescription(); }
		}

		public float? Arrowsize
		{
			get { return (ValueItems as dynamic).arrowsize; }
			set { (ValueItems as dynamic).arrowsize = value; }
		}

		public float? Arrowwidth
		{
			get { return (ValueItems as dynamic).arrowwidth; }
			set { (ValueItems as dynamic).arrowwidth = value; }
		}

		public object? Ax
		{
			get { return (ValueItems as dynamic).ax; }
			set { (ValueItems as dynamic).ax = value; }
		}

		public AXRefOptions? AXRef
		{
			get { return EnumerationStatic.GetValueFromDescription<AXRefOptions>((ValueItems as dynamic).axref); }
			set { (ValueItems as dynamic).axref = value?.GetDescription(); }
		}

		public object? Ay
		{
			get { return (ValueItems as dynamic).ay; }
			set { (ValueItems as dynamic).ay = value; }
		}

		public AYRefOptions? AYRef
		{
			get { return EnumerationStatic.GetValueFromDescription<AYRefOptions>((ValueItems as dynamic).ayref); }
			set { (ValueItems as dynamic).ayref = value?.GetDescription(); }
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

		public float? BOrderpad
		{
			get { return (ValueItems as dynamic).borderpad; }
			set { (ValueItems as dynamic).borderpad = value; }
		}

		public float? Borderwidth
		{
			get { return (ValueItems as dynamic).borderwidth; }
			set { (ValueItems as dynamic).borderwidth = value; }
		}

		public bool? Captureevents
		{
			get { return (ValueItems as dynamic).captureevents; }
			set { (ValueItems as dynamic).captureevents = value; }
		}

		public ClickToShowOptions? ClickToShow
		{
			get { return EnumerationStatic.GetValueFromDescription<ClickToShowOptions>((ValueItems as dynamic).clicktoshow); }
			set { (ValueItems as dynamic).clicktoshow = value?.GetDescription(); }
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

		public float? Height
		{
			get { return (ValueItems as dynamic).height; }
			set { (ValueItems as dynamic).height = value; }
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

		public string? HoverText
		{
			get { return (ValueItems as dynamic).hovertext; }
			set { (ValueItems as dynamic).hovertext = value; }
		}

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		public object? Opacity
		{
			get { return (ValueItems as dynamic).opacity; }
			set { (ValueItems as dynamic).opacity = value; }
		}

		public bool? ShowArrow
		{
			get { return (ValueItems as dynamic).showarrow; }
			set { (ValueItems as dynamic).showarrow = value; }
		}

		public float? Standoff
		{
			get { return (ValueItems as dynamic).standoff; }
			set { (ValueItems as dynamic).standoff = value; }
		}

		public int? Startarrowhead
		{
			get { return (ValueItems as dynamic).startarrowhead; }
			set { (ValueItems as dynamic).startarrowhead = value; }
		}

		public float? Startarrowsize
		{
			get { return (ValueItems as dynamic).startarrowsize; }
			set { (ValueItems as dynamic).startarrowsize = value; }
		}

		public float? Startstandoff
		{
			get { return (ValueItems as dynamic).startstandoff; }
			set { (ValueItems as dynamic).startstandoff = value; }
		}

		public string? Templateitemname
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public string? Text
		{
			get { return (ValueItems as dynamic).text; }
			set { (ValueItems as dynamic).text = value; }
		}

		public float? TextAngle
		{
			get { return (ValueItems as dynamic).textangle; }
			set { (ValueItems as dynamic).textangle = value; }
		}

		public VAlignOptions? VAlign
		{
			get { return EnumerationStatic.GetValueFromDescription<VAlignOptions>((ValueItems as dynamic).valign); }
			set { (ValueItems as dynamic).valign = value?.GetDescription(); }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		public float? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

		public object? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public XAnchorOptions? XAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<XAnchorOptions>((ValueItems as dynamic).xanchor); }
			set { (ValueItems as dynamic).xanchor = value?.GetDescription(); }
		}

		public object? XClick
		{
			get { return (ValueItems as dynamic).xclick; }
			set { (ValueItems as dynamic).xclick = value; }
		}

		public XRefOptions? XRef
		{
			get { return EnumerationStatic.GetValueFromDescription<XRefOptions>((ValueItems as dynamic).xref); }
			set { (ValueItems as dynamic).xref = value?.GetDescription(); }
		}

		public float? Xshift
		{
			get { return (ValueItems as dynamic).xshift; }
			set { (ValueItems as dynamic).xshift = value; }
		}

		public object? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

		public YAnchorOptions? YAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<YAnchorOptions>((ValueItems as dynamic).yanchor); }
			set { (ValueItems as dynamic).yanchor = value?.GetDescription(); }
		}

		public object? YClick
		{
			get { return (ValueItems as dynamic).yclick; }
			set { (ValueItems as dynamic).yclick = value; }
		}

		public YRefOptions? YRef
		{
			get { return EnumerationStatic.GetValueFromDescription<YRefOptions>((ValueItems as dynamic).yref); }
			set { (ValueItems as dynamic).yref = value?.GetDescription(); }
		}

		public float? Yshift
		{
			get { return (ValueItems as dynamic).yshift; }
			set { (ValueItems as dynamic).yshift = value; }
		}

	}

}




