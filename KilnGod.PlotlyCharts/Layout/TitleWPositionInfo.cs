//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TitleWPositionInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;

namespace KilnGod.PlotlyCharts.Layout
{
    public class TitleWPositionInfo : TitleInfo
    {
        public TitleWPositionInfo() : base()
        {

        }

        public PositionOptions Position
        {
            get
            {
                return (ValueItems as dynamic).position;
            }
            set
            {
                (ValueItems as dynamic).position = value.GetDescription();
            }
        }
    }
}
