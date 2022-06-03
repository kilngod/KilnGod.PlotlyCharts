using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.JsonSchema
{
    public static partial class PlotlySchema
    {
        public const string DefsSchema = @"
{

  ""defs"": {
    ""editType"": {
      ""layout"": {
        ""description"": ""layout attributes should include an `editType` string matching this flaglist. *calc* is the most extensive: a full (re)plot starting by clearing `gd.calcdata` to force it to be regenerated *plot* (re)plots but without first clearing `gd.calcdata`. *legend* only redraws the legend. *ticks* only redraws axis ticks, labels, and gridlines. *axrange* minimal sequence when updating axis ranges. *layoutstyle* reapplies global and SVG cartesian axis styles. *modebar* just updates the modebar. *camera* just updates the camera settings for gl3d scenes. *arraydraw* allows component arrays to invoke the redraw routines just for the component(s) that changed. *colorbars* only redraws colorbars."",
        ""extras"": [
          ""none""
        ],
        ""flags"": [
          ""calc"",
          ""plot"",
          ""legend"",
          ""ticks"",
          ""axrange"",
          ""layoutstyle"",
          ""modebar"",
          ""camera"",
          ""arraydraw"",
          ""colorbars""
        ],
        ""valType"": ""flaglist""
      },
      ""traces"": {
        ""description"": ""trace attributes should include an `editType` string matching this flaglist. *calc* is the most extensive: a full (re)plot starting by clearing `gd.calcdata` to force it to be regenerated *clearAxisTypes* resets the types of the axes this trace is on, because new data could cause the automatic axis type detection to change. Log type will not be cleared, as that is never automatically chosen so must have been user-specified. *plot* (re)plots but without first clearing `gd.calcdata`. *style* only calls `module.style` (or module.editStyle) for all trace modules and redraws the legend. *markerSize* is like *style*, but propagate axis-range changes due to scatter `marker.size` *colorbars* only redraws colorbars."",
        ""extras"": [
          ""none""
        ],
        ""flags"": [
          ""calc"",
          ""clearAxisTypes"",
          ""plot"",
          ""style"",
          ""markerSize"",
          ""colorbars""
        ],
        ""valType"": ""flaglist""
      }
    },
    ""impliedEdits"": {
      ""description"": ""Sometimes when an attribute is changed, other attributes must be altered as well in order to achieve the intended result. For example, when `range` is specified, it is important to set `autorange` to `false` or the new `range` value would be lost in the redraw. `impliedEdits` is the mechanism to do this: `impliedEdits: {autorange: false}`. Each key is a relative paths to the attribute string to change, using *^* to ascend into the parent container, for example `range[0]` has `impliedEdits: {*^autorange*: false}`. A value of `undefined` means that the attribute will not be changed, but its previous value should be recorded in case we want to reverse this change later. For example, `autorange` has `impliedEdits: {*range[0]*: undefined, *range[1]*:undefined} because the range will likely be changed by redraw.""
    },
    ""metaKeys"": [
      ""_isSubplotObj"",
      ""_isLinkedToArray"",
      ""_arrayAttrRegexps"",
      ""_deprecated"",
      ""description"",
      ""role"",
      ""editType"",
      ""impliedEdits""
    ],
    ""valObjects"": {
      ""angle"": {
        ""description"": ""A number (in degree) between -180 and 180."",
        ""otherOpts"": [
          ""dflt""
        ],
        ""requiredOpts"": []
      },
      ""any"": {
        ""description"": ""Any type."",
        ""otherOpts"": [
          ""dflt"",
          ""values"",
          ""arrayOk""
        ],
        ""requiredOpts"": []
      },
      ""boolean"": {
        ""description"": ""A boolean (true/false) value."",
        ""otherOpts"": [
          ""dflt""
        ],
        ""requiredOpts"": []
      },
      ""color"": {
        ""description"": ""A string describing color. Supported formats: - hex (e.g. '#d3d3d3') - rgb (e.g. 'rgb(255, 0, 0)') - rgba (e.g. 'rgb(255, 0, 0, 0.5)') - hsl (e.g. 'hsl(0, 100%, 50%)') - hsv (e.g. 'hsv(0, 100%, 100%)') - named colors (full list: http://www.w3.org/TR/css3-color/#svg-color)"",
        ""otherOpts"": [
          ""dflt"",
          ""arrayOk""
        ],
        ""requiredOpts"": []
      },
      ""colorlist"": {
        ""description"": ""A list of colors. Must be an {array} containing valid colors."",
        ""otherOpts"": [
          ""dflt""
        ],
        ""requiredOpts"": []
      },
      ""colorscale"": {
        ""description"": ""A Plotly colorscale either picked by a name: (any of Greys, YlGnBu, Greens, YlOrRd, Bluered, RdBu, Reds, Blues, Picnic, Rainbow, Portland, Jet, Hot, Blackbody, Earth, Electric, Viridis, Cividis ) customized as an {array} of 2-element {arrays} where the first element is the normalized color level value (starting at *0* and ending at *1*), and the second item is a valid color string."",
        ""otherOpts"": [
          ""dflt""
        ],
        ""requiredOpts"": []
      },
      ""data_array"": {
        ""description"": ""An {array} of data. The value MUST be an {array}, or we ignore it. Note that typed arrays (e.g. Float32Array) are supported."",
        ""otherOpts"": [
          ""dflt""
        ],
        ""requiredOpts"": []
      },
      ""enumerated"": {
        ""description"": ""Enumerated value type. The available values are listed in `values`."",
        ""otherOpts"": [
          ""dflt"",
          ""coerceNumber"",
          ""arrayOk""
        ],
        ""requiredOpts"": [
          ""values""
        ]
      },
      ""flaglist"": {
        ""description"": ""A string representing a combination of flags (order does not matter here). Combine any of the available `flags` with *+*. (e.g. ('lines+markers')). Values in `extras` cannot be combined."",
        ""otherOpts"": [
          ""dflt"",
          ""extras"",
          ""arrayOk""
        ],
        ""requiredOpts"": [
          ""flags""
        ]
      },
      ""info_array"": {
        ""description"": ""An {array} of plot information."",
        ""otherOpts"": [
          ""dflt"",
          ""freeLength"",
          ""dimensions""
        ],
        ""requiredOpts"": [
          ""items""
        ]
      },
      ""integer"": {
        ""description"": ""An integer or an integer inside a string. When applicable, values greater (less) than `max` (`min`) are coerced to the `dflt`."",
        ""otherOpts"": [
          ""dflt"",
          ""min"",
          ""max"",
          ""arrayOk""
        ],
        ""requiredOpts"": []
      },
      ""number"": {
        ""description"": ""A number or a numeric value (e.g. a number inside a string). When applicable, values greater (less) than `max` (`min`) are coerced to the `dflt`."",
        ""otherOpts"": [
          ""dflt"",
          ""min"",
          ""max"",
          ""arrayOk""
        ],
        ""requiredOpts"": []
      },
      ""string"": {
        ""description"": ""A string value. Numbers are converted to strings except for attributes with `strict` set to true."",
        ""otherOpts"": [
          ""dflt"",
          ""noBlank"",
          ""strict"",
          ""arrayOk"",
          ""values""
        ],
        ""requiredOpts"": []
      },
      ""subplotid"": {
        ""description"": ""An id string of a subplot type (given by dflt), optionally followed by an integer >1. e.g. if dflt='geo', we can have 'geo', 'geo2', 'geo3', ..."",
        ""otherOpts"": [
          ""regex""
        ],
        ""requiredOpts"": [
          ""dflt""
        ]
      }
    }
  }
}
"; 
    
    }
}
