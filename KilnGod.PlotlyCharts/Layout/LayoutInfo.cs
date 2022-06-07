//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: LayoutInfo.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Enumerations.TracesEnums;
using KilnGod.PlotlyCharts.Wrappers;


namespace KilnGod.PlotlyCharts.Layout
{
    public class LayoutInfo : ValuesObject
	{

		public LayoutInfo() : base() { }

		ActiveShapeInfo? _ActiveShape = null;
		public ActiveShapeInfo? ActiveShape
		{
			get { return _ActiveShape; }
			set
			{
				_ActiveShape = value;
				(ValueItems as dynamic).activeshape = _ActiveShape?.ValueItems;
			}
		}

		ItemList<AnnotationItem>? _AnnotationItems = null;
		public ItemList<AnnotationItem>? Annotations
		{
			get
			{			
				return _AnnotationItems;
			}
            set
            {
				_AnnotationItems = value;
				(ValueItems as dynamic).annotations = _AnnotationItems?.Values;
			}
		}

		public bool? AutoSize
		{
			get { return (ValueItems as dynamic).autosize; }
			set { (ValueItems as dynamic).autosize = value; }
		}

		public AutoTypeNumbersOptions? AutoTypeNumbers
		{
			get { return EnumerationStatic.GetValueFromDescription<AutoTypeNumbersOptions>((ValueItems as dynamic).autotypenumbers); }
			set { (ValueItems as dynamic).autotypenumbers = value?.GetDescription(); }
		}

		public double? BarGap
		{
			get { return (ValueItems as dynamic).bargap; }
			set { (ValueItems as dynamic).bargap = value; }
		}

		public double? BarGroupGap
		{
			get { return (ValueItems as dynamic).bargroupgap; }
			set { (ValueItems as dynamic).bargroupgap = value; }
		}

		public BarModeOptions? BarMode
		{
			get { return EnumerationStatic.GetValueFromDescription<BarModeOptions>((ValueItems as dynamic).barmode); }
			set { (ValueItems as dynamic).barmode = value?.GetDescription(); }
		}

		public BarNormOptions? BarNorm
		{
			get { return EnumerationStatic.GetValueFromDescription<BarNormOptions>((ValueItems as dynamic).barnorm); }
			set { (ValueItems as dynamic).barnorm = value?.GetDescription(); }
		}


		public CalendarOptions? Calendar
		{
			get { return EnumerationStatic.GetValueFromDescription<CalendarOptions>((ValueItems as dynamic).calendar); }
			set { (ValueItems as dynamic).calendar = value?.GetDescription(); }
		}

		public ClickModeOptions? ClickMode
		{
			get { return EnumerationStatic.GetValueFromDescription<ClickModeOptions>((ValueItems as dynamic).clickmode); }
			set { (ValueItems as dynamic).clickmode = value?.GetDescription(); }
		}

		ColorAxisInfo? _ColorAxis = null;
		public ColorAxisInfo? ColorAxis
		{
			get { return _ColorAxis; }
			set
			{
				_ColorAxis = value;
				(ValueItems as dynamic).coloraxis = _ColorAxis?.ValueItems;
			}
		}

		ColorScaleInfo? _ColorScale = null;
		public ColorScaleInfo? ColorScale
		{
			get { return _ColorScale; }
			set
			{
				_ColorScale = value;
				(ValueItems as dynamic).colorscale = _ColorScale?.ValueItems;
			}
		}

		public object? Colorway
		{
			get { return (ValueItems as dynamic).colorway; }
			set { (ValueItems as dynamic).colorway = value; }
		}

		public object? Computed
		{
			get { return (ValueItems as dynamic).computed; }
			set { (ValueItems as dynamic).computed = value; }
		}

		public object? DataRevision
		{
			get { return (ValueItems as dynamic).datarevision; }
			set { (ValueItems as dynamic).datarevision = value; }
		}

		public DragModeOptions? DragMode
		{
			get { return EnumerationStatic.GetValueFromDescription<DragModeOptions>((ValueItems as dynamic).dragmode); }
			set { (ValueItems as dynamic).dragmode = value?.GetDescription(); }
		}

		public object? EditRevision
		{
			get { return (ValueItems as dynamic).editrevision; }
			set { (ValueItems as dynamic).editrevision = value; }
		}

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


		public FunnelModeOptions? FunnelMode
		{
			get { return EnumerationStatic.GetValueFromDescription<DragModeOptions>((ValueItems as dynamic).funnelmode); }
			set { (ValueItems as dynamic).funnelmode = value?.GetDescription(); }
		}

