//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlySourceGen.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.Text.Json;
using KilnGod.PlotlyCharts.DemoTest.SchemaReview;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Linq;
using KilnGod.PlotlyCharts.Services;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;

namespace KilnGod.PlotlyCharts.DemoTest.Pages
{
    public partial class PlotlySourceGen
    {

        protected ElementReference _textArea1;



        public ElementReference textArea => this._textArea1;


        [Inject]
        public IWebfileRepository? Webfile { get; set; }

        protected string AreaText { get; set; } = string.Empty;


        public string SchemaNode { get; set; } = "traces";

        public bool DisabledButtons { get; set; } = true;

        public string OutputFolder { get; set; } = "!PlotlyCode";  // <- only blazor server compliant.


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (Webfile != null)
                {
                    string? jsonschema = await Webfile.DownloadText("https://localhost:7132/_content/KilnGod.PlotlyCharts.DemoTest/plot-schema.json");
                    AreaText = jsonschema != null ? jsonschema : string.Empty;
                }

                DisabledButtons = false;
                StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }



        public List<SchemaItem> SchemaTree = new List<SchemaItem>();

        public List<MapNameType> ClassList = new List<MapNameType>();

        public List<MapNameType> EnumList = new List<MapNameType>();

        public void GenerateSource()
        {


            string value = FuncOptions.Range.GetDescription();
            JsonDocument doc = JsonDocument.Parse(AreaText);


            List<MapNameType> names = new List<MapNameType>();

            foreach (var item in doc.RootElement.EnumerateObject())
            {
                SchemaItem head = new SchemaItem() { RootItemType = item.Name, Name = item.Name, CsType = item.Name };
                SchemaTree.Add(head);
                MapSchema(head, item.Value);


                MapNames(head, names, item.Name);
              //  break;
            }

            string namelist = "";

            for (int i = 0; i < names.Count; i++)
            {
                MapNameType name = names[i];
                FixClassNames(ref name);
                if (name.IsEnumeration)
                {
                    EnumList.Add(name);
                } 
                else if (!string.IsNullOrWhiteSpace( name.ClassTypeName) && name.HasChildren && name.Name != "traces" && name.Name != "transforms")// && name.Name != "traces" )
                {
                    ClassList.Add(name);

                }
            }


            names = ClassList.OrderBy(x => x.PropertyName).ThenBy(x => MapNameType.ChildCount(x)).ToList();

            string reasons = string.Empty;

            for (int i = 1; i < names.Count; i++)
            {
                MapNameType priorName = names[i - 1];
                MapNameType name = names[i];

                bool isDifferentClass = false;
                string reason = string.Empty;
                if (name.ClassTypeName == priorName.ClassTypeName)
                {
                    if (name.item.Children.Count != priorName.item.Children.Count)
                    {
                        isDifferentClass = true;
                        reason = "property count is different";
                    }
                    else if (name.item.Children.Count>0) 
                    { 
                        foreach(var child in name.item.Children)
                        {
                            var mia = priorName.item.Children.Find(x => x.Name == child.Name);

                            if (mia == null)
                            {
                                isDifferentClass = true;
                                reason = "property not found: " + child.Name;
                            }
                        }
                    }

                    if (isDifferentClass)
                    {
                        reasons = reasons+ System.Environment.NewLine + name.PropertyName + " " + name.Name + " != " + priorName.Name + " : " + reason;
                    }
                }
                
            }


            /*

            for (int i = 0; i < names.Count; i++)
            {
                MapNameType name = names[i];
                namelist += "\t\t\t\tnew MapNameType(){PropertyName=\""+name.PropertyName+ "\", ClassTypeName=\"" + name.ClassTypeName + "\", OriginalName=\"" + name.OriginalName + "\", FileName=\""+name.FileName+ "\", SchemaSection=\"" + name.SchemaSection + "\", JsonType=\"" + name.JsonType + "\", Name = \"" + name.Name + "\"}," + System.Environment.NewLine;
            }
            
            */
            AreaText = reasons;
            

        }


