//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: Scatter3DErrorInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

	public class Scatter3DErrorInfo : ValuesObject
	{

		public Scatter3DErrorInfo():base()		{		}

		public object? Array
		{
			get { return (ValueItems as dynamic).array; }
			set { (ValueItems as dynamic).array = value; }
		}

		public object? ArrayMinus
		{
			get { return (ValueItems as dynamic).arrayminus; }
			set { (ValueItems as dynamic).arrayminus = value; }
		}

		public object? Color
		{
			get { return (ValueItems as dynamic).color; }
			set { (ValueItems as dynamic).color = value; }
		}

		public bool? CopyZStyle
		{
			get { return (ValueItems as dynamic).copy_zstyle; }
			set { (ValueItems as dynamic).copy_zstyle = value; }
		}

		public bool? Symmetric
		{
			get { return (ValueItems as dynamic).symmetric; }
			set { (ValueItems as dynamic).symmetric = value; }
		}

		public double? Thickness
		{
			get { return (ValueItems as dynamic).thickness; }
			set { (ValueItems as dynamic).thickness = value; }
		}

		public int? TraceRef
		{
			get { return (ValueItems as dynamic).traceref; }
			set { (ValueItems as dynamic).traceref = value; }
		}

		public int? TraceRefMinus
		{
			get { return (ValueItems as dynamic).tracerefminus; }
			set { (ValueItems as dynamic).tracerefminus = value; }
		}

		public ErrorTypeOptions? Type
		{
			get { return EnumerationStatic.GetValueFromDescription<ErrorTypeOptions> ((ValueItems as dynamic).type); }
			set { (ValueItems as dynamic).type = value?.GetDescription(); }
		}

		public double? Value
		{
			get { return (ValueItems as dynamic).value; }
			set { (ValueItems as dynamic).value = value; }
		}

		public double? ValueMinus
		{
			get { return (ValueItems as dynamic).valueminus; }
			set { (ValueItems as dynamic).valueminus = value; }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		public double? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

	}
}

