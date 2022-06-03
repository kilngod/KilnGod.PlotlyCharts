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

namespace KilnGod.PlotlyCharts.Enumerations
{
    public enum TraceTypeOptions
    {
        [Description("bar")]
        Simple_Bar,
        [Description("bubble")]
        Simple_Bubble,
        [Description("barpolar")]
        Specialized_BarPolar,
        [Description("box")]
        Distribution_Box,
        
        [Description("carpet")]
        Specialized_Carpet,
        [Description("choropleth")]
        Maps_Choropleth,
        [Description("choroplethMapBox")]
        Maps_ChoroplethMapBox,
        [Description("cone")]
        ThreeD_Cone,
        [Description("contour")]
        Simple_Contour,
        [Description("contourcarpet")]
        Specialized_ContourCarpet,
        [Description("densitymapbox")]
        Map_DensityMapBox,
        [Description("funnel")]
        Finance_Funnel,
        [Description("funnelarea")]
        Finance_FunnelArea,
        [Description("heatmap")]
        Simple_Heatmap,
        [Description("heatmapgl")]
        Simple_HeatMapGl,
        [Description("histogram")]
        Distribution_Histogram,
        [Description("histogram2d")]
        Distribution_Histogram2D,
        [Description("histogram2dcontour")]
        Distribution_Histogram2DContour,
        [Description("icicle")]
        Specialized_Icicle,
        [Description("image")]
        Simple_Image,
        [Description("indicator")]
        Finance_Indicator,
        [Description("isosurface")]
        ThreeD_IsoSurface,
        [Description("mesh3d")]
        ThreeD_Mesh,      
        [Description("parcats")]
        Specialized_ParCats,
        [Description("parcoords")]
        Specialized_ParCoords,
        [Description("pie")]
        Simple_Pie,
        [Description("pointcloud")]
        Specialized_PointCloud,
        [Description("sankey")]
        Specialized_Sankey,
        [Description("scatter")]
        Simple_Scatter,
        [Description("scatter3d")]
        ThreeD_Scatter3D,
        [Description("scattercarpet")]
        Specialized_ScatterCarpet,
        [Description("scattergeo")]
        Map_ScatterGeo,
        [Description("scattergl")]
        Simple_ScatterGl,
        [Description("scattermapbox")]
        Map_ScatterMapBox,
        [Description("scatterpolar")]
        Specialized_ScatterPolar,
        [Description("scatterpolargl")]
        Specialized_ScatterPolarGl,
        [Description("scattersmith")]
        Specialized_ScatterSmith,
        [Description("scatterternary")]

        Specialized_ScatterTernary,

        [Description("splom")]
        Specialized_Splom,

        [Description("streamtube")]

        ThreeD_StreamTube,
        [Description("sunburst")]

        Specialized_Sunburst,
        [Description("surface")]

        ThreeD_Surface,

        [Description("table")]

        Specialized_Table,
        [Description("treemap")]

        Specialized_TreeMap,
        [Description("violin")]

        Distribution_Violin,
        [Description("volume")]
        ThreeD_Volume, 
        [Description("waterfall")]
        Finance_Waterfall,
        [Description("ohlc")]
        Finance_Ohlc,
        [Description("candlestick")]
        Finance_Candlestick
    }


    

}
