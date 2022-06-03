//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ValuesObject.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.Dynamic;


namespace KilnGod.PlotlyCharts.Wrappers
{
    public class ValuesObject
    {
        public ExpandoObject ValueItems { get; private set; }

        public ValuesObject()
        {
            ValueItems = new ExpandoObject();
        }
    
        

    }
}
