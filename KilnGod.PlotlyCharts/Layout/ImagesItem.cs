//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ImagesItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{


	public class ImagesItem : ValuesObject
	{

		public ImagesItem() : base() { }

		public LayerOptions? Layer
		{
			get { return EnumerationStatic.GetValueFromDescription<LayerOptions>((ValueItems as dynamic).layer); }
			set { (ValueItems as dynamic).layer = value?.GetDescription(); }
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

		public double? Sizex
		{
			get { return (ValueItems as dynamic).sizex; }
			set { (ValueItems as dynamic).sizex = value; }
		}

		public double? Sizey
		{
			get { return (ValueItems as dynamic).sizey; }
			set { (ValueItems as dynamic).sizey = value; }
		}

		public SizingOptions? Sizing
		{
			get { return EnumerationStatic.GetValueFromDescription<SizingOptions>((ValueItems as dynamic).sizing); }
			set { (ValueItems as dynamic).sizing = value?.GetDescription(); }
		}

		public string? Source
		{
			get { return (ValueItems as dynamic).source; }
			set { (ValueItems as dynamic).source = value; }
		}

		public string? Templateitemname
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
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

		public RefOptions? XRef
		{
			get { return EnumerationStatic.GetValueFromDescription<RefOptions>((ValueItems as dynamic).xref); }
			set { (ValueItems as dynamic).xref = value?.GetDescription(); }
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

		public RefOptions? YRef
		{
			get { return EnumerationStatic.GetValueFromDescription<RefOptions>((ValueItems as dynamic).yref); }
			set { (ValueItems as dynamic).yref = value?.GetDescription(); }
		}

	}


}
