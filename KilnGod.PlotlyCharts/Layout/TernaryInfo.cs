//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TernaryInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{


	public class TernaryInfo : ValuesObject
	{

		public TernaryInfo() : base() { }

		TernaryAxisInfo? _AAxis = null;
		public TernaryAxisInfo? AAxis
		{
			get { return _AAxis; }
			set
			{
				_AAxis = value;
				(ValueItems as dynamic).aaxis = _AAxis?.ValueItems;
			}
		}

		TernaryAxisInfo? _BAxis = null;
		public TernaryAxisInfo? BAxis
		{
			get { return _BAxis; }
			set
			{
				_BAxis = value;
				(ValueItems as dynamic).baxis = _BAxis?.ValueItems;
			}
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		TernaryAxisInfo? _CAxis = null;
		public TernaryAxisInfo? CAxis
		{
			get { return _CAxis; }
			set
			{
				_CAxis = value;
				(ValueItems as dynamic).caxis = _CAxis?.ValueItems;
			}
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

		public double? Sum
		{
			get { return (ValueItems as dynamic).sum; }
			set { (ValueItems as dynamic).sum = value; }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

	}


}
