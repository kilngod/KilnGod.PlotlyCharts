//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ProjectionGeoInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class ProjectionGeoInfo : ValuesObject
	{

		public ProjectionGeoInfo():base()		{		}

		public double? Distance
		{
			get { return (ValueItems as dynamic).distance; }
			set { (ValueItems as dynamic).distance = value; }
		}

		public object? Parallels
		{
			get { return (ValueItems as dynamic).parallels; }
			set { (ValueItems as dynamic).parallels = value; }
		}

		RotationInfo? _Rotation = null;
		public RotationInfo? Rotation
		{
			get { return _Rotation; }
			set
			{
				_Rotation = value;
				(ValueItems as dynamic).rotation = _Rotation?.ValueItems;
			}
		}

		public double? Scale
		{
			get { return (ValueItems as dynamic).scale; }
			set { (ValueItems as dynamic).scale = value; }
		}

		public double? Tilt
		{
			get { return (ValueItems as dynamic).tilt; }
			set { (ValueItems as dynamic).tilt = value; }
		}

		public GeoProjectionTypeOptions? Type
		{
			get { return EnumerationStatic.GetValueFromDescription<GeoProjectionTypeOptions> ((ValueItems as dynamic).type); }
			set { (ValueItems as dynamic).type = value?.GetDescription(); }
		}

	}
}

