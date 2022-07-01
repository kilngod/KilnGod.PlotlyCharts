//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: GeoInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class GeoInfo : ValuesObject
	{

		public GeoInfo():base()		{		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
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

		public object? CoastLineColor
		{
			get { return (ValueItems as dynamic).coastlinecolor; }
			set { (ValueItems as dynamic).coastlinecolor = value; }
		}

		public double? CoastLineWidth
		{
			get { return (ValueItems as dynamic).coastlinewidth; }
			set { (ValueItems as dynamic).coastlinewidth = value; }
		}

		public object? CountryColor
		{
			get { return (ValueItems as dynamic).countrycolor; }
			set { (ValueItems as dynamic).countrycolor = value; }
		}

		public double? CountryWidth
		{
			get { return (ValueItems as dynamic).countrywidth; }
			set { (ValueItems as dynamic).countrywidth = value; }
		}

		GeoDomainInfo? _Domain = null;
		public GeoDomainInfo? Domain
		{
			get { return _Domain; }
			set
			{
				_Domain = value;
				(ValueItems as dynamic).domain = _Domain?.ValueItems;
			}
		}

		public FitBoundsOptions? FitBounds
		{
			get { return EnumerationStatic.GetValueFromDescription<FitBoundsOptions> ((ValueItems as dynamic).fitbounds); }
			set { (ValueItems as dynamic).fitbounds = value?.GetDescription(); }
		}

		public object? FrameColor
		{
			get { return (ValueItems as dynamic).framecolor; }
			set { (ValueItems as dynamic).framecolor = value; }
		}

		public double? FrameWidth
		{
			get { return (ValueItems as dynamic).framewidth; }
			set { (ValueItems as dynamic).framewidth = value; }
		}

		public object? LakeColor
		{
			get { return (ValueItems as dynamic).lakecolor; }
			set { (ValueItems as dynamic).lakecolor = value; }
		}

		public object? LandColor
		{
			get { return (ValueItems as dynamic).landcolor; }
			set { (ValueItems as dynamic).landcolor = value; }
		}

		GeoAxisInfo? _LatAxis = null;
		public GeoAxisInfo? LatAxis
		{
			get { return _LatAxis; }
			set
			{
				_LatAxis = value;
				(ValueItems as dynamic).lataxis = _LatAxis?.ValueItems;
			}
		}

		GeoAxisInfo? _LonAxis = null;
		public GeoAxisInfo? LonAxis
		{
			get { return _LonAxis; }
			set
			{
				_LonAxis = value;
				(ValueItems as dynamic).lonaxis = _LonAxis?.ValueItems;
			}
		}

		public object? OceanColor
		{
			get { return (ValueItems as dynamic).oceancolor; }
			set { (ValueItems as dynamic).oceancolor = value; }
		}

		ProjectionGeoInfo? _Projection = null;
		public ProjectionGeoInfo? Projection
		{
			get { return _Projection; }
			set
			{
				_Projection = value;
				(ValueItems as dynamic).projection = _Projection?.ValueItems;
			}
		}

		public ResolutionOptions? Resolution
		{
			get { return EnumerationStatic.GetValueFromDescription<ResolutionOptions> ((ValueItems as dynamic).resolution); }
			set { (ValueItems as dynamic).resolution = value?.GetDescription(); }
		}

		public object? RiverColor
		{
			get { return (ValueItems as dynamic).rivercolor; }
			set { (ValueItems as dynamic).rivercolor = value; }
		}

		public double? RiverWidth
		{
			get { return (ValueItems as dynamic).riverwidth; }
			set { (ValueItems as dynamic).riverwidth = value; }
		}

		public ScopeOptions? Scope
		{
			get { return EnumerationStatic.GetValueFromDescription<ScopeOptions> ((ValueItems as dynamic).scope); }
			set { (ValueItems as dynamic).scope = value?.GetDescription(); }
		}

		public bool? ShowCoastLines
		{
			get { return (ValueItems as dynamic).showcoastlines; }
			set { (ValueItems as dynamic).showcoastlines = value; }
		}

		public bool? ShowCountries
		{
			get { return (ValueItems as dynamic).showcountries; }
			set { (ValueItems as dynamic).showcountries = value; }
		}

		public bool? ShowFrame
		{
			get { return (ValueItems as dynamic).showframe; }
			set { (ValueItems as dynamic).showframe = value; }
		}

		public bool? ShowLakes
		{
			get { return (ValueItems as dynamic).showlakes; }
			set { (ValueItems as dynamic).showlakes = value; }
		}

		public bool? ShowLand
		{
			get { return (ValueItems as dynamic).showland; }
			set { (ValueItems as dynamic).showland = value; }
		}

		public bool? ShowOcean
		{
			get { return (ValueItems as dynamic).showocean; }
			set { (ValueItems as dynamic).showocean = value; }
		}

		public bool? ShowRivers
		{
			get { return (ValueItems as dynamic).showrivers; }
			set { (ValueItems as dynamic).showrivers = value; }
		}

		public bool? ShowSubunits
		{
			get { return (ValueItems as dynamic).showsubunits; }
			set { (ValueItems as dynamic).showsubunits = value; }
		}

		public object? SubunitColor
		{
			get { return (ValueItems as dynamic).subunitcolor; }
			set { (ValueItems as dynamic).subunitcolor = value; }
		}

		public double? SubunitWidth
		{
			get { return (ValueItems as dynamic).subunitwidth; }
			set { (ValueItems as dynamic).subunitwidth = value; }
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

	}
}

