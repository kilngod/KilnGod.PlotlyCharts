//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: TransformsEnums.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Enumerations.TransformsEnums
{
	/******************************
	*** Enum Name: func

	*** Description: Sets the aggregation function. All values from the linked `target`, corresponding to the same value in the `groups` array, are collected and reduced by this function. *count* is simply the number of values in the `groups` array, so does not even require the linked array to exist. *first* (*last*) is just the first (last) linked value. Invalid values are ignored, so for example in *avg* they do not contribute to either the numerator or the denominator. Any data type (numeric, date, category) may be aggregated with any function, even though in certain cases it is unlikely to make sense, for example a sum of dates or average of categories. *median* will return the average of the two central values if there is an even count. *mode* will return the first value to reach the maximum count, in case of a tie. *change* will return the difference between the first and last linked values. *range* will return the difference between the min and max linked values.
	******************************/

	public enum FuncOptions
	{
		[Description("count")]
		Count,
		[Description("sum")]
		Sum,
		[Description("avg")]
		Avg,
		[Description("median")]
		Median,
		[Description("mode")]
		Mode,
		[Description("rms")]
		Rms,
		[Description("stddev")]
		Stddev,
		[Description("min")]
		Min,
		[Description("max")]
		Max,
		[Description("first")]
		First,
		[Description("last")]
		Last,
		[Description("change")]
		Change,
		[Description("range")]
		Range
	}

	/******************************
	*** Enum Name: funcmode

	*** Description: *stddev* supports two formula variants: *sample* (normalize by N-1) and *population* (normalize by N).
	******************************/

	public enum FuncModeOptions
	{
		[Description("sample")]
		Sample,
		[Description("population")]
		Population
	}

	/******************************
	*** Enum Name: operation

	*** Description: Sets the filter operation. *=* keeps items equal to `value` *!=* keeps items not equal to `value` *<* keeps items less than `value` *<=* keeps items less than or equal to `value` *>* keeps items greater than `value` *>=* keeps items greater than or equal to `value` *[]* keeps items inside `value[0]` to `value[1]` including both bounds *()* keeps items inside `value[0]` to `value[1]` excluding both bounds *[)* keeps items inside `value[0]` to `value[1]` including `value[0]` but excluding `value[1] *(]* keeps items inside `value[0]` to `value[1]` excluding `value[0]` but including `value[1] *][* keeps items outside `value[0]` to `value[1]` and equal to both bounds *)(* keeps items outside `value[0]` to `value[1]` *](* keeps items outside `value[0]` to `value[1]` and equal to `value[0]` *)[* keeps items outside `value[0]` to `value[1]` and equal to `value[1]` *{}* keeps items present in a set of values *}{* keeps items not present in a set of values
	******************************/

	public enum OperationOptions
	{
		[Description("=")]
		Equals,
		[Description("!=")]
		NotEquals,
		[Description("<")]
		LessThan,
		[Description(">=")]
		GreaterThanEquals,
		[Description(">")]
		GreaterThan,
		[Description("<=")]
		LessThanEquals,
		[Description("[]")]
		LBRB,
		[Description("()")]
		LPRP,
		[Description("[)")]
		RBRP,
		[Description("(]")]
		LPRB,
		[Description("][")]
		RBLB,
		[Description(")(")]
		RPLP,
		[Description("](")]
		RBLP,
		[Description(")[")]
		TPLB,
		[Description("{}")]
		LCRC,
		[Description("}{")]
		RCLC
	}

	/******************************
	*** Enum Name: order

	*** Description: Sets the sort transform order.
	******************************/

	public enum OrderOptions
	{
		[Description("ascending")]
		Ascending,
		[Description("descending")]
		Descending
	}

	/******************************
	*** Enum Name: targetcalendar

	*** Description: WARNING: All transforms are deprecated and may be removed from the API in next major version. Sets the calendar system to use for `target`, if it is an array of dates. If `target` is a string (eg *x*) we use the corresponding trace attribute (eg `xcalendar`) if it exists, even if `targetcalendar` is provided.
	******************************/

	public enum TargetCalendarOptions
	{
		[Description("chinese")]
		Chinese,
		[Description("coptic")]
		Coptic,
		[Description("discworld")]
		Discworld,
		[Description("ethiopian")]
		Ethiopian,
		[Description("gregorian")]
		Gregorian,
		[Description("hebrew")]
		Hebrew,
		[Description("islamic")]
		Islamic,
		[Description("jalali")]
		Jalali,
		[Description("julian")]
		Julian,
		[Description("mayan")]
		Mayan,
		[Description("nanakshahi")]
		Nanakshahi,
		[Description("nepali")]
		Nepali,
		[Description("persian")]
		Persian,
		[Description("taiwan")]
		Taiwan,
		[Description("thai")]
		Thai,
		[Description("ummalqura")]
		Ummalqura
	}

	/******************************
	*** Enum Name: valuecalendar

	*** Description: WARNING: All transforms are deprecated and may be removed from the API in next major version. Sets the calendar system to use for `value`, if it is a date.
	******************************/

	public enum ValueCalendarOptions
	{
		[Description("chinese")]
		Chinese,
		[Description("coptic")]
		Coptic,
		[Description("discworld")]
		Discworld,
		[Description("ethiopian")]
		Ethiopian,
		[Description("gregorian")]
		Gregorian,
		[Description("hebrew")]
		Hebrew,
		[Description("islamic")]
		Islamic,
		[Description("jalali")]
		Jalali,
		[Description("julian")]
		Julian,
		[Description("mayan")]
		Mayan,
		[Description("nanakshahi")]
		Nanakshahi,
		[Description("nepali")]
		Nepali,
		[Description("persian")]
		Persian,
		[Description("taiwan")]
		Taiwan,
		[Description("thai")]
		Thai,
		[Description("ummalqura")]
		Ummalqura
	}


}
