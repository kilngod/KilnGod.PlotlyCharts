//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: EditsInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Configuration
{

	public class EditsInfo : ValuesObject
	{

		public EditsInfo():base()		{		}

		public bool? AnnotationPosition
		{
			get { return (ValueItems as dynamic).annotationposition; }
			set { (ValueItems as dynamic).annotationposition = value; }
		}

		public bool? AnnotationTail
		{
			get { return (ValueItems as dynamic).annotationtail; }
			set { (ValueItems as dynamic).annotationtail = value; }
		}

		public bool? AnnotationText
		{
			get { return (ValueItems as dynamic).annotationtext; }
			set { (ValueItems as dynamic).annotationtext = value; }
		}

		public bool? AxisTitleText
		{
			get { return (ValueItems as dynamic).axistitletext; }
			set { (ValueItems as dynamic).axistitletext = value; }
		}

		public bool? ColorBarPosition
		{
			get { return (ValueItems as dynamic).colorbarposition; }
			set { (ValueItems as dynamic).colorbarposition = value; }
		}

		public bool? ColorBarTitleText
		{
			get { return (ValueItems as dynamic).colorbartitletext; }
			set { (ValueItems as dynamic).colorbartitletext = value; }
		}

		public bool? LegendPosition
		{
			get { return (ValueItems as dynamic).legendposition; }
			set { (ValueItems as dynamic).legendposition = value; }
		}

		public bool? LegendText
		{
			get { return (ValueItems as dynamic).legendtext; }
			set { (ValueItems as dynamic).legendtext = value; }
		}

		public bool? ShapePosition
		{
			get { return (ValueItems as dynamic).shapeposition; }
			set { (ValueItems as dynamic).shapeposition = value; }
		}

		public bool? TitleText
		{
			get { return (ValueItems as dynamic).titletext; }
			set { (ValueItems as dynamic).titletext = value; }
		}

	}
}