        public void MapNames(SchemaItem node, List<MapNameType> names, string schemaSection)
        {
            if (node.Name.IndexOf("src")>0)
            {
                return;
            }

            MapNameType name = new MapNameType()
            {
                Name = node.Name,

                PropertyName = CamelCaseName(node.Name),

                OriginalName = node.Name,

                SchemaSection = schemaSection,

                JsonType = node.ElementType.ToString(),

                HasChildren = node.Children.Count > 0,

                IsEnumeration = node.Enumeration != null && node.Enumeration.Count > 0 ? true : false,
                
                item = node

            };

            node.map = name;

            if (name.IsEnumeration)
            {
                name.ClassTypeName = name.PropertyName + "Options";
            } else if (name.HasChildren)
            {
                if (node.Parent != null && node.Parent.Name == "traces")
                {
                    name.ClassTypeName = name.PropertyName + "Trace";
                }
                else
                {
                    name.ClassTypeName = name.PropertyName + "Info";
                }
            }
            if (!string.IsNullOrEmpty(name.ClassTypeName))
            {
                name.FileName = name.ClassTypeName + ".cs";
            }

            if (node.Parent != null)// && node.Parent.Name != "attributes")
            {
                name.Name = node.Parent.Name +"." + name.Name;

                if (node.Parent.Parent != null)// && node.Parent.Parent.Name != "attributes")
                {
                    name.Name = node.Parent.Parent.Name + "." + name.Name;
                }
            }

            if (name.JsonType == "infoArrayOption" && !string.IsNullOrEmpty(name.ClassTypeName))
            {
                name.ClassTypeName = string.Empty;
                name.FileName = String.Empty;
                name.HasChildren = false;
                name.item.Children.Clear();
                name.item.ElementType = SchemaElementType.objectOption;
                name.IsEnumeration = false;
                name.JsonType = SchemaElementType.objectOption.ToString();

            }

            if (names.FindIndex(x => x.Name == name.Name) <0)
            {
                names.Add(name);
            }

            foreach(SchemaItem child in node.Children)
            {
                MapNames(child, names, schemaSection);
            }
        }


