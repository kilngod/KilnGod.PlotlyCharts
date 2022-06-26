//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PolarInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{


    public class PolarInfo : ValuesObject
	{

		public PolarInfo() : base() { }

		AngularAxisInfo? _AngularAxis = null;
		public AngularAxisInfo? AngularAxis
		{
			get { return _AngularAxis; }
			set
			{
				_AngularAxis = value;
				(ValueItems as dynamic).angularaxis = _AngularAxis?.ValueItems;
			}
		}


		public double? BarGap
		{
			get { return (ValueItems as dynamic).bargap; }
			set { (ValueItems as dynamic).bargap = value; }
		}

		public BarModeOptions? BarMode
		{
			get { return EnumerationStatic.GetValueFromDescription<BarModeOptions>((ValueItems as dynamic).barmode); }
			set { (ValueItems as dynamic).barmode = value?.GetDescription(); }
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		DomainInfo? _Domain = null;
		public DomainInfo? Domain
		{
			get { return _Domain; }
			set
			{
				_Domain = value;
				(ValueItems as dynamic).domain = _Domain?.ValueItems;
			}
		}

		public GridShapeOptions? GridShape
		{
			get { return EnumerationStatic.GetValueFromDescription<GridShapeOptions>((ValueItems as dynamic).gridshape); }
			set { (ValueItems as dynamic).gridshape = value?.GetDescription(); }
		}

		public double? Hole
		{
			get { return (ValueItems as dynamic).hole; }
			set { (ValueItems as dynamic).hole = value; }
		}

		RadialAxisInfo? _RadialAxis = null;
		public RadialAxisInfo? RadialAxis
		{
			get { return _RadialAxis; }
			set
			{
				_RadialAxis = value;
				(ValueItems as dynamic).radialaxis = _RadialAxis?.ValueItems;
			}
		}

		public object? Sector
		{
			get { return (ValueItems as dynamic).sector; }
			set { (ValueItems as dynamic).sector = value; }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

	}
}