		GeoInfo? _Geo = null;
		public GeoInfo? Geo
		{
			get { return _Geo; }
			set
			{
				_Geo = value;
				(ValueItems as dynamic).geo = _Geo?.ValueItems;
			}
		}

		GridInfo? _Grid = null;
		public GridInfo? Grid
		{
			get { return _Grid; }
			set
			{
				_Grid = value;
				(ValueItems as dynamic).grid = _Grid?.ValueItems;
			}
		}

		public double? Height
		{
			get { return (ValueItems as dynamic).height; }
			set { (ValueItems as dynamic).height = value; }
		}

		public bool? Hidesources
		{
			get { return (ValueItems as dynamic).hidesources; }
			set { (ValueItems as dynamic).hidesources = value; }
		}

		public int? Hoverdistance
		{
			get { return (ValueItems as dynamic).hoverdistance; }
			set { (ValueItems as dynamic).hoverdistance = value; }
		}

		HoverLabelInfo? _HoverLabel = null;
		public HoverLabelInfo? HoverLabel
		{
			get { return _HoverLabel; }
			set
			{
				_HoverLabel = value;
				(ValueItems as dynamic).hoverlabel = _HoverLabel?.ValueItems;
			}
		}

		public HoverModeOptions? HoverMode
		{
			get { return EnumerationStatic.GetValueFromDescription<HoverModeOptions>((ValueItems as dynamic).hovermode); }
			set { (ValueItems as dynamic).hovermode = value?.GetDescription(); }
		}

		ItemList<ImagesItem>? _ImagesItems = null;
		public ItemList<ImagesItem>? Images
		{
			get
			{
				return _ImagesItems;
			}
			set
			{
				_ImagesItems = value;
				if (value != null)
				{
					(ValueItems as dynamic).images = _ImagesItems?.Values;
				}
			}
		}


		LegendInfo? _Legend = null;
		public LegendInfo? Legend
		{
			get { return _Legend; }
			set
			{
				_Legend = value;
				(ValueItems as dynamic).legend = _Legend?.ValueItems;
			}
		}

		MapboxInfo? _Mapbox = null;
		public MapboxInfo? Mapbox
		{
			get { return _Mapbox; }
			set
			{
				_Mapbox = value;
				(ValueItems as dynamic).mapbox = _Mapbox?.ValueItems;
			}
		}

		MarginInfo? _Margin = null;
		public MarginInfo? Margin
		{
			get { return _Margin; }
			set
			{
				_Margin = value;
				(ValueItems as dynamic).margin = _Margin?.ValueItems;
			}
		}

		public object? Meta
		{
			get { return (ValueItems as dynamic).meta; }
			set { (ValueItems as dynamic).meta = value; }
		}

		ModeBarInfo? _ModeBar = null;
		public ModeBarInfo? ModeBar
		{
			get { return _ModeBar; }
			set
			{
				_ModeBar = value;
				(ValueItems as dynamic).modebar = _ModeBar?.ValueItems;
			}
		}

		NewShapeInfo? _NewShape = null;
		public NewShapeInfo? NewShape
		{
			get { return _NewShape; }
			set
			{
				_NewShape = value;
				(ValueItems as dynamic).newshape = _NewShape?.ValueItems;
			}
		}

		public object? PaperBgColor
		{
			get { return (ValueItems as dynamic).paper_bgcolor; }
			set { (ValueItems as dynamic).paper_bgcolor = value; }
		}

		public object? PlotBgColor
		{
			get { return (ValueItems as dynamic).plot_bgcolor; }
			set { (ValueItems as dynamic).plot_bgcolor = value; }
		}

		PolarInfo? _Polar = null;
		public PolarInfo? Polar
		{
			get { return _Polar; }
			set
			{
				_Polar = value;
				(ValueItems as dynamic).polar = _Polar?.ValueItems;
			}
		}

		SceneInfo? _Scene = null;
		public SceneInfo? Scene
		{
			get { return _Scene; }
			set
			{
				_Scene = value;
				(ValueItems as dynamic).scene = _Scene?.ValueItems;
			}
		}

		public SelectDirectionOptions? SelectDirection
		{
			get { return EnumerationStatic.GetValueFromDescription<SelectDirectionOptions>((ValueItems as dynamic).selectdirection); }
			set { (ValueItems as dynamic).selectdirection = value?.GetDescription(); }
		}

