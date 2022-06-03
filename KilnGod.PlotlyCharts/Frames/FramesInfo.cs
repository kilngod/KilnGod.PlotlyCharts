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
		public ItemList<FramesEntryItem>? Frames
		{
			get
			{
				return _FramesEntryItems;
			}
			set
			{
				_FramesEntryItems = value;
				if (value != null)
				{
					(ValueItems as dynamic).frames = value.Values;
				}
			}
		}

		

	}

}
