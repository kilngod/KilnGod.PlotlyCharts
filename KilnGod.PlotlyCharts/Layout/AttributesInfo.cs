//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: AttributesInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Traces;

namespace KilnGod.PlotlyCharts.Layout
{

    public class AttributesInfo : ValuesObject
    {

        public AttributesInfo() : base() { }

        public string? Alignmentgroup
        {
            get { return (ValueItems as dynamic).alignmentgroup; }
            set { (ValueItems as dynamic).alignmentgroup = value; }
        }

        // does this work?
        public object? Base
        {
            get { return (ValueItems as dynamic)["base"]; }
            set { (ValueItems as dynamic)["base"] = value; }
        }


        public bool? CliponAxis
        {
            get { return (ValueItems as dynamic).cliponaxis; }
            set { (ValueItems as dynamic).cliponaxis = value; }
        }

        public ConstrainTextOptions? ConstrainText
        {
            get { return EnumerationStatic.GetValueFromDescription<ConstrainTextOptions>((ValueItems as dynamic).constraintext); }
            set { (ValueItems as dynamic).constraintext = value?.GetDescription(); }
        }

        public object? Customdata
        {
            get { return (ValueItems as dynamic).customdata; }
            set { (ValueItems as dynamic).customdata = value; }
        }

        public float? Dx
        {
            get { return (ValueItems as dynamic).dx; }
            set { (ValueItems as dynamic).dx = value; }
        }

        public float? Dy
        {
            get { return (ValueItems as dynamic).dy; }
            set { (ValueItems as dynamic).dy = value; }
        }

        ErrorInfo? _ErrorX = null;
        public ErrorInfo? ErrorX
        {
            get { return _ErrorX; }
            set
            {
                _ErrorX = value;
                (ValueItems as dynamic).error_x = _ErrorX?.ValueItems;
            }
        }

        ErrorInfo? _ErrorY = null;
        public ErrorInfo? ErrorY
        {
            get { return _ErrorY; }
            set
            {
                _ErrorY = value;
                (ValueItems as dynamic).error_y = _ErrorY?.ValueItems;
            }
        }

