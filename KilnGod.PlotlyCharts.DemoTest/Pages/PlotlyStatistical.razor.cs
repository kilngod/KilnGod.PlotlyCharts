//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyStatistical.razor.cs
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
    public partial class PlotlyStatistical : DemoBaseComponent
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
        /// Box chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/box-plots/
        /// </summary>
        public async void BoxChart()
		{
			
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
					Marker = new MarkerBoxInfo() { Size = 2 },
					Line = new LineColorWidthInfo() { Width = 1 }

				};

				dataTraces.AddTrace(box);
			}

			BoxLayout layout = new BoxLayout()
			{
				Title = new TitleLayoutInfo() { Text = "Points Scored by the Top 9 Scoring NBA Players in 2012" },
				YAxis = new LayoutYAxisInfo()
				{
					AutoRange = AutoRangeOptions.True,
					ShowGrid = true,
					ZeroLine = true,
					DTick = 5,
					GridColor = "rgb(255, 255, 255)",
					GridWidth = 1,
					ZeroLineColor = "rgb(255, 255, 255)",
					ZeroLineWidth = 2
				},
				Margin = new MarginInfo() { L = 40, R = 30, B = 80, T = 100 },
				PaperBgColor = "rgb(243, 243, 243)",
				PlotBgColor = "rgb(243, 243, 243)",
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}


        private static System.Random random = new System.Random();

        /// <summary>
        /// Random double generator
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static double NextDouble(double min, double max)
		{ 
			double val = (random.NextDouble() * (max - min) + min);
			return val;
		}

		/// <summary>
		/// Random double[] generator
		/// </summary>
		/// <param name="num"></param>
		/// <param name="mul"></param>
		/// <returns></returns>
        public double[] BoxRandom(int num, double mul)
        {
            double[] result = new double[num];
            for (int i = 0; i < num; i++)
            {
                result[i] = random.NextDouble() * mul;

            }
            return result;
        }



        /// <summary>
        /// Histogram chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/histograms/
        /// </summary>
        public async void Histogram()
		{
		
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
				Marker = new MarkerHistogramInfo() { Color = "rgba(255, 100, 102, 0.7)", Line = new LineMarkerInfo() { Color = "rgba(255, 100, 102, 1)", Width = 1 } },
				Opacity = 0.5,
				XBins = new BinsInfo() { End = 2.8, Size = 0.06, Start = 0.5 }
			};

			HistogramTrace trace2 = new HistogramTrace()
			{
				X = x2,
				Y = y2,
				Name = "experiment",
				AutoBinX = false,
				Marker = new MarkerHistogramInfo()
				{
					Color = "rgba(100, 200, 102, 0.7)",
					Line = new LineMarkerInfo() { Color = "rgba(100, 200, 102, 1)", Width = 1 }
				},
				Opacity = 0.5,
				XBins = new BinsInfo() { End = 4, Size = 0.06, Start = -3.2 }
			};

			TraceList dataTraces = new TraceList(trace1);
			dataTraces.AddTrace(trace2);

			BarLayout layout = new BarLayout()
			{
				BarGap = 0.05f,
				BarGroupGap = 0.2f,
				BarMode = BarModeOptions.Overlay,
				Title = new TitleLayoutInfo() { Text = "Sample Results" },
				XAxis = new LayoutAxisInfo() { Title = new TitleFontStandoffInfo() { Text = "Value" } },
				YAxis = new LayoutYAxisInfo() { Title = new TitleFontStandoffInfo() { Text = "Count" } },
				Height = plotHeight,
				Width = plotWidth
			};

			await Chart1.newPlot(dataTraces, layout,commonConfig);

		}



        /// <summary>
        /// HistogramContour chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/2d-histogram-contour/
        /// </summary>
        public async void HistogramContour2D()
		{
			
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
				Contours = new ContoursInfo()
				{
					ShowLabels = true,
					LabelFont = new LabelFontInfo() { Family = "Raleway", Color = "white" }
				},
				HoverLabel = new HoverLabelInfo()
				{
					BgColor = "white",
					BorderColor = "black",
					Font = new FontLabelInfo() { Color = "black", Family = "Raleway" }
				}
			};

			TraceList dataTraces = new TraceList(trace);

			await Chart1.newPlot(dataTraces, commonLayout, commonConfig);
		}


        /// <summary>
        /// ParallelCategories chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/parallel-categories-diagram/
        /// </summary>
        public async void ParallelCategoriesChart()
		{
			

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

					ParCatsDimensionItem classDim = new ParCatsDimensionItem()
					{
						Label = "Class",
						CategoryOrder = DimensionCategoryOrderOptions.CategoryAscending,
						Values = passengerList.Select(passenger => passenger.Pclass).ToArray(),
					};

					ParCatsDimensionItem genderDim = new ParCatsDimensionItem()
					{
						Label = "Gender",
						CategoryOrder = DimensionCategoryOrderOptions.CategoryAscending,
						Values = passengerList.Select(passenger => passenger.Sex).ToArray(),
					};

					ParCatsDimensionItem survivalDim = new ParCatsDimensionItem()
					{
						Label = "Outcome",
						CategoryArray = new int[] { 0, 1 },
						Values = passengerList.Select(passenger => passenger.Survived).ToArray(),
						TickText = new string[] { "perished", "survived" }
					};

					ItemList<ParCatsDimensionItem> dimensions = new ItemList<ParCatsDimensionItem>();
					dimensions.Add(classDim);
					dimensions.Add(genderDim);
					dimensions.Add(survivalDim);

					ParallelCategoriesTrace trace = new ParallelCategoriesTrace()
					{
						Arrangement = ParCatsArrangementOptions.FreeForm,
						Dimensions = dimensions,
						LabelFont = new LabelFontInfo() { Size = 14 },
						Line = new LineParCatsInfo()
						{
							Color = survivalDim.Values,
							ColorScale = new object[] { new object[] { 0, "lightsteelblue" }, new object[] { 1, "mediumseagreen" } }
						},
						HoverOn = ParCatsHoverOnOptions.Color

					};

					TraceList dataTraces = new TraceList(trace);

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "Titanic Passenger Outcome" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,

					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}

			}
		}


		/// <summary>
		/// Lookup color value
		/// </summary>
		/// <param name="irisType"></param>
		/// <returns></returns>
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



        /// <summary>
        /// Splom chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/splom/
        /// </summary>
        public async void SplomChart()
		{
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

					SplomDimensionItem dim1 = new SplomDimensionItem()
					{
						Label = "sepal length",

						Values = samples.Select(iris => iris.SepalLength).ToArray(),
					};

					SplomDimensionItem dim2 = new SplomDimensionItem()
					{
						Label = "sepal width",

						Values = samples.Select(iris => iris.SepalWidth).ToArray(),
					};

					SplomDimensionItem dim3 = new SplomDimensionItem()
					{
						Label = "petal length",

						Values = samples.Select(iris => iris.PetalLength).ToArray(),

					};

					SplomDimensionItem dim4 = new SplomDimensionItem()
					{
						Label = "petal width",

						Values = samples.Select(iris => iris.PetalWidth).ToArray(),

					};

					ItemList<SplomDimensionItem> dimensions = new ItemList<SplomDimensionItem>();
					dimensions.Add(dim1);
					dimensions.Add(dim2);
					dimensions.Add(dim3);
					dimensions.Add(dim4);

					SplomTrace trace = new SplomTrace()
					{

						Dimensions = dimensions,

						Marker = new MarkerSplomInfo()
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
							Line = new LineMarkerInfo()
							{
								Color = "white",
								Width = 0.5
							},
							Size = 7

						},

						Text = samples.Select(iris => iris.IrisClass).ToArray(),
					};

					TraceList dataTraces = new TraceList(trace);

					LayoutAxisInfo axisx = new LayoutAxisInfo()
					{
						ShowLine = false,
						ZeroLine = false,
						GridColor = "#fff",
						TickLen = 4

					};
					LayoutYAxisInfo axisy = new LayoutYAxisInfo()
					{
						ShowLine = false,
						ZeroLine = false,
						GridColor = "#fff",
						TickLen = 4

					};

					Layout layout = new Layout()
					{
						Title = new TitleLayoutInfo() { Text = "Iris Dataset" },
						AutoSize = false,
						Width = plotWidth,
						Height = plotHeight,
						HoverMode = HoverModeOptions.Closest,
						DragMode = LayoutDragModeOptions.Select,
						PlotBgColor = "rgba(240, 240, 240, 0.95)"
					};
					// badly flawed architecture by plotly
					(layout.ValueItems as dynamic).xaxis = axisx.ValueItems;
					(layout.ValueItems as dynamic).xaxis2 = axisx.ValueItems;
					(layout.ValueItems as dynamic).xaxis3 = axisx.ValueItems;
					(layout.ValueItems as dynamic).xaxis4 = axisx.ValueItems;
					(layout.ValueItems as dynamic).yaxis = axisy.ValueItems;
					(layout.ValueItems as dynamic).yaxis2 = axisy.ValueItems;
					(layout.ValueItems as dynamic).yaxis3 = axisy.ValueItems;
					(layout.ValueItems as dynamic).yaxis4 = axisy.ValueItems;


					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}




        /// <summary>
        /// Violin chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/violin/
        /// </summary>
        public async void ViolinChart()
		{
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
						Side = ViolinSideOptions.Negative,
						Box = new BoxInfo() { Visible = true },
						Line = new LineColorWidthInfo() { Color = "blue", Width = 2 },
						MeanLine = new MeanLineInfo() { }
					};

					ViolinTrace traceNo = new ViolinTrace()
					{
						X = samples.Select(meal => meal.Day).ToArray(),
						Y = samples.Select(meal => meal.TotalBill).ToArray(),
						LegendGroup = "No",
						ScaleGroup = "No",
						Name = "No",
						Side = ViolinSideOptions.Positive,
						Box = new BoxInfo() { Visible = true },
						Line = new LineColorWidthInfo() { Color = "green", Width = 2 },
						MeanLine = new MeanLineInfo() {  }
					};

					TraceList dataTraces = new TraceList(new[] { traceYes, traceNo });

					ViolinLayout layout = new ViolinLayout()
					{
						Title = new TitleLayoutInfo() { Text = "Split Violin Plot" },
						Height = plotHeight,
						Width = plotWidth,
						YAxis = new LayoutYAxisInfo() { ZeroLine = false },
						ViolinGap = 0,
						ViolinGroupGap = 0,
						ViolinMode = GroupOverlayBoxModeOptions.Overlay
					};

					await Chart1.newPlot(dataTraces, layout, commonConfig);
				}
			}
		}



	
	}
}


