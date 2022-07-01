//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TreemapTilingInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class TreemapTilingInfo : ValuesObject
	{

		public TreemapTilingInfo():base()		{		}

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

		public PackingOptions? Packing
		{
			get { return EnumerationStatic.GetValueFromDescription<PackingOptions> ((ValueItems as dynamic).packing); }
			set { (ValueItems as dynamic).packing = value?.GetDescription(); }
		}

		public double? Pad
		{
			get { return (ValueItems as dynamic).pad; }
			set { (ValueItems as dynamic).pad = value; }
		}

		public double? SquarifyRatio
		{
			get { return (ValueItems as dynamic).squarifyratio; }
			set { (ValueItems as dynamic).squarifyratio = value; }
		}

	}
}