		public object? SelectionRevision
		{
			get { return (ValueItems as dynamic).selectionrevision; }
			set { (ValueItems as dynamic).selectionrevision = value; }
		}

		public string? Separators
		{
			get { return (ValueItems as dynamic).separators; }
			set { (ValueItems as dynamic).separators = value; }
		}

		ItemList<ShapeItem>? _ShapeItems = null;
		public ItemList<ShapeItem>? Shapes
		{
			get
			{
				return _ShapeItems;
			}
			set
			{
				_ShapeItems = value;
				if (value != null)
				{
					(ValueItems as dynamic).shapes = _ShapeItems?.Values;
				}
			}
		}

		public bool? ShowLegend
		{
			get { return (ValueItems as dynamic).showlegend; }
			set { (ValueItems as dynamic).showlegend = value; }
		}


		ItemList<SlidersItem>? _SlidersItems = null;
		public ItemList<SlidersItem>? Sliders
		{
			get
			{
				return _SlidersItems;
			}
			set
			{
				_SlidersItems = value;
				if (value != null)
				{
					(ValueItems as dynamic).sliders = _SlidersItems?.Values;
				}
			}
		}

		

		SmithInfo? _Smith = null;
		public SmithInfo? Smith
		{
			get { return _Smith; }
			set
			{
				_Smith = value;
				(ValueItems as dynamic).smith = _Smith?.ValueItems;
			}
		}

		public int? Spikedistance
		{
			get { return (ValueItems as dynamic).spikedistance; }
			set { (ValueItems as dynamic).spikedistance = value; }
		}

		public object? Template
		{
			get { return (ValueItems as dynamic).template; }
			set { (ValueItems as dynamic).template = value; }
		}

		TernaryInfo? _Ternary = null;
		public TernaryInfo? Ternary
		{
			get { return _Ternary; }
			set
			{
				_Ternary = value;
				(ValueItems as dynamic).ternary = _Ternary?.ValueItems;
			}
		}

		TitleInfo? _Title = null;
		public TitleInfo? Title
		{
			get { return _Title; }
			set
			{
				_Title = value;
				(ValueItems as dynamic).title = _Title?.ValueItems;
			}
		}

		TransitionInfo? _Transition = null;
		public TransitionInfo? Transition
		{
			get { return _Transition; }
			set
			{
				_Transition = value;
				(ValueItems as dynamic).transition = _Transition?.ValueItems;
			}
		}

		public object? UiRevision
		{
			get { return (ValueItems as dynamic).uirevision; }
			set { (ValueItems as dynamic).uirevision = value; }
		}

		UniformTextInfo? _UniformText = null;
		public UniformTextInfo? UniformText
		{
			get { return _UniformText; }
			set
			{
				_UniformText = value;
				(ValueItems as dynamic).uniformtext = _UniformText?.ValueItems;
			}
		}

		ItemList<UpdateMenusItem>? _UpdateMenusItems = null;
		public ItemList<UpdateMenusItem>? UpdateMenus
		{
			get
			{
				return _UpdateMenusItems;
			}
			set
			{
				_UpdateMenusItems = value;
				if (value != null)
				{
					(ValueItems as dynamic).updatemenus = _UpdateMenusItems?.Values;
				}
			}
		}

		public double? ViolinGap
		{
			get { return (ValueItems as dynamic).violingap; }
			set { (ValueItems as dynamic).violingap = value; }
		}

		public double? ViolinGroupGap
		{
			get { return (ValueItems as dynamic).violingroupgap; }
			set { (ValueItems as dynamic).violingroupgap = value; }
		}

		public ViolinModeOptions? ViolinMode
		{
			get { return EnumerationStatic.GetValueFromDescription<ViolinModeOptions>((ValueItems as dynamic).violinmode); }
			set { (ValueItems as dynamic).violinmode = value?.GetDescription(); }
		}

		public double? Width
		{
			get { return (ValueItems as dynamic).width; }
			set { (ValueItems as dynamic).width = value; }
		}

		AxisInfo? _XAxis = null;
		public AxisInfo? XAxis
		{
			get { return _XAxis; }
			set
			{
				_XAxis = value;
				(ValueItems as dynamic).xaxis = _XAxis?.ValueItems;
			}
		}

		AxisInfo? _YAxis = null;
		public AxisInfo? YAxis
		{
			get { return _YAxis; }
			set
			{
				_YAxis = value;
				(ValueItems as dynamic).yaxis = _YAxis?.ValueItems;
			}
		}

	}

}
