//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: NumberInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class NumberInfo : ValuesObject
	{

		public NumberInfo():base()		{		}

		FontInfo? _Font = null;
		public FontInfo? Font
		{
			get { return _Font; }
			set
			{
				_Font = value;
				(ValueItems as dynamic).font = _Font?.ValueItems;
			}
		}

		public string? Prefix
		{
			get { return (ValueItems as dynamic).prefix; }
			set { (ValueItems as dynamic).prefix = value; }
		}

		public string? Suffix
		{
			get { return (ValueItems as dynamic).suffix; }
			set { (ValueItems as dynamic).suffix = value; }
		}

		public string? ValueFormat
		{
			get { return (ValueItems as dynamic).valueformat; }
			set { (ValueItems as dynamic).valueformat = value; }
		}

	}
}

