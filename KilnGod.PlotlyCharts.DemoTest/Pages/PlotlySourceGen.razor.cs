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
using System.IO;
using KilnGod.PlotlyCharts.Services;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Enumerations.TransformsEnums;
using KilnGod.PlotlyCharts.Wrappers;

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

     
        public async void GenerateSource()
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

         

            for (int i = 0; i < mapNameItems.Count; i++)
            {
                MapNameType name = mapNameItems[i];
               
                if (name.IsEnumeration)
                {
                
                    EnumList.Add(name);
                } 
                else if (!string.IsNullOrWhiteSpace( name.ClassTypeName) && name.HasChildren && name.Name != "traces")
                {
                
                    ClassList.Add(name);

                }
            }




  

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
                                isDifferentEnum = !child.Contains("^"); // skip regex
                                if (isDifferentEnum)
                                {
                                    reason = "element not found: " + child;
                                }
                            }
                        }
                    }

                    if (isDifferentEnum)
                    {
                        reasons = reasons + System.Environment.NewLine + name.PropertyName + " " + name.Name + " != " + priorName.Name + " : " + reason;
                    }
                }

            }

            // need to clean up existing files.
            DeleteFiles("C:\\!PlotlyCode");

            if (string.IsNullOrWhiteSpace(reasons))
            {
                await PublishEnumerations();
            }
            else
            {
                AreaText = reasons;
                StateHasChanged();

                return;
            }
        
            List< MapNameType>   classItems = ClassList.OrderBy(x => x.ClassTypeName).ThenBy(x => MapNameType.ChildCount(x)).ToList();

         

            for (int i = 1; i < classItems.Count; i++)
            {
                MapNameType priorName = classItems[i - 1];
                MapNameType name = classItems[i];

                bool isDifferentClass = false;
                string reason = string.Empty;
                if (name.ClassTypeName == priorName.ClassTypeName && name.ClassTypeName != "NoPublish")
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
                            else if (mia.ElementType != child.ElementType)
                            {
                                isDifferentClass = true;
                                reason = "property is different type: " + child.Name;
                            }
                        }
                    }

                    if (isDifferentClass)
                    {
                        reasons = reasons+ System.Environment.NewLine + name.PropertyName + " " + name.LocationName + " != " + priorName.LocationName + " : " + reason;
                    }
                }
                
            }

            if (!string.IsNullOrWhiteSpace(reasons))
            {
                AreaText = reasons;
                StateHasChanged();

                return;
            }

                /*

                for (int i = 0; i < classItems.Count; i++)
                {
                    MapNameType name = classItems[i];
                    //    namelist += "\t\t\t\tnew MapNameType(){PropertyName=\""+name.PropertyName+ "\", ClassTypeName=\"" + name.ClassTypeName + "\", OriginalName=\"" + name.OriginalName + "\", FileName=\""+name.FileName+ "\", SchemaSection=\"" + name.SchemaSection + "\", JsonType=\"" + name.JsonType + "\", Name = \"" + name.Name + "\"}," + System.Environment.NewLine;
                    namelist += "PropertyName =\"" + name.PropertyName + "\", ClassTypeName=\"" + name.ClassTypeName + "\", Location=\"" + name.Name + "\"\n";
                }
                */



                foreach (var head in SchemaTree)
            {
                if (head.Name== "defs")
                {
                    continue;
                }
                PrintSchema(head, 0);
            }

            AreaText = schemaOutline;
            StateHasChanged();

            await PublishClasses();

        }


        public void DeleteFiles(string folder)
        {
            string[] files = Directory.GetFiles(folder);

            foreach (string file in files)
            {
                File.Delete(file);
            }

            string[] subfolders = Directory.GetDirectories(folder);

            foreach(string subfolder in subfolders)
            {
                DeleteFiles(subfolder);
            }
        }


        List<string> filesSaved = new List<string>();
        public async Task<bool> SaveTextFile (string fileName, string fileText)
        {
            bool result = false;
            if (!filesSaved.Contains(fileName))
            {
                using (StreamWriter file = new StreamWriter(fileName, new FileStreamOptions() { Access = FileAccess.Write, Mode = FileMode.OpenOrCreate, Options = FileOptions.Asynchronous }))
                {
                    await file.WriteAsync(fileText);
                    await file.FlushAsync();
                    file.Close();
                }
                filesSaved.Add(fileName);
                result = true;
            }
            return result;
           
        }

        public async Task PublishEnumerations()
        {


            string result = string.Empty;
            string blowup = string.Empty;

            string indent = "\t\t";

           
            int lastItemCount = 0;
            string lastClassName = string.Empty;

            EnumList = EnumList.OrderBy(x => x.ClassTypeName).ToList();
            int icnt = 0;

            foreach (MapNameType map in EnumList)
            {
                SchemaItem item = map.item;

                if (string.IsNullOrEmpty(map.ClassTypeName))
                {
                    continue;
                }

                if (map.ClassTypeName == lastClassName)
                {
                    continue;
                }

            

                icnt += 1;
               
                try
                {


                    if ((item.ElementType == SchemaElementType.enumOption || item.ElementType== SchemaElementType.flagListOption) && (map.ClassTypeName != lastClassName || item.Children.Count != lastItemCount))
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

                        result = result + indent + "public enum " + CamelCaseName(enumName) + System.Environment.NewLine + indent + "{" + System.Environment.NewLine;

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

                                    itemsList += indent + "\t[Description(\"" + item.Enumeration[i - 1] + "\")]\n" + indent + "\t" + CamelCapEnumItem(item.Enumeration[i], enumName);


                                }
                            }
                            else
                            {

                                foreach (string enumItem in item.Enumeration)
                                {






                                    if (itemsList != string.Empty)
                                    {
                                        itemsList += "," + System.Environment.NewLine;

                                    }

                                    if (enumItem == "")
                                    {
                                        itemsList += indent + "\t[Description(\"\")]\n" + indent + "\tBlank";
                                    }
                                    else if (enumItem.StartsWith("/") && enumItem.Length > 2)
                                    {
                                        itemsList += indent + "\t[Description(\"" + enumItem.Replace("\"", "\\\"") + "\")]\n" + indent + "\tRegEx_" + enumItem[2].ToString().ToUpper();
                                    }
                                    else
                                    {
                                        if (enumItem == "\\")
                                        {
                                            itemsList += indent + "\t[Description(\"" + "\\\\" + "\")]\n" + indent + "\t" + CamelCapEnumItem(enumItem, enumName);
                                        }
                                        else
                                        {
                                            itemsList += indent + "\t[Description(\"" + enumItem.Replace("True", "true").Replace("False", "false") + "\")]\n" + indent + "\t" + CamelCapEnumItem(enumItem, enumName);
                                        }
                                    }


                                }
                            }
                        }

                        result = result + itemsList + System.Environment.NewLine + indent + "}" + System.Environment.NewLine + System.Environment.NewLine;

                        lastClassName = map.ClassTypeName;
                        lastItemCount = item.Children.Count;
                    }
                }
                catch (Exception ex)
                {
                    blowup = ex.Message;
                }

                //    break;
            }


            string filename = "PlotlyEnums.cs";

            string output = SchemaExtensions.EnumerationsFileHeader.Replace("@filename@", filename) + result + "\n\n}";

            await SaveTextFile("C:\\!PlotlyCode\\Enumerations\\" + filename, output);




        }




        public async Task PublishClasses()
        {


            List<MapNameType> classItems = ClassList.OrderBy(x => x.ClassTypeName).ThenBy(x => MapNameType.ChildCount(x)).ToList();

         

            string skippedClasses = string.Empty;

            string lastClassName = "";
            string indent = "\t";
            int icnt = 0;
            for (int i = 0; i < classItems.Count; i++)
            {

                

                string result = result = SchemaExtensions.CommonFileHeader;
                string folder = "C:\\!PlotlyCode\\Common\\";

                MapNameType map = classItems[i];

                bool isItems = map.item.Children.Find(x => x.map.PropertyName == "Items") != null;

                if (map.ClassTypeName == "NoPublish" || isItems || map.ClassTypeName == string.Empty || map.SchemaSection == "defs")
                {
                    if (map.item.Children.Count > 0)
                    {
                        skippedClasses += map.Name + "\t" + map.ClassTypeName + "\t" + map.PropertyName + "\n";
                    }

                    continue;
                }

                switch(map.SchemaSection)
                {
                    case "animation":
                        result = SchemaExtensions.AnimationFileHeader;
                        folder = "C:\\!PlotlyCode\\Animation\\";
                        break;
                    case "config":
                        result = SchemaExtensions.ConfigFileHeader;
                        folder = "C:\\!PlotlyCode\\Config\\";
                        break;
                    case "frames":
                        result = SchemaExtensions.FramesFileHeader;
                        folder = "C:\\!PlotlyCode\\Frames\\";
                        break;
                    case "layout":
                        result = SchemaExtensions.LayoutFileHeader;
                        folder = "C:\\!PlotlyCode\\Layouts\\";
                        if (!map.ClassTypeName.Contains(": Layout") && map.ClassTypeName != "Layout")
                        {
                            result = SchemaExtensions.CommonFileHeader;
                            folder = "C:\\!PlotlyCode\\Common\\";
                        }
                        break;
                    case "traces":
                        result = SchemaExtensions.TracesFileHeader;
                        folder = "C:\\!PlotlyCode\\Traces\\";

                        if (map.ClassTypeName.Contains(": Layout") || map.ClassTypeName == "Layout")
                        {
                            result = SchemaExtensions.LayoutFileHeader;
                            folder = "C:\\!PlotlyCode\\Layouts\\";
                        }
                        else if (!map.ClassTypeName.Contains(": Trace"))
                        {
                            result = SchemaExtensions.CommonFileHeader;
                            folder = "C:\\!PlotlyCode\\Common\\";
                        }

                        break;
                    case "transforms":
                        result = SchemaExtensions.TransformsFileHeader;
                        folder = "C:\\!PlotlyCode\\Transforms\\";
                        break;

                }


                string fileName = map.FileName;

                if (string.IsNullOrEmpty(fileName))
                {
                    fileName = map.ClassTypeName + ".cs";
                }
                if (string.IsNullOrEmpty(map.ClassTypeName))
                {
                    fileName = map.PropertyName + ".cs";
                }

                result = result.Replace("@filename@", map.FileName);



                SchemaItem item = map.item;
                if (item.Enumeration != null)
                {
                    // skip enums if we missed any
                    continue;
                }

                if (isEnterpriseName(item.Name))
                {
                    continue;
                }

                if (map.ClassTypeName != lastClassName)
                {

                    string Info = string.Empty;

                    if (!item.CsType.EndsWith("Item"))
                    {
                        Info = "Info";
                    }

                    if (map.ClassTypeName.Contains(":"))
                    {
                        result += indent + "public class " + map.ClassTypeName + "\n";
                        result += indent + "{\n\n";

                        result += indent + "\tpublic " + map.ClassTypeName.Substring(0, map.ClassTypeName.IndexOf(":") - 1) + "():base()";

                    }
                    else
                    {
                        result += indent + "public class " + map.ClassTypeName + " : ValuesObject\n";
                        result += indent + "{\n\n";

                        result += indent + "\tpublic " + map.ClassTypeName + "():base()";

                    }

                    result += indent + "\t{";
                    result += indent + "\t}\n";


                    var children = item.Children.OrderBy(x => x.Name);


                    foreach (SchemaItem child in children)
                    {



                        MapNameType childMap = child.map;

                        string childName = childMap.PropertyName;

                        if (childName == String.Empty)
                        {
                            childName = CamelCaseName(childMap.item.Name);
                        }

                        if (isEnterpriseName(childName))
                        {
                            continue;
                        }

                        if (childMap.IsEnumeration)
                        {
                            FixEnumNames(childMap);
                            if (!FixEnumNames(childMap))
                            {
                                string enumIssue = childMap.LocationName + "\t" + childMap.Name;

                                if (unmappedEnums.Find(x => x == enumIssue) == null)
                                {
                                    unmappedEnums.Add(enumIssue);
                                }
                            }
                        }

                        string childClassName = childMap.ClassTypeName;
                        if (childMap.ClassTypeName == String.Empty)
                        {
                            childClassName = CamelCaseName(childMap.item.Name);
                        }

                        if (childMap.item.IsItemList)
                        {
                            SchemaItem itemList = childMap.item.Children[0];


                            if (itemList.Children.Count > 0)
                            {
                                SchemaItem childItem = itemList.Children[0];
                                MapNameType childItemMap = childItem.map;

                                if (string.IsNullOrEmpty(childItemMap.ClassTypeName))
                                {
                                    FixClassNames(childItemMap);
                                }

                                string itemClassName = childItemMap.ClassTypeName;

                                if (string.IsNullOrEmpty(itemClassName))
                                {
                                    itemClassName = childItemMap.PropertyName + "Item";
                                }

                                itemClassName = itemClassName.Replace("TransformItem", "Transform");// do not item transform

                                result = result + itemsMethodSigniture(childMap.PropertyName, itemClassName, childMap.item.Name);
                            }

                        }
                        else
                            switch(child.ElementType)
                            {
                                case SchemaElementType.boolOption:
                                    result = result + directMethodSigniture(childName, "bool", child.Name.ToLower());
                                    break;
                                case SchemaElementType.stringOption:
                                    result = result + directMethodSigniture(childName, "string", child.Name.ToLower());
                                    break;
                                case SchemaElementType.angleOption:
                                case SchemaElementType.doubleOption:
                                    result = result + directMethodSigniture(childName, "double", child.Name.ToLower());
                                    break;
                                case SchemaElementType.intOption:
                                    result = result + directMethodSigniture(childName, "int", child.Name.ToLower());
                                    break;
                                case SchemaElementType.anyOption:
                                case SchemaElementType.numberOption:
                                case SchemaElementType.subplotIdOption:
                                    result = result + directMethodSigniture(childName, "object", child.Name.ToLower());
                                    break;
                                case SchemaElementType.flagListOption:

                                    string flagClassName = childMap.ClassTypeName;



                                    if (string.IsNullOrEmpty(childMap.ClassTypeName))
                                    {
                                        flagClassName = childMap.PropertyName + "Options";
                                    }
                                    result = result + flaglistMethodSigniture(childName, flagClassName, child.Name.ToLower());
                                    break;

                                case SchemaElementType.enumOption:
                                    string enumName = child.Name;

                                    if (enumName == "type" && item.Parent != null)
                                    {
                                        enumName = item.Parent.Name + "Type";
                                    }


                                    string enumClassName = childMap.ClassTypeName;



                                    if (string.IsNullOrEmpty(childMap.ClassTypeName))
                                    {
                                        enumClassName = childMap.PropertyName + "Options";
                                    }

                                    result = result + enumMethodSigniture(childName, enumClassName, child.Name.ToLower());
                                    break;




                                case SchemaElementType.colorOption:
                                case SchemaElementType.colorListOption:
                                case SchemaElementType.colorScaleOption:

                                case SchemaElementType.arrayOption:
                                case SchemaElementType.dataArrayOption:
                                case SchemaElementType.infoArrayOption:



                                case SchemaElementType.unknownOption:
                                case SchemaElementType.nullOption:

                                    result = result + directMethodSigniture(childName, "object", child.Name.ToLower());
                                    break;

                                case SchemaElementType.classOption:
                                case SchemaElementType.objectOption:

                                    string className = childMap.ClassTypeName;


                                    if (childMap.HasChildren && childMap.item.Children.Count == 1 && className == "noPublish" && !string.IsNullOrEmpty(childMap.item.Children[0].map.ClassTypeName))
                                    {
                                        className = childMap.item.Children[0].map.ClassTypeName;

                                        result = result + fancyMethodSigniture(CamelCaseName(childName), className, child.Name.ToLower());
                                    }
                                    else if (childMap.HasChildren)
                                    {
                                        if (string.IsNullOrEmpty(className))
                                        {
                                            className = CamelCaseName(childName) + "Info";
                                        }
                                        result = result + fancyMethodSigniture(CamelCaseName(childName), className, child.Name.ToLower());
                                    }
                                    else
                                    {
                                        result = result + directMethodSigniture(childName, "object", child.Name.ToLower());
                                    }

                                    break;
                                default:
                                    result = result + directMethodSigniture(childName, "badType", child.Name.ToLower()); ;
                                    break;
                            }
                    }




                    lastClassName = map.ClassTypeName;
                    result = result + "\n" + indent + "}\n}\n\n";
                    bool savedAFile = await SaveTextFile(folder + fileName, result);
                    if (savedAFile)
                    {
                        icnt += 1;
                    }

                }

            }

            string badEnums = string.Empty;
            foreach (string item in unmappedEnums)
            {
                badEnums += item + "\n";
            }

            AreaText = "Generated " + icnt.ToString() + " Classes\n\nUnmapped Enums:\n"
                + badEnums + "\n\nSkipped Classes:\n"
                + skippedClasses+"\n\nOther:\n"
                + AreaText;
            StateHasChanged();
        }

        /*
         public object? Base
		{
			get { return (ValueItems as IDictionary<string, Object?>)["base"]; }
			set { (ValueItems as IDictionary<string, Object?>)["base"] = value; }
		}
 
         * */

        public static string[] reservedKeywords = new string[] { "base" };
        public string directMethodSigniture(string propertyName, string propertyType, string ValueName)
        {
            string indent = "\n\t\t";

            string result = string.Empty;

            if (reservedKeywords.Contains(ValueName)) 
            {
                //can't be typed
                result += indent + "public object? " + propertyName;
                result += indent + "{";
                result += indent + "\tget { return (ValueItems as IDictionary<string, Object?>)[\"" + ValueName + "\"]; }";
                result += indent + "\tset { (ValueItems as IDictionary<string, Object?>)[\"" + ValueName + "\"] = value; }";
                result += indent + "}\n";
            }
            else
            {
                result += indent + "public " + propertyType + "? " + propertyName;
                result += indent + "{";
                result += indent + "\tget { return (ValueItems as dynamic)." + ValueName + "; }";
                result += indent + "\tset { (ValueItems as dynamic)." + ValueName + " = value; }";
                result += indent + "}\n";

            }

            return result;
        }

        public string fancyMethodSigniture(string propertyName, string className, string ValueName)
        {
            string indent = "\n\t\t";
            string indent2 = "\n\t\t\t";
            string indent3 = "\n\t\t\t\t";

            string result = indent + className + "? _" + propertyName + " = null;";
            result += indent + "public " + className + "? " + propertyName;
            result += indent + "{";
            result += indent2 + "get { return _" + propertyName + "; }";
            result += indent2 + "set";
            result += indent2 + "{";
            result += indent3 + "_" + propertyName + " = value;";
            result += indent3 + "(ValueItems as dynamic)." + ValueName + " = _" + propertyName + "?.ValueItems;";
            result += indent2 + "}";
            result += indent + "}\n";

            return result;

        }



        public string itemsMethodSigniture(string propertyName, string className, string ValueName)
        {
            string indent = "\n\t\t";
            string indent2 = "\n\t\t\t";
            string indent3 = "\n\t\t\t\t";

            string result = indent + "ItemList<" + className + ">? _" + propertyName + " = null;";
            result += indent + "public ItemList<" + className + ">? " + propertyName;
            result += indent + "{";
            result += indent2 + "get";
            result += indent2 + "{ ";
            result += indent3 + "return _" + propertyName + ";";
            result += indent2 + "}";
            result += indent2 + "set";
            result += indent2 + "{ ";
            result += indent3 + "_" + propertyName + " = value;";
            result += indent3 + "(ValueItems as dynamic)." + ValueName + " = _" + propertyName + "?.Values;";
            result += indent2 + "}";
            result += indent + "}\n";

            return result;

          

        }

        public string enumMethodSigniture(string propertyName, string enumName, string ValueName)
        {
            string indent = "\n\t\t";

            string result = indent + "public " + enumName + "? " + propertyName;
            result += indent + "{";
            result += indent + "\tget { return EnumerationStatic.GetValueFromDescription<" + enumName + "> ((ValueItems as dynamic)." + ValueName + "); }";
            result += indent + "\tset { (ValueItems as dynamic)." + ValueName + " = value?.GetDescription(); }";
            result += indent + "}\n";
            return result;

        }

        public string flaglistMethodSigniture(string propertyName, string enumName, string ValueName)
        {
            string indent = "\n\t\t";

            string result = indent+ enumName + "[]? _" + propertyName+" = null;";
            result += indent + "public " + enumName + "[]? " + propertyName ;
            result += indent + "{";
            result += indent + "\tget { return _" + propertyName+"; }";
            result += indent + "\tset";
            result += indent + "\t{";
            result += indent + "\t\t_" + propertyName + " = value;";
            result += indent + "\t\tif (value != null)";
            result += indent + "\t\t{";
            result += indent + "\t\t\t(ValueItems as dynamic)." + ValueName + " = EnumerationStatic.MakeFlagList(value);";
            result += indent + "\t\t}";
            result += indent + "\t}";
            result += indent + "}\n";
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


        public string CamelCapEnumItem(string enumItem, string enumName)
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

            switch(enumItem)
            {
                case "":
                    enumItem = "Blank";
                    break;
                case "l":
                    enumItem = "L";
                    break;

                case "r":
                    enumItem = "R";

                    break;

                case "t":
                    enumItem = "T";

                    break;

                case "b":
                    enumItem = "B";

                    break;

                case "axrange":
                    enumItem = "AXRange";
                    break;
                case "colorbars":
                    enumItem = "ColorBars";
                    break;
                case "modebar":
                    enumItem = "ModeBar";
                    break;
                case "todate":
                    enumItem = "ToDate";
                    break;
                case "onout":
                    enumItem = "OnOut";
                    break;
                case "relayout":
                    enumItem = "RelayOut";
                    break;
                case "afterall":
                    enumItem = "AfterAll";
                    break;
                case "freeform":
                    enumItem = "FreeForm";
                    break;
                case "all":
                    enumItem = "All";
                    break;

                case "a":
                    enumItem = "A";
                    break;

                case "c":
                    enumItem = "C";
                    break;
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
                case "stddev":
                    enumItem = "StdDev";
                    break;
                case "usa":
                    enumItem = "USA";
                    break;

                case "50":
                    enumItem = "_50";
                    break;

                case "110":
                    enumItem = "_110";
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
                case "u":
                    enumItem = "U";
                    break;

                case "v":
                    if (enumName.ToLower().Contains("direction") || enumName.ToLower().Contains("orientation"))
                    {
                        enumItem = "Vertical";
                    }
                    else
                    {
                        enumItem = "V";
                    }
                    break;
                case "w":
                    enumItem = "W";
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

            enumItem = enumItem
               .Replace("-out", "-Out");

            enumItem = enumItem.Replace(" ", "_").Replace("-", "_");


            for (int i = 1; i < enumItem.Length; i++)
            {
                if (enumItem[i] == '_')
                {
                    enumItem = enumItem.Substring(0, i) + enumItem[i + 1].ToString().ToUpper() + enumItem.Substring(i + 2);
                }
            }


            enumItem = enumItem
               .Replace("size", "Size")
               .Replace("draw", "Draw")
               .Replace("off", "Off")
               .Replace("+auto","_Auto")
               .Replace("closed", "Closed")
               .Replace("open", "Open")
               .Replace("path", "Path")
               .Replace("line", "Line")
               .Replace("rect", "Rect")
               .Replace("circle", "Circle")
               .Replace("json", "JSON")
               .Replace("others", "Others")
               .Replace("odd", "Odd")
               .Replace("zero", "Zero")
               .Replace("dash", "Dash")
               .Replace("dot", "Dot")
               .Replace("hsla", "HSLA")
               .Replace("hsl", "HSL")
               .Replace("rgba", "RGBA")
               .Replace("rgb", "RGB")
               .Replace("self", "Self")
               .Replace("next", "Next")
               .Replace("even", "Even")
               .Replace("only", "Only")
               .Replace("ticks", "Ticks");


            if (enumItem.Length > 1)
            {
                enumItem = enumItem.Substring(0, 1).ToUpper() + enumItem.Substring(1);
            }
           
           

            return (enumItem);
        }

        public List<string> unmappedEnums = new List<string>();

        public void MapNames(SchemaItem node, List<MapNameType> names, string schemaSection)
        {
            if (node.Name.IndexOf("src")>0)
            {
                return;
            }

            string locationName = string.Empty;

            if (node.Parent != null && !node.Name.Contains("."))
            {
                if (node.Name.EndsWith("dimension") && node?.Parent?.Parent?.Parent?.Parent != null)
                {
                    locationName = node.Parent.Parent.Parent.Parent.Name + "." + node.Parent.Parent.Parent.Name + "."
                        + node.Parent.Parent.Name + "." + node.Parent.Name + "." + node.Name;
                }

                if (node?.Parent?.Parent != null )
                {
                    locationName = node.Parent.Parent.Name + "." + node.Parent.Name + "." + node.Name;
                }
                else if (node?.Parent != null)
                {
                    locationName = node.Parent.Name +"." + node.Name;
                }
            }
            else
            {
                locationName = node.Name;
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

                LocationName = locationName,
                
                item = node

            };

            // no idea how this got set weirdly.
            if (name.PropertyName.IndexOf(".")>0)
            {
                name.PropertyName = CamelCaseName( name.PropertyName.Substring(name.PropertyName.IndexOf(".")+1));
                name.JsonType = SchemaElementType.subplotIdOption.ToString();
            }

            node.map = name;

            if (name.IsEnumeration)
            {
                name.ClassTypeName = name.PropertyName + "Options";

                FixEnumNames(name);
            } 
            else if (name.HasChildren)
            {
                if (node.Parent != null && node.Parent.Name == "traces")
                {
                    name.ClassTypeName = name.PropertyName + "Trace";
                }
                else
                {
                    name.ClassTypeName = name.PropertyName + "Info";
                }
                FixClassNames(name);
            }

            if (!string.IsNullOrEmpty(name.ClassTypeName) && string.IsNullOrEmpty(name.FileName))
            {
                name.FileName = name.ClassTypeName + ".cs";
            }


            /*
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
             */
            if (names.FindIndex(x => x.LocationName == name.LocationName && x.FileName==name.FileName) <0)
            {
                names.Add(name);
            }
           


            foreach (SchemaItem child in node.Children)
            {
                MapNames(child, names, schemaSection);
            }
        }

        public string schemaOutline = string.Empty;
        public void PrintSchema(SchemaItem node, int indent)
        {
            if (indent == 0)
            {
                schemaOutline += "\n\n\n";
            }

            string nodeText = string.Empty;
            string indenttabs = "\t";
            for(int i=0; i< indent; i++)
            {
                indenttabs += "\t";
            }

            if (string.IsNullOrEmpty(node.map.ClassTypeName))
            {
                FixClassNames(node.map);
            }

            nodeText +=  node.ElementType.ToString()+ "\t" + node.map.LocationName + "\t" + node.map.ClassTypeName+ "\t" + node.map.FileName+indenttabs+ node.map.PropertyName + "\n";

            schemaOutline += nodeText;

            foreach(SchemaItem child in node.Children)
            {
                PrintSchema(child, indent + 1);
            }

        }
        public void MapSchema(SchemaItem node, JsonElement root)
        {
            bool isItems = node.Name == "items";
            JsonElement valType;
            bool isArray = false;
            bool useParent = false;
            if (node.Name.ToLower()== "dflt")
            {
                // to be ignored
                return;
            }
            if (root.ValueKind != JsonValueKind.String)
            {
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
                    SchemaItem schemaItem = new SchemaItem() { Name = node.Name, ElementType = SchemaElementType.arrayOption, Parent = node, Description = "Array Element" };
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

                        node.Name = prop.Name;
                        node.CsType = prop.Name;

                        MapSchema(node, prop.Value);
                    }
                }
            }
            else
            {
                SchemaElementType propType = SchemaElementType.unknownOption;

                switch(root.ValueKind)
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
                switch(root.ValueKind)
                {
                    case JsonValueKind.String:
                      

                        break;
                    default:
                        bool arrayOk = false;

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

                                if (objectValue.HasValue && prop.Name.ToLower() != "impliededits" && prop.Name.ToLower()!= "dflt")
                                {


                                    SchemaItem simpleItem = new SchemaItem() { ElementType = propType, Name = prop.Name, CsType = prop.Name, Parent = node, Description = description };


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

                                switch(jsontype)
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
                            else if (prop.Name == "arrayOk" && prop.Value.ToString() == "true")
                            {
                                arrayOk = true;
                                node.ElementType = SchemaElementType.arrayOption;
                            }

                            if (arrayOk && node.ElementType != SchemaElementType.arrayOption)
                            {
                                node.ElementType = SchemaElementType.arrayOption;
                            }

                            switch (node.Name.ToLower())
                            {
                                case "size":
                                case "opacity":
                                case "text":
                                case "width":
                                case "x":
                                case "y":
                                case "z":
                                    JsonElement arrayOkElement;
                                    if (root.TryGetProperty("arrayOk", out arrayOkElement))
                                    {
                                        if (arrayOkElement.ValueKind.ToString().ToLower() == "true" && !arrayOk)
                                        {
                                            node.ElementType = SchemaElementType.arrayOption;
                                            arrayOk = true;

                                        }
                                    }
                                    break;
                            }
                           

                        }
                        break;
                }

                if (node.Enumeration != null && node.Enumeration.Count > 0 && !(node.ElementType == SchemaElementType.enumOption || node.ElementType == SchemaElementType.flagListOption))
                {
                    node.ElementType = SchemaElementType.enumOption;
                }

                

            }

        }


        public bool FixEnumNames(MapNameType node)
        {
            bool result = true;
            switch(node.LocationName)
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
                    node.ClassTypeName = "CategoryOrderLayoutOptions";
                    node.FileName = "CategoryOrderLayoutOptions.cs";
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
                    node.ClassTypeName = "AutoDateCategoryLinearTypeOptions";
                    node.FileName = "AutoDateCategoryLinearTypeOptions.cs";
                    break;

                case "dimension.axis.type":
                    node.ClassTypeName = "CategoryDateLinearLogAxisTypeOptions";
                    node.FileName = "CategoryDateLinearLogAxisTypeOptions.cs";
                    break;

                case "scene.xaxis.type":
                case "scene.yaxis.type":
                case "scene.zaxis.type":
                case "polar.radialaxis.type":
                    node.ClassTypeName = "ViewAxisTypeOptions";
                    node.FileName = "ViewAxisTypeOptions.cs";
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
                case "link.hoverlabel.align":
                case "node.hoverlabel.align":


                    node.ClassTypeName = "HoverLabelAlignOptions";
                    node.FileName = "HoverLabelAlignOptions.cs";
                    break;

         
                case "items.shape.layer":
                case "items.image.layer":
                    node.ClassTypeName = "LayerOptions";
                    node.FileName = "LayerOptions.cs";
                    break;
             

           

                case "attributes.header.align":
                case "attributes.cells.align":
                case "slider.currentvalue.xanchor":
                case "attributes.colorbar.xanchor":
                case "marker.colorbar.xanchor":
                case "attributes.title.align":
                case "line.colorbar.xanchor":
                case "items.image.xanchor":
                case "coloraxis.colorbar.xanchor":
                case "indicator.attributes.align":
                case "items.annotation.align":

                    node.ClassTypeName = "XAlignOptions";
                    node.FileName = "XAlignOptions.cs";
                    break;

                case "bar.attributes.insidetextanchor":
                case "bar.attributes.xperiodalignment":
                case "bar.attributes.yperiodalignment":
                case "box.attributes.yperiodalignment":
                case "box.attributes.xperiodalignment":
                case "candlestick.attributes.xperiodalignment":
                case "contour.attributes.xperiodalignment":
                case "contour.attributes.yperiodalignment":
                case "funnel.attributes.insidetextanchor":
                case "funnel.attributes.xperiodalignment":
                case "funnel.attributes.yperiodalignment":
                case "heatmap.attributes.xperiodalignment":
                case "heatmap.attributes.yperiodalignment":
                case "histogram.attributes.insidetextanchor":
                case "ohlc.attributes.xperiodalignment":
                case "scatter.attributes.xperiodalignment":
                case "scatter.attributes.yperiodalignment":
                case "scattergl.attributes.xperiodalignment":
                case "scattergl.attributes.yperiodalignment":
                case "waterfall.attributes.insidetextanchor":
                case "waterfall.attributes.xperiodalignment":
                case "waterfall.attributes.yperiodalignment":

                    node.ClassTypeName = "StartMiddleEndOptions";
                    node.FileName = "StartMiddleEndOptions.cs";
                    break;


                case "items.annotation.xanchor":
                case "layoutAttributes.legend.xanchor":



                    node.ClassTypeName = "XAutoAlignOptions";
                    node.FileName = "XAutoAlignOptions.cs";
                    break;

                case "newshape.line.dash":
                case "layoutAttributes.xaxis.spikedash":
                case "layoutAttributes.yaxis.spikedash":
                    node.ClassTypeName = "SpikeDashOptions";
                    node.FileName = "SpikeDashOptions.cs";
                    break;


                case "items.shape.xsizemode":
                case "items.shape.ysizemode":
                    node.ClassTypeName = "ShapeSizeModeOptions";
                    node.FileName = "ShapeSizeModeOptions.cs";
                    break;

                case "items.annotation.xref":
                case "items.shape.xref":
                    node.ClassTypeName = "XRefOptions";
                    node.FileName = "XRefOptions.cs";
                    break;

                case "items.annotation.yref":
                case "items.shape.yref":
                    node.ClassTypeName = "YRefOptions";
                    node.FileName = "YRefOptions.cs";
                    break;

                case "layoutAttributes.title.xref":
                case "layoutAttributes.title.yref":
                    node.ClassTypeName = "TitleRefOptions";
                    node.FileName = "TitleRefOptions.cs";
                    break;

                case "box.layoutAttributes.boxmode":
                case "violin.layoutAttributes.violinmode":
                case "waterfall.layoutAttributes.waterfallmode":
                case "candlestick.layoutAttributes.boxmode":
                    node.ClassTypeName = "GroupOverlayBoxModeOptions";
                    node.FileName = "GroupOverlayBoxModeOptions.cs";
                    break;

                case "attributes.aaxis.tickmode":
                case "attributes.baxis.tickmode":
                    node.ClassTypeName = "LinearArrayTickModeOptions";
                    node.FileName = "LinearArrayTickModeOptions.cs";
                    break;
                case "polar.angularaxis.tickmode":
                case "polar.radialaxis.tickmode":
                case "marker.colorbar.tickmode":
                case "scene.xaxis.tickmode":
                case "scene.yaxis.tickmode":
                case "scene.zaxis.tickmode":
                case "ternary.aaxis.tickmode":
                case "ternary.baxis.tickmode":
                case "ternary.caxis.tickmode":
                case "line.colorbar.tickmode":
                case "coloraxis.colorbar.tickmode":
                case "attributes.colorbar.tickmode":
                case "gauge.axis.tickmode":
                case "layoutAttributes.xaxis.tickmode":
                case "layoutAttributes.yaxis.tickmode":

                    node.ClassTypeName = "AutoLinearArrayTickModeOptions";
                    node.FileName = "AutoLinearArrayTickModeOptions.cs";
                    break;

          

                case "items.rangebreak.pattern":
                    node.ClassTypeName = "RangeBreakPatternOptions";
                    node.FileName = "RangeBreakPatternOptions.cs";
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
                    node.ClassTypeName = "DimensionCategoryOrderOptions";
                    node.FileName = "DimensionCategoryOrderOptions.cs";
                    break;

                case "attributes.title.position":
                    node.ClassTypeName = "TitlePositionOptions";
                    node.FileName = "TitlePositionOptions.cs";
                    break;
                case "attributes.fillpattern.shape":
                case "marker.pattern.shape":
                    node.ClassTypeName = "ShapeFillPatternOptions";
                    node.FileName = "ShapeFillPatternOptions.cs";
                    break;

                case "attributes.gauge.shape":
                    node.ClassTypeName = "ShapeGaugeOptions";
                    node.FileName = "ShapeGaugeOptions.cs";
                    break;

                case "attributes.line.shape":
                    switch (node.item.Parent.Parent.Parent.Name)
                    {
                        case "parcats":
                            node.ClassTypeName = "ShapeLineParCatsOptions";
                            node.FileName = "ShapeLineParCatsOptions.cs";
                            break;
                        case "scatter":
                            node.ClassTypeName = "ShapeLineScatterOptions";
                            node.FileName = "ShapeLineScatterOptions.cs";
                            break;
                        case "scatterpolargl":
                        case "scattergl":
                            node.ClassTypeName = "ShapeLineScatterGLOptions";
                            node.FileName = "ShapeLineScatterGLOptions.cs";
                            break;
                        default:
                            node.ClassTypeName = "ShapeLineOptions";
                            node.FileName = "ShapeLineOptions.cs";
                            break;
                    }
                    break;
                case "cone.attributes.sizemode":
                    node.ClassTypeName = "SizeModeConeOptions";
                    node.FileName = "SizeModeConeOptions.cs";
                    break;

                case "scatter.attributes.sizemode":
                    node.ClassTypeName = "SizeModeOptions";
                    node.FileName = "SizeModeOptions.cs";
                    break;

                case "rangeslider.yaxis.rangemode":
                    node.ClassTypeName = "RangeModeSliderOptions";
                    node.FileName = "RangeModeSliderOptions.cs";
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

                case "scattermapbox.attributes.fill":
                    node.ClassTypeName = "FillMapboxOptions";
                    node.FileName = "FillMapboxOptions.cs";
                    break;


                case "scatter.attributes.fill":
                case "scattergl.attributes.fill":
                    node.ClassTypeName = "FillScatterOptions";
                    node.FileName = "FillScatterOptions.cs";
                    break;

                case "scatterpolar.attributes.fill":

                    node.ClassTypeName = "FillPolarOptions";
                    node.FileName = "FillPolarOptions.cs";
                    break;
                case "scatterpolargl.attributes.fill":

                    node.ClassTypeName = "FillPolarGLOptions";
                    node.FileName = "FillPolarGLOptions.cs";
                    break;

                case "scattersmith.attributes.fill":
                    node.ClassTypeName = "FillSmithInfo";
                    node.FileName = "FillSmithInfo.cs";
                    break;

          

                case "items.updatemenu.direction":
                    node.ClassTypeName = "MenuDirectionOptions";
                    node.FileName = "MenuDirectionOptions.cs";
                    break;

                case "animation.direction":
                    node.ClassTypeName = "DirectionAnimationOptions";
                    node.FileName = "DirectionAnimationOptions.cs";
                    break;


                case "layoutAttributes.xaxis.anchor":
                case "layoutAttributes.yaxis.anchor":
                    node.ClassTypeName = "AnchorAxisOptions";
                    node.FileName = "AnchorAxisOptions.cs";
                    break;

                case "cone.attributes.anchor":
                    node.ClassTypeName = "AnchorConeOptions";
                    node.FileName = "AnchorConeOptions.cs";
                    break;

                case "polar.angularaxis.layer":
                    node.ClassTypeName = "AngularAxisLayerOptions";
                    node.FileName = "AngularAxisLayerOptions.cs";
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
                    node.ClassTypeName = "AutoCategoryLinearAxisTypeOptions";
                    node.FileName = "AutoCategpryLinearAxisTypeOptions.cs";
                    break;
             
                case "barpolar.attributes.thetaunit":
                    node.ClassTypeName = "BarPolarThetaUnitOptions";
                    node.FileName = "BarPolarThetaUnitOptions.cs";
                    break;

                case "attributes.delta.position":
                case "layoutAttributes.xaxis.side":
                case "layoutAttributes.yaxis.side":
                    node.ClassTypeName = "PositionOptions";
                    node.FileName = "PositionOptions.cs";
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
                case "bar.attributes.textposition":
                case "pie.attributes.textposition":
                    node.ClassTypeName = "TextPositionOptions";
                    node.FileName = "TextPositionOptions.cs";
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
                    node.ClassTypeName = "ModeUniformTextOptions";
                    node.FileName = "ModeUniformTextOptions.cs";
                    break;
                case "animation.mode":
                    node.ClassTypeName = "ModeAnimationOptions";
                    node.FileName = "ModeAnimationOptions.cs";
                    break;
                case "attributes.connector.mode":
                    node.ClassTypeName = "ModeConnectorOptions";
                    node.FileName = "ModeConnectorOptions.cs";
                    break;
                case "scatter3d.attributes.mode":
                case "scatter.attributes.mode":
                case "scattercarpet.attributes.mode":
                case "scattergeo.attributes.mode":
                case "scattergl.attributes.mode":
                case "scattermapbox.attributes.mode":
                case "scatterpolar.attributes.mode":
                case "scatterpolargl.attributes.mode":
                case "scattersmith.attributes.mode":
                case "scatterternary.attributes.mode":
             

                    node.ClassTypeName = "ModeScatterOptions";
                    node.FileName = "ModeScatterOptions.cs";
                    break;

                case "indicator.attributes.mode":
                    node.ClassTypeName = "ModeIndicatorOptions";
                    node.FileName = "ModeIndicatorOptions.cs";
                    break;

                case "waterfall.connector.mode":
                    node.ClassTypeName = "ModeCoonectorWaterallOptions";
                    node.FileName = "ModeCoonectorWaterallOptions.cs";
                    break;

                case "violin.attributes.side":
                    node.ClassTypeName = "ViolinSideOptions";
                    node.FileName = "ViolinSideOptions.cs";
                    break;
                
               
                case "smith.realaxis.ticks":

                    node.ClassTypeName = "TopBottomBlankOptions";
                    node.FileName = "TopBottomBlankOptions.cs";
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

                case "layoutAttributes.legend.itemclick":
                case "layoutAttributes.legend.itemdoubleclick":
                    node.ClassTypeName = "ItemClickOptions";
                    node.FileName = "ItemClickOptions.cs";
                    break;

                case "attributes.pathbar.side":
                case "parcoords.attributes.labelside":
                case "smith.realaxis.side":
                    node.ClassTypeName = "TopBottomOptions";
                    node.FileName = "TopBottomOptions.cs";
                    break;


                case "items.slider.yanchor":
                case "items.annotation.yanchor":
                case "layoutAttributes.legend.yanchor":
                case "layoutAttributes.title.yanchor":
                case "items.updatemenu.yanchor":
                case "xaxis.rangeselector.yanchor":
                    node.ClassTypeName = "AutoTopMiddleBottomOptions";
                    node.FileName = "AutoTopMiddleBottomOptions.cs";
                    break;



                case "coloraxis.colorbar.yanchor":
                case "items.annotation.valign":
                case "items.image.yanchor":
                case "layoutAttributes.legend.valign":
                case "line.colorbar.yanchor":
                case "marker.colorbar.yanchor":
                case "attributes.colorbar.yanchor":

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
                case "sankey.attributes.arrangement":
                    node.ClassTypeName = "SankeyArrangementOptions";
                    node.FileName = "SankeyArrangementOptions.cs";
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
                case "funnelarea.attributes.hoverinfo":
                case "pie.attributes.hoverinfo":
                    node.ClassTypeName = "AreaHoverOptions";
                    node.FileName = "AreaHoverOptions.cs";
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
                case "bar.attributes.hoverinfo":
                case "box.attributes.hoverinfo":
                case "heatmap.attributes.hoverinfo":
                case "violin.attributes.hoverinfo":
                case "candlestick.attributes.hoverinfo":
                case "contour.attributes.hoverinfo":
                case "splom.attributes.hoverinfo":
                case "table.attributes.hoverinfo":
                case "pointcloud.attributes.hoverinfo":
                case "surface.attributes.hoverinfo":
                case "volume.attributes.hoverinfo":
                case "heatmapgl.attributes.hoverinfo":
                case "isosurface.attributes.hoverinfo":
                case "mesh3d.attributes.hoverinfo":



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
             

                case "scattersmith.attributes.hoverinfo":
                    node.ClassTypeName = "ScatterSmithHoverOptions";
                    node.FileName = "ScatterSmithHoverOptions.cs";
                    break;
                case "icicle.attributes.hoverinfo":
                    node.ClassTypeName = "IcicleHoverOptions";
                    node.FileName = "IcicleHoverOptions.cs";
                    break;
                case "barpolar.attributes.hoverinfo":
                    node.ClassTypeName = "BarPolarHoverOptions";
                    node.FileName = "BarPolarHoverOptions.cs";
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

                
                case "ohlc.attributes.hoverinfo":
                    node.ClassTypeName = "FinanceHoverInfoOptions";
                    node.FileName = "FinanceHoverInfoOptions.cs";
                    break;

                case "attributes.node.hoverinfo":
                    node.ClassTypeName = "NodeHoverInfoOptions";
                    node.FileName = "NodeHoverInfoOptions.cs";
                    break;

                case "coloraxis.colorbar.ticks":
                case "ternary.aaxis.ticks":
                case "ternary.baxis.ticks":
                case "ternary.caxis.ticks":
                case "layoutAttributes.xaxis.ticks":
                case "layoutAttributes.yaxis.ticks":
                case "attributes.colorbar.ticks":
                    node.ClassTypeName = "TicksOptions";
                    node.FileName = "TicksOptions.cs";
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
                default:
                    result = false;
                    break;
            }
            return result;
        }

        public void FixClassNames(MapNameType node)
        {


            // classes
            if (node.PropertyName == "Items")
            {
                node.ClassTypeName = "NoPublish";
                node.FileName = "NoPublish.cs";
                node.JsonType = "ItemsList";
            }
            else if (node.item != null && (node.item.ElementType == SchemaElementType.doubleOption || node.item.ElementType == SchemaElementType.stringOption || node.item.ElementType == SchemaElementType.anyOption))
            {
                node.ClassTypeName = string.Empty;
                node.FileName = string.Empty;
                node.JsonType = node.item.ElementType.ToString(); 
            }
            switch(node.LocationName)
            {
                case "layout":
                
                case "traces.bar":
                case "traces.barpolar":
                case "traces.box":
                case "traces.candlestick":
                case "traces.carpet":
                case "traces.cone":
                case "traces.choropleth":
                case "traces.choroplethmapbox":
                case "traces.contour":
                case "traces.contourcarpet":
                case "traces.densitymapbox":
                case "traces.funnel":
                case "traces.funnelarea":
                case "traces.image":
                case "traces.icicle":
                case "traces.indicator":
                case "traces.isosurface":
                case "traces.heatmap":
                case "traces.heatmapgl":
                case "traces.histogram":
                case "traces.histogram2d":
                case "traces.histogram2dcontour":
                case "traces.mesh3d":
                case "traces.ohlc":
                case "traces.parcats":
                case "traces.parcoords":
                case "traces.pie":
                case "traces.pointcloud":
                case "traces.sankey":
                case "traces.scatter":
                case "traces.scattercarpet":
                case "traces.scattergeo":
                case "traces.scattergl":
                case "traces.scattermapbox":
                case "traces.scatterpolar":
                case "traces.scatterpolargl":
                case "traces.scattersmith":
                case "traces.scatterternary":
                case "traces.scatter3d":
                case "traces.splom":
                case "traces.streamtube":
                case "traces.sunburst":
                case "traces.surface":
                case "traces.table":
                case "traces.treemap":
                case "traces.violin":
                case "traces.volume":
                case "traces.waterfall":

                  node.ClassTypeName = "NoPublish";
                  node.FileName = "NoPublish.cs";
                  break;

                case "attributes.header.fill":
                case "attributes.cells.fill":
                    node.ClassTypeName = "FillColorInfo";
                    node.FileName = "FillColorInfo.cs";
                    break;

                case "items.layer.fill":
                    node.ClassTypeName = "FillOutlineInfo";
                    node.FileName = "FillOutlineInfo.cs";
                    break;


                case "layout.layoutAttributes":
                    node.ClassTypeName = "Layout";
                    node.FileName = "Layout.cs";
                    break;
                case "traces.bar.attributes":
                    node.ClassTypeName = "BarTrace : Trace";
                    node.FileName = "BarTrace.cs";
                    break;
               
                case "traces.barpolar.attributes":
                    node.ClassTypeName = "BarPolarTrace : Trace";
                    node.FileName = "BarPolarTrace.cs";
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
                    node.ClassTypeName = "ParallelCategoriesTrace : Trace";
                    node.FileName = "ParallelCategoriesTrace.cs";
                    break;

               
                case "traces.parcoords.attributes":
                    node.ClassTypeName = "ParallelCoordinateTrace : Trace";
                    node.FileName = "ParallelCoordinateTrace.cs";
                    break;

              
                case "traces.pie.attributes":
                    node.ClassTypeName = "PieTrace : Trace";
                    node.FileName = "PieTrace.cs";
                    break;

              
                case "traces.pointcloud.attributes":
                    node.ClassTypeName = "PointCloudTrace : Trace";
                    node.FileName = "PointCloudTrace.cs";
                    break;

                case "traces.polar.attributes":
                    node.ClassTypeName = "PolarTrace : Trace";
                    node.FileName = "PolarTrace.cs";
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
                    node.ClassTypeName = "Scatter3DTrace : Trace";
                    node.FileName = "Scatter3DTrace.cs";
                    break;

              
                case "traces.splom.attributes":
                    node.ClassTypeName = "SplomTrace : Trace";
                    node.FileName = "SplomTrace.cs";
                    break;

             
                case "traces.streamtube.attributes":
                    node.ClassTypeName = "StreamTubeTrace : Trace";
                    node.FileName = "StreamTubeTrace.cs";
                    break;

              
                case "traces.sunburst.attributes":
                    node.ClassTypeName = "SunburstTrace : Trace";
                    node.FileName = "SunburstTrace.cs";
                    break;

             
                case "traces.surface.attributes":
                    node.ClassTypeName = "SurfaceTrace : Trace";
                    node.FileName = "SurfaceTrace.cs";
                    break;


                case "traces.table.attributes":
                    node.ClassTypeName = "TableTrace : Trace";
                    node.FileName = "TableTrace.cs";
                    break;

                case "traces.ternary.attributes":
                    node.ClassTypeName = "TernaryTrace : Trace";
                    node.FileName = "TernaryTrace.cs";
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


                case "transforms":
                case "transforms.sort":
                case "transforms.aggregate":
                case "transforms.groupby":
                case "transforms.filter":
                    node.ClassTypeName = "NoPublish";
                    node.FileName = "NoPublish.cs";
                    node.JsonType = "classOption";

                    break;

                case "transforms.aggregate.attributes":

                    node.ClassTypeName = "AggregateTransform : Transform";
                    node.FileName = "AggregateTransform.cs";
                    node.JsonType = "classOption";
                    break;

                case "aggregations.items.aggregation":
                    node.ClassTypeName = "AggregationItem";
                    node.FileName = "AggregationItem.cs";
                    break;

                
                case "transforms.sort.attributes":

                    node.ClassTypeName = "SortTransform : Transform";
                    node.FileName = "SortTransform.cs";
                    break;


                case "transforms.groupby.attributes":
                    node.ClassTypeName = "GroupByTransform : Transform";
                    node.FileName = "GroupByTransform.cs";
                    break;



                case "transforms.filter.attributes":
                    node.ClassTypeName = "FilterTransform : Transform";
                    node.FileName = "FilterTransform.cs";
                    break;

               

                case "traces.bar.layoutAttributes":
                    node.ClassTypeName = "BarLayout : Layout";
                    node.FileName = "BarLayout.cs";
                    break;
                case "traces.box.layoutAttributes":
                    node.ClassTypeName = "BoxLayout : Layout";
                    node.FileName = "BoxLayout.cs";
                    break;

                case "traces.barpolar.layoutAttributes":
                    node.ClassTypeName = "BarPolarLayout : Layout";
                    node.FileName = "BarPolarLyout.cs";
                    break;
                case "traces.candlestick.layoutAttributes":
                    node.ClassTypeName = "CandlestickLayout : Layout";
                    node.FileName = "CandlestickLayout.cs";
                    break;


                case "traces.funnel.layoutAttributes":
                    node.ClassTypeName = "FunnelLayout : Layout";
                    node.FileName = "FunnelLayout.cs";
                    break;
                case "traces.funnelarea.layoutAttributes":
                    node.ClassTypeName = "FunnelAreaLayout : Layout";
                    node.FileName = "FunnelAreaLayout.cs";
                    break;
                case "traces.icicle.layoutAttributes":
                    node.ClassTypeName = "IcicleLayout : Layout";
                    node.FileName = "IcicleLayout.cs";
                    break;
                case "traces.histogram.layoutAttributes":
                    node.ClassTypeName = "HistogramLayout : Layout";
                    node.FileName = "HistogramLayout.cs";
                    break;
              

                case "traces.pie.layoutAttributes":
                    node.ClassTypeName = "PieLayout : Layout";
                    node.FileName = "PieLayout.cs";
                    break;


                case "traces.sunburst.layoutAttributes":
                    node.ClassTypeName = "SunburstLayout : Layout";
                    node.FileName = "SunburstLayout.cs";
                    break;
                case "traces.treemap.layoutAttributes":
                    node.ClassTypeName = "TreemapLayout : Layout";
                    node.FileName = "TreemapLayout.cs";
                    break;
                case "traces.violin.layoutAttributes":
                    node.ClassTypeName = "ViolinLayout : Layout";
                    node.FileName = "ViolinLayout.cs";
                    break;
                case "traces.waterfall.layoutAttributes":
                    node.ClassTypeName = "WaterfallLayout : Layout";
                    node.FileName = "WaterfallLayout.cs";
                    break;
                case "icicle.attributes.marker":
                    node.ClassTypeName = "MarkerIcicleInfo";
                    node.FileName = "MarkerIcicleInfo.cs";
                    break;
                case "histogram.attributes.marker":
                    node.ClassTypeName = "MarkerHistogramInfo";
                    node.FileName = "MarkerHistogramInfo.cs";
                    break;
                case "bar.attributes.marker":
                    node.ClassTypeName = "MarkerBarInfo";
                    node.FileName = "MarkerBarInfo.cs";
                    break;
                case "scatter.attributes.marker":
                case "scattercarpet.attributes.marker":  
                case "scattersmith.attributes.marker":
                case "scatterternary.attributes.marker":
                    node.ClassTypeName = "MarkerScatterInfo";
                    node.FileName = "MarkerScatterInfo.cs";
                    break;
                case "scattergl.attributes.marker":
                    node.ClassTypeName = "MarkerScatterGLInfo";
                    node.FileName = "MarkerScatterGLInfo.cs";
                    break;
                case "scatterpolar.attributes.marker":
                    node.ClassTypeName = "MarkerPolarInfo";
                    node.FileName = "MarkerPolarInfo.cs";
                    break;
                case "scatterpolargl.attributes.marker":
                    node.ClassTypeName = "MarkerPolarGLInfo";
                    node.FileName = "MarkerPolarGLInfo.cs";
                    break;

                case "scattermapbox.attributes.marker":
                    node.ClassTypeName = "MarkerMapboxInfo";
                    node.FileName = "MarkerMapboxInfo.cs";
                    break;
                case "scatter3d.attributes.marker":
                    node.ClassTypeName = "MarkerScatter3DInfo";
                    node.FileName = "MarkerScatter3DInfo.cs";
                    break;
                case "scattergeo.attributes.marker":
                    node.ClassTypeName = "MarkerScatterGeoInfo";
                    node.FileName = "MarkerScatterGeoInfo.cs";
                    break;
                case "splom.attributes.marker":

                    node.ClassTypeName = "MarkerSplomInfo";
                    node.FileName = "MarkerSplomInfo.cs";
                    break;
                case "sunburst.attributes.marker":
                
                    node.ClassTypeName = "MarkerSunburstInfo";
                    node.FileName = "MarkerSunburstInfo.cs";
                    break;
                case "barpolar.attributes.marker":
                    node.ClassTypeName = "MarkerBarPolarInfo";
                    node.FileName = "MarkerBarPolarInfo.cs";
                    break;
               
                case "violin.attributes.marker":
                    node.ClassTypeName = "MarkerViolinInfo";
                    node.FileName = "MarkerViolinInfo.cs";
                    break;
                case "histogram2dcontour.attributes.marker":
                case "histogram2d.attributes.marker":
                    node.ClassTypeName = "MarkerHistogram2DInfo";
                    node.FileName = "MarkerHistogram2DInfo.cs";
                    break;
                case "box.attributes.marker":
                    node.ClassTypeName = "MarkerBoxInfo";
                    node.FileName = "MarkerBoxInfo.cs";
                    break;

                case "choroplethmapbox.attributes.marker":
                case "choropleth.attributes.marker":
                    node.ClassTypeName = "MarkerChoroplethInfo";
                    node.FileName = "MarkerChoroplethInfo.cs";
                    break;
                case "funnel.attributes.marker":
                    node.ClassTypeName = "MarkerFunnelInfo";
                    node.FileName = "MarkerFunnelInfo.cs";
                    break;

                case "funnelarea.attributes.marker":
                    node.ClassTypeName = "MarkerFunnelAreaInfo";
                    node.FileName = "MarkerFunnelAreaInfo.cs";
                    break;

                case "pie.attributes.marker":
                    node.ClassTypeName = "MarkerPieInfo";
                    node.FileName = "MarkerPieInfo.cs";
                    break;
                case "pointcloud.attributes.marker":
                    node.ClassTypeName = "MarkerPointCloudInfo";
                    node.FileName = "MarkerPointCloudInfo.cs";
                    break;
                case "attributes.total.marker":
                    node.ClassTypeName = "MarkerTotalInfo";
                    node.FileName = "MarkerTotalInfo.cs";
                    break;
                case "attributes.increasing.marker":
                case "attributes.decreasing.marker":
                    switch(node.item.Parent.Parent.Parent.Name)
                    {
                        case "waterfall":
                            node.ClassTypeName = "MarkerChangeWaterfallInfo";
                            node.FileName = "MarkerChangeWaterfallInfo.cs";
                            break;
                        default:
                            node.ClassTypeName = "MarkerChangeInfo";
                            node.FileName = "MarkerChangeInfo.cs";
                            break;
                    }
                   
                    break;

                case "treemap.attributes.marker":
                    node.ClassTypeName = "MarkerTreemapInfo";
                    node.FileName = "MarkerTreemapInfo.cs";
                    break;
                case "attributes.unselected.marker":
                case "attributes.selected.marker":
                    switch(node.item.Parent.Parent.Parent.Name)
                    {
                        case "choropleth":
                        case "choroplethmapbox":
                            node.ClassTypeName = "MarkerSelectionOpacityInfo";
                            node.FileName = "MarkerSelectionOpacityInfo.cs";
                            break;
                        default:
                            node.ClassTypeName = "MarkerSelectionInfo";
                            node.FileName = "MarkerSelectionInfo.cs";
                            break;
                    }
                  
                    break;


                case "attributes.hoverlabel.font":
                case "link.hoverlabel.font":
                case "node.hoverlabel.font":
                case "attributes.cells.font":
                   case "attributes.header.font":
                    node.ClassTypeName = "FontLabelInfo";
                    node.FileName = "FontLabelInfo.cs";
                    break;

                case "attributes.title.font":
                    node.ClassTypeName = "FontTitleInfo";
                    node.FileName = "FontTitleInfo.cs";
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

                case "streamtube.attributes.starts":
                    node.ClassTypeName = "StartsInfo";
                    node.FileName = "StartsInfo.cs";
                    break;

                case "cone.attributes.lighting":
                case "isosurface.attributes.lighting":
                case "mesh3d.attributes.lighting":
                case "streamtube.attributes.lighting":
                case "volume.attributes.lighting":
              
                    node.ClassTypeName = "SurfaceLightingInfo";
                    node.FileName = "SurfaceLightingInfo.cs";
                    break;
                case "attributes.link.line":
                case "attributes.node.line":
                case "attributes.cells.line":
                case "attributes.header.line":
                case "attributes.cell.line":

                    node.ClassTypeName = "LineColorWidthsInfo";
                    node.FileName = "LineColorWidthsInfo.cs";
                    break;
              
                    
                
                case "attributes.marker.line":
                    switch(node.item.Parent.Parent.Parent.Name)
                    {
                        case "pie":
                        case "choropleth":
                        case "choroplethmapbox":
                        case "funnelarea":
                        case "treemap":
                            node.ClassTypeName = "LineColorWidthsInfo";
                            node.FileName = "LineColorWidthsInfo.cs";
                            break;
                        case "violin":
                            node.ClassTypeName = "LineMarkerViolinInfo";
                            node.FileName = "LineMarkerViolinInfo.cs";
                            break;
                        default:
                            node.ClassTypeName = "LineMarkerInfo";
                            node.FileName = "LineMarkerInfo.cs";
                            break;
                    }

                    break;
                case "choropleth.attributes.unselected":
                case "choropleth.attributes.selected":
                case "choroplethmapbox.attributes.unselected":                
                case "choroplethmapbox.attributes.selected":
                case "scattermapbox.attributes.unselected":
                case "scattermapbox.attributes.selected":
                
                    node.ClassTypeName = "SelectionMapboxInfo";
                    node.FileName = "SelectionMapboxInfo.cs";
                    break;

                case "box.attributes.unselected":
                case "box.attributes.selected":
                    node.ClassTypeName = "SelectionBoxInfo";
                    node.FileName = "SelectionBoxInfo.cs";
                    break;
                case "histogram.attributes.selected":
                case "histogram.attributes.unselected":
                case "barpolar.attributes.unselected":
                case "barpolar.attributes.selected":
                case "scatter.attributes.unselected":
                case "scatter.attributes.selected":
                case "scattercarpet.attributes.unselected":
                case "scattercarpet.attributes.selected":
                case "scattergeo.attributes.unselected":
                case "scattergeo.attributes.selected":
                case "scattergl.attributes.unselected":
                case "scattergl.attributes.selected":
                case "scatterpolar.attributes.unselected":
                case "scatterpolar.attributes.selected":
                case "scatterpolargl.attributes.unselected":
                case "scatterpolargl.attributes.selected":
                case "scattersmith.attributes.unselected":
                case "scattersmith.attributes.selected":
                case "scatterternary.attributes.unselected":
                case "scatterternary.attributes.selected":
                    node.ClassTypeName = "SelectionInfo";
                    node.FileName = "SelectionInfo.cs";
                    break;

              

                case "items.slider.transition":
                    node.ClassTypeName = "TransitionSliderInfo";
                    node.FileName = "TransitionSliderInfo.cs";
                    break;


              
               
              
                   

                case "indicator.attributes.title":
                    node.ClassTypeName = "TitleAlignFontInfo";
                    node.FileName = "TitleAlignFontInfo.cs";
                    break;
             

                case "layoutAttributes.legend.title":
                    node.ClassTypeName = "TitleLegendInfo";
                    node.FileName = "TitleLegendInfo.cs";
                    break;

                case "coloraxis.colorbar.title":
                case "marker.colorbar.title":
                case "attributes.colorbar.title":
                case "line.colorbar.title":
                    node.ClassTypeName = "TitleFontSideInfo";
                    node.FileName = "TitleFontSideInfo.cs";
                    break;

                case "scene.xaxis.title":
                case "scene.yaxis.title":
                case "scene.zaxis.title":
                    node.ClassTypeName = "TitleFontInfo";
                    node.FileName = "TitleFontInfo.cs";
                    break;

                case "funnelarea.attributes.title":
                 
                case "pie.attributes.title":
                    node.ClassTypeName = "TitleFontPositionInfo";
                    node.FileName = "TitleFontPositionInfo.cs";
                    break;

                case "attributes.aaxis.title":
                case "attributes.baxis.title":
                    node.ClassTypeName = "TitleFontOffsetInfo";
                    node.FileName = "TitleFontOffsetInfo.cs";
                    break;

                case "layout.layoutAttributes.title":
                    node.ClassTypeName = "TitleLayoutInfo";
                    node.FileName = "TitleLayoutInfo.cs";
                    break;
                case "layoutAttributes.xaxis.title":
                case "layoutAttributes.yaxis.title":
               
                    node.ClassTypeName = "TitleFontStandoffInfo";
                    node.FileName = "TitleFontStandoffInfo.cs";
                    break;

                case "ternary.aaxis.title":
                case "ternary.baxis.title":
                case "ternary.caxis.title":
                    node.ClassTypeName = "TitleTernaryAxisInfo";
                    node.FileName = "TitleTernaryAxisInfo.cs";
                    break;

                case "polar.radialaxis.title":
                    node.ClassTypeName = "TitleFontInfo";
                    node.FileName = "TitleFontInfo.cs";
                    break;


                case "gauge.threshold.line":
                case "items.step.line":
                case "gauge.bar.line":
                case "box.attributes.line":
                case "attributes.decreasing.line":
                case "attributes.increasing.line":
                case "scattermapbox.attributes.line":
                    node.ClassTypeName = "LineColorWidthInfo";
                    node.FileName = "LineColorWidthInfo.cs";
                    break;


                case "ohlc.attributes.line":
                    node.ClassTypeName = "LineDashWidthInfo";
                    node.FileName = "LineDashWidthInfo.cs";
                    break;
                case "items.layer.line":
                    
                    node.ClassTypeName = "LineDashesWidthInfo";
                    node.FileName = "LineDashesWidthInfo.cs";
                    break;

                    // default LineInfo.cs include color, dash, width

                case "decreasing.marker.line": // color, width
                case "increasing.marker.line":
                   
                case "attributes.box.line":

                case "totals.marker.line":  // color, width
                case "violin.attributes.line":
                    node.ClassTypeName = "LineColorWidthInfo";
                    node.FileName = "LineColorWidthInfo.cs";
                    break;



                
               



                case "scattergl.attributes.line":
                case "scatterpolargl.attributes.line":
                    node.ClassTypeName = "LineColorDashShapeWidthInfo";
                    node.FileName = "LineColorDashShapeWidthInfo.cs";
                    break;
              
                  

                case "carpetcontour.attributes.line":
                case "contour.attributes.line":
                case "contourcarpet.attributes.line":
                case "histogram2dcontour.attributes.line":
               
                    node.ClassTypeName = "LineColorDashSmoothingWidthInfo";
                    node.FileName = "LineColorDashSmoothingWidthInfo.cs";
                    break;


                case "scattersmith.attributes.line":


                case "scattercarpet.attributes.line":
                case "scatterpolar.attributes.line":
                case "scatterternary.attributes.line":
                    node.ClassTypeName = "LineColorDashShapeSmoothingWidthInfo";
                    node.FileName = "LineColorDashShapeSmoothingWidthInfo.cs";
                    break;

      

                case "candlestick.attributes.line":
                    node.ClassTypeName = "LineWidthInfo";
                    node.FileName = "LineWidthInfo.cs";
                    break;


                case "parcats.attributes.line":
                    node.ClassTypeName = "LineParCatsInfo";
                    node.FileName = "LineParCatsInfo.cs";
                    break;

                case "parcoords.attributes.line":
                    node.ClassTypeName = "LineParCoordsInfo";
                    node.FileName = "LineParCoordsInfo.cs";
                    break;

               

                case "scatter.attributes.line":
                    node.ClassTypeName = "LineScatterInfo";
                    node.FileName = "LineScatterInfo.cs";
                    break;
        

       
             



                case "scatter3d.attributes.line":
                    node.ClassTypeName = "LineScatter3DInfo";
                    node.FileName = "LineScatter3DInfo.cs";
                    break;

          

                case "splom.attributes.line":

                    node.ClassTypeName = "LineSplomInfo";
                    node.FileName = "LineSplomInfo.cs";
                    break;

                case "layoutAttributes.geo.projection":
                    node.ClassTypeName = "ProjectionGeoInfo";
                    node.FileName = "ProjectionGeoInfo.cs";
                    break;

                case "scene.camera.projection":
                    node.ClassTypeName = "ProjectionCameraInfo";
                    node.FileName = "ProjectionCameraInfo.cs";
                    break;
           

                case "layout.layoutAttributes.activeshape":
                    node.ClassTypeName = "ActiveShapeInfo";
                    node.FileName = "ActiveShapeInfo.cs";
                    break;

                case "layout.layoutAttributes.margin":
                    node.ClassTypeName = "MarginInfo";
                    node.FileName = "MarginInfo.cs";
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

                case "splom.attributes.selected":
                case "splom.attributes.unselected":
                    node.ClassTypeName = "SplomSelectionInfo";
                    node.FileName = "SplomSelectionInfo.cs";
                    break;

                case "scatter3d.attributes.projection":
        
                       node.ClassTypeName = "Scatter3DProjection";
                       node.FileName = "Scatter3DProjection.cs";
                       break;
                case "ohlc.attributes.decreasing":
                case "ohlc.attributes.increasing":
                    node.ClassTypeName = "ChangeOHLCInfo";
                    node.FileName = "ChangeOHLCInfo.cs";
                    break;
               
                case "candlestick.attributes.decreasing":
                case "candlestick.attributes.increasing":
                    node.ClassTypeName = "ChangeCandlestickInfo";
                    node.FileName = "ChangeCandlestickInfo.cs";
                    break;
                case "layer.symbol.textfont":
                    node.ClassTypeName = "TextFontSymbolInfo";
                    node.FileName = "TextFontSymbolInfo.cs";
                    break;
                case "attributes.unselected.textfont":
                case "attributes.selected.textfont":
                    node.ClassTypeName = "TextFontSelectionInfo";
                    node.FileName = "TextFontSelectionInfo.cs";
                    break;
                case "funnelarea.attributes.insidetextfont":
               
                case "funnel.attributes.outsidetextfont":
                case "bar.attributes.textfont":
                case "funnelarea.attributes.textfont":
                case "pie.attributes.textfont":
                
                    node.ClassTypeName = "TextFontInfo";
                    node.FileName = "TextFontInfo.cs";
                    break;
                case "histogram.attributes.insidetextfont":
                case "histogram.attributes.outsidetextfont":
                case "heatmap.attributes.textfont":
                case "contour.attributes.textfont":
                case "histogram.attributes.textfont":
                case "histogram2d.attributes.textfont":
                case "sankey.attributes.textfont":
                case "histogram2dcontour.attributes.textfont":
                    node.ClassTypeName = "TextFontSizeInfo";
                    node.FileName = "TextFontSizeInfo.cs";
                    break;
                case "icicle.attributes.insidetextfont":
                case "icicle.attributes.outsidetextfont":
                case "funnel.attributes.textfont":
                case "attributes.pathbar.textfont":
                case "scatter.attributes.textfont":
                    
                case "scattergl.attributes.textfont":

                case "icicle.attributes.textfont":
                    node.ClassTypeName = "TextFontSizesInfo";
                    node.FileName = "TextFontSizesInfo.cs";
                    break;
                case "scattermapbox.attributes.textfont":
                    node.ClassTypeName = "TextFontMapboxInfo";
                    node.FileName = "TextFontMapboxInfo.cs";
                    break;
                case "waterfall.attributes.decreasing":
                case "waterfall.attributes.increasing":
                    node.ClassTypeName = "MarkerChangeInfo";
                    node.FileName = "MarkerChangeInfo.cs";
                    break;

                case "attributes.delta.decreasing":
                case "attributes.delta.increasing":
                    node.ClassTypeName = "AreaChangeInfo";
                    node.FileName = "AreaChangeInfo.cs";
                    break;

                case "items.annotation.hoverlabel":
                    node.ClassTypeName = "HoverLabelAnnotationInfo";
                    node.FileName = "HoverLabelAnnotationInfo.cs";
                    break;

                case "layout.layoutAttributes.hoverlabel":
                    node.ClassTypeName = "HoverLabelLayoutInfo";
                    node.FileName = "HoverLabelLayoutInfo.cs";
                    break;
                 
                case "ohlc.attributes.hoverlabel":
                case "candlestick.attributes.hoverlabel":
                    node.ClassTypeName = "HoverLabelFinanceInfo";
                    node.FileName = "HoverLabelFinanceInfo.cs";
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

         

                case "layoutAttributes.geo.domain":
                    node.ClassTypeName = "GeoDomainInfo";
                    node.FileName = "GeoDomainInfo.cs";
                    break;
                case "scatter3d.attributes.error_x":
                case "scatter3d.attributes.error_y":
      
                    node.ClassTypeName = "Scatter3DErrorInfo";
                    node.FileName = "Scatter3DErrorInfo.cs";
                    break;
                case "scatter3d.attributes.error_z":
                    node.ClassTypeName = "Scatter3DZErrorInfo";
                    node.FileName = "Scatter3DZErrorInfo.cs";
                    break;
                case "layoutAttributes.mapbox.center":
                case "layoutAttributes.geo.center":
                    node.ClassTypeName = "GeoCenterInfo";
                    node.FileName = "GeoCenterInfo.cs";
                    break;
                case "scene.camera.center":
                    node.ClassTypeName = "CameraCenterInfo";
                    node.FileName = "CameraCenterInfo.cs";
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
                    node.ClassTypeName = "SliceInfo";
                    node.FileName = "SliceInfo.cs";
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
                case "layoutAttributes.scene.yaxis":
                    node.ClassTypeName = "SceneYAxisInfo";
                    node.FileName = "SceneYAxisInfo.cs";
                    break;
                case "layoutAttributes.scene.xaxis":
              
                case "layoutAttributes.scene.zaxis":
                    node.ClassTypeName = "SceneAxisInfo";
                    node.FileName = "SceneAxisInfo.cs";
                    break;
                case "layoutAttributes.grid.domain":
                    node.ClassTypeName = "GridDomainInfo";
                    node.FileName = "GridDomainInfo.cs";
                    break;
                case "layout.layoutAttributes.yaxis":
                    node.ClassTypeName = "LayoutYAxisInfo";
                    node.FileName = "LayoutYAxisInfo.cs";
                    break;
                case "layout.layoutAttributes.xaxis":              
                case "layout.layoutAttributes.zaxis":
                    node.ClassTypeName = "LayoutAxisInfo";
                    node.FileName = "LayoutAxisInfo.cs";
                    break;
                case "splom.attributes.xaxes":
                case "splom.attributes.yaxes":
                    node.ClassTypeName = "SplomAxes";
                    node.FileName = "SplomAxes.cs";
                    break;
                case "layoutAttributes.grid.xaxes":
                case "layoutAttributes.grid.yaxes":
                    node.ClassTypeName = "GridAxes";
                    node.FileName = "GridAxes.cs";
                    break;
              
                
                case "annotations.items.annotation":
                    node.ClassTypeName = "AnnotationItem";
                    node.FileName = "AnnotationItem.cs";
                    break;
                case "buttons.items.button":
                    node.ClassTypeName = "ButtonItem";
                    node.FileName = "ButtonItem.cs";
                    break;
                case "colorscales.items.concentrationscales":
                    node.ClassTypeName = "ConcentrationScalesItem";
                    node.FileName = "ConcentrationScalesItem.cs";
                    break;
              

                case "dimensions.items.dimension":
                    switch (node.item.Parent.Parent.Parent.Parent.Name)
                    {
                        case "parcats":
                            node.ClassTypeName = "ParCatsDimensionItem";
                            node.FileName = "ParCatsDimensionItem.cs";
                            break;
                        case "parcoords":
                            node.ClassTypeName = "ParCoordsDimensionItem";
                            node.FileName = "ParCoordsDimensionItem.cs";
                            break;
                        case "splom":
                            node.ClassTypeName = "SplomDimensionItem";
                            node.FileName = "SplomDimensionItem.cs";
                            break;
                        default:
                            node.ClassTypeName = "DimensionItem";
                            node.FileName = "DimensionItem.cs";
                            break;
                    }

                    break;

                case "frames.items.frames_entry":
                    node.ClassTypeName = "FrameEntryItem";
                    node.FileName = "FrameEntryItem.cs";
                    break;
                case "images.items.image":
                    node.ClassTypeName = "ImageItem";
                    node.FileName = "ImageItem.cs";
                    break;
                case "layers.items.layer":
                    node.ClassTypeName = "LayerItem";
                    node.FileName = "LayerItem.cs";
                    break;
                case "rangebreaks.items.rangebreak":
                    node.ClassTypeName = "RangeBreakItem";
                    node.FileName = "RangeBreakItem.cs";
                    break;
                case "shapes.items.shape":
                    node.ClassTypeName = "ShapeItem";
                    node.FileName = "ShapeItem.cs";
                    break;
                case "sliders.items.slider":
                    node.ClassTypeName = "SliderItem";
                    node.FileName = "SliderItem.cs";
                    break;
             
                case "steps.items.step":
                    switch (node.item.Parent.Parent.Parent.Name)
                    {
                        case "gauge":
                            node.ClassTypeName = "GaugeStepItem";
                            node.FileName = "GaugeStepItem.cs";
                            break;
                        case "slider":
                            node.ClassTypeName = "SliderStepItem";
                            node.FileName = "SliderStepItem.cs";
                            break;
                        default:
                            node.ClassTypeName = "StepItem";
                            node.FileName = "StepItem.cs";
                            break;
                    }

                    break;
                case "styles.items.style":
                    node.ClassTypeName = "StyleItem";
                    node.FileName = "StyleItem.cs";
                    break;
                case "tickformatstops.items.tickformatstop":
                    node.ClassTypeName = "TickFormatStopItem";
                    node.FileName = "TickFormatStopItem.cs";
                    break;
        
                case "updatemenus.items.updatemenu":
                    node.ClassTypeName = "UpdateMenuItem";
                    node.FileName = "UpdateMenuItem.cs";
                    break;
           
       
     

            }
        }



        public string CamelCaseName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return string.Empty;
            }
            switch(name)
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

                case "l":
                    
                        name = "L";
                    
                    break;
                case "r":
                    
                        name = "R";
                    
                    
                    break;
                case "t":
                    
                        name = "T";
                    
                   
                    break;
                case "b":
                    
                        name = "B";
                    
                   
                    break;
                case "side":
                    name = "Side";
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
                .Replace("autorange", "AutoRange")
                .Replace("autobinx", "AutoBinX")
                .Replace("autobiny", "AutoBinY")
                .Replace("autosize", "AutoSize")
                .Replace("autoexpand","AutoExpand")
                .Replace("automargin", "AutoMargin")
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
                .Replace("usecolormap","UseColorMap")
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
                .Replace("gridwidth", "GridWidth")
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
                .Replace("showcoastlines", "ShowCoastLines")
                .Replace("line", "Line")
                .Replace("showdividers", "ShowDividers")
                .Replace("showframe", "ShowFrame")
                .Replace("showland", "ShowLand")
                .Replace("showlakes", "ShowLakes")
             
                .Replace("showlowerhalf", "ShowLowerHalf")

                .Replace("shift", "Shift")
              
                .Replace("inside", "Inside")
                .Replace("arrowside", "ArrowSide")
                .Replace("xside", "XSide")
                .Replace("yside", "YSide")
            

                .Replace("sizable", "Sizable")
                .Replace("sizeref", "SizeRef")
                .Replace("sizex", "SizeX")
                .Replace("sizey", "SizeY")
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



    }
}