//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Plotly3DCharts.razor.cs
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
    public partial class Plotly3DCharts
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
        /// Cone chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/cone-plot/
        /// </summary>
        public async void ConeChart()
		{

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
						SizeMode = SizeModeConeOptions.Absolute,
						SizeRef = 40
					};

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "Cone Vector Plot" },
						
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




        /// <summary>
        /// ISOSurfaceChart chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/3d-isosurface-plots/
        /// </summary>
        public async void IsoSurface3DChart()
		{
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
							Z = new SliceInfo()
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

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "3D Line Plot" },
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
							L = 0,
							B = 0,
							T = 0
						}
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// Line3D chart sample from plotly website in C#.
        ///
        /// https://plotly.com/javascript/3d-line-plots/
        /// </summary>
        public async void Line3DChart()
		{		
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
						Marker = new MarkerScatter3DInfo()
						{
							Color = "#1f77b4",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineMarkerInfo()
							{
								Color = "rgb(0,0,0)",
								Width = 0

							}
						}
				,
						Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
						Line = new LineScatter3DInfo()
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
						Marker = new MarkerScatter3DInfo()
						{
							Color = "#9467bd",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineMarkerInfo()
							{
								Color = "rgb(0,0,0)",
								Width = 0

							}
						}
				,
						Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
						Line = new LineScatter3DInfo()
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
						Marker = new MarkerScatter3DInfo()
						{
							Color = "#bcbd22",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineMarkerInfo()
							{
								Color = "rgb(0,0,0)",
								Width = 0

							}
						}
				,
						Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
						Line = new LineScatter3DInfo()
						{
							Color = "#bcbd22",
							Width = 1
						}

					};

					TraceList dataTraces = new TraceList(new[] { trace1, trace2, trace3 });

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "3D Line Plot" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						Margin = new MarginInfo()
						{
							L = 0,
							R = 0,
							B = 0,
							T = 65
						}
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// Scatter 3D chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/3d-scatter-plots/
        /// </summary>
        public async void Scatter3DChart()
		{
			
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
						Marker = new MarkerScatter3DInfo()
						{
							Color = "#1f77b4",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineMarkerInfo()
							{
								Color = "rgba(217, 217, 217, 0.14)",
								Width = 0.5

							},
							Opacity = 0.8
						}
				,
						Mode = new ModeScatterOptions[] { ModeScatterOptions.Markers }
					};

					var trace2lines = from item in lines where item.x2 != string.Empty select item;

					Scatter3DTrace trace2 = new Scatter3DTrace()
					{
						X = trace2lines.Select(item => item.x2).ToArray(),
						Y = trace2lines.Select(item => item.y2).ToArray(),
						Z = trace2lines.Select(item => item.z2).ToArray(),
						Marker = new MarkerScatter3DInfo()
						{
							Color = "#9467bd",
							Size = 12,
							Symbol = SymbolOptions.Circle,
							Line = new LineMarkerInfo()
							{
								Color = "rgba(217, 217, 217, 0.14)",
								Width = 0.5
							},
							Opacity = 0.8

						},
						Mode = new ModeScatterOptions[] { ModeScatterOptions.Markers }
					};

					TraceList dataTraces = new TraceList(new[] { trace1, trace2 });

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "3D Line Plot" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						Margin = new MarginInfo()
						{
							L = 0,
							R = 0,
							B = 0,
							T = 0
						},
						ShowLegend = false
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}




        /// <summary>
        /// SteamTube chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/streamtube-plot/
        /// </summary>
        public async void StreamTubeChart()
		{
			
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
						Starts = new StartsInfo()
						{
							X = new int[] { 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80 },
							Y = new int[] { 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50, 20, 30, 40, 50 },
							Z = new int[] { 0, 0, 0, 0, 5, 5, 5, 5, 10, 10, 10, 10, 15, 15, 15, 15 }
						},
						Opacity=0.8

					};


					Layout layout = new Layout()
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
							L = 20,
							R = 20,
							B = 20,
							T = 20
						}
					};


					TraceList dataTraces = new TraceList(trace);

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// 3DSurface chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/3d-surface-plots/
        /// </summary>
        public async void Surface3DChart()
		{
			
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
						Contours = new SurfaceContoursInfo()
						{
							Z = new ContoursRenderInfo()
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

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "Mt Bruno Elevation With Projected Contours" },

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
							L = 65,
							R = 50,
							B = 65,
							T = 90
						}


					};

					TraceList dataTraces = new TraceList(trace);



					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



        /// <summary>
        /// Volume chart sample from plotly website in C#.
		///
		/// https://plotly.com/python/3d-volume-plots/
		/// https://metacpan.org/pod/Chart::Plotly::Trace::Volume
        /// </summary>
        public async void VolumeChart()
        {
			
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
				Lighting = new SurfaceLightingInfo() {  FaceNormalsEpsilon=0},
				ReverseScale = true,
				Slices = new SlicesInfo()
				{
					X = new SliceInfo() { Show = true },
					Y = new SliceInfo() { Show = true },
					Z = new SliceInfo() { Show = true }
				},
				Spaceframe = new SpaceframeInfo() { Fill=1, Show = true},
				Surface = new SurfaceInfo() { Show=true, Fill=1, Pattern= new SurfacePatternOptions[] { SurfacePatternOptions.A }, Count=25},
				Value = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.Value,
				X = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.X,
				Y = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.Y,
				Z = KilnGod.PlotlyCharts.DemoTest.Data.VolumeData.Z,
			};

			TraceList dataTraces = new TraceList(trace);

			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "volume airflow model" },
				
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
					XAxis = new SceneAxisInfo() { NTicks = 12 },
					YAxis = new SceneYAxisInfo() { NTicks = 12 },
					ZAxis = new SceneAxisInfo() { NTicks = 12 },
					Camera = new CameraInfo()
					{
						Center = new CameraCenterInfo()
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


