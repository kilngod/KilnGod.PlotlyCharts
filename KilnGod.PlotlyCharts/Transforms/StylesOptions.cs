//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: StylesOptions.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{
	public class StylesOptions : ValuesObject
	{

		public StylesOptions() : base() { }

		ItemList<StyleItem>? _StyleItems = null;
		public ItemList<StyleItem> StyleItems
		{
			get
			{
				if (_StyleItems == null)
				{
					_StyleItems = new ItemList<StyleItem>();
				}
				return _StyleItems;
			}
		}

	}

}
