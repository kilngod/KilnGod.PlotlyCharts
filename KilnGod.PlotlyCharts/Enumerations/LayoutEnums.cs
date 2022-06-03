//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LayoutEnums.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Enumerations.LayoutEnums
{


	/******************************
*** Enum Name: align

*** Description: Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
******************************/

	public enum AlignOptions
	{
		[Description("left")]
		Left,
		[Description("center")]
		Center,
		[Description("right")]
		Right
	}

	/******************************
	*** Enum Name: anchor

	*** Description: If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
	******************************/

	public enum AnchorOptions
	{
		[Description("free")]
		Free,
		[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_X,
		[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_Y
	}

	/******************************
	*** Enum Name: angularaxisType

	*** Description: Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis.
	******************************/

	public enum AngularAxisTypeOptions
	{
		[Description("-")]
		Auto,
		[Description("linear")]
		Linear,
		[Description("category")]
		Category
	}

	/******************************
	*** Enum Name: arrowside

	*** Description: Sets the annotation arrow head position.
	******************************/

	public enum ArrowSideOptions
	{
		[Description("end")]
		End,
		[Description("start")]
		Start
	}

	/******************************
	*** Enum Name: aspectmode

	*** Description: If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used.
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
	*** Enum Name: autorange

	*** Description: Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
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
	*** Enum Name: autotypenumbers

	*** Description: Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. This is the default value; however it could be overridden for individual axes.
	******************************/

	public enum AutoTypeNumbersOptions
	{
		[Description("convert types")]
		ConvertTypes,
		[Description("strict")]
		Strict
	}

	/******************************
	*** Enum Name: axref

	*** Description: Indicates in what coordinates the tail of the annotation (ax,ay) is specified. If set to a ax axis id (e.g. *ax* or *ax2*), the `ax` position refers to a ax coordinate. If set to *paper*, the `ax` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a ax axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *ax2 domain* refers to the domain of the second ax  axis and a ax position of 0.5 refers to the point between the left and the right of the domain of the second ax axis. In order for absolute positioning of the arrow to work, *axref* must be exactly the same as *xref*, otherwise *axref* will revert to *pixel* (explained next). For relative positioning, *axref* can be set to *pixel*, in which case the *ax* value is specified in pixels relative to *x*. Absolute positioning is useful for trendline annotations which should continue to indicate the correct trend when zoomed. Relative positioning is useful for specifying the text offset for an annotated point.
	******************************/

	public enum AXRefOptions
	{
		[Description("pixel")]
		Pixel,
		[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_X
	}

	/******************************
	*** Enum Name: ayref

	*** Description: Indicates in what coordinates the tail of the annotation (ax,ay) is specified. If set to a ay axis id (e.g. *ay* or *ay2*), the `ay` position refers to a ay coordinate. If set to *paper*, the `ay` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a ay axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *ay2 domain* refers to the domain of the second ay  axis and a ay position of 0.5 refers to the point between the bottom and the top of the domain of the second ay axis. In order for absolute positioning of the arrow to work, *ayref* must be exactly the same as *yref*, otherwise *ayref* will revert to *pixel* (explained next). For relative positioning, *ayref* can be set to *pixel*, in which case the *ay* value is specified in pixels relative to *y*. Absolute positioning is useful for trendline annotations which should continue to indicate the correct trend when zoomed. Relative positioning is useful for specifying the text offset for an annotated point.
	******************************/

	public enum AYRefOptions
	{
		[Description("pixel")]
		Pixel,
		[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_Y
	}

	/******************************
	*** Enum Name: calendar

	*** Description: Sets the default calendar system to use for interpreting and displaying dates throughout the plot.
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
	*** Enum Name: categoryorder

	*** Description: Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
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
	*** Enum Name: clickmode

	*** Description: Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
	******************************/

	public enum ClickModeOptions
	{
		[Description("event")]
		Event,
		[Description("select")]
		Select
	}

	/******************************
	*** Enum Name: clicktoshow

	*** Description: Makes this annotation respond to clicks on the plot. If you click a data point that exactly matches the `x` and `y` values of this annotation, and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same point again to make it disappear, so if you click multiple points, you can show multiple annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not) will hide this annotation. If you need to show/hide this annotation in response to different `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
	******************************/

	public enum ClickToShowOptions
	{
		[Description("False")]
		False,
		[Description("onoff")]
		Onoff,
		[Description("onout")]
		Onout
	}

	/******************************
	*** Enum Name: constrain

	*** Description: If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range*, or by decreasing the *domain*. Default is *domain* for axes containing image traces, *range* otherwise.
	******************************/

	public enum ConstrainOptions
	{
		[Description("range")]
		Range,
		[Description("domain")]
		Domain
	}

	/******************************
	*** Enum Name: constraintoward

	*** Description: If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
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
	*** Enum Name: dash

	*** Description: Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
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
		Longdash,
		[Description("dashdot")]
		Dashdot,
		[Description("longdashdot")]
		Longdashdot
	}

	/******************************
	*** Enum Name: direction

	*** Description: Sets the direction corresponding to positive angles.
	******************************/

	public enum DirectionOptions
	{
		[Description("counterclockwise")]
		Counterclockwise,
		[Description("clockwise")]
		Clockwise
	}

	/******************************
	*** Enum Name: dragmode

	*** Description: Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
	******************************/

	public enum DragModeOptions
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
		Drawclosedpath,
		[Description("drawopenpath")]
		Drawopenpath,
		[Description("drawline")]
		Drawline,
		[Description("drawrect")]
		Drawrect,
		[Description("drawcircle")]
		Drawcircle,
		[Description("orbit")]
		Orbit,
		[Description("turntable")]
		Turntable,
		[Description("False")]
		False
	}

	/******************************
	*** Enum Name: drawdirection

	*** Description: When `dragmode` is set to *drawrect*, *drawline* or *drawcircle* this limits the drag to be horizontal, vertical or diagonal. Using *diagonal* there is no limit e.g. in drawing lines in any direction. *ortho* limits the draw to be either horizontal or vertical. *horizontal* allows horizontal extend. *vertical* allows vertical extend.
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
	*** Enum Name: easing

	*** Description: Sets the easing function of the slider transition
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
	*** Enum Name: fillrule

	*** Description: Determines the path's interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
	******************************/

	public enum FillRuleOptions
	{
		[Description("evenodd")]
		Evenodd,
		[Description("nonzero")]
		Nonzero
	}

	/******************************
	*** Enum Name: fitbounds

	*** Description: Determines if this subplot's view settings are auto-computed to fit trace data. On scoped maps, setting `fitbounds` leads to `center.lon` and `center.lat` getting auto-filled. On maps with a non-clipped projection, setting `fitbounds` leads to `center.lon`, `center.lat`, and `projection.rotation.lon` getting auto-filled. On maps with a clipped projection, setting `fitbounds` leads to `center.lon`, `center.lat`, `projection.rotation.lon`, `projection.rotation.lat`, `lonaxis.range` and `lonaxis.range` getting auto-filled. If *locations*, only the trace's visible locations are considered in the `fitbounds` computations. If *geojson*, the entire trace input `geojson` (if provided) is considered in the `fitbounds` computations, Defaults to *false*.
	******************************/

	public enum FitBoundsOptions
	{
		[Description("False")]
		False,
		[Description("locations")]
		Locations,
		[Description("geojson")]
		Geojson
	}

	/******************************
	*** Enum Name: gridshape

	*** Description: Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
	******************************/

	public enum GridShapeOptions
	{
		[Description("circular")]
		Circular,
		[Description("linear")]
		Linear
	}

	/******************************
	*** Enum Name: groupclick

	*** Description: Determines the behavior on legend group item click. *toggleitem* toggles the visibility of the individual item clicked on the graph. *togglegroup* toggles the visibility of all items in the same legendgroup as the item clicked on the graph.
	******************************/

	public enum GroupClickOptions
	{
		[Description("toggleitem")]
		Toggleitem,
		[Description("togglegroup")]
		Togglegroup
	}

	/******************************
	*** Enum Name: hovermode

	*** Description: Determines the mode of hover interactions. If *closest*, a single hoverlabel will appear for the *closest* point within the `hoverdistance`. If *x* (or *y*), multiple hoverlabels will appear for multiple points at the *closest* x- (or y-) coordinate within the `hoverdistance`, with the caveat that no more than one hoverlabel will appear per trace. If *x unified* (or *y unified*), a single hoverlabel will appear multiple points at the closest x- (or y-) coordinate within the `hoverdistance` with the caveat that no more than one hoverlabel will appear per trace. In this mode, spikelines are enabled by default perpendicular to the specified axis. If false, hover interactions are disabled.
	******************************/

	public enum HoverModeOptions
	{
		[Description("x")]
		X,
		[Description("y")]
		Y,
		[Description("closest")]
		Closest,
		[Description("False")]
		False,
		[Description("x unified")]
		XUnified,
		[Description("y unified")]
		YUnified
	}


	/******************************
*** Enum Name: GaugeShapeOptions

*** Description: Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
******************************/

	public enum GaugeShapeOptions
	{
		[Description("angular")]
		Angular,
		[Description("bullet")]
		Bullet
	}

	/******************************
	*** Enum Name: itemclick

	*** Description: Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disables legend item click interactions.
	******************************/

	public enum ItemClickOptions
	{
		[Description("toggle")]
		Toggle,
		[Description("toggleothers")]
		Toggleothers,
		[Description("False")]
		False
	}

	/******************************
	*** Enum Name: itemdoubleclick

	*** Description: Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disables legend item double-click interactions.
	******************************/

	public enum ItemDoubleClickOptions
	{
		[Description("toggle")]
		Toggle,
		[Description("toggleothers")]
		Toggleothers,
		[Description("False")]
		False
	}

	/******************************
	*** Enum Name: items

	*** Description: 
	******************************/

	public enum ItemsOptions
	{
		[Description("/^x([2-9]|[1-9][0-9]+)?y([2-9]|[1-9][0-9]+)?$/")]
		RegEx_X
	}

	/******************************
	*** Enum Name: itemsizing

	*** Description: Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
	******************************/

	public enum ItemSizingOptions
	{
		[Description("trace")]
		Trace,
		[Description("constant")]
		Constant
	}

	/******************************
	*** Enum Name: layer

	*** Description: Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area.
	******************************/

	public enum LayerOptions
	{
		[Description("below")]
		Below,
		[Description("above")]
		Above
	}

	/******************************
	*** Enum Name: layerType

	*** Description: Sets the layer type, that is the how the layer data set in `source` will be rendered With `sourcetype` set to *geojson*, the following values are allowed: *circle*, *line*, *fill* and *symbol*. but note that *line* and *fill* are not compatible with Point GeoJSON geometries. With `sourcetype` set to *vector*, the following values are allowed:  *circle*, *line*, *fill* and *symbol*. With `sourcetype` set to *raster* or `*image*`, only the *raster* value is allowed.
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
	*** Enum Name: lineshape

	*** Description: Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area.
	******************************/

	public enum LineShapeOptions
	{
		[Description("linear")]
		Linear,
		[Description("spline")]
		Spline
			
	}

	/******************************
	*** Enum Name: matches

	*** Description: If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
	******************************/

	public enum MatchesOptions
	{
		[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_X,
		[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_Y
	}

	/******************************
	*** Enum Name: method

	*** Description: Sets the Plotly method to be called when the slider value is changed. If the `skip` method is used, the API slider will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to slider events manually via JavaScript.
	******************************/

	public enum MethodOptions
	{
		[Description("restyle")]
		Restyle,
		[Description("relayout")]
		Relayout,
		[Description("animate")]
		Animate,
		[Description("update")]
		Update,
		[Description("skip")]
		Skip
	}

	/******************************
	*** Enum Name: mirror

	*** Description: Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
	******************************/

	public enum MirrorOptions
	{
		[Description("True")]
		True,
		[Description("ticks")]
		Ticks,
		[Description("False")]
		False,
		[Description("all")]
		All,
		[Description("allticks")]
		Allticks
	}

	/******************************
	*** Enum Name: mode

	*** Description: Determines how the font size for various text elements are uniformed between each trace type. If the computed text sizes were smaller than the minimum size defined by `uniformtext.minsize` using *hide* option hides the text; and using *show* option shows the text without further downscaling. Please note that if the size defined by `minsize` is greater than the font size defined by trace, then the `minsize` is used.
	******************************/

	public enum FontModeOptions
	{
		[Description("false")]
		False,
		[Description("hide")]
		Hide,
		[Description("show")]
		Show
	}

	/******************************
	*** Enum Name: ordering

	*** Description: Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
	******************************/

	public enum OrderingOptions
	{
		[Description("layout first")]
		LayoutFirst,
		[Description("traces first")]
		TracesFirst
	}

	/******************************
	*** Enum Name: orientation

	*** Description: Sets the orientation of the colorbar.
	******************************/

	public enum OrientationOptions
	{
		[Description("h")]
		Horizontal,
		[Description("v")]
		Vertical
	}

	/******************************
	*** Enum Name: overlaying

	*** Description: If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
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
	*** Enum Name: pattern

	*** Description: If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
	******************************/

	public enum PatternOptions
	{
		[Description("independent")]
		Independent,
		[Description("coupled")]
		Coupled
	}

	/******************************
	*** Enum Name: placement

	*** Description: Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement). If `placement` is *point*, the label is placed where the geometry is located If `placement` is *line*, the label is placed along the line of the geometry If `placement` is *line-center*, the label is placed on the center of the geometry
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
	*** Enum Name: projectionType

	*** Description: Sets the projection type.
	******************************/

	public enum ProjectionTypeOptions
	{
		[Description("airy")]
		Airy,
		[Description("aitoff")]
		Aitoff,
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
		Equirectangular,
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
	*** Enum Name: radialaxisType

	*** Description: Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
	******************************/

	public enum RadialAxisTypeOptions
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
	*** Enum Name: rangemode

	*** Description: If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
	******************************/

	public enum RangeModeOptions
	{
		[Description("tozero")]
		Tozero,
		[Description("nonnegative")]
		Nonnegative,
		[Description("normal")]
		Normal
	}

	/******************************
	*** Enum Name: resolution

	*** Description: Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
	******************************/

	public enum ResolutionOptions
	{
		[Description("110")]
			_110,
		[Description("50")]
			_50
		}

	/******************************
	*** Enum Name: roworder

	*** Description: Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
	******************************/

	public enum RowOrderOptions
	{
		[Description("top to bottom")]
		TopToBottom,
		[Description("bottom to top")]
		BottomToTop
	}

	/******************************
	*** Enum Name: scaleanchor

	*** Description: If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
	******************************/

	public enum ScaleAnchorOptions
	{
		[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_X,
		[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_Y
	}

	/******************************
	*** Enum Name: scope

	*** Description: Set the scope of the map.
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
		Usa,
		[Description("world")]
		World
	}

	/******************************
	*** Enum Name: selectdirection

	*** Description: When `dragmode` is set to *select*, this limits the selection of the drag to horizontal, vertical or diagonal. *h* only allows horizontal selection, *v* only vertical, *d* only diagonal and *any* sets no limit.
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
	*** Enum Name: shapeType

	*** Description: Specifies the shape type to be drawn. If *line*, a line is drawn from (`x0`,`y0`) to (`x1`,`y1`) with respect to the axes' sizing mode. If *circle*, a circle is drawn from ((`x0`+`x1`)/2, (`y0`+`y1`)/2)) with radius (|(`x0`+`x1`)/2 - `x0`|, |(`y0`+`y1`)/2 -`y0`)|) with respect to the axes' sizing mode. If *rect*, a rectangle is drawn linking (`x0`,`y0`), (`x1`,`y0`), (`x1`,`y1`), (`x0`,`y1`), (`x0`,`y0`) with respect to the axes' sizing mode. If *path*, draw a custom SVG path using `path`. with respect to the axes' sizing mode.
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
	*** Enum Name: 	ShowLabelOptions


	*** Description: If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
	*Description: If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
	******************************/

	public enum ShowLabelOptions
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
	*** Enum Name: side

	*** Description: Determines the location of color bar's title with respect to the color bar. Defaults to *top* when `orientation` if *v* and  defaults to *right* when `orientation` if *h*. Note that the title's location used to be set by the now deprecated `titleside` attribute.
	******************************/

	public enum DensitySideOptions
	{
		[Description("positive")]
		Positive,
		[Description("negative")]
		Negative,
		[Description("both")]
		Both
	}
	/******************************
	*** Enum Name: sizing

	*** Description: Specifies which dimension of the image to constrain.
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
	*** Enum Name: sourcetype

	*** Description: Sets the source type for this layer, that is the type of the layer data.
	******************************/

	public enum SourceTypeOptions
	{
		[Description("geojson")]
		Geojson,
		[Description("vector")]
		Vector,
		[Description("raster")]
		Raster,
		[Description("image")]
		Image
	}

	/******************************
	*** Enum Name: spikedash

	*** Description: Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
	******************************/

	public enum SpikedashOptions
	{
		[Description("solid")]
		Solid,
		[Description("dot")]
		Dot,
		[Description("dash")]
		Dash,
		[Description("longdash")]
		Longdash,
		[Description("dashdot")]
		Dashdot,
		[Description("longdashdot")]
		Longdashdot
	}

	/******************************
	*** Enum Name: spikemode

	*** Description: Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
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
	*** Enum Name: spikesnap

	*** Description: Determines whether spikelines are stuck to the cursor or to the closest datapoints.
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
	*** Enum Name: step

	*** Description: The unit of measurement that the `count` value will set the range by.
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
	*** Enum Name: stepmode

	*** Description: Sets the range update mode. If *backward*, the range update shifts the start of range back *count* times *step* milliseconds. If *todate*, the range update shifts the start of range back to the first timestamp from *count* times *step* milliseconds back. For example, with `step` set to *year* and `count` set to *1* the range update shifts the start of the range back to January 01 of the current year. Month and year *todate* are currently available only for the built-in (Gregorian) calendar.
	******************************/

	public enum StepModeOptions
	{
		[Description("backward")]
		Backward,
		[Description("todate")]
		Todate
	}

	/******************************
	*** Enum Name: style

	*** Description: Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: carto-darkmatter, carto-positron, open-street-map, stamen-terrain, stamen-toner, stamen-watercolor, white-bg  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>
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
	*** Enum Name: textposition

	*** Description: Sets the positions of the `text` elements with respects to the (x,y) coordinates.
	******************************/

	public enum LayoutTextPositionOptions
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
	*** Enum Name: thetaunit

	*** Description: Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*.
	******************************/

	public enum ThetaUnitOptions
	{
		[Description("radians")]
		Radians,
		[Description("degrees")]
		Degrees
	}

	/******************************
	*** Enum Name: thicknessmode

	*** Description: Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value.
	******************************/

	public enum ThicknessModeOptions
	{
		[Description("fraction")]
		Fraction,
		[Description("pixels")]
		Pixels
	}

	/******************************
	*** Enum Name: ticklabelmode

	*** Description: Determines where tick labels are drawn with respect to their corresponding ticks and grid lines. Only has an effect for axes of `type` *date* When set to *period*, tick labels are drawn in the middle of the period between ticks.
	******************************/

	public enum TickLabelModeOptions
	{
		[Description("instant")]
		Instant,
		[Description("period")]
		Period
	}

	/******************************
	*** Enum Name: ticklabeloverflow

	*** Description: Determines how we handle tick labels that would overflow either the graph div or the domain of the axis. The default value for inside tick labels is *hide past domain*. In other cases the default is *hide past div*.
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
	*** Enum Name: ticklabelposition

	*** Description: Determines where tick labels are drawn relative to the ticks. Left and right options are used when `orientation` is *h*, top and bottom when `orientation` is *v*.
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
	*** Enum Name: tickmode

	*** Description: Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
	******************************/

	public enum TickModeOptions
	{
		[Description("auto")]
		Auto,
		[Description("linear")]
		Linear,
		[Description("array")]
		Array
	}

	/******************************
	*** Enum Name: ticks

	*** Description: Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
	******************************/

	public enum TicksOptions
	{
		[Description("outside")]
		Outside,
		[Description("inside")]
		Inside
	}

	/******************************
	*** Enum Name: tickson

	*** Description: Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
	******************************/

	public enum TicksonOptions
	{
		[Description("labels")]
		Labels,
		[Description("boundaries")]
		Boundaries
	}

	/******************************
	*** Enum Name: traceorder

	*** Description: Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
	******************************/

	public enum TraceOrderOptions
	{
		[Description("reversed")]
		Reversed,
		[Description("grouped")]
		Grouped
	}

	/******************************
	*** Enum Name: updatemenuType

	*** Description: Determines whether the buttons are accessible via a dropdown menu or whether the buttons are stacked horizontally or vertically
	******************************/

	public enum UpdateMenuTypeOptions
	{
		[Description("dropdown")]
		Dropdown,
		[Description("buttons")]
		Buttons
	}

	/******************************
	*** Enum Name: valign

	*** Description: Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height.
	******************************/

	public enum VAlignOptions
	{
		[Description("top")]
		Top,
		[Description("middle")]
		Middle,
		[Description("bottom")]
		Bottom
	}

	/******************************
	*** Enum Name: xanchor

	*** Description: Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
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
	*** Enum Name: xaxisType

	*** Description: Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
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
		MultiCategory
	}

	/******************************
	*** Enum Name: xref

	*** Description: Sets the annotation's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to a x coordinate. If set to *paper*, the `x` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a x axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *x2 domain* refers to the domain of the second x  axis and a x position of 0.5 refers to the point between the left and the right of the domain of the second x axis.
	******************************/

	public enum XRefOptions
	{
		[Description("paper")]
		Paper,
		[Description("/^x([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_X
	}

	/******************************
	*** Enum Name: xside

	*** Description: Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
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
	*** Enum Name: xsizemode

	*** Description: Sets the shapes's sizing mode along the x axis. If set to *scaled*, `x0`, `x1` and x coordinates within `path` refer to data values on the x axis or a fraction of the plot area's width (`xref` set to *paper*). If set to *pixel*, `xanchor` specifies the x position in terms of data or plot fraction but `x0`, `x1` and x coordinates within `path` are pixels relative to `xanchor`. This way, the shape can have a fixed width while maintaining a position relative to data or plot fraction.
	******************************/

	public enum XSizeModeOptions
	{
		[Description("scaled")]
		Scaled,
		[Description("pixel")]
		Pixel
	}

	/******************************
	*** Enum Name: yanchor

	*** Description: Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
	******************************/

	public enum YAnchorOptions
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
	*** Enum Name: yref

	*** Description: Sets the annotation's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a y axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *y2 domain* refers to the domain of the second y  axis and a y position of 0.5 refers to the point between the bottom and the top of the domain of the second y axis.
	******************************/

	public enum YRefOptions
	{
		[Description("paper")]
		Paper,
		[Description("/^y([2-9]|[1-9][0-9]+)?( domain)?$/")]
		RegEx_Y
	}

	/******************************
	*** Enum Name: yside

	*** Description: Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
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
	*** Enum Name: ysizemode

	*** Description: Sets the shapes's sizing mode along the y axis. If set to *scaled*, `y0`, `y1` and y coordinates within `path` refer to data values on the y axis or a fraction of the plot area's height (`yref` set to *paper*). If set to *pixel*, `yanchor` specifies the y position in terms of data or plot fraction but `y0`, `y1` and y coordinates within `path` are pixels relative to `yanchor`. This way, the shape can have a fixed height while maintaining a position relative to data or plot fraction.
	******************************/

	public enum YSizeModeOptions
	{
		[Description("scaled")]
		Scaled,
		[Description("pixel")]
		Pixel
	}

	



}