        public HoverInfoOptions? HoverInfo
        {
            get { return EnumerationStatic.GetValueFromDescription<HoverInfoOptions>((ValueItems as dynamic).hoverinfo); }
            set { (ValueItems as dynamic).hoverinfo = value?.GetDescription(); }
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

        public object? Ids
        {
            get { return (ValueItems as dynamic).ids; }
            set { (ValueItems as dynamic).ids = value; }
        }

        public InSideTextAnchorOptions? InSideTextAnchor
        {
            get { return EnumerationStatic.GetValueFromDescription<InSideTextAnchorOptions>((ValueItems as dynamic).insidetextanchor); }
            set { (ValueItems as dynamic).insidetextanchor = value?.GetDescription(); }
        }

        FontInfo? _InsideTextFont = null;
        public FontInfo? InSideTextFont
        {
            get { return _InsideTextFont; }
            set
            {
                _InsideTextFont = value;
                (ValueItems as dynamic).insidetextfont = _InsideTextFont?.ValueItems;
            }
        }

        public string? Legendgroup
        {
            get { return (ValueItems as dynamic).legendgroup; }
            set { (ValueItems as dynamic).legendgroup = value; }
        }

        LegendGroupTitleInfo? _LegendgroupTitle = null;
        public LegendGroupTitleInfo? LegendgroupTitle
        {
            get { return _LegendgroupTitle; }
            set
            {
                _LegendgroupTitle = value;
                (ValueItems as dynamic).legendgrouptitle = _LegendgroupTitle?.ValueItems;
            }
        }

        public float? Legendrank
        {
            get { return (ValueItems as dynamic).legendrank; }
            set { (ValueItems as dynamic).legendrank = value; }
        }

        MarkerInfo? _Marker = null;
        public MarkerInfo? Marker
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

        public float? Offset
        {
            get { return (ValueItems as dynamic).offset; }
            set { (ValueItems as dynamic).offset = value; }
        }

        public string? Offsetgroup
        {
            get { return (ValueItems as dynamic).offsetgroup; }
            set { (ValueItems as dynamic).offsetgroup = value; }
        }

        public float? Opacity
        {
            get { return (ValueItems as dynamic).opacity; }
            set { (ValueItems as dynamic).opacity = value; }
        }

        public OrientationOptions? Orientation
        {
            get { return EnumerationStatic.GetValueFromDescription<OrientationOptions>((ValueItems as dynamic).orientation); }
            set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
        }

        FontInfo? _OutsideTextFont = null;
        public FontInfo? OutsideTextFont
        {
            get { return _OutsideTextFont; }
            set
            {
                _OutsideTextFont = value;
                (ValueItems as dynamic).outsidetextfont = _OutsideTextFont?.ValueItems;
            }
        }

        SelectedInfo? _Selected = null;
        public SelectedInfo? Selected
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

        public bool? Showlegend
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

        FontInfo? _TextFont = null;
        public FontInfo? TextFont
        {
            get { return _TextFont; }
            set
            {
                _TextFont = value;
                (ValueItems as dynamic).textfont = _TextFont?.ValueItems;
            }
        }

        public TextPositionOptions? TextPosition
        {
            get { return EnumerationStatic.GetValueFromDescription<TextPositionOptions>((ValueItems as dynamic).textposition); }
            set { (ValueItems as dynamic).textposition = value?.GetDescription(); }
        }

        public string? Texttemplate
        {
            get { return (ValueItems as dynamic).texttemplate; }
            set { (ValueItems as dynamic).texttemplate = value; }
        }


      
        ItemList<ValuesObject>? _TransformsItems = null;
        public ItemList<ValuesObject> TransformsItems
        {
            get
            {
                if (_TransformsItems == null)
                {
                    _TransformsItems = new ItemList<ValuesObject>();
                }
                return _TransformsItems;
            }
        }




        public string? Uid
        {
            get { return (ValueItems as dynamic).uid; }
            set { (ValueItems as dynamic).uid = value; }
        }

        public object? UiRevision
        {
            get { return (ValueItems as dynamic).uirevision; }
            set { (ValueItems as dynamic).uirevision = value; }
        }

        SelectedInfo? _Unselected = null;
        public SelectedInfo? Unselected
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
            get { return EnumerationStatic.GetValueFromDescription<VisibleOptions>((ValueItems as dynamic).visible); }
            set { (ValueItems as dynamic).visible = value?.GetDescription(); }
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

        public object? X0
        {
            get { return (ValueItems as dynamic).x0; }
            set { (ValueItems as dynamic).x0 = value; }
        }

        public object? XAxis
        {
            get { return (ValueItems as dynamic).xaxis; }
            set { (ValueItems as dynamic).xaxis = value; }
        }

        public XCalendarOptions? XCalendar
        {
            get { return EnumerationStatic.GetValueFromDescription<XCalendarOptions>((ValueItems as dynamic).xcalendar); }
            set { (ValueItems as dynamic).xcalendar = value?.GetDescription(); }
        }

        public string? XhoverFormat
        {
            get { return (ValueItems as dynamic).xhoverformat; }
            set { (ValueItems as dynamic).xhoverformat = value; }
        }

        public object? XPeriod
        {
            get { return (ValueItems as dynamic).xperiod; }
            set { (ValueItems as dynamic).xperiod = value; }
        }

        public object? XPeriod0
        {
            get { return (ValueItems as dynamic).xperiod0; }
            set { (ValueItems as dynamic).xperiod0 = value; }
        }

        public XPeriodAlignmentOptions? XPeriodAlignment
        {
            get { return EnumerationStatic.GetValueFromDescription<XPeriodAlignmentOptions>((ValueItems as dynamic).xperiodalignment); }
            set { (ValueItems as dynamic).xperiodalignment = value?.GetDescription(); }
        }

        public object? Y
        {
            get { return (ValueItems as dynamic).y; }
            set { (ValueItems as dynamic).y = value; }
        }

        public object? Y0
        {
            get { return (ValueItems as dynamic).y0; }
            set { (ValueItems as dynamic).y0 = value; }
        }

        public object? YAxis
        {
            get { return (ValueItems as dynamic).yaxis; }
            set { (ValueItems as dynamic).yaxis = value; }
        }

        public YCalendarOptions? YCalendar
        {
            get { return EnumerationStatic.GetValueFromDescription<YCalendarOptions>((ValueItems as dynamic).ycalendar); }
            set { (ValueItems as dynamic).ycalendar = value?.GetDescription(); }
        }

        public string? YhoverFormat
        {
            get { return (ValueItems as dynamic).yhoverformat; }
            set { (ValueItems as dynamic).yhoverformat = value; }
        }

        public object? YPeriod
        {
            get { return (ValueItems as dynamic).yperiod; }
            set { (ValueItems as dynamic).yperiod = value; }
        }

        public object? YPeriod0
        {
            get { return (ValueItems as dynamic).yperiod0; }
            set { (ValueItems as dynamic).yperiod0 = value; }
        }

        public YPeriodAlignmentOptions? YPeriodAlignment
        {
            get { return EnumerationStatic.GetValueFromDescription<YPeriodAlignmentOptions>((ValueItems as dynamic).yperiodalignment); }
            set { (ValueItems as dynamic).yperiodalignment = value?.GetDescription(); }
        }

    }

}
