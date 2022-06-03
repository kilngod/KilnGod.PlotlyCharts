//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Trace.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Layout;
using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Wrappers
{


    public class Trace : ValuesObject
    {
        public Trace()
        {

        }
        public Trace(TraceTypeOptions traceType)
        {
            TraceType = traceType.GetDescription();
        }



        AttributesInfo? _Attributes = null;
        public AttributesInfo? Attributes
        {
            get { return _Attributes; }
            set
            {
                _Attributes = value;
                (ValueItems as dynamic).attributes = _Attributes?.ValueItems;
            }
        }

        public bool? AutoMargin
        {
            get { return (ValueItems as dynamic).automargin; }
            set { (ValueItems as dynamic).automargin = value; }
        }


        ConnectorInfo? _Connector = null;
        public ConnectorInfo? Connector
        {
            get { return _Connector; }
            set
            {
                _Connector = value;
                (ValueItems as dynamic).connector = _Connector?.ValueItems;
            }
        }
        public FillOptions? Fill
        {
            get
            {
                var result = (ValueItems as dynamic).fill;
                return EnumerationStatic.GetValueFromDescription(result) as FillOptions?;

            }
            set { (ValueItems as dynamic).fill = value?.GetDescription(); }
        }

        public object? FillColor
        {
            get { return (ValueItems as dynamic).fillcolor; }
            set { (ValueItems as dynamic).fillcolor = value; }
        }

        public bool? HoverOnGaps
        {
            get { return (ValueItems as dynamic).hoverongaps; }
            set { (ValueItems as dynamic).hoverongaps = value; }
        }



        LayoutAttributesInfo? _LayoutAttributes = null;
        public LayoutAttributesInfo? LayoutAttributes
        {
            get { return _LayoutAttributes; }
            set
            {
                _LayoutAttributes = value;
                (ValueItems as dynamic).layoutattributes = _LayoutAttributes?.ValueItems;
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



        public string? LegendGroup
        {
            get { return (ValueItems as dynamic).legendgroup; }
            set { (ValueItems as dynamic).legendgroup = value; }
        }

        public int? LegendRank
        {
            get { return (ValueItems as dynamic).legendrank; }
            set { (ValueItems as dynamic).legendrank = value; }
        }








        LineInfo? _line = null;
        public LineInfo? Line
        {
            get { return _line; }
            set
            {
                _line = value;
                (ValueItems as dynamic).line = _line?.ValueItems;

            }


        }

        MarkerInfo? _marker = null;

        public MarkerInfo? Marker
        {
            get
            {
                return _marker;
            }
            set
            {
                _marker = value;
                (ValueItems as dynamic).marker = _marker?.ValueItems;
            }
        }




        public ModeOptions? Mode
        {
            get
            {
                var result = (ValueItems as dynamic).mode;
                return EnumerationStatic.GetValueFromDescription(result) as ModeOptions?;

            }
            set { (ValueItems as dynamic).mode = value?.GetDescription(); }
        }

        public object? Opacity
        {
            get { return (ValueItems as dynamic).opacity; }
            set { (ValueItems as dynamic).opacity = value; }
        }

        public string ScaleGroup
        {
            get { return (ValueItems as dynamic).scalegroup; }
            set { (ValueItems as dynamic).scalegroup = value; }
        }

        public bool? ShowLegend
        {
            get { return (ValueItems as dynamic).showlegend; }
            set { (ValueItems as dynamic).showlegend = value; }
        }


        public object? Text
        {
            get { return (ValueItems as dynamic).text; }
            set { (ValueItems as dynamic).text = value; }
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

        public TextInfoOptions? TextInfo
        {
            get { return (ValueItems as dynamic).labels; }
            set { (ValueItems as dynamic).labels = value?.GetDescription(); }
        }


        public TextPositionOptions? TextPosition
        {
            get { return (ValueItems as dynamic).textposition; }
            set { (ValueItems as dynamic).textposition = value?.GetDescription(); }
        }

        TitleInfo? _title = null;

        public TitleInfo? Title
        {
            get { return _title; }
            set
            {
                _title = value;
                (ValueItems as dynamic).title = _title?.ValueItems;

            }
        }

        TitleInfo? _legengGroupTitle = null;

        public TitleInfo? LegengGroupTitle
        {
            get { return _legengGroupTitle; }
            set
            {
                _legengGroupTitle = value;
                (ValueItems as dynamic).title = _legengGroupTitle?.ValueItems;

            }
        }

        /* its a bad idea to include every trace option on the same object as it will cause confusion.*/
        public string? TraceType
        {
            get { return (ValueItems as dynamic).type; }
            private set { (ValueItems as dynamic).type = value; }
        }


        public bool? Visible
        {
            get { return (ValueItems as dynamic).visible; }
            set { (ValueItems as dynamic).visible = value; }
        }







        public string? UIRevision
        {
            get { return (ValueItems as dynamic).uirevision; }
            set { (ValueItems as dynamic).uirevision = value; }
        }
    }
}
