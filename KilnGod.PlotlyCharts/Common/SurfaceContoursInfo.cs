//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SurfaceContoursInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class SurfaceContoursInfo : ValuesObject
	{

		public SurfaceContoursInfo():base()		{		}

		ContoursRenderInfo? _X = null;
		public ContoursRenderInfo? X
		{
			get { return _X; }
			set
			{
				_X = value;
				(ValueItems as dynamic).x = _X?.ValueItems;
			}
		}

		ContoursRenderInfo? _Y = null;
		public ContoursRenderInfo? Y
		{
			get { return _Y; }
			set
			{
				_Y = value;
				(ValueItems as dynamic).y = _Y?.ValueItems;
			}
		}

		ContoursRenderInfo? _Z = null;
		public ContoursRenderInfo? Z
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

