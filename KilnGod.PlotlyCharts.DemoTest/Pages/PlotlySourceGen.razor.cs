﻿//***********************************************************************************
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


            List<MapNameType> mapNameItems = new List<MapNameType>();

            foreach (var item in doc.RootElement.EnumerateObject())
            {
                SchemaItem head = new SchemaItem() { RootItemType = item.Name, Name = item.Name, CsType = item.Name };
                SchemaTree.Add(head);
                MapSchema(head, item.Value);


                MapNames(head, mapNameItems, item.Name);
              //  break;
            }

            string namelist = "";

            for (int i = 0; i < mapNameItems.Count; i++)
            {
                MapNameType name = mapNameItems[i];
               
                if (name.IsEnumeration)
                {
                    FixEnumNames(ref name);
                    EnumList.Add(name);
                } 
                else if (!string.IsNullOrWhiteSpace( name.ClassTypeName) && name.HasChildren && name.Name != "traces" && name.Name != "transforms")// && name.Name != "traces" )
                {
                    FixClassNames(ref name);

                    ClassList.Add(name);

                }
            }


//            PublishEnumerations();

  

            string reasons = string.Empty;

            List<MapNameType> enumItems = EnumList.OrderBy(x => x.ClassTypeName).ThenBy(x => x.PropertyName).ThenBy(x => x.item?.Enumeration?.Count).ToList();

            for (int i = 1; i < enumItems.Count; i++)
            {
                MapNameType priorName = enumItems[i - 1];
                MapNameType name = enumItems[i];

                bool isDifferentEnum = false;
                string reason = string.Empty;
                if (name.ClassTypeName == priorName.ClassTypeName)
                {
                    if (name.item.Enumeration.Count != priorName.item.Enumeration.Count)
                    {
                        isDifferentEnum = true;
                        reason = "enum count is different";
                    }
                    else if (name.item.Enumeration.Count > 0)
                    {
                        foreach (var child in name.item.Enumeration)
                        {
                            var mia = priorName.item.Enumeration.Find(x => x == child);

                            if (mia == null)
                            {
                                isDifferentEnum = true;
                                reason = "element not found: " + child;
                            }
                        }
                    }

                    if (isDifferentEnum)
                    {
                        reasons = reasons + System.Environment.NewLine + name.PropertyName + " " + name.Name + " != " + priorName.Name + " : " + reason;
                    }
                }

            }

            AreaText = reasons;
            /*
            List< MapNameType>   classItems = ClassList.OrderBy(x => x.PropertyName).ThenBy(x => MapNameType.ChildCount(x)).ToList();

          

            for (int i = 1; i < classItems.Count; i++)
            {
                MapNameType priorName = classItems[i - 1];
                MapNameType name = classItems[i];

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
            */

            /*

            for (int i = 0; i < names.Count; i++)
            {
                MapNameType name = names[i];
                namelist += "\t\t\t\tnew MapNameType(){PropertyName=\""+name.PropertyName+ "\", ClassTypeName=\"" + name.ClassTypeName + "\", OriginalName=\"" + name.OriginalName + "\", FileName=\""+name.FileName+ "\", SchemaSection=\"" + name.SchemaSection + "\", JsonType=\"" + name.JsonType + "\", Name = \"" + name.Name + "\"}," + System.Environment.NewLine;
            }
            
            */



        }



        public void PublishEnumerations()
        {


            string result = string.Empty;
            string blowup = string.Empty;

            string indent = "\t\t";

            string lastResultName = "";
            int lastItemCount = 0;
            string lastClassName = string.Empty;

            EnumList = EnumList.OrderBy(x => x.ClassTypeName).ToList();
            int icnt = 0;
            foreach (MapNameType map in EnumList)
            {
                SchemaItem item = map.item;

                if (map.ClassTypeName == lastClassName)
                {
                    continue;
                }
                icnt += 1;
                lastClassName = map.ClassTypeName;
                try
                {


                    if ((item.ElementType == SchemaElementType.enumOption) && (item.Name != lastResultName || item.Children.Count != lastItemCount))
                    {

                        string enumName = map.ClassTypeName;
/*
                        if (enumName == "type" && item.Parent != null)
                        {
                            enumName = item.Parent.Name + "Type";
                        }
*/
                        
                        result = result + indent + "/******************************\n";
                        result = result + indent + "*** Enum Name: " + enumName + "\n" + indent + "***\n";

                        result = result + indent + "*** Description: " + item.Description + "\n" + indent + "***\n";
                        result = result + indent + "*** Source: " + map.Name + "\n";
                        result = result + indent + "******************************/\n\n";



                        bool isSymbol = (item.Name == "symbol");

                        string itemsList = string.Empty;

                        result = result + indent + "public enum " + CamelCaseName( enumName) + System.Environment.NewLine + indent + "{" + System.Environment.NewLine;

                        if (item.Enumeration != null)
                        {
                            if (isSymbol)
                            {
                                for (int i = 0; i < item.Enumeration.Count; i++)
                                {
                                    if (i % 3 == 0 || i % 3 == 1)
                                    {
                                        continue;
                                    }
                                    if (itemsList != string.Empty)
                                    {
                                        itemsList += ",\n";

                                    }

                                    itemsList += indent + "\t[Description(\"" + item.Enumeration[i - 1] + "\")]\n" + indent + "\t" + CamelCapEnumItem( item.Enumeration[i]);


                                }
                            }
                            else
                            {

                                foreach (string enumItem in item.Enumeration)
                                {




                                    if (enumItem != string.Empty)
                                    {

                                        if (itemsList != string.Empty)
                                        {
                                            itemsList += ",\n";

                                        }
                                        if (enumItem.StartsWith("/") && enumItem.Length > 2)
                                        {
                                            itemsList += indent + "\t[Description(\"" + enumItem.Replace("\"", "\\\"") + "\")]\n" + indent + "\tRegEx_" + enumItem[2].ToString().ToUpper();
                                        }
                                        else
                                        {
                                            if (enumItem == "\\")
                                            {
                                                itemsList += indent + "\t[Description(\"" + "\\\\" + "\")]\n" + indent + "\t" + CamelCapEnumItem(enumItem);
                                            }
                                            else
                                            {
                                                itemsList += indent + "\t[Description(\"" + enumItem.Replace("True","true").Replace("False","false") + "\")]\n" + indent + "\t" + CamelCapEnumItem(enumItem);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        result = result + itemsList + System.Environment.NewLine + indent + "}" + System.Environment.NewLine + System.Environment.NewLine;

                        lastResultName = item.Name;
                        lastItemCount = item.Children.Count;
                    }
                }
                catch (Exception ex)
                {
                    blowup = ex.Message;
                }

            //    break;
            }


            AreaText = "Total Enums:"+ icnt.ToString() + System.Environment.NewLine + result;
            StateHasChanged();

        }


        public string CamelCapEnumItem(string enumItem)
        {


            enumItem = enumItem.Replace(">=", "GreaterThanEquals");
            enumItem = enumItem.Replace(">", "GreaterThan");
            enumItem = enumItem.Replace("<=", "LessThanEquals");
            enumItem = enumItem.Replace("<", "LessThan");
            enumItem = enumItem.Replace("!=", "NotEquals");
            enumItem = enumItem.Replace("=", "Equals");
            enumItem = enumItem.Replace("|", "Pipe");
            enumItem = enumItem.Replace("/", "ForwardSlash");
            enumItem = enumItem.Replace("\\", "BackSlash");

            switch (enumItem)
            {
                case "evenodd":
                    enumItem = "EvenOdd";
                    break;
                case "nonzero":
                    enumItem = "NonZero";
                    break;
                case "toself":
                    enumItem = "ToSelf";
                    break;
                case "tonext":
                    enumItem = "ToNext";
                    break;
                case "geojson":
                    enumItem = "GeoJSON";
                    break;

                case "usa":
                    enumItem = "USA";
                    break;

                case "50":
                    enumItem = "_50";
                    break;

                case "100":                   
                    enumItem = "_100";
                    break;

                case "-":
                    enumItem = "Auto";
                    break;

                case "-1":
                    enumItem = "Neg_1";
                    break;
                case "1":
                    enumItem = "Plus_1";
                    break;
                case "2":
                    enumItem = "Plus_2";
                    break;
                case "0":
                    enumItem = "Zero";
                    break;

                case "h":
                    enumItem = "Horizontal";
                    break;
                case "v":
                    enumItem = "Vertical";
                    break;
                case "e":
                    enumItem = "Small_e";
                    break;
                case "E":
                    enumItem = "Big_E";
                    break;
                case "r":
                    enumItem = "R";
                    break;
                case "x":
                    enumItem = "X";
                    break;
                case "y":
                    enumItem = "Y";
                    break;
                case "z":
                    enumItem = "Z";
                    break;
                case "_":
                    enumItem = "Underscore";
                    break;
                case "|":
                    enumItem = "Pipe";
                    break;
                case "+":
                    enumItem = "Plus";
                    break;
                case ".":
                    enumItem = "Dot";
                    break;
                case "[]":
                    enumItem = "LBRB";
                    break;
                case "][":
                    enumItem = "RBLB";
                    break;
                case "()":
                    enumItem = "LPRP";
                    break;

                case ")(":
                    enumItem = "RPLP";
                    break;
                case "[)":
                    enumItem = "RBRP";
                    break;
                case "(]":
                    enumItem = "LPRB";
                    break;
                case "](":
                    enumItem = "RBLP";
                    break;
                case ")[":
                    enumItem = "TPLB";
                    break;

                case "{}":
                    enumItem = "LCRC";
                    break;

                case "}{":
                    enumItem = "RCLC";
                    break;

            }

            enumItem = enumItem.Replace(" ", "_").Replace("-", "_");


            for (int i = 1; i < enumItem.Length; i++)
            {
                if (enumItem[i] == '_')
                {
                    enumItem = enumItem.Substring(0, i) + enumItem[i + 1].ToString().ToUpper() + enumItem.Substring(i + 2);
                }
            }

            if (enumItem.Length > 1)
            {
                enumItem = enumItem.Substring(0, 1).ToUpper() + enumItem.Substring(1);
            }
            enumItem =  enumItem.Replace("all", "All")
                .Replace("size", "Size")
                .Replace("draw", "Draw")
                .Replace("off", "Off")
                .Replace("out", "Out")
                .Replace("closed", "Closed")
                .Replace("line", "Line")
                .Replace("rect", "Rect")
                .Replace("circle", "Circle")
                .Replace("json", "JSON")
                .Replace("others", "Others")
                .Replace("odd", "Odd")
                .Replace("zero", "Zero")
                .Replace("dash", "Dash")
                .Replace("dot", "Dot")
                .Replace("self", "Self")
                .Replace("next", "Next")
                .Replace("even", "Even")
                .Replace("only", "Only");
           

            return (enumItem);
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


        public void FixEnumNames(ref MapNameType node)
        {
            switch (node.Name)
            {
                case "polar.angularaxis.categoryorder":
                case "polar.radialaxis.categoryorder":
                    node.ClassTypeName = "PolarCategoryOrderOptions";
                    node.FileName = "PolarCategoryOrderOptions.cs";
                    break;
                case "scene.xaxis.categoryorder":
                case "scene.yaxis.categoryorder":
                case "scene.zaxis.categoryorder":
                case "layoutAttributes.xaxis.categoryorder":
                case "layoutAttributes.yaxis.categoryorder":
                    node.ClassTypeName = "CartesianCategoryOrderOptions";
                    node.FileName = "CartesianCategoryOrderOptions.cs";
                    break;

                case "attributes.contours.type":
                    node.ClassTypeName = "ContoursTypeOptions";
                    node.FileName = "ContoursTypeOptions.cs";
                    break;
                case "camera.projection.type":
               
                    node.ClassTypeName = "CameraProjectionTypeOptions";
                    node.FileName = "CameraProjectionTypeOptions.cs";
                    break;
                case "geo.projection.type":
                    node.ClassTypeName = "GeoProjectionTypeOptions";
                    node.FileName = "GeoProjectionTypeOptions.cs";
                    break;
                case "attributes.aaxis.type":
                case "attributes.baxis.type":
                    node.ClassTypeName = "ABAxisTypeOptions";
                    node.FileName = "ABAxisTypeOptions.cs";
                    break;

                case "scene.xaxis.type":
                case "scene.yaxis.type":
                case "scene.zaxis.type":
                    node.ClassTypeName = "SceneAxisTypeOptions";
                    node.FileName = "SceneAxisTypeOptions.cs";
                    break;

                case "contourcarpet.attributes.atype":
                case "contourcarpet.attributes.btype":
                case "contour.attributes.xtype":
                case "contour.attributes.ytype":
                case "heatmap.attributes.xtype":
                case "heatmap.attributes.ytype":
                case "heatmapgl.attributes.ytype":
                case "heatmapgl.attributes.xtype":

                    node.ClassTypeName = "ArrayTypeOptions";
                    node.FileName = "ArrayTypeOptions.cs";
                    break;

                case "layoutAttributes.hoverlabel.align":
                case "attributes.hoverlabel.align":
               
                case "node.hoverlabel.align":


                    node.ClassTypeName = "AutoAlignOptions";
                    node.FileName = "AutoAlignOptions.cs";
                    break;

                case "attributes.title.align":
                    node.ClassTypeName = "TitleAlignOptions";
                    node.FileName = "TitleAlignOptions.cs";
                    break;

                case "items.shape.layer":
                case "items.image.layer":
                    node.ClassTypeName = "LayerOptions";
                    node.FileName = "LayerOptions.cs";
                    break;
                case "attributes.cells.align":
               
                    node.ClassTypeName = "CellAlignOptions";
                    node.FileName = "CellAlignOptions.cs";
                    break;
                case "link.hoverlabel.align":
                    node.ClassTypeName = "LinkAlignOptions";
                    node.FileName = "LinkAlignOptions.cs";
                    break;


                case "line.colorbar.xanchor":
                case "items.image.xanchor":
                case "coloraxis.colorbar.xanchor":
                    node.ClassTypeName = "XAlignOptions";
                    node.FileName = "XAlignOptions.cs";
                    break;

                case "line.colorbar.yanchor":

                    node.ClassTypeName = "YAlignOptions";
                    node.FileName = "YAlignOptions.cs";
                    break;

                case "indicator.attributes.align":            
              
                case "items.annotation.align":
               
                    node.ClassTypeName = "AlignOptions";
                    node.FileName = "AlignOptions.cs";
                    break;

                case "items.shape.xsizemode":
                case "items.shape.ysizemode":
                    node.ClassTypeName = "ShapeSizeModeOptions";
                    node.FileName = "ShapeSizeModeOptions.cs";
                    break;

                case "items.shape.xref":
                    node.ClassTypeName = "ShapeXRef";
                    node.FileName = "ShapeReXf.cs";
                    break;
                case "items.shape.yref":
                    node.ClassTypeName = "ShapeYRef";
                    node.FileName = "ShapeYRef.cs";
                    break;
                case "layoutAttributes.title.xref":
                case "layoutAttributes.title.yref":
                    node.ClassTypeName = "TitleRefOptions";
                    node.FileName = "TitleRefOptions.cs";
                    break;


                case "slider.currentvalue.xanchor":
                case "attributes.colorbar.xanchor":
                case "marker.colorbar.xanchor":
                    node.ClassTypeName = "ColorbarXAnchorOptions";
                    node.FileName = "ColorbarXAnchorOptions.cs";
                    break;
                case "marker.colorbar.yanchor":
                case "attributes.colorbar.yanchor":
                    node.ClassTypeName = "ColorbarYAnchorOptions";
                    node.FileName = "ColorbarYAnchorOptions.cs";
                    break;

                case "items.annotation.xanchor":
                case "layoutAttributes.legend.xanchor":
              
               
               
                    node.ClassTypeName = "XAnchorOptions";
                    node.FileName = "XAnchorOptions.cs";
                    break;
                
                case "items.annotation.yanchor":
                case "layoutAttributes.legend.yanchor":
               
                
                    node.ClassTypeName = "YAnchorOptions";
                    node.FileName = "YAnchorOptions.cs";
                    break;
                case "attributes.aaxis.tickmode":
                case "attributes.baxis.tickmode":
                    node.ClassTypeName = "ABAxisTickModeOptions";
                    node.FileName = "ABAxisTickModeOptions.cs";
                    break;
                case "coloraxis.colorbar.tickmode":
                    node.ClassTypeName = "ColorbarTickModeOptions";
                    node.FileName = "ColorbarTickModeOptions.cs";
                    break;

                case "animation.mode":
                    node.ClassTypeName = "AnimationModeOptions";
                    node.FileName = "AnimationModeOptions.cs";
                    break;

                case "items.rangebreak.pattern":
                    node.ClassTypeName = "RangebreakPatternOptions";
                    node.FileName = "RangebreakPatternOptions.cs";
                    break;

               
                case "layout.layoutAttributes.dragmode":
                    node.ClassTypeName = "LayoutDragModeOptions";
                    node.FileName = "LayoutDragModeOptions.cs";
                    break;

                case "attributes.cumulative.direction":
                    node.ClassTypeName = "CumulativeDirectionOptions";
                    node.FileName = "CumulativeDirectionOptions.cs";
                    break;

                case "items.dimension.categoryorder":
                    node.ClassTypeName = "DimensionCategoryOrder";
                    node.FileName = "DimensionCategoryOrder.cs";
                    break;

                case "indicator.attributes.mode":
                    node.ClassTypeName = "IndicatorModeOptions";
                    node.FileName = "IndicatorModeOptions.cs";
                    break;

                case "attributes.title.position":
                    node.ClassTypeName = "TitlePositionOptions";
                    node.FileName = "TitlePositionOptions.cs";
                    break;
               

                case "attributes.gauge.shape":
                    node.ClassTypeName = "GaugeShapeOptions";
                    node.FileName = "GaugeShapeOptions.cs";
                    break;

                case "cone.attributes.sizemode":
                    node.ClassTypeName = "ConeSizemodeOptions";
                    node.FileName = "ConeSizemodeOptions.cs";
                    break;

                case "rangeslider.yaxis.rangemode":
                    node.ClassTypeName = "SliderRangeModeOptions";
                    node.FileName = "SliderRangeModeOptions.cs";
                    break;

                case "attributes.contours.operation":
                    node.ClassTypeName = "ContoursOperationOptions";
                    node.FileName = "ContoursOperationOptions.cs";
                    break;
                case "scattercarpet.attributes.fill":
                case "scatterternary.attributes.fill":
                    node.ClassTypeName = "FillSubsetOptions";
                    node.FileName = "FillSubsetOptions.cs";
                    break;

                case "items.updatemenu.direction":
                    node.ClassTypeName = "MenuDirectionOptions";
                    node.FileName = "MenuDirectionOptions.cs";
                    break;

                case "animation.direction":
                    node.ClassTypeName = "AnimationDirectionOptions";
                    node.FileName = "AnimationDirectionOptions.cs";
                    break;
            

               

                case "cone.attributes.anchor":
                    node.ClassTypeName = "ConeAnchorOptions";
                    node.FileName = "ConeAnchorOptions.cs";
                    break;

                case "polar.angularaxis.layer":
                    node.ClassTypeName = "AngularAxisLayerOptions";
                    node.FileName = "AngularAxisLayerOptions.cs";
                    break;

                case "marker.pattern.shape":
                    node.ClassTypeName = "PatternShapeOptions";
                    node.FileName = "PatternShapeOptions.cs";
                    break;

                case "legend.title.side":
                    node.ClassTypeName = "LegendTitleSideOptions";
                    node.FileName = "LegendTitleSideOptions.cs";
                    break;
                case "histogram2d.attributes.zsmooth":
                case "heatmap.attributes.zsmooth":
                    node.ClassTypeName = "ZSmooth2DOptions";
                    node.FileName = "ZSmooth2DOptions.cs";
                    break;

                case "items.updatemenu.type":
                    node.ClassTypeName = "UpdateMenuTypeOptions";
                    node.FileName = "UpdateMenuTypeOptions.cs";
                    break;

                case "items.shape.type":
                    node.ClassTypeName = "ShapeTypeOptions";
                    node.FileName = "ShapeTypeOptions.cs";
                    break;
                case "attributes.error_x.type":
                case "attributes.error_y.type":
                case "attributes.error_z.type":
                    node.ClassTypeName = "ErrorTypeOptions";
                    node.FileName = "ErrorTypeOptions.cs";
                    break;
                case "layoutAttributes.xaxis.type":
                case "layoutAttributes.yaxis.type":
                case "layoutAttributes.zaxis.type":
                    node.ClassTypeName = "AxisTypeOptions";
                    node.FileName = "AxisTypeOptions.cs";
                    break;
                case "marker.gradient.type":
                    node.ClassTypeName = "GradientTypeOptions";
                    node.FileName = "GradientTypeOptions.cs";
                    break;

                case "items.layer.type":
                    node.ClassTypeName = "LayerTypeOptions";
                    node.FileName = "LayerTypeOptions.cs";
                    break;
                case "polar.angularaxis.type":
                    node.ClassTypeName = "AngularAxisTypeOptions";
                    node.FileName = "AngularAxisTypeOptions.cs";
                    break;
                case "polar.radialaxis.type":
                    node.ClassTypeName = "RadialAxisTypeOptions";
                    node.FileName = "RadialAxisTypeOptions.cs";
                    break;
                case "barpolar.attributes.thetaunit":
                    node.ClassTypeName = "BarpolarThetaUnitOptions";
                    node.FileName = "BarpolarThetaUnitOptions.cs";
                    break;


                case "layer.symbol.textposition":
                    node.ClassTypeName = "SymbolTextPositionOptions";
                    node.FileName = "SymbolTextPositionOptions.cs";
                    break;
                 case "funnelarea.attributes.textposition":
               
                    node.ClassTypeName = "FunnelAreaTextPositionOptions";
                    node.FileName = "FunnelAreaTextPositionOptions.cs";
                    break;
                case "waterfall.attributes.textposition":
                    node.ClassTypeName = "WaterfallTextPositionOptions";
                    node.FileName = "WaterfallTextPositionOptions.cs";
                    break;
                case "pie.attributes.textposition":
                    node.ClassTypeName = "PieTextPositionOptions";
                    node.FileName = "PieTextPositionOptions.cs";
                    break;
                case "treemap.attributes.textposition":
                    node.ClassTypeName = "TreemapTextPositionOptions";
                    node.FileName = "TreemapTextPositionOptions.cs";
                    break;
                case "scatterternary.attributes.textposition":
                case "scattersmith.attributes.textposition":
                case "scatterpolargl.attributes.textposition":
                case "scatterpolar.attributes.textposition":
                case "scattermapbox.attributes.textposition":
                case "scattergl.attributes.textposition":
                case "scattergeo.attributes.textposition":
                case "scattercarpet.attributes.textposition":
                case "scatter3d.attributes.textposition":
                case "scatter.attributes.textposition":
                    node.ClassTypeName = "ScatterTextPositionOptions";
                    node.FileName = "ScatterTextPositionOptions.cs";
                    break;
                case "attributes.fillpattern.shape":
                    node.ClassTypeName = "FillPatternShapeOptions";
                    node.FileName = "FillPatternShapeOptions.cs";
                    break;
                case "ternary.aaxis.layer":
                case "ternary.baxis.layer":
                case "ternary.caxis.layer":
                case "layoutAttributes.xaxis.layer":
                case "layoutAttributes.yaxis.layer":
                case "polar.radialaxis.layer":
                case "smith.imaginaryaxis.layer":
                case "smith.realaxis.layer":
                    node.ClassTypeName = "AxisLayerOptions";
                    node.FileName = "AxisLayerOptions.cs";
                    break;
                case "attributes.surface.pattern":
                    node.ClassTypeName = "SurfacePatternOptions";
                    node.FileName = "SurfacePatternOptions.cs";
                    break;
                case "layoutAttributes.grid.pattern":
                    node.ClassTypeName = "GridPatternOptions";
                    node.FileName = "GridPatternOptions.cs";
                    break;
                case "layoutAttributes.uniformtext.mode":
                    node.ClassTypeName = "UniformTextModeOptions";
                    node.FileName = "UniformTextModeOptions.cs";
                    break;
                case "attributes.connector.mode":
                    node.ClassTypeName = "ConnectorModeOptions";
                    node.FileName = "ConnectorModeOptions.cs";
                    break;
                case "violin.attributes.side":
                    node.ClassTypeName = "ViolinSideOptions";
                    node.FileName = "ViolinSideOptions.cs";
                    break;
                case "attributes.pathbar.side":
                    node.ClassTypeName = "PathbarSideOptions";
                    node.FileName = "PathbarSideOptions.cs";
                    break;
                case "smith.realaxis.side":
                    node.ClassTypeName = "RealAxisSideOptions";
                    node.FileName = "RealAxisSideOptions.cs";
                    break;
                case "polar.radialaxis.side":
                    node.ClassTypeName = "RadialAxisSideOptions";
                    node.FileName = "RadialAxisSideOptions.cs";
                    break;
                case "icicle.attributes.textposition":
                    node.ClassTypeName = "IcicleTextPositionOptions";
                    node.FileName = "IcicleTextPositionOptions.cs";
                    break;
                case "treemap.attributes.textinfo":
                case "sunburst.attributes.textinfo":
                    node.ClassTypeName = "SunburstTextInfoOptions";
                    node.FileName = "SunburstTextInfoOptions.cs";
                    break;

                case "funnel.attributes.textinfo":
                    node.ClassTypeName = "FunnelTextInfoOptions";
                    node.FileName = "FunnelTextInfoOptions.cs";
                    break;
                case "icicle.attributes.textinfo":
                    node.ClassTypeName = "IcicleTextInfoOptions";
                    node.FileName = "IcicleTextInfoOptions.cs";
                    break;
                case "waterfall.attributes.textinfo":
                    node.ClassTypeName = "WaterfallTextInfoOptions";
                    node.FileName = "WaterfallTextInfoOptions.cs";
                    break;
                case "colorbar.title.side":
                    node.ClassTypeName = "TitleSideOptions";
                    node.FileName = "TitleSideOptions.cs";
                    break;
            //    case "smith.realaxis.side":
            //    case "smith.realaxis.ticks":
            //    case "layoutAttributes.xaxis.side":
                case "parcoords.attributes.labelside":
                    node.ClassTypeName = "TopBottomOptions";
                    node.FileName = "TopBottomOptions.cs";
                    break;


                case "coloraxis.colorbar.yanchor":
                case "items.annotation.valign":
                case "items.image.yanchor":
                case "layoutAttributes.legend.valign":


                    node.ClassTypeName = "TopMiddleBottomOptions";
                    node.FileName = "TopMiddleBottomOptions.cs";
                    break;
                case "violin.attributes.hoveron":
                    node.ClassTypeName = "ViolinHoverOnOptions";
                    node.FileName = "ViolinHoverOnOptions.cs";
                    break;
                case "parcats.attributes.hoveron":
                    node.ClassTypeName = "ParCatsHoverOnOptions";
                    node.FileName = "ParCatsHoverOnOptions.cs";
                    break;
                case "box.attributes.hoveron":
                    node.ClassTypeName = "BoxHoverOnOptions";
                    node.FileName = "BoxHoverOnOptions.cs";
                    break;
                case "layoutAttributes.scene.hovermode":
                    node.ClassTypeName = "SceneHoverModeOptions";
                    node.FileName = "SceneHoverModeOptions.cs";
                    break;
                case "parcats.attributes.arrangement":
                    node.ClassTypeName = "ParCatsArrangementOptions";
                    node.FileName = "ParCatsArrangementOptions.cs";
                    break;
                case "barpolar.layoutAttributes.barmode":
                    node.ClassTypeName = "BarPolarBarModeOptions";
                    node.FileName = "BarPolarBarModeOptions.cs";
                    break;

                case "attributes.link.hoverinfo":
                    node.ClassTypeName = "LinkHoverOptions";
                    node.FileName = "LinkHoverOptions.cs";
                    break;

                case "densitymapbox.attributes.hoverinfo":
                
                    node.ClassTypeName = "DensityMapboxHoverOptions";
                    node.FileName = "DensityMapboxHoverOptions.cs";
                    break;
                case "funnel.attributes.hoverinfo":
                    node.ClassTypeName = "FunnelHoverOptions";
                    node.FileName = "FunnelHoverOptions.cs";
                    break;
                case "pie.attributes.hoverinfo":
                    node.ClassTypeName = "PieHoverOptions";
                    node.FileName = "PieHoverOptions.cs";
                    break;
                case "scattermapbox.attributes.hoverinfo":
                    node.ClassTypeName = "MapboxHoverOptions";
                    node.FileName = "MapboxHoverOptions.cs";
                    break;
                case "scattergeo.attributes.hoverinfo":
                
                    node.ClassTypeName = "GeoHoverOptions";
                    node.FileName = "GeoHoverOptions.cs";
                    break;
                case "choropleth.attributes.hoverinfo":
                case "choroplethmapbox.attributes.hoverinfo":
                    node.ClassTypeName = "ChoroplethHoverOptions";
                    node.FileName = "ChoroplethHoverOptions.cs";
                    break;
              
                case "cone.attributes.hoverinfo":

                    node.ClassTypeName = "ConeHoverOptions";
                    node.FileName = "ConeHoverOptions.cs";
                    break;
                case "volume.attributes.hoverinfo":
                    node.ClassTypeName = "VolumeHoverOptions";
                    node.FileName = "VolumeHoverOptions.cs";
                    break;

                case "surface.attributes.hoverinfo":
                
                    node.ClassTypeName = "SurfaceHoverOptions";
                    node.FileName = "SurfaceHoverOptions.cs";
                    break;
                case "streamtube.attributes.hoverinfo":
                    node.ClassTypeName = "StreamTubeHoverOptions";
                    node.FileName = "StreamTubeHoverOptions.cs";
                    break;

                case "parcats.attributes.hoverinfo":
                    node.ClassTypeName = "ParallelCatsHoverOptions";
                    node.FileName = "ParallelCatsHoverOptions.cs";
                    break;
                case "treemap.attributes.hoverinfo":
                case "sunburst.attributes.hoverinfo":
                    node.ClassTypeName = "SunburstHoverOptions";
                    node.FileName = "SunburstHoverOptions.cs";
                    break;
                case "image.attributes.hoverinfo":
                    node.ClassTypeName = "ImageHoverOptions";
                    node.FileName = "ImageHoverOptions.cs";
                    break;
             
                

                case "scatter.attributes.hoverinfo":
                case "scatter3d.attributes.hoverinfo":
                case "box.attributes.hoverinfo":
                
                case "violin.attributes.hoverinfo":
                case "candlestick.attributes.hoverinfo":
                case "contour.attributes.hoverinfo":
                case "splom.attributes.hoverinfo":
                case "table.attributes.hoverinfo":

                    node.ClassTypeName = "HoverOptions";
                    node.FileName = "HoverOptions.cs";
                    break;
                case "scatterpolargl.attributes.hoverinfo":
                case "scatterpolar.attributes.hoverinfo":
                    node.ClassTypeName = "PolarHoverOptions";
                    node.FileName = "PolarHoverOptions.cs";
                    break;
                case "scattercarpet.attributes.hoverinfo":
                    node.ClassTypeName = "CarpetHoverOptions";
                    node.FileName = "CarpetHoverOptions.cs";
                    break;

                case "scatterternary.attributes.hoverinfo":
                    node.ClassTypeName = "TernaryHoverOptions";
                    node.FileName = "TernaryHoverOptions.cs";
                    break;
                case "funnelarea.attributes.hoverinfo":
              
                    node.ClassTypeName = "FunnelAreaHoverOptions";
                    node.FileName = "FunnelAreaHoverOptions.cs";
                    break;

                case "scattersmith.attributes.hoverinfo":
                    node.ClassTypeName = "ScatterSmithHoverOptions";
                    node.FileName = "ScatterSmithHoverOptions.cs";
                    break;
                case "icicle.attributes.hoverinfo":
                    node.ClassTypeName = "IcicleHoverOptions";
                    node.FileName = "IcicleHoverOptions.cs";
                    break;
                case "barpolar.attributes.hoverinfo":
                    node.ClassTypeName = "BarpolarHoverOptions";
                    node.FileName = "BarpolarHoverOptions.cs";
                    break;
                case "waterfall.attributes.hoverinfo":
                    node.ClassTypeName = "WaterfallHoverOptions";
                    node.FileName = "WaterfallHoverOptions.cs";
                    break;
                case "coloraxis.colorbar.showtickprefix":
                case "coloraxis.colorbar.showticksuffix":
                case "polar.angularaxis.showticksuffix":
                case "polar.radialaxis.showticksuffix":
                case "scene.xaxis.showticksuffix":
                case "scene.xaxis.showtickprefix":
                case "scene.yaxis.showticksuffix":
                case "scene.yaxis.showtickprefix":
                case "scene.zaxis.showticksuffix":
                case "scene.zaxis.showtickprefix":
                case "smith.realaxis.showticksuffix":
                case "smith.realaxis.showtickprefix":
                case "smith.imaginaryaxis.showticksuffix":
                case "smith.imaginaryaxis.showtickprefix":
                case "ternary.aaxis.showticksuffix":
                case "ternary.aaxis.showtickprefix":
                case "ternary.baxis.showticksuffix":
                case "ternary.baxis.showtickprefix":
                case "ternary.caxis.showticksuffix":
                case "ternary.caxis.showtickprefix":
                case "layoutAttributes.xaxis.showticksuffix":
                case "layoutAttributes.xaxis.showtickprefix":
                case "layoutAttributes.yaxis.showticksuffix":
                case "layoutAttributes.yaxis.showtickprefix":
                case "marker.colorbar.showticksuffix":
                case "marker.colorbar.showtickprefix":
                case "attributes.aaxis.showticksuffix":
                case "attributes.aaxis.showtickprefix":
                case "attributes.baxis.showticksuffix":
                case "attributes.baxis.showtickprefix":
                case "attributes.colorbar.showticksuffix":
                case "attributes.colorbar.showtickprefix":
                case "gauge.axis.showticksuffix":
                case "gauge.axis.showtickprefix":
                case "line.colorbar.showticksuffix":
                case "line.colorbar.showtickprefix":
                    node.ClassTypeName = "ShowTickOptions";
                    node.FileName = "ShowTickOptions.cs";
                    break;
                case "scatterpolar.attributes.thetaunit":
                case "scatterpolargl.attributes.thetaunit":
                    node.ClassTypeName = "PolarThetaUnitOptions";
                    node.FileName = "PolarThetaUnitOptions.cs";
                    break;
                case "polar.angularaxis.thetaunit":
               
                    node.ClassTypeName = "AngularThetaUnitOptions";
                    node.FileName = "AngularThetaUnitOptions.cs";
                    break;

                case "bar.attributes.hoverinfo":
                case "ohlc.attributes.hoverinfo":
                    node.ClassTypeName = "GraphHoverInfoOptions";
                    node.FileName = "GraphHoverInfoOptions.cs";
                    break;

                case "attributes.node.hoverinfo":
                    node.ClassTypeName = "NodeHoverInfoOptions";
                    node.FileName = "NodeHoverInfoOptions.cs";
                    break;

                case "ternary.aaxis.ticks":
                case "ternary.baxis.ticks":
                case "ternary.caxis.ticks":
                    node.ClassTypeName = "TernaryAxisTicksOptions";
                    node.FileName = "TernaryAxisTicksOptions.cs";
                    break;
                case "smith.realaxis.ticks":
                    node.ClassTypeName = "RealAxisTicksOptions";
                    node.FileName = "RealAxisTicksOptions.cs";
                    break;

                case "layoutAttributes.xaxis.ticks":
                case "layoutAttributes.yaxis.ticks":
                    node.ClassTypeName = "CartesianAxisTicksOptions";
                    node.FileName = "CartesianAxisTicksOptions.cs";
                    break;

                case "pointcloud.attributes.hoverinfo":
                    node.ClassTypeName = "PointCloudHoverInfoOptions";
                    node.FileName = "PointCloudHoverInfoOptions.cs";
                    break;

                case "bar.layoutAttributes.barnorm":
                case "scatter.attributes.groupnorm":
                case "histogram.layoutAttributes.barnorm":
                    node.ClassTypeName = "NormalizationOptions";
                    node.FileName = "NormalizationOptions.cs";
                    break;

                case "attributes.colorbar.lenmode":
                case "coloraxis.colorbar.lenmode":               
                case "coloraxis.colorbar.thicknessmode":
                case "items.slider.lenmode":
                case "line.colorbar.lenmode":
                case "line.colorbar.thicknessmode":
                case "marker.colorbar.lenmode":
                case "marker.colorbar.thicknessmode":
                case "attributes.colorbar.thicknessmode":
                    node.ClassTypeName = "MeasureModeOptions";
                    node.FileName = "MeasureModeOptions.cs";
                    break;

                case "mesh3d.attributes.zcalendar":
                case "mesh3d.attributes.ycalendar":
                case "mesh3d.attributes.xcalendar":
                case "bar.attributes.ycalendar":
                case "bar.attributes.xcalendar":
                case "filter.attributes.valuecalendar":
                case "filter.attributes.targetcalendar":
                case "layout.layoutAttributes.calendar":
                case "scatter.attributes.xcalendar":
                case "scatter.attributes.ycalendar":
                case "scattergl.attributes.xcalendar":
                case "scattergl.attributes.ycalendar":
                case "scatter3d.attributes.xcalendar":
                case "scatter3d.attributes.ycalendar":
                case "scatter3d.attributes.zcalendar":
                case "surface.attributes.xcalendar":
                case "surface.attributes.ycalendar":
                case "box.attributes.ycalendar":
                case "box.attributes.xcalendar":
                case "surface.attributes.zcalendar":
                case "contour.attributes.xcalendar":
                case "contour.attributes.ycalendar":
                case "candlestick.attributes.xcalendar":
                case "heatmap.attributes.xcalendar":
                case "heatmap.attributes.ycalendar":
                case "histogram.attributes.xcalendar":
                case "histogram.attributes.ycalendar":
                case "histogram2d.attributes.xcalendar":
                case "histogram2d.attributes.ycalendar":
                case "histogram2dcontour.attributes.xcalendar":
                case "histogram2dcontour.attributes.ycalendar":
                case "ohlc.attributes.xcalendar":
                    node.ClassTypeName = "CalendarOptions";
                    node.FileName = "CalendarOptions.cs";
                    break;

            }
        }

        public void FixClassNames(ref MapNameType node)
        {


            // classes
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

                case "traces.bar.attributes":
                    node.ClassTypeName = "BarTrace : Trace";
                    node.FileName = "BarTrace.cs";
                    break;
                case "traces.barpolar.attributes":
                    node.ClassTypeName = "BarPolar : Trace";
                    node.FileName = "BarPolar.cs";
                    break;
                case "traces.box.attributes":
                    node.ClassTypeName = "BoxTrace : Trace";
                    node.FileName = "BoxTrace.cs";
                    break;

                case "traces.candlestick.attributes":
                    node.ClassTypeName = "CandlestickTrace : Trace";
                    node.FileName = "CandlestickTrace.cs";
                    break;

                case "traces.carpet.attributes":
                    node.ClassTypeName = "CarpetTrace : Trace";
                    node.FileName = "CarpetTrace.cs";
                    break;

                case "traces.cone.attributes":
                    node.ClassTypeName = "ConeTrace : Trace";
                    node.FileName = "ConeTrace.cs";
                    break;

                case "traces.choropleth.attributes":
                    node.ClassTypeName = "ChoroplethTrace : Trace";
                    node.FileName = "ChoroplethTrace.cs";
                    break;


                case "traces.choroplethmapbox.attributes":
                    node.ClassTypeName = "ChoroplethMapboxTrace : Trace";
                    node.FileName = "ChoroplethMapboxTrace.cs";
                    break;

                case "traces.contour.attributes":
                    node.ClassTypeName = "ContourTrace : Trace";
                    node.FileName = "ContourTrace.cs";
                    break;

                case "traces.contourcarpet.attributes":
                    node.ClassTypeName = "ContourCarpetTrace : Trace";
                    node.FileName = "ContourCarpetTrace.cs";
                    break;

                case "traces.densitymapbox.attributes":
                    node.ClassTypeName = "DensityMapboxTrace : Trace";
                    node.FileName = "DensityMapboxTrace.cs";
                    break;


                case "traces.funnel.attributes":
                    node.ClassTypeName = "FunnelTrace : Trace";
                    node.FileName = "FunnelTrace.cs";
                    break;

                case "traces.funnelarea.attributes":
                    node.ClassTypeName = "FunnelAreaTrace : Trace";
                    node.FileName = "FunnelAreaTrace.cs";
                    break;


                case "traces.image.attributes":
                    node.ClassTypeName = "ImageTrace : Trace";
                    node.FileName = "ImageTrace.cs";
                    break;

                case "traces.icicle.attributes":
                    node.ClassTypeName = "IcicleTrace : Trace";
                    node.FileName = "IcicleTrace.cs";
                    break;

                case "traces.indicator.attributes":
                    node.ClassTypeName = "IndicatorTrace : Trace";
                    node.FileName = "IndicatorTrace.cs";
                    break;

                case "traces.isosurface.attributes":
                    node.ClassTypeName = "IsoSurfaceTrace : Trace";
                    node.FileName = "IsoSurfaceTrace.cs";
                    break;

                case "traces.heatmap.attributes":
                    node.ClassTypeName = "HeatmapTrace : Trace";
                    node.FileName = "HeatmapTrace.cs";
                    break;

                case "traces.heatmapgl.attributes":
                    node.ClassTypeName = "HeatmapGLTrace : Trace";
                    node.FileName = "HeatmapGLTrace.cs";
                    break;

                case "traces.histogram.attributes":
                    node.ClassTypeName = "HistogramTrace : Trace";
                    node.FileName = "HistogramTrace.cs";
                    break;
                case "traces.histogram2d.attributes":
                    node.ClassTypeName = "Histogram2DTrace : Trace";
                    node.FileName = "Histogram2DTrace.cs";
                    break;


                case "traces.histogram2dcontour.attributes":
                    node.ClassTypeName = "Histogram2DContourTrace : Trace";
                    node.FileName = "Histogram2DContourTrace.cs";
                    break;



                case "traces.mesh3d.attributes":
                    node.ClassTypeName = "Mesh3DTrace : Trace";
                    node.FileName = "Mesh3DTrace.cs";
                    break;


                case "traces.ohlc.attributes":
                    node.ClassTypeName = "OhlcTrace : Trace";
                    node.FileName = "OhlcTrace.cs";
                    break;


                case "traces.parcats.attributes":
                    node.ClassTypeName = "ParallelCatsTrace : Trace";
                    node.FileName = "ParallelCatsTrace.cs";
                    break;

                case "traces.parcoords.attributes":
                    node.ClassTypeName = "ParallelCoordsTrace : Trace";
                    node.FileName = "ParallelCoordsTrace.cs";
                    break;

                case "traces.pie.attributes":
                    node.ClassTypeName = "PieTrace : Trace";
                    node.FileName = "PieTrace.cs";
                    break;

                case "traces.pointcloud.attributes":
                    node.ClassTypeName = "PointCloudTrace : Trace";
                    node.FileName = "PointCloudTrace.cs";
                    break;


                case "traces.sankey.attributes":
                    node.ClassTypeName = "SankeyTrace : Trace";
                    node.FileName = "SankeyTrace.cs";
                    break;


                case "traces.scatter.attributes":
                    node.ClassTypeName = "ScatterTrace : Trace";
                    node.FileName = "ScatterTrace.cs";
                    break;

                case "traces.scattercarpet.attributes":
                    node.ClassTypeName = "ScatterCarpetTrace : Trace";
                    node.FileName = "ScatterCarpetTrace.cs";
                    break;

                case "traces.scattergeo.attributes":
                    node.ClassTypeName = "ScatterGeoTrace : Trace";
                    node.FileName = "ScatterGeoTrace.cs";
                    break;

                case "traces.scattergl.attributes":
                    node.ClassTypeName = "ScatterGLTrace : Trace";
                    node.FileName = "ScatterGLTrace.cs";
                    break;





                case "traces.scattermapbox.attributes":
                    node.ClassTypeName = "ScatterMapboxTrace : Trace";
                    node.FileName = "ScatterMapboxTrace.cs";
                    break;


                case "traces.scatterpolar.attributes":
                    node.ClassTypeName = "ScatterPolarTrace : Trace";
                    node.FileName = "ScatterPolarTrace.cs";
                    break;
                case "traces.scatterpolargl.attributes":
                    node.ClassTypeName = "ScatterPolarGLTrace : Trace";
                    node.FileName = "ScatterPolarGLTrace.cs";
                    break;


                case "traces.scattersmith.attributes":
                    node.ClassTypeName = "ScatterSmithTrace : Trace";
                    node.FileName = "ScatterSmithTrace.cs";
                    break;


                case "traces.scatterternary.attributes":
                    node.ClassTypeName = "ScatterTernaryTrace : Trace";
                    node.FileName = "ScatterTernaryTrace.cs";
                    break;

                case "traces.scatter3d.attributes":
                    node.ClassTypeName = "Scatter3dTrace : Trace";
                    node.FileName = "Scatter3dTrace.cs";
                    break;


                case "traces.splom.attributes":
                    node.ClassTypeName = "SplomTrace : Trace";
                    node.FileName = "SplomTrace.cs";
                    break;


                case "traces.streamtube.attributes":
                    node.ClassTypeName = "StreamtubeTrace : Trace";
                    node.FileName = "StreamtubeTrace.cs";
                    break;


                case "traces.sunburst.attributes":
                    node.ClassTypeName = "SunburstTrace : Trace";
                    node.FileName = "SunburstTrace.cs";
                    break;


                case "traces.surface.attributes":
                    node.ClassTypeName = "SurfaceTrace : Trace";
                    node.FileName = "SurfaceTrace.cs";
                    break;


                case "traces.treemap.attributes":
                    node.ClassTypeName = "TreemapTrace : Trace";
                    node.FileName = "TreemapTrace.cs";
                    break;


                case "traces.violin.attributes":
                    node.ClassTypeName = "ViolinTrace : Trace";
                    node.FileName = "ViolinTrace.cs";
                    break;


                case "traces.volume.attributes":
                    node.ClassTypeName = "VolumeTrace : Trace";
                    node.FileName = "VolumeTraceTrace.cs";
                    break;


                case "traces.waterfall.attributes":
                    node.ClassTypeName = "WaterfallTrace : Trace";
                    node.FileName = "WaterfallTrace.cs";
                    break;


              

              


                case "transforms.filter.attributes":
                    node.ClassTypeName = "FilterInfo";
                    node.FileName = "FilterInfo.cs";
                    break;

                case "traces.bar.layoutAttributes":
                    node.ClassTypeName = "BarLayout:LayoutInfo";
                    node.FileName = "BarLayout.cs";
                    break;
                case "traces.box.layoutAttributes":
                    node.ClassTypeName = "BoxLayout:LayoutInfo";
                    node.FileName = "BoxLayout.cs";
                    break;

                case "traces.barpolar.layoutAttributes":
                    node.ClassTypeName = "BarpolarLyout:LayoutInfo";
                    node.FileName = "BarpolarLyout.cs";
                    break;
                case "traces.funnel.layoutAttributes":
                    node.ClassTypeName = "FunnelaLyout:LayoutInfo";
                    node.FileName = "FunnelaLyout.cs";
                    break;
                case "traces.funnelarea.layoutAttributes":
                    node.ClassTypeName = "FunnelAreaLayout:LayoutInfo";
                    node.FileName = "FunnelAreaLayout.cs";
                    break;
                case "traces.icicle.layoutAttributes":
                    node.ClassTypeName = "IcicleLayout:LayoutInfo";
                    node.FileName = "IcicleLayout.cs";
                    break;

                case "traces.pie.layoutAttributes":
                    node.ClassTypeName = "PieLayout:LayoutInfo";
                    node.FileName = "PieLayout.cs";
                    break;


                case "traces.sunburst.layoutAttributes":
                    node.ClassTypeName = "SunburstLayout:LayoutInfo";
                    node.FileName = "SunburstLayout.cs";
                    break;
                case "traces.treemap.layoutAttributes":
                    node.ClassTypeName = "TreemapLayout:LayoutInfo";
                    node.FileName = "TreemapLayout.cs";
                    break;
                case "traces.violin.layoutAttributes":
                    node.ClassTypeName = "ViolinLayout:LayoutInfo";
                    node.FileName = "ViolinLayout.cs";
                    break;
                case "traces.waterfall.layoutAttributes":
                    node.ClassTypeName = "WaterfallLayout:LayoutInfo";
                    node.FileName = "WaterfallLayout.cs";
                    break;
            



                case "layout.layoutAttributes":
                    node.ClassTypeName = "LayoutInfo";
                    node.FileName = "LayoutInfo.cs";
                    break;

                case "funnel.attributes.connector":
                    node.ClassTypeName = "FunnelConnectorInfo";
                    node.FileName = "FunnelConnectorInfo.cs";
                    break;
                case "waterfall.attributes.connector":
                    node.ClassTypeName = "WaterfallConnectorInfo";
                    node.FileName = "WaterfallConnectorInfo.cs";
                    break;
                case "surface.attributes.contours":
                    node.ClassTypeName = "SurfaceContoursInfo";
                    node.FileName = "SurfaceContoursInfo.cs";
                    break;

                case "cone.attributes.lighting":
                    node.ClassTypeName = "ConeLightingInfo";
                    node.FileName = "ConeLightingInfo.cs";
                    break;
                case "parcats.attributes.line":
                    node.ClassTypeName = "ParCatsLineInfo";
                    node.FileName = "ParCatsLineInfo.cs";
                    break;

                case "histogram2dcontour.attributes.line":
                    node.ClassTypeName = "ContourLineInfo";
                    node.FileName = "ContourLineInfo.cs";
                    break;

                case "items.layer.line":
                    node.ClassTypeName = "LayerLineInfo";
                    node.FileName = "LayerLineInfo.cs";
                    break;

                case "scattergeo.attributes.line":
                case "scatterpolargl.attributes.line":
                    node.ClassTypeName = "RadialLineInfo";
                    node.FileName = "RadialLineInfo.cs";
                    break;

                case "box.attributes.marker":
                    node.ClassTypeName = "BoxMarkerInfo";
                    node.FileName = "BoxMarkerInfo.cs";
                    break;

                case "treemap.attributes.marker":
                    node.ClassTypeName = "TreemapMarkerInfo";
                    node.FileName = "TreemapMarkerInfo.cs";
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
                case "scattermapbox.attributes.marker":
                    node.ClassTypeName = "ScatterMapboxMarkerInfo";
                    node.FileName = "ScatterMapboxMarkerInfo.cs";
                    break;

                case "ohlc.attributes.line":
                case "candlestick.attributes.line":
                    node.ClassTypeName = "FinanceLineInfo";
                    node.FileName = "FinanceLineInfo.cs";
                    break;
                case "funnel.attributes.marker":
                    node.ClassTypeName = "FunnelMarkerInfo";
                    node.FileName = "FunnelMarkerInfo.cs";
                    break;
                case "violin.attributes.marker":
                    node.ClassTypeName = "ViolinMarkerInfo";
                    node.FileName = "ViolinMarkerInfo.cs";
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

                case "scattermapbox.attributes.fill":
                    node.ClassTypeName = "MapboxFillInfo";
                    node.FileName = "MapboxFillInfo.cs";
                    break;
               

                case "scatter.attributes.fill":
                    node.ClassTypeName = "ScatterFillInfo";
                    node.FileName = "ScatterFillInfo.cs";
                    break;
                case "scatterpolar.attributes.fill":
              
                    node.ClassTypeName = "PolarFillInfo";
                    node.FileName = "PolarFillInfo.cs";
                    break;
                case "scattersmith.attributes.fill":
                    node.ClassTypeName = "SmithFillInfo";
                    node.FileName = "SmithFillInfo.cs";
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
                    node.ClassTypeName = "AxisInfo";
                    node.FileName = "AxisInfo.cs";
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
                .Replace("autorange", "AutoRange")
                
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
                .Replace("toself", "ToSelf")
                .Replace("tonext", "ToNext")
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