        public void MapSchema(SchemaItem node, JsonElement root)
        {
            bool isItems = node.Name == "items";
            JsonElement valType;
            bool isArray = false;
            bool useParent = false;
            if (root.ValueKind != JsonValueKind.String)
            {
                if (root.TryGetProperty("valType", out valType))
                {
                    switch (valType.ToString())
                    {
                        case "string":
                        case "number":
                        case "enumerated":
                        case "color":
                        case "integer":
                        case "any":
                        case "colorscale":
                        case "colorlist":
                        case "angle":
                        case "flaglist":
                        case "boolean":

                            isArray = false;
                            break;

                        default:
                            isArray = true;
                            break;
                    }

                }
            }
            else if (isItems)
            {
                isArray = true;
                useParent = true;
            }

            if (root.ValueKind == JsonValueKind.Array || (isItems && isArray))
            {


                if (root.ValueKind == JsonValueKind.Array)
                {
                    SchemaItem schemaItem = new SchemaItem() { Name = LookupName(node.Name, node), ElementType = SchemaElementType.arrayOption, Parent = node, Description = "Array Element" };
                    //  CheckTypeName(schemaItem);
                    node.Children.Add(schemaItem);

                    foreach (JsonElement element in root.EnumerateArray())
                    {

                        MapSchema(schemaItem, element);
                    }
                }
                else if (useParent && node.Parent != null)
                {
                    node = node.Parent;
                    node.Children.Clear();
                    node.Name = LookupName(node.Name, node);
                    node.CsType = LookupName(node.CsType, node);
                    node.ElementType = SchemaElementType.arrayOption;

                    foreach (JsonProperty prop in root.EnumerateObject())
                    {
                      
                        MapSchema(node, prop.Value);
                    }

                }
                else
                {
                    node.ElementType = SchemaElementType.arrayOption;


                    foreach (JsonProperty prop in root.EnumerateObject())
                    {
                        if (node.Name.EndsWith("src"))
                        {
                            continue;
                        }

                        node.Name = LookupName(prop.Name, node);
                        node.CsType = LookupName(prop.Name, node);

                        MapSchema(node, prop.Value);
                    }
                }
            }
            else
            {
                SchemaElementType propType = SchemaElementType.unknownOption;

                switch (root.ValueKind)
                {
                    case JsonValueKind.Array:
                        propType = SchemaElementType.arrayOption;
                        break;
                    case JsonValueKind.Object:
                        propType = SchemaElementType.objectOption;
                        break;
                    case JsonValueKind.Undefined:
                        propType = SchemaElementType.unknownOption;
                        break;
                    case JsonValueKind.String:
                        propType = SchemaElementType.stringOption;
                        break;
                    case JsonValueKind.Number:
                        propType = SchemaElementType.numberOption;
                        break;
                    case JsonValueKind.False:
                        propType = SchemaElementType.boolOption;
                        break;
                    case JsonValueKind.True:
                        propType = SchemaElementType.boolOption;
                        break;
                    case JsonValueKind.Null:
                        propType = SchemaElementType.nullOption;
                        break;

                    default:
                        break;
                }



                string description = string.Empty;


                List<string>? enumeration = null;
                string name = root.ToString();

                JsonElement? objectValue = null;
                switch (root.ValueKind)
                {
                    case JsonValueKind.String:

                        break;
                    default:

                        foreach (JsonProperty prop in root.EnumerateObject())
                        {
                            if (prop.Name.EndsWith("src"))
                            {
                                continue;
                            }


                            if (prop.Name.IndexOf('_') == 0)
                            {
                                continue;
                            }


                            if (prop.Value.ValueKind == JsonValueKind.Object)
                            {
                                objectValue = prop.Value;

                                if (objectValue.HasValue && prop.Name != "impliedEdits")
                                {


                                    SchemaItem simpleItem = new SchemaItem() { ElementType = propType, Name = prop.Name, CsType = LookupClassName(prop.Name, node), Parent = node, Description = description };
                                    if (prop.Name == "yaxis" && node.CsType.ToLower() == "rangeslider")
                                    {
                                        simpleItem.ElementType = SchemaElementType.classOption;
                                    }


                                  //  CheckTypeName(simpleItem);
                                    node.Children.Add(simpleItem);
                                    MapSchema(simpleItem, objectValue.Value);

                                }

                            }

                            if (prop.Name == "impliedEdits")
                            {

                                node.EditTypeDecorator = prop.Value.ToString();

                                continue;
                            }
                            else if (prop.Name == "valType")
                            {
                                string jsontype = prop.Value.ToString();

                                switch (jsontype)
                                {
                                    case "angle":
                                        propType = SchemaElementType.angleOption;
                                        break;
                                    case "colorscale":
                                        propType = SchemaElementType.colorScaleOption;
                                        break;
                                    case "colorlist":
                                        propType = SchemaElementType.colorListOption;
                                        break;

                                    case "info_array":
                                        propType = SchemaElementType.infoArrayOption;
                                        break;
                                    case "data_array":
                                        propType = SchemaElementType.dataArrayOption;
                                        break;

                                    case "color":
                                        propType = SchemaElementType.colorOption;
                                        break;
                                    case "string":
                                        propType = SchemaElementType.stringOption;
                                        break;

                                    case "boolean":
                                        propType = SchemaElementType.boolOption;
                                        break;
                                    case "enumerated":
                                        propType = SchemaElementType.enumOption;
                                        break;
                                    case "flaglist":
                                        propType = SchemaElementType.flagListOption;
                                        break;
                                    case "integer":
                                        propType = SchemaElementType.intOption;
                                        break;
                                    case "any":
                                        propType = SchemaElementType.anyOption;
                                        break;

                                    case "number":
                                        propType = SchemaElementType.doubleOption;
                                        break;
                                    case "role":
                                        if (node.Name != "impliedEdits")
                                        {
                                            propType = SchemaElementType.classOption;
                                        }
                                        break;
                                    case "type":
                                        propType = SchemaElementType.classOption;

                                        break;
                                    case "subplotid":
                                        propType = SchemaElementType.subplotIdOption;

                                        break;
                                    default:

                                        break;
                                }


                                node.ElementType = propType;
                            }
                            else if (prop.Name == "description")
                            {
                                node.Description = prop.Value.ToString();

                            }
                            else if (prop.Name == "flags")
                            {
                                JsonElement flagsInfo = prop.Value;
                                enumeration = new List<string>();
                                foreach (var item in flagsInfo.EnumerateArray())
                                {
                                    string value = item.ToString();
                                    enumeration.Add(value);
                                }

                                node.Enumeration = enumeration;

                            }
                            else if (prop.Name == "values" && prop.Value.ValueKind == JsonValueKind.Array && propType != SchemaElementType.infoArrayOption)
                            {
                                // an array of string
                                JsonElement enumItems = prop.Value;
                                enumeration = new List<string>();

                                foreach (var item in enumItems.EnumerateArray())
                                {
                                    string value = item.ToString();
                                    enumeration.Add(value);
                                }

                                node.Enumeration = enumeration;

                            }
                            else if (prop.Name == "editType")
                            {
                                node.EditTypeDecorator = prop.Value.ToString();
                            }
                            else if (prop.Name == "dflt")
                            {
                                node.DfltDecorator = prop.Value.ToString();
                            }


                        }
                        break;
                }

                if (node.Enumeration != null && node.Enumeration.Count > 0 && node.ElementType != SchemaElementType.enumOption)
                {
                    node.ElementType = SchemaElementType.enumOption;
                }

                

            }





        }

