//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Scatter3DProjection.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class Scatter3DProjection : ValuesObject
	{

		public Scatter3DProjection():base()		{		}

		ProjectionRenderInfo? _X = null;
		public ProjectionRenderInfo? X
		{
			get { return _X; }
			set
			{
				_X = value;
				(ValueItems as dynamic).x = _X?.ValueItems;
			}
		}

		ProjectionRenderInfo? _Y = null;
		public ProjectionRenderInfo? Y
		{
			get { return _Y; }
			set
			{
				_Y = value;
				(ValueItems as dynamic).y = _Y?.ValueItems;
			}
		}

		ProjectionRenderInfo? _Z = null;
		public ProjectionRenderInfo? Z
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

