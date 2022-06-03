using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.JsonSchema
{
    public static partial class PlotlySchema
    {
        public const string ConfigSchema = @"
      
{

  ""config"": {
    ""autosizable"": {
      ""description"": ""Determines whether the graphs are plotted with respect to layout.autosize:true and infer its container size."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""displaylogo"": {
      ""description"": ""Determines whether or not the plotly logo is displayed on the end of the mode bar."",
      ""dflt"": true,
      ""valType"": ""boolean""
    },
    ""displayModeBar"": {
      ""description"": ""Determines the mode bar display mode. If *true*, the mode bar is always visible. If *false*, the mode bar is always hidden. If *hover*, the mode bar is visible while the mouse cursor is on the graph container."",
      ""dflt"": ""hover"",
      ""valType"": ""enumerated"",
      ""values"": [
        ""hover"",
        true,
        false
      ]
    },
    ""doubleClick"": {
      ""description"": ""Sets the double click interaction mode. Has an effect only in cartesian plots. If *false*, double click is disable. If *reset*, double click resets the axis ranges to their initial values. If *autosize*, double click set the axis ranges to their autorange values. If *reset+autosize*, the odd double clicks resets the axis ranges to their initial values and even double clicks set the axis ranges to their autorange values."",
      ""dflt"": ""reset+autosize"",
      ""valType"": ""enumerated"",
      ""values"": [
        false,
        ""reset"",
        ""autosize"",
        ""reset+autosize""
      ]
    },
    ""doubleClickDelay"": {
      ""description"": ""Sets the delay for registering a double-click in ms. This is the time interval (in ms) between first mousedown and 2nd mouseup to constitute a double-click. This setting propagates to all on-subplot double clicks (except for geo and mapbox) and on-legend double clicks."",
      ""dflt"": 300,
      ""min"": 0,
      ""valType"": ""number""
    },
    ""editable"": {
      ""description"": ""Determines whether the graph is editable or not. Sets all pieces of `edits` unless a separate `edits` config item overrides individual parts."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""edits"": {
      ""annotationPosition"": {
        ""description"": ""Determines if the main anchor of the annotation is editable. The main anchor corresponds to the text (if no arrow) or the arrow (which drags the whole thing leaving the arrow length & direction unchanged)."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""annotationTail"": {
        ""description"": ""Has only an effect for annotations with arrows. Enables changing the length and direction of the arrow."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""annotationText"": {
        ""description"": ""Enables editing annotation text."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""axisTitleText"": {
        ""description"": ""Enables editing axis title text."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""colorbarPosition"": {
        ""description"": ""Enables moving colorbars."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""colorbarTitleText"": {
        ""description"": ""Enables editing colorbar title text."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""legendPosition"": {
        ""description"": ""Enables moving the legend."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""legendText"": {
        ""description"": ""Enables editing the trace name fields from the legend"",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""role"": ""object"",
      ""shapePosition"": {
        ""description"": ""Enables moving shapes."",
        ""dflt"": false,
        ""valType"": ""boolean""
      },
      ""titleText"": {
        ""description"": ""Enables editing the global layout title."",
        ""dflt"": false,
        ""valType"": ""boolean""
      }
    },
    ""fillFrame"": {
      ""description"": ""When `layout.autosize` is turned on, determines whether the graph fills the container (the default) or the screen (if set to *true*)."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""frameMargins"": {
      ""description"": ""When `layout.autosize` is turned on, set the frame margins in fraction of the graph size."",
      ""dflt"": 0,
      ""max"": 0.5,
      ""min"": 0,
      ""valType"": ""number""
    },
    ""globalTransforms"": {
      ""description"": ""Set global transform to be applied to all traces with no specification needed"",
      ""dflt"": [],
      ""valType"": ""any""
    },
    ""linkText"": {
      ""description"": ""Sets the text appearing in the `showLink` link."",
      ""dflt"": ""Edit chart"",
      ""noBlank"": true,
      ""valType"": ""string""
    },
    ""locale"": {
      ""description"": ""Which localization should we use? Should be a string like 'en' or 'en-US'."",
      ""dflt"": ""en-US"",
      ""valType"": ""string""
    },
    ""locales"": {
      ""description"": ""Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats."",
      ""dflt"": {},
      ""valType"": ""any""
    },
    ""logging"": {
      ""description"": ""Turn all console logging on or off (errors will be thrown) This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no logs 1: warnings and errors, but not informational messages 2: verbose logs"",
      ""dflt"": 1,
      ""max"": 2,
      ""min"": 0,
      ""valType"": ""integer""
    },
    ""mapboxAccessToken"": {
      ""description"": ""Mapbox access token (required to plot mapbox trace types) If using an Mapbox Atlas server, set this option to '' so that plotly.js won't attempt to authenticate to the public Mapbox server."",
      ""dflt"": null,
      ""valType"": ""string""
    },
    ""modeBarButtons"": {
      ""description"": ""Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info."",
      ""dflt"": false,
      ""valType"": ""any""
    },
    ""modeBarButtonsToAdd"": {
      ""description"": ""Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments. To enable predefined modebar buttons e.g. shape drawing, hover and spikelines, simply provide their string name(s). This could include: *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect* and *eraseshape*. Please note that these predefined buttons will only be shown if they are compatible with all trace types used in a graph."",
      ""dflt"": [],
      ""valType"": ""any""
    },
    ""modeBarButtonsToRemove"": {
      ""description"": ""Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names."",
      ""dflt"": [],
      ""valType"": ""any""
    },
    ""notifyOnLogging"": {
      ""description"": ""Set on-graph logging (notifier) level This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no on-graph logs 1: warnings and errors, but not informational messages 2: verbose logs"",
      ""dflt"": 0,
      ""max"": 2,
      ""min"": 0,
      ""valType"": ""integer""
    },
    ""plotGlPixelRatio"": {
      ""description"": ""Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated."",
      ""dflt"": 2,
      ""max"": 4,
      ""min"": 1,
      ""valType"": ""number""
    },
    ""plotlyServerURL"": {
      ""description"": ""When set it determines base URL for the 'Edit in Chart Studio' `showEditInChartStudio`/`showSendToCloud` mode bar button and the showLink/sendData on-graph link. To enable sending your data to Chart Studio Cloud, you need to set both `plotlyServerURL` to 'https://chart-studio.plotly.com' and also set `showSendToCloud` to true."",
      ""dflt"": """",
      ""valType"": ""string""
    },
    ""queueLength"": {
      ""description"": ""Sets the length of the undo/redo queue."",
      ""dflt"": 0,
      ""min"": 0,
      ""valType"": ""integer""
    },
    ""responsive"": {
      ""description"": ""Determines whether to change the layout size when window is resized. In v3, this option will be removed and will always be true."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""scrollZoom"": {
      ""description"": ""Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots."",
      ""dflt"": ""gl3d+geo+mapbox"",
      ""extras"": [
        true,
        false
      ],
      ""flags"": [
        ""cartesian"",
        ""gl3d"",
        ""geo"",
        ""mapbox""
      ],
      ""valType"": ""flaglist""
    },
    ""sendData"": {
      ""description"": ""If *showLink* is true, does it contain data just link to a Chart Studio Cloud file?"",
      ""dflt"": true,
      ""valType"": ""boolean""
    },
    ""setBackground"": {
      ""description"": ""Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it."",
      ""dflt"": ""transparent"",
      ""valType"": ""any""
    },
    ""showAxisDragHandles"": {
      ""description"": ""Set to *false* to omit cartesian axis pan/zoom drag handles."",
      ""dflt"": true,
      ""valType"": ""boolean""
    },
    ""showAxisRangeEntryBoxes"": {
      ""description"": ""Set to *false* to omit direct range entry at the pan/zoom drag points, note that `showAxisDragHandles` must be enabled to have an effect."",
      ""dflt"": true,
      ""valType"": ""boolean""
    },
    ""showEditInChartStudio"": {
      ""description"": ""Same as `showSendToCloud`, but use a pencil icon instead of a floppy-disk. Note that if both `showSendToCloud` and `showEditInChartStudio` are turned, only `showEditInChartStudio` will be honored."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""showLink"": {
      ""description"": ""Determines whether a link to Chart Studio Cloud is displayed at the bottom right corner of resulting graphs. Use with `sendData` and `linkText`."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""showSendToCloud"": {
      ""description"": ""Should we include a ModeBar button, labeled \""Edit in Chart Studio\"", that sends this chart to chart-studio.plotly.com (formerly plot.ly) or another plotly server as specified by `plotlyServerURL` for editing, export, etc? Prior to version 1.43.0 this button was included by default, now it is opt-in using this flag. Note that this button can (depending on `plotlyServerURL` being set) send your data to an external server. However that server does not persist your data until you arrive at the Chart Studio and explicitly click \""Save\""."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""showSources"": {
      ""description"": ""Adds a source-displaying function to show sources on the resulting graphs."",
      ""dflt"": false,
      ""valType"": ""any""
    },
    ""showTips"": {
      ""description"": ""Determines whether or not tips are shown while interacting with the resulting graphs."",
      ""dflt"": true,
      ""valType"": ""boolean""
    },
    ""staticPlot"": {
      ""description"": ""Determines whether the graphs are interactive or not. If *false*, no interactivity, for export or image generation."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""toImageButtonOptions"": {
      ""description"": ""Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js"",
      ""dflt"": {},
      ""valType"": ""any""
    },
    ""topojsonURL"": {
      ""description"": ""Set the URL to topojson used in geo charts. By default, the topojson files are fetched from cdn.plot.ly. For example, set this option to: <path-to-plotly.js>/dist/topojson/ to render geographical feature using the topojson files that ship with the plotly.js module."",
      ""dflt"": ""https://cdn.plot.ly/"",
      ""noBlank"": true,
      ""valType"": ""string""
    },
    ""typesetMath"": {
      ""description"": ""Determines whether math should be typeset or not, when MathJax (either v2 or v3) is present on the page."",
      ""dflt"": true,
      ""valType"": ""boolean""
    },
    ""watermark"": {
      ""description"": ""watermark the images with the company's logo"",
      ""dflt"": false,
      ""valType"": ""boolean""
    }
  }
}";

    }
}
