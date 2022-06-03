//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: FramesInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Frames
{
	public class FramesInfo : ValuesObject
	{

		public FramesInfo() : base() { }

		ItemList<FramesEntryItem>? _FramesEntryItems = null;
		public ItemList<FramesEntryItem> FramesEntryItems
		{
			get
			{
				if (_FramesEntryItems == null)
				{
					_FramesEntryItems = new ItemList<FramesEntryItem>();
				}
				return _FramesEntryItems;
			}
		}

	}

}
