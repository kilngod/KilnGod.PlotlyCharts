//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyScientific.razor.cs
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
    public partial class PlotlyScientific : DemoBaseComponent
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
        /// Contour chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/contour-plots/
        /// </summary>
        public async void ContourChart()
		{
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

			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Smooth Contour Coloring" },
				Height = plotHeight,
				Width = plotWidth
			};
		
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// ContourCarpet chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/carpet-contour/
        /// </summary>
        public async void ContourCarpetChart()
		{
			
			ContourCarpetTrace trace1 = new ContourCarpetTrace()
			{
				A = new double[] { 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 },
				B = new double[] { 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6 },
				Z = new double[] { 1, 1.96, 2.56, 3.0625, 4, 5.0625, 1, 7.5625, 9, 12.25, 15.21, 14.0625 },
				AutoContour = false,
				Contours = new ContoursInfo() { Start = 1, End = 14, Size = 1 },
				Line = new LineColorDashSmoothingWidthInfo() { Width = 2, Smoothing = 0 },
				ColorBar = new ColorBarInfo() { Len = 0.4, Y = 0.25 }

			};

			CarpetTrace trace2 = new CarpetTrace()
			{
				A = new double[] { 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3 },
				B = new double[] { 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6 },
				X = new double[] { 2, 3, 4, 5, 2.2, 3.1, 4.1, 5.1, 1.5, 2.5, 3.5, 4.5 },
				Y = new double[] { 1, 1.4, 1.6, 1.75, 2, 2.5, 2.7, 2.75, 3, 3.5, 3.7, 3.75 },
				AAxis = new CarpetAxisInfo() { TickPrefix = "a = ", Smoothing = 0, Type = AutoDateCategoryLinearTypeOptions.Linear, MinorGridCount = 9 },
				BAxis = new CarpetAxisInfo() { TickPrefix = "b = ", Smoothing = 0, Type = AutoDateCategoryLinearTypeOptions.Linear, MinorGridCount = 9 }

			};



			TraceList dataTraces = new TraceList(trace1);
			dataTraces.AddTrace(trace2);

			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Cheater plot with 1d input" },
				Margin = new MarginInfo() { T = 40, R = 30, B = 30, L = 30 },
				YAxis = new LayoutYAxisInfo() { Range = new double[] { 0.388, 4.361 } },
				XAxis = new LayoutAxisInfo() { Range = new double[] { 0.667, 5.932 } },
				Height = plotHeight,
				Width = plotWidth
			};


			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}


        /// <summary>
        /// Heatmap chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/heatmaps/
        /// </summary>
        public async void HeatmapChart()
		{
			
			TraceList dataTraces = new TraceList(new HeatmapTrace()
			{
				X = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
				Y = new string[] { "Morning", "Afternoon", "Evening" },
				Z = new object[] { new object?[] { 1, null, 30, 50, 1 }, new object[] { 20, 1, 60, 80, 30 }, new object[] { 30, 60, 1, -10, 20 } },

				HoverOnGaps = false
			});


			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
		}




        /// <summary>
        /// ParallelCoordinate chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/parallel-coordinates-plot/
        /// </summary>
        public async void ParallelCoordinateChart()
		{

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

					ItemList<ParCoordsDimensionItem> dimensions = new ItemList<ParCoordsDimensionItem>(
						new ParCoordsDimensionItem[] {
							new ParCoordsDimensionItem()
							{ 
								ConstraintRange = new object[] { 100000, 150000 },
								Range = new object[] { 32000, 227900 },
								Label = "Block height",
								Values = blockList.Select(block => block.blockHeight).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] { 0, 700000 },
								Label = "Block width",
								Values = blockList.Select(block => block.blockWidth).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								TickVals = new double[]{0, 0.5, 1, 2, 3},
								TickText = new string[]{"A", "AB", "B", "Y", "Z"},
								Label = "Cylinder material",
								Values = blockList.Select(block => block.blockWidth).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] { -1, 4 },
								TickVals = new double[]{0, 1, 2, 3},
								Label = "Block material",
								Values = blockList.Select(block => block.blockMaterial).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] {134, 3154 },
								Label = "Total weight",
								Visible = true,
								Values = blockList.Select(block => block.totalWeight).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] { 9, 19984 },
								Label = "Assembly penalty weight",
								Values = blockList.Select(block => block.assemblyPW).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] { 49000, 568000 },
								Label = "Height st width",
								Values = blockList.Select(block => block.HstW).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] {-28000, 196430 },
								Label = "Min height width",
								Values = blockList.Select(block => block.minHW).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] {98453, 501789 },
								Label = "Min width diameter",
								Values = blockList.Select(block => block.minWD).ToArray()
							},
							new ParCoordsDimensionItem()
							{
								Range = new object[] { 1417, 107154 },
								Label = "RF block",
								Values = blockList.Select(block => block.rfBlock).ToArray()
							}

						}
					);

					ParallelCoordinatesTrace trace = new ParallelCoordinatesTrace()
					{
						Dimensions = dimensions,
						Line = new LineParCoordsInfo()
						{
							ShowScale = true,
							ReverseScale = true,
							ColorScale = ColorScaleOptions.Jet.GetDescription(),
							CMin = -4000,
							CMax = -100,
							Color = blockList.Select(block => block.colorVal).ToArray()
						}
					};

					TraceList dataTraces = new TraceList(trace);

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "Parallel Coordinate Chart" },
						ShowLegend = false,
						Height = plotHeight,
						Width = plotWidth,
						Margin = new MarginInfo() { L = 50, R = 0, T= 250, B = 250 }
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// Polar chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/polar-chart/
        /// </summary>
        public async void PolarChart()
		{
			
			ScatterPolarTrace polar1 = new ScatterPolarTrace()
			{
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
				R = new double[] { 0, 1.5, 1.5, 0, 2.5, 2.5, 0 },
				Theta = new double[] { 0, 10, 25, 0, 205, 215, 0 },
				Line = new LineColorDashShapeSmoothingWidthInfo() { Color = "black" },
				Fill = FillPolarOptions.ToSelf,
				FillColor = "#709BFF"
			};

			ScatterPolarTrace polar2 = new ScatterPolarTrace()
			{
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
				R = new double[] { 0, 3.5, 3.5, 0 },
				Theta = new double[] { 0, 55, 75, 0 },
				Line = new LineColorDashShapeSmoothingWidthInfo() { Color = "black" },
				Fill = FillPolarOptions.ToSelf,
				FillColor = "#E4FF87"
			};
			ScatterPolarTrace polar3 = new ScatterPolarTrace()
			{
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
				R = new double[] { 0, 4.5, 4.5, 0, 4.5, 4.5, 0 },
				Theta = new double[] { 0, 100, 120, 0, 305, 320, 0 },
				Line = new LineColorDashShapeSmoothingWidthInfo() { Color = "black" },
				Fill = FillPolarOptions.ToSelf,
				FillColor = "#FFAA70"
			};
			ScatterPolarTrace polar4 = new ScatterPolarTrace()
			{
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
				R = new double[] { 0, 4, 4, 0 },
				Theta = new double[] { 0, 4.5, 4.5, 0, 4.5, 4.5, 0 },
				Line = new LineColorDashShapeSmoothingWidthInfo() { Color = "black" },
				Fill = FillPolarOptions.ToSelf,
				FillColor = "#FFDF70"
			};
			ScatterPolarTrace polar5 = new ScatterPolarTrace()
			{
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
				R = new double[] { 0, 3, 3, 0 },
				Theta = new double[] { 0, 262.5, 277.5, 0 },
				Line = new LineColorDashShapeSmoothingWidthInfo() { Color = "black" },
				Fill = FillPolarOptions.ToSelf,
				FillColor = "#B6FFB4"
			};

			TraceList dataTraces = new TraceList(new Trace[] { polar1, polar2, polar3, polar4, polar5 });

			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Polar Chart" },
				Polar = new PolarInfo() { RadialAxis = new RadialAxisInfo() { Visible = true, Range = new double[] { 0, 5 } } },
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
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
                                    mix.Clay = Convert.ToInt32(clay.ToString());
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
                    for (int i = 0; i < soilList.Count; i++)
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
                            X = 0.15,
                            Y = 1.1
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
        /// ScatterCarpet chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/carpet-scatter/
        /// </summary>
        public async void ScatterCarpetChart()
		{
			
			CarpetTrace trace1 = new CarpetTrace()
			{
				A = new double[] { 4e-6, 4e-6, 4e-6, 4.5e-6, 4.5e-6, 4.5e-6, 5e-6, 5e-6, 5e-6, 6e-6, 6e-6, 6e-6 },
				B = new double[] { 1e6, 2e6, 3e6, 1e6, 2e6, 3e6, 1e6, 2e6, 3e6, 1e6, 2e6, 3e6 },
				Y = new double[] { 2, 3.5, 4, 3, 4.5, 5, 5.5, 6.5, 7.5, 8, 8.5, 10 },
				AAxis = new CarpetAxisInfo() { TickPrefix = "a = ", TickSuffix = "m", Smoothing = 1, MinorGridCount = 9 },
				BAxis = new CarpetAxisInfo() { TickPrefix = "b = ", TickSuffix = "Pa", Smoothing = 1, MinorGridCount = 9 }
			};

			ScatterCarpetTrace trace2 = new ScatterCarpetTrace()
			{
				A = new double[] { 4e-6, 4.5e-6, 5e-6, 6e-6 },
				B = new double[] { 1.5e6, 2.5e6, 1.5e6, 2.5e6 },
				Line = new LineColorDashShapeSmoothingWidthInfo() { Smoothing = 1, Shape = ShapeLineScatterBasicOptions.Spline }
			};

			TraceList dataTraces = new TraceList(trace1);
			dataTraces.AddTrace(trace2);


			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);


		}



        /// <summary>
        /// ScatterSmith chart sample from plotly website in C#.
		///
		/// https://plotly.com/python/smith-charts/
        /// </summary>
        public async void ScatterSmithChart()
        {
			
			ScatterSmithTrace trace = new ScatterSmithTrace()
			{
				Real = new double[] { 0.5, 1, 2, 3 },
				Imaginary = new double[] { 0.5, 1, 2, 3 }
			};

			TraceList dataTraces = new TraceList(trace);

			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
		}




        /// <summary>
        /// Ternary chart sample from plotly website in C#.
        ///
        /// https://plotly.com/javascript/ternary-plots/
        /// </summary>
        public async void TernaryChart()
		{
			
			ScatterTernaryTrace trace = new ScatterTernaryTrace()
			{
				A = new double[] { 75, 70, 75, 5, 10, 10, 20, 10, 15, 10, 20 },
				B = new double[] { 25, 10, 20, 60, 80, 90, 70, 20, 5, 10, 10 },
				C = new double[] { 0, 20, 50, 35, 10, 0, 10, 70, 80, 80, 70 },
				Text = new string[] { "point 1", "point 2", "point 3", "point 4", "point 5", "point 6", "point 7", "point 8", "point 9", "point 10", "point 11" },
				Marker = new MarkerScatterInfo() { Size = 14, Line = new LineMarkerInfo() { Width = 2, Color = "DB7365" }, Symbol = SymbolOptions.CircleOpen },
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Markers }
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

			Layout layout = new Layout()
			{
				Ternary = new TernaryInfo()
				{
					Sum = 100,
					AAxis = new TernaryAxisInfo()
					{
						Title = new TitleTernaryAxisInfo() { Text = "Journalist", Font = new FontInfo() { Size = 20 } },
						TickAngle = 0,
						TickFont = new TickFontInfo() { Size = 15 },
						TickColor = "black",
						TickLen = 5,
						ShowGrid = true,
						ShowLine = true

					},
					BAxis = new TernaryAxisInfo()
					{
						Title = new TitleTernaryAxisInfo() { Text = "<br>Developer", Font = new FontInfo() { Size = 20 } },
						TickAngle = 45,
						TickFont = new TickFontInfo() { Size = 15 },
						TickColor = "black",
						TickLen = 5,
						ShowGrid = true,
						ShowLine = true

					},
					CAxis = new TernaryAxisInfo()
					{
						Title = new TitleTernaryAxisInfo() { Text = "<br>Designer", Font = new FontInfo() { Size = 20 } },
						TickAngle = -45,
						TickFont = new TickFontInfo() { Size = 15 },
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




	
	}
}


