//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TracesEnums.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Enumerations.TracesEnums
{
	/******************************
	*** Enum Name: aaxisType

	*** Description: Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
	******************************/

	public enum ABAxisTypeOptions
	{
		[Description("-")]
		Auto,
		[Description("linear")]
		Linear,
		[Description("date")]
		Date,
		[Description("category")]
		Category
	}

	/******************************
	*** Enum Name: align

	*** Description: Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
	******************************/

	public enum AlignOptions
	{
		[Description("left")]
		Left,
		[Description("right")]
		Right,
		[Description("auto")]
		Auto
	}

	/******************************
	*** Enum Name: anchor

	*** Description: Sets the cones' anchor with respect to their x/y/z positions. Note that *cm* denote the cone's center of mass which corresponds to 1/4 from the tail to tip.
	******************************/

	public enum AnchorOptions
	{
		[Description("tip")]
		Tip,
		[Description("tail")]
		Tail,
		[Description("cm")]
		Cm,
		[Description("center")]
		Center
	}

	/******************************
	*** Enum Name: arrangement

	*** Description: Sets the drag interaction mode for categories and dimensions. If `perpendicular`, the categories can only move along a line perpendicular to the paths. If `freeform`, the categories can freely move on the plane. If `fixed`, the categories and dimensions are stationary.
	******************************/

	public enum ArrangementOptions
	{
		[Description("snap")]
		Snap,
		[Description("perpendicular")]
		Perpendicular,
		[Description("freeform")]
		Freeform,
		[Description("fixed")]
		Fixed
	}

	/******************************
	*** Enum Name: atype

	*** Description: If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
	******************************/

	public enum ATypeOptions
	{
		[Description("array")]
		Array,
		[Description("scaled")]
		Scaled
	}

	

	

	

	/******************************
	*** Enum Name: barmode

	*** Description: Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *relative*, the bars are stacked on top of one another, with negative values below the axis, positive values above With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
	******************************/

	public enum BarModeOptions
	{
		[Description("stack")]
		Stack,
		[Description("group")]
		Group,
		[Description("overlay")]
		Overlay,
		[Description("relative")]
		Relative
	}

	/******************************
	*** Enum Name: barnorm

	*** Description: Sets the normalization for bar traces on the graph. With *fraction*, the value of each bar is divided by the sum of all values at that location coordinate. *percent* is the same but multiplied by 100 to show percentages.
	******************************/

	public enum BarNormOptions
	{
		[Description("fraction")]
		Fraction,
		[Description("percent")]
		Percent
	}



	/******************************
	*** Enum Name: boxmean

	*** Description: If *true*, the mean of the box(es)' underlying distribution is drawn as a dashed line inside the box(es). If *sd* the standard deviation is also drawn. Defaults to *true* when `mean` is set. Defaults to *sd* when `sd` is set Otherwise defaults to *false*.
	******************************/

	public enum BoxMeanOptions
	{
		[Description("True")]
		True,
		[Description("sd")]
		Sd,
		[Description("False")]
		False
	}

	/******************************
	*** Enum Name: boxmode

	*** Description: Determines how boxes at the same location coordinate are displayed on the graph. If *group*, the boxes are plotted next to one another centered around the shared location. If *overlay*, the boxes are plotted over one another, you might need to set *opacity* to see them multiple boxes. Has no effect on traces that have *width* set.
	******************************/

	public enum BoxModeOptions
	{
		[Description("group")]
		Group,
		[Description("overlay")]
		Overlay
	}

	/******************************
	*** Enum Name: boxpoints

	*** Description: If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the box(es) are shown with no sample points Defaults to *suspectedoutliers* when `marker.outliercolor` or `marker.line.outliercolor` is set. Defaults to *all* under the q1/median/q3 signature. Otherwise defaults to *outliers*.
	******************************/

	public enum BoxPointsOptions
	{
		[Description("all")]
		All,
		[Description("outliers")]
		Outliers,
		[Description("suspectedoutliers")]
		Suspectedoutliers,
		[Description("False")]
		False
	}

	/******************************
	*** Enum Name: branchvalues

	*** Description: Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
	******************************/

	public enum BranchValuesOptions
	{
		[Description("remainder")]
		Remainder,
		[Description("total")]
		Total
	}

	/******************************
	*** Enum Name: btype

	*** Description: If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
	******************************/

	public enum BTypeOptions
	{
		[Description("array")]
		Array,
		[Description("scaled")]
		Scaled
	}

	/******************************
	*** Enum Name: categoryorder

	*** Description: Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
	******************************/

	public enum OtherCategoryOrderOptions
	{
		[Description("trace")]
		Trace,
		[Description("category ascending")]
		CategoryAscending,
		[Description("category descending")]
		CategoryDescending,
		[Description("array")]
		Array
	}

	/******************************
	*** Enum Name: cheatertype

	*** Description: 
	******************************/

	public enum CheaterTypeOptions
	{
		[Description("index")]
		Index,
		[Description("value")]
		Value
	}

	/******************************
	*** Enum Name: coloring

	*** Description: Determines the coloring method showing the contour values. If *fill*, coloring is done evenly between each contour level If *heatmap*, a heatmap gradient coloring is applied between each contour level. If *lines*, coloring is done on the contour lines. If *none*, no coloring is applied on this trace.
	******************************/

	public enum ColoringOptions
	{
		[Description("fill")]
		Fill,
		[Description("heatmap")]
		Heatmap,
		[Description("lines")]
		Lines,
		[Description("none")]
		None
	}

	/******************************
	*** Enum Name: colormodel

	*** Description: Color model used to map the numerical color components described in `z` into colors. If `source` is specified, this attribute will be set to `rgba256` otherwise it defaults to `rgb`.
	******************************/

	public enum ColorModelOptions
	{
		[Description("rgb")]
		Rgb,
		[Description("rgba")]
		Rgba,
		[Description("rgba256")]
		Rgba256,
		[Description("hsl")]
		Hsl,
		[Description("hsla")]
		Hsla
	}


	/******************************
	*** Enum Name: ConnectorModeOptions

	*** Description: Constrain the size of text inside or outside a bar to be no larger than the bar itself.
	******************************/

	public enum ConnectorModeOptions
	{

		[Description("spanning")]
		Spanning,
		[Description("between")]
		Between
		
	}


	/******************************
	*** Enum Name: constraintext

	*** Description: Constrain the size of text inside or outside a bar to be no larger than the bar itself.
	******************************/

	public enum ConstrainTextOptions
	{
		[Description("inside")]
		Inside,
		[Description("outside")]
		Outside,
		[Description("both")]
		Both,
		[Description("none")]
		None
	}

	/******************************
	*** Enum Name: contoursType

	*** Description: If `levels`, the data is represented as a contour plot with multiple levels displayed. If `constraint`, the data is represented as constraints with the invalid region shaded as specified by the `operation` and `value` parameters.
	******************************/

	public enum ContoursTypeOptions
	{
		[Description("levels")]
		Levels,
		[Description("constraint")]
		Constraint
	}

	/******************************
	*** Enum Name: count

	*** Description: Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
	******************************/

	public enum CountOptions
	{
		[Description("branches")]
		Branches,
		[Description("leaves")]
		Leaves
	}

	/******************************
	*** Enum Name: currentbin

	*** Description: Only applies if cumulative is enabled. Sets whether the current bin is included, excluded, or has half of its value included in the current cumulative value. *include* is the default for compatibility with various other tools, however it introduces a half-bin bias to the results. *exclude* makes the opposite half-bin bias, and *half* removes it.
	******************************/

	public enum CurrentBinOptions
	{
		[Description("include")]
		Include,
		[Description("exclude")]
		Exclude,
		[Description("half")]
		Half
	}

	

	/******************************
	*** Enum Name: delaunayaxis

	*** Description: Sets the Delaunay axis, which is the axis that is perpendicular to the surface of the Delaunay triangulation. It has an effect if `i`, `j`, `k` are not provided and `alphahull` is set to indicate Delaunay triangulation.
	******************************/

	public enum DelaunaYAxisOptions
	{
		[Description("x")]
		X,
		[Description("y")]
		Y,
		[Description("z")]
		Z
	}

	/******************************
	*** Enum Name: depthfade

	*** Description: Determines if the sector colors are faded towards the background from the leaves up to the headers. This option is unavailable when a `colorscale` is present, defaults to false when `marker.colors` is set, but otherwise defaults to true. When set to *reversed*, the fading direction is inverted, that is the top elements within hierarchy are drawn with fully saturated colors while the leaves are faded towards the background color.
	******************************/

	public enum DepthFadeOptions
	{
		[Description("True")]
		True,
		[Description("False")]
		False,
		[Description("reversed")]
		Reversed
	}

	/******************************
	*** Enum Name: direction

	*** Description: Only applies if cumulative is enabled. If *increasing* (default) we sum all prior bins, so the result increases from left to right. If *decreasing* we sum later bins so the result decreases from left to right.
	******************************/

	public enum DirectionOptions
	{
		[Description("increasing")]
		Increasing,
		[Description("decreasing")]
		Decreasing
	}

	
	/******************************
	*** Enum Name: edgeshape

	*** Description: Determines which shape is used for edges between `barpath` labels.
	******************************/

	public enum EdgeShapeOptions
	{
		[Description(">")]
		GreaterThan,
		[Description("<")]
		LessThan,
		[Description("|")]
		Pipe,
		[Description("/")]
		ForwardSlash,
		[Description("\\")]
		BackSlash
	}

	/******************************
	*** Enum Name: error_xType

	*** Description: Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the square of the underlying data. If *data*, the bar lengths are set with data set `array`.
	******************************/

	public enum ErrorTypeOptions
	{
		[Description("percent")]
		Percent,
		[Description("constant")]
		Constant,
		[Description("sqrt")]
		Sqrt,
		[Description("data")]
		Data
	}


	/******************************
	*** Enum Name: exponentformat

	*** Description: Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
	******************************/

	public enum ExponentFormatOptions
	{
		[Description("none")]
		None,
		[Description("e")]
		SmallE,
		[Description("E")]
		BigE,
		[Description("power")]
		Power,
		[Description("SI")]
		SI,
		[Description("B")]
		B
	}

	/******************************
	*** Enum Name: fill

	*** Description: Sets the area to fill with a solid color. Defaults to *none* unless this trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints of this trace and the endpoints of the trace before it, connecting those endpoints with straight lines (to make a stacked area graph); if there is no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
	******************************/

	public enum FillOptions
	{
		[Description("none")]
		None,
		[Description("tozeroy")]
		Tozeroy,
		[Description("tozerox")]
		Tozerox,
		[Description("tonexty")]
		Tonexty,
		[Description("tonextx")]
		Tonextx,
		[Description("toself")]
		Toself,
		[Description("tonext")]
		Tonext
	}

	/******************************
	*** Enum Name: fillmode

	*** Description: Determines whether `marker.color` should be used as a default to `bgcolor` or a `fgcolor`.
	******************************/

	public enum FillModeOptions
	{
		[Description("replace")]
		Replace,
		[Description("overlay")]
		Overlay
	}

	/******************************
	*** Enum Name: flip

	*** Description: Determines if the positions obtained from solver are flipped on each axis.
	******************************/

	public enum FlipOptions
	{
		[Description("x")]
		X,
		[Description("y")]
		Y
	}

	/******************************
	*** Enum Name: funnelmode

	*** Description: Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
	******************************/

	public enum FunnelModeOptions
	{
		[Description("stack")]
		Stack,
		[Description("group")]
		Group,
		[Description("overlay")]
		Overlay
	}

	/******************************
	*** Enum Name: gradientType

	*** Description: Sets the type of gradient used to fill the markers
	******************************/

	public enum GradientTypeOptions
	{
		[Description("radial")]
		Radial,
		[Description("horizontal")]
		Horizontal,
		[Description("vertical")]
		Vertical,
		[Description("none")]
		None
	}

	/******************************
	*** Enum Name: groupnorm

	*** Description: Only relevant when `stackgroup` is used, and only the first `groupnorm` found in the `stackgroup` will be used - including if `visible` is *legendonly* but not if it is `false`. Sets the normalization for the sum of this `stackgroup`. With *fraction*, the value of each trace at each location is divided by the sum of all trace values at that location. *percent* is the same but multiplied by 100 to show percentages. If there are multiple subplots, or multiple `stackgroup`s on one subplot, each will be normalized within its own set.
	******************************/

	public enum GroupNormOptions
	{
		[Description("fraction")]
		Fraction,
		[Description("percent")]
		Percent
	}

	/******************************
	*** Enum Name: histfunc

	*** Description: Specifies the binning function used for this histogram trace. If *count*, the histogram values are computed by counting the number of values lying inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are computed using the sum, the average, the minimum or the maximum of the values lying inside each bin respectively.
	******************************/

	public enum HistFuncOptions
	{
		[Description("count")]
		Count,
		[Description("sum")]
		Sum,
		[Description("avg")]
		Avg,
		[Description("min")]
		Min,
		[Description("max")]
		Max
	}

	/******************************
	*** Enum Name: histnorm

	*** Description: Specifies the type of normalization used for this histogram trace. If **, the span of each bar corresponds to the number of occurrences (i.e. the number of data points lying inside the bins). If *percent* / *probability*, the span of each bar corresponds to the percentage / fraction of occurrences with respect to the total number of sample points (here, the sum of all bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds to the number of occurrences in a bin divided by the size of the bin interval (here, the sum of all bin AREAS equals the total number of sample points). If *probability density*, the area of each bar corresponds to the probability that an event will fall into the corresponding bin (here, the sum of all bin AREAS equals 1).
	******************************/

	public enum HistNormOptions
	{
		[Description("percent")]
		Percent,
		[Description("probability")]
		Probability,
		[Description("density")]
		Density,
		[Description("probability density")]
		ProbabilityDensity
	}

	/******************************
	*** Enum Name: hoverinfo

	*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
	******************************/

	public enum HoverInfoOptions
	{
		[Description("x")]
		X,
		[Description("y")]
		Y,
		[Description("z")]
		Z,
		[Description("text")]
		Text,
		[Description("name")]
		Name,
		[Description("count")]
		Count,
		[Description("Probability")]
		Probability
	}

	/******************************
	*** Enum Name: hoveron

	*** Description: Do the hover effects highlight individual boxes  or sample points or both?
	******************************/

	public enum HoverOnOptions
	{
		[Description("boxes")]
		Boxes,
		[Description("points")]
		Points,
		[Description("fills")]
		Fills,
		[Description("category")]
		Category,
		[Description("color")]
		Color,
		[Description("dimension")]
		Dimension,
		[Description("all")]
		All

			 
	}

	/******************************
	*** Enum Name: insidetextanchor

	*** Description: Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
	******************************/

	public enum InSideTextAnchorOptions
	{
		[Description("end")]
		End,
		[Description("middle")]
		Middle,
		[Description("start")]
		Start
	}

	/******************************
	*** Enum Name: insidetextorientation

	*** Description: Controls the orientation of the text inside chart sectors. When set to *auto*, text may be oriented in any direction in order to be as big as possible in the middle of a sector. The *horizontal* option orients text to be parallel with the bottom of the chart, and may make text smaller in order to achieve that goal. The *radial* option orients text along the radius of the sector. The *tangential* option orients text perpendicular to the radius of the sector.
	******************************/

	public enum InsideTextOrientationOptions
	{
		[Description("horizontal")]
		Horizontal,
		[Description("radial")]
		Radial,
		[Description("tangential")]
		Tangential,
		[Description("auto")]
		Auto
	}

	/******************************
	*** Enum Name: intensitymode

	*** Description: Determines the source of `intensity` values.
	******************************/

	public enum IntensityModeOptions
	{
		[Description("vertex")]
		Vertex,
		[Description("cell")]
		Cell
	}

	/******************************
	*** Enum Name: labelside

	*** Description: Specifies the location of the `label`. *top* positions labels above, next to the title *bottom* positions labels below the graph Tilted labels with *labelangle* may be positioned better inside margins when `labelposition` is set to *bottom*.
	******************************/

	public enum LabelSideOptions
	{
		[Description("top")]
		Top,
		[Description("bottom")]
		Bottom
	}

	/******************************
	*** Enum Name: lenmode

	*** Description: Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
	******************************/

	public enum LenModeOptions
	{
		[Description("fraction")]
		Fraction,
		[Description("pixels")]
		Pixels
	}

	/******************************
	*** Enum Name: locationmode

	*** Description: Determines the set of locations used to match entries in `locations` to regions on the map. Values *ISO-3*, *USA-states*, *country names* correspond to features on the base map and value *geojson-id* corresponds to features from a custom GeoJSON linked to the `geojson` attribute.
	******************************/

	public enum LocationModeOptions
	{
		[Description("ISO-3")]
		ISO3,
		[Description("USA-states")]
		USAStates,
		[Description("country names")]
		CountryNames,
		[Description("geojson-id")]
		GeojsonId
	}

	/******************************
	*** Enum Name: mode

	*** Description: Determines how the value is displayed on the graph. `number` displays the value numerically in text. `delta` displays the difference to a reference value in text. Finally, `gauge` displays the value graphically on an axis.
	******************************/

	public enum ModeOptions
	{
		[Description("number")]
		Number,
		[Description("delta")]
		Delta,
		[Description("gauge")]
		Gauge,
		[Description("number+gauge+delta")]
		Number_Gauge_Delta,
		[Description("lines")]
		Lines,
		[Description("lines+markers")]
		Line_Markers,
		[Description("markers")]
		Markers,		
		[Description("text")]
		Text
	}



/******************************
*** Enum Name: operation

*** Description: Sets the constraint operation. *=* keeps regions equal to `value` *<* and *<=* keep regions less than `value` *>* and *>=* keep regions greater than `value` *[]*, *()*, *[)*, and *(]* keep regions inside `value[0]` to `value[1]` *][*, *)(*, *](*, *)[* keep regions outside `value[0]` to value[1]` Open vs. closed intervals make no difference to constraint display, but all versions are allowed for consistency with filter transforms.
******************************/

public enum OperationOptions
	{
		[Description("=")]
		Equals,
		[Description("<")]
		LessThan,
		[Description(">=")]
		GreaterThanEquals,
		[Description(">")]
		GreaterThan,
		[Description("<=")]
		LessThanEquals,
		[Description("[]")]
		LBRB,
		[Description("()")]
		LPRP,
		[Description("[)")]
		RBRP,
		[Description("(]")]
		LPRB,
		[Description("][")]
		RBLB,
		[Description(")(")]
		RPLP,
		[Description("](")]
		RBLP,
		[Description(")[")]
		TPLB
	}

	

	/******************************
	*** Enum Name: packing

	*** Description: Determines d3 treemap solver. For more info please refer to https://github.com/d3/d3-hierarchy#treemap-tiling
	******************************/

	public enum PackingOptions
	{
		[Description("squarify")]
		Squarify,
		[Description("binary")]
		Binary,
		[Description("dice")]
		Dice,
		[Description("slice")]
		Slice,
		[Description("slice-dice")]
		SliceDice,
		[Description("dice-slice")]
		DiceSlice
	}

	/******************************
	*** Enum Name: pattern

	*** Description: Sets the surface pattern of the iso-surface 3-D sections. The default pattern of the surface is `all` meaning that the rest of surface elements would be shaded. The check options (either 1 or 2) could be used to draw half of the squares on the surface. Using various combinations of capital `A`, `B`, `C`, `D` and `E` may also be used to reduce the number of triangles on the iso-surfaces and creating other patterns of interest.
	******************************/

	public enum PatternOptions
	{
		[Description("A")]
		A,
		[Description("all")]
		All,
		[Description("B")]
		B,
		[Description("C")]
		C,
		[Description("D")]
		D,
		[Description("E")]
		BigE
	}

	/******************************
	*** Enum Name: points

	*** Description: If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the violins are shown with no sample points. Defaults to *suspectedoutliers* when `marker.outliercolor` or `marker.line.outliercolor` is set, otherwise defaults to *outliers*.
	******************************/

	public enum PointsOptions
	{
		[Description("all")]
		All,
		[Description("outliers")]
		Outliers,
		[Description("suspectedoutliers")]
		Suspectedoutliers,
		[Description("False")]
		False
	}

	/******************************
	*** Enum Name: position

	*** Description: Specifies the location of the `title`. Note that the title's position used to be set by the now deprecated `titleposition` attribute.
	******************************/

	public enum PositionOptions
	{
		[Description("top")]
		Top,
		[Description("top left")]
		TopLeft,
		[Description("top center")]
		TopCenter,
		[Description("top right")]
		TopRight
	}

	/******************************
	*** Enum Name: quartilemethod

	*** Description: Sets the method used to compute the sample's Q1 and Q3 quartiles. The *linear* method uses the 25th percentile for Q1 and 75th percentile for Q3 as computed using method #10 (listed on http://www.amstat.org/publications/jse/v14n3/langford.html). The *exclusive* method uses the median to divide the ordered dataset into two halves if the sample is odd, it does not include the median in either half - Q1 is then the median of the lower half and Q3 the median of the upper half. The *inclusive* method also uses the median to divide the ordered dataset into two halves but if the sample is odd, it includes the median in both halves - Q1 is then the median of the lower half and Q3 the median of the upper half.
	******************************/

	public enum QuartileMethodOptions
	{
		[Description("linear")]
		Linear,
		[Description("exclusive")]
		Exclusive,
		[Description("inclusive")]
		Inclusive
	}


	/******************************
	*** Enum Name: scalemode

	*** Description: Sets the metric by which the width of each violin is determined.*width* means each violin has the same (max) width*count* means the violins are scaled by the number of sample points makingup each violin.
	******************************/

	public enum ScaleModeOptions
	{
		[Description("width")]
		Width,
		[Description("count")]
		Count
	}

	/******************************
	*** Enum Name: shape

	*** Description: Sets the shape of the pattern fill. By default, no pattern is used for filling the area.
	******************************/

	public enum ShapeOptions
	{
		[Description("/")]
		ForwardSlash,
		[Description("\\")]
		BackSlash,
		[Description("x")]
		X,
		[Description("-")]
		Auto,
		[Description("|")]
		Pipe,
		[Description("+")]
		Plus,
		[Description(".")]
		Dot
	}

	

	



	

	/******************************
	*** Enum Name: side

	*** Description: Determines the location of color bar's title with respect to the color bar. Defaults to *top* when `orientation` if *v* and  defaults to *right* when `orientation` if *h*. Note that the title's location used to be set by the now deprecated `titleside` attribute.
	******************************/

	public enum SideOptions
	{
		[Description("right")]
		Right,
		[Description("top")]
		Top,
		[Description("bottom")]
		Bottom
	}

	/******************************
	*** Enum Name: sizemode

	*** Description: Determines whether `sizeref` is set as a *scaled* (i.e unitless) scalar (normalized by the max u/v/w norm in the vector field) or as *absolute* value (in the same units as the vector field).
	******************************/

	public enum SizeModeOptions
	{
		[Description("scaled")]
		Scaled,
		[Description("absolute")]
		Absolute
	}

	/******************************
	*** Enum Name: sortpaths

	*** Description: Sets the path sorting algorithm. If `forward`, sort paths based on dimension categories from left to right. If `backward`, sort paths based on dimensions categories from right to left.
	******************************/

	public enum SortPathsOptions
	{
		[Description("forward")]
		Forward,
		[Description("backward")]
		Backward
	}

	/******************************
	*** Enum Name: spanmode

	*** Description: Sets the method by which the span in data space where the density function will be computed. *soft* means the span goes from the sample's minimum value minus two bandwidths to the sample's maximum value plus two bandwidths. *hard* means the span goes from the sample's minimum to its maximum value. For custom span settings, use mode *manual* and fill in the `span` attribute.
	******************************/

	public enum SpanModeOptions
	{
		[Description("soft")]
		Soft,
		[Description("hard")]
		Hard,
		[Description("manual")]
		Manual
	}

	/******************************
	*** Enum Name: stackgaps

	*** Description: Only relevant when `stackgroup` is used, and only the first `stackgaps` found in the `stackgroup` will be used - including if `visible` is *legendonly* but not if it is `false`. Determines how we handle locations at which other traces in this group have data but this one does not. With *infer zero* we insert a zero at these locations. With *interpolate* we linearly interpolate between existing values, and extrapolate a constant beyond the existing values.
	******************************/

	public enum StackGapsOptions
	{
		[Description("infer zero")]
		InferZero,
		[Description("interpolate")]
		Interpolate
	}

	/******************************
	*** Enum Name: surfaceaxis

	*** Description: If *-1*, the scatter points are not fill with a surface If *0*, *1*, *2*, the scatter points are filled with a Delaunay surface about the x, y, z respectively.
	******************************/

	public enum SurfaceAxisOptions
	{
		[Description("-1")]
		Neg1,
		[Description("0")]
		Zero,
		[Description("1")]
		Plus1,
		[Description("2")]
		Plus2
	}

	/******************************
	*** Enum Name: symbol

	*** Description: Sets the marker symbol type. Adding 100 is equivalent to appending *-open* to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to a symbol name.
	******************************/

	public enum SymbolOptions
	{
		[Description("0")]
		Circle,
		[Description("100")]
		CircleOpen,
		[Description("200")]
		CircleDot,
		[Description("300")]
		CircleOpenDot,
		[Description("1")]
		Square,
		[Description("101")]
		SquareOpen,
		[Description("201")]
		SquareDot,
		[Description("301")]
		SquareOpenDot,
		[Description("2")]
		Diamond,
		[Description("102")]
		DiamondOpen,
		[Description("202")]
		DiamondDot,
		[Description("302")]
		DiamondOpenDot,
		[Description("3")]
		Cross,
		[Description("103")]
		CrossOpen,
		[Description("203")]
		CrossDot,
		[Description("303")]
		CrossOpenDot,
		[Description("4")]
		X,
		[Description("104")]
		XOpen,
		[Description("204")]
		XDot,
		[Description("304")]
		XOpenDot,
		[Description("5")]
		TriangleUp,
		[Description("105")]
		TriangleUpOpen,
		[Description("205")]
		TriangleUpDot,
		[Description("305")]
		TriangleUpOpenDot,
		[Description("6")]
		TriangleDown,
		[Description("106")]
		TriangleDownOpen,
		[Description("206")]
		TriangleDownDot,
		[Description("306")]
		TriangleDownOpenDot,
		[Description("7")]
		TriangleLeft,
		[Description("107")]
		TriangleLeftOpen,
		[Description("207")]
		TriangleLeftDot,
		[Description("307")]
		TriangleLeftOpenDot,
		[Description("8")]
		TriangleRight,
		[Description("108")]
		TriangleRightOpen,
		[Description("208")]
		TriangleRightDot,
		[Description("308")]
		TriangleRightOpenDot,
		[Description("9")]
		TriangleNe,
		[Description("109")]
		TriangleNeOpen,
		[Description("209")]
		TriangleNeDot,
		[Description("309")]
		TriangleNeOpenDot,
		[Description("10")]
		TriangleSe,
		[Description("110")]
		TriangleSeOpen,
		[Description("210")]
		TriangleSeDot,
		[Description("310")]
		TriangleSeOpenDot,
		[Description("11")]
		TriangleSw,
		[Description("111")]
		TriangleSwOpen,
		[Description("211")]
		TriangleSwDot,
		[Description("311")]
		TriangleSwOpenDot,
		[Description("12")]
		TriangleNw,
		[Description("112")]
		TriangleNwOpen,
		[Description("212")]
		TriangleNwDot,
		[Description("312")]
		TriangleNwOpenDot,
		[Description("13")]
		Pentagon,
		[Description("113")]
		PentagonOpen,
		[Description("213")]
		PentagonDot,
		[Description("313")]
		PentagonOpenDot,
		[Description("14")]
		Hexagon,
		[Description("114")]
		HexagonOpen,
		[Description("214")]
		HexagonDot,
		[Description("314")]
		HexagonOpenDot,
		[Description("15")]
		Hexagon2,
		[Description("115")]
		Hexagon2Open,
		[Description("215")]
		Hexagon2Dot,
		[Description("315")]
		Hexagon2OpenDot,
		[Description("16")]
		Octagon,
		[Description("116")]
		OctagonOpen,
		[Description("216")]
		OctagonDot,
		[Description("316")]
		OctagonOpenDot,
		[Description("17")]
		Star,
		[Description("117")]
		StarOpen,
		[Description("217")]
		StarDot,
		[Description("317")]
		StarOpenDot,
		[Description("18")]
		Hexagram,
		[Description("118")]
		HexagramOpen,
		[Description("218")]
		HexagramDot,
		[Description("318")]
		HexagramOpenDot,
		[Description("19")]
		StarTriangleUp,
		[Description("119")]
		StarTriangleUpOpen,
		[Description("219")]
		StarTriangleUpDot,
		[Description("319")]
		StarTriangleUpOpenDot,
		[Description("20")]
		StarTriangleDown,
		[Description("120")]
		StarTriangleDownOpen,
		[Description("220")]
		StarTriangleDownDot,
		[Description("320")]
		StarTriangleDownOpenDot,
		[Description("21")]
		StarSquare,
		[Description("121")]
		StarSquareOpen,
		[Description("221")]
		StarSquareDot,
		[Description("321")]
		StarSquareOpenDot,
		[Description("22")]
		StarDiamond,
		[Description("122")]
		StarDiamondOpen,
		[Description("222")]
		StarDiamondDot,
		[Description("322")]
		StarDiamondOpenDot,
		[Description("23")]
		DiamondTall,
		[Description("123")]
		DiamondTallOpen,
		[Description("223")]
		DiamondTallDot,
		[Description("323")]
		DiamondTallOpenDot,
		[Description("24")]
		DiamondWide,
		[Description("124")]
		DiamondWideOpen,
		[Description("224")]
		DiamondWideDot,
		[Description("324")]
		DiamondWideOpenDot,
		[Description("25")]
		Hourglass,
		[Description("125")]
		HourglassOpen,
		[Description("26")]
		Bowtie,
		[Description("126")]
		BowtieOpen,
		[Description("27")]
		CircleCross,
		[Description("127")]
		CircleCrossOpen,
		[Description("28")]
		CircleX,
		[Description("128")]
		CircleXOpen,
		[Description("29")]
		SquareCross,
		[Description("129")]
		SquareCrossOpen,
		[Description("30")]
		SquareX,
		[Description("130")]
		SquareXOpen,
		[Description("31")]
		DiamondCross,
		[Description("131")]
		DiamondCrossOpen,
		[Description("32")]
		DiamondX,
		[Description("132")]
		DiamondXOpen,
		[Description("33")]
		CrossThin,
		[Description("133")]
		CrossThinOpen,
		[Description("34")]
		XThin,
		[Description("134")]
		XThinOpen,
		[Description("35")]
		Asterisk,
		[Description("135")]
		AsteriskOpen,
		[Description("36")]
		Hash,
		[Description("136")]
		HashOpen,
		[Description("236")]
		HashDot,
		[Description("336")]
		HashOpenDot,
		[Description("37")]
		YUp,
		[Description("137")]
		YUpOpen,
		[Description("38")]
		YDown,
		[Description("138")]
		YDownOpen,
		[Description("39")]
		YLeft,
		[Description("139")]
		YLeftOpen,
		[Description("40")]
		YRight,
		[Description("140")]
		YRightOpen,
		[Description("41")]
		LineEw,
		[Description("141")]
		LineEwOpen,
		[Description("42")]
		LineNs,
		[Description("142")]
		LineNsOpen,
		[Description("43")]
		LineNe,
		[Description("143")]
		LineNeOpen,
		[Description("44")]
		LineNw,
		[Description("144")]
		LineNwOpen,
		[Description("45")]
		ArrowUp,
		[Description("145")]
		ArrowUpOpen,
		[Description("46")]
		ArrowDown,
		[Description("146")]
		ArrowDownOpen,
		[Description("47")]
		ArrowLeft,
		[Description("147")]
		ArrowLeftOpen,
		[Description("48")]
		ArrowRight,
		[Description("148")]
		ArrowRightOpen,
		[Description("49")]
		ArrowBarUp,
		[Description("149")]
		ArrowBarUpOpen,
		[Description("50")]
		ArrowBarDown,
		[Description("150")]
		ArrowBarDownOpen,
		[Description("51")]
		ArrowBarLeft,
		[Description("151")]
		ArrowBarLeftOpen,
		[Description("52")]
		ArrowBarRight,
		[Description("152")]
		ArrowBarRightOpen
	}

	/******************************
	*** Enum Name: textinfo

	*** Description: Determines which trace information appear on the graph. In the case of having multiple funnels, percentages & totals are computed separately (per trace).
	******************************/

	public enum TextInfoOptions
	{
		[Description("label")]
		Label,
		[Description("text")]
		Text,
		[Description("percent initial")]
		PercentInitial,
		[Description("percent previous")]
		PercentPrevious,
		[Description("percent total")]
		PercentTotal,
		[Description("value")]
		Value,
		[Description("value+percent initial")]
		Value_PercentInitial
	}

	/******************************
	*** Enum Name: textposition

	*** Description: Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside. If *none*, no text appears.
	******************************/

	public enum TextPositionOptions
	{
		[Description("inside")]
		Inside,
		[Description("outside")]
		Outside,
		[Description("auto")]
		Auto,
		[Description("none")]
		None
	}

	/******************************
	*** Enum Name: thetaunit

	*** Description: Sets the unit of input *theta* values. Has an effect only when on *linear* angular axes.
	******************************/

	public enum ThetaUnitOptions
	{
		[Description("radians")]
		Radians,
		[Description("degrees")]
		Degrees,
		[Description("gradians")]
		Gradians
	}

	

	


	/******************************
	*** Enum Name: violinmode

	*** Description: Determines how violins at the same location coordinate are displayed on the graph. If *group*, the violins are plotted next to one another centered around the shared location. If *overlay*, the violins are plotted over one another, you might need to set *opacity* to see them multiple violins. Has no effect on traces that have *width* set.
	******************************/

	public enum ViolinModeOptions
	{
		[Description("group")]
		Group,
		[Description("overlay")]
		Overlay
	}

	/******************************
	*** Enum Name: visible

	*** Description: Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
	******************************/

	public enum VisibleOptions
	{
		[Description("True")]
		True,
		[Description("False")]
		False,
		[Description("legendonly")]
		Legendonly
	}

	/******************************
	*** Enum Name: waterfallmode

	*** Description: Determines how bars at the same location coordinate are displayed on the graph. With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
	******************************/

	public enum WaterfallModeOptions
	{
		[Description("group")]
		Group,
		[Description("overlay")]
		Overlay
	}

	

	/******************************
	*** Enum Name: xcalendar

	*** Description: Sets the calendar system to use with `x` date data.
	******************************/

	public enum XCalendarOptions
	{
		[Description("chinese")]
		Chinese,
		[Description("coptic")]
		Coptic,
		[Description("discworld")]
		Discworld,
		[Description("ethiopian")]
		Ethiopian,
		[Description("gregorian")]
		Gregorian,
		[Description("hebrew")]
		Hebrew,
		[Description("islamic")]
		Islamic,
		[Description("jalali")]
		Jalali,
		[Description("julian")]
		Julian,
		[Description("mayan")]
		Mayan,
		[Description("nanakshahi")]
		Nanakshahi,
		[Description("nepali")]
		Nepali,
		[Description("persian")]
		Persian,
		[Description("taiwan")]
		Taiwan,
		[Description("thai")]
		Thai,
		[Description("ummalqura")]
		Ummalqura
	}

	/******************************
	*** Enum Name: xperiodalignment

	*** Description: Only relevant when the axis `type` is *date*. Sets the alignment of data points on the x axis.
	******************************/

	public enum XPeriodAlignmentOptions
	{
		[Description("start")]
		Start,
		[Description("middle")]
		Middle,
		[Description("end")]
		End
	}

	

	/******************************
	*** Enum Name: xtype

	*** Description: If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
	******************************/

	public enum XTypeOptions
	{
		[Description("array")]
		Array,
		[Description("scaled")]
		Scaled
	}



	/******************************
	*** Enum Name: ycalendar

	*** Description: Sets the calendar system to use with `y` date data.
	******************************/

	public enum YCalendarOptions
	{
		[Description("chinese")]
		Chinese,
		[Description("coptic")]
		Coptic,
		[Description("discworld")]
		Discworld,
		[Description("ethiopian")]
		Ethiopian,
		[Description("gregorian")]
		Gregorian,
		[Description("hebrew")]
		Hebrew,
		[Description("islamic")]
		Islamic,
		[Description("jalali")]
		Jalali,
		[Description("julian")]
		Julian,
		[Description("mayan")]
		Mayan,
		[Description("nanakshahi")]
		Nanakshahi,
		[Description("nepali")]
		Nepali,
		[Description("persian")]
		Persian,
		[Description("taiwan")]
		Taiwan,
		[Description("thai")]
		Thai,
		[Description("ummalqura")]
		Ummalqura
	}

	/******************************
	*** Enum Name: yperiodalignment

	*** Description: Only relevant when the axis `type` is *date*. Sets the alignment of data points on the y axis.
	******************************/

	public enum YPeriodAlignmentOptions
	{
		[Description("start")]
		Start,
		[Description("middle")]
		Middle,
		[Description("end")]
		End
	}

	

	/******************************
	*** Enum Name: ytype

	*** Description: If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
	******************************/

	public enum YTypeOptions
	{
		[Description("array")]
		Array,
		[Description("scaled")]
		Scaled
	}

	/******************************
	*** Enum Name: zcalendar

	*** Description: Sets the calendar system to use with `z` date data.
	******************************/

	public enum ZCalendarOptions
	{
		[Description("chinese")]
		Chinese,
		[Description("coptic")]
		Coptic,
		[Description("discworld")]
		Discworld,
		[Description("ethiopian")]
		Ethiopian,
		[Description("gregorian")]
		Gregorian,
		[Description("hebrew")]
		Hebrew,
		[Description("islamic")]
		Islamic,
		[Description("jalali")]
		Jalali,
		[Description("julian")]
		Julian,
		[Description("mayan")]
		Mayan,
		[Description("nanakshahi")]
		Nanakshahi,
		[Description("nepali")]
		Nepali,
		[Description("persian")]
		Persian,
		[Description("taiwan")]
		Taiwan,
		[Description("thai")]
		Thai,
		[Description("ummalqura")]
		Ummalqura
	}

	/******************************
	*** Enum Name: zsmooth

	*** Description: Picks a smoothing algorithm use to smooth `z` data.
	******************************/

	public enum ZSmoothOptions
	{
		[Description("fast")]
		Fast,
		[Description("best")]
		Best,
		[Description("False")]
		False
	}


}
