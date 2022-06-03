using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.JsonSchema
{
    public static partial class PlotlySchema
    {
        public const string LayoutSchema = @"
{
  ""layout"": {

      ""_deprecated"": {
        ""title"": {
          ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the contents of the title, please use `title.text` now."",
          ""editType"": ""layoutstyle"",
          ""valType"": ""string""
        },
        ""titlefont"": {
          ""color"": {
            ""editType"": ""layoutstyle"",
            ""valType"": ""color""
          },
          ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
          ""editType"": ""layoutstyle"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""editType"": ""layoutstyle"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""size"": {
            ""editType"": ""layoutstyle"",
            ""min"": 1,
            ""valType"": ""number""
          }
        }
      },
      ""activeshape"": {
        ""editType"": ""none"",
        ""fillcolor"": {
          ""description"": ""Sets the color filling the active shape' interior."",
          ""dflt"": ""rgb(255,0,255)"",
          ""editType"": ""none"",
          ""valType"": ""color""
        },
        ""opacity"": {
          ""description"": ""Sets the opacity of the active shape."",
          ""dflt"": 0.5,
          ""editType"": ""none"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""role"": ""object""
      },
      ""annotations"": {
        ""items"": {
          ""annotation"": {
            ""_deprecated"": {
              ""ref"": {
                ""description"": ""Obsolete. Set `xref` and `yref` separately instead."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              }
            },
            ""align"": {
              ""description"": ""Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width."",
              ""dflt"": ""center"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""left"",
                ""center"",
                ""right""
              ]
            },
            ""arrowcolor"": {
              ""description"": ""Sets the color of the annotation arrow."",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""arrowhead"": {
              ""description"": ""Sets the end annotation arrow head style."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""max"": 8,
              ""min"": 0,
              ""valType"": ""integer""
            },
            ""arrowside"": {
              ""description"": ""Sets the annotation arrow head position."",
              ""dflt"": ""end"",
              ""editType"": ""arraydraw"",
              ""extras"": [
                ""none""
              ],
              ""flags"": [
                ""end"",
                ""start""
              ],
              ""valType"": ""flaglist""
            },
            ""arrowsize"": {
              ""description"": ""Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line."",
              ""dflt"": 1,
              ""editType"": ""calc+arraydraw"",
              ""min"": 0.3,
              ""valType"": ""number""
            },
            ""arrowwidth"": {
              ""description"": ""Sets the width (in px) of annotation arrow line."",
              ""editType"": ""calc+arraydraw"",
              ""min"": 0.1,
              ""valType"": ""number""
            },
            ""ax"": {
              ""description"": ""Sets the x component of the arrow tail about the arrow head. If `axref` is `pixel`, a positive (negative) component corresponds to an arrow pointing from right to left (left to right). If `axref` is not `pixel` and is exactly the same as `xref`, this is an absolute value on that axis, like `x`, specified in the same coordinates as `xref`."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""axref"": {
              ""description"": ""Indicates in what coordinates the tail of the annotation (ax,ay) is specified. If set to a ax axis id (e.g. *ax* or *ax2*), the `ax` position refers to a ax coordinate. If set to *paper*, the `ax` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a ax axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *ax2 domain* refers to the domain of the second ax  axis and a ax position of 0.5 refers to the point between the left and the right of the domain of the second ax axis. In order for absolute positioning of the arrow to work, *axref* must be exactly the same as *xref*, otherwise *axref* will revert to *pixel* (explained next). For relative positioning, *axref* can be set to *pixel*, in which case the *ax* value is specified in pixels relative to *x*. Absolute positioning is useful for trendline annotations which should continue to indicate the correct trend when zoomed. Relative positioning is useful for specifying the text offset for an annotated point."",
              ""dflt"": ""pixel"",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""pixel"",
                ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            },
            ""ay"": {
              ""description"": ""Sets the y component of the arrow tail about the arrow head. If `ayref` is `pixel`, a positive (negative) component corresponds to an arrow pointing from bottom to top (top to bottom). If `ayref` is not `pixel` and is exactly the same as `yref`, this is an absolute value on that axis, like `y`, specified in the same coordinates as `yref`."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""ayref"": {
              ""description"": ""Indicates in what coordinates the tail of the annotation (ax,ay) is specified. If set to a ay axis id (e.g. *ay* or *ay2*), the `ay` position refers to a ay coordinate. If set to *paper*, the `ay` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a ay axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *ay2 domain* refers to the domain of the second ay  axis and a ay position of 0.5 refers to the point between the bottom and the top of the domain of the second ay axis. In order for absolute positioning of the arrow to work, *ayref* must be exactly the same as *yref*, otherwise *ayref* will revert to *pixel* (explained next). For relative positioning, *ayref* can be set to *pixel*, in which case the *ay* value is specified in pixels relative to *y*. Absolute positioning is useful for trendline annotations which should continue to indicate the correct trend when zoomed. Relative positioning is useful for specifying the text offset for an annotated point."",
              ""dflt"": ""pixel"",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""pixel"",
                ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            },
            ""bgcolor"": {
              ""description"": ""Sets the background color of the annotation."",
              ""dflt"": ""rgba(0,0,0,0)"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""bordercolor"": {
              ""description"": ""Sets the color of the border enclosing the annotation `text`."",
              ""dflt"": ""rgba(0,0,0,0)"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""borderpad"": {
              ""description"": ""Sets the padding (in px) between the `text` and the enclosing border."",
              ""dflt"": 1,
              ""editType"": ""calc+arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""borderwidth"": {
              ""description"": ""Sets the width (in px) of the border enclosing the annotation `text`."",
              ""dflt"": 1,
              ""editType"": ""calc+arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""captureevents"": {
              ""description"": ""Determines whether the annotation text box captures mouse move and click events, or allows those events to pass through to data points in the plot that may be behind the annotation. By default `captureevents` is *false* unless `hovertext` is provided. If you use the event `plotly_clickannotation` without `hovertext` you must explicitly enable `captureevents`."",
              ""editType"": ""arraydraw"",
              ""valType"": ""boolean""
            },
            ""clicktoshow"": {
              ""description"": ""Makes this annotation respond to clicks on the plot. If you click a data point that exactly matches the `x` and `y` values of this annotation, and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same point again to make it disappear, so if you click multiple points, you can show multiple annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not) will hide this annotation. If you need to show/hide this annotation in response to different `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`."",
              ""dflt"": false,
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                false,
                ""onoff"",
                ""onout""
              ]
            },
            ""editType"": ""calc"",
            ""font"": {
              ""color"": {
                ""editType"": ""arraydraw"",
                ""valType"": ""color""
              },
              ""description"": ""Sets the annotation text font."",
              ""editType"": ""calc+arraydraw"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""calc+arraydraw"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""calc+arraydraw"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""height"": {
              ""description"": ""Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped."",
              ""dflt"": null,
              ""editType"": ""calc+arraydraw"",
              ""min"": 1,
              ""valType"": ""number""
            },
            ""hoverlabel"": {
              ""bgcolor"": {
                ""description"": ""Sets the background color of the hover label. By default uses the annotation's `bgcolor` made opaque, or white if it was transparent."",
                ""editType"": ""arraydraw"",
                ""valType"": ""color""
              },
              ""bordercolor"": {
                ""description"": ""Sets the border color of the hover label. By default uses either dark grey or white, for maximum contrast with `hoverlabel.bgcolor`."",
                ""editType"": ""arraydraw"",
                ""valType"": ""color""
              },
              ""editType"": ""arraydraw"",
              ""font"": {
                ""color"": {
                  ""editType"": ""arraydraw"",
                  ""valType"": ""color""
                },
                ""description"": ""Sets the hover label text font. By default uses the global hover font and size, with color from `hoverlabel.bordercolor`."",
                ""editType"": ""arraydraw"",
                ""family"": {
                  ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                  ""editType"": ""arraydraw"",
                  ""noBlank"": true,
                  ""strict"": true,
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""size"": {
                  ""editType"": ""arraydraw"",
                  ""min"": 1,
                  ""valType"": ""number""
                }
              },
              ""role"": ""object""
            },
            ""hovertext"": {
              ""description"": ""Sets text to appear when hovering over this annotation. If omitted or blank, no hover label will appear."",
              ""editType"": ""arraydraw"",
              ""valType"": ""string""
            },
            ""name"": {
              ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
              ""editType"": ""none"",
              ""valType"": ""string""
            },
            ""opacity"": {
              ""description"": ""Sets the opacity of the annotation (text + arrow)."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""max"": 1,
              ""min"": 0,
              ""valType"": ""number""
            },
            ""role"": ""object"",
            ""showarrow"": {
              ""description"": ""Determines whether or not the annotation is drawn with an arrow. If *true*, `text` is placed near the arrow's tail. If *false*, `text` lines up with the `x` and `y` provided."",
              ""dflt"": true,
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""boolean""
            },
            ""standoff"": {
              ""description"": ""Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount."",
              ""dflt"": 0,
              ""editType"": ""calc+arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""startarrowhead"": {
              ""description"": ""Sets the start annotation arrow head style."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""max"": 8,
              ""min"": 0,
              ""valType"": ""integer""
            },
            ""startarrowsize"": {
              ""description"": ""Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line."",
              ""dflt"": 1,
              ""editType"": ""calc+arraydraw"",
              ""min"": 0.3,
              ""valType"": ""number""
            },
            ""startstandoff"": {
              ""description"": ""Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount."",
              ""dflt"": 0,
              ""editType"": ""calc+arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""templateitemname"": {
              ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
              ""editType"": ""calc"",
              ""valType"": ""string""
            },
            ""text"": {
              ""description"": ""Sets the text associated with this annotation. Plotly uses a subset of HTML tags to do things like newline (<br>), bold (<b></b>), italics (<i></i>), hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub> <span> are also supported."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""string""
            },
            ""textangle"": {
              ""description"": ""Sets the angle at which the `text` is drawn with respect to the horizontal."",
              ""dflt"": 0,
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""angle""
            },
            ""valign"": {
              ""description"": ""Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height."",
              ""dflt"": ""middle"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""top"",
                ""middle"",
                ""bottom""
              ]
            },
            ""visible"": {
              ""description"": ""Determines whether or not this annotation is visible."",
              ""dflt"": true,
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""boolean""
            },
            ""width"": {
              ""description"": ""Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line."",
              ""dflt"": null,
              ""editType"": ""calc+arraydraw"",
              ""min"": 1,
              ""valType"": ""number""
            },
            ""x"": {
              ""description"": ""Sets the annotation's x position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""xanchor"": {
              ""description"": ""Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side."",
              ""dflt"": ""auto"",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""auto"",
                ""left"",
                ""center"",
                ""right""
              ]
            },
            ""xclick"": {
              ""description"": ""Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value."",
              ""editType"": ""arraydraw"",
              ""valType"": ""any""
            },
            ""xref"": {
              ""description"": ""Sets the annotation's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to a x coordinate. If set to *paper*, the `x` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a x axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *x2 domain* refers to the domain of the second x  axis and a x position of 0.5 refers to the point between the left and the right of the domain of the second x axis."",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""paper"",
                ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            },
            ""xshift"": {
              ""description"": ""Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels."",
              ""dflt"": 0,
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""number""
            },
            ""y"": {
              ""description"": ""Sets the annotation's y position. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""yanchor"": {
              ""description"": ""Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side."",
              ""dflt"": ""auto"",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""auto"",
                ""top"",
                ""middle"",
                ""bottom""
              ]
            },
            ""yclick"": {
              ""description"": ""Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value."",
              ""editType"": ""arraydraw"",
              ""valType"": ""any""
            },
            ""yref"": {
              ""description"": ""Sets the annotation's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a y axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *y2 domain* refers to the domain of the second y  axis and a y position of 0.5 refers to the point between the bottom and the top of the domain of the second y axis."",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""paper"",
                ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            },
            ""yshift"": {
              ""description"": ""Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels."",
              ""dflt"": 0,
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""number""
            }
          }
        },
        ""role"": ""object""
      },
      ""autosize"": {
        ""description"": ""Determines whether or not a layout width or height that has been left undefined by the user is initialized on each relayout. Note that, regardless of this attribute, an undefined layout width or height is always initialized on the first call to plot."",
        ""dflt"": false,
        ""editType"": ""none"",
        ""valType"": ""boolean""
      },
      ""autotypenumbers"": {
        ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. This is the default value; however it could be overridden for individual axes."",
        ""dflt"": ""convert types"",
        ""editType"": ""calc"",
        ""valType"": ""enumerated"",
        ""values"": [
          ""convert types"",
          ""strict""
        ]
      },
      ""calendar"": {
        ""description"": ""Sets the default calendar system to use for interpreting and displaying dates throughout the plot."",
        ""dflt"": ""gregorian"",
        ""editType"": ""calc"",
        ""valType"": ""enumerated"",
        ""values"": [
          ""chinese"",
          ""coptic"",
          ""discworld"",
          ""ethiopian"",
          ""gregorian"",
          ""hebrew"",
          ""islamic"",
          ""jalali"",
          ""julian"",
          ""mayan"",
          ""nanakshahi"",
          ""nepali"",
          ""persian"",
          ""taiwan"",
          ""thai"",
          ""ummalqura""
        ]
      },
      ""clickmode"": {
        ""description"": ""Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired."",
        ""dflt"": ""event"",
        ""editType"": ""plot"",
        ""extras"": [
          ""none""
        ],
        ""flags"": [
          ""event"",
          ""select""
        ],
        ""valType"": ""flaglist""
      },
      ""coloraxis"": {
        ""_isSubplotObj"": true,
        ""autocolorscale"": {
          ""description"": ""Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed."",
          ""dflt"": true,
          ""editType"": ""calc"",
          ""impliedEdits"": {},
          ""valType"": ""boolean""
        },
        ""cauto"": {
          ""description"": ""Determines whether or not the color domain is computed with respect to the input data (here corresponding trace color array(s)) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user."",
          ""dflt"": true,
          ""editType"": ""calc"",
          ""impliedEdits"": {},
          ""valType"": ""boolean""
        },
        ""cmax"": {
          ""description"": ""Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well."",
          ""dflt"": null,
          ""editType"": ""plot"",
          ""impliedEdits"": {
            ""cauto"": false
          },
          ""valType"": ""number""
        },
        ""cmid"": {
          ""description"": ""Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`."",
          ""dflt"": null,
          ""editType"": ""calc"",
          ""impliedEdits"": {},
          ""valType"": ""number""
        },
        ""cmin"": {
          ""description"": ""Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well."",
          ""dflt"": null,
          ""editType"": ""plot"",
          ""impliedEdits"": {
            ""cauto"": false
          },
          ""valType"": ""number""
        },
        ""colorbar"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Deprecated in favor of color bar's `title.text`. Note that value of color bar's `title` is no longer a simple *string* but a set of sub-attributes."",
              ""editType"": ""colorbars"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""colorbars"",
                ""valType"": ""color""
              },
              ""description"": ""Deprecated in favor of color bar's `title.font`."",
              ""editType"": ""colorbars"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""colorbars"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""colorbars"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""titleside"": {
              ""description"": ""Deprecated in favor of color bar's `title.side`."",
              ""dflt"": ""top"",
              ""editType"": ""colorbars"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""right"",
                ""top"",
                ""bottom""
              ]
            }
          },
          ""bgcolor"": {
            ""description"": ""Sets the color of padded area."",
            ""dflt"": ""rgba(0,0,0,0)"",
            ""editType"": ""colorbars"",
            ""valType"": ""color""
          },
          ""bordercolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""colorbars"",
            ""valType"": ""color""
          },
          ""borderwidth"": {
            ""description"": ""Sets the width (in px) or the border enclosing this color bar."",
            ""dflt"": 0,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""colorbars"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""colorbars"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""len"": {
            ""description"": ""Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends."",
            ""dflt"": 1,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""lenmode"": {
            ""description"": ""Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value."",
            ""dflt"": ""fraction"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""fraction"",
              ""pixels""
            ]
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 0,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""orientation"": {
            ""description"": ""Sets the orientation of the colorbar."",
            ""dflt"": ""v"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""h"",
              ""v""
            ]
          },
          ""outlinecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""colorbars"",
            ""valType"": ""color""
          },
          ""outlinewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""colorbars"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""colorbars"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""thickness"": {
            ""description"": ""Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels."",
            ""dflt"": 30,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""thicknessmode"": {
            ""description"": ""Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value."",
            ""dflt"": ""pixels"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""fraction"",
              ""pixels""
            ]
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""colorbars"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""colorbars"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""colorbars"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""colorbars"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the color bar's tick label font"",
            ""editType"": ""colorbars"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""colorbars"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""colorbars"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""colorbars"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""colorbars"",
                  ""items"": [
                    {
                      ""editType"": ""colorbars"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""colorbars"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""colorbars"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""colorbars"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""colorbars"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""colorbars"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""colorbars"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklabeloverflow"": {
            ""description"": ""Determines how we handle tick labels that would overflow either the graph div or the domain of the axis. The default value for inside tick labels is *hide past domain*. In other cases the default is *hide past div*."",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""allow"",
              ""hide past div"",
              ""hide past domain""
            ]
          },
          ""ticklabelposition"": {
            ""description"": ""Determines where tick labels are drawn relative to the ticks. Left and right options are used when `orientation` is *h*, top and bottom when `orientation` is *v*."",
            ""dflt"": ""outside"",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              ""outside top"",
              ""inside top"",
              ""outside left"",
              ""inside left"",
              ""outside right"",
              ""inside right"",
              ""outside bottom"",
              ""inside bottom""
            ]
          },
          ""ticklabelstep"": {
            ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
            ""dflt"": 1,
            ""editType"": ""colorbars"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""colorbars"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""colorbars"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""dflt"": """",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""colorbars"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""colorbars"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""colorbars"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""colorbars"",
            ""font"": {
              ""color"": {
                ""editType"": ""colorbars"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this color bar's title font. Note that the title's font used to be set by the now deprecated `titlefont` attribute."",
              ""editType"": ""colorbars"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""colorbars"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""colorbars"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""side"": {
              ""description"": ""Determines the location of color bar's title with respect to the color bar. Defaults to *top* when `orientation` if *v* and  defaults to *right* when `orientation` if *h*. Note that the title's location used to be set by the now deprecated `titleside` attribute."",
              ""editType"": ""colorbars"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""right"",
                ""top"",
                ""bottom""
              ]
            },
            ""text"": {
              ""description"": ""Sets the title of the color bar. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""editType"": ""colorbars"",
              ""valType"": ""string""
            }
          },
          ""x"": {
            ""description"": ""Sets the x position of the color bar (in plot fraction). Defaults to 1.02 when `orientation` is *v* and 0.5 when `orientation` is *h*."",
            ""editType"": ""colorbars"",
            ""max"": 3,
            ""min"": -2,
            ""valType"": ""number""
          },
          ""xanchor"": {
            ""description"": ""Sets this color bar's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the color bar. Defaults to *left* when `orientation` is *v* and *center* when `orientation` is *h*."",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""left"",
              ""center"",
              ""right""
            ]
          },
          ""xpad"": {
            ""description"": ""Sets the amount of padding (in px) along the x direction."",
            ""dflt"": 10,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""y"": {
            ""description"": ""Sets the y position of the color bar (in plot fraction). Defaults to 0.5 when `orientation` is *v* and 1.02 when `orientation` is *h*."",
            ""editType"": ""colorbars"",
            ""max"": 3,
            ""min"": -2,
            ""valType"": ""number""
          },
          ""yanchor"": {
            ""description"": ""Sets this color bar's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the color bar. Defaults to *middle* when `orientation` is *v* and *bottom* when `orientation` is *h*."",
            ""editType"": ""colorbars"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""top"",
              ""middle"",
              ""bottom""
            ]
          },
          ""ypad"": {
            ""description"": ""Sets the amount of padding (in px) along the y direction."",
            ""dflt"": 10,
            ""editType"": ""colorbars"",
            ""min"": 0,
            ""valType"": ""number""
          }
        },
        ""colorscale"": {
          ""description"": ""Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Blackbody,Bluered,Blues,Cividis,Earth,Electric,Greens,Greys,Hot,Jet,Picnic,Portland,Rainbow,RdBu,Reds,Viridis,YlGnBu,YlOrRd."",
          ""dflt"": null,
          ""editType"": ""calc"",
          ""impliedEdits"": {
            ""autocolorscale"": false
          },
          ""valType"": ""colorscale""
        },
        ""description"": """",
        ""editType"": ""calc"",
        ""reversescale"": {
          ""description"": ""Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color."",
          ""dflt"": false,
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""role"": ""object"",
        ""showscale"": {
          ""description"": ""Determines whether or not a colorbar is displayed for this trace."",
          ""dflt"": true,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        }
      },
      ""colorscale"": {
        ""diverging"": {
          ""description"": ""Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work."",
          ""dflt"": [
            [
              0,
              ""rgb(5,10,172)""
            ],
            [
              0.35,
              ""rgb(106,137,247)""
            ],
            [
              0.5,
              ""rgb(190,190,190)""
            ],
            [
              0.6,
              ""rgb(220,170,132)""
            ],
            [
              0.7,
              ""rgb(230,145,90)""
            ],
            [
              1,
              ""rgb(178,10,28)""
            ]
          ],
          ""editType"": ""calc"",
          ""valType"": ""colorscale""
        },
        ""editType"": ""calc"",
        ""role"": ""object"",
        ""sequential"": {
          ""description"": ""Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work."",
          ""dflt"": [
            [
              0,
              ""rgb(220,220,220)""
            ],
            [
              0.2,
              ""rgb(245,195,157)""
            ],
            [
              0.4,
              ""rgb(245,160,105)""
            ],
            [
              1,
              ""rgb(178,10,28)""
            ]
          ],
          ""editType"": ""calc"",
          ""valType"": ""colorscale""
        },
        ""sequentialminus"": {
          ""description"": ""Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work."",
          ""dflt"": [
            [
              0,
              ""rgb(5,10,172)""
            ],
            [
              0.35,
              ""rgb(40,60,190)""
            ],
            [
              0.5,
              ""rgb(70,100,245)""
            ],
            [
              0.6,
              ""rgb(90,120,245)""
            ],
            [
              0.7,
              ""rgb(106,137,247)""
            ],
            [
              1,
              ""rgb(220,220,220)""
            ]
          ],
          ""editType"": ""calc"",
          ""valType"": ""colorscale""
        }
      },
      ""colorway"": {
        ""description"": ""Sets the default trace colors."",
        ""dflt"": [
          ""#1f77b4"",
          ""#ff7f0e"",
          ""#2ca02c"",
          ""#d62728"",
          ""#9467bd"",
          ""#8c564b"",
          ""#e377c2"",
          ""#7f7f7f"",
          ""#bcbd22"",
          ""#17becf""
        ],
        ""editType"": ""calc"",
        ""valType"": ""colorlist""
      },
      ""computed"": {
        ""description"": ""Placeholder for exporting automargin-impacting values namely `margin.t`, `margin.b`, `margin.l` and `margin.r` in *full-json* mode."",
        ""editType"": ""none"",
        ""valType"": ""any""
      },
      ""datarevision"": {
        ""description"": ""If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data."",
        ""editType"": ""calc"",
        ""valType"": ""any""
      },
      ""dragmode"": {
        ""description"": ""Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes."",
        ""dflt"": ""zoom"",
        ""editType"": ""modebar"",
        ""valType"": ""enumerated"",
        ""values"": [
          ""zoom"",
          ""pan"",
          ""select"",
          ""lasso"",
          ""drawclosedpath"",
          ""drawopenpath"",
          ""drawline"",
          ""drawrect"",
          ""drawcircle"",
          ""orbit"",
          ""turntable"",
          false
        ]
      },
      ""editrevision"": {
        ""description"": ""Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`."",
        ""editType"": ""none"",
        ""valType"": ""any""
      },
      ""editType"": ""calc"",
      ""font"": {
        ""color"": {
          ""dflt"": ""#444"",
          ""editType"": ""calc"",
          ""valType"": ""color""
        },
        ""description"": ""Sets the global font. Note that fonts used in traces and other layout components inherit from the global font."",
        ""editType"": ""calc"",
        ""family"": {
          ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
          ""dflt"": ""\""Open Sans\"", verdana, arial, sans-serif"",
          ""editType"": ""calc"",
          ""noBlank"": true,
          ""strict"": true,
          ""valType"": ""string""
        },
        ""role"": ""object"",
        ""size"": {
          ""dflt"": 12,
          ""editType"": ""calc"",
          ""min"": 1,
          ""valType"": ""number""
        }
      },
      ""geo"": {
        ""_isSubplotObj"": true,
        ""bgcolor"": {
          ""description"": ""Set the background color of the map"",
          ""dflt"": ""#fff"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""center"": {
          ""editType"": ""plot"",
          ""lat"": {
            ""description"": ""Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default."",
            ""editType"": ""plot"",
            ""valType"": ""number""
          },
          ""lon"": {
            ""description"": ""Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise."",
            ""editType"": ""plot"",
            ""valType"": ""number""
          },
          ""role"": ""object""
        },
        ""coastlinecolor"": {
          ""description"": ""Sets the coastline color."",
          ""dflt"": ""#444"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""coastlinewidth"": {
          ""description"": ""Sets the coastline stroke width (in px)."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""countrycolor"": {
          ""description"": ""Sets line color of the country boundaries."",
          ""dflt"": ""#444"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""countrywidth"": {
          ""description"": ""Sets line width (in px) of the country boundaries."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""domain"": {
          ""column"": {
            ""description"": ""If there is a layout grid, use the domain for this column in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""editType"": ""plot"",
          ""role"": ""object"",
          ""row"": {
            ""description"": ""If there is a layout grid, use the domain for this row in the grid for this geo subplot . Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""x"": {
            ""description"": ""Sets the horizontal domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""y"": {
            ""description"": ""Sets the vertical domain of this geo subplot (in plot fraction). Note that geo subplots are constrained by domain. In general, when `projection.scale` is set to 1. a map will fit either its x or y domain, but not both."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          }
        },
        ""editType"": ""plot"",
        ""fitbounds"": {
          ""description"": ""Determines if this subplot's view settings are auto-computed to fit trace data. On scoped maps, setting `fitbounds` leads to `center.lon` and `center.lat` getting auto-filled. On maps with a non-clipped projection, setting `fitbounds` leads to `center.lon`, `center.lat`, and `projection.rotation.lon` getting auto-filled. On maps with a clipped projection, setting `fitbounds` leads to `center.lon`, `center.lat`, `projection.rotation.lon`, `projection.rotation.lat`, `lonaxis.range` and `lonaxis.range` getting auto-filled. If *locations*, only the trace's visible locations are considered in the `fitbounds` computations. If *geojson*, the entire trace input `geojson` (if provided) is considered in the `fitbounds` computations, Defaults to *false*."",
          ""dflt"": false,
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            false,
            ""locations"",
            ""geojson""
          ]
        },
        ""framecolor"": {
          ""description"": ""Sets the color the frame."",
          ""dflt"": ""#444"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""framewidth"": {
          ""description"": ""Sets the stroke width (in px) of the frame."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""lakecolor"": {
          ""description"": ""Sets the color of the lakes."",
          ""dflt"": ""#3399FF"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""landcolor"": {
          ""description"": ""Sets the land mass color."",
          ""dflt"": ""#F0DC82"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""lataxis"": {
          ""dtick"": {
            ""description"": ""Sets the graticule's longitude/latitude tick step."",
            ""editType"": ""plot"",
            ""valType"": ""number""
          },
          ""editType"": ""plot"",
          ""gridcolor"": {
            ""description"": ""Sets the graticule's stroke color."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the graticule's stroke width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""range"": {
            ""description"": ""Sets the range of this axis (in degrees), sets the map's clipped coordinates."",
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""role"": ""object"",
          ""showgrid"": {
            ""description"": ""Sets whether or not graticule are shown on the map."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""tick0"": {
            ""description"": ""Sets the graticule's starting tick longitude/latitude."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""valType"": ""number""
          }
        },
        ""lonaxis"": {
          ""dtick"": {
            ""description"": ""Sets the graticule's longitude/latitude tick step."",
            ""editType"": ""plot"",
            ""valType"": ""number""
          },
          ""editType"": ""plot"",
          ""gridcolor"": {
            ""description"": ""Sets the graticule's stroke color."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the graticule's stroke width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""range"": {
            ""description"": ""Sets the range of this axis (in degrees), sets the map's clipped coordinates."",
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""role"": ""object"",
          ""showgrid"": {
            ""description"": ""Sets whether or not graticule are shown on the map."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""tick0"": {
            ""description"": ""Sets the graticule's starting tick longitude/latitude."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""valType"": ""number""
          }
        },
        ""oceancolor"": {
          ""description"": ""Sets the ocean color"",
          ""dflt"": ""#3399FF"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""projection"": {
          ""distance"": {
            ""description"": ""For satellite projection type only. Sets the distance from the center of the sphere to the point of view as a proportion of the sphere’s radius."",
            ""dflt"": 2,
            ""editType"": ""plot"",
            ""min"": 1.001,
            ""valType"": ""number""
          },
          ""editType"": ""plot"",
          ""parallels"": {
            ""description"": ""For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere."",
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""role"": ""object"",
          ""rotation"": {
            ""editType"": ""plot"",
            ""lat"": {
              ""description"": ""Rotates the map along meridians (in degrees North)."",
              ""editType"": ""plot"",
              ""valType"": ""number""
            },
            ""lon"": {
              ""description"": ""Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values."",
              ""editType"": ""plot"",
              ""valType"": ""number""
            },
            ""role"": ""object"",
            ""roll"": {
              ""description"": ""Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down."",
              ""editType"": ""plot"",
              ""valType"": ""number""
            }
          },
          ""scale"": {
            ""description"": ""Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges. "",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tilt"": {
            ""description"": ""For satellite projection type only. Sets the tilt angle of perspective projection."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""valType"": ""number""
          },
          ""type"": {
            ""description"": ""Sets the projection type."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""airy"",
              ""aitoff"",
              ""albers"",
              ""albers usa"",
              ""august"",
              ""azimuthal equal area"",
              ""azimuthal equidistant"",
              ""baker"",
              ""bertin1953"",
              ""boggs"",
              ""bonne"",
              ""bottomley"",
              ""bromley"",
              ""collignon"",
              ""conic conformal"",
              ""conic equal area"",
              ""conic equidistant"",
              ""craig"",
              ""craster"",
              ""cylindrical equal area"",
              ""cylindrical stereographic"",
              ""eckert1"",
              ""eckert2"",
              ""eckert3"",
              ""eckert4"",
              ""eckert5"",
              ""eckert6"",
              ""eisenlohr"",
              ""equirectangular"",
              ""fahey"",
              ""foucaut"",
              ""foucaut sinusoidal"",
              ""ginzburg4"",
              ""ginzburg5"",
              ""ginzburg6"",
              ""ginzburg8"",
              ""ginzburg9"",
              ""gnomonic"",
              ""gringorten"",
              ""gringorten quincuncial"",
              ""guyou"",
              ""hammer"",
              ""hill"",
              ""homolosine"",
              ""hufnagel"",
              ""hyperelliptical"",
              ""kavrayskiy7"",
              ""lagrange"",
              ""larrivee"",
              ""laskowski"",
              ""loximuthal"",
              ""mercator"",
              ""miller"",
              ""mollweide"",
              ""mt flat polar parabolic"",
              ""mt flat polar quartic"",
              ""mt flat polar sinusoidal"",
              ""natural earth"",
              ""natural earth1"",
              ""natural earth2"",
              ""nell hammer"",
              ""nicolosi"",
              ""orthographic"",
              ""patterson"",
              ""peirce quincuncial"",
              ""polyconic"",
              ""rectangular polyconic"",
              ""robinson"",
              ""satellite"",
              ""sinu mollweide"",
              ""sinusoidal"",
              ""stereographic"",
              ""times"",
              ""transverse mercator"",
              ""van der grinten"",
              ""van der grinten2"",
              ""van der grinten3"",
              ""van der grinten4"",
              ""wagner4"",
              ""wagner6"",
              ""wiechel"",
              ""winkel tripel"",
              ""winkel3""
            ]
          }
        },
        ""resolution"": {
          ""coerceNumber"": true,
          ""description"": ""Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000."",
          ""dflt"": 110,
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            110,
            50
          ]
        },
        ""rivercolor"": {
          ""description"": ""Sets color of the rivers."",
          ""dflt"": ""#3399FF"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""riverwidth"": {
          ""description"": ""Sets the stroke width (in px) of the rivers."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""role"": ""object"",
        ""scope"": {
          ""description"": ""Set the scope of the map."",
          ""dflt"": ""world"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""africa"",
            ""asia"",
            ""europe"",
            ""north america"",
            ""south america"",
            ""usa"",
            ""world""
          ]
        },
        ""showcoastlines"": {
          ""description"": ""Sets whether or not the coastlines are drawn."",
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""showcountries"": {
          ""description"": ""Sets whether or not country boundaries are drawn."",
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""showframe"": {
          ""description"": ""Sets whether or not a frame is drawn around the map."",
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""showlakes"": {
          ""description"": ""Sets whether or not lakes are drawn."",
          ""dflt"": false,
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""showland"": {
          ""description"": ""Sets whether or not land masses are filled in color."",
          ""dflt"": false,
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""showocean"": {
          ""description"": ""Sets whether or not oceans are filled in color."",
          ""dflt"": false,
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""showrivers"": {
          ""description"": ""Sets whether or not rivers are drawn."",
          ""dflt"": false,
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""showsubunits"": {
          ""description"": ""Sets whether or not boundaries of subunits within countries (e.g. states, provinces) are drawn."",
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""subunitcolor"": {
          ""description"": ""Sets the color of the subunits boundaries."",
          ""dflt"": ""#444"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""subunitwidth"": {
          ""description"": ""Sets the stroke width (in px) of the subunits boundaries."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        },
        ""visible"": {
          ""description"": ""Sets the default visibility of the base layers."",
          ""dflt"": true,
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        }
      },
      ""grid"": {
        ""columns"": {
          ""description"": ""The number of columns in the grid. If you provide a 2D `subplots` array, the length of its longest row is used as the default. If you give an `xaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots."",
          ""editType"": ""plot"",
          ""min"": 1,
          ""valType"": ""integer""
        },
        ""domain"": {
          ""editType"": ""plot"",
          ""role"": ""object"",
          ""x"": {
            ""description"": ""Sets the horizontal domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""y"": {
            ""description"": ""Sets the vertical domain of this grid subplot (in plot fraction). The first and last cells end exactly at the domain edges, with no grout around the edges."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          }
        },
        ""editType"": ""plot"",
        ""pattern"": {
          ""description"": ""If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`."",
          ""dflt"": ""coupled"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""independent"",
            ""coupled""
          ]
        },
        ""role"": ""object"",
        ""roworder"": {
          ""description"": ""Is the first row the top or the bottom? Note that columns are always enumerated from left to right."",
          ""dflt"": ""top to bottom"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""top to bottom"",
            ""bottom to top""
          ]
        },
        ""rows"": {
          ""description"": ""The number of rows in the grid. If you provide a 2D `subplots` array or a `yaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots."",
          ""editType"": ""plot"",
          ""min"": 1,
          ""valType"": ""integer""
        },
        ""subplots"": {
          ""description"": ""Used for freeform grids, where some axes may be shared across subplots but others are not. Each entry should be a cartesian subplot id, like *xy* or *x3y2*, or ** to leave that cell empty. You may reuse x axes within the same column, and y axes within the same row. Non-cartesian subplots and traces that support `domain` can place themselves in this grid separately using the `gridcell` attribute."",
          ""dimensions"": 2,
          ""editType"": ""plot"",
          ""freeLength"": true,
          ""items"": {
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""/^x([2-9]|[1-9][0-9]+)?y([2-9]|[1-9][0-9]+)?$/"",
              """"
            ]
          },
          ""valType"": ""info_array""
        },
        ""xaxes"": {
          ""description"": ""Used with `yaxes` when the x and y axes are shared across columns and rows. Each entry should be an x axis id like *x*, *x2*, etc., or ** to not put an x axis in that column. Entries other than ** must be unique. Ignored if `subplots` is present. If missing but `yaxes` is present, will generate consecutive IDs."",
          ""editType"": ""plot"",
          ""freeLength"": true,
          ""items"": {
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
              """"
            ]
          },
          ""valType"": ""info_array""
        },
        ""xgap"": {
          ""description"": ""Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids."",
          ""editType"": ""plot"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""xside"": {
          ""description"": ""Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar."",
          ""dflt"": ""bottom plot"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""bottom"",
            ""bottom plot"",
            ""top plot"",
            ""top""
          ]
        },
        ""yaxes"": {
          ""description"": ""Used with `yaxes` when the x and y axes are shared across columns and rows. Each entry should be an y axis id like *y*, *y2*, etc., or ** to not put a y axis in that row. Entries other than ** must be unique. Ignored if `subplots` is present. If missing but `xaxes` is present, will generate consecutive IDs."",
          ""editType"": ""plot"",
          ""freeLength"": true,
          ""items"": {
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/"",
              """"
            ]
          },
          ""valType"": ""info_array""
        },
        ""ygap"": {
          ""description"": ""Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids."",
          ""editType"": ""plot"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""yside"": {
          ""description"": ""Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar."",
          ""dflt"": ""left plot"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""left"",
            ""left plot"",
            ""right plot"",
            ""right""
          ]
        }
      },
      ""height"": {
        ""description"": ""Sets the plot's height (in px)."",
        ""dflt"": 450,
        ""editType"": ""plot"",
        ""min"": 10,
        ""valType"": ""number""
      },
      ""hidesources"": {
        ""description"": ""Determines whether or not a text link citing the data source is placed at the bottom-right cored of the figure. Has only an effect only on graphs that have been generated via forked graphs from the Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise)."",
        ""dflt"": false,
        ""editType"": ""plot"",
        ""valType"": ""boolean""
      },
      ""hoverdistance"": {
        ""description"": ""Sets the default distance (in pixels) to look for data to add hover labels (-1 means no cutoff, 0 means no looking for data). This is only a real distance for hovering on point-like objects, like scatter points. For area-like objects (bars, scatter fills, etc) hovering is on inside the area and off outside, but these objects will not supersede hover on point-like objects in case of conflict."",
        ""dflt"": 20,
        ""editType"": ""none"",
        ""min"": -1,
        ""valType"": ""integer""
      },
      ""hoverlabel"": {
        ""align"": {
          ""description"": ""Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines"",
          ""dflt"": ""auto"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""left"",
            ""right"",
            ""auto""
          ]
        },
        ""bgcolor"": {
          ""description"": ""Sets the background color of all hover labels on graph"",
          ""editType"": ""none"",
          ""valType"": ""color""
        },
        ""bordercolor"": {
          ""description"": ""Sets the border color of all hover labels on graph."",
          ""editType"": ""none"",
          ""valType"": ""color""
        },
        ""editType"": ""none"",
        ""font"": {
          ""color"": {
            ""editType"": ""none"",
            ""valType"": ""color""
          },
          ""description"": ""Sets the default hover label font used by all traces on the graph."",
          ""editType"": ""none"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""dflt"": ""Arial, sans-serif"",
            ""editType"": ""none"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""role"": ""object"",
          ""size"": {
            ""dflt"": 13,
            ""editType"": ""none"",
            ""min"": 1,
            ""valType"": ""number""
          }
        },
        ""grouptitlefont"": {
          ""color"": {
            ""editType"": ""none"",
            ""valType"": ""color""
          },
          ""description"": ""Sets the font for group titles in hover (unified modes). Defaults to `hoverlabel.font`."",
          ""editType"": ""none"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""editType"": ""none"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""role"": ""object"",
          ""size"": {
            ""editType"": ""none"",
            ""min"": 1,
            ""valType"": ""number""
          }
        },
        ""namelength"": {
          ""description"": ""Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis."",
          ""dflt"": 15,
          ""editType"": ""none"",
          ""min"": -1,
          ""valType"": ""integer""
        },
        ""role"": ""object""
      },
      ""hovermode"": {
        ""description"": ""Determines the mode of hover interactions. If *closest*, a single hoverlabel will appear for the *closest* point within the `hoverdistance`. If *x* (or *y*), multiple hoverlabels will appear for multiple points at the *closest* x- (or y-) coordinate within the `hoverdistance`, with the caveat that no more than one hoverlabel will appear per trace. If *x unified* (or *y unified*), a single hoverlabel will appear multiple points at the closest x- (or y-) coordinate within the `hoverdistance` with the caveat that no more than one hoverlabel will appear per trace. In this mode, spikelines are enabled by default perpendicular to the specified axis. If false, hover interactions are disabled."",
        ""dflt"": ""closest"",
        ""editType"": ""modebar"",
        ""valType"": ""enumerated"",
        ""values"": [
          ""x"",
          ""y"",
          ""closest"",
          false,
          ""x unified"",
          ""y unified""
        ]
      },
      ""images"": {
        ""items"": {
          ""image"": {
            ""editType"": ""arraydraw"",
            ""layer"": {
              ""description"": ""Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area."",
              ""dflt"": ""above"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""below"",
                ""above""
              ]
            },
            ""name"": {
              ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
              ""editType"": ""none"",
              ""valType"": ""string""
            },
            ""opacity"": {
              ""description"": ""Sets the opacity of the image."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""max"": 1,
              ""min"": 0,
              ""valType"": ""number""
            },
            ""role"": ""object"",
            ""sizex"": {
              ""description"": ""Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width. When `xref` ends with ` domain`, units are sized relative to the axis width."",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""valType"": ""number""
            },
            ""sizey"": {
              ""description"": ""Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height. When `yref` ends with ` domain`, units are sized relative to the axis height."",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""valType"": ""number""
            },
            ""sizing"": {
              ""description"": ""Specifies which dimension of the image to constrain."",
              ""dflt"": ""contain"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""fill"",
                ""contain"",
                ""stretch""
              ]
            },
            ""source"": {
              ""description"": ""Specifies the URL of the image to be used. The URL must be accessible from the domain where the plot code is run, and can be either relative or absolute."",
              ""editType"": ""arraydraw"",
              ""valType"": ""string""
            },
            ""templateitemname"": {
              ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
              ""editType"": ""calc"",
              ""valType"": ""string""
            },
            ""visible"": {
              ""description"": ""Determines whether or not this image is visible."",
              ""dflt"": true,
              ""editType"": ""arraydraw"",
              ""valType"": ""boolean""
            },
            ""x"": {
              ""description"": ""Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info"",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""valType"": ""any""
            },
            ""xanchor"": {
              ""description"": ""Sets the anchor for the x position"",
              ""dflt"": ""left"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""left"",
                ""center"",
                ""right""
              ]
            },
            ""xref"": {
              ""description"": ""Sets the images's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to a x coordinate. If set to *paper*, the `x` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a x axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *x2 domain* refers to the domain of the second x  axis and a x position of 0.5 refers to the point between the left and the right of the domain of the second x axis."",
              ""dflt"": ""paper"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""paper"",
                ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            },
            ""y"": {
              ""description"": ""Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info"",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""valType"": ""any""
            },
            ""yanchor"": {
              ""description"": ""Sets the anchor for the y position."",
              ""dflt"": ""top"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""top"",
                ""middle"",
                ""bottom""
              ]
            },
            ""yref"": {
              ""description"": ""Sets the images's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a y axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *y2 domain* refers to the domain of the second y  axis and a y position of 0.5 refers to the point between the bottom and the top of the domain of the second y axis."",
              ""dflt"": ""paper"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""paper"",
                ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            }
          }
        },
        ""role"": ""object""
      },
      ""legend"": {
        ""bgcolor"": {
          ""description"": ""Sets the legend background color. Defaults to `layout.paper_bgcolor`."",
          ""editType"": ""legend"",
          ""valType"": ""color""
        },
        ""bordercolor"": {
          ""description"": ""Sets the color of the border enclosing the legend."",
          ""dflt"": ""#444"",
          ""editType"": ""legend"",
          ""valType"": ""color""
        },
        ""borderwidth"": {
          ""description"": ""Sets the width (in px) of the border enclosing the legend."",
          ""dflt"": 0,
          ""editType"": ""legend"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""editType"": ""legend"",
        ""font"": {
          ""color"": {
            ""editType"": ""legend"",
            ""valType"": ""color""
          },
          ""description"": ""Sets the font used to text the legend items."",
          ""editType"": ""legend"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""editType"": ""legend"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""role"": ""object"",
          ""size"": {
            ""editType"": ""legend"",
            ""min"": 1,
            ""valType"": ""number""
          }
        },
        ""groupclick"": {
          ""description"": ""Determines the behavior on legend group item click. *toggleitem* toggles the visibility of the individual item clicked on the graph. *togglegroup* toggles the visibility of all items in the same legendgroup as the item clicked on the graph."",
          ""dflt"": ""togglegroup"",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""toggleitem"",
            ""togglegroup""
          ]
        },
        ""grouptitlefont"": {
          ""color"": {
            ""editType"": ""legend"",
            ""valType"": ""color""
          },
          ""description"": ""Sets the font for group titles in legend. Defaults to `legend.font` with its size increased about 10%."",
          ""editType"": ""legend"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""editType"": ""legend"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""role"": ""object"",
          ""size"": {
            ""editType"": ""legend"",
            ""min"": 1,
            ""valType"": ""number""
          }
        },
        ""itemclick"": {
          ""description"": ""Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disables legend item click interactions."",
          ""dflt"": ""toggle"",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""toggle"",
            ""toggleothers"",
            false
          ]
        },
        ""itemdoubleclick"": {
          ""description"": ""Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disables legend item double-click interactions."",
          ""dflt"": ""toggleothers"",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""toggle"",
            ""toggleothers"",
            false
          ]
        },
        ""itemsizing"": {
          ""description"": ""Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph."",
          ""dflt"": ""trace"",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""trace"",
            ""constant""
          ]
        },
        ""itemwidth"": {
          ""description"": ""Sets the width (in px) of the legend item symbols (the part other than the title.text)."",
          ""dflt"": 30,
          ""editType"": ""legend"",
          ""min"": 30,
          ""valType"": ""number""
        },
        ""orientation"": {
          ""description"": ""Sets the orientation of the legend."",
          ""dflt"": ""v"",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""v"",
            ""h""
          ]
        },
        ""role"": ""object"",
        ""title"": {
          ""editType"": ""legend"",
          ""font"": {
            ""color"": {
              ""editType"": ""legend"",
              ""valType"": ""color""
            },
            ""description"": ""Sets this legend's title font. Defaults to `legend.font` with its size increased about 20%."",
            ""editType"": ""legend"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""legend"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""legend"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""role"": ""object"",
          ""side"": {
            ""description"": ""Determines the location of legend's title with respect to the legend items. Defaulted to *top* with `orientation` is *h*. Defaulted to *left* with `orientation` is *v*. The *top left* options could be used to expand legend area in both x and y sides."",
            ""editType"": ""legend"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""top"",
              ""left"",
              ""top left""
            ]
          },
          ""text"": {
            ""description"": ""Sets the title of the legend."",
            ""dflt"": """",
            ""editType"": ""legend"",
            ""valType"": ""string""
          }
        },
        ""tracegroupgap"": {
          ""description"": ""Sets the amount of vertical space (in px) between legend groups."",
          ""dflt"": 10,
          ""editType"": ""legend"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""traceorder"": {
          ""description"": ""Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*."",
          ""editType"": ""legend"",
          ""extras"": [
            ""normal""
          ],
          ""flags"": [
            ""reversed"",
            ""grouped""
          ],
          ""valType"": ""flaglist""
        },
        ""uirevision"": {
          ""description"": ""Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        },
        ""valign"": {
          ""description"": ""Sets the vertical alignment of the symbols with respect to their associated text."",
          ""dflt"": ""middle"",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""top"",
            ""middle"",
            ""bottom""
          ]
        },
        ""x"": {
          ""description"": ""Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends."",
          ""editType"": ""legend"",
          ""max"": 3,
          ""min"": -2,
          ""valType"": ""number""
        },
        ""xanchor"": {
          ""description"": ""Sets the legend's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the legend. Value *auto* anchors legends to the right for `x` values greater than or equal to 2/3, anchors legends to the left for `x` values less than or equal to 1/3 and anchors legends with respect to their center otherwise."",
          ""dflt"": ""left"",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""auto"",
            ""left"",
            ""center"",
            ""right""
          ]
        },
        ""y"": {
          ""description"": ""Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders."",
          ""editType"": ""legend"",
          ""max"": 3,
          ""min"": -2,
          ""valType"": ""number""
        },
        ""yanchor"": {
          ""description"": ""Sets the legend's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the legend. Value *auto* anchors legends at their bottom for `y` values less than or equal to 1/3, anchors legends to at their top for `y` values greater than or equal to 2/3 and anchors legends with respect to their middle otherwise."",
          ""editType"": ""legend"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""auto"",
            ""top"",
            ""middle"",
            ""bottom""
          ]
        }
      },
      ""mapbox"": {
        ""_arrayAttrRegexps"": [
          {}
        ],
        ""_isSubplotObj"": true,
        ""accesstoken"": {
          ""description"": ""Sets the mapbox access token to be used for this mapbox map. Alternatively, the mapbox access token can be set in the configuration options under `mapboxAccessToken`. Note that accessToken are only required when `style` (e.g with values : basic, streets, outdoors, light, dark, satellite, satellite-streets ) and/or a layout layer references the Mapbox server."",
          ""editType"": ""plot"",
          ""noBlank"": true,
          ""strict"": true,
          ""valType"": ""string""
        },
        ""bearing"": {
          ""description"": ""Sets the bearing angle of the map in degrees counter-clockwise from North (mapbox.bearing)."",
          ""dflt"": 0,
          ""editType"": ""plot"",
          ""valType"": ""number""
        },
        ""center"": {
          ""editType"": ""plot"",
          ""lat"": {
            ""description"": ""Sets the latitude of the center of the map (in degrees North)."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""valType"": ""number""
          },
          ""lon"": {
            ""description"": ""Sets the longitude of the center of the map (in degrees East)."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""valType"": ""number""
          },
          ""role"": ""object""
        },
        ""domain"": {
          ""column"": {
            ""description"": ""If there is a layout grid, use the domain for this column in the grid for this mapbox subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""editType"": ""plot"",
          ""role"": ""object"",
          ""row"": {
            ""description"": ""If there is a layout grid, use the domain for this row in the grid for this mapbox subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""x"": {
            ""description"": ""Sets the horizontal domain of this mapbox subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""y"": {
            ""description"": ""Sets the vertical domain of this mapbox subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          }
        },
        ""editType"": ""plot"",
        ""layers"": {
          ""items"": {
            ""layer"": {
              ""below"": {
                ""description"": ""Determines if the layer will be inserted before the layer with the specified ID. If omitted or set to '', the layer will be inserted above every existing layer."",
                ""editType"": ""plot"",
                ""valType"": ""string""
              },
              ""circle"": {
                ""editType"": ""plot"",
                ""radius"": {
                  ""description"": ""Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect only when `type` is set to *circle*."",
                  ""dflt"": 15,
                  ""editType"": ""plot"",
                  ""valType"": ""number""
                },
                ""role"": ""object""
              },
              ""color"": {
                ""description"": ""Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)"",
                ""dflt"": ""#444"",
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""coordinates"": {
                ""description"": ""Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`."",
                ""editType"": ""plot"",
                ""valType"": ""any""
              },
              ""editType"": ""plot"",
              ""fill"": {
                ""editType"": ""plot"",
                ""outlinecolor"": {
                  ""description"": ""Sets the fill outline color (mapbox.layer.paint.fill-outline-color). Has an effect only when `type` is set to *fill*."",
                  ""dflt"": ""#444"",
                  ""editType"": ""plot"",
                  ""valType"": ""color""
                },
                ""role"": ""object""
              },
              ""line"": {
                ""dash"": {
                  ""description"": ""Sets the length of dashes and gaps (mapbox.layer.paint.line-dasharray). Has an effect only when `type` is set to *line*."",
                  ""editType"": ""plot"",
                  ""valType"": ""data_array""
                },
                ""dashsrc"": {
                  ""description"": ""Sets the source reference on Chart Studio Cloud for `dash`."",
                  ""editType"": ""none"",
                  ""valType"": ""string""
                },
                ""editType"": ""plot"",
                ""role"": ""object"",
                ""width"": {
                  ""description"": ""Sets the line width (mapbox.layer.paint.line-width). Has an effect only when `type` is set to *line*."",
                  ""dflt"": 2,
                  ""editType"": ""plot"",
                  ""valType"": ""number""
                }
              },
              ""maxzoom"": {
                ""description"": ""Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal to or greater than the maxzoom, the layer will be hidden."",
                ""dflt"": 24,
                ""editType"": ""plot"",
                ""max"": 24,
                ""min"": 0,
                ""valType"": ""number""
              },
              ""minzoom"": {
                ""description"": ""Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less than the minzoom, the layer will be hidden."",
                ""dflt"": 0,
                ""editType"": ""plot"",
                ""max"": 24,
                ""min"": 0,
                ""valType"": ""number""
              },
              ""name"": {
                ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                ""editType"": ""plot"",
                ""valType"": ""string""
              },
              ""opacity"": {
                ""description"": ""Sets the opacity of the layer. If `type` is *circle*, opacity corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If `type` is *line*, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity) If `type` is *fill*, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity) If `type` is *symbol*, opacity corresponds to the icon/text opacity (mapbox.layer.paint.text-opacity)"",
                ""dflt"": 1,
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              ""role"": ""object"",
              ""source"": {
                ""description"": ""Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image."",
                ""editType"": ""plot"",
                ""valType"": ""any""
              },
              ""sourceattribution"": {
                ""description"": ""Sets the attribution for this source."",
                ""editType"": ""plot"",
                ""valType"": ""string""
              },
              ""sourcelayer"": {
                ""description"": ""Specifies the layer to use from a vector tile source (mapbox.layer.source-layer). Required for *vector* source type that supports multiple layers."",
                ""dflt"": """",
                ""editType"": ""plot"",
                ""valType"": ""string""
              },
              ""sourcetype"": {
                ""description"": ""Sets the source type for this layer, that is the type of the layer data."",
                ""dflt"": ""geojson"",
                ""editType"": ""plot"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""geojson"",
                  ""vector"",
                  ""raster"",
                  ""image""
                ]
              },
              ""symbol"": {
                ""editType"": ""plot"",
                ""icon"": {
                  ""description"": ""Sets the symbol icon image (mapbox.layer.layout.icon-image). Full list: https://www.mapbox.com/maki-icons/"",
                  ""dflt"": ""marker"",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""iconsize"": {
                  ""description"": ""Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect only when `type` is set to *symbol*."",
                  ""dflt"": 10,
                  ""editType"": ""plot"",
                  ""valType"": ""number""
                },
                ""placement"": {
                  ""description"": ""Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement). If `placement` is *point*, the label is placed where the geometry is located If `placement` is *line*, the label is placed along the line of the geometry If `placement` is *line-center*, the label is placed on the center of the geometry"",
                  ""dflt"": ""point"",
                  ""editType"": ""plot"",
                  ""valType"": ""enumerated"",
                  ""values"": [
                    ""point"",
                    ""line"",
                    ""line-center""
                  ]
                },
                ""role"": ""object"",
                ""text"": {
                  ""description"": ""Sets the symbol text (mapbox.layer.layout.text-field)."",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""textfont"": {
                  ""color"": {
                    ""editType"": ""plot"",
                    ""valType"": ""color""
                  },
                  ""description"": ""Sets the icon text font (color=mapbox.layer.paint.text-color, size=mapbox.layer.layout.text-size). Has an effect only when `type` is set to *symbol*."",
                  ""editType"": ""plot"",
                  ""family"": {
                    ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                    ""dflt"": ""Open Sans Regular, Arial Unicode MS Regular"",
                    ""editType"": ""plot"",
                    ""noBlank"": true,
                    ""strict"": true,
                    ""valType"": ""string""
                  },
                  ""role"": ""object"",
                  ""size"": {
                    ""editType"": ""plot"",
                    ""min"": 1,
                    ""valType"": ""number""
                  }
                },
                ""textposition"": {
                  ""arrayOk"": false,
                  ""description"": ""Sets the positions of the `text` elements with respects to the (x,y) coordinates."",
                  ""dflt"": ""middle center"",
                  ""editType"": ""plot"",
                  ""valType"": ""enumerated"",
                  ""values"": [
                    ""top left"",
                    ""top center"",
                    ""top right"",
                    ""middle left"",
                    ""middle center"",
                    ""middle right"",
                    ""bottom left"",
                    ""bottom center"",
                    ""bottom right""
                  ]
                }
              },
              ""templateitemname"": {
                ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                ""editType"": ""plot"",
                ""valType"": ""string""
              },
              ""type"": {
                ""description"": ""Sets the layer type, that is the how the layer data set in `source` will be rendered With `sourcetype` set to *geojson*, the following values are allowed: *circle*, *line*, *fill* and *symbol*. but note that *line* and *fill* are not compatible with Point GeoJSON geometries. With `sourcetype` set to *vector*, the following values are allowed:  *circle*, *line*, *fill* and *symbol*. With `sourcetype` set to *raster* or `*image*`, only the *raster* value is allowed."",
                ""dflt"": ""circle"",
                ""editType"": ""plot"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""circle"",
                  ""line"",
                  ""fill"",
                  ""symbol"",
                  ""raster""
                ]
              },
              ""visible"": {
                ""description"": ""Determines whether this layer is displayed"",
                ""dflt"": true,
                ""editType"": ""plot"",
                ""valType"": ""boolean""
              }
            }
          },
          ""role"": ""object""
        },
        ""pitch"": {
          ""description"": ""Sets the pitch angle of the map (in degrees, where *0* means perpendicular to the surface of the map) (mapbox.pitch)."",
          ""dflt"": 0,
          ""editType"": ""plot"",
          ""valType"": ""number""
        },
        ""role"": ""object"",
        ""style"": {
          ""description"": ""Defines the map layers that are rendered by default below the trace layers defined in `data`, which are themselves by default rendered below the layers defined in `layout.mapbox.layers`.  These layers can be defined either explicitly as a Mapbox Style object which can contain multiple layer definitions that load data from any public or private Tile Map Service (TMS or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in style objects which use WMSes which do not require any access tokens, or by using a default Mapbox style or custom Mapbox style URL, both of which require a Mapbox access token  Note that Mapbox access token can be set in the `accesstoken` attribute or in the `mapboxAccessToken` config option.  Mapbox Style objects are of the form described in the Mapbox GL JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec  The built-in plotly.js styles objects are: carto-darkmatter, carto-positron, open-street-map, stamen-terrain, stamen-toner, stamen-watercolor, white-bg  The built-in Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets  Mapbox style URLs are of the form: mapbox://mapbox.mapbox-<name>-<version>"",
          ""dflt"": ""basic"",
          ""editType"": ""plot"",
          ""valType"": ""any"",
          ""values"": [
            ""basic"",
            ""streets"",
            ""outdoors"",
            ""light"",
            ""dark"",
            ""satellite"",
            ""satellite-streets"",
            ""carto-darkmatter"",
            ""carto-positron"",
            ""open-street-map"",
            ""stamen-terrain"",
            ""stamen-toner"",
            ""stamen-watercolor"",
            ""white-bg""
          ]
        },
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes in the view: `center`, `zoom`, `bearing`, `pitch`. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        },
        ""zoom"": {
          ""description"": ""Sets the zoom level of the map (mapbox.zoom)."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""valType"": ""number""
        }
      },
      ""margin"": {
        ""autoexpand"": {
          ""description"": ""Turns on/off margin expansion computations. Legends, colorbars, updatemenus, sliders, axis rangeselector and rangeslider are allowed to push the margins by defaults."",
          ""dflt"": true,
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""b"": {
          ""description"": ""Sets the bottom margin (in px)."",
          ""dflt"": 80,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""editType"": ""plot"",
        ""l"": {
          ""description"": ""Sets the left margin (in px)."",
          ""dflt"": 80,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""pad"": {
          ""description"": ""Sets the amount of padding (in px) between the plotting area and the axis lines"",
          ""dflt"": 0,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""r"": {
          ""description"": ""Sets the right margin (in px)."",
          ""dflt"": 80,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""role"": ""object"",
        ""t"": {
          ""description"": ""Sets the top margin (in px)."",
          ""dflt"": 100,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        }
      },
      ""meta"": {
        ""arrayOk"": true,
        ""description"": ""Assigns extra meta information that can be used in various `text` attributes. Attributes such as the graph, axis and colorbar `title.text`, annotation `text` `trace.name` in legend items, `rangeselector`, `updatemenus` and `sliders` `label` text all support `meta`. One can access `meta` fields using template strings: `%{meta[i]}` where `i` is the index of the `meta` item in question. `meta` can also be an object for example `{key: value}` which can be accessed %{meta[key]}."",
        ""editType"": ""plot"",
        ""valType"": ""any""
      },
      ""metasrc"": {
        ""description"": ""Sets the source reference on Chart Studio Cloud for `meta`."",
        ""editType"": ""none"",
        ""valType"": ""string""
      },
      ""modebar"": {
        ""activecolor"": {
          ""description"": ""Sets the color of the active or hovered on icons in the modebar."",
          ""editType"": ""modebar"",
          ""valType"": ""color""
        },
        ""add"": {
          ""arrayOk"": true,
          ""description"": ""Determines which predefined modebar buttons to add. Please note that these buttons will only be shown if they are compatible with all trace types used in a graph. Similar to `config.modeBarButtonsToAdd` option. This may include *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect*, *eraseshape*."",
          ""dflt"": """",
          ""editType"": ""modebar"",
          ""valType"": ""string""
        },
        ""addsrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `add`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""bgcolor"": {
          ""description"": ""Sets the background color of the modebar."",
          ""editType"": ""modebar"",
          ""valType"": ""color""
        },
        ""color"": {
          ""description"": ""Sets the color of the icons in the modebar."",
          ""editType"": ""modebar"",
          ""valType"": ""color""
        },
        ""editType"": ""modebar"",
        ""orientation"": {
          ""description"": ""Sets the orientation of the modebar."",
          ""dflt"": ""h"",
          ""editType"": ""modebar"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""v"",
            ""h""
          ]
        },
        ""remove"": {
          ""arrayOk"": true,
          ""description"": ""Determines which predefined modebar buttons to remove. Similar to `config.modeBarButtonsToRemove` option. This may include *autoScale2d*, *autoscale*, *editInChartStudio*, *editinchartstudio*, *hoverCompareCartesian*, *hovercompare*, *lasso*, *lasso2d*, *orbitRotation*, *orbitrotation*, *pan*, *pan2d*, *pan3d*, *reset*, *resetCameraDefault3d*, *resetCameraLastSave3d*, *resetGeo*, *resetSankeyGroup*, *resetScale2d*, *resetViewMapbox*, *resetViews*, *resetcameradefault*, *resetcameralastsave*, *resetsankeygroup*, *resetscale*, *resetview*, *resetviews*, *select*, *select2d*, *sendDataToCloud*, *senddatatocloud*, *tableRotation*, *tablerotation*, *toImage*, *toggleHover*, *toggleSpikelines*, *togglehover*, *togglespikelines*, *toimage*, *zoom*, *zoom2d*, *zoom3d*, *zoomIn2d*, *zoomInGeo*, *zoomInMapbox*, *zoomOut2d*, *zoomOutGeo*, *zoomOutMapbox*, *zoomin*, *zoomout*."",
          ""dflt"": """",
          ""editType"": ""modebar"",
          ""valType"": ""string""
        },
        ""removesrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `remove`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""role"": ""object"",
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        }
      },
      ""newshape"": {
        ""drawdirection"": {
          ""description"": ""When `dragmode` is set to *drawrect*, *drawline* or *drawcircle* this limits the drag to be horizontal, vertical or diagonal. Using *diagonal* there is no limit e.g. in drawing lines in any direction. *ortho* limits the draw to be either horizontal or vertical. *horizontal* allows horizontal extend. *vertical* allows vertical extend."",
          ""dflt"": ""diagonal"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""ortho"",
            ""horizontal"",
            ""vertical"",
            ""diagonal""
          ]
        },
        ""editType"": ""none"",
        ""fillcolor"": {
          ""description"": ""Sets the color filling new shapes' interior. Please note that if using a fillcolor with alpha greater than half, drag inside the active shape starts moving the shape underneath, otherwise a new shape could be started over."",
          ""dflt"": ""rgba(0,0,0,0)"",
          ""editType"": ""none"",
          ""valType"": ""color""
        },
        ""fillrule"": {
          ""description"": ""Determines the path's interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule"",
          ""dflt"": ""evenodd"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""evenodd"",
            ""nonzero""
          ]
        },
        ""layer"": {
          ""description"": ""Specifies whether new shapes are drawn below or above traces."",
          ""dflt"": ""above"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""below"",
            ""above""
          ]
        },
        ""line"": {
          ""color"": {
            ""description"": ""Sets the line color. By default uses either dark grey or white to increase contrast with background color."",
            ""editType"": ""none"",
            ""valType"": ""color""
          },
          ""dash"": {
            ""description"": ""Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*)."",
            ""dflt"": ""solid"",
            ""editType"": ""none"",
            ""valType"": ""string"",
            ""values"": [
              ""solid"",
              ""dot"",
              ""dash"",
              ""longdash"",
              ""dashdot"",
              ""longdashdot""
            ]
          },
          ""editType"": ""none"",
          ""role"": ""object"",
          ""width"": {
            ""description"": ""Sets the line width (in px)."",
            ""dflt"": 4,
            ""editType"": ""none"",
            ""min"": 0,
            ""valType"": ""number""
          }
        },
        ""opacity"": {
          ""description"": ""Sets the opacity of new shapes."",
          ""dflt"": 1,
          ""editType"": ""none"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""role"": ""object""
      },
      ""paper_bgcolor"": {
        ""description"": ""Sets the background color of the paper where the graph is drawn."",
        ""dflt"": ""#fff"",
        ""editType"": ""plot"",
        ""valType"": ""color""
      },
      ""plot_bgcolor"": {
        ""description"": ""Sets the background color of the plotting area in-between x and y axes."",
        ""dflt"": ""#fff"",
        ""editType"": ""layoutstyle"",
        ""valType"": ""color""
      },
      ""polar"": {
        ""_isSubplotObj"": true,
        ""angularaxis"": {
          ""autotypenumbers"": {
            ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers."",
            ""dflt"": ""convert types"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""convert types"",
              ""strict""
            ]
          },
          ""categoryarray"": {
            ""description"": ""Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`."",
            ""editType"": ""calc"",
            ""valType"": ""data_array""
          },
          ""categoryarraysrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `categoryarray`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""categoryorder"": {
            ""description"": ""Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values."",
            ""dflt"": ""trace"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""trace"",
              ""category ascending"",
              ""category descending"",
              ""array"",
              ""total ascending"",
              ""total descending"",
              ""min ascending"",
              ""min descending"",
              ""max ascending"",
              ""max descending"",
              ""sum ascending"",
              ""sum descending"",
              ""mean ascending"",
              ""mean descending"",
              ""median ascending"",
              ""median descending""
            ]
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""direction"": {
            ""description"": ""Sets the direction corresponding to positive angles."",
            ""dflt"": ""counterclockwise"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""counterclockwise"",
              ""clockwise""
            ]
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""layer"": {
            ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
            ""dflt"": ""above traces"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""above traces"",
              ""below traces""
            ]
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""period"": {
            ""description"": ""Set the angular period. Has an effect only when `angularaxis.type` is *category*."",
            ""editType"": ""calc"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""role"": ""object"",
          ""rotation"": {
            ""description"": ""Sets that start position (in degrees) of the angular axis By default, polar subplots with `direction` set to *counterclockwise* get a `rotation` of *0* which corresponds to due East (like what mathematicians prefer). In turn, polar with `direction` set to *clockwise* get a rotation of *90* which corresponds to due North (like on a compass),"",
            ""editType"": ""calc"",
            ""valType"": ""angle""
          },
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""thetaunit"": {
            ""description"": ""Sets the format unit of the formatted *theta* values. Has an effect only when `angularaxis.type` is *linear*."",
            ""dflt"": ""degrees"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""radians"",
              ""degrees""
            ]
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklabelstep"": {
            ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""type"": {
            ""_noTemplating"": true,
            ""description"": ""Sets the angular axis type. If *linear*, set `thetaunit` to determine the unit in which axis value are shown. If *category, use `period` to set the number of integer coordinates around polar axis."",
            ""dflt"": ""-"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""-"",
              ""linear"",
              ""category""
            ]
          },
          ""uirevision"": {
            ""description"": ""Controls persistence of user-driven changes in axis `rotation`. Defaults to `polar<N>.uirevision`."",
            ""editType"": ""none"",
            ""valType"": ""any""
          },
          ""visible"": {
            ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          }
        },
        ""bgcolor"": {
          ""description"": ""Set the background color of the subplot"",
          ""dflt"": ""#fff"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""domain"": {
          ""column"": {
            ""description"": ""If there is a layout grid, use the domain for this column in the grid for this polar subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""editType"": ""plot"",
          ""role"": ""object"",
          ""row"": {
            ""description"": ""If there is a layout grid, use the domain for this row in the grid for this polar subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""x"": {
            ""description"": ""Sets the horizontal domain of this polar subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""y"": {
            ""description"": ""Sets the vertical domain of this polar subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          }
        },
        ""editType"": ""calc"",
        ""gridshape"": {
          ""description"": ""Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale)."",
          ""dflt"": ""circular"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""circular"",
            ""linear""
          ]
        },
        ""hole"": {
          ""description"": ""Sets the fraction of the radius to cut out of the polar subplot."",
          ""dflt"": 0,
          ""editType"": ""plot"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""radialaxis"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
              ""editType"": ""ticks"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""ticks"",
                ""valType"": ""color""
              },
              ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
              ""editType"": ""ticks"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""ticks"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""ticks"",
                ""min"": 1,
                ""valType"": ""number""
              }
            }
          },
          ""angle"": {
            ""description"": ""Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle."",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""autorange"": {
            ""description"": ""Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              true,
              false,
              ""reversed""
            ]
          },
          ""autotypenumbers"": {
            ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers."",
            ""dflt"": ""convert types"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""convert types"",
              ""strict""
            ]
          },
          ""calendar"": {
            ""description"": ""Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`"",
            ""dflt"": ""gregorian"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""chinese"",
              ""coptic"",
              ""discworld"",
              ""ethiopian"",
              ""gregorian"",
              ""hebrew"",
              ""islamic"",
              ""jalali"",
              ""julian"",
              ""mayan"",
              ""nanakshahi"",
              ""nepali"",
              ""persian"",
              ""taiwan"",
              ""thai"",
              ""ummalqura""
            ]
          },
          ""categoryarray"": {
            ""description"": ""Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`."",
            ""editType"": ""calc"",
            ""valType"": ""data_array""
          },
          ""categoryarraysrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `categoryarray`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""categoryorder"": {
            ""description"": ""Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values."",
            ""dflt"": ""trace"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""trace"",
              ""category ascending"",
              ""category descending"",
              ""array"",
              ""total ascending"",
              ""total descending"",
              ""min ascending"",
              ""min descending"",
              ""max ascending"",
              ""max descending"",
              ""sum ascending"",
              ""sum descending"",
              ""mean ascending"",
              ""mean descending"",
              ""median ascending"",
              ""median descending""
            ]
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""layer"": {
            ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
            ""dflt"": ""above traces"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""above traces"",
              ""below traces""
            ]
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""range"": {
            ""anim"": true,
            ""description"": ""Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""autorange"": false
            },
            ""items"": [
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              },
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              }
            ],
            ""valType"": ""info_array""
          },
          ""rangemode"": {
            ""description"": ""If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes)."",
            ""dflt"": ""tozero"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""tozero"",
              ""nonnegative"",
              ""normal""
            ]
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""side"": {
            ""description"": ""Determines on which side of radial axis line the tick and tick labels appear."",
            ""dflt"": ""clockwise"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""clockwise"",
              ""counterclockwise""
            ]
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklabelstep"": {
            ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""plot"",
            ""font"": {
              ""color"": {
                ""editType"": ""ticks"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""ticks"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""ticks"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""text"": {
              ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""dflt"": """",
              ""editType"": ""plot"",
              ""valType"": ""string""
            }
          },
          ""type"": {
            ""_noTemplating"": true,
            ""description"": ""Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question."",
            ""dflt"": ""-"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""-"",
              ""linear"",
              ""log"",
              ""date"",
              ""category""
            ]
          },
          ""uirevision"": {
            ""description"": ""Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`."",
            ""editType"": ""none"",
            ""valType"": ""any""
          },
          ""visible"": {
            ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          }
        },
        ""role"": ""object"",
        ""sector"": {
          ""description"": ""Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot."",
          ""dflt"": [
            0,
            360
          ],
          ""editType"": ""plot"",
          ""items"": [
            {
              ""editType"": ""plot"",
              ""valType"": ""number""
            },
            {
              ""editType"": ""plot"",
              ""valType"": ""number""
            }
          ],
          ""valType"": ""info_array""
        },
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        }
      },
      ""scene"": {
        ""_arrayAttrRegexps"": [
          {}
        ],
        ""_deprecated"": {
          ""cameraposition"": {
            ""description"": ""Obsolete. Use `camera` instead."",
            ""editType"": ""camera"",
            ""valType"": ""info_array""
          }
        },
        ""_isSubplotObj"": true,
        ""annotations"": {
          ""items"": {
            ""annotation"": {
              ""align"": {
                ""description"": ""Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width."",
                ""dflt"": ""center"",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""left"",
                  ""center"",
                  ""right""
                ]
              },
              ""arrowcolor"": {
                ""description"": ""Sets the color of the annotation arrow."",
                ""editType"": ""calc"",
                ""valType"": ""color""
              },
              ""arrowhead"": {
                ""description"": ""Sets the end annotation arrow head style."",
                ""dflt"": 1,
                ""editType"": ""calc"",
                ""max"": 8,
                ""min"": 0,
                ""valType"": ""integer""
              },
              ""arrowside"": {
                ""description"": ""Sets the annotation arrow head position."",
                ""dflt"": ""end"",
                ""editType"": ""calc"",
                ""extras"": [
                  ""none""
                ],
                ""flags"": [
                  ""end"",
                  ""start""
                ],
                ""valType"": ""flaglist""
              },
              ""arrowsize"": {
                ""description"": ""Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line."",
                ""dflt"": 1,
                ""editType"": ""calc"",
                ""min"": 0.3,
                ""valType"": ""number""
              },
              ""arrowwidth"": {
                ""description"": ""Sets the width (in px) of annotation arrow line."",
                ""editType"": ""calc"",
                ""min"": 0.1,
                ""valType"": ""number""
              },
              ""ax"": {
                ""description"": ""Sets the x component of the arrow tail about the arrow head (in pixels)."",
                ""editType"": ""calc"",
                ""valType"": ""number""
              },
              ""ay"": {
                ""description"": ""Sets the y component of the arrow tail about the arrow head (in pixels)."",
                ""editType"": ""calc"",
                ""valType"": ""number""
              },
              ""bgcolor"": {
                ""description"": ""Sets the background color of the annotation."",
                ""dflt"": ""rgba(0,0,0,0)"",
                ""editType"": ""calc"",
                ""valType"": ""color""
              },
              ""bordercolor"": {
                ""description"": ""Sets the color of the border enclosing the annotation `text`."",
                ""dflt"": ""rgba(0,0,0,0)"",
                ""editType"": ""calc"",
                ""valType"": ""color""
              },
              ""borderpad"": {
                ""description"": ""Sets the padding (in px) between the `text` and the enclosing border."",
                ""dflt"": 1,
                ""editType"": ""calc"",
                ""min"": 0,
                ""valType"": ""number""
              },
              ""borderwidth"": {
                ""description"": ""Sets the width (in px) of the border enclosing the annotation `text`."",
                ""dflt"": 1,
                ""editType"": ""calc"",
                ""min"": 0,
                ""valType"": ""number""
              },
              ""captureevents"": {
                ""description"": ""Determines whether the annotation text box captures mouse move and click events, or allows those events to pass through to data points in the plot that may be behind the annotation. By default `captureevents` is *false* unless `hovertext` is provided. If you use the event `plotly_clickannotation` without `hovertext` you must explicitly enable `captureevents`."",
                ""editType"": ""calc"",
                ""valType"": ""boolean""
              },
              ""editType"": ""calc"",
              ""font"": {
                ""color"": {
                  ""editType"": ""calc"",
                  ""valType"": ""color""
                },
                ""description"": ""Sets the annotation text font."",
                ""editType"": ""calc"",
                ""family"": {
                  ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                  ""editType"": ""calc"",
                  ""noBlank"": true,
                  ""strict"": true,
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""size"": {
                  ""editType"": ""calc"",
                  ""min"": 1,
                  ""valType"": ""number""
                }
              },
              ""height"": {
                ""description"": ""Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped."",
                ""dflt"": null,
                ""editType"": ""calc"",
                ""min"": 1,
                ""valType"": ""number""
              },
              ""hoverlabel"": {
                ""bgcolor"": {
                  ""description"": ""Sets the background color of the hover label. By default uses the annotation's `bgcolor` made opaque, or white if it was transparent."",
                  ""editType"": ""calc"",
                  ""valType"": ""color""
                },
                ""bordercolor"": {
                  ""description"": ""Sets the border color of the hover label. By default uses either dark grey or white, for maximum contrast with `hoverlabel.bgcolor`."",
                  ""editType"": ""calc"",
                  ""valType"": ""color""
                },
                ""editType"": ""calc"",
                ""font"": {
                  ""color"": {
                    ""editType"": ""calc"",
                    ""valType"": ""color""
                  },
                  ""description"": ""Sets the hover label text font. By default uses the global hover font and size, with color from `hoverlabel.bordercolor`."",
                  ""editType"": ""calc"",
                  ""family"": {
                    ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                    ""editType"": ""calc"",
                    ""noBlank"": true,
                    ""strict"": true,
                    ""valType"": ""string""
                  },
                  ""role"": ""object"",
                  ""size"": {
                    ""editType"": ""calc"",
                    ""min"": 1,
                    ""valType"": ""number""
                  }
                },
                ""role"": ""object""
              },
              ""hovertext"": {
                ""description"": ""Sets text to appear when hovering over this annotation. If omitted or blank, no hover label will appear."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""name"": {
                ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""opacity"": {
                ""description"": ""Sets the opacity of the annotation (text + arrow)."",
                ""dflt"": 1,
                ""editType"": ""calc"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              ""role"": ""object"",
              ""showarrow"": {
                ""description"": ""Determines whether or not the annotation is drawn with an arrow. If *true*, `text` is placed near the arrow's tail. If *false*, `text` lines up with the `x` and `y` provided."",
                ""dflt"": true,
                ""editType"": ""calc"",
                ""valType"": ""boolean""
              },
              ""standoff"": {
                ""description"": ""Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount."",
                ""dflt"": 0,
                ""editType"": ""calc"",
                ""min"": 0,
                ""valType"": ""number""
              },
              ""startarrowhead"": {
                ""description"": ""Sets the start annotation arrow head style."",
                ""dflt"": 1,
                ""editType"": ""calc"",
                ""max"": 8,
                ""min"": 0,
                ""valType"": ""integer""
              },
              ""startarrowsize"": {
                ""description"": ""Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line."",
                ""dflt"": 1,
                ""editType"": ""calc"",
                ""min"": 0.3,
                ""valType"": ""number""
              },
              ""startstandoff"": {
                ""description"": ""Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount."",
                ""dflt"": 0,
                ""editType"": ""calc"",
                ""min"": 0,
                ""valType"": ""number""
              },
              ""templateitemname"": {
                ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""text"": {
                ""description"": ""Sets the text associated with this annotation. Plotly uses a subset of HTML tags to do things like newline (<br>), bold (<b></b>), italics (<i></i>), hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub> <span> are also supported."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""textangle"": {
                ""description"": ""Sets the angle at which the `text` is drawn with respect to the horizontal."",
                ""dflt"": 0,
                ""editType"": ""calc"",
                ""valType"": ""angle""
              },
              ""valign"": {
                ""description"": ""Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height."",
                ""dflt"": ""middle"",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""top"",
                  ""middle"",
                  ""bottom""
                ]
              },
              ""visible"": {
                ""description"": ""Determines whether or not this annotation is visible."",
                ""dflt"": true,
                ""editType"": ""calc"",
                ""valType"": ""boolean""
              },
              ""width"": {
                ""description"": ""Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line."",
                ""dflt"": null,
                ""editType"": ""calc"",
                ""min"": 1,
                ""valType"": ""number""
              },
              ""x"": {
                ""description"": ""Sets the annotation's x position."",
                ""editType"": ""calc"",
                ""valType"": ""any""
              },
              ""xanchor"": {
                ""description"": ""Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side."",
                ""dflt"": ""auto"",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""auto"",
                  ""left"",
                  ""center"",
                  ""right""
                ]
              },
              ""xshift"": {
                ""description"": ""Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels."",
                ""dflt"": 0,
                ""editType"": ""calc"",
                ""valType"": ""number""
              },
              ""y"": {
                ""description"": ""Sets the annotation's y position."",
                ""editType"": ""calc"",
                ""valType"": ""any""
              },
              ""yanchor"": {
                ""description"": ""Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side."",
                ""dflt"": ""auto"",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""auto"",
                  ""top"",
                  ""middle"",
                  ""bottom""
                ]
              },
              ""yshift"": {
                ""description"": ""Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels."",
                ""dflt"": 0,
                ""editType"": ""calc"",
                ""valType"": ""number""
              },
              ""z"": {
                ""description"": ""Sets the annotation's z position."",
                ""editType"": ""calc"",
                ""valType"": ""any""
              }
            }
          },
          ""role"": ""object""
        },
        ""aspectmode"": {
          ""description"": ""If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used."",
          ""dflt"": ""auto"",
          ""editType"": ""plot"",
          ""impliedEdits"": {},
          ""valType"": ""enumerated"",
          ""values"": [
            ""auto"",
            ""cube"",
            ""data"",
            ""manual""
          ]
        },
        ""aspectratio"": {
          ""description"": ""Sets this scene's axis aspectratio."",
          ""editType"": ""plot"",
          ""impliedEdits"": {
            ""aspectmode"": ""manual"",
            ""role"": ""object""
          },
          ""role"": ""object"",
          ""x"": {
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""^aspectmode"": ""manual""
            },
            ""min"": 0,
            ""valType"": ""number""
          },
          ""y"": {
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""^aspectmode"": ""manual""
            },
            ""min"": 0,
            ""valType"": ""number""
          },
          ""z"": {
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""^aspectmode"": ""manual""
            },
            ""min"": 0,
            ""valType"": ""number""
          }
        },
        ""bgcolor"": {
          ""dflt"": ""rgba(0,0,0,0)"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""camera"": {
          ""center"": {
            ""description"": ""Sets the (x,y,z) components of the 'center' camera vector This vector determines the translation (x,y,z) space about the center of this scene. By default, there is no such translation."",
            ""editType"": ""camera"",
            ""role"": ""object"",
            ""x"": {
              ""dflt"": 0,
              ""editType"": ""camera"",
              ""valType"": ""number""
            },
            ""y"": {
              ""dflt"": 0,
              ""editType"": ""camera"",
              ""valType"": ""number""
            },
            ""z"": {
              ""dflt"": 0,
              ""editType"": ""camera"",
              ""valType"": ""number""
            }
          },
          ""editType"": ""camera"",
          ""eye"": {
            ""description"": ""Sets the (x,y,z) components of the 'eye' camera vector. This vector determines the view point about the origin of this scene."",
            ""editType"": ""camera"",
            ""role"": ""object"",
            ""x"": {
              ""dflt"": 1.25,
              ""editType"": ""camera"",
              ""valType"": ""number""
            },
            ""y"": {
              ""dflt"": 1.25,
              ""editType"": ""camera"",
              ""valType"": ""number""
            },
            ""z"": {
              ""dflt"": 1.25,
              ""editType"": ""camera"",
              ""valType"": ""number""
            }
          },
          ""projection"": {
            ""editType"": ""calc"",
            ""role"": ""object"",
            ""type"": {
              ""description"": ""Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*."",
              ""dflt"": ""perspective"",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""perspective"",
                ""orthographic""
              ]
            }
          },
          ""role"": ""object"",
          ""up"": {
            ""description"": ""Sets the (x,y,z) components of the 'up' camera vector. This vector determines the up direction of this scene with respect to the page. The default is *{x: 0, y: 0, z: 1}* which means that the z axis points up."",
            ""editType"": ""camera"",
            ""role"": ""object"",
            ""x"": {
              ""dflt"": 0,
              ""editType"": ""camera"",
              ""valType"": ""number""
            },
            ""y"": {
              ""dflt"": 0,
              ""editType"": ""camera"",
              ""valType"": ""number""
            },
            ""z"": {
              ""dflt"": 1,
              ""editType"": ""camera"",
              ""valType"": ""number""
            }
          }
        },
        ""domain"": {
          ""column"": {
            ""description"": ""If there is a layout grid, use the domain for this column in the grid for this scene subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""editType"": ""plot"",
          ""role"": ""object"",
          ""row"": {
            ""description"": ""If there is a layout grid, use the domain for this row in the grid for this scene subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""x"": {
            ""description"": ""Sets the horizontal domain of this scene subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""y"": {
            ""description"": ""Sets the vertical domain of this scene subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          }
        },
        ""dragmode"": {
          ""description"": ""Determines the mode of drag interactions for this scene."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""orbit"",
            ""turntable"",
            ""zoom"",
            ""pan"",
            false
          ]
        },
        ""editType"": ""plot"",
        ""hovermode"": {
          ""description"": ""Determines the mode of hover interactions for this scene."",
          ""dflt"": ""closest"",
          ""editType"": ""modebar"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""closest"",
            false
          ]
        },
        ""role"": ""object"",
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        },
        ""xaxis"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            }
          },
          ""autorange"": {
            ""description"": ""Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              true,
              false,
              ""reversed""
            ]
          },
          ""autotypenumbers"": {
            ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers."",
            ""dflt"": ""convert types"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""convert types"",
              ""strict""
            ]
          },
          ""backgroundcolor"": {
            ""description"": ""Sets the background color of this axis' wall."",
            ""dflt"": ""rgba(204, 204, 204, 0.5)"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""calendar"": {
            ""description"": ""Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`"",
            ""dflt"": ""gregorian"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""chinese"",
              ""coptic"",
              ""discworld"",
              ""ethiopian"",
              ""gregorian"",
              ""hebrew"",
              ""islamic"",
              ""jalali"",
              ""julian"",
              ""mayan"",
              ""nanakshahi"",
              ""nepali"",
              ""persian"",
              ""taiwan"",
              ""thai"",
              ""ummalqura""
            ]
          },
          ""categoryarray"": {
            ""description"": ""Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""categoryarraysrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `categoryarray`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""categoryorder"": {
            ""description"": ""Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values."",
            ""dflt"": ""trace"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""trace"",
              ""category ascending"",
              ""category descending"",
              ""array"",
              ""total ascending"",
              ""total descending"",
              ""min ascending"",
              ""min descending"",
              ""max ascending"",
              ""max descending"",
              ""sum ascending"",
              ""sum descending"",
              ""mean ascending"",
              ""mean descending"",
              ""median ascending"",
              ""median descending""
            ]
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""rgb(204, 204, 204)"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""mirror"": {
            ""description"": ""Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              true,
              ""ticks"",
              false,
              ""all"",
              ""allticks""
            ]
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""range"": {
            ""anim"": false,
            ""description"": ""Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""autorange"": false
            },
            ""items"": [
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              },
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              }
            ],
            ""valType"": ""info_array""
          },
          ""rangemode"": {
            ""description"": ""If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes."",
            ""dflt"": ""normal"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""normal"",
              ""tozero"",
              ""nonnegative""
            ]
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showaxeslabels"": {
            ""description"": ""Sets whether or not this axis is labeled"",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showbackground"": {
            ""description"": ""Sets whether or not this axis' wall has a background color."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showspikes"": {
            ""description"": ""Sets whether or not spikes starting from data points to this axis' wall are shown on hover."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""spikecolor"": {
            ""description"": ""Sets the color of the spikes."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""spikesides"": {
            ""description"": ""Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""spikethickness"": {
            ""description"": ""Sets the thickness (in px) of the spikes."",
            ""dflt"": 2,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""plot"",
            ""font"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""text"": {
              ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            }
          },
          ""type"": {
            ""_noTemplating"": true,
            ""description"": ""Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question."",
            ""dflt"": ""-"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""-"",
              ""linear"",
              ""log"",
              ""date"",
              ""category""
            ]
          },
          ""visible"": {
            ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""zeroline"": {
            ""description"": ""Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines."",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""zerolinecolor"": {
            ""description"": ""Sets the line color of the zero line."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""zerolinewidth"": {
            ""description"": ""Sets the width (in px) of the zero line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""valType"": ""number""
          }
        },
        ""yaxis"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            }
          },
          ""autorange"": {
            ""description"": ""Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              true,
              false,
              ""reversed""
            ]
          },
          ""autotypenumbers"": {
            ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers."",
            ""dflt"": ""convert types"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""convert types"",
              ""strict""
            ]
          },
          ""backgroundcolor"": {
            ""description"": ""Sets the background color of this axis' wall."",
            ""dflt"": ""rgba(204, 204, 204, 0.5)"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""calendar"": {
            ""description"": ""Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`"",
            ""dflt"": ""gregorian"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""chinese"",
              ""coptic"",
              ""discworld"",
              ""ethiopian"",
              ""gregorian"",
              ""hebrew"",
              ""islamic"",
              ""jalali"",
              ""julian"",
              ""mayan"",
              ""nanakshahi"",
              ""nepali"",
              ""persian"",
              ""taiwan"",
              ""thai"",
              ""ummalqura""
            ]
          },
          ""categoryarray"": {
            ""description"": ""Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""categoryarraysrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `categoryarray`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""categoryorder"": {
            ""description"": ""Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values."",
            ""dflt"": ""trace"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""trace"",
              ""category ascending"",
              ""category descending"",
              ""array"",
              ""total ascending"",
              ""total descending"",
              ""min ascending"",
              ""min descending"",
              ""max ascending"",
              ""max descending"",
              ""sum ascending"",
              ""sum descending"",
              ""mean ascending"",
              ""mean descending"",
              ""median ascending"",
              ""median descending""
            ]
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""rgb(204, 204, 204)"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""mirror"": {
            ""description"": ""Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              true,
              ""ticks"",
              false,
              ""all"",
              ""allticks""
            ]
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""range"": {
            ""anim"": false,
            ""description"": ""Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""autorange"": false
            },
            ""items"": [
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              },
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              }
            ],
            ""valType"": ""info_array""
          },
          ""rangemode"": {
            ""description"": ""If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes."",
            ""dflt"": ""normal"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""normal"",
              ""tozero"",
              ""nonnegative""
            ]
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showaxeslabels"": {
            ""description"": ""Sets whether or not this axis is labeled"",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showbackground"": {
            ""description"": ""Sets whether or not this axis' wall has a background color."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showspikes"": {
            ""description"": ""Sets whether or not spikes starting from data points to this axis' wall are shown on hover."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""spikecolor"": {
            ""description"": ""Sets the color of the spikes."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""spikesides"": {
            ""description"": ""Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""spikethickness"": {
            ""description"": ""Sets the thickness (in px) of the spikes."",
            ""dflt"": 2,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""plot"",
            ""font"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""text"": {
              ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            }
          },
          ""type"": {
            ""_noTemplating"": true,
            ""description"": ""Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question."",
            ""dflt"": ""-"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""-"",
              ""linear"",
              ""log"",
              ""date"",
              ""category""
            ]
          },
          ""visible"": {
            ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""zeroline"": {
            ""description"": ""Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines."",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""zerolinecolor"": {
            ""description"": ""Sets the line color of the zero line."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""zerolinewidth"": {
            ""description"": ""Sets the width (in px) of the zero line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""valType"": ""number""
          }
        },
        ""zaxis"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            }
          },
          ""autorange"": {
            ""description"": ""Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              true,
              false,
              ""reversed""
            ]
          },
          ""autotypenumbers"": {
            ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers."",
            ""dflt"": ""convert types"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""convert types"",
              ""strict""
            ]
          },
          ""backgroundcolor"": {
            ""description"": ""Sets the background color of this axis' wall."",
            ""dflt"": ""rgba(204, 204, 204, 0.5)"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""calendar"": {
            ""description"": ""Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`"",
            ""dflt"": ""gregorian"",
            ""editType"": ""calc"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""chinese"",
              ""coptic"",
              ""discworld"",
              ""ethiopian"",
              ""gregorian"",
              ""hebrew"",
              ""islamic"",
              ""jalali"",
              ""julian"",
              ""mayan"",
              ""nanakshahi"",
              ""nepali"",
              ""persian"",
              ""taiwan"",
              ""thai"",
              ""ummalqura""
            ]
          },
          ""categoryarray"": {
            ""description"": ""Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""categoryarraysrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `categoryarray`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""categoryorder"": {
            ""description"": ""Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values."",
            ""dflt"": ""trace"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""trace"",
              ""category ascending"",
              ""category descending"",
              ""array"",
              ""total ascending"",
              ""total descending"",
              ""min ascending"",
              ""min descending"",
              ""max ascending"",
              ""max descending"",
              ""sum ascending"",
              ""sum descending"",
              ""mean ascending"",
              ""mean descending"",
              ""median ascending"",
              ""median descending""
            ]
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""rgb(204, 204, 204)"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""mirror"": {
            ""description"": ""Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              true,
              ""ticks"",
              false,
              ""all"",
              ""allticks""
            ]
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""range"": {
            ""anim"": false,
            ""description"": ""Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""autorange"": false
            },
            ""items"": [
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              },
              {
                ""editType"": ""plot"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              }
            ],
            ""valType"": ""info_array""
          },
          ""rangemode"": {
            ""description"": ""If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes."",
            ""dflt"": ""normal"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""normal"",
              ""tozero"",
              ""nonnegative""
            ]
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showaxeslabels"": {
            ""description"": ""Sets whether or not this axis is labeled"",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showbackground"": {
            ""description"": ""Sets whether or not this axis' wall has a background color."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showspikes"": {
            ""description"": ""Sets whether or not spikes starting from data points to this axis' wall are shown on hover."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""spikecolor"": {
            ""description"": ""Sets the color of the spikes."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""spikesides"": {
            ""description"": ""Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""spikethickness"": {
            ""description"": ""Sets the thickness (in px) of the spikes."",
            ""dflt"": 2,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""plot"",
            ""font"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""text"": {
              ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            }
          },
          ""type"": {
            ""_noTemplating"": true,
            ""description"": ""Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question."",
            ""dflt"": ""-"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""-"",
              ""linear"",
              ""log"",
              ""date"",
              ""category""
            ]
          },
          ""visible"": {
            ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""zeroline"": {
            ""description"": ""Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines."",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""zerolinecolor"": {
            ""description"": ""Sets the line color of the zero line."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""zerolinewidth"": {
            ""description"": ""Sets the width (in px) of the zero line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""valType"": ""number""
          }
        }
      },
      ""selectdirection"": {
        ""description"": ""When `dragmode` is set to *select*, this limits the selection of the drag to horizontal, vertical or diagonal. *h* only allows horizontal selection, *v* only vertical, *d* only diagonal and *any* sets no limit."",
        ""dflt"": ""any"",
        ""editType"": ""none"",
        ""valType"": ""enumerated"",
        ""values"": [
          ""h"",
          ""v"",
          ""d"",
          ""any""
        ]
      },
      ""selectionrevision"": {
        ""description"": ""Controls persistence of user-driven changes in selected points from all traces."",
        ""editType"": ""none"",
        ""valType"": ""any""
      },
      ""separators"": {
        ""description"": ""Sets the decimal and thousand separators. For example, *. * puts a '.' before decimals and a space between thousands. In English locales, dflt is *.,* but other locales may alter this default."",
        ""editType"": ""plot"",
        ""valType"": ""string""
      },
      ""shapes"": {
        ""items"": {
          ""shape"": {
            ""editable"": {
              ""description"": ""Determines whether the shape could be activated for edit or not. Has no effect when the older editable shapes mode is enabled via `config.editable` or `config.edits.shapePosition`."",
              ""dflt"": false,
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""boolean""
            },
            ""editType"": ""arraydraw"",
            ""fillcolor"": {
              ""description"": ""Sets the color filling the shape's interior. Only applies to closed shapes."",
              ""dflt"": ""rgba(0,0,0,0)"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""fillrule"": {
              ""description"": ""Determines which regions of complex paths constitute the interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule"",
              ""dflt"": ""evenodd"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""evenodd"",
                ""nonzero""
              ]
            },
            ""layer"": {
              ""description"": ""Specifies whether shapes are drawn below or above traces."",
              ""dflt"": ""above"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""below"",
                ""above""
              ]
            },
            ""line"": {
              ""color"": {
                ""anim"": true,
                ""description"": ""Sets the line color."",
                ""editType"": ""arraydraw"",
                ""valType"": ""color""
              },
              ""dash"": {
                ""description"": ""Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*)."",
                ""dflt"": ""solid"",
                ""editType"": ""arraydraw"",
                ""valType"": ""string"",
                ""values"": [
                  ""solid"",
                  ""dot"",
                  ""dash"",
                  ""longdash"",
                  ""dashdot"",
                  ""longdashdot""
                ]
              },
              ""editType"": ""calc+arraydraw"",
              ""role"": ""object"",
              ""width"": {
                ""anim"": true,
                ""description"": ""Sets the line width (in px)."",
                ""dflt"": 2,
                ""editType"": ""calc+arraydraw"",
                ""min"": 0,
                ""valType"": ""number""
              }
            },
            ""name"": {
              ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
              ""editType"": ""none"",
              ""valType"": ""string""
            },
            ""opacity"": {
              ""description"": ""Sets the opacity of the shape."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""max"": 1,
              ""min"": 0,
              ""valType"": ""number""
            },
            ""path"": {
              ""description"": ""For `type` *path* - a valid SVG path with the pixel values replaced by data values in `xsizemode`/`ysizemode` being *scaled* and taken unmodified as pixels relative to `xanchor` and `yanchor` in case of *pixel* size mode. There are a few restrictions / quirks only absolute instructions, not relative. So the allowed segments are: M, L, H, V, Q, C, T, S, and Z arcs (A) are not allowed because radius rx and ry are relative. In the future we could consider supporting relative commands, but we would have to decide on how to handle date and log axes. Note that even as is, Q and C Bezier paths that are smooth on linear axes may not be smooth on log, and vice versa. no chained \""polybezier\"" commands - specify the segment type for each one. On category axes, values are numbers scaled to the serial numbers of categories because using the categories themselves there would be no way to describe fractional positions On data axes: because space and T are both normal components of path strings, we can't use either to separate date from time parts. Therefore we'll use underscore for this purpose: 2015-02-21_13:45:56.789"",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""templateitemname"": {
              ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
              ""editType"": ""calc"",
              ""valType"": ""string""
            },
            ""type"": {
              ""description"": ""Specifies the shape type to be drawn. If *line*, a line is drawn from (`x0`,`y0`) to (`x1`,`y1`) with respect to the axes' sizing mode. If *circle*, a circle is drawn from ((`x0`+`x1`)/2, (`y0`+`y1`)/2)) with radius (|(`x0`+`x1`)/2 - `x0`|, |(`y0`+`y1`)/2 -`y0`)|) with respect to the axes' sizing mode. If *rect*, a rectangle is drawn linking (`x0`,`y0`), (`x1`,`y0`), (`x1`,`y1`), (`x0`,`y1`), (`x0`,`y0`) with respect to the axes' sizing mode. If *path*, draw a custom SVG path using `path`. with respect to the axes' sizing mode."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""circle"",
                ""rect"",
                ""path"",
                ""line""
              ]
            },
            ""visible"": {
              ""description"": ""Determines whether or not this shape is visible."",
              ""dflt"": true,
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""boolean""
            },
            ""x0"": {
              ""description"": ""Sets the shape's starting x position. See `type` and `xsizemode` for more info."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""x1"": {
              ""description"": ""Sets the shape's end x position. See `type` and `xsizemode` for more info."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""xanchor"": {
              ""description"": ""Only relevant in conjunction with `xsizemode` set to *pixel*. Specifies the anchor point on the x axis to which `x0`, `x1` and x coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `xsizemode` not set to *pixel*."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""xref"": {
              ""description"": ""Sets the shape's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to a x coordinate. If set to *paper*, the `x` position refers to the distance from the left of the plotting area in normalized coordinates where *0* (*1*) corresponds to the left (right). If set to a x axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the left of the domain of that axis: e.g., *x2 domain* refers to the domain of the second x  axis and a x position of 0.5 refers to the point between the left and the right of the domain of the second x axis. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, then you must convert the date to unix time in milliseconds."",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""paper"",
                ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            },
            ""xsizemode"": {
              ""description"": ""Sets the shapes's sizing mode along the x axis. If set to *scaled*, `x0`, `x1` and x coordinates within `path` refer to data values on the x axis or a fraction of the plot area's width (`xref` set to *paper*). If set to *pixel*, `xanchor` specifies the x position in terms of data or plot fraction but `x0`, `x1` and x coordinates within `path` are pixels relative to `xanchor`. This way, the shape can have a fixed width while maintaining a position relative to data or plot fraction."",
              ""dflt"": ""scaled"",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""scaled"",
                ""pixel""
              ]
            },
            ""y0"": {
              ""description"": ""Sets the shape's starting y position. See `type` and `ysizemode` for more info."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""y1"": {
              ""description"": ""Sets the shape's end y position. See `type` and `ysizemode` for more info."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""yanchor"": {
              ""description"": ""Only relevant in conjunction with `ysizemode` set to *pixel*. Specifies the anchor point on the y axis to which `y0`, `y1` and y coordinates within `path` are relative to. E.g. useful to attach a pixel sized shape to a certain data value. No effect when `ysizemode` not set to *pixel*."",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""any""
            },
            ""yref"": {
              ""description"": ""Sets the annotation's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where *0* (*1*) corresponds to the bottom (top). If set to a y axis ID followed by *domain* (separated by a space), the position behaves like for *paper*, but refers to the distance in fractions of the domain length from the bottom of the domain of that axis: e.g., *y2 domain* refers to the domain of the second y  axis and a y position of 0.5 refers to the point between the bottom and the top of the domain of the second y axis."",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""paper"",
                ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
              ]
            },
            ""ysizemode"": {
              ""description"": ""Sets the shapes's sizing mode along the y axis. If set to *scaled*, `y0`, `y1` and y coordinates within `path` refer to data values on the y axis or a fraction of the plot area's height (`yref` set to *paper*). If set to *pixel*, `yanchor` specifies the y position in terms of data or plot fraction but `y0`, `y1` and y coordinates within `path` are pixels relative to `yanchor`. This way, the shape can have a fixed height while maintaining a position relative to data or plot fraction."",
              ""dflt"": ""scaled"",
              ""editType"": ""calc+arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""scaled"",
                ""pixel""
              ]
            }
          }
        },
        ""role"": ""object""
      },
      ""showlegend"": {
        ""description"": ""Determines whether or not a legend is drawn. Default is `true` if there is a trace to show and any of these: a) Two or more traces would by default be shown in the legend. b) One pie trace is shown in the legend. c) One trace is explicitly given with `showlegend: true`."",
        ""editType"": ""legend"",
        ""valType"": ""boolean""
      },
      ""sliders"": {
        ""items"": {
          ""slider"": {
            ""active"": {
              ""description"": ""Determines which button (by index starting from 0) is considered active."",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""activebgcolor"": {
              ""description"": ""Sets the background color of the slider grip while dragging."",
              ""dflt"": ""#dbdde0"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""bgcolor"": {
              ""description"": ""Sets the background color of the slider."",
              ""dflt"": ""#f8fafc"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""bordercolor"": {
              ""description"": ""Sets the color of the border enclosing the slider."",
              ""dflt"": ""#bec8d9"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""borderwidth"": {
              ""description"": ""Sets the width (in px) of the border enclosing the slider."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""currentvalue"": {
              ""editType"": ""arraydraw"",
              ""font"": {
                ""color"": {
                  ""editType"": ""arraydraw"",
                  ""valType"": ""color""
                },
                ""description"": ""Sets the font of the current value label text."",
                ""editType"": ""arraydraw"",
                ""family"": {
                  ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                  ""editType"": ""arraydraw"",
                  ""noBlank"": true,
                  ""strict"": true,
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""size"": {
                  ""editType"": ""arraydraw"",
                  ""min"": 1,
                  ""valType"": ""number""
                }
              },
              ""offset"": {
                ""description"": ""The amount of space, in pixels, between the current value label and the slider."",
                ""dflt"": 10,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              },
              ""prefix"": {
                ""description"": ""When currentvalue.visible is true, this sets the prefix of the label."",
                ""editType"": ""arraydraw"",
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""suffix"": {
                ""description"": ""When currentvalue.visible is true, this sets the suffix of the label."",
                ""editType"": ""arraydraw"",
                ""valType"": ""string""
              },
              ""visible"": {
                ""description"": ""Shows the currently-selected value above the slider."",
                ""dflt"": true,
                ""editType"": ""arraydraw"",
                ""valType"": ""boolean""
              },
              ""xanchor"": {
                ""description"": ""The alignment of the value readout relative to the length of the slider."",
                ""dflt"": ""left"",
                ""editType"": ""arraydraw"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""left"",
                  ""center"",
                  ""right""
                ]
              }
            },
            ""editType"": ""arraydraw"",
            ""font"": {
              ""color"": {
                ""editType"": ""arraydraw"",
                ""valType"": ""color""
              },
              ""description"": ""Sets the font of the slider step labels."",
              ""editType"": ""arraydraw"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""arraydraw"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""arraydraw"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""len"": {
              ""description"": ""Sets the length of the slider This measure excludes the padding of both ends. That is, the slider's length is this length minus the padding on both ends."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""lenmode"": {
              ""description"": ""Determines whether this slider length is set in units of plot *fraction* or in *pixels. Use `len` to set the value."",
              ""dflt"": ""fraction"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""fraction"",
                ""pixels""
              ]
            },
            ""minorticklen"": {
              ""description"": ""Sets the length in pixels of minor step tick marks"",
              ""dflt"": 4,
              ""editType"": ""arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""name"": {
              ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
              ""editType"": ""arraydraw"",
              ""valType"": ""string""
            },
            ""pad"": {
              ""b"": {
                ""description"": ""The amount of padding (in px) along the bottom of the component."",
                ""dflt"": 0,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              },
              ""description"": ""Set the padding of the slider component along each side."",
              ""editType"": ""arraydraw"",
              ""l"": {
                ""description"": ""The amount of padding (in px) on the left side of the component."",
                ""dflt"": 0,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              },
              ""r"": {
                ""description"": ""The amount of padding (in px) on the right side of the component."",
                ""dflt"": 0,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              },
              ""role"": ""object"",
              ""t"": {
                ""description"": ""The amount of padding (in px) along the top of the component."",
                ""dflt"": 20,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""steps"": {
              ""items"": {
                ""step"": {
                  ""args"": {
                    ""description"": ""Sets the arguments values to be passed to the Plotly method set in `method` on slide."",
                    ""editType"": ""arraydraw"",
                    ""freeLength"": true,
                    ""items"": [
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      },
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      },
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      }
                    ],
                    ""valType"": ""info_array""
                  },
                  ""editType"": ""arraydraw"",
                  ""execute"": {
                    ""description"": ""When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_sliderchange` method and executing the API command manually without losing the benefit of the slider automatically binding to the state of the plot through the specification of `method` and `args`."",
                    ""dflt"": true,
                    ""editType"": ""arraydraw"",
                    ""valType"": ""boolean""
                  },
                  ""label"": {
                    ""description"": ""Sets the text label to appear on the slider"",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""string""
                  },
                  ""method"": {
                    ""description"": ""Sets the Plotly method to be called when the slider value is changed. If the `skip` method is used, the API slider will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to slider events manually via JavaScript."",
                    ""dflt"": ""restyle"",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""enumerated"",
                    ""values"": [
                      ""restyle"",
                      ""relayout"",
                      ""animate"",
                      ""update"",
                      ""skip""
                    ]
                  },
                  ""name"": {
                    ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""string""
                  },
                  ""role"": ""object"",
                  ""templateitemname"": {
                    ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""string""
                  },
                  ""value"": {
                    ""description"": ""Sets the value of the slider step, used to refer to the step programatically. Defaults to the slider label if not provided."",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""string""
                  },
                  ""visible"": {
                    ""description"": ""Determines whether or not this step is included in the slider."",
                    ""dflt"": true,
                    ""editType"": ""arraydraw"",
                    ""valType"": ""boolean""
                  }
                }
              },
              ""role"": ""object""
            },
            ""templateitemname"": {
              ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
              ""editType"": ""arraydraw"",
              ""valType"": ""string""
            },
            ""tickcolor"": {
              ""description"": ""Sets the color of the border enclosing the slider."",
              ""dflt"": ""#333"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""ticklen"": {
              ""description"": ""Sets the length in pixels of step tick marks"",
              ""dflt"": 7,
              ""editType"": ""arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""tickwidth"": {
              ""description"": ""Sets the tick width (in px)."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""transition"": {
              ""duration"": {
                ""description"": ""Sets the duration of the slider transition"",
                ""dflt"": 150,
                ""editType"": ""arraydraw"",
                ""min"": 0,
                ""valType"": ""number""
              },
              ""easing"": {
                ""description"": ""Sets the easing function of the slider transition"",
                ""dflt"": ""cubic-in-out"",
                ""editType"": ""arraydraw"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""linear"",
                  ""quad"",
                  ""cubic"",
                  ""sin"",
                  ""exp"",
                  ""circle"",
                  ""elastic"",
                  ""back"",
                  ""bounce"",
                  ""linear-in"",
                  ""quad-in"",
                  ""cubic-in"",
                  ""sin-in"",
                  ""exp-in"",
                  ""circle-in"",
                  ""elastic-in"",
                  ""back-in"",
                  ""bounce-in"",
                  ""linear-out"",
                  ""quad-out"",
                  ""cubic-out"",
                  ""sin-out"",
                  ""exp-out"",
                  ""circle-out"",
                  ""elastic-out"",
                  ""back-out"",
                  ""bounce-out"",
                  ""linear-in-out"",
                  ""quad-in-out"",
                  ""cubic-in-out"",
                  ""sin-in-out"",
                  ""exp-in-out"",
                  ""circle-in-out"",
                  ""elastic-in-out"",
                  ""back-in-out"",
                  ""bounce-in-out""
                ]
              },
              ""editType"": ""arraydraw"",
              ""role"": ""object""
            },
            ""visible"": {
              ""description"": ""Determines whether or not the slider is visible."",
              ""dflt"": true,
              ""editType"": ""arraydraw"",
              ""valType"": ""boolean""
            },
            ""x"": {
              ""description"": ""Sets the x position (in normalized coordinates) of the slider."",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""max"": 3,
              ""min"": -2,
              ""valType"": ""number""
            },
            ""xanchor"": {
              ""description"": ""Sets the slider's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector."",
              ""dflt"": ""left"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""auto"",
                ""left"",
                ""center"",
                ""right""
              ]
            },
            ""y"": {
              ""description"": ""Sets the y position (in normalized coordinates) of the slider."",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""max"": 3,
              ""min"": -2,
              ""valType"": ""number""
            },
            ""yanchor"": {
              ""description"": ""Sets the slider's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector."",
              ""dflt"": ""top"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""auto"",
                ""top"",
                ""middle"",
                ""bottom""
              ]
            }
          }
        },
        ""role"": ""object""
      },
      ""smith"": {
        ""_isSubplotObj"": true,
        ""bgcolor"": {
          ""description"": ""Set the background color of the subplot"",
          ""dflt"": ""#fff"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""domain"": {
          ""column"": {
            ""description"": ""If there is a layout grid, use the domain for this column in the grid for this smith subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""editType"": ""plot"",
          ""role"": ""object"",
          ""row"": {
            ""description"": ""If there is a layout grid, use the domain for this row in the grid for this smith subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""x"": {
            ""description"": ""Sets the horizontal domain of this smith subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""y"": {
            ""description"": ""Sets the vertical domain of this smith subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          }
        },
        ""editType"": ""calc"",
        ""imaginaryaxis"": {
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""editType"": ""plot"",
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""layer"": {
            ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
            ""dflt"": ""above traces"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""above traces"",
              ""below traces""
            ]
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""role"": ""object"",
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""ticks"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Defaults to `realaxis.tickvals` plus the same as negatives and zero."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 2,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""visible"": {
            ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          }
        },
        ""realaxis"": {
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""editType"": ""plot"",
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""layer"": {
            ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
            ""dflt"": ""above traces"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""above traces"",
              ""below traces""
            ]
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""role"": ""object"",
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""side"": {
            ""description"": ""Determines on which side of real axis line the tick and tick labels appear."",
            ""dflt"": ""top"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""top"",
              ""bottom""
            ]
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": 90,
            ""editType"": ""ticks"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *top* (*bottom*), this axis' are drawn above (below) the axis line."",
            ""editType"": ""ticks"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""top"",
              ""bottom"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear."",
            ""dflt"": [
              0.2,
              0.5,
              1,
              2,
              5
            ],
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 2,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""visible"": {
            ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          }
        },
        ""role"": ""object""
      },
      ""spikedistance"": {
        ""description"": ""Sets the default distance (in pixels) to look for data to draw spikelines to (-1 means no cutoff, 0 means no looking for data). As with hoverdistance, distance does not apply to area-like objects. In addition, some objects can be hovered on but will not generate spikelines, such as scatter fills."",
        ""dflt"": -1,
        ""editType"": ""none"",
        ""min"": -1,
        ""valType"": ""integer""
      },
      ""template"": {
        ""description"": ""Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`."",
        ""editType"": ""calc"",
        ""valType"": ""any""
      },
      ""ternary"": {
        ""_isSubplotObj"": true,
        ""aaxis"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            }
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""layer"": {
            ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
            ""dflt"": ""above traces"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""above traces"",
              ""below traces""
            ]
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""min"": {
            ""description"": ""The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 6,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklabelstep"": {
            ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""plot"",
            ""font"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""text"": {
              ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            }
          },
          ""uirevision"": {
            ""description"": ""Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`."",
            ""editType"": ""none"",
            ""valType"": ""any""
          }
        },
        ""baxis"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            }
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""layer"": {
            ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
            ""dflt"": ""above traces"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""above traces"",
              ""below traces""
            ]
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""min"": {
            ""description"": ""The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 6,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklabelstep"": {
            ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""plot"",
            ""font"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""text"": {
              ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            }
          },
          ""uirevision"": {
            ""description"": ""Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`."",
            ""editType"": ""none"",
            ""valType"": ""any""
          }
        },
        ""bgcolor"": {
          ""description"": ""Set the background color of the subplot"",
          ""dflt"": ""#fff"",
          ""editType"": ""plot"",
          ""valType"": ""color""
        },
        ""caxis"": {
          ""_deprecated"": {
            ""title"": {
              ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            },
            ""titlefont"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            }
          },
          ""color"": {
            ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""dtick"": {
            ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""editType"": ""plot"",
          ""exponentformat"": {
            ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
            ""dflt"": ""B"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""none"",
              ""e"",
              ""E"",
              ""power"",
              ""SI"",
              ""B""
            ]
          },
          ""gridcolor"": {
            ""description"": ""Sets the color of the grid lines."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""gridwidth"": {
            ""description"": ""Sets the width (in px) of the grid lines."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""hoverformat"": {
            ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""layer"": {
            ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
            ""dflt"": ""above traces"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""above traces"",
              ""below traces""
            ]
          },
          ""linecolor"": {
            ""description"": ""Sets the axis line color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""linewidth"": {
            ""description"": ""Sets the width (in px) of the axis line."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""min"": {
            ""description"": ""The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""minexponent"": {
            ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
            ""dflt"": 3,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""nticks"": {
            ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
            ""dflt"": 6,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""role"": ""object"",
          ""separatethousands"": {
            ""description"": ""If \""true\"", even 4-digit integers are separated"",
            ""dflt"": false,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showexponent"": {
            ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showgrid"": {
            ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showline"": {
            ""description"": ""Determines whether or not a line bounding this axis is drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showticklabels"": {
            ""description"": ""Determines whether or not the tick labels are drawn."",
            ""dflt"": true,
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""showtickprefix"": {
            ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""showticksuffix"": {
            ""description"": ""Same as `showtickprefix` but for tick suffixes."",
            ""dflt"": ""all"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""all"",
              ""first"",
              ""last"",
              ""none""
            ]
          },
          ""tick0"": {
            ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""plot"",
            ""impliedEdits"": {
              ""tickmode"": ""linear""
            },
            ""valType"": ""any""
          },
          ""tickangle"": {
            ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
            ""dflt"": ""auto"",
            ""editType"": ""plot"",
            ""valType"": ""angle""
          },
          ""tickcolor"": {
            ""description"": ""Sets the tick color."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""tickfont"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the tick font."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""tickformat"": {
            ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""tickformatstops"": {
            ""items"": {
              ""tickformatstop"": {
                ""dtickrange"": {
                  ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                  ""editType"": ""plot"",
                  ""items"": [
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    },
                    {
                      ""editType"": ""plot"",
                      ""valType"": ""any""
                    }
                  ],
                  ""valType"": ""info_array""
                },
                ""editType"": ""plot"",
                ""enabled"": {
                  ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""value"": {
                  ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                  ""dflt"": """",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                }
              }
            },
            ""role"": ""object""
          },
          ""ticklabelstep"": {
            ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 1,
            ""valType"": ""integer""
          },
          ""ticklen"": {
            ""description"": ""Sets the tick length (in px)."",
            ""dflt"": 5,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""tickmode"": {
            ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
            ""editType"": ""plot"",
            ""impliedEdits"": {},
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""linear"",
              ""array""
            ]
          },
          ""tickprefix"": {
            ""description"": ""Sets a tick label prefix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticks"": {
            ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""outside"",
              ""inside"",
              """"
            ]
          },
          ""ticksuffix"": {
            ""description"": ""Sets a tick label suffix."",
            ""dflt"": """",
            ""editType"": ""plot"",
            ""valType"": ""string""
          },
          ""ticktext"": {
            ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""ticktextsrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickvals"": {
            ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
            ""editType"": ""plot"",
            ""valType"": ""data_array""
          },
          ""tickvalssrc"": {
            ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
            ""editType"": ""none"",
            ""valType"": ""string""
          },
          ""tickwidth"": {
            ""description"": ""Sets the tick width (in px)."",
            ""dflt"": 1,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""title"": {
            ""editType"": ""plot"",
            ""font"": {
              ""color"": {
                ""editType"": ""plot"",
                ""valType"": ""color""
              },
              ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
              ""editType"": ""plot"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""plot"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""plot"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""text"": {
              ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
              ""editType"": ""plot"",
              ""valType"": ""string""
            }
          },
          ""uirevision"": {
            ""description"": ""Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`."",
            ""editType"": ""none"",
            ""valType"": ""any""
          }
        },
        ""domain"": {
          ""column"": {
            ""description"": ""If there is a layout grid, use the domain for this column in the grid for this ternary subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""editType"": ""plot"",
          ""role"": ""object"",
          ""row"": {
            ""description"": ""If there is a layout grid, use the domain for this row in the grid for this ternary subplot ."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""x"": {
            ""description"": ""Sets the horizontal domain of this ternary subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          },
          ""y"": {
            ""description"": ""Sets the vertical domain of this ternary subplot (in plot fraction)."",
            ""dflt"": [
              0,
              1
            ],
            ""editType"": ""plot"",
            ""items"": [
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              },
              {
                ""editType"": ""plot"",
                ""max"": 1,
                ""min"": 0,
                ""valType"": ""number""
              }
            ],
            ""valType"": ""info_array""
          }
        },
        ""editType"": ""plot"",
        ""role"": ""object"",
        ""sum"": {
          ""description"": ""The number each triplet should sum to, and the maximum range of each axis"",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        }
      },
      ""title"": {
        ""editType"": ""layoutstyle"",
        ""font"": {
          ""color"": {
            ""editType"": ""layoutstyle"",
            ""valType"": ""color""
          },
          ""description"": ""Sets the title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
          ""editType"": ""layoutstyle"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""editType"": ""layoutstyle"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""role"": ""object"",
          ""size"": {
            ""editType"": ""layoutstyle"",
            ""min"": 1,
            ""valType"": ""number""
          }
        },
        ""pad"": {
          ""b"": {
            ""description"": ""The amount of padding (in px) along the bottom of the component."",
            ""dflt"": 0,
            ""editType"": ""layoutstyle"",
            ""valType"": ""number""
          },
          ""description"": ""Sets the padding of the title. Each padding value only applies when the corresponding `xanchor`/`yanchor` value is set accordingly. E.g. for left padding to take effect, `xanchor` must be set to *left*. The same rule applies if `xanchor`/`yanchor` is determined automatically. Padding is muted if the respective anchor value is *middle*/*center*."",
          ""editType"": ""layoutstyle"",
          ""l"": {
            ""description"": ""The amount of padding (in px) on the left side of the component."",
            ""dflt"": 0,
            ""editType"": ""layoutstyle"",
            ""valType"": ""number""
          },
          ""r"": {
            ""description"": ""The amount of padding (in px) on the right side of the component."",
            ""dflt"": 0,
            ""editType"": ""layoutstyle"",
            ""valType"": ""number""
          },
          ""role"": ""object"",
          ""t"": {
            ""description"": ""The amount of padding (in px) along the top of the component."",
            ""dflt"": 0,
            ""editType"": ""layoutstyle"",
            ""valType"": ""number""
          }
        },
        ""role"": ""object"",
        ""text"": {
          ""description"": ""Sets the plot's title. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
          ""editType"": ""layoutstyle"",
          ""valType"": ""string""
        },
        ""x"": {
          ""description"": ""Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right)."",
          ""dflt"": 0.5,
          ""editType"": ""layoutstyle"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""xanchor"": {
          ""description"": ""Sets the title's horizontal alignment with respect to its x position. *left* means that the title starts at x, *right* means that the title ends at x and *center* means that the title's center is at x. *auto* divides `xref` by three and calculates the `xanchor` value automatically based on the value of `x`."",
          ""dflt"": ""auto"",
          ""editType"": ""layoutstyle"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""auto"",
            ""left"",
            ""center"",
            ""right""
          ]
        },
        ""xref"": {
          ""description"": ""Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only."",
          ""dflt"": ""container"",
          ""editType"": ""layoutstyle"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""container"",
            ""paper""
          ]
        },
        ""y"": {
          ""description"": ""Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin."",
          ""dflt"": ""auto"",
          ""editType"": ""layoutstyle"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""yanchor"": {
          ""description"": ""Sets the title's vertical alignment with respect to its y position. *top* means that the title's cap line is at y, *bottom* means that the title's baseline is at y and *middle* means that the title's midline is at y. *auto* divides `yref` by three and calculates the `yanchor` value automatically based on the value of `y`."",
          ""dflt"": ""auto"",
          ""editType"": ""layoutstyle"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""auto"",
            ""top"",
            ""middle"",
            ""bottom""
          ]
        },
        ""yref"": {
          ""description"": ""Sets the container `y` refers to. *container* spans the entire `height` of the plot. *paper* refers to the height of the plotting area only."",
          ""dflt"": ""container"",
          ""editType"": ""layoutstyle"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""container"",
            ""paper""
          ]
        }
      },
      ""transition"": {
        ""description"": ""Sets transition options used during Plotly.react updates."",
        ""duration"": {
          ""description"": ""The duration of the transition, in milliseconds. If equal to zero, updates are synchronous."",
          ""dflt"": 500,
          ""editType"": ""none"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""easing"": {
          ""description"": ""The easing function used for the transition"",
          ""dflt"": ""cubic-in-out"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""linear"",
            ""quad"",
            ""cubic"",
            ""sin"",
            ""exp"",
            ""circle"",
            ""elastic"",
            ""back"",
            ""bounce"",
            ""linear-in"",
            ""quad-in"",
            ""cubic-in"",
            ""sin-in"",
            ""exp-in"",
            ""circle-in"",
            ""elastic-in"",
            ""back-in"",
            ""bounce-in"",
            ""linear-out"",
            ""quad-out"",
            ""cubic-out"",
            ""sin-out"",
            ""exp-out"",
            ""circle-out"",
            ""elastic-out"",
            ""back-out"",
            ""bounce-out"",
            ""linear-in-out"",
            ""quad-in-out"",
            ""cubic-in-out"",
            ""sin-in-out"",
            ""exp-in-out"",
            ""circle-in-out"",
            ""elastic-in-out"",
            ""back-in-out"",
            ""bounce-in-out""
          ]
        },
        ""editType"": ""none"",
        ""ordering"": {
          ""description"": ""Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change."",
          ""dflt"": ""layout first"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""layout first"",
            ""traces first""
          ]
        },
        ""role"": ""object""
      },
      ""uirevision"": {
        ""description"": ""Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom."",
        ""editType"": ""none"",
        ""valType"": ""any""
      },
      ""uniformtext"": {
        ""editType"": ""plot"",
        ""minsize"": {
          ""description"": ""Sets the minimum text size between traces of the same type."",
          ""dflt"": 0,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""mode"": {
          ""description"": ""Determines how the font size for various text elements are uniformed between each trace type. If the computed text sizes were smaller than the minimum size defined by `uniformtext.minsize` using *hide* option hides the text; and using *show* option shows the text without further downscaling. Please note that if the size defined by `minsize` is greater than the font size defined by trace, then the `minsize` is used."",
          ""dflt"": false,
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            false,
            ""hide"",
            ""show""
          ]
        },
        ""role"": ""object""
      },
      ""updatemenus"": {
        ""items"": {
          ""updatemenu"": {
            ""_arrayAttrRegexps"": [
              {}
            ],
            ""active"": {
              ""description"": ""Determines which button (by index starting from 0) is considered active."",
              ""dflt"": 0,
              ""editType"": ""arraydraw"",
              ""min"": -1,
              ""valType"": ""integer""
            },
            ""bgcolor"": {
              ""description"": ""Sets the background color of the update menu buttons."",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""bordercolor"": {
              ""description"": ""Sets the color of the border enclosing the update menu."",
              ""dflt"": ""#BEC8D9"",
              ""editType"": ""arraydraw"",
              ""valType"": ""color""
            },
            ""borderwidth"": {
              ""description"": ""Sets the width (in px) of the border enclosing the update menu."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""min"": 0,
              ""valType"": ""number""
            },
            ""buttons"": {
              ""items"": {
                ""button"": {
                  ""args"": {
                    ""description"": ""Sets the arguments values to be passed to the Plotly method set in `method` on click."",
                    ""editType"": ""arraydraw"",
                    ""freeLength"": true,
                    ""items"": [
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      },
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      },
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      }
                    ],
                    ""valType"": ""info_array""
                  },
                  ""args2"": {
                    ""description"": ""Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons."",
                    ""editType"": ""arraydraw"",
                    ""freeLength"": true,
                    ""items"": [
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      },
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      },
                      {
                        ""editType"": ""arraydraw"",
                        ""valType"": ""any""
                      }
                    ],
                    ""valType"": ""info_array""
                  },
                  ""editType"": ""arraydraw"",
                  ""execute"": {
                    ""description"": ""When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_buttonclicked` method and executing the API command manually without losing the benefit of the updatemenu automatically binding to the state of the plot through the specification of `method` and `args`."",
                    ""dflt"": true,
                    ""editType"": ""arraydraw"",
                    ""valType"": ""boolean""
                  },
                  ""label"": {
                    ""description"": ""Sets the text label to appear on the button."",
                    ""dflt"": """",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""string""
                  },
                  ""method"": {
                    ""description"": ""Sets the Plotly method to be called on click. If the `skip` method is used, the API updatemenu will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to updatemenu events manually via JavaScript."",
                    ""dflt"": ""restyle"",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""enumerated"",
                    ""values"": [
                      ""restyle"",
                      ""relayout"",
                      ""animate"",
                      ""update"",
                      ""skip""
                    ]
                  },
                  ""name"": {
                    ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""string""
                  },
                  ""role"": ""object"",
                  ""templateitemname"": {
                    ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""string""
                  },
                  ""visible"": {
                    ""description"": ""Determines whether or not this button is visible."",
                    ""editType"": ""arraydraw"",
                    ""valType"": ""boolean""
                  }
                }
              },
              ""role"": ""object""
            },
            ""direction"": {
              ""description"": ""Determines the direction in which the buttons are laid out, whether in a dropdown menu or a row/column of buttons. For `left` and `up`, the buttons will still appear in left-to-right or top-to-bottom order respectively."",
              ""dflt"": ""down"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""left"",
                ""right"",
                ""up"",
                ""down""
              ]
            },
            ""editType"": ""arraydraw"",
            ""font"": {
              ""color"": {
                ""editType"": ""arraydraw"",
                ""valType"": ""color""
              },
              ""description"": ""Sets the font of the update menu button text."",
              ""editType"": ""arraydraw"",
              ""family"": {
                ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
                ""editType"": ""arraydraw"",
                ""noBlank"": true,
                ""strict"": true,
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""size"": {
                ""editType"": ""arraydraw"",
                ""min"": 1,
                ""valType"": ""number""
              }
            },
            ""name"": {
              ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
              ""editType"": ""arraydraw"",
              ""valType"": ""string""
            },
            ""pad"": {
              ""b"": {
                ""description"": ""The amount of padding (in px) along the bottom of the component."",
                ""dflt"": 0,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              },
              ""description"": ""Sets the padding around the buttons or dropdown menu."",
              ""editType"": ""arraydraw"",
              ""l"": {
                ""description"": ""The amount of padding (in px) on the left side of the component."",
                ""dflt"": 0,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              },
              ""r"": {
                ""description"": ""The amount of padding (in px) on the right side of the component."",
                ""dflt"": 0,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              },
              ""role"": ""object"",
              ""t"": {
                ""description"": ""The amount of padding (in px) along the top of the component."",
                ""dflt"": 0,
                ""editType"": ""arraydraw"",
                ""valType"": ""number""
              }
            },
            ""role"": ""object"",
            ""showactive"": {
              ""description"": ""Highlights active dropdown item or active button if true."",
              ""dflt"": true,
              ""editType"": ""arraydraw"",
              ""valType"": ""boolean""
            },
            ""templateitemname"": {
              ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
              ""editType"": ""arraydraw"",
              ""valType"": ""string""
            },
            ""type"": {
              ""description"": ""Determines whether the buttons are accessible via a dropdown menu or whether the buttons are stacked horizontally or vertically"",
              ""dflt"": ""dropdown"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""dropdown"",
                ""buttons""
              ]
            },
            ""visible"": {
              ""description"": ""Determines whether or not the update menu is visible."",
              ""editType"": ""arraydraw"",
              ""valType"": ""boolean""
            },
            ""x"": {
              ""description"": ""Sets the x position (in normalized coordinates) of the update menu."",
              ""dflt"": -0.05,
              ""editType"": ""arraydraw"",
              ""max"": 3,
              ""min"": -2,
              ""valType"": ""number""
            },
            ""xanchor"": {
              ""description"": ""Sets the update menu's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector."",
              ""dflt"": ""right"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""auto"",
                ""left"",
                ""center"",
                ""right""
              ]
            },
            ""y"": {
              ""description"": ""Sets the y position (in normalized coordinates) of the update menu."",
              ""dflt"": 1,
              ""editType"": ""arraydraw"",
              ""max"": 3,
              ""min"": -2,
              ""valType"": ""number""
            },
            ""yanchor"": {
              ""description"": ""Sets the update menu's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector."",
              ""dflt"": ""top"",
              ""editType"": ""arraydraw"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""auto"",
                ""top"",
                ""middle"",
                ""bottom""
              ]
            }
          }
        },
        ""role"": ""object""
      },
      ""width"": {
        ""description"": ""Sets the plot's width (in px)."",
        ""dflt"": 700,
        ""editType"": ""plot"",
        ""min"": 10,
        ""valType"": ""number""
      },
      ""xaxis"": {
        ""_deprecated"": {
          ""autotick"": {
            ""description"": ""Obsolete. Set `tickmode` to *auto* for old `autotick` *true* behavior. Set `tickmode` to *linear* for `autotick` *false*."",
            ""editType"": ""ticks"",
            ""valType"": ""boolean""
          },
          ""title"": {
            ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
            ""editType"": ""ticks"",
            ""valType"": ""string""
          },
          ""titlefont"": {
            ""color"": {
              ""editType"": ""ticks"",
              ""valType"": ""color""
            },
            ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
            ""editType"": ""ticks"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""ticks"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""size"": {
              ""editType"": ""ticks"",
              ""min"": 1,
              ""valType"": ""number""
            }
          }
        },
        ""_isSubplotObj"": true,
        ""anchor"": {
          ""description"": ""If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""free"",
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""automargin"": {
          ""description"": ""Determines whether long tick labels automatically grow the figure margins."",
          ""dflt"": false,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""autorange"": {
          ""description"": ""Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*."",
          ""dflt"": true,
          ""editType"": ""axrange"",
          ""impliedEdits"": {},
          ""valType"": ""enumerated"",
          ""values"": [
            true,
            false,
            ""reversed""
          ]
        },
        ""autotypenumbers"": {
          ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers."",
          ""dflt"": ""convert types"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""convert types"",
            ""strict""
          ]
        },
        ""calendar"": {
          ""description"": ""Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`"",
          ""dflt"": ""gregorian"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""chinese"",
            ""coptic"",
            ""discworld"",
            ""ethiopian"",
            ""gregorian"",
            ""hebrew"",
            ""islamic"",
            ""jalali"",
            ""julian"",
            ""mayan"",
            ""nanakshahi"",
            ""nepali"",
            ""persian"",
            ""taiwan"",
            ""thai"",
            ""ummalqura""
          ]
        },
        ""categoryarray"": {
          ""description"": ""Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`."",
          ""editType"": ""calc"",
          ""valType"": ""data_array""
        },
        ""categoryarraysrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `categoryarray`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""categoryorder"": {
          ""description"": ""Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values."",
          ""dflt"": ""trace"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""trace"",
            ""category ascending"",
            ""category descending"",
            ""array"",
            ""total ascending"",
            ""total descending"",
            ""min ascending"",
            ""min descending"",
            ""max ascending"",
            ""max descending"",
            ""sum ascending"",
            ""sum descending"",
            ""mean ascending"",
            ""mean descending"",
            ""median ascending"",
            ""median descending""
          ]
        },
        ""color"": {
          ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""constrain"": {
          ""description"": ""If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range*, or by decreasing the *domain*. Default is *domain* for axes containing image traces, *range* otherwise."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""range"",
            ""domain""
          ]
        },
        ""constraintoward"": {
          ""description"": ""If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""left"",
            ""center"",
            ""right"",
            ""top"",
            ""middle"",
            ""bottom""
          ]
        },
        ""dividercolor"": {
          ""description"": ""Sets the color of the dividers Only has an effect on *multicategory* axes."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""dividerwidth"": {
          ""description"": ""Sets the width (in px) of the dividers Only has an effect on *multicategory* axes."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""valType"": ""number""
        },
        ""domain"": {
          ""description"": ""Sets the domain of this axis (in plot fraction)."",
          ""dflt"": [
            0,
            1
          ],
          ""editType"": ""plot"",
          ""items"": [
            {
              ""editType"": ""plot"",
              ""max"": 1,
              ""min"": 0,
              ""valType"": ""number""
            },
            {
              ""editType"": ""plot"",
              ""max"": 1,
              ""min"": 0,
              ""valType"": ""number""
            }
          ],
          ""valType"": ""info_array""
        },
        ""dtick"": {
          ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
          ""editType"": ""ticks"",
          ""impliedEdits"": {
            ""tickmode"": ""linear""
          },
          ""valType"": ""any""
        },
        ""editType"": ""calc"",
        ""exponentformat"": {
          ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
          ""dflt"": ""B"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""none"",
            ""e"",
            ""E"",
            ""power"",
            ""SI"",
            ""B""
          ]
        },
        ""fixedrange"": {
          ""description"": ""Determines whether or not this axis is zoom-able. If true, then zoom is disabled."",
          ""dflt"": false,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        },
        ""gridcolor"": {
          ""description"": ""Sets the color of the grid lines."",
          ""dflt"": ""#eee"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""gridwidth"": {
          ""description"": ""Sets the width (in px) of the grid lines."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""hoverformat"": {
          ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
          ""dflt"": """",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""layer"": {
          ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
          ""dflt"": ""above traces"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""above traces"",
            ""below traces""
          ]
        },
        ""linecolor"": {
          ""description"": ""Sets the axis line color."",
          ""dflt"": ""#444"",
          ""editType"": ""layoutstyle"",
          ""valType"": ""color""
        },
        ""linewidth"": {
          ""description"": ""Sets the width (in px) of the axis line."",
          ""dflt"": 1,
          ""editType"": ""ticks+layoutstyle"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""matches"": {
          ""description"": ""If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`."",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""minexponent"": {
          ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
          ""dflt"": 3,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""mirror"": {
          ""description"": ""Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots."",
          ""dflt"": false,
          ""editType"": ""ticks+layoutstyle"",
          ""valType"": ""enumerated"",
          ""values"": [
            true,
            ""ticks"",
            false,
            ""all"",
            ""allticks""
          ]
        },
        ""nticks"": {
          ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
          ""dflt"": 0,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""integer""
        },
        ""overlaying"": {
          ""description"": ""If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""free"",
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""position"": {
          ""description"": ""Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*."",
          ""dflt"": 0,
          ""editType"": ""plot"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""range"": {
          ""anim"": true,
          ""description"": ""Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
          ""editType"": ""axrange"",
          ""impliedEdits"": {
            ""autorange"": false
          },
          ""items"": [
            {
              ""anim"": true,
              ""editType"": ""axrange"",
              ""impliedEdits"": {
                ""^autorange"": false
              },
              ""valType"": ""any""
            },
            {
              ""anim"": true,
              ""editType"": ""axrange"",
              ""impliedEdits"": {
                ""^autorange"": false
              },
              ""valType"": ""any""
            }
          ],
          ""valType"": ""info_array""
        },
        ""rangebreaks"": {
          ""items"": {
            ""rangebreak"": {
              ""bounds"": {
                ""description"": ""Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`."",
                ""editType"": ""calc"",
                ""items"": [
                  {
                    ""editType"": ""calc"",
                    ""valType"": ""any""
                  },
                  {
                    ""editType"": ""calc"",
                    ""valType"": ""any""
                  }
                ],
                ""valType"": ""info_array""
              },
              ""dvalue"": {
                ""description"": ""Sets the size of each `values` item. The default is one day in milliseconds."",
                ""dflt"": 86400000,
                ""editType"": ""calc"",
                ""min"": 0,
                ""valType"": ""number""
              },
              ""editType"": ""calc"",
              ""enabled"": {
                ""description"": ""Determines whether this axis rangebreak is enabled or disabled. Please note that `rangebreaks` only work for *date* axis type."",
                ""dflt"": true,
                ""editType"": ""calc"",
                ""valType"": ""boolean""
              },
              ""name"": {
                ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                ""editType"": ""none"",
                ""valType"": ""string""
              },
              ""pattern"": {
                ""description"": ""Determines a pattern on the time line that generates breaks. If *day of week* - days of the week in English e.g. 'Sunday' or `sun` (matching is case-insensitive and considers only the first three characters), as well as Sunday-based integers between 0 and 6. If *hour* - hour (24-hour clock) as decimal numbers between 0 and 24. for more info. Examples: - { pattern: 'day of week', bounds: [6, 1] }  or simply { bounds: ['sat', 'mon'] }   breaks from Saturday to Monday (i.e. skips the weekends). - { pattern: 'hour', bounds: [17, 8] }   breaks from 5pm to 8am (i.e. skips non-work hours)."",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""day of week"",
                  ""hour"",
                  """"
                ]
              },
              ""role"": ""object"",
              ""templateitemname"": {
                ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""values"": {
                ""description"": ""Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis."",
                ""editType"": ""calc"",
                ""freeLength"": true,
                ""items"": {
                  ""editType"": ""calc"",
                  ""valType"": ""any""
                },
                ""valType"": ""info_array""
              }
            }
          },
          ""role"": ""object""
        },
        ""rangemode"": {
          ""description"": ""If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes."",
          ""dflt"": ""normal"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""normal"",
            ""tozero"",
            ""nonnegative""
          ]
        },
        ""rangeselector"": {
          ""activecolor"": {
            ""description"": ""Sets the background color of the active range selector button."",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""bgcolor"": {
            ""description"": ""Sets the background color of the range selector buttons."",
            ""dflt"": ""#eee"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""bordercolor"": {
            ""description"": ""Sets the color of the border enclosing the range selector."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""borderwidth"": {
            ""description"": ""Sets the width (in px) of the border enclosing the range selector."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""buttons"": {
            ""items"": {
              ""button"": {
                ""count"": {
                  ""description"": ""Sets the number of steps to take to update the range. Use with `step` to specify the update interval."",
                  ""dflt"": 1,
                  ""editType"": ""plot"",
                  ""min"": 0,
                  ""valType"": ""number""
                },
                ""description"": ""Sets the specifications for each buttons. By default, a range selector comes with no buttons."",
                ""editType"": ""plot"",
                ""label"": {
                  ""description"": ""Sets the text label to appear on the button."",
                  ""editType"": ""plot"",
                  ""valType"": ""string""
                },
                ""name"": {
                  ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                  ""editType"": ""none"",
                  ""valType"": ""string""
                },
                ""role"": ""object"",
                ""step"": {
                  ""description"": ""The unit of measurement that the `count` value will set the range by."",
                  ""dflt"": ""month"",
                  ""editType"": ""plot"",
                  ""valType"": ""enumerated"",
                  ""values"": [
                    ""month"",
                    ""year"",
                    ""day"",
                    ""hour"",
                    ""minute"",
                    ""second"",
                    ""all""
                  ]
                },
                ""stepmode"": {
                  ""description"": ""Sets the range update mode. If *backward*, the range update shifts the start of range back *count* times *step* milliseconds. If *todate*, the range update shifts the start of range back to the first timestamp from *count* times *step* milliseconds back. For example, with `step` set to *year* and `count` set to *1* the range update shifts the start of the range back to January 01 of the current year. Month and year *todate* are currently available only for the built-in (Gregorian) calendar."",
                  ""dflt"": ""backward"",
                  ""editType"": ""plot"",
                  ""valType"": ""enumerated"",
                  ""values"": [
                    ""backward"",
                    ""todate""
                  ]
                },
                ""templateitemname"": {
                  ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                  ""editType"": ""calc"",
                  ""valType"": ""string""
                },
                ""visible"": {
                  ""description"": ""Determines whether or not this button is visible."",
                  ""dflt"": true,
                  ""editType"": ""plot"",
                  ""valType"": ""boolean""
                }
              }
            },
            ""role"": ""object""
          },
          ""editType"": ""plot"",
          ""font"": {
            ""color"": {
              ""editType"": ""plot"",
              ""valType"": ""color""
            },
            ""description"": ""Sets the font of the range selector button text."",
            ""editType"": ""plot"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""plot"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""plot"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""role"": ""object"",
          ""visible"": {
            ""description"": ""Determines whether or not this range selector is visible. Note that range selectors are only available for x axes of `type` set to or auto-typed to *date*."",
            ""editType"": ""plot"",
            ""valType"": ""boolean""
          },
          ""x"": {
            ""description"": ""Sets the x position (in normalized coordinates) of the range selector."",
            ""editType"": ""plot"",
            ""max"": 3,
            ""min"": -2,
            ""valType"": ""number""
          },
          ""xanchor"": {
            ""description"": ""Sets the range selector's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector."",
            ""dflt"": ""left"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""left"",
              ""center"",
              ""right""
            ]
          },
          ""y"": {
            ""description"": ""Sets the y position (in normalized coordinates) of the range selector."",
            ""editType"": ""plot"",
            ""max"": 3,
            ""min"": -2,
            ""valType"": ""number""
          },
          ""yanchor"": {
            ""description"": ""Sets the range selector's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector."",
            ""dflt"": ""bottom"",
            ""editType"": ""plot"",
            ""valType"": ""enumerated"",
            ""values"": [
              ""auto"",
              ""top"",
              ""middle"",
              ""bottom""
            ]
          }
        },
        ""rangeslider"": {
          ""autorange"": {
            ""description"": ""Determines whether or not the range slider range is computed in relation to the input data. If `range` is provided, then `autorange` is set to *false*."",
            ""dflt"": true,
            ""editType"": ""calc"",
            ""impliedEdits"": {},
            ""valType"": ""boolean""
          },
          ""bgcolor"": {
            ""description"": ""Sets the background color of the range slider."",
            ""dflt"": ""#fff"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""bordercolor"": {
            ""description"": ""Sets the border color of the range slider."",
            ""dflt"": ""#444"",
            ""editType"": ""plot"",
            ""valType"": ""color""
          },
          ""borderwidth"": {
            ""description"": ""Sets the border width of the range slider."",
            ""dflt"": 0,
            ""editType"": ""plot"",
            ""min"": 0,
            ""valType"": ""integer""
          },
          ""editType"": ""calc"",
          ""range"": {
            ""description"": ""Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
            ""editType"": ""calc"",
            ""impliedEdits"": {
              ""autorange"": false
            },
            ""items"": [
              {
                ""editType"": ""calc"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              },
              {
                ""editType"": ""calc"",
                ""impliedEdits"": {
                  ""^autorange"": false
                },
                ""valType"": ""any""
              }
            ],
            ""valType"": ""info_array""
          },
          ""role"": ""object"",
          ""thickness"": {
            ""description"": ""The height of the range slider as a fraction of the total plot area height."",
            ""dflt"": 0.15,
            ""editType"": ""plot"",
            ""max"": 1,
            ""min"": 0,
            ""valType"": ""number""
          },
          ""visible"": {
            ""description"": ""Determines whether or not the range slider will be visible. If visible, perpendicular axes will be set to `fixedrange`"",
            ""dflt"": true,
            ""editType"": ""calc"",
            ""valType"": ""boolean""
          },
          ""yaxis"": {
            ""_isSubplotObj"": true,
            ""editType"": ""calc"",
            ""range"": {
              ""description"": ""Sets the range of this axis for the rangeslider."",
              ""editType"": ""plot"",
              ""items"": [
                {
                  ""editType"": ""plot"",
                  ""valType"": ""any""
                },
                {
                  ""editType"": ""plot"",
                  ""valType"": ""any""
                }
              ],
              ""valType"": ""info_array""
            },
            ""rangemode"": {
              ""description"": ""Determines whether or not the range of this axis in the rangeslider use the same value than in the main plot when zooming in/out. If *auto*, the autorange will be used. If *fixed*, the `range` is used. If *match*, the current range of the corresponding y-axis on the main subplot is used."",
              ""dflt"": ""match"",
              ""editType"": ""calc"",
              ""valType"": ""enumerated"",
              ""values"": [
                ""auto"",
                ""fixed"",
                ""match""
              ]
            },
            ""role"": ""object""
          }
        },
        ""role"": ""object"",
        ""scaleanchor"": {
          ""description"": ""If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""scaleratio"": {
          ""description"": ""If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""separatethousands"": {
          ""description"": ""If \""true\"", even 4-digit integers are separated"",
          ""dflt"": false,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showdividers"": {
          ""description"": ""Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes."",
          ""dflt"": true,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showexponent"": {
          ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
          ""dflt"": ""all"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""all"",
            ""first"",
            ""last"",
            ""none""
          ]
        },
        ""showgrid"": {
          ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showline"": {
          ""description"": ""Determines whether or not a line bounding this axis is drawn."",
          ""dflt"": false,
          ""editType"": ""ticks+layoutstyle"",
          ""valType"": ""boolean""
        },
        ""showspikes"": {
          ""description"": ""Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest"",
          ""dflt"": false,
          ""editType"": ""modebar"",
          ""valType"": ""boolean""
        },
        ""showticklabels"": {
          ""description"": ""Determines whether or not the tick labels are drawn."",
          ""dflt"": true,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showtickprefix"": {
          ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
          ""dflt"": ""all"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""all"",
            ""first"",
            ""last"",
            ""none""
          ]
        },
        ""showticksuffix"": {
          ""description"": ""Same as `showtickprefix` but for tick suffixes."",
          ""dflt"": ""all"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""all"",
            ""first"",
            ""last"",
            ""none""
          ]
        },
        ""side"": {
          ""description"": ""Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""top"",
            ""bottom"",
            ""left"",
            ""right""
          ]
        },
        ""spikecolor"": {
          ""description"": ""Sets the spike color. If undefined, will use the series color"",
          ""dflt"": null,
          ""editType"": ""none"",
          ""valType"": ""color""
        },
        ""spikedash"": {
          ""description"": ""Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*)."",
          ""dflt"": ""dash"",
          ""editType"": ""none"",
          ""valType"": ""string"",
          ""values"": [
            ""solid"",
            ""dot"",
            ""dash"",
            ""longdash"",
            ""dashdot"",
            ""longdashdot""
          ]
        },
        ""spikemode"": {
          ""description"": ""Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on"",
          ""dflt"": ""toaxis"",
          ""editType"": ""none"",
          ""flags"": [
            ""toaxis"",
            ""across"",
            ""marker""
          ],
          ""valType"": ""flaglist""
        },
        ""spikesnap"": {
          ""description"": ""Determines whether spikelines are stuck to the cursor or to the closest datapoints."",
          ""dflt"": ""hovered data"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""data"",
            ""cursor"",
            ""hovered data""
          ]
        },
        ""spikethickness"": {
          ""description"": ""Sets the width (in px) of the zero line."",
          ""dflt"": 3,
          ""editType"": ""none"",
          ""valType"": ""number""
        },
        ""tick0"": {
          ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
          ""editType"": ""ticks"",
          ""impliedEdits"": {
            ""tickmode"": ""linear""
          },
          ""valType"": ""any""
        },
        ""tickangle"": {
          ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
          ""dflt"": ""auto"",
          ""editType"": ""ticks"",
          ""valType"": ""angle""
        },
        ""tickcolor"": {
          ""description"": ""Sets the tick color."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""tickfont"": {
          ""color"": {
            ""editType"": ""ticks"",
            ""valType"": ""color""
          },
          ""description"": ""Sets the tick font."",
          ""editType"": ""ticks"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""editType"": ""ticks"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""role"": ""object"",
          ""size"": {
            ""editType"": ""ticks"",
            ""min"": 1,
            ""valType"": ""number""
          }
        },
        ""tickformat"": {
          ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
          ""dflt"": """",
          ""editType"": ""ticks"",
          ""valType"": ""string""
        },
        ""tickformatstops"": {
          ""items"": {
            ""tickformatstop"": {
              ""dtickrange"": {
                ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                ""editType"": ""ticks"",
                ""items"": [
                  {
                    ""editType"": ""ticks"",
                    ""valType"": ""any""
                  },
                  {
                    ""editType"": ""ticks"",
                    ""valType"": ""any""
                  }
                ],
                ""valType"": ""info_array""
              },
              ""editType"": ""ticks"",
              ""enabled"": {
                ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                ""dflt"": true,
                ""editType"": ""ticks"",
                ""valType"": ""boolean""
              },
              ""name"": {
                ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                ""editType"": ""none"",
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""templateitemname"": {
                ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""value"": {
                ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                ""dflt"": """",
                ""editType"": ""ticks"",
                ""valType"": ""string""
              }
            }
          },
          ""role"": ""object""
        },
        ""ticklabelmode"": {
          ""description"": ""Determines where tick labels are drawn with respect to their corresponding ticks and grid lines. Only has an effect for axes of `type` *date* When set to *period*, tick labels are drawn in the middle of the period between ticks."",
          ""dflt"": ""instant"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""instant"",
            ""period""
          ]
        },
        ""ticklabeloverflow"": {
          ""description"": ""Determines how we handle tick labels that would overflow either the graph div or the domain of the axis. The default value for inside tick labels is *hide past domain*. Otherwise on *category* and *multicategory* axes the default is *allow*. In other cases the default is *hide past div*."",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""allow"",
            ""hide past div"",
            ""hide past domain""
          ]
        },
        ""ticklabelposition"": {
          ""description"": ""Determines where tick labels are drawn with respect to the axis Please note that top or bottom has no effect on x axes or when `ticklabelmode` is set to *period*. Similarly left or right has no effect on y axes or when `ticklabelmode` is set to *period*. Has no effect on *multicategory* axes or when `tickson` is set to *boundaries*. When used on axes linked by `matches` or `scaleanchor`, no extra padding for inside labels would be added by autorange, so that the scales could match."",
          ""dflt"": ""outside"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""outside"",
            ""inside"",
            ""outside top"",
            ""inside top"",
            ""outside left"",
            ""inside left"",
            ""outside right"",
            ""inside right"",
            ""outside bottom"",
            ""inside bottom""
          ]
        },
        ""ticklabelstep"": {
          ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""min"": 1,
          ""valType"": ""integer""
        },
        ""ticklen"": {
          ""description"": ""Sets the tick length (in px)."",
          ""dflt"": 5,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""tickmode"": {
          ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
          ""editType"": ""ticks"",
          ""impliedEdits"": {},
          ""valType"": ""enumerated"",
          ""values"": [
            ""auto"",
            ""linear"",
            ""array""
          ]
        },
        ""tickprefix"": {
          ""description"": ""Sets a tick label prefix."",
          ""dflt"": """",
          ""editType"": ""ticks"",
          ""valType"": ""string""
        },
        ""ticks"": {
          ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""outside"",
            ""inside"",
            """"
          ]
        },
        ""tickson"": {
          ""description"": ""Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels."",
          ""dflt"": ""labels"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""labels"",
            ""boundaries""
          ]
        },
        ""ticksuffix"": {
          ""description"": ""Sets a tick label suffix."",
          ""dflt"": """",
          ""editType"": ""ticks"",
          ""valType"": ""string""
        },
        ""ticktext"": {
          ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
          ""editType"": ""ticks"",
          ""valType"": ""data_array""
        },
        ""ticktextsrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""tickvals"": {
          ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
          ""editType"": ""ticks"",
          ""valType"": ""data_array""
        },
        ""tickvalssrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""tickwidth"": {
          ""description"": ""Sets the tick width (in px)."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""title"": {
          ""editType"": ""ticks"",
          ""font"": {
            ""color"": {
              ""editType"": ""ticks"",
              ""valType"": ""color""
            },
            ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
            ""editType"": ""ticks"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""ticks"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""ticks"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""role"": ""object"",
          ""standoff"": {
            ""description"": ""Sets the standoff distance (in px) between the axis labels and the title text The default value is a function of the axis tick labels, the title `font.size` and the axis `linewidth`. Note that the axis title position is always constrained within the margins, so the actual standoff distance is always less than the set or default value. By setting `standoff` and turning on `automargin`, plotly.js will push the margins to fit the axis title at given standoff distance."",
            ""editType"": ""ticks"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""text"": {
            ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
            ""editType"": ""ticks"",
            ""valType"": ""string""
          }
        },
        ""type"": {
          ""_noTemplating"": true,
          ""description"": ""Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question."",
          ""dflt"": ""-"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""-"",
            ""linear"",
            ""log"",
            ""date"",
            ""category"",
            ""multicategory""
          ]
        },
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        },
        ""visible"": {
          ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""zeroline"": {
          ""description"": ""Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines."",
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""zerolinecolor"": {
          ""description"": ""Sets the line color of the zero line."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""zerolinewidth"": {
          ""description"": ""Sets the width (in px) of the zero line."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""valType"": ""number""
        }
      },
      ""yaxis"": {
        ""_deprecated"": {
          ""autotick"": {
            ""description"": ""Obsolete. Set `tickmode` to *auto* for old `autotick` *true* behavior. Set `tickmode` to *linear* for `autotick` *false*."",
            ""editType"": ""ticks"",
            ""valType"": ""boolean""
          },
          ""title"": {
            ""description"": ""Value of `title` is no longer a simple *string* but a set of sub-attributes. To set the axis' title, please use `title.text` now."",
            ""editType"": ""ticks"",
            ""valType"": ""string""
          },
          ""titlefont"": {
            ""color"": {
              ""editType"": ""ticks"",
              ""valType"": ""color""
            },
            ""description"": ""Former `titlefont` is now the sub-attribute `font` of `title`. To customize title font properties, please use `title.font` now."",
            ""editType"": ""ticks"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""ticks"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""size"": {
              ""editType"": ""ticks"",
              ""min"": 1,
              ""valType"": ""number""
            }
          }
        },
        ""_isSubplotObj"": true,
        ""anchor"": {
          ""description"": ""If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""free"",
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""automargin"": {
          ""description"": ""Determines whether long tick labels automatically grow the figure margins."",
          ""dflt"": false,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""autorange"": {
          ""description"": ""Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*."",
          ""dflt"": true,
          ""editType"": ""axrange"",
          ""impliedEdits"": {},
          ""valType"": ""enumerated"",
          ""values"": [
            true,
            false,
            ""reversed""
          ]
        },
        ""autotypenumbers"": {
          ""description"": ""Using *strict* a numeric string in trace data is not converted to a number. Using *convert types* a numeric string in trace data may be treated as a number during automatic axis `type` detection. Defaults to layout.autotypenumbers."",
          ""dflt"": ""convert types"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""convert types"",
            ""strict""
          ]
        },
        ""calendar"": {
          ""description"": ""Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`"",
          ""dflt"": ""gregorian"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""chinese"",
            ""coptic"",
            ""discworld"",
            ""ethiopian"",
            ""gregorian"",
            ""hebrew"",
            ""islamic"",
            ""jalali"",
            ""julian"",
            ""mayan"",
            ""nanakshahi"",
            ""nepali"",
            ""persian"",
            ""taiwan"",
            ""thai"",
            ""ummalqura""
          ]
        },
        ""categoryarray"": {
          ""description"": ""Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`."",
          ""editType"": ""calc"",
          ""valType"": ""data_array""
        },
        ""categoryarraysrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `categoryarray`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""categoryorder"": {
          ""description"": ""Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values."",
          ""dflt"": ""trace"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""trace"",
            ""category ascending"",
            ""category descending"",
            ""array"",
            ""total ascending"",
            ""total descending"",
            ""min ascending"",
            ""min descending"",
            ""max ascending"",
            ""max descending"",
            ""sum ascending"",
            ""sum descending"",
            ""mean ascending"",
            ""mean descending"",
            ""median ascending"",
            ""median descending""
          ]
        },
        ""color"": {
          ""description"": ""Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""constrain"": {
          ""description"": ""If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range*, or by decreasing the *domain*. Default is *domain* for axes containing image traces, *range* otherwise."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""range"",
            ""domain""
          ]
        },
        ""constraintoward"": {
          ""description"": ""If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""left"",
            ""center"",
            ""right"",
            ""top"",
            ""middle"",
            ""bottom""
          ]
        },
        ""dividercolor"": {
          ""description"": ""Sets the color of the dividers Only has an effect on *multicategory* axes."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""dividerwidth"": {
          ""description"": ""Sets the width (in px) of the dividers Only has an effect on *multicategory* axes."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""valType"": ""number""
        },
        ""domain"": {
          ""description"": ""Sets the domain of this axis (in plot fraction)."",
          ""dflt"": [
            0,
            1
          ],
          ""editType"": ""plot"",
          ""items"": [
            {
              ""editType"": ""plot"",
              ""max"": 1,
              ""min"": 0,
              ""valType"": ""number""
            },
            {
              ""editType"": ""plot"",
              ""max"": 1,
              ""min"": 0,
              ""valType"": ""number""
            }
          ],
          ""valType"": ""info_array""
        },
        ""dtick"": {
          ""description"": ""Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*"",
          ""editType"": ""ticks"",
          ""impliedEdits"": {
            ""tickmode"": ""linear""
          },
          ""valType"": ""any""
        },
        ""editType"": ""calc"",
        ""exponentformat"": {
          ""description"": ""Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B."",
          ""dflt"": ""B"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""none"",
            ""e"",
            ""E"",
            ""power"",
            ""SI"",
            ""B""
          ]
        },
        ""fixedrange"": {
          ""description"": ""Determines whether or not this axis is zoom-able. If true, then zoom is disabled."",
          ""dflt"": false,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        },
        ""gridcolor"": {
          ""description"": ""Sets the color of the grid lines."",
          ""dflt"": ""#eee"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""gridwidth"": {
          ""description"": ""Sets the width (in px) of the grid lines."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""hoverformat"": {
          ""description"": ""Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
          ""dflt"": """",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""layer"": {
          ""description"": ""Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis."",
          ""dflt"": ""above traces"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""above traces"",
            ""below traces""
          ]
        },
        ""linecolor"": {
          ""description"": ""Sets the axis line color."",
          ""dflt"": ""#444"",
          ""editType"": ""layoutstyle"",
          ""valType"": ""color""
        },
        ""linewidth"": {
          ""description"": ""Sets the width (in px) of the axis line."",
          ""dflt"": 1,
          ""editType"": ""ticks+layoutstyle"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""matches"": {
          ""description"": ""If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`."",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""minexponent"": {
          ""description"": ""Hide SI prefix for 10^n if |n| is below this number. This only has an effect when `tickformat` is *SI* or *B*."",
          ""dflt"": 3,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""mirror"": {
          ""description"": ""Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots."",
          ""dflt"": false,
          ""editType"": ""ticks+layoutstyle"",
          ""valType"": ""enumerated"",
          ""values"": [
            true,
            ""ticks"",
            false,
            ""all"",
            ""allticks""
          ]
        },
        ""nticks"": {
          ""description"": ""Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*."",
          ""dflt"": 0,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""integer""
        },
        ""overlaying"": {
          ""description"": ""If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""free"",
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""position"": {
          ""description"": ""Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*."",
          ""dflt"": 0,
          ""editType"": ""plot"",
          ""max"": 1,
          ""min"": 0,
          ""valType"": ""number""
        },
        ""range"": {
          ""anim"": true,
          ""description"": ""Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears."",
          ""editType"": ""axrange"",
          ""impliedEdits"": {
            ""autorange"": false
          },
          ""items"": [
            {
              ""anim"": true,
              ""editType"": ""axrange"",
              ""impliedEdits"": {
                ""^autorange"": false
              },
              ""valType"": ""any""
            },
            {
              ""anim"": true,
              ""editType"": ""axrange"",
              ""impliedEdits"": {
                ""^autorange"": false
              },
              ""valType"": ""any""
            }
          ],
          ""valType"": ""info_array""
        },
        ""rangebreaks"": {
          ""items"": {
            ""rangebreak"": {
              ""bounds"": {
                ""description"": ""Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`."",
                ""editType"": ""calc"",
                ""items"": [
                  {
                    ""editType"": ""calc"",
                    ""valType"": ""any""
                  },
                  {
                    ""editType"": ""calc"",
                    ""valType"": ""any""
                  }
                ],
                ""valType"": ""info_array""
              },
              ""dvalue"": {
                ""description"": ""Sets the size of each `values` item. The default is one day in milliseconds."",
                ""dflt"": 86400000,
                ""editType"": ""calc"",
                ""min"": 0,
                ""valType"": ""number""
              },
              ""editType"": ""calc"",
              ""enabled"": {
                ""description"": ""Determines whether this axis rangebreak is enabled or disabled. Please note that `rangebreaks` only work for *date* axis type."",
                ""dflt"": true,
                ""editType"": ""calc"",
                ""valType"": ""boolean""
              },
              ""name"": {
                ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                ""editType"": ""none"",
                ""valType"": ""string""
              },
              ""pattern"": {
                ""description"": ""Determines a pattern on the time line that generates breaks. If *day of week* - days of the week in English e.g. 'Sunday' or `sun` (matching is case-insensitive and considers only the first three characters), as well as Sunday-based integers between 0 and 6. If *hour* - hour (24-hour clock) as decimal numbers between 0 and 24. for more info. Examples: - { pattern: 'day of week', bounds: [6, 1] }  or simply { bounds: ['sat', 'mon'] }   breaks from Saturday to Monday (i.e. skips the weekends). - { pattern: 'hour', bounds: [17, 8] }   breaks from 5pm to 8am (i.e. skips non-work hours)."",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""day of week"",
                  ""hour"",
                  """"
                ]
              },
              ""role"": ""object"",
              ""templateitemname"": {
                ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""values"": {
                ""description"": ""Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis."",
                ""editType"": ""calc"",
                ""freeLength"": true,
                ""items"": {
                  ""editType"": ""calc"",
                  ""valType"": ""any""
                },
                ""valType"": ""info_array""
              }
            }
          },
          ""role"": ""object""
        },
        ""rangemode"": {
          ""description"": ""If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes."",
          ""dflt"": ""normal"",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""normal"",
            ""tozero"",
            ""nonnegative""
          ]
        },
        ""role"": ""object"",
        ""scaleanchor"": {
          ""description"": ""If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""/^x([2-9]|[1-9][0-9]+)?( domain)?$/"",
            ""/^y([2-9]|[1-9][0-9]+)?( domain)?$/""
          ]
        },
        ""scaleratio"": {
          ""description"": ""If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal."",
          ""dflt"": 1,
          ""editType"": ""plot"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""separatethousands"": {
          ""description"": ""If \""true\"", even 4-digit integers are separated"",
          ""dflt"": false,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showdividers"": {
          ""description"": ""Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes."",
          ""dflt"": true,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showexponent"": {
          ""description"": ""If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear."",
          ""dflt"": ""all"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""all"",
            ""first"",
            ""last"",
            ""none""
          ]
        },
        ""showgrid"": {
          ""description"": ""Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark."",
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showline"": {
          ""description"": ""Determines whether or not a line bounding this axis is drawn."",
          ""dflt"": false,
          ""editType"": ""ticks+layoutstyle"",
          ""valType"": ""boolean""
        },
        ""showspikes"": {
          ""description"": ""Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest"",
          ""dflt"": false,
          ""editType"": ""modebar"",
          ""valType"": ""boolean""
        },
        ""showticklabels"": {
          ""description"": ""Determines whether or not the tick labels are drawn."",
          ""dflt"": true,
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""showtickprefix"": {
          ""description"": ""If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden."",
          ""dflt"": ""all"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""all"",
            ""first"",
            ""last"",
            ""none""
          ]
        },
        ""showticksuffix"": {
          ""description"": ""Same as `showtickprefix` but for tick suffixes."",
          ""dflt"": ""all"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""all"",
            ""first"",
            ""last"",
            ""none""
          ]
        },
        ""side"": {
          ""description"": ""Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area."",
          ""editType"": ""plot"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""top"",
            ""bottom"",
            ""left"",
            ""right""
          ]
        },
        ""spikecolor"": {
          ""description"": ""Sets the spike color. If undefined, will use the series color"",
          ""dflt"": null,
          ""editType"": ""none"",
          ""valType"": ""color""
        },
        ""spikedash"": {
          ""description"": ""Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*)."",
          ""dflt"": ""dash"",
          ""editType"": ""none"",
          ""valType"": ""string"",
          ""values"": [
            ""solid"",
            ""dot"",
            ""dash"",
            ""longdash"",
            ""dashdot"",
            ""longdashdot""
          ]
        },
        ""spikemode"": {
          ""description"": ""Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on"",
          ""dflt"": ""toaxis"",
          ""editType"": ""none"",
          ""flags"": [
            ""toaxis"",
            ""across"",
            ""marker""
          ],
          ""valType"": ""flaglist""
        },
        ""spikesnap"": {
          ""description"": ""Determines whether spikelines are stuck to the cursor or to the closest datapoints."",
          ""dflt"": ""hovered data"",
          ""editType"": ""none"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""data"",
            ""cursor"",
            ""hovered data""
          ]
        },
        ""spikethickness"": {
          ""description"": ""Sets the width (in px) of the zero line."",
          ""dflt"": 3,
          ""editType"": ""none"",
          ""valType"": ""number""
        },
        ""tick0"": {
          ""description"": ""Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears."",
          ""editType"": ""ticks"",
          ""impliedEdits"": {
            ""tickmode"": ""linear""
          },
          ""valType"": ""any""
        },
        ""tickangle"": {
          ""description"": ""Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically."",
          ""dflt"": ""auto"",
          ""editType"": ""ticks"",
          ""valType"": ""angle""
        },
        ""tickcolor"": {
          ""description"": ""Sets the tick color."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""tickfont"": {
          ""color"": {
            ""editType"": ""ticks"",
            ""valType"": ""color""
          },
          ""description"": ""Sets the tick font."",
          ""editType"": ""ticks"",
          ""family"": {
            ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
            ""editType"": ""ticks"",
            ""noBlank"": true,
            ""strict"": true,
            ""valType"": ""string""
          },
          ""role"": ""object"",
          ""size"": {
            ""editType"": ""ticks"",
            ""min"": 1,
            ""valType"": ""number""
          }
        },
        ""tickformat"": {
          ""description"": ""Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-format/tree/v1.4.5#d3-format. And for dates see: https://github.com/d3/d3-time-format/tree/v2.2.3#locale_format. We add two items to d3's date formatter: *%h* for half of the year as a decimal number as well as *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*"",
          ""dflt"": """",
          ""editType"": ""ticks"",
          ""valType"": ""string""
        },
        ""tickformatstops"": {
          ""items"": {
            ""tickformatstop"": {
              ""dtickrange"": {
                ""description"": ""range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*"",
                ""editType"": ""ticks"",
                ""items"": [
                  {
                    ""editType"": ""ticks"",
                    ""valType"": ""any""
                  },
                  {
                    ""editType"": ""ticks"",
                    ""valType"": ""any""
                  }
                ],
                ""valType"": ""info_array""
              },
              ""editType"": ""ticks"",
              ""enabled"": {
                ""description"": ""Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`."",
                ""dflt"": true,
                ""editType"": ""ticks"",
                ""valType"": ""boolean""
              },
              ""name"": {
                ""description"": ""When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template."",
                ""editType"": ""none"",
                ""valType"": ""string""
              },
              ""role"": ""object"",
              ""templateitemname"": {
                ""description"": ""Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""value"": {
                ""description"": ""string - dtickformat for described zoom level, the same as *tickformat*"",
                ""dflt"": """",
                ""editType"": ""ticks"",
                ""valType"": ""string""
              }
            }
          },
          ""role"": ""object""
        },
        ""ticklabelmode"": {
          ""description"": ""Determines where tick labels are drawn with respect to their corresponding ticks and grid lines. Only has an effect for axes of `type` *date* When set to *period*, tick labels are drawn in the middle of the period between ticks."",
          ""dflt"": ""instant"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""instant"",
            ""period""
          ]
        },
        ""ticklabeloverflow"": {
          ""description"": ""Determines how we handle tick labels that would overflow either the graph div or the domain of the axis. The default value for inside tick labels is *hide past domain*. Otherwise on *category* and *multicategory* axes the default is *allow*. In other cases the default is *hide past div*."",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""allow"",
            ""hide past div"",
            ""hide past domain""
          ]
        },
        ""ticklabelposition"": {
          ""description"": ""Determines where tick labels are drawn with respect to the axis Please note that top or bottom has no effect on x axes or when `ticklabelmode` is set to *period*. Similarly left or right has no effect on y axes or when `ticklabelmode` is set to *period*. Has no effect on *multicategory* axes or when `tickson` is set to *boundaries*. When used on axes linked by `matches` or `scaleanchor`, no extra padding for inside labels would be added by autorange, so that the scales could match."",
          ""dflt"": ""outside"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""outside"",
            ""inside"",
            ""outside top"",
            ""inside top"",
            ""outside left"",
            ""inside left"",
            ""outside right"",
            ""inside right"",
            ""outside bottom"",
            ""inside bottom""
          ]
        },
        ""ticklabelstep"": {
          ""description"": ""Sets the spacing between tick labels as compared to the spacing between ticks. A value of 1 (default) means each tick gets a label. A value of 2 means shows every 2nd label. A larger value n means only every nth tick is labeled. `tick0` determines which labels are shown. Not implemented for axes with `type` *log* or *multicategory*, or when `tickmode` is *array*."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""min"": 1,
          ""valType"": ""integer""
        },
        ""ticklen"": {
          ""description"": ""Sets the tick length (in px)."",
          ""dflt"": 5,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""tickmode"": {
          ""description"": ""Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided)."",
          ""editType"": ""ticks"",
          ""impliedEdits"": {},
          ""valType"": ""enumerated"",
          ""values"": [
            ""auto"",
            ""linear"",
            ""array""
          ]
        },
        ""tickprefix"": {
          ""description"": ""Sets a tick label prefix."",
          ""dflt"": """",
          ""editType"": ""ticks"",
          ""valType"": ""string""
        },
        ""ticks"": {
          ""description"": ""Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines."",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""outside"",
            ""inside"",
            """"
          ]
        },
        ""tickson"": {
          ""description"": ""Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels."",
          ""dflt"": ""labels"",
          ""editType"": ""ticks"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""labels"",
            ""boundaries""
          ]
        },
        ""ticksuffix"": {
          ""description"": ""Sets a tick label suffix."",
          ""dflt"": """",
          ""editType"": ""ticks"",
          ""valType"": ""string""
        },
        ""ticktext"": {
          ""description"": ""Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`."",
          ""editType"": ""ticks"",
          ""valType"": ""data_array""
        },
        ""ticktextsrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `ticktext`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""tickvals"": {
          ""description"": ""Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`."",
          ""editType"": ""ticks"",
          ""valType"": ""data_array""
        },
        ""tickvalssrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `tickvals`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""tickwidth"": {
          ""description"": ""Sets the tick width (in px)."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""min"": 0,
          ""valType"": ""number""
        },
        ""title"": {
          ""editType"": ""ticks"",
          ""font"": {
            ""color"": {
              ""editType"": ""ticks"",
              ""valType"": ""color""
            },
            ""description"": ""Sets this axis' title font. Note that the title's font used to be customized by the now deprecated `titlefont` attribute."",
            ""editType"": ""ticks"",
            ""family"": {
              ""description"": ""HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*."",
              ""editType"": ""ticks"",
              ""noBlank"": true,
              ""strict"": true,
              ""valType"": ""string""
            },
            ""role"": ""object"",
            ""size"": {
              ""editType"": ""ticks"",
              ""min"": 1,
              ""valType"": ""number""
            }
          },
          ""role"": ""object"",
          ""standoff"": {
            ""description"": ""Sets the standoff distance (in px) between the axis labels and the title text The default value is a function of the axis tick labels, the title `font.size` and the axis `linewidth`. Note that the axis title position is always constrained within the margins, so the actual standoff distance is always less than the set or default value. By setting `standoff` and turning on `automargin`, plotly.js will push the margins to fit the axis title at given standoff distance."",
            ""editType"": ""ticks"",
            ""min"": 0,
            ""valType"": ""number""
          },
          ""text"": {
            ""description"": ""Sets the title of this axis. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated."",
            ""editType"": ""ticks"",
            ""valType"": ""string""
          }
        },
        ""type"": {
          ""_noTemplating"": true,
          ""description"": ""Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question."",
          ""dflt"": ""-"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""-"",
            ""linear"",
            ""log"",
            ""date"",
            ""category"",
            ""multicategory""
          ]
        },
        ""uirevision"": {
          ""description"": ""Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`."",
          ""editType"": ""none"",
          ""valType"": ""any""
        },
        ""visible"": {
          ""description"": ""A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false"",
          ""editType"": ""plot"",
          ""valType"": ""boolean""
        },
        ""zeroline"": {
          ""description"": ""Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines."",
          ""editType"": ""ticks"",
          ""valType"": ""boolean""
        },
        ""zerolinecolor"": {
          ""description"": ""Sets the line color of the zero line."",
          ""dflt"": ""#444"",
          ""editType"": ""ticks"",
          ""valType"": ""color""
        },
        ""zerolinewidth"": {
          ""description"": ""Sets the width (in px) of the zero line."",
          ""dflt"": 1,
          ""editType"": ""ticks"",
          ""valType"": ""number""
        }
      }
    }
  
}";

    }
}
