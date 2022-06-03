//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: EnumElementType.cs
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
    public class EnumElementType
    {
        public string JsonName { get; set; }
        public string CSharpName { get; set; }

        public EnumElementType(string jsonName, string cSharpName)
        {
            JsonName = jsonName;
            CSharpName = cSharpName;

        }
    }
}
