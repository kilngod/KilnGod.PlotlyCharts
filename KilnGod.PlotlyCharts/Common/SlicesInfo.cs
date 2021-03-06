//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SlicesInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SlicesInfo : ValuesObject
	{

		public SlicesInfo():base()		{		}

		SliceInfo? _X = null;
		public SliceInfo? X
		{
			get { return _X; }
			set
			{
				_X = value;
				(ValueItems as dynamic).x = _X?.ValueItems;
			}
		}

		SliceInfo? _Y = null;
		public SliceInfo? Y
		{
			get { return _Y; }
			set
			{
				_Y = value;
				(ValueItems as dynamic).y = _Y?.ValueItems;
			}
		}

		SliceInfo? _Z = null;
		public SliceInfo? Z
		{
			get { return _Z; }
			set
			{
				_Z = value;
				(ValueItems as dynamic).z = _Z?.ValueItems;
			}
		}

	}
}

