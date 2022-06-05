//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ErrorInfo.cs
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

    public class ErrorInfo : ValuesObject
    {

        public ErrorInfo() : base() { }

        public object? Array
        {
            get { return (ValueItems as dynamic).array; }
            set { (ValueItems as dynamic).array = value; }
        }

        public object? Arrayminus
        {
            get { return (ValueItems as dynamic).arrayminus; }
            set { (ValueItems as dynamic).arrayminus = value; }
        }

        public object? Color
        {
            get { return (ValueItems as dynamic).color; }
            set { (ValueItems as dynamic).color = value; }
        }

        public bool? CopyYstyle
        {
            get { return (ValueItems as dynamic).copy_ystyle; }
            set { (ValueItems as dynamic).copy_ystyle = value; }
        }

        public ErrorTypeOptions? ErrorXType
        {
            get { return EnumerationStatic.GetValueFromDescription<ErrorTypeOptions>((ValueItems as dynamic).error_type); }
            set { (ValueItems as dynamic).error_xtype = value?.GetDescription(); }
        }

        public bool? Symmetric
        {
            get { return (ValueItems as dynamic).symmetric; }
            set { (ValueItems as dynamic).symmetric = value; }
        }

        public double? Thickness
        {
            get { return (ValueItems as dynamic).thickness; }
            set { (ValueItems as dynamic).thickness = value; }
        }

        public int? Traceref
        {
            get { return (ValueItems as dynamic).traceref; }
            set { (ValueItems as dynamic).traceref = value; }
        }

        public int? Tracerefminus
        {
            get { return (ValueItems as dynamic).tracerefminus; }
            set { (ValueItems as dynamic).tracerefminus = value; }
        }

        public double? Value
        {
            get { return (ValueItems as dynamic).value; }
            set { (ValueItems as dynamic).value = value; }
        }

        public double? Valueminus
        {
            get { return (ValueItems as dynamic).valueminus; }
            set { (ValueItems as dynamic).valueminus = value; }
        }

        public bool? Visible
        {
            get { return (ValueItems as dynamic).visible; }
            set { (ValueItems as dynamic).visible = value; }
        }

        public double? Width
        {
            get { return (ValueItems as dynamic).width; }
            set { (ValueItems as dynamic).width = value; }
        }

    }
}