        public void FixClassNames(ref MapNameType node)
        {
            if (node.PropertyName == "Items")
            {
                node.ClassTypeName = string.Empty;
                node.FileName = string.Empty;
                node.JsonType = "ItemsList";
            }
            else if (node.item != null && (node.item.ElementType == SchemaElementType.doubleOption || node.item.ElementType == SchemaElementType.stringOption || node.item.ElementType == SchemaElementType.anyOption))
            {
                node.ClassTypeName = string.Empty;
                node.FileName = string.Empty;
                node.JsonType = node.item.ElementType.ToString(); 
            }           
            switch (node.Name)
            {
                case "scattergeo.attributes.line":
                case "scatterpolargl.attributes.line":
                    node.ClassTypeName = "RadialLineInfo";
                    node.FileName = "RadialLineInfo.cs";
                    break;

                case "totals.marker.line":
                case "attributes.marker.line":
                    node.ClassTypeName = "MarkerLineInfo";
                    node.FileName = "MarkerLineInfo.cs";
                    break;
                case "scatterternary.attributes.line":
                    node.ClassTypeName = "TernaryLineInfo";
                    node.FileName = "TernaryLineInfo.cs";
                    break;

                case "ohlc.attributes.line":
                case "candlestick.attributes.line":
                    node.ClassTypeName = "FinanceLineInfo";
                    node.FileName = "FinanceLineInfo.cs";
                    break;

                case "attributes.decreasing.marker":
                    node.ClassTypeName = "ChangeMarkerInfo";
                    node.FileName = "ChangeMarkerInfo.cs";
                    break;
                case "scattergeo.attributes.marker":
                case "choroplethmapbox.attributes.marker":
                    node.ClassTypeName = "GeoMarkerInfo";
                    node.FileName = "GeoMarkerInfo.cs";
                    break;
                case "attributes.selected.marker":
                case "attributes.unselected.marker":
                    node.ClassTypeName = "MarkerSelectionInfo";
                    node.FileName = "MarkerSelectionInfo.cs";
                    break;

                case "indicator.attributes.title":
                    node.ClassTypeName = "IndicatorTitleInfo";
                    node.FileName = "IndicatorTitleInfo.cs";
                    break;
                case "pie.attributes.title":
                    node.ClassTypeName = "PieTitleInfo";
                    node.FileName = "PieTitleInfo.cs";
                    break;

                case "layoutAttributes.legend.title":
                    node.ClassTypeName = "LegendTitleInfo";
                    node.FileName = "LegendTitleInfo.cs";
                    break;

                case "bar.attributes.selected":
                case "bar.attributes.unselected":
                    node.ClassTypeName = "BarSelectionInfo";
                    node.FileName = "BarSelectionInfo.cs";
                    break;

                case "violin.attributes.selected":
                case "violin.attributes.unselected":
                    node.ClassTypeName = "ViolinSelectionInfo";
                    node.FileName = "ViolinSelectionInfo.cs";
                    break;

                case "scatter3d.attributes.projection":
        
                       node.ClassTypeName = "Scatter3DProjection";
                       node.FileName = "Scatter3DProjection.cs";
                       break;
                case "ohlc.attributes.decreasing":
                case "candlestick.attributes.decreasing":
                case "ohlc.attributes.increasing":
                case "candlestick.attributes.increasing":
                    node.ClassTypeName = "FinanceChangeInfo";
                    node.FileName = "FinanceChangeInfo.cs";
                    break;
                case "layer.symbol.textfont":
                    node.ClassTypeName = "FontInfo";
                    node.FileName = "FontInfo.cs";
                    break;

                case "waterfall.attributes.decreasing":
                case "waterfall.attributes.increasing":
                    node.ClassTypeName = "WaterfallChangeInfo";
                    node.FileName = "WaterfallChangeInfo.cs";
                    break;

                case "attributes.delta.decreasing":
                case "attributes.delta.increasing":
                    node.ClassTypeName = "AreaChangeInfo";
                    node.FileName = "AreaChangeInfo.cs";
                    break;

                case "items.annotation.hoverlabel":
                    node.ClassTypeName = "AnnotationHoverLabelInfo";
                    node.FileName = "AnnotationHoverLabelInfo.cs";
                    break;

                case "layout.layoutAttributes.hoverlabel":
                    node.ClassTypeName = "LayoutHoverLabelInfo";
                    node.FileName = "LayoutHoverLabelInfo.cs";
                    break;

                case "coloraxis.colorbar.title":
                case "marker.colorbar.title":
                case "attributes.colorbar.title":
                case "line.colorbar.title":
                    node.ClassTypeName = "ColorbarTitleInfo";
                    node.FileName = "ColorbarTitleInfo.cs";
                    break;
                case "icicle.attributes.tiling":
                    node.ClassTypeName = "IcicleTilingInfo";
                    node.FileName = "IcicleTilingInfo.cs";
                    break;

                case "treemap.attributes.tiling":
                    node.ClassTypeName = "TreemapTilingInfo";
                    node.FileName = "TreemapTilingInfo.cs";
                    break;

                case "animation.transition":
                    node.ClassTypeName = "AnimationTransitionInfo";
                    node.FileName = "AnimationTransitionInfo.cs";
                    break;

                case "attributes.cells.fill":
                    node.ClassTypeName = "CellFillInfo";
                    node.FileName = "CellFillInfo.cs";
                    break;

                case "layoutAttributes.geo.domain":
                    node.ClassTypeName = "GeoDomainInfo";
                    node.FileName = "GeoDomainInfo.cs";
                    break;
                case "scatter3d.attributes.error_x":
                case "scatter3d.attributes.error_y":
                case "scatter3d.attributes.error_z":
                    node.ClassTypeName = "Scatter3DErrorInfo";
                    node.FileName = "Scatter3DErrorInfo.cs";
                    break;

                case "scene.camera.center":
                    node.ClassTypeName = "CameraCenterInfo";
                    node.FileName = "CameraCenterInfo.cs";
                    break;

                case "transforms.sort.attributes":
               
                    node.ClassTypeName = "SortAttributesInfo";
                    node.FileName = "SortAttributesInfo.cs";
                    break;
                case "transforms.groupby.attributes":
                    node.ClassTypeName = "GroupByAttributesInfo";
                    node.FileName = "GroupByAttributesInfo.cs";
                    break;

                case "xaxis.rangeslider.yaxis":
                    node.ClassTypeName = "RangeSliderAxisInfo";
                    node.FileName = "RangeSliderAxisInfo.cs";
                    break;
                case "attributes.gauge.axis":
                    node.ClassTypeName = "GaugeAxisInfo";
                    node.FileName = "GaugeAxisInfo.cs";
                    break;
                case "items.dimension.axis":
                    node.ClassTypeName = "DimensionAxisInfo";
                    node.FileName = "DimensionAxisInfo.cs";
                    break;
                case "carpet.attributes.baxis":
                case "carpet.attributes.aaxis":
                case "carpet.attributes.caxis":
                    node.ClassTypeName = "CarpetAxisInfo";
                    node.FileName = "CarpetAxisInfo.cs";
                    break;

                case "cone.attributes.lightposition":
                case "isosurface.attributes.lightposition":
                case "mesh3d.attributes.lightposition":
                case "streamtube.attributes.lightpositio":
                case "surface.attributes.lightposition":
                case "volume.attributes.lightposition":
                case "scene.camera.eye":
                case "streamtube.attributes.starts":

                    node.ClassTypeName = "PositionInfo";
                    node.FileName = "PositionInfo.cs";
                    break;
                case "items.slider.steps":
                    node.ClassTypeName = "SliderSteps";
                    node.FileName = "SliderSteps.cs";
                    break;
                case "attributes.gauge.steps":
                    node.ClassTypeName = "GaugeSteps";
                    node.FileName = "GaugeSteps.cs";
                    break;

                case "histogram.attributes.xbins":
                case "histogram2d.attributes.xbins":
                case "histogram2dcontour.attributes.xbins":
                case "histogram.attributes.ybins":
                case "histogram2d.attributes.ybins":
                case "histogram2dcontour.attributes.ybins":
                case "histogram.attributes.zbins":
                case "histogram2d.attributes.zbins":
                case "histogram2dcontour.attributes.zbins":
                    node.ClassTypeName = "BinsInfo";
                    node.FileName = "BinsInfo.cs";
                    break;

                case "attributes.slices.x":
                case "attributes.slices.y":
                case "attributes.slices.z":
                    node.ClassTypeName = "SlicesRenderInfo";
                    node.FileName = "SlicesRenderInfo.cs";
                    break;

                case "attributes.projection.x":
                case "attributes.projection.y":
                case "attributes.projection.z":
                    node.ClassTypeName = "ProjectionRenderInfo";
                    node.FileName = "ProjectionRenderInfo.cs";
                    break;

                case "attributes.contours.z":
                case "attributes.contours.x":
                case "attributes.contours.y":
                    node.ClassTypeName = "ContoursRenderInfo";
                    node.FileName = "ContoursRenderInfo.cs";
                    break;
                case "attributes.caps.z":
                case "attributes.caps.x":
                case "attributes.caps.y":
                    node.ClassTypeName = "CapRenderInfo";
                    node.FileName = "CapRenderInfo.cs";
                    break;

                case "layoutAttributes.geo.lataxis":
                case "layoutAttributes.geo.lonaxis":
                    node.ClassTypeName = "GeoAxisInfo";
                    node.FileName = "GeoAxisInfo.cs";
                    break;

                case "layoutAttributes.ternary.aaxis":
                case "layoutAttributes.ternary.baxis":
                case "layoutAttributes.ternary.caxis":
                    node.ClassTypeName = "TernaryAxisInfo";
                    node.FileName = "TernaryAxisInfo.cs";
                    break;
                case "layoutAttributes.scene.xaxis":
                case "layoutAttributes.scene.yaxis":
                case "layoutAttributes.scene.zaxis":
                    node.ClassTypeName = "SceneAxisInfo";
                    node.FileName = "SceneAxisInfo.cs";
                    break;

                case "layout.layoutAttributes.xaxis":
                case "layout.layoutAttributes.yaxis":
                case "layout.layoutAttributes.zaxis":
                    node.ClassTypeName = "LayoutAxisInfo";
                    node.FileName = "LayoutAxisInfo.cs";
                    break;

            }
        }



