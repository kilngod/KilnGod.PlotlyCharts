//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ProjectionInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
	public class ProjectionInfo : ValuesObject
	{

		public ProjectionInfo() : base() { }

		public float? Distance
		{
			get { return (ValueItems as dynamic).distance; }
			set { (ValueItems as dynamic).distance = value; }
		}

		public object? Parallels
		{
			get { return (ValueItems as dynamic).parallels; }
			set { (ValueItems as dynamic).parallels = value; }
		}

		public ProjectionTypeOptions? ProjectionType
		{
			get { return EnumerationStatic.GetValueFromDescription<ProjectionTypeOptions>((ValueItems as dynamic).projectiontype); }
			set { (ValueItems as dynamic).projectiontype = value?.GetDescription(); }
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

		public float? Scale
		{
			get { return (ValueItems as dynamic).scale; }
			set { (ValueItems as dynamic).scale = value; }
		}

		public float? Tilt
		{
			get { return (ValueItems as dynamic).tilt; }
			set { (ValueItems as dynamic).tilt = value; }
		}

	}



}
