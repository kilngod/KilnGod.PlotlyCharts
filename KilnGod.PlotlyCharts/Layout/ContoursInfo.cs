//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ContoursInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layout
{


    public class ContoursInfo : ValuesObject
    {

        public ContoursInfo() : base() { }

        public ColoringOptions? Coloring
        {
            get { return EnumerationStatic.GetValueFromDescription<ColoringOptions>((ValueItems as dynamic).coloring); }
            set { (ValueItems as dynamic).coloring = value?.GetDescription(); }
        }

        public ContoursTypeOptions? ContoursType
        {
            get { return EnumerationStatic.GetValueFromDescription<ContoursTypeOptions>((ValueItems as dynamic).contourstype); }
            set { (ValueItems as dynamic).contourstype = value?.GetDescription(); }
        }

        public float? End
        {
            get { return (ValueItems as dynamic).end; }
            set { (ValueItems as dynamic).end = value; }
        }

        FontInfo? _LabelFont = null;
        public FontInfo? LabelFont
        {
            get { return _LabelFont; }
            set
            {
                _LabelFont = value;
                (ValueItems as dynamic).labelfont = _LabelFont?.ValueItems;
            }
        }

        public string? LabelFormat
        {
            get { return (ValueItems as dynamic).labelformat; }
            set { (ValueItems as dynamic).labelformat = value; }
        }

        public OperationOptions? Operation
        {
            get { return EnumerationStatic.GetValueFromDescription<OperationOptions>((ValueItems as dynamic).operation); }
            set { (ValueItems as dynamic).operation = value?.GetDescription(); }
        }

        public bool? ShowLabels
        {
            get { return (ValueItems as dynamic).showlabels; }
            set { (ValueItems as dynamic).showlabels = value; }
        }

        public bool? ShowLines
        {
            get { return (ValueItems as dynamic).showlines; }
            set { (ValueItems as dynamic).showlines = value; }
        }

        public float? Size
        {
            get { return (ValueItems as dynamic).size; }
            set { (ValueItems as dynamic).size = value; }
        }

        public float? Start
        {
            get { return (ValueItems as dynamic).start; }
            set { (ValueItems as dynamic).start = value; }
        }

        public object? Value
        {
            get { return (ValueItems as dynamic).value; }
            set { (ValueItems as dynamic).value = value; }
        }

    }

}
