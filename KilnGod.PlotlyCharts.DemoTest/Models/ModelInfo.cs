//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: ModelInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.Models
{


    public struct CoffeeData
    {

        public string Ids { get; set; }
        public string Labels { get; set; }
        public string Parents { get; set; }
    }

    public struct BitcoinMiningData
    {
        public string Row { get; set; }
        public string Date { get; set; }
        public string Number_transactions { get; set; }
        public string Output_volume_BTC { get; set; }
        public string Market_price { get; set; }
        public string Hash_rate { get; set; }
        public string Cost_per_trans_USD { get; set; }
        public string Mining_revenue_USD { get; set; }
        public string Transaction_fees_BTC { get; set; }
    }
    // for 3d file.

    public struct FlightPath
    {
        public double StartLat { get; set; }
        public double StartLon { get; set; }
        public double EndLat { get; set; }
        public double EndLon { get; set; }
        public string Airline { get; set; }
        public string Airport1 { get; set; }
        public string Airport2 { get; set; }
        public int Count { get; set; }
    }

    public struct Line3D3
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double z1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double z2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }
        public double z3 { get; set; }
       
    }


    public struct Line3D2
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double z1 { get; set; }
        public string x2 { get; set; }
        public string y2 { get; set; }
        public string z2 { get; set; }
       

    }


    public struct Line3D1
    {
        public int row { get; set; }
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double z1 { get; set; }
    
        public double value { get; set; }


    }


    public struct TitanicPassenger
    {
        
        public int PassengerId { get; set; }
        public int Survived { get; set; }
        public int Pclass { get; set; }
        public string Name { get; set; }

        public string Sex { get; set; }

        public string Age { get; set; }
        public int SibSp { get; set; }
        public string Parch { get; set; }
        public string Ticket { get; set; }
        public double Fare { get; set; }
        public string Cabin { get; set; }
        public string Embarked { get; set; }
   
    }

    public struct IrisSample
    {
        public double SepalLength { get; set; }
        public double SepalWidth { get; set; }
        public double PetalLength { get; set; }
        public double PetalWidth { get; set; }
        public string IrisClass { get; set; }
    }

    public struct DinnerSample
    {
        public double TotalBill { get; set; }
        public double Tip { get; set; }
        public string Sex { get; set; }
        public string Smoker { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public int Size { get; set; }
    }

    public struct Mix
    {
        public int Clay { get; set; }
        public int Sand { get; set; }
        public int Silt { get; set; }

    }
    public struct Soil
    {
        public string Name { get; set; }

        public Mix[] Mixes { get; set; }
    }


    public struct WorldHappiness
    {

        public string Year { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int HappinessRank { get; set; }
        public double HappinessScore { get; set; }
        public string StandardError { get; set; }
        public double Economy_GDP_per_Capita { get; set; }
        public double Family { get; set; }
        public double Health_Life_Expectancy { get; set; }
        public double Freedom { get; set; }
        public double Trust_Government_Corruption { get; set; }
        public double Generosity { get; set; }
        public double Dystopia_Residual { get; set; }

    }


}
