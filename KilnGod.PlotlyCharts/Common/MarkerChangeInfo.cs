//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MarkerChangeInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class MarkerChangeInfo : ValuesObject
	{

		public MarkerChangeInfo():base()		{		}

		MarkerChangeWaterfallInfo? _Marker = null;
		public MarkerChangeWaterfallInfo? Marker
		{
			get { return _Marker; }
			set
			{
				_Marker = value;
				(ValueItems as dynamic).marker = _Marker?.ValueItems;
			}
		}

	}
}

