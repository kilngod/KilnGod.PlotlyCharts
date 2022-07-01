//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyEnums.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Enumerations
{

		/******************************
		*** Enum Name: AnchorAxisOptions
		***
		*** Description: If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
		***
		*** Source: anchor
		******************************/

		public enum AnchorAxisOptions
		{
			[Description("free")]
			Free,
			[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_X,
			[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_Y
		}

		/******************************
		*** Enum Name: AnchorConeOptions
		***
		*** Description: Sets the cones' anchor with respect to their x/y/z positions. Note that *cm* denote the cone's center of mass which corresponds to 1/4 from the tail to tip.
		***
		*** Source: anchor
		******************************/

		public enum AnchorConeOptions
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
		*** Enum Name: AngularAxisLayerOptions
		***
		*** Description: Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
		***
		*** Source: layer
		******************************/

		public enum AngularAxisLayerOptions
		{
			[Description("above traces")]
			AboveTraces,
			[Description("below traces")]
			BelowTraces
		}

		/******************************
		*** Enum Name: AngularThetaUnitOptions
		***
		*** Description: Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*.
		***
		*** Source: thetaunit
		******************************/

		public enum AngularThetaUnitOptions
		{
			[Description("radians")]
			Radians,
			[Description("degrees")]
			Degrees
		}

		/******************************
		*** Enum Name: AreaHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum AreaHoverOptions
		{
			[Description("label")]
			Label,
			[Description("text")]
			Text,
			[Description("value")]
			Value,
			[Description("percent")]
			Percent,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: ArrayTypeOptions
		***
		*** Description: If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
		***
		*** Source: xtype
		******************************/

		public enum ArrayTypeOptions
		{
			[Description("array")]
			Array,
			[Description("scaled")]
			Scaled
		}

		/******************************
		*** Enum Name: ArrowSideOptions
		***
		*** Description: Sets the annotation arrow head position.
		***
		*** Source: arrowside
		******************************/

		public enum ArrowSideOptions
		{
			[Description("end")]
			End,
			[Description("start")]
			Start
		}

		/******************************
		*** Enum Name: AspectModeOptions
		***
		*** Description: If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used.
		***
		*** Source: aspectmode
		******************************/

		public enum AspectModeOptions
		{
			[Description("auto")]
			Auto,
			[Description("cube")]
			Cube,
			[Description("data")]
			Data,
			[Description("manual")]
			Manual
		}

		/******************************
		*** Enum Name: AutoCategoryLinearAxisTypeOptions
		***
		*** Description: Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis.
		***
		*** Source: type
		******************************/

		public enum AutoCategoryLinearAxisTypeOptions
		{
			[Description("-")]
			Auto,
			[Description("linear")]
			Linear,
			[Description("category")]
			Category
		}

		/******************************
		*** Enum Name: AutoDateCategoryLinearTypeOptions
		***
		*** Description: Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
		***
		*** Source: type
		******************************/

		public enum AutoDateCategoryLinearTypeOptions
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
		*** Enum Name: AutoLinearArrayTickModeOptions
		***
		*** Description: Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
		***
		*** Source: tickmode
		******************************/

		public enum AutoLinearArrayTickModeOptions
		{
			[Description("auto")]
			Auto,
			[Description("linear")]
			Linear,
			[Description("array")]
			Array
		}

		/******************************
		*** Enum Name: AutoRangeOptions
		***
		*** Description: Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
		***
		*** Source: autorange
		******************************/

		public enum AutoRangeOptions
		{
			[Description("true")]
			True,
			[Description("false")]
			False,
			[Description("reversed")]
			Reversed
		}

		/******************************
		*** Enum Name: AutoTopMiddleBottomOptions
		***
		*** Description: Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
		***
		*** Source: yanchor
		******************************/

		public enum AutoTopMiddleBottomOptions
		{
			[Description("auto")]
			Auto,
			[Description("top")]
			Top,
			[Description("middle")]
			Middle,
			[Description("bottom")]
			Bottom
		}

		/******************************
		*** Enum Name: AutoTypeNumbersOptions
		***
		*** Description: Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. This is the default value; however it could be overridden for individual axes.
		***
		*** Source: autotypenumbers
		******************************/

		public enum AutoTypeNumbersOptions
		{
			[Description("convert types")]
			ConvertTypes,
			[Description("strict")]
			Strict
		}

		/******************************
		*** Enum Name: AxisLayerOptions
		***
		*** Description: Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
		***
		*** Source: layer
		******************************/

		public enum AxisLayerOptions
		{
			[Description("above traces")]
			AboveTraces,
			[Description("below traces")]
			BelowTraces
		}

		/******************************
		*** Enum Name: AxisTypeOptions
		***
		*** Description: Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
		***
		*** Source: type
		******************************/

		public enum AxisTypeOptions
		{
			[Description("-")]
			Auto,
			[Description("linear")]
			Linear,
			[Description("log")]
			Log,
			[Description("date")]
			Date,
			[Description("category")]
			Category,
			[Description("multicategory")]
			Multicategory
		}

		/******************************
		*** Enum Name: AXRefOptions
		***
		*** Description: Indicates in what coordinates the tail of the annotation (ax,ay) is specified. If set to a ax axis id (e.g. *ax* or *ax2*), the `ax` position refers to a ax coordinate. If set to *paper*, the `ax` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a ax axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *ax2 domain* refers to the domain of the second ax  axis and a ax position of 0.5 refers to the point between the left and the right of the domain of the second ax axis. In order for absolute positioning of the arrow to work, *axref* must be exactly the same as *xref*, otherwise *axref* will revert to *pixel* (explained next). For relative positioning, *axref* can be set to *pixel*, in which case the *ax* value is specified in pixels relative to *x*. Absolute positioning is useful for trendline annotations which should continue to indicate the correct trend when zoomed. Relative positioning is useful for specifying the text offset for an annotated point.
		***
		*** Source: axref
		******************************/

		public enum AXRefOptions
		{
			[Description("pixel")]
			Pixel,
			[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_X
		}

		/******************************
		*** Enum Name: AYRefOptions
		***
		*** Description: Indicates in what coordinates the tail of the annotation (ax,ay) is specified. If set to a ay axis id (e.g. *ay* or *ay2*), the `ay` position refers to a ay coordinate. If set to *paper*, the `ay` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a ay axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *ay2 domain* refers to the domain of the second ay  axis and a ay position of 0.5 refers to the point between the bottom and the top of the domain of the second ay axis. In order for absolute positioning of the arrow to work, *ayref* must be exactly the same as *yref*, otherwise *ayref* will revert to *pixel* (explained next). For relative positioning, *ayref* can be set to *pixel*, in which case the *ay* value is specified in pixels relative to *y*. Absolute positioning is useful for trendline annotations which should continue to indicate the correct trend when zoomed. Relative positioning is useful for specifying the text offset for an annotated point.
		***
		*** Source: ayref
		******************************/

		public enum AYRefOptions
		{
			[Description("pixel")]
			Pixel,
			[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_Y
		}

		/******************************
		*** Enum Name: BarModeOptions
		***
		*** Description: Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *relative*, the bars are stacked on top of one another, with negative values below the axis, positive values above With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
		***
		*** Source: barmode
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
		*** Enum Name: BarPolarBarModeOptions
		***
		*** Description: Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
		***
		*** Source: barmode
		******************************/

		public enum BarPolarBarModeOptions
		{
			[Description("stack")]
			Stack,
			[Description("overlay")]
			Overlay
		}

		/******************************
		*** Enum Name: BarPolarHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum BarPolarHoverOptions
		{
			[Description("r")]
			R,
			[Description("theta")]
			Theta,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: BarPolarThetaUnitOptions
		***
		*** Description: Sets the unit of input *theta* values. Has an effect only when on *linear* angular axes.
		***
		*** Source: thetaunit
		******************************/

		public enum BarPolarThetaUnitOptions
		{
			[Description("radians")]
			Radians,
			[Description("degrees")]
			Degrees,
			[Description("gradians")]
			Gradians
		}

		/******************************
		*** Enum Name: BoxHoverOnOptions
		***
		*** Description: Do the hover effects highlight individual boxes  or sample points or both?
		***
		*** Source: hoveron
		******************************/

		public enum BoxHoverOnOptions
		{
			[Description("boxes")]
			Boxes,
			[Description("points")]
			Points
		}

		/******************************
		*** Enum Name: BoxMeanOptions
		***
		*** Description: If *true*, the mean of the box(es)' underlying distribution is drawn as a dashed line inside the box(es). If *sd* the standard deviation is also drawn. Defaults to *true* when `mean` is set. Defaults to *sd* when `sd` is set Otherwise defaults to *false*.
		***
		*** Source: boxmean
		******************************/

		public enum BoxMeanOptions
		{
			[Description("true")]
			True,
			[Description("sd")]
			Sd,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: BoxPointsOptions
		***
		*** Description: If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the box(es) are shown with no sample points Defaults to *suspectedoutliers* when `marker.outliercolor` or `marker.line.outliercolor` is set. Defaults to *all* under the q1/median/q3 signature. Otherwise defaults to *outliers*.
		***
		*** Source: boxpoints
		******************************/

		public enum BoxPointsOptions
		{
			[Description("all")]
			All,
			[Description("outliers")]
			Outliers,
			[Description("suspectedoutliers")]
			Suspectedoutliers,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: BranchValuesOptions
		***
		*** Description: Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
		***
		*** Source: branchvalues
		******************************/

		public enum BranchValuesOptions
		{
			[Description("remainder")]
			Remainder,
			[Description("total")]
			Total
		}

		/******************************
		*** Enum Name: CalendarOptions
		***
		*** Description: Sets the default calendar system to use for interpreting and displaying dates throughout the plot.
		***
		*** Source: calendar
		******************************/

		public enum CalendarOptions
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
		*** Enum Name: CameraProjectionTypeOptions
		***
		*** Description: Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
		***
		*** Source: type
		******************************/

		public enum CameraProjectionTypeOptions
		{
			[Description("perspective")]
			Perspective,
			[Description("orthographic")]
			Orthographic
		}

		/******************************
		*** Enum Name: CarpetHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum CarpetHoverOptions
		{
			[Description("a")]
			A,
			[Description("b")]
			B,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: CategoryDateLinearLogAxisTypeOptions
		***
		*** Description: Sets the axis type for this dimension's generated x and y axes. Note that the axis `type` values set in layout take precedence over this attribute.
		***
		*** Source: type
		******************************/

		public enum CategoryDateLinearLogAxisTypeOptions
		{
			[Description("linear")]
			Linear,
			[Description("log")]
			Log,
			[Description("date")]
			Date,
			[Description("category")]
			Category
		}

		/******************************
		*** Enum Name: CategoryOrderLayoutOptions
		***
		*** Description: Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
		***
		*** Source: categoryorder
		******************************/

		public enum CategoryOrderLayoutOptions
		{
			[Description("trace")]
			Trace,
			[Description("category ascending")]
			CategoryAscending,
			[Description("category descending")]
			CategoryDescending,
			[Description("array")]
			Array,
			[Description("total ascending")]
			TotalAscending,
			[Description("total descending")]
			TotalDescending,
			[Description("min ascending")]
			MinAscending,
			[Description("min descending")]
			MinDescending,
			[Description("max ascending")]
			MaxAscending,
			[Description("max descending")]
			MaxDescending,
			[Description("sum ascending")]
			SumAscending,
			[Description("sum descending")]
			SumDescending,
			[Description("mean ascending")]
			MeanAscending,
			[Description("mean descending")]
			MeanDescending,
			[Description("median ascending")]
			MedianAscending,
			[Description("median descending")]
			MedianDescending
		}

		/******************************
		*** Enum Name: CategoryOrderOptions
		***
		*** Description: Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
		***
		*** Source: categoryorder
		******************************/

		public enum CategoryOrderOptions
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
		*** Enum Name: CheaterTypeOptions
		***
		*** Description: 
		***
		*** Source: cheatertype
		******************************/

		public enum CheaterTypeOptions
		{
			[Description("index")]
			Index,
			[Description("value")]
			Value
		}

		/******************************
		*** Enum Name: ChoroplethHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum ChoroplethHoverOptions
		{
			[Description("location")]
			Location,
			[Description("z")]
			Z,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: ClickModeOptions
		***
		*** Description: Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
		***
		*** Source: clickmode
		******************************/

		public enum ClickModeOptions
		{
			[Description("event")]
			Event,
			[Description("select")]
			Select
		}

		/******************************
		*** Enum Name: ClickToShowOptions
		***
		*** Description: Makes this annotation respond to clicks on the plot. If you click a data point that exactly matches the `x` and `y` values of this annotation, and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same point again to make it disappear, so if you click multiple points, you can show multiple annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not) will hide this annotation. If you need to show/hide this annotation in response to different `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
		***
		*** Source: clicktoshow
		******************************/

		public enum ClickToShowOptions
		{
			[Description("false")]
			False,
			[Description("onoff")]
			OnOff,
			[Description("onout")]
			OnOut
		}

		/******************************
		*** Enum Name: ColoringOptions
		***
		*** Description: Determines the coloring method showing the contour values. If *fill*, coloring is done evenly between each contour level If *heatmap*, a heatmap gradient coloring is applied between each contour level. If *lines*, coloring is done on the contour lines. If *none*, no coloring is applied on this trace.
		***
		*** Source: coloring
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
		*** Enum Name: ColorModelOptions
		***
		*** Description: Color model used to map the numerical color components described in `z` into colors. If `source` is specified, this attribute will be set to `rgba256` otherwise it defaults to `rgb`.
		***
		*** Source: colormodel
		******************************/

		public enum ColorModelOptions
		{
			[Description("rgb")]
			RGB,
			[Description("rgba")]
			RGBA,
			[Description("rgba256")]
			RGBA256,
			[Description("hsl")]
			HSL,
			[Description("hsla")]
			HSLA
		}

		/******************************
		*** Enum Name: ConeHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum ConeHoverOptions
		{
			[Description("x")]
			X,
			[Description("y")]
			Y,
			[Description("z")]
			Z,
			[Description("u")]
			U,
			[Description("v")]
			V,
			[Description("w")]
			W,
			[Description("norm")]
			Norm,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: ConstrainOptions
		***
		*** Description: If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range*, or by decreasing the *domain*. Default is *domain* for axes containing image traces, *range* otherwise.
		***
		*** Source: constrain
		******************************/

		public enum ConstrainOptions
		{
			[Description("range")]
			Range,
			[Description("domain")]
			Domain
		}

		/******************************
		*** Enum Name: ConstrainTextOptions
		***
		*** Description: Constrain the size of text inside or outside a bar to be no larger than the bar itself.
		***
		*** Source: constraintext
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
		*** Enum Name: ConstrainTowardOptions
		***
		*** Description: If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
		***
		*** Source: constraintoward
		******************************/

		public enum ConstrainTowardOptions
		{
			[Description("left")]
			Left,
			[Description("center")]
			Center,
			[Description("right")]
			Right,
			[Description("top")]
			Top,
			[Description("middle")]
			Middle,
			[Description("bottom")]
			Bottom
		}

		/******************************
		*** Enum Name: ContoursOperationOptions
		***
		*** Description: Sets the constraint operation. *=* keeps regions equal to `value` *<* and *<=* keep regions less than `value` *>* and *>=* keep regions greater than `value` *[]*, *()*, *[)*, and *(]* keep regions inside `value[0]` to `value[1]` *][*, *)(*, *](*, *)[* keep regions outside `value[0]` to value[1]` Open vs. closed intervals make no difference to constraint display, but all versions are allowed for consistency with filter transforms.
		***
		*** Source: operation
		******************************/

		public enum ContoursOperationOptions
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
		*** Enum Name: ContoursTypeOptions
		***
		*** Description: If `levels`, the data is represented as a contour plot with multiple levels displayed. If `constraint`, the data is represented as constraints with the invalid region shaded as specified by the `operation` and `value` parameters.
		***
		*** Source: type
		******************************/

		public enum ContoursTypeOptions
		{
			[Description("levels")]
			Levels,
			[Description("constraint")]
			Constraint
		}

		/******************************
		*** Enum Name: CountOptions
		***
		*** Description: Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
		***
		*** Source: count
		******************************/

		public enum CountOptions
		{
			[Description("branches")]
			Branches,
			[Description("leaves")]
			Leaves
		}

		/******************************
		*** Enum Name: CumulativeDirectionOptions
		***
		*** Description: Only applies if cumulative is enabled. If *increasing* (default) we sum all prior bins, so the result increases from left to right. If *decreasing* we sum later bins so the result decreases from left to right.
		***
		*** Source: direction
		******************************/

		public enum CumulativeDirectionOptions
		{
			[Description("increasing")]
			Increasing,
			[Description("decreasing")]
			Decreasing
		}

		/******************************
		*** Enum Name: CurrentBinOptions
		***
		*** Description: Only applies if cumulative is enabled. Sets whether the current bin is included, excluded, or has half of its value included in the current cumulative value. *include* is the default for compatibility with various other tools, however it introduces a half-bin bias to the results. *exclude* makes the opposite half-bin bias, and *half* removes it.
		***
		*** Source: currentbin
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
		*** Enum Name: DashOptions
		***
		*** Description: Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
		***
		*** Source: dash
		******************************/

		public enum DashOptions
		{
			[Description("solid")]
			Solid,
			[Description("dot")]
			Dot,
			[Description("dash")]
			Dash,
			[Description("longdash")]
			LongDash,
			[Description("dashdot")]
			DashDot,
			[Description("longdashdot")]
			LongDashDot
		}

		/******************************
		*** Enum Name: DelaunayAxisOptions
		***
		*** Description: Sets the Delaunay axis, which is the axis that is perpendicular to the surface of the Delaunay triangulation. It has an effect if `i`, `j`, `k` are not provided and `alphahull` is set to indicate Delaunay triangulation.
		***
		*** Source: delaunayaxis
		******************************/

		public enum DelaunayAxisOptions
		{
			[Description("x")]
			X,
			[Description("y")]
			Y,
			[Description("z")]
			Z
		}

		/******************************
		*** Enum Name: DensityMapboxHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum DensityMapboxHoverOptions
		{
			[Description("lon")]
			Lon,
			[Description("lat")]
			Lat,
			[Description("z")]
			Z,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: DepthFadeOptions
		***
		*** Description: Determines if the sector colors are faded towards the background from the leaves up to the headers. This option is unavailable when a `colorscale` is present, defaults to false when `marker.colors` is set, but otherwise defaults to true. When set to *reversed*, the fading direction is inverted, that is the top elements within hierarchy are drawn with fully saturated colors while the leaves are faded towards the background color.
		***
		*** Source: depthfade
		******************************/

		public enum DepthFadeOptions
		{
			[Description("true")]
			True,
			[Description("false")]
			False,
			[Description("reversed")]
			Reversed
		}

		/******************************
		*** Enum Name: DimensionCategoryOrderOptions
		***
		*** Description: Specifies the ordering logic for the categories in the dimension. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
		***
		*** Source: categoryorder
		******************************/

		public enum DimensionCategoryOrderOptions
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
		*** Enum Name: DirectionAnimationOptions
		***
		*** Description: The direction in which to play the frames triggered by the animation call
		***
		*** Source: direction
		******************************/

		public enum DirectionAnimationOptions
		{
			[Description("forward")]
			Forward,
			[Description("reverse")]
			Reverse
		}

		/******************************
		*** Enum Name: DirectionOptions
		***
		*** Description: Sets the direction corresponding to positive angles.
		***
		*** Source: direction
		******************************/

		public enum DirectionOptions
		{
			[Description("counterclockwise")]
			Counterclockwise,
			[Description("clockwise")]
			Clockwise
		}

		/******************************
		*** Enum Name: DisplayModeBarOptions
		***
		*** Description: Determines the mode bar display mode. If *true*, the mode bar is always visible. If *false*, the mode bar is always hidden. If *hover*, the mode bar is visible while the mouse cursor is on the graph container.
		***
		*** Source: displayModeBar
		******************************/

		public enum DisplayModeBarOptions
		{
			[Description("hover")]
			Hover,
			[Description("true")]
			True,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: DoubleClickOptions
		***
		*** Description: Sets the double click interaction mode. Has an effect only in cartesian plots. If *false*, double click is disable. If *reset*, double click resets the axis ranges to their initial values. If *autosize*, double click set the axis ranges to their autorange values. If *reset+autosize*, the odd double clicks resets the axis ranges to their initial values and even double clicks set the axis ranges to their autorange values.
		***
		*** Source: doubleClick
		******************************/

		public enum DoubleClickOptions
		{
			[Description("false")]
			False,
			[Description("reset")]
			Reset,
			[Description("autosize")]
			AutoSize,
			[Description("reset+autosize")]
			Reset_AutoSize
		}

		/******************************
		*** Enum Name: DragModeOptions
		***
		*** Description: Determines the mode of drag interactions for this scene.
		***
		*** Source: dragmode
		******************************/

		public enum DragModeOptions
		{
			[Description("orbit")]
			Orbit,
			[Description("turntable")]
			Turntable,
			[Description("zoom")]
			Zoom,
			[Description("pan")]
			Pan,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: DrawDirectionOptions
		***
		*** Description: When `dragmode` is set to *drawrect*, *drawline* or *drawcircle* this limits the drag to be horizontal, vertical or diagonal. Using *diagonal* there is no limit e.g. in drawing lines in any direction. *ortho* limits the draw to be either horizontal or vertical. *horizontal* allows horizontal extend. *vertical* allows vertical extend.
		***
		*** Source: drawdirection
		******************************/

		public enum DrawDirectionOptions
		{
			[Description("ortho")]
			Ortho,
			[Description("horizontal")]
			Horizontal,
			[Description("vertical")]
			Vertical,
			[Description("diagonal")]
			Diagonal
		}

		/******************************
		*** Enum Name: EasingOptions
		***
		*** Description: The easing function used for the transition
		***
		*** Source: easing
		******************************/

		public enum EasingOptions
		{
			[Description("linear")]
			Linear,
			[Description("quad")]
			Quad,
			[Description("cubic")]
			Cubic,
			[Description("sin")]
			Sin,
			[Description("exp")]
			Exp,
			[Description("circle")]
			Circle,
			[Description("elastic")]
			Elastic,
			[Description("back")]
			Back,
			[Description("bounce")]
			Bounce,
			[Description("linear-in")]
			LinearIn,
			[Description("quad-in")]
			QuadIn,
			[Description("cubic-in")]
			CubicIn,
			[Description("sin-in")]
			SinIn,
			[Description("exp-in")]
			ExpIn,
			[Description("circle-in")]
			CircleIn,
			[Description("elastic-in")]
			ElasticIn,
			[Description("back-in")]
			BackIn,
			[Description("bounce-in")]
			BounceIn,
			[Description("linear-out")]
			LinearOut,
			[Description("quad-out")]
			QuadOut,
			[Description("cubic-out")]
			CubicOut,
			[Description("sin-out")]
			SinOut,
			[Description("exp-out")]
			ExpOut,
			[Description("circle-out")]
			CircleOut,
			[Description("elastic-out")]
			ElasticOut,
			[Description("back-out")]
			BackOut,
			[Description("bounce-out")]
			BounceOut,
			[Description("linear-in-out")]
			LinearInOut,
			[Description("quad-in-out")]
			QuadInOut,
			[Description("cubic-in-out")]
			CubicInOut,
			[Description("sin-in-out")]
			SinInOut,
			[Description("exp-in-out")]
			ExpInOut,
			[Description("circle-in-out")]
			CircleInOut,
			[Description("elastic-in-out")]
			ElasticInOut,
			[Description("back-in-out")]
			BackInOut,
			[Description("bounce-in-out")]
			BounceInOut
		}

		/******************************
		*** Enum Name: EdgeShapeOptions
		***
		*** Description: Determines which shape is used for edges between `barpath` labels.
		***
		*** Source: edgeshape
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
		*** Enum Name: ErrorTypeOptions
		***
		*** Description: Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the square of the underlying data. If *data*, the bar lengths are set with data set `array`.
		***
		*** Source: type
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
		*** Enum Name: ExponentFormatOptions
		***
		*** Description: Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
		***
		*** Source: exponentformat
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
		*** Enum Name: FillMapboxOptions
		***
		*** Description: Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape.
		***
		*** Source: fill
		******************************/

		public enum FillMapboxOptions
		{
			[Description("none")]
			None,
			[Description("toself")]
			ToSelf
		}

		/******************************
		*** Enum Name: FillModeOptions
		***
		*** Description: Determines whether `marker.color` should be used as a default to `bgcolor` or a `fgcolor`.
		***
		*** Source: fillmode
		******************************/

		public enum FillModeOptions
		{
			[Description("replace")]
			Replace,
			[Description("overlay")]
			Overlay
		}

		/******************************
		*** Enum Name: FillOptions
		***
		*** Description: Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape.
		***
		*** Source: fill
		******************************/

		public enum FillOptions
		{
			[Description("none")]
			None,
			[Description("toself")]
			ToSelf
		}

		/******************************
		*** Enum Name: FillPolarGLOptions
		***
		*** Description: Sets the area to fill with a solid color. Defaults to *none* unless this trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints of this trace and the endpoints of the trace before it, connecting those endpoints with straight lines (to make a stacked area graph); if there is no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
		***
		*** Source: fill
		******************************/

		public enum FillPolarGLOptions
		{
			[Description("none")]
			None,
			[Description("tozeroy")]
			ToZeroy,
			[Description("tozerox")]
			ToZerox,
			[Description("tonexty")]
			ToNexty,
			[Description("tonextx")]
			ToNextx,
			[Description("toself")]
			ToSelf,
			[Description("tonext")]
			ToNext
		}

		/******************************
		*** Enum Name: FillPolarOptions
		***
		*** Description: Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterpolar has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
		***
		*** Source: fill
		******************************/

		public enum FillPolarOptions
		{
			[Description("none")]
			None,
			[Description("toself")]
			ToSelf,
			[Description("tonext")]
			ToNext
		}

		/******************************
		*** Enum Name: FillRuleOptions
		***
		*** Description: Determines the path's interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
		***
		*** Source: fillrule
		******************************/

		public enum FillRuleOptions
		{
			[Description("evenodd")]
			EvenOdd,
			[Description("nonzero")]
			NonZero
		}

		/******************************
		*** Enum Name: FillScatterOptions
		***
		*** Description: Sets the area to fill with a solid color. Defaults to *none* unless this trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints of this trace and the endpoints of the trace before it, connecting those endpoints with straight lines (to make a stacked area graph); if there is no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
		***
		*** Source: fill
		******************************/

		public enum FillScatterOptions
		{
			[Description("none")]
			None,
			[Description("tozeroy")]
			ToZeroy,
			[Description("tozerox")]
			ToZerox,
			[Description("tonexty")]
			ToNexty,
			[Description("tonextx")]
			ToNextx,
			[Description("toself")]
			ToSelf,
			[Description("tonext")]
			ToNext
		}

		/******************************
		*** Enum Name: FillSmithInfo
		***
		*** Description: Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scattersmith has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
		***
		*** Source: fill
		******************************/

		public enum FillSmithInfo
		{
			[Description("none")]
			None,
			[Description("toself")]
			ToSelf,
			[Description("tonext")]
			ToNext
		}

		/******************************
		*** Enum Name: FillSubsetOptions
		***
		*** Description: Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterternary has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
		***
		*** Source: fill
		******************************/

		public enum FillSubsetOptions
		{
			[Description("none")]
			None,
			[Description("toself")]
			ToSelf,
			[Description("tonext")]
			ToNext
		}

		/******************************
		*** Enum Name: FinanceHoverInfoOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum FinanceHoverInfoOptions
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
			Name
		}

		/******************************
		*** Enum Name: FitBoundsOptions
		***
		*** Description: Determines if this subplot's view settings are auto-computed to fit trace data. On scoped maps, setting `fitbounds` leads to `center.lon` and `center.lat` getting auto-filled. On maps with a non-clipped projection, setting `fitbounds` leads to `center.lon`, `center.lat`, and `projection.rotation.lon` getting auto-filled. On maps with a clipped projection, setting `fitbounds` leads to `center.lon`, `center.lat`, `projection.rotation.lon`, `projection.rotation.lat`, `lonaxis.range` and `lonaxis.range` getting auto-filled. If *locations*, only the trace's visible locations are considered in the `fitbounds` computations. If *geojson*, the entire trace input `geojson` (if provided) is considered in the `fitbounds` computations, Defaults to *false*.
		***
		*** Source: fitbounds
		******************************/

		public enum FitBoundsOptions
		{
			[Description("false")]
			False,
			[Description("locations")]
			Locations,
			[Description("geojson")]
			GeoJSON
		}

		/******************************
		*** Enum Name: FlipOptions
		***
		*** Description: Determines if the positions obtained from solver are flipped on each axis.
		***
		*** Source: flip
		******************************/

		public enum FlipOptions
		{
			[Description("x")]
			X,
			[Description("y")]
			Y
		}

		/******************************
		*** Enum Name: FuncModeOptions
		***
		*** Description: *stddev* supports two formula variants: *sample* (normalize by N-1) and *population* (normalize by N).
		***
		*** Source: funcmode
		******************************/

		public enum FuncModeOptions
		{
			[Description("sample")]
			Sample,
			[Description("population")]
			Population
		}

		/******************************
		*** Enum Name: FuncOptions
		***
		*** Description: Sets the aggregation function. All values from the linked `target`, corresponding to the same value in the `groups` array, are collected and reduced by this function. *count* is simply the number of values in the `groups` array, so does not even require the linked array to exist. *first* (*last*) is just the first (last) linked value. Invalid values are ignored, so for example in *avg* they do not contribute to either the numerator or the denominator. Any data type (numeric, date, category) may be aggregated with any function, even though in certain cases it is unlikely to make sense, for example a sum of dates or average of categories. *median* will return the average of the two central values if there is an even count. *mode* will return the first value to reach the maximum count, in case of a tie. *change* will return the difference between the first and last linked values. *range* will return the difference between the min and max linked values.
		***
		*** Source: func
		******************************/

		public enum FuncOptions
		{
			[Description("count")]
			Count,
			[Description("sum")]
			Sum,
			[Description("avg")]
			Avg,
			[Description("median")]
			Median,
			[Description("mode")]
			Mode,
			[Description("rms")]
			Rms,
			[Description("stddev")]
			StdDev,
			[Description("min")]
			Min,
			[Description("max")]
			Max,
			[Description("first")]
			First,
			[Description("last")]
			Last,
			[Description("change")]
			Change,
			[Description("range")]
			Range
		}

		/******************************
		*** Enum Name: FunnelAreaTextPositionOptions
		***
		*** Description: Specifies the location of the `textinfo`.
		***
		*** Source: textposition
		******************************/

		public enum FunnelAreaTextPositionOptions
		{
			[Description("inside")]
			Inside,
			[Description("none")]
			None
		}

		/******************************
		*** Enum Name: FunnelHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum FunnelHoverOptions
		{
			[Description("name")]
			Name,
			[Description("x")]
			X,
			[Description("y")]
			Y,
			[Description("text")]
			Text,
			[Description("percent initial")]
			PercentInitial,
			[Description("percent previous")]
			PercentPrevious,
			[Description("percent total")]
			PercentTotal
		}

		/******************************
		*** Enum Name: FunnelModeOptions
		***
		*** Description: Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
		***
		*** Source: funnelmode
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
		*** Enum Name: FunnelTextInfoOptions
		***
		*** Description: Determines which trace information appear on the graph. In the case of having multiple funnels, percentages & totals are computed separately (per trace).
		***
		*** Source: textinfo
		******************************/

		public enum FunnelTextInfoOptions
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
			Value
		}

		/******************************
		*** Enum Name: GeoHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum GeoHoverOptions
		{
			[Description("lon")]
			Lon,
			[Description("lat")]
			Lat,
			[Description("location")]
			Location,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: GeoProjectionTypeOptions
		***
		*** Description: Sets the projection type.
		***
		*** Source: type
		******************************/

		public enum GeoProjectionTypeOptions
		{
			[Description("airy")]
			Airy,
			[Description("aitoff")]
			AitOff,
			[Description("albers")]
			Albers,
			[Description("albers usa")]
			AlbersUsa,
			[Description("august")]
			August,
			[Description("azimuthal equal area")]
			AzimuthalEqualArea,
			[Description("azimuthal equidistant")]
			AzimuthalEquidistant,
			[Description("baker")]
			Baker,
			[Description("bertin1953")]
			Bertin1953,
			[Description("boggs")]
			Boggs,
			[Description("bonne")]
			Bonne,
			[Description("bottomley")]
			Bottomley,
			[Description("bromley")]
			Bromley,
			[Description("collignon")]
			Collignon,
			[Description("conic conformal")]
			ConicConformal,
			[Description("conic equal area")]
			ConicEqualArea,
			[Description("conic equidistant")]
			ConicEquidistant,
			[Description("craig")]
			Craig,
			[Description("craster")]
			Craster,
			[Description("cylindrical equal area")]
			CylindricalEqualArea,
			[Description("cylindrical stereographic")]
			CylindricalStereographic,
			[Description("eckert1")]
			Eckert1,
			[Description("eckert2")]
			Eckert2,
			[Description("eckert3")]
			Eckert3,
			[Description("eckert4")]
			Eckert4,
			[Description("eckert5")]
			Eckert5,
			[Description("eckert6")]
			Eckert6,
			[Description("eisenlohr")]
			Eisenlohr,
			[Description("equirectangular")]
			EquiRectangular,
			[Description("fahey")]
			Fahey,
			[Description("foucaut")]
			Foucaut,
			[Description("foucaut sinusoidal")]
			FoucautSinusoidal,
			[Description("ginzburg4")]
			Ginzburg4,
			[Description("ginzburg5")]
			Ginzburg5,
			[Description("ginzburg6")]
			Ginzburg6,
			[Description("ginzburg8")]
			Ginzburg8,
			[Description("ginzburg9")]
			Ginzburg9,
			[Description("gnomonic")]
			Gnomonic,
			[Description("gringorten")]
			Gringorten,
			[Description("gringorten quincuncial")]
			GringortenQuincuncial,
			[Description("guyou")]
			Guyou,
			[Description("hammer")]
			Hammer,
			[Description("hill")]
			Hill,
			[Description("homolosine")]
			Homolosine,
			[Description("hufnagel")]
			Hufnagel,
			[Description("hyperelliptical")]
			Hyperelliptical,
			[Description("kavrayskiy7")]
			Kavrayskiy7,
			[Description("lagrange")]
			Lagrange,
			[Description("larrivee")]
			Larrivee,
			[Description("laskowski")]
			Laskowski,
			[Description("loximuthal")]
			Loximuthal,
			[Description("mercator")]
			Mercator,
			[Description("miller")]
			Miller,
			[Description("mollweide")]
			Mollweide,
			[Description("mt flat polar parabolic")]
			MtFlatPolarParabolic,
			[Description("mt flat polar quartic")]
			MtFlatPolarQuartic,
			[Description("mt flat polar sinusoidal")]
			MtFlatPolarSinusoidal,
			[Description("natural earth")]
			NaturalEarth,
			[Description("natural earth1")]
			NaturalEarth1,
			[Description("natural earth2")]
			NaturalEarth2,
			[Description("nell hammer")]
			NellHammer,
			[Description("nicolosi")]
			Nicolosi,
			[Description("orthographic")]
			Orthographic,
			[Description("patterson")]
			Patterson,
			[Description("peirce quincuncial")]
			PeirceQuincuncial,
			[Description("polyconic")]
			Polyconic,
			[Description("rectangular polyconic")]
			RectangularPolyconic,
			[Description("robinson")]
			Robinson,
			[Description("satellite")]
			Satellite,
			[Description("sinu mollweide")]
			SinuMollweide,
			[Description("sinusoidal")]
			Sinusoidal,
			[Description("stereographic")]
			Stereographic,
			[Description("times")]
			Times,
			[Description("transverse mercator")]
			TransverseMercator,
			[Description("van der grinten")]
			VanDerGrinten,
			[Description("van der grinten2")]
			VanDerGrinten2,
			[Description("van der grinten3")]
			VanDerGrinten3,
			[Description("van der grinten4")]
			VanDerGrinten4,
			[Description("wagner4")]
			Wagner4,
			[Description("wagner6")]
			Wagner6,
			[Description("wiechel")]
			Wiechel,
			[Description("winkel tripel")]
			WinkelTripel,
			[Description("winkel3")]
			Winkel3
		}

		/******************************
		*** Enum Name: GradientTypeOptions
		***
		*** Description: Sets the type of gradient used to fill the markers
		***
		*** Source: type
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
		*** Enum Name: GridPatternOptions
		***
		*** Description: If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
		***
		*** Source: pattern
		******************************/

		public enum GridPatternOptions
		{
			[Description("independent")]
			Independent,
			[Description("coupled")]
			Coupled
		}

		/******************************
		*** Enum Name: GridShapeOptions
		***
		*** Description: Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
		***
		*** Source: gridshape
		******************************/

		public enum GridShapeOptions
		{
			[Description("circular")]
			Circular,
			[Description("linear")]
			Linear
		}

		/******************************
		*** Enum Name: GroupClickOptions
		***
		*** Description: Determines the behavior on legend group item click. *toggleitem* toggles the visibility of the individual item clicked on the graph. *togglegroup* toggles the visibility of all items in the same legendgroup as the item clicked on the graph.
		***
		*** Source: groupclick
		******************************/

		public enum GroupClickOptions
		{
			[Description("toggleitem")]
			Toggleitem,
			[Description("togglegroup")]
			Togglegroup
		}

		/******************************
		*** Enum Name: GroupOverlayBoxModeOptions
		***
		*** Description: Determines how boxes at the same location coordinate are displayed on the graph. If *group*, the boxes are plotted next to one another centered around the shared location. If *overlay*, the boxes are plotted over one another, you might need to set *opacity* to see them multiple boxes. Has no effect on traces that have *width* set.
		***
		*** Source: boxmode
		******************************/

		public enum GroupOverlayBoxModeOptions
		{
			[Description("group")]
			Group,
			[Description("overlay")]
			Overlay
		}

		/******************************
		*** Enum Name: HistFuncOptions
		***
		*** Description: Specifies the binning function used for this histogram trace. If *count*, the histogram values are computed by counting the number of values lying inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are computed using the sum, the average, the minimum or the maximum of the values lying inside each bin respectively.
		***
		*** Source: histfunc
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
		*** Enum Name: HistNormOptions
		***
		*** Description: Specifies the type of normalization used for this histogram trace. If **, the span of each bar corresponds to the number of occurrences (i.e. the number of data points lying inside the bins). If *percent* / *probability*, the span of each bar corresponds to the percentage / fraction of occurrences with respect to the total number of sample points (here, the sum of all bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds to the number of occurrences in a bin divided by the size of the bin interval (here, the sum of all bin AREAS equals the total number of sample points). If *probability density*, the area of each bar corresponds to the probability that an event will fall into the corresponding bin (here, the sum of all bin AREAS equals 1).
		***
		*** Source: histnorm
		******************************/

		public enum HistNormOptions
		{
			[Description("")]
			Blank,
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
		*** Enum Name: HoverInfoOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
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
			Name
		}

		/******************************
		*** Enum Name: HoverLabelAlignOptions
		***
		*** Description: Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
		***
		*** Source: align
		******************************/

		public enum HoverLabelAlignOptions
		{
			[Description("left")]
			Left,
			[Description("right")]
			Right,
			[Description("auto")]
			Auto
		}

		/******************************
		*** Enum Name: HoverModeOptions
		***
		*** Description: Determines the mode of hover interactions. If *closest*, a single hoverlabel will appear for the *closest* point within the `hoverdistance`. If *x* (or *y*), multiple hoverlabels will appear for multiple points at the *closest* x- (or y-) coordinate within the `hoverdistance`, with the caveat that no more than one hoverlabel will appear per trace. If *x unified* (or *y unified*), a single hoverlabel will appear multiple points at the closest x- (or y-) coordinate within the `hoverdistance` with the caveat that no more than one hoverlabel will appear per trace. In this mode, spikelines are enabled by default perpendicular to the specified axis. If false, hover interactions are disabled.
		***
		*** Source: hovermode
		******************************/

		public enum HoverModeOptions
		{
			[Description("x")]
			X,
			[Description("y")]
			Y,
			[Description("closest")]
			Closest,
			[Description("false")]
			False,
			[Description("x unified")]
			XUnified,
			[Description("y unified")]
			YUnified
		}

		/******************************
		*** Enum Name: HoverOnOptions
		***
		*** Description: Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
		***
		*** Source: hoveron
		******************************/

		public enum HoverOnOptions
		{
			[Description("points")]
			Points,
			[Description("fills")]
			Fills
		}

		/******************************
		*** Enum Name: HoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum HoverOptions
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
			Name
		}

		/******************************
		*** Enum Name: IcicleHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum IcicleHoverOptions
		{
			[Description("label")]
			Label,
			[Description("text")]
			Text,
			[Description("value")]
			Value,
			[Description("name")]
			Name,
			[Description("current path")]
			CurrentPath,
			[Description("percent root")]
			PercentRoot,
			[Description("percent entry")]
			PercentEntry,
			[Description("percent parent")]
			PercentParent
		}

		/******************************
		*** Enum Name: IcicleTextInfoOptions
		***
		*** Description: Determines which trace information appear on the graph.
		***
		*** Source: textinfo
		******************************/

		public enum IcicleTextInfoOptions
		{
			[Description("label")]
			Label,
			[Description("text")]
			Text,
			[Description("value")]
			Value,
			[Description("current path")]
			CurrentPath,
			[Description("percent root")]
			PercentRoot,
			[Description("percent entry")]
			PercentEntry,
			[Description("percent parent")]
			PercentParent
		}

		/******************************
		*** Enum Name: IcicleTextPositionOptions
		***
		*** Description: Sets the positions of the `text` elements.
		***
		*** Source: textposition
		******************************/

		public enum IcicleTextPositionOptions
		{
			[Description("top left")]
			TopLeft,
			[Description("top center")]
			TopCenter,
			[Description("top right")]
			TopRight,
			[Description("middle left")]
			MiddleLeft,
			[Description("middle center")]
			MiddleCenter,
			[Description("middle right")]
			MiddleRight,
			[Description("bottom left")]
			BottomLeft,
			[Description("bottom center")]
			BottomCenter,
			[Description("bottom right")]
			BottomRight
		}

		/******************************
		*** Enum Name: ImageHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum ImageHoverOptions
		{
			[Description("x")]
			X,
			[Description("y")]
			Y,
			[Description("z")]
			Z,
			[Description("color")]
			Color,
			[Description("name")]
			Name,
			[Description("text")]
			Text
		}

		/******************************
		*** Enum Name: InsideTextOrientationOptions
		***
		*** Description: Controls the orientation of the text inside chart sectors. When set to *auto*, text may be oriented in any direction in order to be as big as possible in the middle of a sector. The *horizontal* option orients text to be parallel with the bottom of the chart, and may make text smaller in order to achieve that goal. The *radial* option orients text along the radius of the sector. The *tangential* option orients text perpendicular to the radius of the sector.
		***
		*** Source: insidetextorientation
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
		*** Enum Name: IntensityModeOptions
		***
		*** Description: Determines the source of `intensity` values.
		***
		*** Source: intensitymode
		******************************/

		public enum IntensityModeOptions
		{
			[Description("vertex")]
			Vertex,
			[Description("cell")]
			Cell
		}

		/******************************
		*** Enum Name: ItemClickOptions
		***
		*** Description: Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disables legend item click interactions.
		***
		*** Source: itemclick
		******************************/

		public enum ItemClickOptions
		{
			[Description("toggle")]
			Toggle,
			[Description("toggleothers")]
			ToggleOthers,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: ItemSizingOptions
		***
		*** Description: Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
		***
		*** Source: itemsizing
		******************************/

		public enum ItemSizingOptions
		{
			[Description("trace")]
			Trace,
			[Description("constant")]
			Constant
		}

		/******************************
		*** Enum Name: ItemsOptions
		***
		*** Description: 
		***
		*** Source: items
		******************************/

		public enum ItemsOptions
		{
			[Description("/^x([2-9]|[1-9][0-9]+)?y([2-9]|[1-9][0-9]+)?$/")]
			RegEx_X,
			[Description("")]
			Blank
		}

		/******************************
		*** Enum Name: LayerOptions
		***
		*** Description: Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area.
		***
		*** Source: layer
		******************************/

		public enum LayerOptions
		{
			[Description("below")]
			Below,
			[Description("above")]
			Above
		}

		/******************************
		*** Enum Name: LayerTypeOptions
		***
		*** Description: Sets the layer type, that is the how the layer data set in `source` will be rendered With `sourcetype` set to *geojson*, the following values are allowed: *circle*, *line*, *fill* and *symbol*. but note that *line* and *fill* are not compatible with Point GeoJSON geometries. With `sourcetype` set to *vector*, the following values are allowed:  *circle*, *line*, *fill* and *symbol*. With `sourcetype` set to *raster* or `*image*`, only the *raster* value is allowed.
		***
		*** Source: type
		******************************/

		public enum LayerTypeOptions
		{
			[Description("circle")]
			Circle,
			[Description("line")]
			Line,
			[Description("fill")]
			Fill,
			[Description("symbol")]
			Symbol,
			[Description("raster")]
			Raster
		}

		/******************************
		*** Enum Name: LayoutDragModeOptions
		***
		*** Description: Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
		***
		*** Source: dragmode
		******************************/

		public enum LayoutDragModeOptions
		{
			[Description("zoom")]
			Zoom,
			[Description("pan")]
			Pan,
			[Description("select")]
			Select,
			[Description("lasso")]
			Lasso,
			[Description("drawclosedpath")]
			DrawClosedPath,
			[Description("drawopenpath")]
			DrawOpenPath,
			[Description("drawline")]
			Drawline,
			[Description("drawrect")]
			DrawRect,
			[Description("drawcircle")]
			DrawCircle,
			[Description("orbit")]
			Orbit,
			[Description("turntable")]
			Turntable,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: LayoutOptions
		***
		*** Description: layout attributes should include an `editType` string matching this flaglist. *calc* is the most extensive: a full (re)plot starting by clearing `gd.calcdata` to force it to be regenerated *plot* (re)plots but without first clearing `gd.calcdata`. *legend* only redraws the legend. *ticks* only redraws axis ticks, labels, and gridlines. *axrange* minimal sequence when updating axis ranges. *layoutstyle* reapplies global and SVG cartesian axis styles. *modebar* just updates the modebar. *camera* just updates the camera settings for gl3d scenes. *arraydraw* allows component arrays to invoke the redraw routines just for the component(s) that changed. *colorbars* only redraws colorbars.
		***
		*** Source: layout
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
			AXRange,
			[Description("layoutstyle")]
			Layoutstyle,
			[Description("modebar")]
			ModeBar,
			[Description("camera")]
			Camera,
			[Description("arraydraw")]
			ArrayDraw,
			[Description("colorbars")]
			ColorBars
		}

		/******************************
		*** Enum Name: LegendTitleSideOptions
		***
		*** Description: Determines the location of legend's title with respect to the legend items. Defaulted to *top* with `orientation` is *h*. Defaulted to *left* with `orientation` is *v*. The *top left* options could be used to expand legend area in both x and y sides.
		***
		*** Source: side
		******************************/

		public enum LegendTitleSideOptions
		{
			[Description("top")]
			Top,
			[Description("left")]
			Left,
			[Description("top left")]
			TopLeft
		}

		/******************************
		*** Enum Name: LinearArrayTickModeOptions
		***
		*** Description: 
		***
		*** Source: tickmode
		******************************/

		public enum LinearArrayTickModeOptions
		{
			[Description("linear")]
			Linear,
			[Description("array")]
			Array
		}

		/******************************
		*** Enum Name: LinkHoverOptions
		***
		*** Description: Determines which trace information appear when hovering links. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum LinkHoverOptions
		{
			[Description("all")]
			All,
			[Description("none")]
			None,
			[Description("skip")]
			Skip
		}

		/******************************
		*** Enum Name: LocationModeOptions
		***
		*** Description: Determines the set of locations used to match entries in `locations` to regions on the map. Values *ISO-3*, *USA-states*, *country names* correspond to features on the base map and value *geojson-id* corresponds to features from a custom GeoJSON linked to the `geojson` attribute.
		***
		*** Source: locationmode
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
			GeoJSONId
		}

		/******************************
		*** Enum Name: MapboxHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum MapboxHoverOptions
		{
			[Description("lon")]
			Lon,
			[Description("lat")]
			Lat,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: MatchesOptions
		***
		*** Description: If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
		***
		*** Source: matches
		******************************/

		public enum MatchesOptions
		{
			[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_X,
			[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_Y
		}

		/******************************
		*** Enum Name: MeasureModeOptions
		***
		*** Description: Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
		***
		*** Source: lenmode
		******************************/

		public enum MeasureModeOptions
		{
			[Description("fraction")]
			Fraction,
			[Description("pixels")]
			Pixels
		}

		/******************************
		*** Enum Name: MenuDirectionOptions
		***
		*** Description: Determines the direction in which the buttons are laid out, whether in a dropdown menu or a row/column of buttons. For `left` and `up`, the buttons will still appear in left-to-right or top-to-bottom order respectively.
		***
		*** Source: direction
		******************************/

		public enum MenuDirectionOptions
		{
			[Description("left")]
			Left,
			[Description("right")]
			Right,
			[Description("up")]
			Up,
			[Description("down")]
			Down
		}

		/******************************
		*** Enum Name: MethodOptions
		***
		*** Description: Sets the Plotly method to be called when the slider value is changed. If the `skip` method is used, the API slider will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to slider events manually via JavaScript.
		***
		*** Source: method
		******************************/

		public enum MethodOptions
		{
			[Description("restyle")]
			Restyle,
			[Description("relayout")]
			RelayOut,
			[Description("animate")]
			Animate,
			[Description("update")]
			Update,
			[Description("skip")]
			Skip
		}

		/******************************
		*** Enum Name: MirrorOptions
		***
		*** Description: Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
		***
		*** Source: mirror
		******************************/

		public enum MirrorOptions
		{
			[Description("true")]
			True,
			[Description("ticks")]
			Ticks,
			[Description("false")]
			False,
			[Description("all")]
			All,
			[Description("allticks")]
			AllTicks
		}

		/******************************
		*** Enum Name: ModeAnimationOptions
		***
		*** Description: Describes how a new animate call interacts with currently-running animations. If `immediate`, current animations are interrupted and the new animation is started. If `next`, the current frame is allowed to complete, after which the new animation is started. If `afterall` all existing frames are animated to completion before the new animation is started.
		***
		*** Source: mode
		******************************/

		public enum ModeAnimationOptions
		{
			[Description("immediate")]
			Immediate,
			[Description("next")]
			Next,
			[Description("afterall")]
			AfterAll
		}

		/******************************
		*** Enum Name: ModeConnectorOptions
		***
		*** Description: Sets the shape of connector lines.
		***
		*** Source: mode
		******************************/

		public enum ModeConnectorOptions
		{
			[Description("spanning")]
			Spanning,
			[Description("between")]
			Between
		}

		/******************************
		*** Enum Name: ModeIndicatorOptions
		***
		*** Description: Determines how the value is displayed on the graph. `number` displays the value numerically in text. `delta` displays the difference to a reference value in text. Finally, `gauge` displays the value graphically on an axis.
		***
		*** Source: mode
		******************************/

		public enum ModeIndicatorOptions
		{
			[Description("number")]
			Number,
			[Description("delta")]
			Delta,
			[Description("gauge")]
			Gauge
		}

		/******************************
		*** Enum Name: ModeScatterOptions
		***
		*** Description: Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
		***
		*** Source: mode
		******************************/

		public enum ModeScatterOptions
		{
			[Description("lines")]
			Lines,
			[Description("markers")]
			Markers,
			[Description("text")]
			Text
		}

		/******************************
		*** Enum Name: ModeUniformTextOptions
		***
		*** Description: Determines how the font size for various text elements are uniformed between each trace type. If the computed text sizes were smaller than the minimum size defined by `uniformtext.minsize` using *hide* option hides the text; and using *show* option shows the text without further downscaling. Please note that if the size defined by `minsize` is greater than the font size defined by trace, then the `minsize` is used.
		***
		*** Source: mode
		******************************/

		public enum ModeUniformTextOptions
		{
			[Description("false")]
			False,
			[Description("hide")]
			Hide,
			[Description("show")]
			Show
		}

		/******************************
		*** Enum Name: NodeHoverInfoOptions
		***
		*** Description: Determines which trace information appear when hovering nodes. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum NodeHoverInfoOptions
		{
			[Description("all")]
			All,
			[Description("none")]
			None,
			[Description("skip")]
			Skip
		}

		/******************************
		*** Enum Name: NormalizationOptions
		***
		*** Description: Sets the normalization for bar traces on the graph. With *fraction*, the value of each bar is divided by the sum of all values at that location coordinate. *percent* is the same but multiplied by 100 to show percentages.
		***
		*** Source: barnorm
		******************************/

		public enum NormalizationOptions
		{
			[Description("")]
			Blank,
			[Description("fraction")]
			Fraction,
			[Description("percent")]
			Percent
		}

		/******************************
		*** Enum Name: OperationOptions
		***
		*** Description: Sets the filter operation. *=* keeps items equal to `value` *!=* keeps items not equal to `value` *<* keeps items less than `value` *<=* keeps items less than or equal to `value` *>* keeps items greater than `value` *>=* keeps items greater than or equal to `value` *[]* keeps items inside `value[0]` to `value[1]` including both bounds *()* keeps items inside `value[0]` to `value[1]` excluding both bounds *[)* keeps items inside `value[0]` to `value[1]` including `value[0]` but excluding `value[1] *(]* keeps items inside `value[0]` to `value[1]` excluding `value[0]` but including `value[1] *][* keeps items outside `value[0]` to `value[1]` and equal to both bounds *)(* keeps items outside `value[0]` to `value[1]` *](* keeps items outside `value[0]` to `value[1]` and equal to `value[0]` *)[* keeps items outside `value[0]` to `value[1]` and equal to `value[1]` *{}* keeps items present in a set of values *}{* keeps items not present in a set of values
		***
		*** Source: operation
		******************************/

		public enum OperationOptions
		{
			[Description("=")]
			Equals,
			[Description("!=")]
			NotEquals,
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
			TPLB,
			[Description("{}")]
			LCRC,
			[Description("}{")]
			RCLC
		}

		/******************************
		*** Enum Name: OrderingOptions
		***
		*** Description: Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
		***
		*** Source: ordering
		******************************/

		public enum OrderingOptions
		{
			[Description("layout first")]
			LayoutFirst,
			[Description("traces first")]
			TracesFirst
		}

		/******************************
		*** Enum Name: OrderOptions
		***
		*** Description: Sets the sort transform order.
		***
		*** Source: order
		******************************/

		public enum OrderOptions
		{
			[Description("ascending")]
			Ascending,
			[Description("descending")]
			Descending
		}

		/******************************
		*** Enum Name: OrientationOptions
		***
		*** Description: Sets the orientation of the colorbar.
		***
		*** Source: orientation
		******************************/

		public enum OrientationOptions
		{
			[Description("h")]
			Horizontal,
			[Description("v")]
			Vertical
		}

		/******************************
		*** Enum Name: OverlayingOptions
		***
		*** Description: If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
		***
		*** Source: overlaying
		******************************/

		public enum OverlayingOptions
		{
			[Description("free")]
			Free,
			[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_X,
			[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_Y
		}

		/******************************
		*** Enum Name: PackingOptions
		***
		*** Description: Determines d3 treemap solver. For more info please refer to https://github.com/d3/d3-hierarchy#treemap-tiling
		***
		*** Source: packing
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
		*** Enum Name: ParallelCatsHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum ParallelCatsHoverOptions
		{
			[Description("count")]
			Count,
			[Description("probability")]
			Probability
		}

		/******************************
		*** Enum Name: ParCatsArrangementOptions
		***
		*** Description: Sets the drag interaction mode for categories and dimensions. If `perpendicular`, the categories can only move along a line perpendicular to the paths. If `freeform`, the categories can freely move on the plane. If `fixed`, the categories and dimensions are stationary.
		***
		*** Source: arrangement
		******************************/

		public enum ParCatsArrangementOptions
		{
			[Description("perpendicular")]
			Perpendicular,
			[Description("freeform")]
			FreeForm,
			[Description("fixed")]
			Fixed
		}

		/******************************
		*** Enum Name: ParCatsHoverOnOptions
		***
		*** Description: Sets the hover interaction mode for the parcats diagram. If `category`, hover interaction take place per category. If `color`, hover interactions take place per color per category. If `dimension`, hover interactions take place across all categories per dimension.
		***
		*** Source: hoveron
		******************************/

		public enum ParCatsHoverOnOptions
		{
			[Description("category")]
			Category,
			[Description("color")]
			Color,
			[Description("dimension")]
			Dimension
		}

		/******************************
		*** Enum Name: PlacementOptions
		***
		*** Description: Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement). If `placement` is *point*, the label is placed where the geometry is located If `placement` is *line*, the label is placed along the line of the geometry If `placement` is *line-center*, the label is placed on the center of the geometry
		***
		*** Source: placement
		******************************/

		public enum PlacementOptions
		{
			[Description("point")]
			Point,
			[Description("line")]
			Line,
			[Description("line-center")]
			LineCenter
		}

		/******************************
		*** Enum Name: PointsOptions
		***
		*** Description: If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the violins are shown with no sample points. Defaults to *suspectedoutliers* when `marker.outliercolor` or `marker.line.outliercolor` is set, otherwise defaults to *outliers*.
		***
		*** Source: points
		******************************/

		public enum PointsOptions
		{
			[Description("all")]
			All,
			[Description("outliers")]
			Outliers,
			[Description("suspectedoutliers")]
			Suspectedoutliers,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: PolarCategoryOrderOptions
		***
		*** Description: Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
		***
		*** Source: categoryorder
		******************************/

		public enum PolarCategoryOrderOptions
		{
			[Description("trace")]
			Trace,
			[Description("category ascending")]
			CategoryAscending,
			[Description("category descending")]
			CategoryDescending,
			[Description("array")]
			Array,
			[Description("total ascending")]
			TotalAscending,
			[Description("total descending")]
			TotalDescending,
			[Description("min ascending")]
			MinAscending,
			[Description("min descending")]
			MinDescending,
			[Description("max ascending")]
			MaxAscending,
			[Description("max descending")]
			MaxDescending,
			[Description("sum ascending")]
			SumAscending,
			[Description("sum descending")]
			SumDescending,
			[Description("mean ascending")]
			MeanAscending,
			[Description("mean descending")]
			MeanDescending,
			[Description("median ascending")]
			MedianAscending,
			[Description("median descending")]
			MedianDescending
		}

		/******************************
		*** Enum Name: PolarHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum PolarHoverOptions
		{
			[Description("r")]
			R,
			[Description("theta")]
			Theta,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: PolarThetaUnitOptions
		***
		*** Description: Sets the unit of input *theta* values. Has an effect only when on *linear* angular axes.
		***
		*** Source: thetaunit
		******************************/

		public enum PolarThetaUnitOptions
		{
			[Description("radians")]
			Radians,
			[Description("degrees")]
			Degrees,
			[Description("gradians")]
			Gradians
		}

		/******************************
		*** Enum Name: PositionOptions
		***
		*** Description: Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
		***
		*** Source: side
		******************************/

		public enum PositionOptions
		{
			[Description("top")]
			Top,
			[Description("bottom")]
			Bottom,
			[Description("left")]
			Left,
			[Description("right")]
			Right
		}

		/******************************
		*** Enum Name: QuartileMethodOptions
		***
		*** Description: Sets the method used to compute the sample's Q1 and Q3 quartiles. The *linear* method uses the 25th percentile for Q1 and 75th percentile for Q3 as computed using method #10 (listed on http://www.amstat.org/publications/jse/v14n3/langford.html). The *exclusive* method uses the median to divide the ordered dataset into two halves if the sample is odd, it does not include the median in either half - Q1 is then the median of the lower half and Q3 the median of the upper half. The *inclusive* method also uses the median to divide the ordered dataset into two halves but if the sample is odd, it includes the median in both halves - Q1 is then the median of the lower half and Q3 the median of the upper half.
		***
		*** Source: quartilemethod
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
		*** Enum Name: RadialAxisSideOptions
		***
		*** Description: Determines on which side of radial axis line the tick and tick labels appear.
		***
		*** Source: side
		******************************/

		public enum RadialAxisSideOptions
		{
			[Description("clockwise")]
			Clockwise,
			[Description("counterclockwise")]
			Counterclockwise
		}

		/******************************
		*** Enum Name: RangeBreakPatternOptions
		***
		*** Description: Determines a pattern on the time line that generates breaks. If *day of week* - days of the week in English e.g. 'Sunday' or `sun` (matching is case-insensitive and considers only the first three characters), as well as Sunday-based integers between 0 and 6. If *hour* - hour (24-hour clock) as decimal numbers between 0 and 24. for more info. Examples: - { pattern: 'day of week', bounds: [6, 1] }  or simply { bounds: ['sat', 'mon'] }   breaks from Saturday to Monday (i.e. skips the weekends). - { pattern: 'hour', bounds: [17, 8] }   breaks from 5pm to 8am (i.e. skips non-work hours).
		***
		*** Source: pattern
		******************************/

		public enum RangeBreakPatternOptions
		{
			[Description("day of week")]
			DayOfWeek,
			[Description("hour")]
			Hour,
			[Description("")]
			Blank
		}

		/******************************
		*** Enum Name: RangeModeOptions
		***
		*** Description: If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
		***
		*** Source: rangemode
		******************************/

		public enum RangeModeOptions
		{
			[Description("tozero")]
			ToZero,
			[Description("nonnegative")]
			Nonnegative,
			[Description("normal")]
			Normal
		}

		/******************************
		*** Enum Name: RangeModeSliderOptions
		***
		*** Description: Determines whether or not the range of this axis in the rangeslider use the same value than in the main plot when zooming in/out. If *auto*, the autorange will be used. If *fixed*, the `range` is used. If *match*, the current range of the corresponding y-axis on the main subplot is used.
		***
		*** Source: rangemode
		******************************/

		public enum RangeModeSliderOptions
		{
			[Description("auto")]
			Auto,
			[Description("fixed")]
			Fixed,
			[Description("match")]
			Match
		}

		/******************************
		*** Enum Name: ResolutionOptions
		***
		*** Description: Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
		***
		*** Source: resolution
		******************************/

		public enum ResolutionOptions
		{
			[Description("110")]
			_110,
			[Description("50")]
			_50
		}

		/******************************
		*** Enum Name: RowOrderOptions
		***
		*** Description: Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
		***
		*** Source: roworder
		******************************/

		public enum RowOrderOptions
		{
			[Description("top to bottom")]
			TopToBottom,
			[Description("bottom to top")]
			BottomToTop
		}

		/******************************
		*** Enum Name: SankeyArrangementOptions
		***
		*** Description: If value is `snap` (the default), the node arrangement is assisted by automatic snapping of elements to preserve space between nodes specified via `nodepad`. If value is `perpendicular`, the nodes can only move along a line perpendicular to the flow. If value is `freeform`, the nodes can freely move on the plane. If value is `fixed`, the nodes are stationary.
		***
		*** Source: arrangement
		******************************/

		public enum SankeyArrangementOptions
		{
			[Description("snap")]
			Snap,
			[Description("perpendicular")]
			Perpendicular,
			[Description("freeform")]
			FreeForm,
			[Description("fixed")]
			Fixed
		}

		/******************************
		*** Enum Name: ScaleAnchorOptions
		***
		*** Description: If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
		***
		*** Source: scaleanchor
		******************************/

		public enum ScaleAnchorOptions
		{
			[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_X,
			[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_Y
		}

		/******************************
		*** Enum Name: ScaleModeOptions
		***
		*** Description: Sets the metric by which the width of each violin is determined.*width* means each violin has the same (max) width*count* means the violins are scaled by the number of sample points makingup each violin.
		***
		*** Source: scalemode
		******************************/

		public enum ScaleModeOptions
		{
			[Description("width")]
			Width,
			[Description("count")]
			Count
		}

		/******************************
		*** Enum Name: ScatterSmithHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum ScatterSmithHoverOptions
		{
			[Description("real")]
			Real,
			[Description("imag")]
			Imag,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: ScatterTextPositionOptions
		***
		*** Description: Sets the positions of the `text` elements with respects to the (x,y) coordinates.
		***
		*** Source: textposition
		******************************/

		public enum ScatterTextPositionOptions
		{
			[Description("top left")]
			TopLeft,
			[Description("top center")]
			TopCenter,
			[Description("top right")]
			TopRight,
			[Description("middle left")]
			MiddleLeft,
			[Description("middle center")]
			MiddleCenter,
			[Description("middle right")]
			MiddleRight,
			[Description("bottom left")]
			BottomLeft,
			[Description("bottom center")]
			BottomCenter,
			[Description("bottom right")]
			BottomRight
		}

		/******************************
		*** Enum Name: SceneHoverModeOptions
		***
		*** Description: Determines the mode of hover interactions for this scene.
		***
		*** Source: hovermode
		******************************/

		public enum SceneHoverModeOptions
		{
			[Description("closest")]
			Closest,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: ScopeOptions
		***
		*** Description: Set the scope of the map.
		***
		*** Source: scope
		******************************/

		public enum ScopeOptions
		{
			[Description("africa")]
			Africa,
			[Description("asia")]
			Asia,
			[Description("europe")]
			Europe,
			[Description("north america")]
			NorthAmerica,
			[Description("south america")]
			SouthAmerica,
			[Description("usa")]
			USA,
			[Description("world")]
			World
		}

		/******************************
		*** Enum Name: ScrollZoomOptions
		***
		*** Description: Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
		***
		*** Source: scrollZoom
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

		/******************************
		*** Enum Name: SelectDirectionOptions
		***
		*** Description: When `dragmode` is set to *select*, this limits the selection of the drag to horizontal, vertical or diagonal. *h* only allows horizontal selection, *v* only vertical, *d* only diagonal and *any* sets no limit.
		***
		*** Source: selectdirection
		******************************/

		public enum SelectDirectionOptions
		{
			[Description("h")]
			Horizontal,
			[Description("v")]
			Vertical,
			[Description("d")]
			d,
			[Description("any")]
			Any
		}

		/******************************
		*** Enum Name: ShapeFillPatternOptions
		***
		*** Description: Sets the shape of the pattern fill. By default, no pattern is used for filling the area.
		***
		*** Source: shape
		******************************/

		public enum ShapeFillPatternOptions
		{
			[Description("")]
			Blank,
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
		*** Enum Name: ShapeGaugeOptions
		***
		*** Description: Set the shape of the gauge
		***
		*** Source: shape
		******************************/

		public enum ShapeGaugeOptions
		{
			[Description("angular")]
			Angular,
			[Description("bullet")]
			Bullet
		}

		/******************************
		*** Enum Name: ShapeLineParCatsOptions
		***
		*** Description: Sets the shape of the paths. If `linear`, paths are composed of straight lines. If `hspline`, paths are composed of horizontal curved splines
		***
		*** Source: shape
		******************************/

		public enum ShapeLineParCatsOptions
		{
			[Description("linear")]
			Linear,
			[Description("hspline")]
			HSpline
		}

		/******************************
		*** Enum Name: ShapeLineScatterBasicOptions
		***
		*** Description: Determines the line shape. With *spline* the lines are drawn using spline interpolation. The other available values correspond to step-wise line shapes.
		***
		*** Source: shape
		******************************/

		public enum ShapeLineScatterBasicOptions
		{
			[Description("linear")]
			Linear,
			[Description("spline")]
			Spline
		}

		/******************************
		*** Enum Name: ShapeLineScatterGLOptions
		***
		*** Description: Determines the line shape. The values correspond to step-wise line shapes.
		***
		*** Source: shape
		******************************/

		public enum ShapeLineScatterGLOptions
		{
			[Description("linear")]
			Linear,
			[Description("hv")]
			Hv,
			[Description("vh")]
			Vh,
			[Description("hvh")]
			Hvh,
			[Description("vhv")]
			Vhv
		}

		/******************************
		*** Enum Name: ShapeLineScatterOptions
		***
		*** Description: Determines the line shape. With *spline* the lines are drawn using spline interpolation. The other available values correspond to step-wise line shapes.
		***
		*** Source: shape
		******************************/

		public enum ShapeLineScatterOptions
		{
			[Description("linear")]
			Linear,
			[Description("spline")]
			Spline,
			[Description("hv")]
			Hv,
			[Description("vh")]
			Vh,
			[Description("hvh")]
			Hvh,
			[Description("vhv")]
			Vhv
		}

		/******************************
		*** Enum Name: ShapeSizeModeOptions
		***
		*** Description: Sets the shapes's sizing mode along the x axis. If set to *scaled*, `x0`, `x1` and x coordinates within `path` refer to data values on the x axis or a fraction of the plot area's width (`xref` set to *paper*). If set to *pixel*, `xanchor` specifies the x position in terms of data or plot fraction but `x0`, `x1` and x coordinates within `path` are pixels relative to `xanchor`. This way, the shape can have a fixed width while maintaining a position relative to data or plot fraction.
		***
		*** Source: xsizemode
		******************************/

		public enum ShapeSizeModeOptions
		{
			[Description("scaled")]
			Scaled,
			[Description("pixel")]
			Pixel
		}

		/******************************
		*** Enum Name: ShapeTypeOptions
		***
		*** Description: Specifies the shape type to be drawn. If *line*, a line is drawn from (`x0`,`y0`) to (`x1`,`y1`) with respect to the axes' sizing mode. If *circle*, a circle is drawn from ((`x0`+`x1`)/2, (`y0`+`y1`)/2)) with radius (|(`x0`+`x1`)/2 - `x0`|, |(`y0`+`y1`)/2 -`y0`)|) with respect to the axes' sizing mode. If *rect*, a rectangle is drawn linking (`x0`,`y0`), (`x1`,`y0`), (`x1`,`y1`), (`x0`,`y1`), (`x0`,`y0`) with respect to the axes' sizing mode. If *path*, draw a custom SVG path using `path`. with respect to the axes' sizing mode.
		***
		*** Source: type
		******************************/

		public enum ShapeTypeOptions
		{
			[Description("circle")]
			Circle,
			[Description("rect")]
			Rect,
			[Description("path")]
			Path,
			[Description("line")]
			Line
		}

		/******************************
		*** Enum Name: ShowExponentOptions
		***
		*** Description: If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
		***
		*** Source: showexponent
		******************************/

		public enum ShowExponentOptions
		{
			[Description("all")]
			All,
			[Description("first")]
			First,
			[Description("last")]
			Last,
			[Description("none")]
			None
		}

		/******************************
		*** Enum Name: ShowTickLabelsOptions
		***
		*** Description: Determines whether axis labels are drawn on the low side, the high side, both, or neither side of the axis.
		***
		*** Source: showticklabels
		******************************/

		public enum ShowTickLabelsOptions
		{
			[Description("start")]
			Start,
			[Description("end")]
			End,
			[Description("both")]
			Both,
			[Description("none")]
			None
		}

		/******************************
		*** Enum Name: ShowTickOptions
		***
		*** Description: If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
		***
		*** Source: showtickprefix
		******************************/

		public enum ShowTickOptions
		{
			[Description("all")]
			All,
			[Description("first")]
			First,
			[Description("last")]
			Last,
			[Description("none")]
			None
		}

		/******************************
		*** Enum Name: ShowTickPrefixOptions
		***
		*** Description: If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
		***
		*** Source: showtickprefix
		******************************/

		public enum ShowTickPrefixOptions
		{
			[Description("all")]
			All,
			[Description("first")]
			First,
			[Description("last")]
			Last,
			[Description("none")]
			None
		}

		/******************************
		*** Enum Name: SizeModeConeOptions
		***
		*** Description: Determines whether `sizeref` is set as a *scaled* (i.e unitless) scalar (normalized by the max u/v/w norm in the vector field) or as *absolute* value (in the same units as the vector field).
		***
		*** Source: sizemode
		******************************/

		public enum SizeModeConeOptions
		{
			[Description("scaled")]
			Scaled,
			[Description("absolute")]
			Absolute
		}

		/******************************
		*** Enum Name: SizeModeOptions
		***
		*** Description: Has an effect only if `marker.size` is set to a numerical array. Sets the rule for which the data in `size` is converted to pixels.
		***
		*** Source: sizemode
		******************************/

		public enum SizeModeOptions
		{
			[Description("diameter")]
			Diameter,
			[Description("area")]
			Area
		}

		/******************************
		*** Enum Name: SizingOptions
		***
		*** Description: Specifies which dimension of the image to constrain.
		***
		*** Source: sizing
		******************************/

		public enum SizingOptions
		{
			[Description("fill")]
			Fill,
			[Description("contain")]
			Contain,
			[Description("stretch")]
			Stretch
		}

		/******************************
		*** Enum Name: SortPathsOptions
		***
		*** Description: Sets the path sorting algorithm. If `forward`, sort paths based on dimension categories from left to right. If `backward`, sort paths based on dimensions categories from right to left.
		***
		*** Source: sortpaths
		******************************/

		public enum SortPathsOptions
		{
			[Description("forward")]
			Forward,
			[Description("backward")]
			Backward
		}

		/******************************
		*** Enum Name: SourceTypeOptions
		***
		*** Description: Sets the source type for this layer, that is the type of the layer data.
		***
		*** Source: sourcetype
		******************************/

		public enum SourceTypeOptions
		{
			[Description("geojson")]
			GeoJSON,
			[Description("vector")]
			Vector,
			[Description("raster")]
			Raster,
			[Description("image")]
			Image
		}

		/******************************
		*** Enum Name: SpanModeOptions
		***
		*** Description: Sets the method by which the span in data space where the density function will be computed. *soft* means the span goes from the sample's minimum value minus two bandwidths to the sample's maximum value plus two bandwidths. *hard* means the span goes from the sample's minimum to its maximum value. For custom span settings, use mode *manual* and fill in the `span` attribute.
		***
		*** Source: spanmode
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
		*** Enum Name: SpikeDashOptions
		***
		*** Description: Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
		***
		*** Source: dash
		******************************/

		public enum SpikeDashOptions
		{
			[Description("solid")]
			Solid,
			[Description("dot")]
			Dot,
			[Description("dash")]
			Dash,
			[Description("longdash")]
			LongDash,
			[Description("dashdot")]
			DashDot,
			[Description("longdashdot")]
			LongDashDot
		}

		/******************************
		*** Enum Name: SpikeModeOptions
		***
		*** Description: Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
		***
		*** Source: spikemode
		******************************/

		public enum SpikeModeOptions
		{
			[Description("toaxis")]
			Toaxis,
			[Description("across")]
			Across,
			[Description("marker")]
			Marker
		}

		/******************************
		*** Enum Name: SpikeSnapOptions
		***
		*** Description: Determines whether spikelines are stuck to the cursor or to the closest datapoints.
		***
		*** Source: spikesnap
		******************************/

		public enum SpikeSnapOptions
		{
			[Description("data")]
			Data,
			[Description("cursor")]
			Cursor,
			[Description("hovered data")]
			HoveredData
		}

		/******************************
		*** Enum Name: StackGapsOptions
		***
		*** Description: Only relevant when `stackgroup` is used, and only the first `stackgaps` found in the `stackgroup` will be used - including if `visible` is *legendonly* but not if it is `false`. Determines how we handle locations at which other traces in this group have data but this one does not. With *infer zero* we insert a zero at these locations. With *interpolate* we linearly interpolate between existing values, and extrapolate a constant beyond the existing values.
		***
		*** Source: stackgaps
		******************************/

		public enum StackGapsOptions
		{
			[Description("infer zero")]
			InferZero,
			[Description("interpolate")]
			Interpolate
		}

		/******************************
		*** Enum Name: StartMiddleEndOptions
		***
		*** Description: Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
		***
		*** Source: insidetextanchor
		******************************/

		public enum StartMiddleEndOptions
		{
			[Description("end")]
			End,
			[Description("middle")]
			Middle,
			[Description("start")]
			Start
		}

		/******************************
		*** Enum Name: StepModeOptions
		***
		*** Description: Sets the range update mode. If *backward*, the range update shifts the start of range back *count* times *step* milliseconds. If *todate*, the range update shifts the start of range back to the first timestamp from *count* times *step* milliseconds back. For example, with `step` set to *year* and `count` set to *1* the range update shifts the start of the range back to January 01 of the current year. Month and year *todate* are currently available only for the built-in (Gregorian) calendar.
		***
		*** Source: stepmode
		******************************/

		public enum StepModeOptions
		{
			[Description("backward")]
			Backward,
			[Description("todate")]
			ToDate
		}

		/******************************
		*** Enum Name: StepOptions
		***
		*** Description: The unit of measurement that the `count` value will set the range by.
		***
		*** Source: step
		******************************/

		public enum StepOptions
		{
			[Description("month")]
			Month,
			[Description("year")]
			Year,
			[Description("day")]
			Day,
			[Description("hour")]
			Hour,
			[Description("minute")]
			Minute,
			[Description("second")]
			Second,
			[Description("all")]
			All
		}

		/******************************
		*** Enum Name: StreamTubeHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum StreamTubeHoverOptions
		{
			[Description("x")]
			X,
			[Description("y")]
			Y,
			[Description("z")]
			Z,
			[Description("u")]
			U,
			[Description("v")]
			V,
			[Description("w")]
			W,
			[Description("norm")]
			Norm,
			[Description("divergence")]
			Divergence,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: StyleOptions
		***
		*** Description: Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: carto-darkmatter, carto-positron, open-street-map, stamen-terrain, stamen-toner, stamen-watercolor, white-bg  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
		***
		*** Source: style
		******************************/

		public enum StyleOptions
		{
			[Description("basic")]
			Basic,
			[Description("streets")]
			Streets,
			[Description("outdoors")]
			Outdoors,
			[Description("light")]
			Light,
			[Description("dark")]
			Dark,
			[Description("satellite")]
			Satellite,
			[Description("satellite-streets")]
			SatelliteStreets,
			[Description("carto-darkmatter")]
			CartoDarkmatter,
			[Description("carto-positron")]
			CartoPositron,
			[Description("open-street-map")]
			OpenStreetMap,
			[Description("stamen-terrain")]
			StamenTerrain,
			[Description("stamen-toner")]
			StamenToner,
			[Description("stamen-watercolor")]
			StamenWatercolor,
			[Description("white-bg")]
			WhiteBg
		}

		/******************************
		*** Enum Name: SunburstHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum SunburstHoverOptions
		{
			[Description("label")]
			Label,
			[Description("text")]
			Text,
			[Description("value")]
			Value,
			[Description("name")]
			Name,
			[Description("current path")]
			CurrentPath,
			[Description("percent root")]
			PercentRoot,
			[Description("percent entry")]
			PercentEntry,
			[Description("percent parent")]
			PercentParent
		}

		/******************************
		*** Enum Name: SunburstTextInfoOptions
		***
		*** Description: Determines which trace information appear on the graph.
		***
		*** Source: textinfo
		******************************/

		public enum SunburstTextInfoOptions
		{
			[Description("label")]
			Label,
			[Description("text")]
			Text,
			[Description("value")]
			Value,
			[Description("current path")]
			CurrentPath,
			[Description("percent root")]
			PercentRoot,
			[Description("percent entry")]
			PercentEntry,
			[Description("percent parent")]
			PercentParent
		}

		/******************************
		*** Enum Name: SurfaceAxisOptions
		***
		*** Description: If *-1*, the scatter points are not fill with a surface If *0*, *1*, *2*, the scatter points are filled with a Delaunay surface about the x, y, z respectively.
		***
		*** Source: surfaceaxis
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
		*** Enum Name: SurfacePatternOptions
		***
		*** Description: Sets the surface pattern of the iso-surface 3-D sections. The default pattern of the surface is `all` meaning that the rest of surface elements would be shaded. The check options (either 1 or 2) could be used to draw half of the squares on the surface. Using various combinations of capital `A`, `B`, `C`, `D` and `E` may also be used to reduce the number of triangles on the iso-surfaces and creating other patterns of interest.
		***
		*** Source: pattern
		******************************/

		public enum SurfacePatternOptions
		{
			[Description("A")]
			A,
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
		*** Enum Name: SymbolOptions
		***
		*** Description: Sets the marker symbol type. Adding 100 is equivalent to appending *-open* to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to a symbol name.
		***
		*** Source: symbol
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
		*** Enum Name: SymbolTextPositionOptions
		***
		*** Description: Sets the positions of the `text` elements with respects to the (x,y) coordinates.
		***
		*** Source: textposition
		******************************/

		public enum SymbolTextPositionOptions
		{
			[Description("top left")]
			TopLeft,
			[Description("top center")]
			TopCenter,
			[Description("top right")]
			TopRight,
			[Description("middle left")]
			MiddleLeft,
			[Description("middle center")]
			MiddleCenter,
			[Description("middle right")]
			MiddleRight,
			[Description("bottom left")]
			BottomLeft,
			[Description("bottom center")]
			BottomCenter,
			[Description("bottom right")]
			BottomRight
		}

		/******************************
		*** Enum Name: TernaryHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum TernaryHoverOptions
		{
			[Description("a")]
			A,
			[Description("b")]
			B,
			[Description("c")]
			C,
			[Description("text")]
			Text,
			[Description("name")]
			Name
		}

		/******************************
		*** Enum Name: TextInfoOptions
		***
		*** Description: Determines which trace information appear on the graph.
		***
		*** Source: textinfo
		******************************/

		public enum TextInfoOptions
		{
			[Description("label")]
			Label,
			[Description("text")]
			Text,
			[Description("value")]
			Value,
			[Description("percent")]
			Percent
		}

		/******************************
		*** Enum Name: TextPositionOptions
		***
		*** Description: Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside. If *none*, no text appears.
		***
		*** Source: textposition
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
		*** Enum Name: TickLabelModeOptions
		***
		*** Description: Determines where tick labels are drawn with respect to their corresponding ticks and grid lines. Only has an effect for axes of `type` *date* When set to *period*, tick labels are drawn in the middle of the period between ticks.
		***
		*** Source: ticklabelmode
		******************************/

		public enum TickLabelModeOptions
		{
			[Description("instant")]
			Instant,
			[Description("period")]
			Period
		}

		/******************************
		*** Enum Name: TickLabelOverflowOptions
		***
		*** Description: Determines how we handle tick labels that would overflow either the graph div or the domain of the axis. The default value for inside tick labels is *hide past domain*. In other cases the default is *hide past div*.
		***
		*** Source: ticklabeloverflow
		******************************/

		public enum TickLabelOverflowOptions
		{
			[Description("allow")]
			Allow,
			[Description("hide past div")]
			HidePastDiv,
			[Description("hide past domain")]
			HidePastDomain
		}

		/******************************
		*** Enum Name: TickLabelPositionOptions
		***
		*** Description: Determines where tick labels are drawn relative to the ticks. Left and right options are used when `orientation` is *h*, top and bottom when `orientation` is *v*.
		***
		*** Source: ticklabelposition
		******************************/

		public enum TickLabelPositionOptions
		{
			[Description("outside")]
			Outside,
			[Description("inside")]
			Inside,
			[Description("outside top")]
			OutsideTop,
			[Description("inside top")]
			InsideTop,
			[Description("outside left")]
			OutsideLeft,
			[Description("inside left")]
			InsideLeft,
			[Description("outside right")]
			OutsideRight,
			[Description("inside right")]
			InsideRight,
			[Description("outside bottom")]
			OutsideBottom,
			[Description("inside bottom")]
			InsideBottom
		}

		/******************************
		*** Enum Name: TicksOnOptions
		***
		*** Description: Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
		***
		*** Source: tickson
		******************************/

		public enum TicksOnOptions
		{
			[Description("labels")]
			Labels,
			[Description("boundaries")]
			Boundaries
		}

		/******************************
		*** Enum Name: TicksOptions
		***
		*** Description: Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
		***
		*** Source: ticks
		******************************/

		public enum TicksOptions
		{
			[Description("outside")]
			Outside,
			[Description("inside")]
			Inside,
			[Description("")]
			Blank
		}

		/******************************
		*** Enum Name: TitlePositionOptions
		***
		*** Description: Specifies the location of the `title`. Note that the title's position used to be set by the now deprecated `titleposition` attribute.
		***
		*** Source: position
		******************************/

		public enum TitlePositionOptions
		{
			[Description("top left")]
			TopLeft,
			[Description("top center")]
			TopCenter,
			[Description("top right")]
			TopRight
		}

		/******************************
		*** Enum Name: TitleRefOptions
		***
		*** Description: Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only.
		***
		*** Source: xref
		******************************/

		public enum TitleRefOptions
		{
			[Description("container")]
			Container,
			[Description("paper")]
			Paper
		}

		/******************************
		*** Enum Name: TitleSideOptions
		***
		*** Description: Determines the location of color bar's title with respect to the color bar. Defaults to *top* when `orientation` if *v* and  defaults to *right* when `orientation` if *h*. Note that the title's location used to be set by the now deprecated `titleside` attribute.
		***
		*** Source: side
		******************************/

		public enum TitleSideOptions
		{
			[Description("right")]
			Right,
			[Description("top")]
			Top,
			[Description("bottom")]
			Bottom
		}

		/******************************
		*** Enum Name: TopBottomBlankOptions
		***
		*** Description: Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *top* (*bottom*), this axis' are drawn above (below) the axis line.
		***
		*** Source: ticks
		******************************/

		public enum TopBottomBlankOptions
		{
			[Description("top")]
			Top,
			[Description("bottom")]
			Bottom,
			[Description("")]
			Blank
		}

		/******************************
		*** Enum Name: TopBottomOptions
		***
		*** Description: Determines on which side of real axis line the tick and tick labels appear.
		***
		*** Source: side
		******************************/

		public enum TopBottomOptions
		{
			[Description("top")]
			Top,
			[Description("bottom")]
			Bottom
		}

		/******************************
		*** Enum Name: TopMiddleBottomOptions
		***
		*** Description: Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height.
		***
		*** Source: valign
		******************************/

		public enum TopMiddleBottomOptions
		{
			[Description("top")]
			Top,
			[Description("middle")]
			Middle,
			[Description("bottom")]
			Bottom
		}

		/******************************
		*** Enum Name: TraceOrderOptions
		***
		*** Description: Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
		***
		*** Source: traceorder
		******************************/

		public enum TraceOrderOptions
		{
			[Description("reversed")]
			Reversed,
			[Description("grouped")]
			Grouped
		}

		/******************************
		*** Enum Name: TracesOptions
		***
		*** Description: trace attributes should include an `editType` string matching this flaglist. *calc* is the most extensive: a full (re)plot starting by clearing `gd.calcdata` to force it to be regenerated *clearAxisTypes* resets the types of the axes this trace is on, because new data could cause the automatic axis type detection to change. Log type will not be cleared, as that is never automatically chosen so must have been user-specified. *plot* (re)plots but without first clearing `gd.calcdata`. *style* only calls `module.style` (or module.editStyle) for all trace modules and redraws the legend. *markerSize* is like *style*, but propagate axis-range changes due to scatter `marker.size` *colorbars* only redraws colorbars.
		***
		*** Source: traces
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
			ColorBars
		}

		/******************************
		*** Enum Name: TreemapTextPositionOptions
		***
		*** Description: Sets the positions of the `text` elements.
		***
		*** Source: textposition
		******************************/

		public enum TreemapTextPositionOptions
		{
			[Description("top left")]
			TopLeft,
			[Description("top center")]
			TopCenter,
			[Description("top right")]
			TopRight,
			[Description("middle left")]
			MiddleLeft,
			[Description("middle center")]
			MiddleCenter,
			[Description("middle right")]
			MiddleRight,
			[Description("bottom left")]
			BottomLeft,
			[Description("bottom center")]
			BottomCenter,
			[Description("bottom right")]
			BottomRight
		}

		/******************************
		*** Enum Name: UpdateMenuTypeOptions
		***
		*** Description: Determines whether the buttons are accessible via a dropdown menu or whether the buttons are stacked horizontally or vertically
		***
		*** Source: type
		******************************/

		public enum UpdateMenuTypeOptions
		{
			[Description("dropdown")]
			Dropdown,
			[Description("buttons")]
			Buttons
		}

		/******************************
		*** Enum Name: ViewAxisTypeOptions
		***
		*** Description: Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
		***
		*** Source: type
		******************************/

		public enum ViewAxisTypeOptions
		{
			[Description("-")]
			Auto,
			[Description("linear")]
			Linear,
			[Description("log")]
			Log,
			[Description("date")]
			Date,
			[Description("category")]
			Category
		}

		/******************************
		*** Enum Name: ViolinHoverOnOptions
		***
		*** Description: Do the hover effects highlight individual violins or sample points or the kernel density estimate or any combination of them?
		***
		*** Source: hoveron
		******************************/

		public enum ViolinHoverOnOptions
		{
			[Description("violins")]
			Violins,
			[Description("points")]
			Points,
			[Description("kde")]
			Kde
		}

		/******************************
		*** Enum Name: ViolinSideOptions
		***
		*** Description: Determines on which side of the position value the density function making up one half of a violin is plotted. Useful when comparing two violin traces under *overlay* mode, where one trace has `side` set to *positive* and the other to *negative*.
		***
		*** Source: side
		******************************/

		public enum ViolinSideOptions
		{
			[Description("both")]
			Both,
			[Description("positive")]
			Positive,
			[Description("negative")]
			Negative
		}

		/******************************
		*** Enum Name: VisibleOptions
		***
		*** Description: Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
		***
		*** Source: visible
		******************************/

		public enum VisibleOptions
		{
			[Description("true")]
			True,
			[Description("false")]
			False,
			[Description("legendonly")]
			LegendOnly
		}

		/******************************
		*** Enum Name: WaterfallHoverOptions
		***
		*** Description: Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
		***
		*** Source: hoverinfo
		******************************/

		public enum WaterfallHoverOptions
		{
			[Description("name")]
			Name,
			[Description("x")]
			X,
			[Description("y")]
			Y,
			[Description("text")]
			Text,
			[Description("initial")]
			Initial,
			[Description("delta")]
			Delta,
			[Description("final")]
			Final
		}

		/******************************
		*** Enum Name: WaterfallTextInfoOptions
		***
		*** Description: Determines which trace information appear on the graph. In the case of having multiple waterfalls, totals are computed separately (per trace).
		***
		*** Source: textinfo
		******************************/

		public enum WaterfallTextInfoOptions
		{
			[Description("label")]
			Label,
			[Description("text")]
			Text,
			[Description("initial")]
			Initial,
			[Description("delta")]
			Delta,
			[Description("final")]
			Final
		}

		/******************************
		*** Enum Name: XAlignOptions
		***
		*** Description: Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
		***
		*** Source: align
		******************************/

		public enum XAlignOptions
		{
			[Description("left")]
			Left,
			[Description("center")]
			Center,
			[Description("right")]
			Right
		}

		/******************************
		*** Enum Name: XAnchorOptions
		***
		*** Description: Sets the slider's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
		***
		*** Source: xanchor
		******************************/

		public enum XAnchorOptions
		{
			[Description("auto")]
			Auto,
			[Description("left")]
			Left,
			[Description("center")]
			Center,
			[Description("right")]
			Right
		}

		/******************************
		*** Enum Name: XAutoAlignOptions
		***
		*** Description: Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
		***
		*** Source: xanchor
		******************************/

		public enum XAutoAlignOptions
		{
			[Description("auto")]
			Auto,
			[Description("left")]
			Left,
			[Description("center")]
			Center,
			[Description("right")]
			Right
		}

		/******************************
		*** Enum Name: XRefOptions
		***
		*** Description: Sets the annotation's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to a x coordinate. If set to *paper*, the `x` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a x axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *x2 domain* refers to the domain of the second x  axis and a x position of 0.5 refers to the point between the left and the right of the domain of the second x axis.
		***
		*** Source: xref
		******************************/

		public enum XRefOptions
		{
			[Description("paper")]
			Paper,
			[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_X
		}

		/******************************
		*** Enum Name: XSideOptions
		***
		*** Description: Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
		***
		*** Source: xside
		******************************/

		public enum XSideOptions
		{
			[Description("bottom")]
			Bottom,
			[Description("bottom plot")]
			BottomPlot,
			[Description("top plot")]
			TopPlot,
			[Description("top")]
			Top
		}

		/******************************
		*** Enum Name: YRefOptions
		***
		*** Description: Sets the annotation's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a y axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *y2 domain* refers to the domain of the second y  axis and a y position of 0.5 refers to the point between the bottom and the top of the domain of the second y axis.
		***
		*** Source: yref
		******************************/

		public enum YRefOptions
		{
			[Description("paper")]
			Paper,
			[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
			RegEx_Y
		}

		/******************************
		*** Enum Name: YSideOptions
		***
		*** Description: Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
		***
		*** Source: yside
		******************************/

		public enum YSideOptions
		{
			[Description("left")]
			Left,
			[Description("left plot")]
			LeftPlot,
			[Description("right plot")]
			RightPlot,
			[Description("right")]
			Right
		}

		/******************************
		*** Enum Name: ZSmooth2DOptions
		***
		*** Description: Picks a smoothing algorithm use to smooth `z` data.
		***
		*** Source: zsmooth
		******************************/

		public enum ZSmooth2DOptions
		{
			[Description("fast")]
			Fast,
			[Description("best")]
			Best,
			[Description("false")]
			False
		}

		/******************************
		*** Enum Name: ZSmoothOptions
		***
		*** Description: Picks a smoothing algorithm use to smooth `z` data.
		***
		*** Source: zsmooth
		******************************/

		public enum ZSmoothOptions
		{
			[Description("fast")]
			Fast,
			[Description("false")]
			False
		}



}