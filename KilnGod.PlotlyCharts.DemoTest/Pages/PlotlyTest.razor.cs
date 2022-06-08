//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyTest.razor.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using Microsoft.AspNetCore.Components;
using System.Dynamic;
using System.Text.Json;
using KilnGod.PlotlyCharts.Configuration;
using KilnGod.PlotlyCharts.Layout;
using KilnGod.PlotlyCharts.Data;
using KilnGod.PlotlyCharts.Traces;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.DemoTest.Models;
using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Enumerations;


namespace KilnGod.PlotlyCharts.DemoTest.Pages
{
    public partial class PlotlyTest
	{

#nullable disable
		public PlotlyChart Chart1 { get; set; }

#nullable enable
		[Inject]
		public IWebfileRepository? Webfile { get; set; }

		public bool DisabledButtons { get; set; } = true;

		static int plotWidth = 800;
		static int plotHeight = 800;

		LayoutInfo commonLayout = new LayoutInfo() {
			Margin = new MarginInfo()
			{
				Left = 0,
				Right = 0,
				Bottom = 0,
				Top = 0
			},
			Height = plotHeight,
			Width = plotWidth
		};
		ConfigInfo commonConfig = new ConfigInfo() { Responsive = true, Editable = false, DisplayLogo = false };

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				Chart1.PlotlyInitComplete += Chart1_InitComplete;
			}
			await base.OnAfterRenderAsync(firstRender);
		}

		private void Chart1_InitComplete(PlotlyChart obj)
		{
			DisabledButtons = false;
			StateHasChanged();
		}


		public async void ScatterChart()
		{
			//https://plotly.com/javascript/line-and-scatter/

			ScatterTrace trace = new ScatterTrace();

			trace.X = new int[] { 1, 2, 3, 4 };
			trace.Y = new int[] { 2, -1, 1, 3 };

			TraceList dataTraces = new TraceList(trace);

			LayoutInfo layout = new LayoutInfo
			{
				Title = new TitleInfo() { Text = "Scatter Chart" },
				XAxis = new AxisInfo() { Title = new TitleInfo() { Text = "X Axis" } },
				YAxis = new AxisInfo() { Title = new TitleInfo() { Text = "Y Axis" } },
				Height = plotHeight,
				Width = plotWidth
			};
			

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void LogScatterChart()
		{

			ScatterTrace trace1 = new ScatterTrace()
			{
				X = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
				Y = new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 }
			};

			ScatterTrace trace2 = new ScatterTrace()
			{
				X = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
				Y = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }
			};



			TraceList dataTraces = new TraceList(new ScatterTrace[] { trace1, trace2 });



			LayoutInfo layout = new LayoutInfo
			{
				Title = new TitleInfo() { Text = "Scatter Chart" },
				XAxis = new AxisInfo() { Title = new TitleInfo() { Text = "X Axis" }, AutoRange = AutoRangeOptions.True, AxisType = AxisTypeOptions.Log },
				YAxis = new AxisInfo() { Title = new TitleInfo() { Text = "Y Axis" }, AutoRange = AutoRangeOptions.True, AxisType = AxisTypeOptions.Log },
				Height = plotHeight,
				Width = plotWidth,
				ShowLegend = false
			};
			

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}


		public async void BarChart()
		{
			//https://plotly.com/javascript/bar-charts/

			BarTrace trace1 = new BarTrace();

			trace1.X = new string[] { "giraffes", "orangutans", "monkeys" };
			trace1.Y = new int[] { 20, 14, 23 };
			trace1.Name = "San Francisco Zoo";
			TraceList dataTraces = new TraceList(trace1);

			BarTrace trace2 = new BarTrace()
			{
				X = new string[] { "giraffes", "orangutans", "monkeys" },
				Y = new int[] { 5, 18, 42 },
				Name = "Los Angeles Zoo"
			};

			dataTraces.AddTrace(trace2);

			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Bar Chart" },
				XAxis = new AxisInfo() { Title = new TitleInfo() { Text = "Beast(s)" }, TickAngle = -45 },
				YAxis = new AxisInfo() { Title = new TitleInfo { Text = "Inventory" } },
				Height = plotHeight,
				Width = plotWidth
			};
		

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}


		public async void PieChart()
		{
			//https://plotly.com/javascript/pie-charts/

			PieTrace trace = new PieTrace();

			trace.Values = new int[] { 2, 3, 4, 4 };
			trace.Labels = new string[] { "Wages", "Operating expenses", "Cost of sales", "Insurance" };
			trace.TextInfo = TextInfoOptions.Text;
			trace.TextPosition = TextPositionOptions.Outside;
			trace.AutoMargin = true;


			TraceList dataTraces = new TraceList(trace);



			LayoutInfo layout = new LayoutInfo() { Title = new TitleInfo() { Text = "Pie Chart" }, ShowLegend = false, Height = plotHeight, Width = plotWidth };
			

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}

		public async void BubbleChart()
		{

			ScatterTrace trace = new ScatterTrace();

			trace.X = new int[] { 1, 2, 3, 4 };
			trace.Y = new int[] { 10, 11, 12, 13 };
			trace.Mode = ModeOptions.Number;
			trace.Marker = new MarkerInfo()
			{
				Size = new int[] { 400, 600, 800, 100 },
				SizeMode = SizeModeOptions.Absolute,
				Color = new string[] { "rgb(93,164,214)", "rgb(255,144,14)", "rgb(44,160101)", "rgb(255,65,54)" },
				Opacity = new float[] { 1, 0.8f, 0.6f, 0.4f }

			};
			trace.Text = new string[] { "A<br>size: 40", "B<br>size: 60", "C<br>size: 80", "D<br>size: 100" };

			TraceList dataTraces = new TraceList(trace);


			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Bubble Chart" },
				XAxis = new AxisInfo() { Title = new TitleInfo { Text = "X Axis" } },
				Height = plotHeight,
				Width = plotWidth
			};
			
			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}


		public async void TimeSeriesChart()
		{

			ScatterTrace trace = new ScatterTrace();

			trace.X = new string[] { "2017-01-04", "2017-01-05", "2017-01-06", "2017-01-09", "2017-01-10", "2017-01-11", "2017-01-12", "2017-01-13", "2017-01-17", "2017-01-18", "2017-01-19", "2017-01-20", "2017-01-23", "2017-01-24", "2017-01-25", "2017-01-26", "2017-01-27", "2017-01-30", "2017-01-31", "2017-02-01", "2017-02-02", "2017-02-03", "2017-02-06", "2017-02-07", "2017-02-08", "2017-02-09", "2017-02-10", "2017-02-13", "2017-02-14", "2017-02-15" };

			trace.Y = new double[] { 116.019997, 116.610001, 117.910004, 118.989998, 119.110001, 119.75, 119.25, 119.040001, 120, 119.989998, 119.779999, 120, 120.080002, 119.970001, 121.879997, 121.940002, 121.949997, 121.629997, 121.349998, 128.75, 128.529999, 129.080002, 130.289993, 131.529999, 132.039993, 132.419998, 132.119995, 133.289993, 135.020004, 135.509995 };
			trace.Mode = ModeOptions.Number;
			trace.Line = new LineInfo() { Color = "#17BECF" };


			TraceList dataTraces = new TraceList(trace);


			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Time Series Chart" },
				XAxis = new AxisInfo() { Title = new TitleInfo() { Text = "Date" }, Range = new string[] { "2017-01-04", "2017-02-15" }, AxisType = AxisTypeOptions.Date },
				YAxis = new AxisInfo() { Title = new TitleInfo() { Text = "Range" }, AutoRange = Enumerations.LayoutEnums.AutoRangeOptions.True, Range = new double[] { 86.8700008333, 138.870004167 }, AxisType = AxisTypeOptions.Linear },
				Height = plotHeight,
				Width = plotWidth
			};
			

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}

		public async void BarPolarChart()
        {
			TraceList dataTraces = new TraceList(
				new Trace[] {
			new BarPolarTrace()
			{
				R = new double[] { 77.5, 72.5, 70.0, 45.0, 22.5, 42.5, 40.0, 62.5 },
				Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
				Name = "11-14 m/s",
				Marker = new MarkerInfo() { Color = "rgb(106,81,163)" }
			},
			new BarPolarTrace()
			{
				R = new double[] { 57.5, 50.0, 45.0, 35.0, 20.0, 22.5, 37.5, 55.0 },
				Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
				Name = "8-11 m/s",
				Marker = new MarkerInfo() { Color = "rgb(158,154,200)" }
			},
			new BarPolarTrace()
			{
				R = new double[] { 40.0, 30.0, 30.0, 35.0, 7.5, 7.5, 32.5, 40.0 },
				Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
				Name = "5-8 m/s",
				Marker = new MarkerInfo() { Color = "rgb(203,201,226)" }
			},
			new BarPolarTrace()
			{
				R = new double[] { 20.0, 7.5, 15.0, 22.5, 2.5, 2.5, 12.5, 22.5 },
				Theta = new string[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" },
				Name = "< 5 m/s",
				Marker = new MarkerInfo() { Color = "rgb(242,240,247)" }
			}
				}
			);


			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text= "Wind Speed Distribution in Laurel, NE" },
				Font = new FontInfo() { Size=16},
				Legend = new LegendInfo() { Font = new FontInfo() { Size=16} },
				Polar = new PolarInfo()
				{
					BarMode = BarModeOptions.Overlay,
					BarGap = 0,
					RadialAxis = new RadialAxisInfo() { TickSuffix = "%", Angle = 45, DTick = 20 },
					AngularAxis = new AngularAxisInfo() { Direction= Enumerations.LayoutEnums.DirectionOptions.Clockwise}
				},
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

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
						ScatterTernyTrace trace = new ScatterTernyTrace
						{
							Mode = ModeOptions.Lines,
							Name = soil.Name,
							A = soil.Mixes.Select(item => item.Clay).ToArray(),
							B = soil.Mixes.Select(item => item.Sand).ToArray(),
							C = soil.Mixes.Select(item => item.Silt).ToArray(),
							Line = new LineInfo() { Color = "#444" },
							Fill = FillOptions.ToSelf,
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

					LayoutInfo layout = new LayoutInfo()
					{
						Ternary = new TernaryInfo()
						{
							Sum = 100,
							AAxis = new TernaryAxisInfo
							{
								Title = new TitleInfo() { Text = "Clay" },
								TickSuffix = "%",
								Min = 0.01,
								LineWidth = 2,
								Ticks = TicksOptions.Outside,
								TickLen = 8,
								ShowGrid = true
							},
							BAxis = new TernaryAxisInfo
							{
								Title = new TitleInfo() { Text = "Sand" },
								TickSuffix = "%",
								Min = 0.01,
								LineWidth = 2,
								Ticks = TicksOptions.Outside,
								TickLen = 8,
								ShowGrid = true
							},
							CAxis = new TernaryAxisInfo
							{
								Title = new TitleInfo() { Text = "Silt" },
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
		

		public async void SunburstChart()
		{
			//https://plotly.com/javascript/sunburst-charts/

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
						Ids = coffeeList.Select(coffee => coffee.Ids).ToArray(),
						Labels = coffeeList.Select(coffee => coffee.Labels).ToArray(),
						Parents = coffeeList.Select(coffee => coffee.Parents).ToArray(),
						MaxDepth =2,
						TextPosition= TextPositionOptions.Inside,
						InsideTextOrientation = InsideTextOrientationOptions.Radial
					};

					TraceList dataTraces = new TraceList(trace);

					LayoutInfo layout = new LayoutInfo()
					{
						Margin = new MarginInfo()
						{
							Left = 0,
							Right = 0,
							Bottom = 0,
							Top = 0

						},
						Height = plotHeight,
						Width = plotWidth
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

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
						Ids = coffeeList.Select(coffee => coffee.Ids).ToArray(),
						Labels = coffeeList.Select(coffee => coffee.Labels).ToArray(),
						Parents = coffeeList.Select(coffee => coffee.Parents).ToArray(),
						Tiling = new TilingInfo() { Orientation = OrientationOptions.Horizontal}
					};

					TraceList dataTraces = new TraceList(trace);

					LayoutInfo layout = new LayoutInfo()
					{
						Margin = new MarginInfo()
						{
							Left = 25,
							Right = 25,
							Bottom = 25,
							Top = 50

						},
						Height = plotHeight,
						Width = plotWidth
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void PointCloudChart()
		{
			//https://plotly.com/javascript/pointcloud/

			TraceList dataTraces = new TraceList(
				new Trace[] {
					new PointCloudTrace()
					{

						X = new double[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
						Y = new double[]{9, 8, 7, 6, 5, 4, 3, 2, 1, 0 },
						Mode = ModeOptions.Markers,
						Marker = new MarkerInfo()
						{
							AreaRatio=0,
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
						Mode = ModeOptions.Markers,
						Marker = new MarkerInfo()
						{
							AreaRatio=0,
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
						Mode = ModeOptions.Markers,
						Marker = new MarkerInfo()
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

			LayoutInfo layout = new LayoutInfo()
			{
				AutoSize = true,
				ShowLegend = false,
				Title = new TitleInfo() { Text = "Basic Point Cloud" },
				Height = plotHeight,
				Width = plotWidth,
				XAxis = new AxisInfo()
				{
					AxisType = AxisTypeOptions.Linear,
					Range = new object[] { -1,10 },
					AutoRange = AutoRangeOptions.True
				},
				YAxis = new AxisInfo()
				{
					AxisType = AxisTypeOptions.Linear,
					Range = new object[] { -1,10 },
					AutoRange = AutoRangeOptions.True
				}
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void SankeyChart()
        {
			//https://plotly.com/javascript/sankey-diagram/

			TraceList dataTraces = new TraceList(
				new Trace[] { new SankeyTrace()
				{

					Arrangement = ArrangementOptions.Snap,
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

			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Sankey with manually positioned node" },
				Height = plotHeight,
				Width = plotWidth
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}

		public async void ScatterPolarChart()
        {
			TraceList dataTraces = new TraceList(
				new Trace[] {
					 new ScatterPolarTrace()
				{
					R = new double[] { 39, 28, 8, 7, 28, 39},
					Theta = new string[] { "A","B","C", "D", "E", "A" },
					Name = "Group A",
					Fill = FillOptions.ToSelf
				},
				new ScatterPolarTrace()
				{
					R = new double[] {1.5, 10, 39, 31, 15, 1.5},
					Theta = new string[] {"A","B","C", "D", "E", "A" },
					Name = "Group B",
					Fill = FillOptions.ToSelf
				}				
				});
			LayoutInfo layout = new LayoutInfo()
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

		public async void TableChart()
		{
			//https://plotly.com/javascript/table/

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
							Align = Enumerations.LayoutEnums.AlignOptions.Center,
							Line = new LineInfo() { Width = 1, Color = "rgb(50, 50, 50)" },
							Fill = new FillInfo() { Color = new object[] { "rgb(235, 100, 230)" } },
							Font = new FontInfo() { Family = "Arial", Size = 8, Color = "white" }
						},
						Cells = new CellsInfo()
						{
							Values = cellValues,
							Align = new object[] { "center", "center" },
							Line = new LineInfo() { Color = "black", Width = 1 },
							Fill = new FillInfo()
							{
								Color = new object[] { "rgba(228, 222, 249, 0.65)", "rgb(235, 193, 238)", "rgba(228, 222, 249, 0.65)" }
							},
							Font = new FontInfo() { Family = "Arial", Size = 9, Color = new object[] { "black" } }
							

						}
					};


					TraceList dataTraces = new TraceList(trace);
					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Bitcoin mining stats for 180 days" },
						Height = plotHeight,
						Width = plotWidth
					};
					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void TreeMapChart()
		{
			//https://plotly.com/javascript/treemaps/

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

					TreeMapTrace trace = new TreeMapTrace()
					{
						Ids = coffeeList.Select(coffee => coffee.Ids).ToArray(),
						Labels = coffeeList.Select(coffee => coffee.Labels).ToArray(),
						Parents = coffeeList.Select(coffee => coffee.Parents).ToArray()
					};

					TraceList dataTraces = new TraceList(trace);

					await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
				}
			}
		}


		public async void CandlestickChart()
		{
			//https://plotly.com/javascript/candlestick-charts/

			CandlestickTrace trace = new CandlestickTrace();


			trace.X = new string[] { "2017-01-04", "2017-01-05", "2017-01-06", "2017-01-09", "2017-01-10", "2017-01-11", "2017-01-12", "2017-01-13", "2017-01-17", "2017-01-18", "2017-01-19", "2017-01-20", "2017-01-23", "2017-01-24", "2017-01-25", "2017-01-26", "2017-01-27", "2017-01-30", "2017-01-31", "2017-02-01", "2017-02-02", "2017-02-03", "2017-02-06", "2017-02-07", "2017-02-08", "2017-02-09", "2017-02-10", "2017-02-13", "2017-02-14", "2017-02-15" };

			trace.Close = new double[] { 116.019997, 116.610001, 117.910004, 118.989998, 119.110001, 119.75, 119.25, 119.040001, 120, 119.989998, 119.779999, 120, 120.080002, 119.970001, 121.879997, 121.940002, 121.949997, 121.629997, 121.349998, 128.75, 128.529999, 129.080002, 130.289993, 131.529999, 132.039993, 132.419998, 132.119995, 133.289993, 135.020004, 135.509995 };
			trace.High = new double[] { 116.510002, 116.860001, 118.160004, 119.43, 119.379997, 119.93, 119.300003, 119.620003, 120.239998, 120.5, 120.089996, 120.449997, 120.809998, 120.099998, 122.099998, 122.440002, 122.349998, 121.629997, 121.389999, 130.490005, 129.389999, 129.190002, 130.5, 132.089996, 132.220001, 132.449997, 132.940002, 133.820007, 135.089996, 136.270004 };
			trace.Low = new double[] { 115.75, 115.809998, 116.470001, 117.940002, 118.300003, 118.599998, 118.209999, 118.809998, 118.220001, 119.709999, 119.370003, 119.730003, 119.769997, 119.5, 120.279999, 121.599998, 121.599998, 120.660004, 120.620003, 127.010002, 127.779999, 128.160004, 128.899994, 130.449997, 131.220001, 131.119995, 132.050003, 132.75, 133.25, 134.619995 };
			trace.Open = new double[] { 115.849998, 115.919998, 116.779999, 117.949997, 118.769997, 118.739998, 118.900002, 119.110001, 118.339996, 120, 119.400002, 120.449997, 120, 119.550003, 120.419998, 121.669998, 122.139999, 120.93, 121.150002, 127.029999, 127.980003, 128.309998, 129.130005, 130.539993, 131.350006, 131.649994, 132.460007, 133.080002, 133.470001, 135.520004 };

			(trace.ValueItems as dynamic).xaxis = "x";
			(trace.ValueItems as dynamic).yaxis = "y";

			TraceList dataTraces = new TraceList(trace);



			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Finance Candlestick Chart" },
				XAxis = new AxisInfo()
				{
					AutoRange = Enumerations.LayoutEnums.AutoRangeOptions.True,

					AxisType = AxisTypeOptions.Date,
					Domain = new int[] { 0, 1 },
					Range = new string[] { "2017-01-03 12:00", "2017-02-15 12:00" },
					Title = new TitleInfo() { Text = "Date" }
				},

				YAxis = new AxisInfo()
				{
					AutoRange = Enumerations.LayoutEnums.AutoRangeOptions.True,
					AxisType = AxisTypeOptions.Linear,
					Domain = new int[] { 0, 1 },
					Range = new double[] { 114.609999778, 137.410004222 },
					Title = new TitleInfo() { Text = "Price" }
				},
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth

			};




			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}

		public async void OHLCChart()
		{
			//https://plotly.com/javascript/ohlc-charts/

			OHLCTrace trace = new OHLCTrace();


			trace.X = new string[] { "2017-01-04", "2017-01-05", "2017-01-06", "2017-01-09", "2017-01-10", "2017-01-11", "2017-01-12", "2017-01-13", "2017-01-17", "2017-01-18", "2017-01-19", "2017-01-20", "2017-01-23", "2017-01-24", "2017-01-25", "2017-01-26", "2017-01-27", "2017-01-30", "2017-01-31", "2017-02-01", "2017-02-02", "2017-02-03", "2017-02-06", "2017-02-07", "2017-02-08", "2017-02-09", "2017-02-10", "2017-02-13", "2017-02-14", "2017-02-15" };

			trace.Close = new double[] { 116.019997, 116.610001, 117.910004, 118.989998, 119.110001, 119.75, 119.25, 119.040001, 120, 119.989998, 119.779999, 120, 120.080002, 119.970001, 121.879997, 121.940002, 121.949997, 121.629997, 121.349998, 128.75, 128.529999, 129.080002, 130.289993, 131.529999, 132.039993, 132.419998, 132.119995, 133.289993, 135.020004, 135.509995 };
			trace.High = new double[] { 116.510002, 116.860001, 118.160004, 119.43, 119.379997, 119.93, 119.300003, 119.620003, 120.239998, 120.5, 120.089996, 120.449997, 120.809998, 120.099998, 122.099998, 122.440002, 122.349998, 121.629997, 121.389999, 130.490005, 129.389999, 129.190002, 130.5, 132.089996, 132.220001, 132.449997, 132.940002, 133.820007, 135.089996, 136.270004 };
			trace.Low = new double[] { 115.75, 115.809998, 116.470001, 117.940002, 118.300003, 118.599998, 118.209999, 118.809998, 118.220001, 119.709999, 119.370003, 119.730003, 119.769997, 119.5, 120.279999, 121.599998, 121.599998, 120.660004, 120.620003, 127.010002, 127.779999, 128.160004, 128.899994, 130.449997, 131.220001, 131.119995, 132.050003, 132.75, 133.25, 134.619995 };
			trace.Open = new double[] { 115.849998, 115.919998, 116.779999, 117.949997, 118.769997, 118.739998, 118.900002, 119.110001, 118.339996, 120, 119.400002, 120.449997, 120, 119.550003, 120.419998, 121.669998, 122.139999, 120.93, 121.150002, 127.029999, 127.980003, 128.309998, 129.130005, 130.539993, 131.350006, 131.649994, 132.460007, 133.080002, 133.470001, 135.520004 };

			(trace.ValueItems as dynamic).xaxis = "x";
			(trace.ValueItems as dynamic).yaxis = "y";

			TraceList dataTraces = new TraceList(trace);



			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Finance OHLC Chart" },
				XAxis = new AxisInfo()
				{
					AutoRange = Enumerations.LayoutEnums.AutoRangeOptions.True,
					AxisType = AxisTypeOptions.Date,
					Domain = new int[] { 0, 1 },
					Range = new string[] { "2017-01-03 12:00", "2017-02-15 12:00" },
					Title = new TitleInfo() { Text = "Date" }
				},

				YAxis = new AxisInfo()
				{
					AutoRange = Enumerations.LayoutEnums.AutoRangeOptions.True,
					AxisType = AxisTypeOptions.Linear,
					Domain = new int[] { 0, 1 },
					Range = new double[] { 114.609999778, 137.410004222 },
					Title = new TitleInfo() { Text = "Price" }
				},
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth

			};



		

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}

		public async void WaterfallChart()
		{
			//https://plotly.com/javascript/waterfall-charts/

			WaterfallTrace waterfallTrace = new WaterfallTrace()
			{
				Name = "2018",
				Orientation = OrientationOptions.Horizontal,
				Measure = new string[] {
				"relative",
				"relative",
				"relative",
				"relative",
				"total",
				"relative",
				"relative",
				"relative",
				"relative",
				"total",
				"relative",
				"relative",
				"total",
				"relative",
				"total"
				},
				Y = new string[] {
				"Sales",
				"Consulting",
				"Maintenance",
				"Other revenue",
				"Net revenue",
				"Purchases",
				"Material expenses",
				"Personnel expenses",
				"Other expenses",
				"Operating profit",
				"Investment income",
				"Financial income",
				"Profit before tax",
				"Income tax (15%)",
				"Profit after tax"
				},
				X = new object?[] {
				375,
				128,
				78,
				27,
				0,
				-327,
				-12,
				-78,
				-12,
				0,
				32,
				89,
				0,
				-45,
				0
				},
				Connector = new ConnectorInfo() { Mode = ConnectorModeOptions.Between, Line = new LineInfo() { Width = 4, Color = "rgb(0, 0, 0)" } }

			};

			TraceList dataTraces = new TraceList(waterfallTrace);


			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Profit and loss statement 2018<br>waterfall chart displaying positive and negative" },
				YAxis = new AxisInfo() { AxisType = AxisTypeOptions.Category, AutoRange = Enumerations.LayoutEnums.AutoRangeOptions.Reversed },
				XAxis = new AxisInfo() { AxisType = AxisTypeOptions.Linear },
				Margin = new MarginInfo() { Left = 150 },
				ShowLegend = true,
				Height = plotHeight,
				Width = plotWidth
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}


		public async void FunnelChart()
		{
			//https://plotly.com/javascript/funnel-charts/

			FunnelTrace funnel = new FunnelTrace()
			{
				Connector = new ConnectorInfo() { Line = new LineInfo() { Color = "royalblue", Dash = DashOptions.Dot, Width = 3 } },
				X = new double[] { 1200, 909.4, 600.6, 300, 80 },
				Y = new string[] { "Sales person A", "Sales person B", "Sales person C", "Sales person D", "Sales person E" },
				TextPosition = TextPositionOptions.Inside,
				TextInfo = TextInfoOptions.Value_PercentInitial,
				Opacity = 0.65,
				Marker = new MarkerInfo() { Color = new object[] { "59D4E8", "DDB6C6", "A696C8", "67EACA", "94D2E6" } },
				Line = new LineInfo() { Width = new int[] { 4, 2, 2, 3, 1, 1 }, Color = new object[] { "3E4E88", "606470", "3E4E88", "606470", "3E4E88" } }

			};
			TraceList dataTraces = new TraceList(funnel);
			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Sales Activity" },
				Margin = new MarginInfo() { Left = 100 },
				Width = plotWidth,
				Height = plotHeight
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void StackedFunnelChart()
		{
			//https://plotly.com/javascript/funnel-charts/

			FunnelTrace MontreallFunnel = new FunnelTrace()
			{
				Name = "Montreal",
				X = new double[] { 120, 60, 30, 20 },
				Y = new string[] { "Website visit", "Downloads", "Potential customers", "Requested price" },
				TextInfo = TextInfoOptions.Value_PercentInitial,
			};
			FunnelTrace TorontoFunnel = new FunnelTrace()
			{
				Name = "Toronto",
				X = new double[] { 100, 60, 40, 30, 20 },
				Y = new string[] { "Website visit", "Downloads", "Potential customers", "Requested price", "invoice sent" },
				TextInfo = TextInfoOptions.Value_PercentInitial,
			};
			FunnelTrace VancouverFunnel = new FunnelTrace()
			{
				Name = "Vancouver",
				X = new double[] { 90, 70, 50, 30, 10, 5 },
				Y = new string[] { "Website visit", "Downloads", "Potential customers", "Requested price", "invoice sent", "closed deals" },
				TextInfo = TextInfoOptions.Value_PercentInitial,
			};


			TraceList dataTraces = new TraceList(MontreallFunnel);
			dataTraces.AddTrace(TorontoFunnel);
			dataTraces.AddTrace(VancouverFunnel);

			LayoutInfo layout = new LayoutInfo()
			{
				FunnelMode = FunnelModeOptions.Stack,
				Title = new TitleInfo() { Text = "Sales Funnel" },
				Margin = new MarginInfo() { Left = 100, Right = 0 },
				Height = plotHeight,
				Width = plotWidth,
				ShowLegend = true
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void FunnelAreaChart()
		{
			//https://plotly.com/javascript/funnel-charts/

			FunnelAreaTrace funnel = new FunnelAreaTrace()
			{
				Values = new int[] { 5, 4, 3, 2, 1 },
				Text = new string[] { "The 1st", "The 2nd", "The 3rd", "The 4th", "The 5th" },

				Marker = new MarkerInfo()
				{
					Color = new object[] { "59D4E8", "DDB6C6", "A696C8", "67EACA", "94D2E6" },
					Line = new LineInfo()
					{
						Width = new int[] { 2, 1, 5, 0, 3 },
						Color = new object[] { "3E4E88", "606470", "3E4E88", "606470", "3E4E88" }
					}
				},
				Opacity = 0.65,
				TextFont = new FontInfo() { Family = "Old Standard TT", Color = "black", Size = 13 }


			};

			TraceList dataTraces = new TraceList(funnel);
			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Activity" },
				Margin = new MarginInfo() { Left = 100, Right = 200 },
				Height = plotHeight,
				Width = plotWidth,
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}


		
		public async void GuageChart()
		{
			//https://plotly.com/javascript/gauge-charts/
		

			IndicatorTrace guage = new IndicatorTrace()
			{
				Value = 420,
				Mode = ModeOptions.Number_Gauge_Delta,
				Title = new TitleInfo() { Text = "Speed", Font = new FontInfo() { Size = 24 } },
				Delta = new DeltaInfo() { Reference = 400, Increasing = new AreaChangeInfo() { Color = "RebeccaPurple" } },
				Gauge = new GaugeInfo()
				{

					Axis = new GaugeAxisInfo { Range = new object?[] { null, 500 }, TickWidth = 1, TickColor = "darkblue" },

					Bar = new BarInfo { Color = "darkblue" },
					BgColor = "white",
					BorderWidth = 2,
					BorderColor = "gray",
					Steps = new ItemList<GaugeStepItem>()
					{
						new GaugeStepItem() { Range=new object[] { 0, 250 }, Color="cyan" },
						new GaugeStepItem() { Range=new object[] { 250, 400 }, Color="royalblue" }
					},
					Shape = GaugeShapeOptions.Angular,
					Threshold = new ThresholdInfo()
					{
						Line = new LineInfo() { Color = "red", Width = 4 },
						Thickness = 0.75,
						Value = 490
					}
				}

			};
		

			TraceList dataTraces = new TraceList(guage);
			LayoutInfo layout = new LayoutInfo()
			{
				Width = plotWidth,
				Height = plotHeight,
				Margin = new MarginInfo() { Top = 0, Bottom = 0 },
				PaperBgColor = "lavender",
				Font = new FontInfo()
				{
					Family = "Arial",
					Color = "darkblue"
				}
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		
		public async void BulletChart()
		{
			//https://plotly.com/javascript/bullet-charts/

			
			IndicatorTrace bullet = new IndicatorTrace()
			{
				Delta = new DeltaInfo() { Reference = 200 },
				Domain = new DomainInfo() { X = new double[] { 0, 1 }, Y = new double[] { 0, 1 } },
				Value = 220,
				Mode = ModeOptions.Number_Gauge_Delta,
				Title = new TitleInfo() { Text = "<b>Profit</b><br><span style='color: gray; font-size:0.8em'>U.S. $</span>", Font = new FontInfo() { Size = 14 } },

				Gauge = new GaugeInfo()
				{
					Axis = new GaugeAxisInfo { Range = new object?[] { null, 300 } },
					Bar = new BarInfo { Color = "darkblue" },
					BgColor = "white",
					Steps = new ItemList<GaugeStepItem>()
					{
						new GaugeStepItem() { Range=new object[] { 0, 150 }, Color="lightgray" },
						new GaugeStepItem() { Range=new object[] { 150, 250 }, Color="gray" }
					},
					Shape = GaugeShapeOptions.Bullet,
					Threshold = new ThresholdInfo()
					{
						Line = new LineInfo() { Color = "red", Width = 2, Gradient = new GradientInfo() { YAnchor = GradientTypeOptions.Vertical } },
						Thickness = 0.75,
						Value = 280
					},
				}

			};
			


			TraceList dataTraces = new TraceList(bullet);
			LayoutInfo layout = new LayoutInfo()
			{
				Width = plotWidth,
				Height = plotHeight,
				Margin = new MarginInfo()
                {
					Top=300,
					Bottom=300
                }
			};
			
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void ChoroplethChart()
		{
			// https://plotly.com/javascript/aggregations/

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
						Transforms = new ItemList<TransformsItem>() {
							new TransformsItem()
							{
								TransformsType = TransformTypeOptions.Aggregate,
								Groups = happinessRanked.Select(item => item.Country).ToArray(),
								Aggregations = new ItemList<Transforms.AggregationItem>
								{
									new Transforms.AggregationItem()
									{
										Target = "z",
										Func =  Enumerations.TransformsEnums.FuncOptions.Avg,
										Enabled= true
									}
								}
							}
						}
					};

					TraceList dataTraces = new TraceList(trace);

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "<b>World Happiness</b><br>2015 - 2017" },
						Geo = new GeoInfo()
						{
							ShowFrame = false,
							ShowCoastLines = false,
							Projection = new ProjectionInfo { ProjectionType = ProjectionTypeOptions.Orthographic }
						},
						UpdateMenus = new ItemList<UpdateMenusItem>() {
							new UpdateMenusItem()
							{
								X= 0.85,
								Y=1.15,
								XRef = RefOptions.Paper,
								YRef = RefOptions.Paper,
								YAnchor = YAnchorOptions.Top,
								Active = 0,
								ShowActive=true,
								Buttons = new ItemList<ButtonsItem>()
								{
									new ButtonsItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "avg"},
										Label = "Avg"
									},
									new ButtonsItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "sum"},
										Label = "Sum"
									},
									new ButtonsItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "min"},
										Label = "Min"
									},
									new ButtonsItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "max"},
										Label = "Max"
									},
									new ButtonsItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "mode"},
										Label = "Mode"
									},
									new ButtonsItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "median"},
										Label = "Median"
									},
									new ButtonsItem()
									{
								 		Method = MethodOptions.Restyle,
										Args = new object[]{"transforms[0].aggregations[0].func", "first"},
										Label = "First"
									},
									new ButtonsItem()
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


		public async void ChoroplethMapboxChart()
		{
			//https://plotly.com/python/mapbox-county-choropleth/

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
						Zmax=12,
						Zmin=0,
						Locations  = unemploymentFipsArea.Select(item => item.Fips).ToArray(),
						GeoJson = "https://raw.githubusercontent.com/plotly/datasets/master/geojson-counties-fips.json",
						Opacity = 0.5
					};

					LayoutInfo layout = new LayoutInfo()
					{
						
						Width = plotWidth,
						Height = plotHeight,
						Title = new TitleInfo() { Text = "2016 US Unemployment by County" },
						Mapbox = new MapboxInfo() { Style = StyleOptions.CartoPositron, Zoom = 3.2, Center = new CenterInfo() { Lat = 37.0902, Lon = -95.7129 } },
						ColorAxis = new ColorAxisInfo() { ShowScale=false, ColorScale = ColorScaleOptions.Viridis.GetDescription()},
						
					};

					TraceList dataTraces = new TraceList(trace);
					await Chart1.newPlot(dataTraces, layout, commonConfig);

				}

			}
		}

		public async void DensityMapboxChart()
		{
			//https://plotly.com/javascript/mapbox-density-heatmaps/

			DensityMapboxTrace trace = new DensityMapboxTrace()
			{
				Lon = new double[] { 10, 20, 30 },
				Lat = new double[] { 15, 25, 35 },
				Z = new double[] { 1, 3, 2 },
			};
			TraceList dataTraces = new TraceList(trace);

			LayoutInfo layout = new LayoutInfo()
			{
				Width = plotWidth,
				Height = plotHeight,
				Mapbox = new MapboxInfo() { Style = StyleOptions.StamenTerrain }
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void LineGeoChart()
		{
			//https://plotly.com/javascript/lines-on-maps/

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
								Mode = ModeOptions.Lines,
								Longitude = new object[] { path.StartLon, path.EndLon },
								Latitude = new object[] { path.StartLat, path.EndLat },
								Line = new LineInfo() { Width = 1, Color = "red" },
								Opacity = path.Count * 1.0 / maxCount
							}
							);
					}

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Feb. 2011 American Airline flight paths" },
						ShowLegend = false,
						Geo = new GeoInfo()
						{
							Scope = ScopeOptions.NorthAmerica,
							Projection = new ProjectionInfo()
							{
								ProjectionType = ProjectionTypeOptions.AzimuthalEqualArea

							},
							Showland = true,
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
		public async void ScatterGeoChart()
		{
			//https://plotly.com/javascript/filled-area-on-mapbox/

			ScatterGeoTrace geo = new ScatterGeoTrace()
			{
				Locations = new string[] { "FRA", "DEU", "RUS", "ESP" },
				Mode = ModeOptions.Markers,
				Marker = new MarkerInfo()
				{
					Size = new double[] { 20, 30, 15, 10 },
					Color = new object[] { 10, 20, 40, 50 },
					Cmin = 0,
					Cmax = 50,
					ColorScale = "Greens",
					ColorBar = new ColorBarInfo() { Title = new TitleInfo() { Text = "Some Rate" }, TickSuffix = "%", ShowTickSuffix = ShowLabelOptions.Last },
					Line = new LineInfo() { Color = "black" }
				},
				Name = "Europe Data"
			};

			TraceList dataTraces = new TraceList(geo);
			LayoutInfo layout = new LayoutInfo()
			{
				Geo = new GeoInfo() { Scope = ScopeOptions.Europe, Resolution = ResolutionOptions._50 },
				Height = plotHeight,
				Width = plotWidth
			};
			
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		

	
		public async void ScatterMapboxChart()
		{
		   // https://plotly.com/javascript/scattermapbox/

			ScatterMapboxTrace trace = new ScatterMapboxTrace()
			{
				Fill = FillOptions.ToSelf,
				Lon = new double[] { -74, -70, -70, -74 },
				Lat = new double[] { 47, 47, 45, 45 },
				Marker = new MarkerInfo() { Size = 10, Color = "orange" }
			};
			TraceList dataTraces = new TraceList(trace);

			LayoutInfo layout = new LayoutInfo()
			{
				Width = plotWidth,
				Height = plotHeight,
				ShowLegend = false,
				Mapbox = new MapboxInfo() { Style = StyleOptions.StamenTerrain, Center = new CenterInfo() { Lat = 46, Lon = -73 }, Zoom = 5 }

			};

			await Chart1.newPlot(dataTraces, layout);
		}

		public async void ContourChart()
		{
			//https://plotly.com/javascript/contour-plots/

			var data = new object[] {
				new double[] { 10, 10.625, 12.5, 15.625, 20 },
				new double[] { 5.625, 6.25, 8.125, 11.25, 15.625 },
				new double[] { 2.5, 3.125, 5, 8.125, 12.5 },
				new double[] { 0.625, 1.25, 3.125, 6.25, 10.625 },
				new double[] { 0, 0.625, 2.5, 5.625, 10 }
			};

			ContourTrace contourTrace = new ContourTrace();

			contourTrace.Z = data;

			contourTrace.Contours = new ContoursInfo() { Coloring = ColoringOptions.Heatmap };
			TraceList dataTraces = new TraceList(contourTrace);

			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Smooth Contour Coloring" },
				Height = plotHeight,
				Width = plotWidth
			};
		
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void ContourCarpetChart()
		{
			// https://plotly.com/javascript/carpet-contour/

			ContourCarpetTrace trace1 = new ContourCarpetTrace()
			{
				A = new double[] { 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 },
				B = new double[] { 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6 },
				Z = new double[] { 1, 1.96, 2.56, 3.0625, 4, 5.0625, 1, 7.5625, 9, 12.25, 15.21, 14.0625 },
				AutoContour = false,
				Contours = new ContoursInfo() { Start = 1, End = 14, Size = 1 },
				Line = new LineInfo() { Width = 2, Smoothing = 0 },
				ColorBar = new ColorBarInfo() { Len = 0.4, Y = 0.25 }

			};

			CarpetTrace trace2 = new CarpetTrace()
			{
				A = new double[] { 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 },
				B = new double[] { 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6 },
				X = new double[] { 2, 3, 4, 5, 2.2, 3.1, 4.1, 5.1, 1.5, 2.5, 3.5, 4.5 },
				Y = new double[] { 1, 1.4, 1.6, 1.75, 2, 2.5, 2.7, 2.75, 3, 3.5, 3.7, 3.75 },
				AAxis = new ABAxisInfo() { TickPrefix = "a = ", Smoothing = 0, AxisType = ABAxisTypeOptions.Linear, MinorGridCount = 9 },
				BAxis = new ABAxisInfo() { TickPrefix = "b = ", Smoothing = 0, AxisType = ABAxisTypeOptions.Linear, MinorGridCount = 9 }

			};



			TraceList dataTraces = new TraceList(trace1);
			dataTraces.AddTrace(trace2);

			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Cheater plot with 1d input" },
				Margin = new MarginInfo() { Top = 40, Right = 30, Bottom = 30, Left = 30 },
				YAxis = new AxisInfo() { Range = new double[] { 0.388, 4.361 } },
				XAxis = new AxisInfo() { Range = new double[] { 0.667, 5.932 } },
				Height = plotHeight,
				Width = plotWidth
			};


			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}
		public async void HeatmapChart()
		{
			//https://plotly.com/javascript/heatmaps/

			TraceList dataTraces = new TraceList(new HeatmapTrace()
			{
				X = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
				Y = new string[] { "Morning", "Afternoon", "Evening" },
				Z = new object[] { new object?[] { 1, null, 30, 50, 1 }, new object[] { 20, 1, 60, 80, 30 }, new object[] { 30, 60, 1, -10, 20 } },

				HoverOnGaps = false
			});


			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
		}


		public async void ParallelCoordinateChart()
		{



			//https://plotly.com/javascript/parallel-coordinates-plot/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/bcdunbar/datasets/master/parcoords_data.csv");


				if (fileText != null)
				{
					List<BlockData> blockList = new List<BlockData>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 1; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Replace("\r,", "").Split(",");

						BlockData block = new BlockData()
						{

							colorVal = Convert.ToInt32(values[0]),
							blockHeight = Convert.ToDouble(values[1]),
							blockWidth = Convert.ToDouble(values[2]),
							cycMaterial = Convert.ToDouble(values[3]),
							blockMaterial = Convert.ToDouble(values[4]),
							totalWeight = Convert.ToDouble(values[5]),
							assemblyPW = Convert.ToDouble(values[6]),
							HstW = Convert.ToDouble(values[7]),
							minHW = Convert.ToDouble(values[8]),
							minWD = Convert.ToDouble(values[9]),
							rfBlock = Convert.ToDouble(values[10])
						};
						blockList.Add(block);
					}

					ItemList<DimensionItem> dimensions = new ItemList<DimensionItem>(
						new DimensionItem[] {
							new DimensionItem()
							{
								ConstraintRange = new object[] { 100000, 150000 },
								Range = new object[] { 32000, 227900 },
								Label = "Block height",
								Values = blockList.Select(block => block.blockHeight).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] { 0, 700000 },
								Label = "Block width",
								Values = blockList.Select(block => block.blockWidth).ToArray()
							},
							new DimensionItem()
							{
								TickVals = new double[]{0, 0.5, 1, 2, 3},
								TickText = new string[]{"A", "AB", "B", "Y", "Z"},
								Label = "Cylinder material",
								Values = blockList.Select(block => block.blockWidth).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] { -1, 4 },
								TickVals = new double[]{0, 1, 2, 3},
								Label = "Block material",
								Values = blockList.Select(block => block.blockMaterial).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] {134, 3154 },
								Label = "Total weight",
								Visible = true,
								Values = blockList.Select(block => block.totalWeight).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] { 9, 19984 },
								Label = "Assembly penalty weight",
								Values = blockList.Select(block => block.assemblyPW).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] { 49000, 568000 },
								Label = "Height st width",
								Values = blockList.Select(block => block.HstW).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] {-28000, 196430 },
								Label = "Min height width",
								Values = blockList.Select(block => block.minHW).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] {98453, 501789 },
								Label = "Min width diameter",
								Values = blockList.Select(block => block.minWD).ToArray()
							},
							new DimensionItem()
							{
								Range = new object[] { 1417, 107154 },
								Label = "RF block",
								Values = blockList.Select(block => block.rfBlock).ToArray()
							}

						}
					);

					ParallelCoordinateTrace trace = new ParallelCoordinateTrace()
					{
						Dimensions = dimensions,
						Line = new LineInfo()
						{
							ShowScale = true,
							ReverseScale = true,
							ColorScale = ColorScaleOptions.Jet.GetDescription(),
							Cmin = -4000,
							Cmax = -100,
							Color = blockList.Select(block => block.colorVal).ToArray()
						}
					};

					TraceList dataTraces = new TraceList(trace);

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Parallel Coordinate Chart" },
						ShowLegend = false,
						Height = plotHeight,
						Width = plotWidth,
						Margin = new MarginInfo() { Left = 50, Right = 0, Top = 250, Bottom = 250 }
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void PolarChart()
		{
			//https://plotly.com/javascript/polar-chart/

			PolarTrace polar1 = new PolarTrace()
			{
				Mode = ModeOptions.Lines,
				R = new double[] { 0, 1.5, 1.5, 0, 2.5, 2.5, 0 },
				Theta = new double[] { 0, 10, 25, 0, 205, 215, 0 },
				Line = new LineInfo() { Color = "black" },
				Fill = FillOptions.ToSelf,
				FillColor = "#709BFF"
			};

			PolarTrace polar2 = new PolarTrace()
			{
				Mode = ModeOptions.Lines,
				R = new double[] { 0, 3.5, 3.5, 0 },
				Theta = new double[] { 0, 55, 75, 0 },
				Line = new LineInfo() { Color = "black" },
				Fill = FillOptions.ToSelf,
				FillColor = "#E4FF87"
			};
			PolarTrace polar3 = new PolarTrace()
			{
				Mode = ModeOptions.Lines,
				R = new double[] { 0, 4.5, 4.5, 0, 4.5, 4.5, 0 },
				Theta = new double[] { 0, 100, 120, 0, 305, 320, 0 },
				Line = new LineInfo() { Color = "black" },
				Fill = FillOptions.ToSelf,
				FillColor = "#FFAA70"
			};
			PolarTrace polar4 = new PolarTrace()
			{
				Mode = ModeOptions.Lines,
				R = new double[] { 0, 4, 4, 0 },
				Theta = new double[] { 0, 4.5, 4.5, 0, 4.5, 4.5, 0 },
				Line = new LineInfo() { Color = "black" },
				Fill = FillOptions.ToSelf,
				FillColor = "#FFDF70"
			};
			PolarTrace polar5 = new PolarTrace()
			{
				Mode = ModeOptions.Lines,
				R = new double[] { 0, 3, 3, 0 },
				Theta = new double[] { 0, 262.5, 277.5, 0 },
				Line = new LineInfo() { Color = "black" },
				Fill = FillOptions.ToSelf,
				FillColor = "#B6FFB4"
			};

			TraceList dataTraces = new TraceList(new Trace[] { polar1, polar2, polar3, polar4, polar5 });



			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Polar Chart" },
				Polar = new PolarInfo() { RadialAxis = new RadialAxisInfo() { Visible = true, Range = new double[] { 0, 5 } } },
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



		public async void ScatterCarpetChart()
		{
			//https://plotly.com/javascript/carpet-scatter/

			CarpetTrace trace1 = new CarpetTrace()
			{
				A = new double[] { 4e-6, 4e-6, 4e-6, 4.5e-6, 4.5e-6, 4.5e-6, 5e-6, 5e-6, 5e-6, 6e-6, 6e-6, 6e-6 },
				B = new double[] { 1e6, 2e6, 3e6, 1e6, 2e6, 3e6, 1e6, 2e6, 3e6, 1e6, 2e6, 3e6 },
				Y = new double[] { 2, 3.5, 4, 3, 4.5, 5, 5.5, 6.5, 7.5, 8, 8.5, 10 },
				AAxis = new ABAxisInfo() { TickPrefix = "a = ", TickSuffix = "m", Smoothing = 1, MinorGridCount = 9 },
				BAxis = new ABAxisInfo() { TickPrefix = "b = ", TickSuffix = "Pa", Smoothing = 1, MinorGridCount = 9 }
			};

			ScatterCarpetTrace trace2 = new ScatterCarpetTrace()
			{
				A = new double[] { 4e-6, 4.5e-6, 5e-6, 6e-6 },
				B = new double[] { 1.5e6, 2.5e6, 1.5e6, 2.5e6 },
				Line = new LineInfo() { Smoothing = 1, Shape = LineShapeOptions.Spline }
			};

			TraceList dataTraces = new TraceList(trace1);
			dataTraces.AddTrace(trace2);


			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);


		}

		public async void ScatterSmithChart()
        {
			//https://plotly.com/python/smith-charts/

			ScatterSmithTrace trace = new ScatterSmithTrace()
			{
				Real = new double[] { 0.5, 1, 2, 3 },
				Imaginary = new double[] { 0.5, 1, 2, 3 }
			};

			TraceList dataTraces = new TraceList(trace);

			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
		}

		public async void TernaryChart()
		{
			//https://plotly.com/javascript/ternary-plots/

			TernaryTrace trace = new TernaryTrace()
			{
				A = new double[] { 75, 70, 75, 5, 10, 10, 20, 10, 15, 10, 20 },
				B = new double[] { 25, 10, 20, 60, 80, 90, 70, 20, 5, 10, 10 },
				C = new double[] { 0, 20, 50, 35, 10, 0, 10, 70, 80, 80, 70 },
				Text = new string[] { "point 1", "point 2", "point 3", "point 4", "point 5", "point 6", "point 7", "point 8", "point 9", "point 10", "point 11" },
				Marker = new MarkerInfo() { Size = 14, Line = new LineInfo() { Width = 2, Color = "DB7365" }, Symbol = SymbolOptions.CircleOpen },
				Mode = ModeOptions.Markers
			};

			ItemList<AnnotationItem> annotations = new ItemList<AnnotationItem>();
			annotations.Add(new AnnotationItem()
			{
				ShowArrow = true,
				Text = "Replica of Tom Pearson\'s <a href=\"http://bl.ocks.org/tomgp/7674234\">block</a>",
				X = 0.48,
				Y = 1.1,
				Font = new FontInfo() { Size = 15 }
			});

			LayoutInfo layout = new LayoutInfo()
			{
				Ternary = new TernaryInfo()
				{
					Sum = 100,
					AAxis = new TernaryAxisInfo()
					{
						Title = new TitleInfo() { Text = "Journalist", Font = new FontInfo() { Size = 20 } },
						TickAngle = 0,
						TickFont = new FontInfo() { Size = 15 },
						TickColor = "black",
						TickLen = 5,
						ShowGrid = true,
						ShowLine = true

					},
					BAxis = new TernaryAxisInfo()
					{
						Title = new TitleInfo() { Text = "<br>Developer", Font = new FontInfo() { Size = 20 } },
						TickAngle = 45,
						TickFont = new FontInfo() { Size = 15 },
						TickColor = "black",
						TickLen = 5,
						ShowGrid = true,
						ShowLine = true

					},
					CAxis = new TernaryAxisInfo()
					{
						Title = new TitleInfo() { Text = "<br>Designer", Font = new FontInfo() { Size = 20 } },
						TickAngle = -45,
						TickFont = new FontInfo() { Size = 15 },
						TickColor = "black",
						TickLen = 5,
						ShowGrid = true,
						ShowLine = true

					},
					BgColor = "#fff1e0",


				},
				Annotations = annotations,
				PaperBgColor = "#fff1e0",
				Height = plotHeight,
				Width = plotWidth
			};

			TraceList dataTraces = new TraceList(trace);

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}

		public async void BoxChart()
		{
			//https://plotly.com/javascript/box-plots/

			var xPlayers = new string[]
			{
				"Carmelo<br />Anthony",
				"Dwyane<br />Wade",
				"Deron<br />Williams",
				"Brook<br />Lopez",
				"Damian<br />Lillard",
				"David<br />West",
				"Blake<br />Griffin",
				"David<br />Lee",
				"Demar<br />Derozan"
			};

			var yData = new object[]
			{
				BoxRandom(30,10),
				BoxRandom(30,20),
				BoxRandom(30,25),
				BoxRandom(30,40),
				BoxRandom(30,45),
				BoxRandom(30,30),
				BoxRandom(30,20),
				BoxRandom(30,15),
				BoxRandom(30,43)
			};

			var colors = new object[]
			{
				"rgba(93, 164, 214, 0.5)",
				"rgba(255, 144, 14, 0.5)",
				"rgba(44, 160, 101, 0.5)",
				"rgba(255, 65, 54, 0.5)",
				"rgba(207, 114, 255, 0.5)",
				"rgba(127, 96, 0, 0.5)",
				"rgba(255, 140, 184, 0.5)",
				"rgba(79, 90, 117, 0.5)",
				"rgba(222, 223, 0, 0.5)"
			};

			TraceList dataTraces = new TraceList();

			for (int i = 0; i < xPlayers.Length; i++)
			{
				BoxTrace box = new BoxTrace()
				{
					Name = xPlayers[i],
					Y = yData[i],
					BoxPoints = BoxPointsOptions.All,
					Jitter = 0.5,
					WhiskerWidth = 0.2,
					FillColor = "cls",
					Marker = new MarkerInfo() { Size = 2 },
					Line = new LineInfo() { Width = 1 }

				};

				dataTraces.AddTrace(box);
			}

			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "Points Scored by the Top 9 Scoring NBA Players in 2012" },
				YAxis = new AxisInfo()
				{
					AutoRange = Enumerations.LayoutEnums.AutoRangeOptions.True,
					ShowGrid = true,
					ZeroLine = true,
					DTick = 5,
					GridColor = "rgb(255, 255, 255)",
					Gridwidth = 1,
					ZeroLineColor = "rgb(255, 255, 255)",
					ZeroLinewidth = 2
				},
				Margin = new MarginInfo() { Left = 40, Right = 30, Bottom = 80, Top = 100 },
				PaperBgColor = "rgb(243, 243, 243)",
				PlotBgColor = "rgb(243, 243, 243)",
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}


		static double NextDouble(double min, double max)
		{
			System.Random random = new System.Random();
			double val = (random.NextDouble() * (max - min) + min);
			return val;
		}

		public async void Histogram()
		{
		//https://plotly.com/javascript/histograms/

			int size = 500;
			var x1 = new double[size];
			var y1 = new double[size];
			var x2 = new double[size];
			var y2 = new double[size];
			for (var i = 0; i < 500; i++)
			{
				double k = NextDouble(0, 1);

				x1[i] = k * 5;
				y1[i] = k;
				x2[i] = k * 10;
				y2[i] = k * 2;
			}
			HistogramTrace trace1 = new HistogramTrace()
			{
				X = x1,
				Y = y1,
				Name = "control",
				AutoBinX = false,
				Marker = new MarkerInfo() { Color = "rgba(255, 100, 102, 0.7)", Line = new LineInfo() { Color = "rgba(255, 100, 102, 1)", Width = 1 } },
				Opacity = 0.5,
				XBins = new BinInfo() { End = 2.8, Size = 0.06, Start = 0.5 }
			};



			HistogramTrace trace2 = new HistogramTrace()
			{
				X = x2,
				Y = y2,
				Name = "experiment",
				AutoBinX = false,
				Marker = new MarkerInfo() { Color = "rgba(100, 200, 102, 0.7)", Line = new LineInfo() { Color = "rgba(100, 200, 102, 1)", Width = 1 } },
				Opacity = 0.5,
				XBins = new BinInfo() { End = 4, Size = 0.06, Start = -3.2 }
			};

			TraceList dataTraces = new TraceList(trace1);
			dataTraces.AddTrace(trace2);

			LayoutInfo layout = new LayoutInfo()
			{
				BarGap = 0.05f,
				BarGroupGap = 0.2f,
				BarMode = BarModeOptions.Overlay,
				Title = new TitleInfo() { Text = "Sample Results" },
				XAxis = new AxisInfo() { Title = new TitleInfo() { Text = "Value" } },
				YAxis = new AxisInfo() { Title = new TitleInfo() { Text = "Count" } },
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout,commonConfig);

		}


		public async void HistogramContour2D()
		{
			//https://plotly.com/javascript/2d-histogram-contour/

			int size = 500;
			var x = new double[size];
			var y = new double[size];
			for (var i = 0; i < 500; i++)
			{
				x[i] = NextDouble(-0.2, 1.2);
				y[i] = NextDouble(-0.2, 1.2) + 1;
			}

			Histogram2DContourTrace trace = new Histogram2DContourTrace()
			{
				X = x,
				Y = y,
				Contours = new ContoursInfo() { ShowLabels = true, LabelFont = new FontInfo() { Family = "Raleway", Color = "white" } },
				HoverLabel = new HoverLabelInfo() { BgColor = "white", BorderColor = "black", Font = new FontInfo() { Color = "black", Family = "Raleway" } }
			};

			TraceList dataTraces = new TraceList(trace);



			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
		}


		public double[] BoxRandom(int num, double mul)
		{
			System.Random random = new System.Random();
			double[] result = new double[num];
			for (int i = 0; i < num; i++)
			{
				result[i] = random.NextDouble() * mul;

			}
			return result;
		}

	
		public async void ParallelCategoriesChart()
		{
			//https://plotly.com/javascript/parallel-categories-diagram/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/titanic.csv");


				if (fileText != null)
				{
					List<TitanicPassenger> passengerList = new List<TitanicPassenger>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						TitanicPassenger passenger = new TitanicPassenger()
						{
							PassengerId = Convert.ToInt32(values[0]),
							Survived = Convert.ToInt32(values[1]),
							Pclass = Convert.ToInt32(values[2]),
							Name = (values[4] + " " + values[3]).Replace("\"", ""),
							Sex = values[5],
							Age = values[6],
							SibSp = Convert.ToInt32(values[7]),
							Parch = values[8],
							Ticket = values[9],
							Fare = Convert.ToDouble(values[10]),
							Cabin = values[11],
							Embarked = values[12]

						};
						passengerList.Add(passenger);
					}

					DimensionItem classDim = new DimensionItem()
					{
						Label = "Class",
						CategoryOrder = CategoryOrderOptions.CategoryAscending,
						Values = passengerList.Select(passenger => passenger.Pclass).ToArray(),
					};

					DimensionItem genderDim = new DimensionItem()
					{
						Label = "Gender",
						CategoryOrder = CategoryOrderOptions.CategoryAscending,
						Values = passengerList.Select(passenger => passenger.Sex).ToArray(),
					};

					DimensionItem survivalDim = new DimensionItem()
					{
						Label = "Outcome",
						CategoryArray = new int[] { 0, 1 },
						Values = passengerList.Select(passenger => passenger.Survived).ToArray(),
						TickText = new string[] { "perished", "survived" }
					};

					ItemList<DimensionItem> dimensions = new ItemList<DimensionItem>();
					dimensions.Add(classDim);
					dimensions.Add(genderDim);
					dimensions.Add(survivalDim);

					ParallelCategoriesTrace trace = new ParallelCategoriesTrace()
					{
						Arrangement = ArrangementOptions.Freeform,
						Dimensions = dimensions,
						LabelFont = new FontInfo() { Size = 14 },
						Line = new LineInfo()
						{
							Color = survivalDim.Values,
							ColorScale = new object[] { new object[] { 0, "lightsteelblue" }, new object[] { 1, "mediumseagreen" } }
						},
						HoverOn = HoverOnOptions.Color

					};

					TraceList dataTraces = new TraceList(trace);

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Titanic Passenger Outcome" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,

					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}

			}
		}


		public double ColorLookup(string irisType)
		{
			double result = 0;
			switch (irisType)
			{
				case "Iris-setosa":
					result = 0;
					break;
				case "Iris-versicolor":
					result = 0.5;
					break;
				case "Iris-virginica":
					result = 1;
					break;
			}

			return result;
		}

		public async void SplomChart()
		{
			//https://plotly.com/javascript/splom/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/iris-data.csv");

				if (fileText != null)
				{
					List<IrisSample> samples = new List<IrisSample>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						IrisSample iris = new IrisSample()
						{
							SepalLength = Convert.ToDouble(values[0]),
							SepalWidth = Convert.ToDouble(values[1]),
							PetalLength = Convert.ToDouble(values[2]),
							PetalWidth = Convert.ToDouble(values[3]),
							IrisClass = values[4]

						};
						samples.Add(iris);
					}

					DimensionItem dim1 = new DimensionItem()
					{
						Label = "sepal length",

						Values = samples.Select(iris => iris.SepalLength).ToArray(),
					};

					DimensionItem dim2 = new DimensionItem()
					{
						Label = "sepal width",

						Values = samples.Select(iris => iris.SepalWidth).ToArray(),
					};

					DimensionItem dim3 = new DimensionItem()
					{
						Label = "petal length",

						Values = samples.Select(iris => iris.PetalLength).ToArray(),

					};

					DimensionItem dim4 = new DimensionItem()
					{
						Label = "petal width",

						Values = samples.Select(iris => iris.PetalWidth).ToArray(),

					};

					ItemList<DimensionItem> dimensions = new ItemList<DimensionItem>();
					dimensions.Add(dim1);
					dimensions.Add(dim2);
					dimensions.Add(dim3);
					dimensions.Add(dim4);

					SplomTrace trace = new SplomTrace()
					{

						Dimensions = dimensions,

						Marker = new MarkerInfo()
						{
							Color = samples.Select(iris => ColorLookup(iris.IrisClass)).ToArray(),
							ColorScale = new object[]
							{
									new object[]{0.0, "#19d3f3" },
									new object[]{0.333, "#19d3f3" },
									new object[]{0.333, "#e763fa" },
									new object[]{0.666, "#e763fa" },
									new object[]{0.666, "#636efa" },
									new object[]{ 1, "#636efa" },
							},
							Line = new LineInfo()
							{
								Color = "white",
								Width = 0.5
							},
							Size = 7

						},

						Text = samples.Select(iris => iris.IrisClass).ToArray(),
					};

					TraceList dataTraces = new TraceList(trace);

					AxisInfo axis = new AxisInfo()
					{
						ShowLine = false,
						ZeroLine = false,
						GridColor = "#fff",
						Ticklen = 4

					};

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Iris Dataset" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						HoverMode = HoverModeOptions.Closest,
						DragMode = DragModeOptions.Select,
						PlotBgColor = "rgba(240, 240, 240, 0.95)"



					};
					// badly flawed architecture by plotly
					(layout.ValueItems as dynamic).xaxis = axis.ValueItems;
					(layout.ValueItems as dynamic).xaxis2 = axis.ValueItems;
					(layout.ValueItems as dynamic).xaxis3 = axis.ValueItems;
					(layout.ValueItems as dynamic).xaxis4 = axis.ValueItems;
					(layout.ValueItems as dynamic).yaxis = axis.ValueItems;
					(layout.ValueItems as dynamic).yaxis2 = axis.ValueItems;
					(layout.ValueItems as dynamic).yaxis3 = axis.ValueItems;
					(layout.ValueItems as dynamic).yaxis4 = axis.ValueItems;


					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void ViolinChart()
		{
			//https://plotly.com/javascript/violin/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/violin_data.csv");

				if (fileText != null)
				{
					List<DinnerSample> samples = new List<DinnerSample>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						DinnerSample meal = new DinnerSample()
						{
							TotalBill = Convert.ToDouble(values[0]),
							Tip = Convert.ToDouble(values[1]),
							Sex = values[2],
							Smoker = values[3],
							Day = values[4],
							Time = values[5],
							Size = Convert.ToInt32(values[6])


						};
						samples.Add(meal);
					}

					ViolinTrace traceYes = new ViolinTrace()
					{
						X = samples.Select(meal => meal.Day).ToArray(),
						Y = samples.Select(meal => meal.TotalBill).ToArray(),
						LegendGroup = "Yes",
						ScaleGroup = "Yes",
						Name = "Yes",
						Side = DensitySideOptions.Negative,
						Box = new BoxInfo() { Visible = true },
						Line = new LineInfo() { Color = "blue", Width = 2 },
						MeanLine = new LineInfo() { }
					};

					ViolinTrace traceNo = new ViolinTrace()
					{
						X = samples.Select(meal => meal.Day).ToArray(),
						Y = samples.Select(meal => meal.TotalBill).ToArray(),
						LegendGroup = "No",
						ScaleGroup = "No",
						Name = "No",
						Side = DensitySideOptions.Positive,
						Box = new BoxInfo() { Visible = true },
						Line = new LineInfo() { Color = "green", Width = 2 },
						MeanLine = new LineInfo() { }
					};

					TraceList dataTraces = new TraceList(new[] { traceYes, traceNo });

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Split Violin Plot" },
						Height = plotHeight,
						Width = plotWidth,
						YAxis = new AxisInfo() { ZeroLine = false },
						ViolinGap = 0,
						ViolinGroupGap = 0,
						ViolinMode = ViolinModeOptions.Overlay
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void ConeChart()
		{
			//https://plotly.com/javascript/cone-plot/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/vortex.csv");

				if (fileText != null)
				{

					List<Vector> VectorList = new List<Vector>();

					string[] rows = fileText.Split("\n".ToCharArray());
					for (int i = 1; i < rows.Length; i++)
					{

						string[] values = rows[i].Split(",");

						if (values.Length < 6)
							continue;
						Vector vector = new Vector()
						{
							
							x = Convert.ToDouble(values[0]),
							y = Convert.ToDouble(values[1]),
							z = Convert.ToDouble(values[2]),
							u = Convert.ToDouble(values[3]),
							v = Convert.ToDouble(values[4]),
							w = Convert.ToDouble(values[5])
						};

						VectorList.Add(vector);
					}


					ConeTrace trace = new Traces.ConeTrace()
					{
						X = VectorList.Select(vec => vec.x).ToArray(),
						Y = VectorList.Select(vec => vec.y).ToArray(),
						Z = VectorList.Select(vec => vec.z).ToArray(),
						U = VectorList.Select(vec => vec.u).ToArray(),
						V = VectorList.Select(vec => vec.v).ToArray(),
						W = VectorList.Select(vec => vec.w).ToArray(),
						AutoColorScale = false,
						ColorScale  =  ColorScaleOptions.Blues.GetDescription(),
						SizeMode = SizeModeOptions.Absolute,
						SizeRef = 40
					};

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Cone Vector Plot" },
						
						Width = plotWidth,
						Height = plotHeight,
						Scene = new SceneInfo()
						{
							AspectRatio = new AspectRatioInfo()
							{
								X = 1.0,
								Y = 1.0,
								Z = 0.8
							},
							Camera = new CameraInfo()
							{
								Eye = new PositionInfo() { X = 1.2, Y = 1.2, Z = 0.6 }
							}
						},

					};

					TraceList dataTraces = new TraceList( trace );

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void IsoSurface3DChart()
		{

		 // https://plotly.com/javascript/3d-isosurface-plots/
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/clebsch-cubic.csv");

				if (fileText != null)
				{
					List<Line3D1> lines = new List<Line3D1>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						Line3D1 line = new Line3D1()
						{
							row = Convert.ToInt32(values[0]),
							x1 = Convert.ToDouble(values[1]),
							y1 = Convert.ToDouble(values[2]),
							z1 = Convert.ToDouble(values[3]),
							value = Convert.ToDouble(values[4])
						};
						lines.Add(line);
					}

					IsoSurfaceTrace trace1 = new IsoSurfaceTrace()
					{
						X = lines.Select(item => item.x1).ToArray(),
						Y = lines.Select(item => item.y1).ToArray(),
						Z = lines.Select(item => item.z1).ToArray(),
						Value = lines.Select(item => item.value).ToArray(),
						IsoMin = -100,
						IsoMax = 100,
						Surface = new SurfaceInfo { Show = true, Count = 1, Fill = 0.8 },
						Slices = new SlicesInfo
						{
							Z = new SliceRenderInfo()
							{
								Show = true,
								Locations = new double[] { -0.3, 0.5 },
							}
						},
						Caps = new CapsInfo()
						{
							X = new CapRenderInfo { Show = false },
							Y = new CapRenderInfo { Show = false },
							Z = new CapRenderInfo { Show = false }
						}



					};

					TraceList dataTraces = new TraceList(new[] { trace1 });

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "3D Line Plot" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						Scene = new SceneInfo()
						{
							Camera = new CameraInfo()
							{
								Eye = new PositionInfo() { X = 1.87, Y = 0.61, Z = 0.98 }
							}
						},
						Margin = new MarginInfo()
						{
							Left = 0,
							Bottom = 0,
							Top = 0
						}
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



		public async void Line3DChart()
		{
			// https://plotly.com/javascript/3d-line-plots/
			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/_3d-line-plot.csv");

				if (fileText != null)
				{
					List<Line3D3> lines = new List<Line3D3>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						Line3D3 line = new Line3D3()
						{
							x1 = Convert.ToDouble(values[0]),
							y1 = Convert.ToDouble(values[1]),
							z1 = Convert.ToDouble(values[2]),
							x2 = Convert.ToDouble(values[3]),
							y2 = Convert.ToDouble(values[4]),
							z2 = Convert.ToDouble(values[5]),
							x3 = Convert.ToDouble(values[6]),
							y3 = Convert.ToDouble(values[7]),
							z3 = Convert.ToDouble(values[8])
						};
						lines.Add(line);
					}

					Scatter3DTrace trace1 = new Scatter3DTrace()
					{
						X = lines.Select(item => item.x1).ToArray(),
						Y = lines.Select(item => item.y1).ToArray(),
						Z = lines.Select(item => item.z1).ToArray(),
						Marker = new MarkerInfo()
						{
							Color = "#1f77b4",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineInfo()
							{
								Color = "rgb(0,0,0)",
								Width = 0

							}
						}
				,
						Mode = ModeOptions.Lines,
						Line = new LineInfo()
						{
							Color = "#1f77b4",
							Width = 1
						}

					};

					Scatter3DTrace trace2 = new Scatter3DTrace()
					{
						X = lines.Select(item => item.x2).ToArray(),
						Y = lines.Select(item => item.y2).ToArray(),
						Z = lines.Select(item => item.z2).ToArray(),
						Marker = new MarkerInfo()
						{
							Color = "#9467bd",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineInfo()
							{
								Color = "rgb(0,0,0)",
								Width = 0

							}
						}
				,
						Mode = ModeOptions.Lines,
						Line = new LineInfo()
						{
							Color = "rgb(44, 160, 44)",
							Width = 1
						}

					};

					Scatter3DTrace trace3 = new Scatter3DTrace()
					{
						X = lines.Select(item => item.x3).ToArray(),
						Y = lines.Select(item => item.y3).ToArray(),
						Z = lines.Select(item => item.z3).ToArray(),
						Marker = new MarkerInfo()
						{
							Color = "#bcbd22",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineInfo()
							{
								Color = "rgb(0,0,0)",
								Width = 0

							}
						}
				,
						Mode = ModeOptions.Lines,
						Line = new LineInfo()
						{
							Color = "#bcbd22",
							Width = 1
						}

					};



					TraceList dataTraces = new TraceList(new[] { trace1, trace2, trace3 });

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "3D Line Plot" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						Margin = new MarginInfo()
						{
							Left = 0,
							Right = 0,
							Bottom = 0,
							Top = 65
						}
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void Scatter3DChart()
		{
			//https://plotly.com/javascript/3d-scatter-plots/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/3d-scatter.csv");

				if (fileText != null)
				{
					List<Line3D2> lines = new List<Line3D2>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty || i == 0)
						{
							continue;
						}
						string[] values = rows[i].Split(",");

						Line3D2 line = new Line3D2()
						{
							x1 = Convert.ToDouble(values[0]),
							y1 = Convert.ToDouble(values[1]),
							z1 = Convert.ToDouble(values[2]),
							x2 = values[3],
							y2 = values[4],
							z2 = values[5],

						};
						lines.Add(line);
					}

					Scatter3DTrace trace1 = new Scatter3DTrace()
					{
						X = lines.Select(item => item.x1).ToArray(),
						Y = lines.Select(item => item.y1).ToArray(),
						Z = lines.Select(item => item.z1).ToArray(),
						Marker = new MarkerInfo()
						{
							Color = "#1f77b4",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineInfo()
							{
								Color = "rgba(217, 217, 217, 0.14)",
								Width = 0.5

							},
							Opacity = 0.8
						}
				,
						Mode = ModeOptions.Markers


					};

					var trace2lines = from item in lines where item.x2 != string.Empty select item;

					Scatter3DTrace trace2 = new Scatter3DTrace()
					{
						X = trace2lines.Select(item => item.x2).ToArray(),
						Y = trace2lines.Select(item => item.y2).ToArray(),
						Z = trace2lines.Select(item => item.z2).ToArray(),
						Marker = new MarkerInfo()
						{
							Color = "#9467bd",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineInfo()
							{
								Color = "rgba(217, 217, 217, 0.14)",
								Width = 0.5
							},
							Opacity = 0.8

						}
				,
						Mode = ModeOptions.Markers

					};




					TraceList dataTraces = new TraceList(new[] { trace1, trace2 });

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "3D Line Plot" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						Margin = new MarginInfo()
						{
							Left = 0,
							Right = 0,
							Bottom = 0,
							Top = 0
						},
						ShowLegend = false
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}


		public async void StreamTubeChart()
		{
			//https://plotly.com/javascript/streamtube-plot/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/streamtube-wind.csv");


				if (fileText != null)
				{

					List<Vector> Winds = new List<Vector>();

					string[] rows = fileText.Split("\n".ToCharArray());
					for (int i = 1; i < rows.Length; i++)
					{					
						
						string[] values = rows[i].Split(",");

						if (values.Length < 7)
							continue;
						Vector wind = new Vector()
						{
							row = values[0],							
							u = Convert.ToDouble(values[1]),
							v = Convert.ToDouble(values[2]),
							w = Convert.ToDouble(values[3]),
							x = Convert.ToDouble(values[4]),
							y = Convert.ToDouble(values[5]),
							z = Convert.ToDouble(values[6])
						};

						Winds.Add(wind);
					}


					StreamTubeTrace trace = new StreamTubeTrace()
					{
						X = Winds.Select(wind => wind.x).ToArray(),
						Y = Winds.Select(wind => wind.y).ToArray(),
						Z = Winds.Select(wind => wind.z).ToArray(),
						U = Winds.Select(wind => wind.u).ToArray(),
						V = Winds.Select(wind => wind.v).ToArray(),
						W = Winds.Select(wind => wind.w).ToArray(),
						SizeRef = 0.3,
						AutoColorScale = false,
						ColorScale = ColorScaleOptions.Blues.GetDescription(),
						ShowScale = false,
						MaxDisplayed = 3000,
						Starts = new PositionInfo()
						{
							X = new int[] { 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80 },
							Y = new int[] { 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50 },
							Z = new int[] { 0, 0, 0, 0, 5, 5, 5, 5, 10, 10, 10, 10, 15, 15, 15, 15 }
						},
						Opacity=0.8

					};


					LayoutInfo layout = new LayoutInfo()
					{
						Scene = new SceneInfo()
						{
							
							AspectRatio = new AspectRatioInfo()
							{
								X = 2,
								Y = 1,
								Z = 0.3
							}
						},
						Width = plotWidth,
						Height = plotHeight,
						Margin = new MarginInfo()
						{
							Left = 20,
							Right = 20,
							Bottom = 20,
							Top = 20
						}
					};


					TraceList dataTraces = new TraceList(trace);



					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}


		public async void Surface3DChart()
		{
			// https://plotly.com/javascript/3d-surface-plots/

			if (Webfile != null)
			{
				string? fileText = await Webfile.DownloadText("https://raw.githubusercontent.com/plotly/datasets/master/api_docs/mt_bruno_elevation.csv");


				if (fileText != null)
				{

					List<object[]> z_data = new List<object[]>();

					string[] rows = fileText.Split("\n".ToCharArray());

					for (int i = 0; i < rows.Length; i++)
					{
						if (rows[i] == String.Empty)
						{
							continue;
						}
						string[] values = rows[i].Split(",");
						List<string> items = new List<string>();
						for (int j = 0; j < values.Length; j++)
						{

							items.Add(values[j]);

						}
						z_data.Add(items.ToArray());
					}

					SurfaceTrace trace = new SurfaceTrace()
					{
						Z = z_data,
						Contours = new Contours3DInfo()
						{
							Z = new Contour3DLineInfo()
							{
								Show = true,
								UseColorMap = true,
								HighlightColor = "#42f462",
								Project = new ProjectInfo()
								{
									Z = true
								}
							}
						}
					};

					LayoutInfo layout = new LayoutInfo()
					{
						Title = new TitleInfo() { Text = "Mt Bruno Elevation With Projected Contours" },

						Scene = new SceneInfo()
						{
							Camera = new CameraInfo()
							{
								Eye = new PositionInfo() { X = 1.87, Y = 0.88, Z = -0.64 }
							}
						},
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						Margin = new MarginInfo()
						{
							Left = 65,
							Right = 50,
							Bottom = 65,
							Top = 90
						}


					};

					TraceList dataTraces = new TraceList(trace);



					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}

		public async void VolumeChart()
        {
			//https://metacpan.org/pod/Chart::Plotly::Trace::Volume

			//https://plotly.com/python/3d-volume-plots/

			VolumeTrace trace = new Traces.VolumeTrace()
			{
				AutoColorScale = false,
				Caps = new CapsInfo()
				{
					X = new CapRenderInfo() { Show = true },
					Y = new CapRenderInfo() { Show = true },
					Z = new CapRenderInfo() { Show = true }
				},
				ColorScale = new object[] { new object[] { 0.0, "rgb(0,0,255)" }, new object[] { 0.5, "rgb(255,255,255)" }, new object[] { 0.75, "rgb(255,255,0)" }, new object[] { 0.875, "rgb(255,0,0)" }, new object[] { 1.0, "rgb(127,127,127)}" } },
				Contour = new ContourInfo() { Width=4, Show=true},
				FlatShading = true,
				Opacity = 0.05,
				OpacityScale = new Object[] { new double[] { 0, 1.0 }, new double[] { 0.2, 0.9 }, new double[] { 0.3, 0.5 }, new double[] { 0.4, 0.4 }, new double[] { 0.5, 0.5 }, new double[] { 1, 1.0 } },
				Lighting = new LightingInfo() { FaceNormalsEpsilon=0},
				ReverseScale = true,
				Slices = new SlicesInfo()
				{
					X = new SliceRenderInfo() { Show = true },
					Y = new SliceRenderInfo() { Show = true },
					Z = new SliceRenderInfo() { Show = true }
				},
				SpaceFrame = new SpaceFrameInfo() { Fill=1, Show = true},
				Surface = new SurfaceInfo() { Show=true, Fill=1, Pattern= Enumerations.TracesEnums.PatternOptions.All, Count=25},
				Value = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.Value,
				X = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.X,
				Y = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.Y,
				Z = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.Z,
			};

			TraceList dataTraces = new TraceList(trace);

			LayoutInfo layout = new LayoutInfo()
			{
				Title = new TitleInfo() { Text = "volume airflow model" },
				
				Width = plotWidth,
				Height = plotHeight,
			
				Margin = new MarginInfo() { Pad=50},
				Scene = new SceneInfo()
				{
					AspectRatio = new AspectRatioInfo()
					{
						X = 1,
						Y = 1,
						Z = 1
					},
					XAxis = new AxisInfo() { NTicks = 12 },
					YAxis = new AxisInfo() { NTicks = 12 },
					ZAxis = new AxisInfo() { NTicks = 12 },
					Camera = new CameraInfo()
					{
						Center = new CenterInfo()
						{
							X = 0,
							Y = 0,
							Z = 0
						},
						Eye = new PositionInfo()
						{
							X = 1.75,
							Y = 0.2,
							Z = 0.35
						}

					}
				}

			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}
	

	
	}
}


