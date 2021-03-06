//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LightingInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class LightingInfo : ValuesObject
	{

		public LightingInfo():base()		{		}

		public double? Ambient
		{
			get { return (ValueItems as dynamic).ambient; }
			set { (ValueItems as dynamic).ambient = value; }
		}

		public double? Diffuse
		{
			get { return (ValueItems as dynamic).diffuse; }
			set { (ValueItems as dynamic).diffuse = value; }
		}

		public double? Fresnel
		{
			get { return (ValueItems as dynamic).fresnel; }
			set { (ValueItems as dynamic).fresnel = value; }
		}

		public double? Roughness
		{
			get { return (ValueItems as dynamic).roughness; }
			set { (ValueItems as dynamic).roughness = value; }
		}

		public double? Specular
		{
			get { return (ValueItems as dynamic).specular; }
			set { (ValueItems as dynamic).specular = value; }
		}

	}
}

