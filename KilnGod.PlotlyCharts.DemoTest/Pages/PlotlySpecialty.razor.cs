//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlySpecialty.razor.cs
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
    public partial class PlotlySpecialty
    {

#nullable disable
		public PlotlyChart Chart1 { get; set; }

#nullable enable

		[Inject]
		public IWebfileRepository? Webfile { get; set; }

		public bool DisabledButtons { get; set; } = true;

		static int plotWidth = 800;
		static int plotHeight = 800;


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
		private void Chart1_InitComplete(PlotlyChart obj)
		{
			DisabledButtons = false;
			StateHasChanged();
		}



        /// <summary>
        /// BarPolar chart sample from plotly website in C#.
        ///
		/// https://plotly.com/javascript/polar-chart/
		/// https://plotly.com/python/polar-chart/
        /// https://metacpan.org/pod/Chart::Plotly::Trace::Barpolar
        /// </summary>
        public async void BarPolarChart()
		{
			TraceList dataTraces = new TraceList(
				new Trace[] {
				new BarPolarTrace()
				{
					R = new double[] { 77.5, 72.5, 70.0, 45.0, 22.5, 42.5, 40.0, 62.5 },
					Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
					Name = "11-14 m/s",
					Marker = new MarkerBarPolarInfo() { Color = "rgb(106,81,163)" }
				},
				new BarPolarTrace()
				{
					R = new double[] { 57.5, 50.0, 45.0, 35.0, 20.0, 22.5, 37.5, 55.0 },
					Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
					Name = "8-11 m/s",
					Marker = new MarkerBarPolarInfo() { Color = "rgb(158,154,200)" }
				},
				new BarPolarTrace()
				{
					R = new double[] { 40.0, 30.0, 30.0, 35.0, 7.5, 7.5, 32.5, 40.0 },
					Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
					Name = "5-8 m/s",
					Marker = new MarkerBarPolarInfo() { Color = "rgb(203,201,226)" }
				},
				new BarPolarTrace()
				{
					R = new double[] { 20.0, 7.5, 15.0, 22.5, 2.5, 2.5, 12.5, 22.5 },
					Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
					Name = "< 5 m/s",
					Marker = new MarkerBarPolarInfo() { Color = "rgb(242,240,247)" }
				}
				}
			);


			BarPolarLayout layout = new BarPolarLayout()
			{
				Title = new TitleLayoutInfo() { Text = "Wind Speed Distribution in Laurel, NE" },
				Font = new FontInfo() { Size = 16 },
				Legend = new LegendInfo() { Font = new FontInfo() { Size = 16 } },
				BarMode = BarPolarBarModeOptions.Overlay,
				BarGap = 0,
				Polar = new PolarInfo()
				{
					RadialAxis = new RadialAxisInfo() { TickSuffix = "%", Angle = 45, DTick = 20 },
					AngularAxis = new AngularAxisInfo() { Direction = DirectionOptions.Clockwise }
				},
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}


        /// <summary>
        /// ScatterTernary chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/ternary-contour/
        /// </summary>
        public async void ScatterTernaryChart()
		{
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://gist.githubusercontent.com/davenquinn/988167471993bc2ece29/raw/f38d9cb3dd86e315e237fde5d65e185c39c931c2/data.json");


				if (fileText != null)
				{
					List<Soil> soilList = new List<Soil>();

					JsonDocument doc = JsonDocument.Parse(fileText);

					foreach (JsonProperty prop in doc.RootElement.EnumerateObject())
					{
						Soil soil = new Soil()
						{
							Name = prop.Name

						};
						List<Mix> mixes = new List<Mix>();
						if (prop.Value.ValueKind == JsonValueKind.Array)
                        {
							foreach (JsonElement item in prop.Value.EnumerateArray())
							{
								Mix mix = new Mix();

								JsonElement clay;
								JsonElement sand;
								JsonElement silt;

								if (item.TryGetProperty("clay", out clay))
								{
									mix.Clay =Convert.ToInt32( clay.ToString());
								};
								if (item.TryGetProperty("sand", out sand))
								{
									mix.Sand = Convert.ToInt32(sand.ToString());
								};
								if (item.TryGetProperty("silt", out silt))
								{
									mix.Silt = Convert.ToInt32(silt.ToString());
								};
								mixes.Add(mix);
							}													
						}
						soil.Mixes = mixes.ToArray();
						soilList.Add(soil);
					}

					object[] colors = new object[] { "#8dd3c7", "#ffffb3", "#bebada", "#fb8072", "#80b1d3", "#fdb462", "#b3de69", "#fccde5", "#d9d9d9", "#bc80bd", "#ccebc5", "#ffed6f" };




					TraceList dataTraces = new TraceList();
					for(int i=0; i< soilList.Count; i++)
                    {
						Soil soil = soilList[i];
						ScatterTernaryTrace trace = new ScatterTernaryTrace
						{
							Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
							Name = soil.Name,
							A = soil.Mixes.Select(item => item.Clay).ToArray(),
							B = soil.Mixes.Select(item => item.Sand).ToArray(),
							C = soil.Mixes.Select(item => item.Silt).ToArray(),
							Line = new LineColorDashShapeSmoothingWidthInfo() { Color = "#444" },
							Fill = FillSubsetOptions.ToSelf,
							FillColor = colors[i]
						};
						dataTraces.AddTrace(trace);

					}

					ItemList<AnnotationItem> annotations = new ItemList<AnnotationItem>(
						new AnnotationItem()
						{
							ShowArrow = false,
							Text = "Soil Types Fill Plot",
							X = 0.15, Y = 1.1
						});

					Layout layout = new Layout()
					{
						Ternary = new TernaryInfo()
						{
							Sum = 100,
							AAxis = new TernaryAxisInfo
							{
								Title = new TitleTernaryAxisInfo() { Text = "Clay" },
								TickSuffix = "%",
								Min = 0.01,
								LineWidth = 2,
								Ticks = TicksOptions.Outside,
								TickLen = 8,
								ShowGrid = true
							},
							BAxis = new TernaryAxisInfo
							{
								Title = new TitleTernaryAxisInfo() { Text = "Sand" },
								TickSuffix = "%",
								Min = 0.01,
								LineWidth = 2,
								Ticks = TicksOptions.Outside,
								TickLen = 8,
								ShowGrid = true
							},
							CAxis = new TernaryAxisInfo
							{
								Title = new TitleTernaryAxisInfo() { Text = "Silt" },
								TickSuffix = "%",
								Min = 0.01,
								LineWidth = 2,
								Ticks = TicksOptions.Outside,
								TickLen = 8,
								ShowGrid = true
							}
						},
						ShowLegend = false,
						Height = plotHeight,
						Width = plotWidth,
						Annotations = annotations

					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);

				}
			}
		}

        /// <summary>
        /// Sunburst chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/sunburst-charts/
        /// </summary>
        public async void SunburstChart()
		{
			
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/coffee-flavors.csv");


				if (fileText != null)
				{
					List<CoffeeData> coffeeList = new List<CoffeeData>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						CoffeeData coffee = new CoffeeData()
						{
							Ids = values[0],
							Labels = values[1],
							Parents = values[2]
						};
						coffeeList.Add(coffee);
					}

					SunburstTrace trace = new SunburstTrace()
					{
						IDs = coffeeList.Select(coffee => coffee.Ids).ToArray(),
						Labels = coffeeList.Select(coffee => coffee.Labels).ToArray(),
						Parents = coffeeList.Select(coffee => coffee.Parents).ToArray(),
						MaxDepth =2,
						
						InsideTextOrientation = InsideTextOrientationOptions.Radial
					};

					TraceList dataTraces = new TraceList(trace);

					SunburstLayout layout = new SunburstLayout()
					{
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

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// Icicle chart sample from plotly website in C#.
		///
		/// https://plotly.com/python/icicle-charts/
        /// </summary>
        public async void IcicleChart()
        {
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/96c0bd/sunburst-coffee-flavors-complete.csv");


				if (fileText != null)
				{
					List<CoffeeData> coffeeList = new List<CoffeeData>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						CoffeeData coffee = new CoffeeData()
						{
							Ids = values[0],
							Labels = values[1],
							Parents = values[2]
						};
						coffeeList.Add(coffee);
					}

					IcicleTrace trace = new IcicleTrace()
					{ 
						IDs = coffeeList.Select(coffee => coffee.Ids).ToArray(),
						Labels = coffeeList.Select(coffee => coffee.Labels).ToArray(),
						Parents = coffeeList.Select(coffee => coffee.Parents).ToArray(),
						Tiling = new IcicleTilingInfo() { Orientation = OrientationOptions.Horizontal}
					};

					TraceList dataTraces = new TraceList(trace);

					IcicleLayout layout = new IcicleLayout()
					{
						Margin = new MarginInfo()
						{
							L = 25,
							R = 25,
							B = 25,
							T = 50

						},
						Height = plotHeight,
						Width = plotWidth
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// PointCloud chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/pointcloud/
        /// </summary>
        public async void PointCloudChart()
		{
			
			TraceList dataTraces = new TraceList(
				new Trace[] {
					new PointCloudTrace()
					{

						X = new double[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
						Y = new double[]{9, 8, 7, 6, 5, 4, 3, 2, 1, 0 },
						
				//		Mode = new ModeOptions[] { ModeOptions.Markers },
						Marker = new MarkerPointCloudInfo()
						{
							Border = new BorderInfo(){AreaRatio=0 },
							SizeMin=0.5,
							SizeMax=100,
							Color = "rgba(255, 0, 0, 0.6)"
							//,	Size = 1

						},
						Opacity = 0.7
					},
					new PointCloudTrace()
					{
						
						X = new double[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
						Y = new double[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
						//Mode = ModeOptions.Markers,
						Marker = new MarkerPointCloudInfo()
						{
					//		AreaRatio=0,
							Blend = true,
							SizeMin=0.5,
							SizeMax=100,
							Color = "rgba(0, 0, 255, 0.9)",
							Opacity = 0.8
							//,	Size = 1
						},
						Opacity = 0.7
					},
					new PointCloudTrace()
					{
						X = new double[]{3, 4.5, 6},
						Y = new double[]{9, 9, 9},
					//	Mode = ModeOptions.Markers,
						Marker = new MarkerPointCloudInfo()
						{							
							Blend = true,
							Border = new BorderInfo()
                            {
								Color = "rgb(0, 0, 0)",
								AreaRatio = 0.7071
							},
							Color = "green",
							Opacity = 0.8,
							SizeMin=0.5,
							SizeMax=100//,
							//Size = 1
							
						},
						Opacity = 0.7
					}
				}
				);

			Layout layout = new Layout()
			{
				AutoSize = true,
				ShowLegend = false,
				Title = new TitleLayoutInfo() { Text = "Basic Point Cloud" },
				Height = plotHeight,
				Width = plotWidth,
				XAxis = new LayoutAxisInfo()
				{
					Type = AxisTypeOptions.Linear,
					Range = new object[] { -1,10 },
					AutoRange = AutoRangeOptions.True
				},
				YAxis = new LayoutYAxisInfo()
				{
					Type = AxisTypeOptions.Linear,
					Range = new object[] { -1,10 },
					AutoRange = AutoRangeOptions.True
				}
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// Sankey chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/sankey-diagram/
        /// </summary>
        public async void SankeyChart()
        {
			
			TraceList dataTraces = new TraceList(
				new Trace[] { new SankeyTrace()
				{

					Arrangement = SankeyArrangementOptions.Snap,
					Node = new NodeInfo()
                    {
						Label = new string[]{"A", "B", "C", "D", "E", "F"},
						X = new double[]{0.2, 0.1, 0.5, 0.7, 0.3, 0.5},
						Y= new double[]{0.7, 0.5, 0.2, 0.4, 0.2, 0.3},
						Pad=10
                    },
					Link = new LinkInfo()
					{
						Source = new int[]{0, 0, 1, 2, 5, 4, 3, 5 },
						Target = new int[]{ 5, 3, 4, 3, 0, 2, 2, 3},
						Value = new int[]{ 1, 2, 1, 1, 1, 1, 1, 2 }
					}
				}
				});

			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Sankey with manually positioned node" },
				Height = plotHeight,
				Width = plotWidth
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}



        /// <summary>
        /// ScatterPolar chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/radar-chart/
        /// </summary>
        public async void ScatterPolarChart()
        {
			TraceList dataTraces = new TraceList(
				new Trace[] {
					 new ScatterPolarTrace()
				{
					R = new double[] { 39, 28, 8, 7, 28, 39},
					Theta = new string[] { "A","B","C", "D", "E", "A" },
					Name = "Group A",
					Fill = FillPolarOptions.ToSelf
				},
				new ScatterPolarTrace()
				{
					R = new double[] {1.5, 10, 39, 31, 15, 1.5},
					Theta = new string[] {"A","B","C", "D", "E", "A" },
					Name = "Group B",
					Fill = FillPolarOptions.ToSelf
				}				
				});
			Layout layout = new Layout()
			{
				Polar = new PolarInfo()
				{
					RadialAxis = new RadialAxisInfo()
					{
						Visible = true,
						Range = new object[] { 0, 50 }
					}
				},
				Height = plotHeight,
				Width = plotWidth
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// Table chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/table/
        /// </summary>
        public async void TableChart()
		{
			
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/Mining-BTC-180.csv");


				if (fileText != null)
				{
					List<BitcoinMiningData> miningInfo = new List<BitcoinMiningData>();

					string[] rows = fileText.Split("\n".ToCharArray());
					List<string> header = rows[0].Split(",").ToList();
					header.RemoveAt(0);

					for (int i = 1; i < rows.Length; i++)
					{
						
						string[] values = rows[i].Split(",");

						BitcoinMiningData item = new BitcoinMiningData()
						{
							Row = values[0],
							Date = values[1].Split(" ".ToCharArray())[0],
							Number_transactions = values[2],
							Output_volume_BTC = values[3],
							Market_price = values[4],
							Hash_rate = values[5],
							Cost_per_trans_USD = values[6],
							Mining_revenue_USD = values[7],
							Transaction_fees_BTC = values[8]
						};
						miningInfo.Add(item);
					}

					List<object> cellValues = new List<object>();
					cellValues.Add(miningInfo.Select(item => item.Date).ToArray());
					cellValues.Add(miningInfo.Select(item => item.Number_transactions).ToArray());
					cellValues.Add(miningInfo.Select(item => item.Output_volume_BTC).ToArray());
					cellValues.Add(miningInfo.Select(item => item.Market_price).ToArray());
					cellValues.Add(miningInfo.Select(item => item.Hash_rate).ToArray());
					cellValues.Add(miningInfo.Select(item => item.Cost_per_trans_USD).ToArray());
					cellValues.Add(miningInfo.Select(item => item.Mining_revenue_USD).ToArray());
					cellValues.Add(miningInfo.Select(item => item.Transaction_fees_BTC).ToArray());

					TableTrace trace = new TableTrace()
					{
						Header = new HeaderInfo()
						{
							Values = header,
							Align = XAlignOptions.Center,
							Line = new LineColorWidthsInfo() { Width = 1, Color = "rgb(50, 50, 50)" },
							Fill = new FillColorInfo() { Color = new object[] { "rgb(235, 100, 230)" } },
							Font = new FontLabelInfo() { Family = "Arial", Size = 8, Color = "white" }
						},
						Cells = new CellsInfo()
						{
							Values = cellValues,
							Align =  XAlignOptions.Center,
							Line = new LineColorWidthsInfo() { Color = "black", Width = 1 },
							Fill = new FillColorInfo()
							{
								Color = new object[] { "rgba(228, 222, 249, 0.65)", "rgb(235, 193, 238)", "rgba(228, 222, 249, 0.65)" }
							},
							Font = new FontLabelInfo() { Family = "Arial", Size = 9, Color = new object[] { "black" } }
							

						}
					};


					TraceList dataTraces = new TraceList(trace);
					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "Bitcoin mining stats for 180 days" },
						Height = plotHeight,
						Width = plotWidth
					};
					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// Treemap chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/treemaps/
        /// </summary>
        public async void TreeMapChart()
		{
			
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/coffee-flavors.csv");


				if (fileText != null)
				{
					List<CoffeeData> coffeeList = new List<CoffeeData>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						CoffeeData coffee = new CoffeeData()
						{
							Ids = values[0],
							Labels = values[1],
							Parents = values[2]
						};
						coffeeList.Add(coffee);
					}

					TreemapTrace trace = new TreemapTrace()
					{
						IDs = coffeeList.Select(coffee => coffee.Ids).ToArray(),
						Labels = coffeeList.Select(coffee => coffee.Labels).ToArray(),
						Parents = coffeeList.Select(coffee => coffee.Parents).ToArray()
					};

					TraceList dataTraces = new TraceList(trace);

					await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
				}
			}
		}





	
	}
}


