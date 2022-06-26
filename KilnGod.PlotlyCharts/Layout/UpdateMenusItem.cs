//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: UpdateMenusItem.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations.LayoutEnums;
using KilnGod.PlotlyCharts.Wrappers;

namespace KilnGod.PlotlyCharts.Layout
{
    public class UpdateMenusItem : ValuesObject
	{

		public UpdateMenusItem() : base() { }

		public int? Active
		{
			get { return (ValueItems as dynamic).active; }
			set { (ValueItems as dynamic).active = value; }
		}

		public object? BgColor
		{
			get { return (ValueItems as dynamic).bgcolor; }
			set { (ValueItems as dynamic).bgcolor = value; }
		}

		public object? BorderColor
		{
			get { return (ValueItems as dynamic).bordercolor; }
			set { (ValueItems as dynamic).bordercolor = value; }
		}

		public double? Borderwidth
		{
			get { return (ValueItems as dynamic).borderwidth; }
			set { (ValueItems as dynamic).borderwidth = value; }
		}

		ItemList<ButtonsItem>? _ButtonsItems = null;
		public ItemList<ButtonsItem>? Buttons
		{
			get
			{
				return _ButtonsItems;
			}
			set
			{
				_ButtonsItems = value;
				if (value != null)
				{
					(ValueItems as dynamic).buttons = _ButtonsItems?.Values;
				}
			}
		}

		
		public DirectionOptions? Direction
		{
			get { return EnumerationStatic.GetValueFromDescription<DirectionOptions>((ValueItems as dynamic).direction); }
			set { (ValueItems as dynamic).direction = value?.GetDescription(); }
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

		public string? Name
		{
			get { return (ValueItems as dynamic).name; }
			set { (ValueItems as dynamic).name = value; }
		}

		PadInfo? _Pad = null;
		public PadInfo? Pad
		{
			get { return _Pad; }
			set
			{
				_Pad = value;
				(ValueItems as dynamic).pad = _Pad?.ValueItems;
			}
		}

		public bool? ShowActive
		{
			get { return (ValueItems as dynamic).showactive; }
			set { (ValueItems as dynamic).showactive = value; }
		}

		public string? Templateitemname
		{
			get { return (ValueItems as dynamic).templateitemname; }
			set { (ValueItems as dynamic).templateitemname = value; }
		}

		public UpdateMenuTypeOptions? UpdateMenusItemsType
		{
			get { return EnumerationStatic.GetValueFromDescription<UpdateMenuTypeOptions>((ValueItems as dynamic).updatemenusitemstype); }
			set { (ValueItems as dynamic).updatemenusitemstype = value?.GetDescription(); }
		}

		public bool? Visible
		{
			get { return (ValueItems as dynamic).visible; }
			set { (ValueItems as dynamic).visible = value; }
		}

		public double? X
		{
			get { return (ValueItems as dynamic).x; }
			set { (ValueItems as dynamic).x = value; }
		}

		public RefOptions? XRef
		{
			get { return EnumerationStatic.GetValueFromDescription<RefOptions>((ValueItems as dynamic).xref); }
			set { (ValueItems as dynamic).xref = value?.GetDescription(); }
		}

		public XAnchorOptions? XAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<XAnchorOptions>((ValueItems as dynamic).xanchor); }
			set { (ValueItems as dynamic).xanchor = value?.GetDescription(); }
		}

		public double? Y
		{
			get { return (ValueItems as dynamic).y; }
			set { (ValueItems as dynamic).y = value; }
		}

		public RefOptions? YRef
		{
			get { return EnumerationStatic.GetValueFromDescription<RefOptions>((ValueItems as dynamic).yref); }
			set { (ValueItems as dynamic).yref = value?.GetDescription(); }
		}

		public YAnchorOptions? YAnchor
		{
			get { return EnumerationStatic.GetValueFromDescription<YAnchorOptions>((ValueItems as dynamic).yanchor); }
			set { (ValueItems as dynamic).yanchor = value?.GetDescription(); }
		}

	}




}