        public string CamelCaseName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return string.Empty;
            }
            switch (name)
            {
                case "da":
                name = "DA";
                    break;
                case "dr":
                    name = "DR";
                    break;
                case "db":
                    name = "DB";
                    break;
                case "dx":
                    name = "DX";
                    break;
                case "dy":
                    name = "DY";
                    break;
                case "ids":
                    name = "IDs";
                    break;
                case "sd":
                    name = "SD";
                    break;
                case "imag":
                    name = "Imaginary";
                    break;
            }

            name = name.Replace("2d", "2D")
                .Replace("3d", "3D")
                .Replace("align", "Align")
                .Replace("align", "Align")
                .Replace("accesstoken", "AccessToken")        
                .Replace("alphahull", "AlphaHull")
                .Replace("anchor", "Anchor")
                .Replace("angle", "Angle")
                .Replace("arearatio", "AreaRatio")
                .Replace("area", "Area")
                .Replace("array", "Array")
                .Replace("aspectratio", "AspectRatio")

                .Replace("attribution", "Attribution")
                .Replace("auto", "Auto")
                .Replace("axis", "Axis")
                .Replace("axes", "Axes")
                .Replace("axref", "AXRef")
                .Replace("ayref", "AYRef")
                .Replace("background", "Background")
                .Replace("bar", "Bar")
                .Replace("nbinsx", "NBinsX")
                .Replace("nbinsy", "NBinsY")
                .Replace("bin", "Bin")
                .Replace("bordercolor", "BorderColor")
                .Replace("borderwidth", "BorderWidth")
                .Replace("bounds", "Bounds")
                .Replace("break", "Break")                
                .Replace("calendar", "Calendar")
                .Replace("captureevents", "CaptureEvents")
                .Replace("carpet", "Carpet")
                .Replace("click", "Click")
                .Replace("cloud", "Cloud")
                .Replace("colorlist", "ColorList")
                .Replace("color", "Color")
                .Replace("columnorder", "ColumnOrder")
                .Replace("contour", "Contour")
                .Replace("count", "Count")
                .Replace("current", "Current")
                .Replace("customdata", "CustomData")
                .Replace("dash", "Dash")
                .Replace("direction", "Direction")
                .Replace("distance", "Distance")
                .Replace("double", "Double")
                
                .Replace("dtick", "DTick")
                .Replace("epsilon", "Epsilon")
                .Replace("events", "events")
              
                .Replace("exponent", "Exponent")
                .Replace("fade", "Fade")
                .Replace("funnel", "Funnel")
                .Replace("icicle", "Icicle")
                .Replace("pie", "Pie")
                .Replace("sunburst", "Sunburst")
                .Replace("treemap", "Treemap")
              


                .Replace("featureidkey", "FeatureIDKey")
                .Replace("fence", "Fence")
                .Replace("font", "Font")
                .Replace("flaglist", "FlagList")
                .Replace("flatshading", "FlatShading")
                .Replace("format", "Format")
                .Replace("func", "Func")
                .Replace("gap", "Gap")
                .Replace("grid", "Grid")
                .Replace("groupby", "GroupBy")
                .Replace("group", "Group")
                .Replace("hoveron", "HoverOn")
                .Replace("heatmapgl", "HeatmapGL")
                .Replace("hover", "Hover")
                .Replace("hidesources", "HideSources")
                .Replace("iconsize", "IconSize")
                .Replace("index", "Index")
                .Replace("info", "Info")
                .Replace("itemname", "ItemName")
                .Replace("items", "Items")
                .Replace("json", "Json")
                .Replace("label", "Label")
                .Replace("layer", "Layer")
                .Replace("legendrank", "LegendRank")
                .Replace("legend", "Legend")
                .Replace("length", "Length")
                .Replace("line", "Line")
                .Replace("logo", "Logo")
                .Replace("maxdepth", "MaxDepth")
                .Replace("maxdisplayed", "MaxDisplayed")
                .Replace("maxzoom", "MaxZoom")
               
                .Replace("max", "Max")
                .Replace("mapbox", "Mapbox")
                .Replace("method", "Method")
                .Replace("mean", "Mean")
                .Replace("menu", "Menu")
                .Replace("mid", "Mid")
                
                .Replace("minsize", "MinSize")
                .Replace("minzoom", "MinZoom")
                .Replace("min", "Min")
                .Replace("mode", "Mode")
                .Replace("multiselect", "MultiSelect")
                .Replace("norm", "Norm")
               
                .Replace("numbers", "Numbers")
               // .Replace("order", "Order")
               .Replace("categoryorder", "CategoryOrder")
               .Replace("traceorder", "TraceOrder")
                .Replace("ocean", "Ocean")
                .Replace("opacity", "Opacity")
                .Replace("orientation", "Orientation")
                .Replace("others", "Others")
                .Replace("overflow", "Overflow")
                .Replace("pad", "Pad")
                .Replace("parcats", "ParallelCats")
                .Replace("parcoords", "ParallelCoords")
                .Replace("paths", "Paths")
                .Replace("padding", "Padding")
                .Replace("pattern", "Pattern")
                .Replace("pointpos", "PointPosition")
                .Replace("points", "Points")
                .Replace("polargl", "PolarGL")
                .Replace("polar", "Polar")
                .Replace("period", "Period")
                .Replace("position", "Position")
                .Replace("prefix", "Prefix")
                
                .Replace("autorange", "AutoRange")
                .Replace("constraintrange", "ConstraintRange")
                .Replace("dtickrange", "DTickRange")
                .Replace("fixedrange", "FixedRange")
                .Replace("arrangement", "Arrangement")
                // .Replace("range", "range")
                // .Replace("ratio", "Ratio")
                // .Replace("ref", "Ref")
                .Replace("duration", "Duration")
                .Replace("revision", "Revision")
                .Replace("river", "River")
                .Replace("roworder", "RowOrder")
                .Replace("rule", "Rule")
                .Replace("scaleratio", "ScaleRatio")
                .Replace("scale", "Scale")
                .Replace("scattergeo", "ScatterGeo")
                .Replace("scattergl", "ScatterGL")
                .Replace("selector", "Selector")
                .Replace("shape", "Shape")
                .Replace("showactive", "ShowActive")
                .Replace("showarrow", "ShowArrow")
                .Replace("showaxisrangerntryboxes", "ShowAxisRangeEntryBoxes")
                .Replace("showdividers", "ShowDividers")
                .Replace("showframe", "ShowFrame")
                .Replace("showlowerhalf", "ShowLowerHalf")
                .Replace("showlakes", "ShowLakes")
                .Replace("showland", "ShowLand")
                
                .Replace("shift", "Shift")
              
                .Replace("side", "Side")

                .Replace("sizable", "Sizable")
                .Replace("sizeref", "SizeRef")
                .Replace("sizex", "sizeX")
                .Replace("sizey", "sizeY")
                .Replace("sizing", "Sizing")
                .Replace("slider", "Slider")
                .Replace("slope", "Slope")
                .Replace("smith", "Smith")
                .Replace("smooth", "Smooth")
                .Replace("snap", "Snap")
                .Replace("span", "Span")
                .Replace("spikes", "Spikes")
                .Replace("squarifyratio", "SquarifyRatio")
                .Replace("startarrowhead", "StartArrowhead")
                .Replace("startarrowsize", "StartArrowSize")
                .Replace("standoff", "Standoff")
                .Replace("streamtube", "StreamTube")
                .Replace("stop", "Stop")
                .Replace("style", "Style")
                .Replace("subplotid", "SubplotID")
                .Replace("subunit", "Subunit")
                .Replace("suffix", "Suffix")
                .Replace("surface", "Surface")
                .Replace("traceref", "TraceRef")
                .Replace("tracerefminus", "TraceRefMinus")
                .Replace("template", "Template")
                .Replace("text", "Text")
                .Replace("ternary", "Ternary")
                .Replace("thickness", "Thickness")
                .Replace("thetaunit", "ThetaUnit")
                .Replace("theta", "Theta")
                .Replace("ticklen", "TickLen")
                .Replace("tickson", "TicksOn")
                .Replace("tick", "Tick")
                .Replace("title", "Title")
                .Replace("thousands", "Thousands")
                .Replace("toshow", "ToShow")
                .Replace("toward", "Toward")
                .Replace("type", "Type")
                .Replace("uid", "UID")
                //.Replace("unit", "Unit")
                .Replace("upperhalf", "UpperHalf")
                .Replace("value", "Value")
                .Replace("vals", "Vals")
                .Replace("width", "Width")
                .Replace("xref", "XRef")
                .Replace("xside", "XSide")
                .Replace("xsize", "XSize")
                .Replace("xy", "XY")
                .Replace("yanchor", "YAnchor")
                .Replace("yaxis", "YAxis")
                .Replace("yref", "YRef")
                .Replace("yside", "YSide")
                .Replace("ysize", "YSize");


            name = name.Substring(0, 1).ToUpper() + name.Substring(1);

            for (int i = 1; i < name.Length; i++)
            {
                if (name[i] == '_')
                {
                    name = name.Substring(0, i) + name[i + 1].ToString().ToUpper() + name.Substring(i + 2);
                }
            }


            return name;
        }


        public string LookupName(string Name, SchemaItem node)
        {
            return Name;
        }

        public string LookupClassName(string Name, SchemaItem node)
        {
            return Name;
        }

        public void CheckTypeName(SchemaItem item)
        {
            if (item.Name.ToLower() == "type" && item.Parent != null)
            {
                item.Name = item.Parent.Name + "Type";
            }

        }


    }
}