//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: SchemaItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.SchemaReview
{
    public class SchemaItem
    {
        public SchemaItem()
        {
            Children = new List<SchemaItem>();
            Name = string.Empty;
            Description = string.Empty;
            CsType = string.Empty;
            EditTypeDecorator = string.Empty;
            DfltDecorator = string.Empty;
            ElementType = SchemaElementType.objectOption;
            Parent = null;
            RootItemType = string.Empty;


        }
        public string Name { get; set; }
        public string CsType { get; set; }
        public SchemaItem? Parent { get; set; }
        public string Description { get; set; }

        public string EditTypeDecorator { get; set; }

        public string DfltDecorator { get; set; }

        public SchemaElementType ElementType { get; set; }

        public List<string>? Enumeration { get; set; }
        public List<SchemaItem> Children { get; set; }

        public string RootItemType { get; set; }
        
        public MapNameType map { get; set; }

        public string ContentSchemaName 
        {
            get
            {
                // remap all classes supporting traces to layout (likely need to rename the supporting class namespace)
                string result = RootItemType;
                if (result == "traces" && !Name.EndsWith("Trace"))
                {
                    result = "Render";
                }

                if (result == "layout" && !Name.EndsWith("Layout"))
                {
                    result = "Render";
                }
                return result;
            }
        }

        public bool IsItemList
        {
            get
            {
                bool result = false;

                if (Children != null)
                {
                    var items = Children.Find(x => x.map.PropertyName == "Items");

                    result = items != null;
                }

                return result;
            }
        }

    }
}
