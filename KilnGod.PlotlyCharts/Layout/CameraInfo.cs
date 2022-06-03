//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: CameraInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{


	public class CameraInfo : ValuesObject
	{

		public CameraInfo() : base() { }

		CenterInfo? _Center = null;
		public CenterInfo? Center
		{
			get { return _Center; }
			set
			{
				_Center = value;
				(ValueItems as dynamic).center = _Center?.ValueItems;
			}
		}

		PositionInfo? _Eye = null;
		public PositionInfo? Eye
		{
			get { return _Eye; }
			set
			{
				_Eye = value;
				(ValueItems as dynamic).eye = _Eye?.ValueItems;
			}
		}

		ProjectionInfo? _Projection = null;
		public ProjectionInfo? Projection
		{
			get { return _Projection; }
			set
			{
				_Projection = value;
				(ValueItems as dynamic).projection = _Projection?.ValueItems;
			}
		}

		PositionInfo? _Up = null;
		public PositionInfo? Up
		{
			get { return _Up; }
			set
			{
				_Up = value;
				(ValueItems as dynamic).up = _Up?.ValueItems;
			}
		}

	}


}
