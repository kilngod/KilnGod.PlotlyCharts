//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SelectionMapboxInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SelectionMapboxInfo : ValuesObject
	{

		public SelectionMapboxInfo():base()		{		}

		MarkerSelectionOpacityInfo? _Marker = null;
		public MarkerSelectionOpacityInfo? Marker
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

