//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlySimple.razor.cs
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
    public partial class PlotlySimple
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
        /// Scatter chart sample from plotly website in C#.
        ///
        /// https://plotly.com/javascript/line-and-scatter/
        /// </summary>
        public async void ScatterChart()
		{
			
			ScatterTrace trace = new ScatterTrace();

			trace.X = new int[] { 1, 2, 3, 4 };
			trace.Y = new int[] { 2, -1, 1, 3 };

			TraceList dataTraces = new TraceList(trace);

			Layout layout = new Layout
			{
				Title = new TitleLayoutInfo() { Text = "Scatter Chart" },
				XAxis = new LayoutAxisInfo() { Title = new TitleFontStandoffInfo() { Text = "X Axis" } },
				YAxis = new LayoutYAxisInfo() { Title = new TitleFontStandoffInfo() { Text = "Y Axis" } },
				Height = plotHeight,
				Width = plotWidth
			};
			

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// LogScatter chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/log-plot/
        /// </summary>
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

			Layout layout = new Layout
			{
				Title = new TitleLayoutInfo() { Text = "Scatter Chart" },
				XAxis = new LayoutAxisInfo() { Title = new TitleFontStandoffInfo() { Text = "X Axis" }, AutoRange = AutoRangeOptions.True, Type = AxisTypeOptions.Log },
				YAxis = new LayoutYAxisInfo() { Title = new TitleFontStandoffInfo() { Text = "Y Axis" }, AutoRange = AutoRangeOptions.True, Type = AxisTypeOptions.Log },
				Height = plotHeight,
				Width = plotWidth,
				ShowLegend = false
			};
			

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// Bar chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/bar-charts/
        /// </summary>
        public async void BarChart()
		{

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

			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Bar Chart" },
				XAxis = new LayoutAxisInfo() { Title = new TitleFontStandoffInfo() { Text = "Beast(s)" }, TickAngle = -45 },
				YAxis = new LayoutYAxisInfo() { Title = new TitleFontStandoffInfo { Text = "Inventory" } },
				Height = plotHeight,
				Width = plotWidth
			};
		

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}



        /// <summary>
        /// Pie chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/pie-charts/
        /// </summary>
        public async void PieChart()
		{
			
			PieTrace trace = new PieTrace()
			{

				Values = new int[] { 2, 3, 4, 4 },
				Labels = new string[] { "Wages", "Operating expenses", "Cost of sales", "Insurance" },
				TextInfo = new[] { TextInfoOptions.Text },
				TextPosition = TextPositionOptions.Outside,
				
				AutoMargin = true
			};

			TraceList dataTraces = new TraceList(trace);

			PieLayout layout = new PieLayout() { Title = new TitleLayoutInfo() { Text = "Pie Chart" }, ShowLegend = false, Height = plotHeight, Width = plotWidth };
			
			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}

        /// <summary>
        ///  Bubble chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/hover-text-and-formatting/
		/// redo
        /// </summary>
        public async void BubbleChart()
		{

			ScatterTrace trace = new ScatterTrace()
			{

				X = new int[] { 1, 2, 3, 4 },
				Y = new int[] { 10, 11, 12, 13 },
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Markers },
				Marker = new MarkerScatterInfo()
				{
					Size = new int[] { 400, 600, 800, 100 },
					SizeMode = SizeModeOptions.Diameter,
					Color = new string[] { "rgb(93,164,214)", "rgb(255,144,14)", "rgb(44,160101)", "rgb(255,65,54)" },
					Opacity = new float[] { 1, 0.8f, 0.6f, 0.4f }

				},
				Text = new string[] { "A<br>size: 40", "B<br>size: 60", "C<br>size: 80", "D<br>size: 100" }
			};
			TraceList dataTraces = new TraceList(trace);


			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Bubble Chart" },
				XAxis = new LayoutAxisInfo() { Title = new TitleFontStandoffInfo { Text = "X Axis" } },
				Height = plotHeight,
				Width = plotWidth
			};
			
			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}



        /// <summary>
        /// Time series chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/time-series/
		/// redo
        /// </summary>
        public async void TimeSeriesChart()
		{

			ScatterTrace trace = new ScatterTrace()
			{

				X = new string[] { "2017-01-04", "2017-01-05", "2017-01-06", "2017-01-09", "2017-01-10", "2017-01-11", "2017-01-12", "2017-01-13", "2017-01-17", "2017-01-18", "2017-01-19", "2017-01-20", "2017-01-23", "2017-01-24", "2017-01-25", "2017-01-26", "2017-01-27", "2017-01-30", "2017-01-31", "2017-02-01", "2017-02-02", "2017-02-03", "2017-02-06", "2017-02-07", "2017-02-08", "2017-02-09", "2017-02-10", "2017-02-13", "2017-02-14", "2017-02-15" },

				Y = new double[] { 116.019997, 116.610001, 117.910004, 118.989998, 119.110001, 119.75, 119.25, 119.040001, 120, 119.989998, 119.779999, 120, 120.080002, 119.970001, 121.879997, 121.940002, 121.949997, 121.629997, 121.349998, 128.75, 128.529999, 129.080002, 130.289993, 131.529999, 132.039993, 132.419998, 132.119995, 133.289993, 135.020004, 135.509995 },
				Mode = new ModeScatterOptions[] { ModeScatterOptions.Lines },
				Line = new LineScatterInfo() { Color = "#17BECF" }
			};

			TraceList dataTraces = new TraceList(trace);


			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Time Series Chart" },
				XAxis = new LayoutAxisInfo()
				{
					Title = new TitleFontStandoffInfo() { Text = "Date" },
					Range = new string[] { "2017-01-04", "2017-02-15" },
					Type = AxisTypeOptions.Date
				},
				YAxis = new LayoutYAxisInfo()
				{
					Title = new TitleFontStandoffInfo() { Text = "Range" },
					AutoRange = AutoRangeOptions.True,
					Range = new double[] { 86.8700008333, 138.870004167 },
					Type = AxisTypeOptions.Linear
				},
				Height = plotHeight,
				Width = plotWidth
			};
			

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}



	
	}
}


