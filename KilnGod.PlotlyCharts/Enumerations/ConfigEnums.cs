//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ConfigEnums.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;


namespace KilnGod.PlotlyCharts.Enumerations.ConfigEnums
{
	/******************************
	*** Enum Name: displayModeBar

	*** Description: Determines the mode bar display mode. If *true*, the mode bar is always visible. If *false*, the mode bar is always hidden. If *hover*, the mode bar is visible while the mouse cursor is on the graph container.
	******************************/

	public enum DisplayModeBarOptions
	{
		[Description("hover")]
		Hover,
		[Description("True")]
		True,
		[Description("False")]
		False
	}

	/******************************
	*** Enum Name: doubleClick

	*** Description: Sets the double click interaction mode. Has an effect only in cartesian plots. If *false*, double click is disable. If *reset*, double click resets the axis ranges to their initial values. If *autosize*, double click set the axis ranges to their autorange values. If *reset+autosize*, the odd double clicks resets the axis ranges to their initial values and even double clicks set the axis ranges to their autorange values.
	******************************/

	public enum DoubleClickOptions
	{
		[Description("False")]
		False,
		[Description("reset")]
		Reset,
		[Description("autosize")]
		Autosize,
		[Description("reset+autosize")]
		Reset_Autosize
	}

	/******************************
	*** Enum Name: scrollZoom

	*** Description: Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
	******************************/

	public enum ScrollZoomOptions
	{
		[Description("cartesian")]
		Cartesian,
		[Description("gl3d")]
		Gl3d,
		[Description("geo")]
		Geo,
		[Description("mapbox")]
		Mapbox
	}


}
