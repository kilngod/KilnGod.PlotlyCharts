//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyMaps.razor.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using Microsoft.AspNetCore.Components;
using System.Dynamic;
using System.Text.Json;
using KilnGod.PlotlyCharts.Configuration;
using KilnGod.PlotlyCharts.Services;
using KilnGod.PlotlyCharts.Traces;
using KilnGod.PlotlyCharts.Enumerations;

using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.DemoTest.Models;
using KilnGod.PlotlyCharts.Layouts;
using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Transforms;

namespace KilnGod.PlotlyCharts.DemoTest.Pages
{
    public partial class PlotlyMaps : DemoBaseComponent
    {

#nullable disable
		public PlotlyChart Chart1 { get; set; }

#nullable enable

		[Inject]
		public IWebfileRepository? Webfile { get; set; }

		public bool DisabledButtons { get; set; } = true;

		static int plotWidth = 800;
		static int plotHeight = 800;

        public ElementReference firstButton { get; set; }


        // common plotly layout used in many examples
        Layout commonLayout = new Layout() {
			Margin = new MarginInfo()
			{
				L = 0,
				R = 0,
				B = 0,
				T = 0
			},
			Height = plotHeight,
			Width = plotWidth
		};

		// common plotly config used in many examples
		ConfigInfo commonConfig = new ConfigInfo() { Responsive = true, Editable = false, DisplayLogo = false };



