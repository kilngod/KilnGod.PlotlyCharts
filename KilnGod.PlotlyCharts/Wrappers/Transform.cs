//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Transform.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************


using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Wrappers
{
    public class Transform : ValuesObject
    {
        public Transform()
        {

        }

        public Transform(TransformOptions transformType)
        {
            TransformType = transformType.GetDescription();
        }

        /* its a bad idea to include every trace option on the same object as it will cause confusion.*/
        public string? TransformType
        {
            get { return (ValueItems as dynamic).type; }
            private set {  (ValueItems as dynamic).type = value; }
        }


    }
}
