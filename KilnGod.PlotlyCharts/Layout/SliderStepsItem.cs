//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: StepItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;

namespace KilnGod.PlotlyCharts.Layout
{

    public class SliderStepItem : ValuesObject
    {

        public SliderStepItem() : base() { }

        public object? Args
        {
            get { return (ValueItems as dynamic).args; }
            set { (ValueItems as dynamic).args = value; }
        }

       
        public bool? Execute
        {
            get { return (ValueItems as dynamic).execute; }
            set { (ValueItems as dynamic).execute = value; }
        }

        public object? Label
        {
            get { return (ValueItems as dynamic).label; }
            set { (ValueItems as dynamic).label = value; }
        }

        public MethodOptions? Method
        {
            get { return EnumerationStatic.GetValueFromDescription<MethodOptions>((ValueItems as dynamic).method); }
            set { (ValueItems as dynamic).method = value?.GetDescription(); }
        }

        public string? Name
        {
            get { return (ValueItems as dynamic).name; }
            set { (ValueItems as dynamic).name = value; }
        }

        public object? TemplateItemName
        {
            get { return (ValueItems as dynamic).templateitemname; }
            set { (ValueItems as dynamic).templateitemname = value; }
        }

        public object? Value
        {
            get { return (ValueItems as dynamic).value; }
            set { (ValueItems as dynamic).value = value; }
        }

        public bool? Visible
        {
            get { return (ValueItems as dynamic).visible; }
            set { (ValueItems as dynamic).visible = value; }
        }

    }

}
