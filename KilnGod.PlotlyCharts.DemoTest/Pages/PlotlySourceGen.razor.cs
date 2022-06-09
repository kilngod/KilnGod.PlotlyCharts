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

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (Webfile != null)
                {
                    string? jsonschema = await Webfile.DownloadText("./_content/KilnGod.PlotlyCharts.DemoTest/plot-schema.json");
                    AreaText = jsonschema != null ? jsonschema:string.Empty;
                }

                DisabledButtons = false;
                StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }


        public List<SchemaItem> ResultSchema = new List<SchemaItem>();
        public List<SchemaItem> ResultEnumerations = new List<SchemaItem>();
        public List<SchemaItem> ResultClasses = new List<SchemaItem>();




        public void EnumerateClass(SchemaItem root)
        {
            try
            {
                switch (root.ElementType)
                {
                    case SchemaElementType.arrayOption:
                        ResultClasses.Add(root);
                        break;

                    case SchemaElementType.objectOption:
                    case SchemaElementType.classOption:
                        if (root.Enumeration == null)
                        {
                            ResultClasses.Add(root);
                        }
                        else
                        {
                            ResultEnumerations.Add(root);
                        }
                        break;
                    case SchemaElementType.enumOption:
                        ResultEnumerations.Add(root);

                        break;
                    default:
                        if (root.Enumeration != null)
                        {
                            ResultEnumerations.Add(root);
                        }
                        break;

                }


                foreach (SchemaItem item in root.Children)
                {
                    EnumerateClass(item);

                }
            }
            catch (Exception ex)
            {
                string badness = ex.Message;

            }

        }

     

        public void PublishEnumerations(SchemaItem head)
        {


            string result = string.Empty;
            string blowup = string.Empty;
            EnumerateClass(head);
            string indent = "\t\t";
            var query = ResultEnumerations.OrderBy(x => x.Name);

            string lastResultName = "";
            int lastItemCount = 0;
            SchemaItem lastItem = head;
            foreach (SchemaItem item in query)
            {
                lastItem = item;
                try
                {
                    

                    if  ((item.ElementType == SchemaElementType.enumOption) && (item.Name != lastResultName || item.Children.Count != lastItemCount))
                    {

                        string enumName = item.Name;

                        if (enumName=="type" && item.Parent != null)
                        {
                            enumName = item.Parent.Name+"Type";
                        }

                        result = result + indent + "/******************************\n";
                        result = result + indent + "*** Enum Name: "+enumName+"\n\n";
                        
                        result = result + indent + "*** Description: "+ item.Description+"\n";
                        result = result + indent + "******************************/\n\n";



                        bool isSymbol = (item.Name == "symbol");
                        
                        string itemsList = string.Empty;

                        result = result + indent+ "public enum " + CamelCaseEnumName(enumName) +"Options" + System.Environment.NewLine +indent+ "{" + System.Environment.NewLine;
                        
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

                                    itemsList += indent + "\t[Description(\"" + item.Enumeration[i-1] + "\")]\n" + indent + "\t" + CamelCapEnumItem(item.Enumeration[i]);


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
                                                itemsList += indent + "\t[Description(\"" + enumItem + "\")]\n" + indent + "\t" + CamelCapEnumItem(enumItem);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        result = result + itemsList + System.Environment.NewLine+ indent + "}" + System.Environment.NewLine + System.Environment.NewLine;
                        
                        lastResultName = item.Name;
                        lastItemCount = item.Children.Count;
                    }
                } catch (Exception ex)
                {
                    blowup = ex.Message;
                }
            }


            AreaText = result;
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
            return (enumItem);
        }

        public string CamelCaseEnumName(string enumName)
        {
            if (string.IsNullOrWhiteSpace(enumName))
            {
                return string.Empty;
            }
            enumName = enumName.Replace("align", "Align")
                .Replace("anchor", "Anchor")
                .Replace("angle", "Angle")
                
                .Replace("array", "Array")
                .Replace("axis", "Axis")
                .Replace("axref", "AXRef")               
                .Replace("ayref", "AYRef")
                .Replace("bar", "Bar")
                .Replace("bin", "Bin")
                
                .Replace("bounds", "Bounds")
                .Replace("break", "Break")
                .Replace("calendar", "Calendar")                
                .Replace("click", "Click")
                .Replace("color", "Color")
                .Replace("current", "Current")                
                .Replace("double", "Double")
                .Replace("direction", "Direction")
                .Replace("exponent", "Exponent")
                .Replace("fade", "Fade")
                .Replace("font", "Font")
                .Replace("format", "Format")
                .Replace("func", "Func")
                .Replace("gaps", "Gaps")
                .Replace("hoveron", "HoverOn")
                .Replace("info", "Info")
                .Replace("items", "Items")    
                .Replace("json", "Json")
                .Replace("label", "Label")
                .Replace("layer", "Layer")
                .Replace("line", "Line")
                .Replace("logo", "Logo")
                .Replace("method", "Method")
                .Replace("mean", "Mean")
                .Replace("menu", "Menu")
                .Replace("mode", "Mode")
                .Replace("norm", "Norm")
                .Replace("numbers", "Numbers")
                .Replace("order", "Order")
                .Replace("orientation", "Orientation")
                .Replace("others", "Others")
                .Replace("overflow", "Overflow")
                .Replace("paths", "Paths")
                .Replace("points", "Points")
                .Replace("period", "Period")
                .Replace("position", "Position")
                .Replace("prefix", "Prefix")             
                .Replace("range", "Range")
                .Replace("ratio", "Ratio")
                .Replace("DuRation","Duration")
                .Replace("revision", "Revision")
                .Replace("rule", "Rule")
                .Replace("scale", "Scale")
                .Replace("selector", "Selector")
                .Replace("shape", "Shape")
                .Replace("side", "Side")
                .Replace("sizable", "Sizable")
                .Replace("sizing", "Sizing")
                .Replace("slider", "Slider")
                .Replace("smooth", "Smooth")
                .Replace("snap", "Snap")
                .Replace("stops", "Stops")
                .Replace("suffix", "Suffix")
                .Replace("text", "Text")               
                .Replace("tick", "Tick")
                .Replace("title", "Title")
                .Replace("toshow", "ToShow")
                .Replace("toward", "Toward")
                .Replace("type", "Type")
                .Replace("unit", "Unit")
                .Replace("value", "Value")
                .Replace("xref", "XRef")
                .Replace("xside", "XSide")
                .Replace("xsize", "XSize")
                .Replace("yanchor", "YAnchor")
                .Replace("yaxis", "YAxis")
                .Replace("yref", "YRef")
                .Replace("yside", "YSide")
                .Replace("ysize", "YSize");


            enumName = enumName.Substring(0, 1).ToUpper() + enumName.Substring(1);

            for (int i = 1; i < enumName.Length; i++)
            {
                if (enumName[i] == '_')
                {
                    enumName = enumName.Substring(0, i) + enumName[i + 1].ToString().ToUpper() + enumName.Substring(i + 2);
                }
            }


            return enumName;
        }

       

        public void DigDeeper(SchemaItem currentRoot, JsonElement root)
        {
            string blowup = "";

            //   SchemaElementType ParentResult = SchemaElementType.unknownOption;


            try
            {
                bool isItems = currentRoot.Name == "items";
                JsonElement valType;
                bool isArray = false;
                bool useParent = false;
                if (root.TryGetProperty("valType", out valType))
                {
                    switch(valType.ToString())
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
                else if(isItems)
                {
                    isArray = true;
                    useParent = true;
                }
               


                if (root.ValueKind == JsonValueKind.Array || (isItems && isArray))
                {
 

                    if (root.ValueKind == JsonValueKind.Array)
                    {
                        SchemaItem schemaItem = new SchemaItem() { Name = CamelCaseEnumName(currentRoot.Name + "Items"), ElementType = SchemaElementType.arrayOption, Parent = currentRoot, Description = "Array Element" };
                        CheckTypeName(schemaItem);
                        currentRoot.Children.Add(schemaItem);

                        foreach (JsonElement element in root.EnumerateArray())
                        {

                            DigDeeper(schemaItem, element);
                        }
                    }
                    else if (useParent && currentRoot.Parent != null)
                    {
                        currentRoot = currentRoot.Parent;
                        currentRoot.Children.Clear();
                        currentRoot.Name = CamelCaseEnumName(currentRoot.Name + "Items");
                        currentRoot.CsType = CamelCaseEnumName(currentRoot.CsType + "Item");
                        currentRoot.ElementType = SchemaElementType.arrayOption;

                        foreach (JsonProperty prop in root.EnumerateObject())
                        {                          

                            DigDeeper(currentRoot, prop.Value);
                        }

                    }
                    else
                    {
                        currentRoot.ElementType = SchemaElementType.arrayOption;


                        foreach (JsonProperty prop in root.EnumerateObject())
                        {
                            currentRoot.Name = CamelCaseEnumName(prop.Name + "Item");
                            currentRoot.CsType = CamelCaseEnumName(prop.Name + "Item");

                            DigDeeper(currentRoot, prop.Value);
                        }
                    }
                }
                else
                {
                    SchemaElementType propType = SchemaElementType.unknownOption;
                    
                    switch (root.ValueKind )
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

                    foreach (JsonProperty prop in root.EnumerateObject())
                    {

                       

                        if (prop.Name.IndexOf('_')==0)
                        {
                            continue;
                        }

                     
                        if (prop.Value.ValueKind == JsonValueKind.Object)
                        {
                            objectValue = prop.Value;

                            if (objectValue.HasValue && prop.Name != "impliedEdits")
                            {
                              

                                SchemaItem simpleItem = new SchemaItem() { ElementType = propType, Name = prop.Name, CsType = ClassRename(prop.Name, currentRoot), Parent = currentRoot, Description = description };
                                if (prop.Name == "yaxis" && currentRoot.CsType.ToLower() == "rangeslider")
                                {
                                    simpleItem.ElementType = SchemaElementType.classOption;
                                }


                                CheckTypeName(simpleItem);
                                    currentRoot.Children.Add(simpleItem);
                                    DigDeeper(simpleItem, objectValue.Value);
                                
                            }

                        }

                        if (prop.Name == "impliedEdits")
                        {

                            currentRoot.EditTypeDecorator = prop.Value.ToString();
                            
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
                                    propType = SchemaElementType.enumOption;
                                    break;
                                case "integer":
                                    propType = SchemaElementType.intOption;
                                    break;
                                case "any":
                                    propType = SchemaElementType.anyOption;
                                    break;

                                case "number":
                                    propType = SchemaElementType.floatOption;
                                    break;
                                case "role":
                                    if (currentRoot.Name != "impliedEdits")
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

                           
                            currentRoot.ElementType = propType;
                        }
                        else if (prop.Name == "description")
                        {
                            currentRoot.Description = prop.Value.ToString();

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

                            currentRoot.Enumeration = enumeration;

                        }
                        else if (prop.Name == "values")
                        {
                            // an array of string
                            JsonElement enumItems = prop.Value;
                            enumeration = new List<string>();
                            foreach (var item in enumItems.EnumerateArray())
                            {
                                string value = item.ToString();
                                enumeration.Add(value);
                            }

                            currentRoot.Enumeration = enumeration;

                        }
                        else if (prop.Name == "editType")
                        {
                            currentRoot.EditTypeDecorator = prop.Value.ToString();
                        }
                        else if (prop.Name == "dflt")
                        {
                            currentRoot.DfltDecorator = prop.Value.ToString();
                        }



                    }

                    if (currentRoot.Enumeration != null && currentRoot.Enumeration.Count > 0 && currentRoot.ElementType != SchemaElementType.enumOption)
                    {
                        currentRoot.ElementType = SchemaElementType.enumOption;
                    }

                   
                    
                }



            }

            catch (Exception ex)
            {
                blowup = ex.Message;
            }


           
        }

        public void CheckTypeName(SchemaItem item)
        {
            if (item.Name.ToLower() == "type" && item.Parent !=null)
            {
                item.Name = item.Parent.Name + "Type";
            }

        }


        public string directMethodSigniture(string propertyName, string propertyType, string ValueName)
        {
            string indent = "\n\t\t\t";

            string result = indent + "public " + propertyType + "? " + propertyName;
            result += indent + "{";
            result += indent + "\tget { return (ValueItems as dynamic)." + ValueName + "; }";
            result += indent + "\tset { (ValueItems as dynamic)." + ValueName + " = value; }";
            result += indent + "}\n";


            return result;
        }

        public string fancyMethodSigniture(string propertyName, string className, string ValueName)
        {
            string indent = "\n\t\t\t";
            string indent2 = "\n\t\t\t\t";
            string indent3 = "\n\t\t\t\t\t";

            string result = indent + className + "? _" + propertyName+" = null;";
            result += indent + "public " + className + "? " + propertyName;
            result += indent + "{";
            result += indent2 + "get { return _" + propertyName+"; }";
            result += indent2 + "set";
            result += indent2 + "{";
            result += indent3 + "_" + propertyName + " = value;";
            result += indent3 + "(ValueItems as dynamic)."+ValueName+" = _"+propertyName+"?.ValueItems;";
            result += indent2 + "}";
            result += indent + "}\n";

            return result;
                     
        }


       
        public string itemsMethodSigniture(string propertyName, string className)
        {
            string indent = "\n\t\t\t";
            string indent2 = "\n\t\t\t\t";
            string indent3 = "\n\t\t\t\t\t";

            string result = indent + "ValuesCollection<"+ className + ">? _" + propertyName + " = null;";
            result += indent + "public ValuesCollection<" + className + "> " + propertyName;
            result += indent + "{";
            result += indent2 + "get";
            result += indent2 + "{ ";
            result += indent3 + "if (_" + propertyName + "==null)";
            result += indent3 + "{ ";
            result += indent3 + "\t_" + propertyName + " =  new ValuesCollection<"+ className + ">(this);";
            result += indent3 + "} ";

            result += indent3 + "return _" + propertyName + ";";
            result += indent2 + "}";
            result += indent + "}\n";

            return result;

        }

        public string enumMethodSigniture(string propertyName, string enumName, string ValueName)
        {
            string indent = "\n\t\t\t";

            string result = indent + "public " + enumName + "? " + propertyName;
            result += indent + "{";
            result += indent + "\tget { return EnumerationStatic.GetValueFromDescription<" + enumName+"> ((ValueItems as dynamic)." + ValueName + "); }";
            result += indent + "\tset { (ValueItems as dynamic)." + ValueName + " = value?.GetDescription(); }";
            result += indent + "}\n";
            return result;

        }

        public string ClassRename(string initialName, SchemaItem parent)
        {
            string result = initialName;

            string parentType = string.Empty;

            if (parent.CsType != "None")
            {
                parentType = CamelCaseEnumName(parent.CsType);
            }

            switch (initialName)
            {
                case "layer":
                    result = parentType + CamelCaseEnumName(initialName);
                    break;
                case "xaxis":
                case "yaxis":
                case "zaxis":

                case "imaginaryaxis":
                case "realaxis":

                case "aaxis":
                case "baxis":
                case "caxis":

               
                case "lataxis":
                case "lonaxis":
                    if (parentType.ToLower() == "rangeslider")
                    {
                        result = parentType + "YAxis";
                    }
                    else                            
                    {
                        result = parentType + "Axis";
                    }
                    break;
                default:
                    break;
            }

            return result;

        }

        public bool isEnterpriseName(string name)
        {
            bool result = false;
            if (name.ToLower().EndsWith("src"))
            {
                // useless 
                result = true; 
            }

            if (name.ToLower().EndsWith("chartstudio"))
            {
                // useless 
                result = true; 
            }


            return result;
        }


        public void PublishClasses(SchemaItem head)
        {
            string result = string.Empty;

            EnumerateClass(head);

            


            var query = ResultClasses.OrderBy(x => x.Name);

            string lastResultName = "";
            string indent = "\t\t";

            foreach (SchemaItem item in query)
            {
                if (item.Enumeration != null)
                {
                    // skip enums if we missed any
                    continue;
                }

                if (isEnterpriseName(item.Name))
                {
                    continue;
                }
             
                if (item.Name != lastResultName) 
                {

                    string Info = string.Empty;

                    if (!item.CsType.EndsWith("Item"))
                    {
                        Info = "Info";
                    }

                    result += indent + "public class " + CamelCaseEnumName( item.CsType) + Info + " : ValuesObject\n";
                    result += indent + "{\n\n";

                    result += indent + "\tpublic " + CamelCaseEnumName(item.CsType) + Info + "():base()";
                    result += indent + "\t{";
                    result += indent + "\t}\n";


                    var children = item.Children.OrderBy(x => x.Name);



                    foreach (SchemaItem child in children)
                    {
                        string childName = CamelCaseEnumName(child.Name);

                        if (isEnterpriseName(childName))
                        {
                            continue;
                        }

                        string childClassName = CamelCaseEnumName(child.CsType);
                        switch (child.ElementType)
                        {
                            case SchemaElementType.boolOption:
                                result = result + directMethodSigniture(childName, "bool", child.Name.ToLower());
                            break;
                            case SchemaElementType.stringOption:
                                result = result + directMethodSigniture(childName, "string", child.Name.ToLower());
                                break;
                            case SchemaElementType.angleOption:
                            case SchemaElementType.floatOption:
                                result = result + directMethodSigniture(childName, "float", child.Name.ToLower());
                                break;
                            case SchemaElementType.intOption:
                                result = result + directMethodSigniture(childName, "int", child.Name.ToLower());
                                break;
                            case SchemaElementType.anyOption:
                            case SchemaElementType.numberOption:
                            case SchemaElementType.subplotIdOption:
                                result = result + directMethodSigniture(childName, "object", child.Name.ToLower());
                                break;
                            case SchemaElementType.enumOption:
                                string enumName = child.Name;

                                if (enumName == "type" && item.Parent != null)
                                {
                                    enumName = item.Parent.Name + "Type";
                                }

                                result = result + enumMethodSigniture(childName, CamelCaseEnumName(enumName) +"Options", child.Name.ToLower());
                                break;


                            case SchemaElementType.arrayOption:
                                result = result + itemsMethodSigniture(childName + "s", CamelCaseEnumName(childClassName));
                                break;


                            case SchemaElementType.colorOption:
                            case SchemaElementType.colorListOption:
                            case SchemaElementType.colorScaleOption:

                           
                            case SchemaElementType.dataArrayOption:
                            case SchemaElementType.infoArrayOption:
                            
                           
                            
                            case SchemaElementType.unknownOption:
                            case SchemaElementType.nullOption:
                            
                                result = result + directMethodSigniture(childName, "object", child.Name.ToLower());
                                break;
                           
                            case SchemaElementType.classOption:
                            case SchemaElementType.objectOption:
                                result = result + fancyMethodSigniture(CamelCaseEnumName(childName), CamelCaseEnumName(childClassName) +"Info", child.Name.ToLower());
                                break;
                            default:
                                result = result + directMethodSigniture(childName, "badType", child.Name.ToLower()); ;
                                break;
                        }
                    }
                    
              
        

                    lastResultName = item.Name;
                    result = result + "\n"+indent + "}\n\n\n";
                }
               
            }


            AreaText = result;
            StateHasChanged();
        }

        public void GenerateSource()
        {
            JsonDocument doc = JsonDocument.Parse(AreaText);

         




            JsonElement root = doc.RootElement.GetProperty(SchemaNode);



            SchemaItem head = new SchemaItem() { Name = CamelCaseEnumName(SchemaNode), ElementType = SchemaElementType.classOption, Parent = null, Description = "Head Element", CsType= CamelCaseEnumName(SchemaNode) };


            DigDeeper(head, root);

           // PublishEnumerations(head);

            PublishClasses(head);

        }


        
    }
}
