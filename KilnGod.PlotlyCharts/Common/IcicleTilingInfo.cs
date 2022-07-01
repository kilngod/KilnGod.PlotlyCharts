//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: IcicleTilingInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class IcicleTilingInfo : ValuesObject
	{

		public IcicleTilingInfo():base()		{		}

		FlipOptions[]? _Flip = null;
		public FlipOptions[]? Flip
		{
			get { return _Flip; }
			set
			{
				_Flip = value;
				if (value != null)
				{
					(ValueItems as dynamic).flip = EnumerationStatic.MakeFlagList(value);
				}
			}
		}

		public OrientationOptions? Orientation
		{
			get { return EnumerationStatic.GetValueFromDescription<OrientationOptions> ((ValueItems as dynamic).orientation); }
			set { (ValueItems as dynamic).orientation = value?.GetDescription(); }
		}

		public double? Pad
		{
			get { return (ValueItems as dynamic).pad; }
			set { (ValueItems as dynamic).pad = value; }
		}

	}
}