		/// <summary>
		/// Set capture to detect the chart control is ready for action
		/// </summary>
		/// <param name="firstRender"></param>
		/// <returns></returns>
		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				Chart1.PlotlyInitComplete += Chart1_InitComplete;
			}
			await base.OnAfterRenderAsync(firstRender);
		}



		/// <summary>
		/// Chart control notifies page render is complete.
		/// </summary>
		/// <param name="obj"></param>
		private async void Chart1_InitComplete(PlotlyChart obj)
		{
			DisabledButtons = false;
            StateHasChanged();
            await CallElementMethod("focus", firstButton);
            await CallElementMethod("click", firstButton);
        }




        /// <summary>
        /// Choropleth chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/aggregations/
        /// </summary>
        public async void ChoroplethChart()
		{
			
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/bcdunbar/datasets/master/worldhappiness.csv");

				if (fileText != null)
				{
					List<WorldHappiness> happinessRanked = new List<WorldHappiness>();

					string[] rows = fileText.Split("\n".ToCharArray());
					int iCount = 0;
					string[] values;


					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							// skip the header
							continue;
						}


						iCount = i;
						values = rows[i].Replace("\r", "").Replace("\"Hong Kong S.A.R., China\",", "Hong Kong,Eastern Asia").Split(",");

						WorldHappiness score = new WorldHappiness()
						{
							Year = values[0],
							Country = values[1],
							Region = values[2],
							HappinessRank = Convert.ToInt32(values[3]),
							HappinessScore = Convert.ToDouble(values[4]),
							StandardError = values[5],
							Economy_GDP_per_Capita = Convert.ToDouble(values[6]),
							Family = Convert.ToDouble(values[7]),
							Health_Life_Expectancy = Convert.ToDouble(values[8]),
							Freedom = Convert.ToDouble(values[9]),
							Trust_Government_Corruption = Convert.ToDouble(values[10]),
							Generosity = Convert.ToDouble(values[11]),
							Dystopia_Residual = Convert.ToDouble(values[12])

						};

						happinessRanked.Add(score);
					}


					ChoroplethTrace trace = new ChoroplethTrace()
					{
						LocationMode = LocationModeOptions.CountryNames,
						Locations = happinessRanked.Select(item => item.Country).ToArray(),
						Z = happinessRanked.Select(item => item.HappinessScore).ToArray(),
						AutoColorScale = false,
						ReverseScale = true,
						ColorScale = ColorScaleOptions.Portland.GetDescription(),
						Transforms = new ItemList<Transform>() {
							new AggregateTransform()
							{
								Groups = happinessRanked.Select(item => item.Country).ToArray(),

								Aggregations = new ItemList<AggregationItem>(
									new Transforms.AggregationItem()
									{
										Target = "z",
										Func =  FuncOptions.Avg,
										Enabled= true
									}								
								)
							}
						}
					
					};

					TraceList dataTraces = new TraceList(trace);

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "<b>World Happiness</b><br>2015 - 2017" },
						Geo = new GeoInfo()
						{
							ShowFrame = false,
							ShowCoastLines = false,
							Projection = new ProjectionGeoInfo { Type = GeoProjectionTypeOptions.Orthographic }
						},
						UpdateMenus = new ItemList<UpdateMenuItem>() {
							new UpdateMenuItem()
							{
								X= 0.85,
								Y=1.15,
								
								//XRef = RefOptions.Paper,//not in schema
								//YRef = RefOptions.Paper, //not in schema
								YAnchor = AutoTopMiddleBottomOptions.Top,
								Active = 0,
								ShowActive=true,
								Buttons = new ItemList<ButtonItem>()
								{
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "avg"},
										Label = "Avg"
									},
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "sum"},
										Label = "Sum"
									},
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "min"},
										Label = "Min"
									},
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "max"},
										Label = "Max"
									},
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "mode"},
										Label = "Mode"
									},
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "median"},
										Label = "Median"
									},
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "first"},
										Label = "First"
									},
									new ButtonItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "last"},
										Label = "Last"
									}
								}
							}
						},
						Width = plotWidth,
						Height = plotHeight,
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>MapLibre choropleth sample replacing the former Mapbox trace.</summary>
        public async void ChoroplethMapChart()
        {
            ChoroplethMapTrace trace = new ChoroplethMapTrace()
            {
                GeoJson = "https://raw.githubusercontent.com/plotly/datasets/master/geojson-counties-fips.json",
                FeatureIdKey = "id",
                Locations = new string[] { "06037", "36061", "17031", "48201", "04013" },
                Z = new double[] { 92, 85, 78, 70, 64 },
                ColorScale = "Viridis",
                ShowScale = true,
                Name = "Sample value",
                HoverTemplate = "FIPS %{location}<br>Value %{z}<extra></extra>"
            };

            await Chart1.newPlot(new TraceList(trace), new Layout()
            {
                Title = new TitleLayoutInfo() { Text = "Choropleth Map" },
                Map = new MapInfo() { Style = "white-bg", Center = new GeoCenterInfo() { Lat = 38, Lon = -96 }, Zoom = 3 },
                Height = plotHeight,
                Width = plotWidth
            }, commonConfig);
        }

        /// <summary>MapLibre density sample replacing the former Mapbox trace.</summary>
        public async void DensityMapChart()
        {
            DensityMapTrace trace = new DensityMapTrace()
            {
                Lon = new double[] { -122.42, -118.24, -112.07, -104.99, -96.80, -87.63, -74.00, -71.06 },
                Lat = new double[] { 37.77, 34.05, 33.45, 39.74, 32.78, 41.88, 40.71, 42.36 },
                Z = new double[] { 18, 28, 12, 20, 16, 24, 36, 30 },
                Radius = 30,
                ColorScale = "YlOrRd",
                ShowScale = true,
                Name = "City intensity"
            };

            await Chart1.newPlot(new TraceList(trace), new Layout()
            {
                Title = new TitleLayoutInfo() { Text = "Density Map" },
                Map = new MapInfo() { Style = "white-bg", Center = new GeoCenterInfo() { Lat = 39, Lon = -98 }, Zoom = 3 },
                Height = plotHeight,
                Width = plotWidth
            }, commonConfig);
        }

        /// <summary>MapLibre scatter sample replacing the former Mapbox trace.</summary>
        public async void ScatterMapChart()
        {
            ScatterMapTrace trace = new ScatterMapTrace()
            {
                Lon = new double[] { -122.42, -118.24, -112.07, -104.99, -96.80, -87.63, -74.00, -71.06 },
                Lat = new double[] { 37.77, 34.05, 33.45, 39.74, 32.78, 41.88, 40.71, 42.36 },
                Mode = "markers+text",
                Text = new string[] { "San Francisco", "Los Angeles", "Phoenix", "Denver", "Houston", "Chicago", "New York", "Boston" },
                Marker = new { size = 14, color = "#1f77b4" },
                Name = "Cities",
                HoverTemplate = "%{text}<extra></extra>"
            };

            await Chart1.newPlot(new TraceList(trace), new Layout()
            {
                Title = new TitleLayoutInfo() { Text = "Scatter Map" },
                Map = new MapInfo() { Style = "white-bg", Center = new GeoCenterInfo() { Lat = 39, Lon = -98 }, Zoom = 3 },
                Height = plotHeight,
                Width = plotWidth
            }, commonConfig);
        }

        /// <summary>
        /// LineGeo chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/lines-on-maps/
        /// </summary>
        public async void LineGeoChart()
		{
			
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/c34aaa0b1b3cddad335173cb7bc0181897201ee6/2011_february_aa_flight_paths.csv");

				if (fileText != null)
				{
					List<FlightPath> flightPaths = new List<FlightPath>();

					string[] rows = fileText.Split("\n".ToCharArray());
					int maxCount = 0;
					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						FlightPath path = new FlightPath()
						{
							StartLat = Convert.ToDouble(values[0]),
							StartLon = Convert.ToDouble(values[1]),
							EndLat = Convert.ToDouble(values[2]),
							EndLon = Convert.ToDouble(values[3]),
							Airline = values[4],
							Airport1 = values[5],
							Airport2 = values[6],
							Count = Convert.ToInt32(values[7])

						};
						maxCount = maxCount < path.Count ? path.Count : maxCount;
						flightPaths.Add(path);
					}

					TraceList dataTraces = new TraceList();

					foreach (FlightPath path in flightPaths)
					{
						dataTraces.AddTrace(
							new ScatterGeoTrace()
							{
								LocationMode = LocationModeOptions.USAStates,
								Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
								Lon = new object[] { path.StartLon, path.EndLon },
								Lat = new object[] { path.StartLat, path.EndLat },
								Line = new LineInfo() { Width = 1, Color = "red" },
								Opacity = path.Count * 1.0 / maxCount
							}
							);
					}

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "Feb. 2011 American Airline flight paths" },
						ShowLegend = false,
						Geo = new GeoInfo()
						{
							Scope = ScopeOptions.NorthAmerica,
							Projection = new ProjectionGeoInfo()
							{
								
								Type = GeoProjectionTypeOptions.AzimuthalEqualArea

							},
							ShowLand = true,
							LakeColor = "rgb(243,243,243)",
							CountryColor = "rgb(204,204,204)"
						},
						Height = plotHeight,
						Width = plotWidth
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// ScatterGeo chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/filled-area-on-mapbox/
        /// </summary>
        public async void ScatterGeoChart()
		{
			
			ScatterGeoTrace geo = new ScatterGeoTrace()
			{
				Locations = new string[] { "FRA", "DEU", "RUS", "ESP" },
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Markers },
				
				Marker = new MarkerScatterGeoInfo()
				{
					Size = new double[] { 20, 30, 15, 10 },
					Color = new object[] { 10, 20, 40, 50 },
					CMin = 0,
					CMax = 50,
					ColorScale = "Greens",
					ColorBar = new ColorBarInfo() { Title = new TitleFontSideInfo() { Text = "Some Rate" }, TickSuffix = "%", ShowTickSuffix = ShowTickOptions.Last },
					Line = new LineMarkerInfo() { Color = "black" }
				},
				Name = "Europe Data"
			};

			TraceList dataTraces = new TraceList(geo);
			Layout layout = new Layout()
			{
				Geo = new GeoInfo() { Scope = ScopeOptions.Europe, Resolution = ResolutionOptions._50 },
				Height = plotHeight,
				Width = plotWidth
			};
			
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}







	
	}
}


