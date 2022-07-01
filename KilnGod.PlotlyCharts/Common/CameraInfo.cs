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
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class CameraInfo : ValuesObject
	{

		public CameraInfo():base()		{		}

		CameraCenterInfo? _Center = null;
		public CameraCenterInfo? Center
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

		ProjectionCameraInfo? _Projection = null;
		public ProjectionCameraInfo? Projection
		{
			get { return _Projection; }
			set
			{
				_Projection = value;
				(ValueItems as dynamic).projection = _Projection?.ValueItems;
			}
		}

		UpInfo? _Up = null;
		public UpInfo? Up
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

