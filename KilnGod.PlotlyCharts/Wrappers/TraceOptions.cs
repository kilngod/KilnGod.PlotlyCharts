//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TraceTypeOptions.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Wrappers
{
    public enum TraceOptions
    {
        [Description("bar")]
        Bar,
        [Description("bubble")]
        Bubble,
        [Description("barpolar")]
        BarPolar,
        [Description("box")]
        Box,

        [Description("carpet")]
        Carpet,
        [Description("choropleth")]
        Choropleth,
        [Description("choroplethmapbox")]
        ChoroplethMapbox,
        [Description("cone")]
        Cone,
        [Description("contour")]
        Contour,
        [Description("contourcarpet")]
        ContourCarpet,
        [Description("densitymapbox")]
        DensityMapbox,
        [Description("funnel")]
        Funnel,
        [Description("funnelarea")]
        FunnelArea,
        [Description("heatmap")]
        Heatmap,

        [Description("heatmapgl")]
        HeatmapGL,
        [Description("histogram")]
        Histogram,
        [Description("histogram2d")]
        Histogram2D,
        [Description("histogram2dcontour")]
        Histogram2DContour,
        [Description("icicle")]
        Icicle,
        // not sure this is a thing
        [Description("image")]
        Image,
        [Description("indicator")]
        Indicator,
        [Description("isosurface")]
        IsoSurface,
        [Description("mesh3d")]
        Mesh3D,
        [Description("parcats")]
        ParallelCategories,
        [Description("parcoords")]
        ParallelCoordinates,
        [Description("pie")]
        Pie,
        [Description("pointcloud")]
        PointCloud,
        [Description("sankey")]
        Sankey,
        [Description("scatter")]
        Scatter,
        [Description("scatter3d")]
        Scatter3D,
        [Description("scattercarpet")]
        ScatterCarpet,
        [Description("scattergeo")]
        ScatterGeo,
        [Description("scattergl")]
        ScatterGL,
        [Description("scattermapbox")]
        ScatterMapbox,
        [Description("scatterpolar")]
        ScatterPolar,
        [Description("scatterpolargl")]
        ScatterPolarGL,
        [Description("scattersmith")]
        ScatterSmith,
        [Description("scatterternary")]

        ScatterTernary,

        [Description("splom")]
        Splom,

        [Description("streamtube")]

        StreamTube,
        [Description("sunburst")]

        Sunburst,
        [Description("surface")]

        Surface,

        [Description("table")]

        Table,
        [Description("treemap")]

        Treemap,
        [Description("violin")]

        Violin,
        [Description("volume")]
        Volume,
        [Description("waterfall")]
        Waterfall,
        [Description("ohlc")]
        Ohlc,
        [Description("candlestick")]
        Candlestick
    }




}
