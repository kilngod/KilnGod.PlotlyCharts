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
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;


namespace KilnGod.PlotlyCharts.Layout
{

	public class MapboxInfo : ValuesObject
	{

		public MapboxInfo() : base() { }

		public string? Accesstoken
		{
			get { return (ValueItems as dynamic).accesstoken; }
			set { (ValueItems as dynamic).accesstoken = value; }
		}

		public double? Bearing
		{
			get { return (ValueItems as dynamic).bearing; }
			set { (ValueItems as dynamic).bearing = value; }
		}

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

		ItemList<LayersItem>? _LayersItemss = null;
		public ItemList<LayersItem> LayersItemss
		{
			get
			{
				if (_LayersItemss == null)
				{
					_LayersItemss = new ItemList<LayersItem>();
				}
				return _LayersItemss;
			}
		}

		public double? Pitch
		{
			get { return (ValueItems as dynamic).pitch; }
			set { (ValueItems as dynamic).pitch = value; }
		}

		public StyleOptions? Style
		{
			get { return EnumerationStatic.GetValueFromDescription<StyleOptions>((ValueItems as dynamic).style); }
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
