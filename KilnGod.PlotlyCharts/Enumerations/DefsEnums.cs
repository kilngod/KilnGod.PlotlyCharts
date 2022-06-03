//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: DefsEnums.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Enumerations.DefsEnums
{

	/******************************
*** Enum Name: layout

*** Description: layout attributes should include an `editType` string matching this flaglist. *calc* is the most extensive: a full (re)plot starting by clearing `gd.calcdata` to force it to be regenerated *plot* (re)plots but without first clearing `gd.calcdata`. *legend* only redraws the legend. *ticks* only redraws axis ticks, labels, and gridlines. *axrange* minimal sequence when updating axis ranges. *layoutstyle* reapplies global and SVG cartesian axis styles. *modebar* just updates the modebar. *camera* just updates the camera settings for gl3d scenes. *arraydraw* allows component arrays to invoke the redraw routines just for the component(s) that changed. *colorbars* only redraws colorbars.
******************************/

	public enum LayoutOptions
	{
		[Description("calc")]
		Calc,
		[Description("plot")]
		Plot,
		[Description("legend")]
		Legend,
		[Description("ticks")]
		Ticks,
		[Description("axrange")]
		Axrange,
		[Description("layoutstyle")]
		Layoutstyle,
		[Description("modebar")]
		Modebar,
		[Description("camera")]
		Camera,
		[Description("arraydraw")]
		Arraydraw,
		[Description("colorbars")]
		Colorbars
	}

	/******************************
	*** Enum Name: traces

	*** Description: trace attributes should include an `editType` string matching this flaglist. *calc* is the most extensive: a full (re)plot starting by clearing `gd.calcdata` to force it to be regenerated *clearAxisTypes* resets the types of the axes this trace is on, because new data could cause the automatic axis type detection to change. Log type will not be cleared, as that is never automatically chosen so must have been user-specified. *plot* (re)plots but without first clearing `gd.calcdata`. *style* only calls `module.style` (or module.editStyle) for all trace modules and redraws the legend. *markerSize* is like *style*, but propagate axis-range changes due to scatter `marker.size` *colorbars* only redraws colorbars.
	******************************/

	public enum TracesOptions
	{
		[Description("calc")]
		Calc,
		[Description("clearAxisTypes")]
		ClearAxisTypes,
		[Description("plot")]
		Plot,
		[Description("style")]
		Style,
		[Description("markerSize")]
		MarkerSize,
		[Description("colorbars")]
		Colorbars
	}


}
