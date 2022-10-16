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
						Mapbox = new MapboxInfo() { Style = StyleOptions.StamenTerrain }
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// CloroplethMap chart sample from plotly website in C#.
		///
		/// https://plotly.com/python/mapbox-county-choropleth/
        /// </summary>
        public async void ChoroplethMapboxChart()
		{
			
			if (Webfile != null)
			{
		

				string? unemploymentdata = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/fips-unemp-16.csv");

				if (unemploymentdata != null)
				{
				

					List<UnemploymentData> unemploymentFipsArea = new List<UnemploymentData>();

					string[] rows = unemploymentdata.Split("\n".ToCharArray());
					
					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						UnemploymentData fipsArea = new UnemploymentData()
						{
							Fips = values[0],
							Unemp = Convert.ToDouble(values[1])				

						};

						unemploymentFipsArea.Add(fipsArea);

					}


					ChoroplethMapboxTrace trace = new ChoroplethMapboxTrace()
					{
						Z = unemploymentFipsArea.Select(item => item.Unemp).ToArray(),
						ZMax=12,
						ZMin=0,
						Locations  = unemploymentFipsArea.Select(item => item.Fips).ToArray(),
						GeoJson = "https://raw.githubusercontent.com/plotly/datasets/master/geojson-counties-fips.json",
						
					};

					Layout layout = new Layout()
					{
						
						Width = plotWidth,
						Height = plotHeight,
						Title = new TitleLayoutInfo() { Text = "2016 US Unemployment by County" },
						Mapbox = new MapboxInfo() { Style = StyleOptions.CartoPositron, Zoom = 3.2, Center = new GeoCenterInfo() { Lat = 37.0902, Lon = -95.7129 } },
						ColorAxis = new ColorAxisInfo() { ShowScale=false, ColorScale = ColorScaleOptions.Viridis.GetDescription()},
						
					};

					TraceList dataTraces = new TraceList(trace);
					await Chart1.newPlot(dataTraces, layout, commonConfig);

				}

			}
		}


        /// <summary>
        /// DensityMapbox chart sample from plotly website in C#.
        ///
		/// https://plotly.com/javascript/mapbox-density-heatmaps/
        /// </summary>
        public async void DensityMapboxChart()
		{
			
			DensityMapboxTrace trace = new DensityMapboxTrace()
			{
				Lon = new double[] { 10, 20, 30 },
				Lat = new double[] { 15, 25, 35 },
				Z = new double[] { 1, 3, 2 },
			};
			TraceList dataTraces = new TraceList(trace);

			Layout layout = new Layout()
			{
				Width = plotWidth,
				Height = plotHeight,
				Mapbox = new MapboxInfo() { Style = StyleOptions.StamenTerrain }
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
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



        /// <summary>
        /// ScatterMapbox chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/scattermapbox/
        /// </summary>
        public async void ScatterMapboxChart()
		{
		   
			ScatterMapboxTrace trace = new ScatterMapboxTrace()
			{
				Fill = FillMapboxOptions.ToSelf,
				Lon = new double[] { -74, -70, -70, -74 },
				Lat = new double[] { 47, 47, 45, 45 },
				Marker = new MarkerMapboxInfo() { Size = 10, Color = "orange" }
			};
			TraceList dataTraces = new TraceList(trace);

			Layout layout = new Layout()
			{
				Width = plotWidth,
				Height = plotHeight,
				ShowLegend = false,
				Mapbox = new MapboxInfo() { Style = StyleOptions.StamenTerrain, Center = new GeoCenterInfo() { Lat = 46, Lon = -73 }, Zoom = 5 }

			};

			await Chart1.newPlot(dataTraces, layout);
		}




	
	}
}


