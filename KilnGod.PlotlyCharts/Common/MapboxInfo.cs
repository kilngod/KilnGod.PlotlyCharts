//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: MapboxInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class MapboxInfo : ValuesObject
	{

		public MapboxInfo():base()		{		}

		public string? AccessToken
		{
			get { return (ValueItems as dynamic).accesstoken; }
			set { (ValueItems as dynamic).accesstoken = value; }
		}

		public double? Bearing
		{
			get { return (ValueItems as dynamic).bearing; }
			set { (ValueItems as dynamic).bearing = value; }
		}

		GeoCenterInfo? _Center = null;
		public GeoCenterInfo? Center
		{
			get { return _Center; }
			set
			{
				_Center = value;
				(ValueItems as dynamic).center = _Center?.ValueItems;
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

		ItemList<LayerItem>? _Layers = null;
		public ItemList<LayerItem>? Layers
		{
			get
			{ 
				return _Layers;
			}
			set
			{ 
				_Layers = value;
				(ValueItems as dynamic).layers = _Layers?.Values;
			}
		}

		public double? Pitch
		{
			get { return (ValueItems as dynamic).pitch; }
			set { (ValueItems as dynamic).pitch = value; }
		}

		public StyleOptions? Style
		{
			get { return EnumerationStatic.GetValueFromDescription<StyleOptions> ((ValueItems as dynamic).style); }
			set { (ValueItems as dynamic).style = value?.GetDescription(); }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		public double? Zoom
		{
			get { return (ValueItems as dynamic).zoom; }
			set { (ValueItems as dynamic).zoom = value; }
		}

	}
}

