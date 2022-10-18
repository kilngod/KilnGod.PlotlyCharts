//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyFinance.razor.cs
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
    public partial class PlotlyFinance : DemoBaseComponent
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
        /// Candlestick chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/candlestick-charts/
        /// </summary>
        public async void CandlestickChart()
		{
			
			CandlestickTrace trace = new CandlestickTrace();


			trace.X = new string[] { "2017-01-04", "2017-01-05", "2017-01-06", "2017-01-09", "2017-01-10", "2017-01-11", "2017-01-12", "2017-01-13", "2017-01-17", "2017-01-18", "2017-01-19", "2017-01-20", "2017-01-23", "2017-01-24", "2017-01-25", "2017-01-26", "2017-01-27", "2017-01-30", "2017-01-31", "2017-02-01", "2017-02-02", "2017-02-03", "2017-02-06", "2017-02-07", "2017-02-08", "2017-02-09", "2017-02-10", "2017-02-13", "2017-02-14", "2017-02-15" };

			trace.Close = new double[] { 116.019997, 116.610001, 117.910004, 118.989998, 119.110001, 119.75, 119.25, 119.040001, 120, 119.989998, 119.779999, 120, 120.080002, 119.970001, 121.879997, 121.940002, 121.949997, 121.629997, 121.349998, 128.75, 128.529999, 129.080002, 130.289993, 131.529999, 132.039993, 132.419998, 132.119995, 133.289993, 135.020004, 135.509995 };
			trace.High = new double[] { 116.510002, 116.860001, 118.160004, 119.43, 119.379997, 119.93, 119.300003, 119.620003, 120.239998, 120.5, 120.089996, 120.449997, 120.809998, 120.099998, 122.099998, 122.440002, 122.349998, 121.629997, 121.389999, 130.490005, 129.389999, 129.190002, 130.5, 132.089996, 132.220001, 132.449997, 132.940002, 133.820007, 135.089996, 136.270004 };
			trace.Low = new double[] { 115.75, 115.809998, 116.470001, 117.940002, 118.300003, 118.599998, 118.209999, 118.809998, 118.220001, 119.709999, 119.370003, 119.730003, 119.769997, 119.5, 120.279999, 121.599998, 121.599998, 120.660004, 120.620003, 127.010002, 127.779999, 128.160004, 128.899994, 130.449997, 131.220001, 131.119995, 132.050003, 132.75, 133.25, 134.619995 };
			trace.Open = new double[] { 115.849998, 115.919998, 116.779999, 117.949997, 118.769997, 118.739998, 118.900002, 119.110001, 118.339996, 120, 119.400002, 120.449997, 120, 119.550003, 120.419998, 121.669998, 122.139999, 120.93, 121.150002, 127.029999, 127.980003, 128.309998, 129.130005, 130.539993, 131.350006, 131.649994, 132.460007, 133.080002, 133.470001, 135.520004 };

			(trace.ValueItems as dynamic).xaxis = "x";
			(trace.ValueItems as dynamic).yaxis = "y";

			TraceList dataTraces = new TraceList(trace);



			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Finance Candlestick Chart" },
				XAxis = new LayoutAxisInfo()
				{
					AutoRange = AutoRangeOptions.True,

					Type = AxisTypeOptions.Date,
					Domain = new int[] { 0, 1 },
					Range = new string[] { "2017-01-03 12:00", "2017-02-15 12:00" },
					Title = new TitleFontStandoffInfo() { Text = "Date" }
				},

				YAxis = new LayoutYAxisInfo()
				{
					AutoRange = AutoRangeOptions.True,
					Type = AxisTypeOptions.Linear,
					Domain = new int[] { 0, 1 },
					Range = new double[] { 114.609999778, 137.410004222 },
					Title = new TitleFontStandoffInfo() { Text = "Price" }
				},
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth

			};


			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}



        /// <summary>
        /// OHLC chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/ohlc-charts/
        /// </summary>
        public async void OHLCChart()
		{
			OhlcTrace trace = new OhlcTrace();


			trace.X = new string[] { "2017-01-04", "2017-01-05", "2017-01-06", "2017-01-09", "2017-01-10", "2017-01-11", "2017-01-12", "2017-01-13", "2017-01-17", "2017-01-18", "2017-01-19", "2017-01-20", "2017-01-23", "2017-01-24", "2017-01-25", "2017-01-26", "2017-01-27", "2017-01-30", "2017-01-31", "2017-02-01", "2017-02-02", "2017-02-03", "2017-02-06", "2017-02-07", "2017-02-08", "2017-02-09", "2017-02-10", "2017-02-13", "2017-02-14", "2017-02-15" };

			trace.Close = new double[] { 116.019997, 116.610001, 117.910004, 118.989998, 119.110001, 119.75, 119.25, 119.040001, 120, 119.989998, 119.779999, 120, 120.080002, 119.970001, 121.879997, 121.940002, 121.949997, 121.629997, 121.349998, 128.75, 128.529999, 129.080002, 130.289993, 131.529999, 132.039993, 132.419998, 132.119995, 133.289993, 135.020004, 135.509995 };
			trace.High = new double[] { 116.510002, 116.860001, 118.160004, 119.43, 119.379997, 119.93, 119.300003, 119.620003, 120.239998, 120.5, 120.089996, 120.449997, 120.809998, 120.099998, 122.099998, 122.440002, 122.349998, 121.629997, 121.389999, 130.490005, 129.389999, 129.190002, 130.5, 132.089996, 132.220001, 132.449997, 132.940002, 133.820007, 135.089996, 136.270004 };
			trace.Low = new double[] { 115.75, 115.809998, 116.470001, 117.940002, 118.300003, 118.599998, 118.209999, 118.809998, 118.220001, 119.709999, 119.370003, 119.730003, 119.769997, 119.5, 120.279999, 121.599998, 121.599998, 120.660004, 120.620003, 127.010002, 127.779999, 128.160004, 128.899994, 130.449997, 131.220001, 131.119995, 132.050003, 132.75, 133.25, 134.619995 };
			trace.Open = new double[] { 115.849998, 115.919998, 116.779999, 117.949997, 118.769997, 118.739998, 118.900002, 119.110001, 118.339996, 120, 119.400002, 120.449997, 120, 119.550003, 120.419998, 121.669998, 122.139999, 120.93, 121.150002, 127.029999, 127.980003, 128.309998, 129.130005, 130.539993, 131.350006, 131.649994, 132.460007, 133.080002, 133.470001, 135.520004 };

			(trace.ValueItems as dynamic).xaxis = "x";
			(trace.ValueItems as dynamic).yaxis = "y";

			TraceList dataTraces = new TraceList(trace);



			Layout layout = new Layout()
			{
				Title = new TitleLayoutInfo() { Text = "Finance OHLC Chart" },
				XAxis = new LayoutAxisInfo()
				{
					AutoRange = AutoRangeOptions.True,
					Type = AxisTypeOptions.Date,
					Domain = new int[] { 0, 1 },
					Range = new string[] { "2017-01-03 12:00", "2017-02-15 12:00" },
					Title = new TitleFontStandoffInfo() { Text = "Date" }
				},

				YAxis = new LayoutYAxisInfo()
				{
					AutoRange = AutoRangeOptions.True,
					Type = AxisTypeOptions.Linear,
					Domain = new int[] { 0, 1 },
					Range = new double[] { 114.609999778, 137.410004222 },
					Title = new TitleFontStandoffInfo() { Text = "Price" }
				},
				ShowLegend = false,
				Height = plotHeight,
				Width = plotWidth

			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}



        /// <summary>
        /// Waterfall chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/waterfall-charts/
        /// </summary>
        public async void WaterfallChart()
		{
			
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
				Connector = new WaterfallConnectorInfo()
				{
					Mode = ModeConnectorOptions.Between,
					Line = new LineInfo() { Width = 4, Color = "rgb(0, 0, 0)" }
				}

			};

			TraceList dataTraces = new TraceList(waterfallTrace);


			WaterfallLayout layout = new WaterfallLayout()
			{
				Title = new TitleLayoutInfo() { Text = "Profit and loss statement 2018<br>waterfall chart displaying positive and negative" },
				YAxis = new LayoutYAxisInfo() { Type = AxisTypeOptions.Category, AutoRange = AutoRangeOptions.Reversed },
				XAxis = new LayoutAxisInfo() { Type = AxisTypeOptions.Linear },
				Margin = new MarginInfo() { L = 150 },
				ShowLegend = true,
				Height = plotHeight,
				Width = plotWidth
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);

		}



        /// <summary>
        /// Funnel chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/funnel-charts/
        /// </summary>
        public async void FunnelChart()
		{
			
			FunnelTrace funnel = new FunnelTrace()
			{
				Connector = new FunnelConnectorInfo() { Line = new LineInfo() { Color = "royalblue", Dash = SpikeDashOptions.Dot, Width = 3 } },
				X = new double[] { 1200, 909.4, 600.6, 300, 80 },
				Y = new string[] { "Sales person A", "Sales person B", "Sales person C", "Sales person D", "Sales person E" },
				TextPosition = TextPositionOptions.Inside,
				TextInfo = new FunnelTextInfoOptions[] { FunnelTextInfoOptions.Value, FunnelTextInfoOptions.PercentInitial },
				Opacity = 0.65,
				Marker = new MarkerFunnelInfo() { Color = new object[] { "59D4E8", "DDB6C6", "A696C8", "67EACA", "94D2E6" } }
			
			};
			TraceList dataTraces = new TraceList(funnel);
			FunnelLayout layout = new FunnelLayout()
			{
				Title = new TitleLayoutInfo() { Text = "Sales Activity" },
				Margin = new MarginInfo() { L = 100 },
				Width = plotWidth,
				Height = plotHeight
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// StackedFunnel chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/funnel-charts/
        /// </summary>
        public async void StackedFunnelChart()
		{

			FunnelTrace MontreallFunnel = new FunnelTrace()
			{
				Name = "Montreal",
				X = new double[] { 120, 60, 30, 20 },
				Y = new string[] { "Website visit", "Downloads", "Potential customers", "Requested price" },
				TextInfo = new FunnelTextInfoOptions[] { FunnelTextInfoOptions.Value, FunnelTextInfoOptions.PercentInitial },
			};
			FunnelTrace TorontoFunnel = new FunnelTrace()
			{
				Name = "Toronto",
				X = new double[] { 100, 60, 40, 30, 20 },
				Y = new string[] { "Website visit", "Downloads", "Potential customers", "Requested price", "invoice sent" },
				TextInfo = new FunnelTextInfoOptions[] { FunnelTextInfoOptions.Value, FunnelTextInfoOptions.PercentInitial },
			};
			FunnelTrace VancouverFunnel = new FunnelTrace()
			{
				Name = "Vancouver",
				X = new double[] { 90, 70, 50, 30, 10, 5 },
				Y = new string[] { "Website visit", "Downloads", "Potential customers", "Requested price", "invoice sent", "closed deals" },
				TextInfo = new FunnelTextInfoOptions[] { FunnelTextInfoOptions.Value, FunnelTextInfoOptions.PercentInitial },
			};


			TraceList dataTraces = new TraceList(MontreallFunnel);
			dataTraces.AddTrace(TorontoFunnel);
			dataTraces.AddTrace(VancouverFunnel);

			FunnelLayout layout = new FunnelLayout()
			{
				FunnelMode = FunnelModeOptions.Stack,
				Title = new TitleLayoutInfo() { Text = "Sales Funnel" },
				Margin = new MarginInfo() { L = 100, R = 0 },
				Height = plotHeight,
				Width = plotWidth,
				ShowLegend = true
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// FunnelArea chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/funnel-charts/
        /// </summary>
        public async void FunnelAreaChart()
		{
			
			FunnelAreaTrace funnel = new FunnelAreaTrace()
			{
				Values = new int[] { 5, 4, 3, 2, 1 },
				Text = new string[] { "The 1st", "The 2nd", "The 3rd", "The 4th", "The 5th" },

				Marker = new MarkerFunnelAreaInfo()
				{
					Colors = new object[] { "59D4E8", "DDB6C6", "A696C8", "67EACA", "94D2E6" },
					Line = new LineColorWidthsInfo()
					{
						Width = new int[] { 2, 1, 5, 0, 3 },
						Color = new object[] { "3E4E88", "606470", "3E4E88", "606470", "3E4E88" }
					}
				},
				Opacity = 0.65,
				TextFont = new TextFontInfo() { Family = "Old Standard TT", Color = "black", Size = 13 }


			};

			TraceList dataTraces = new TraceList(funnel);
			FunnelAreaLayout layout = new FunnelAreaLayout()
			{
				Title = new TitleLayoutInfo() { Text = "Activity" },
				Margin = new MarginInfo() { L = 100, R = 200 },
				Height = plotHeight,
				Width = plotWidth,
			};
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// Gauge chart sample from plotly website in C#
        ///
        /// https://plotly.com/javascript/gauge-charts/
        /// </summary>
        public async void GuageChart()
		{
			

			IndicatorTrace guage = new IndicatorTrace()
			{
				Value = 420,
				Mode = new ModeIndicatorOptions[] { ModeIndicatorOptions.Number, ModeIndicatorOptions.Gauge, ModeIndicatorOptions.Delta },
				Title = new TitleAlignFontInfo() { Text = "Speed", Font = new FontTitleInfo() { Size = 24 } },
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
					Shape = ShapeGaugeOptions.Angular,
					Threshold = new ThresholdInfo()
					{
						Line = new LineColorWidthInfo() { Color = "red", Width = 4 },
						Thickness = 0.75,
						Value = 490
					}
				}

			};
		

			TraceList dataTraces = new TraceList(guage);
			Layout layout = new Layout()
			{
				Width = plotWidth,
				Height = plotHeight,
				Margin = new MarginInfo() { T = 0, B = 0 },
				PaperBgColor = "lavender",
				Font = new FontInfo()
				{
					Family = "Arial",
					Color = "darkblue"
				}
			};

			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



        /// <summary>
        /// Bullet chart sample from plotly website in C#.
		///
		/// https://plotly.com/javascript/bullet-charts/
        /// </summary>
        public async void BulletChart()
		{
			
			
			IndicatorTrace bullet = new IndicatorTrace()
			{
				Delta = new DeltaInfo() { Reference = 200 },
				Domain = new DomainInfo() { X = new double[] { 0, 1 }, Y = new double[] { 0, 1 } },
				Value = 220,
				Mode = new ModeIndicatorOptions[] { ModeIndicatorOptions.Number, ModeIndicatorOptions.Gauge, ModeIndicatorOptions.Delta },
				Title = new TitleAlignFontInfo()
				{
					Text = "<b>Profit</b><br><span style='color: gray; font-size:0.8em'>U.S. $</span>",
					Font = new FontTitleInfo() { Size = 14 }
				},

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
					Shape = ShapeGaugeOptions.Bullet,
					Threshold = new ThresholdInfo()
					{
						Line = new LineColorWidthInfo() { Color = "red", Width = 2 },
						Thickness = 0.75,
						Value = 280
					},
				}
			};

			TraceList dataTraces = new TraceList(bullet);
			Layout layout = new Layout()
			{
				Width = plotWidth,
				Height = plotHeight,
				Margin = new MarginInfo()
                {
					T=300,
					B=300
                }
			};
			
			await Chart1.newPlot(dataTraces, layout, commonConfig);
		}



	
	}
}


