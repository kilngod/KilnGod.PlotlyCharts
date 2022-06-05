//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CurrentValueInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;
namespace KilnGod.PlotlyCharts.Layout
{


    public class CurrentValueInfo : ValuesObject
	{

		public CurrentValueInfo() : base() { }

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

		public double? Offset
		{
			get { return (ValueItems as dynamic).offset; }
			set { (ValueItems as dynamic).offset = value; }
		}

		public string? Prefix
		{
			get { return (ValueItems as dynamic).prefix; }
			set { (ValueItems as dynamic).prefix = value; }
		}

		public string? Suffix
		{
			get { return (ValueItems as dynamic).suffix; }
			set { (ValueItems as dynamic).suffix = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		public XAnchorOptions? XAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<XAnchorOptions>((ValueItems as dynamic).xanchor); }
			set { (ValueItems as dynamic).xanchor = value?.GetDescription(); }
		}

	}

}
