using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.JsonSchema
{
    public static partial class PlotlySchema
    {
        public const string TransformsSchema = @"
{
  ""transforms"": {
    ""aggregate"": {
      ""attributes"": {
        ""aggregations"": {
          ""items"": {
            ""aggregation"": {
              ""editType"": ""calc"",
              ""enabled"": {
                ""description"": ""Determines whether this aggregation function is enabled or disabled."",
                ""dflt"": true,
                ""editType"": ""calc"",
                ""valType"": ""boolean""
              },
              ""func"": {
                ""description"": ""Sets the aggregation function. All values from the linked `target`, corresponding to the same value in the `groups` array, are collected and reduced by this function. *count* is simply the number of values in the `groups` array, so does not even require the linked array to exist. *first* (*last*) is just the first (last) linked value. Invalid values are ignored, so for example in *avg* they do not contribute to either the numerator or the denominator. Any data type (numeric, date, category) may be aggregated with any function, even though in certain cases it is unlikely to make sense, for example a sum of dates or average of categories. *median* will return the average of the two central values if there is an even count. *mode* will return the first value to reach the maximum count, in case of a tie. *change* will return the difference between the first and last linked values. *range* will return the difference between the min and max linked values."",
                ""dflt"": ""first"",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""count"",
                  ""sum"",
                  ""avg"",
                  ""median"",
                  ""mode"",
                  ""rms"",
                  ""stddev"",
                  ""min"",
                  ""max"",
                  ""first"",
                  ""last"",
                  ""change"",
                  ""range""
                ]
              },
              ""funcmode"": {
                ""description"": ""*stddev* supports two formula variants: *sample* (normalize by N-1) and *population* (normalize by N)."",
                ""dflt"": ""sample"",
                ""editType"": ""calc"",
                ""valType"": ""enumerated"",
                ""values"": [
                  ""sample"",
                  ""population""
                ]
              },
              ""role"": ""object"",
              ""target"": {
                ""description"": ""A reference to the data array in the parent trace to aggregate. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate over the marker color array. The referenced array must already exist, unless `func` is *count*, and each array may only be referenced once."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              }
            }
          },
          ""role"": ""object""
        },
        ""editType"": ""calc"",
        ""enabled"": {
          ""description"": ""Determines whether this aggregate transform is enabled or disabled."",
          ""dflt"": true,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        },
        ""groups"": {
          ""arrayOk"": true,
          ""description"": ""Sets the grouping target to which the aggregation is applied. Data points with matching group values will be coalesced into one point, using the supplied aggregation functions to reduce data in other data arrays. If a string, `groups` is assumed to be a reference to a data array in the parent trace object. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate about the marker color array. If an array, `groups` is itself the data array by which we aggregate."",
          ""dflt"": ""x"",
          ""editType"": ""calc"",
          ""noBlank"": true,
          ""strict"": true,
          ""valType"": ""string""
        },
        ""groupssrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `groups`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        }
      }
    },
    ""filter"": {
      ""attributes"": {
        ""editType"": ""calc"",
        ""enabled"": {
          ""description"": ""Determines whether this filter transform is enabled or disabled."",
          ""dflt"": true,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        },
        ""operation"": {
          ""description"": ""Sets the filter operation. *=* keeps items equal to `value` *!=* keeps items not equal to `value` *<* keeps items less than `value` *<=* keeps items less than or equal to `value` *>* keeps items greater than `value` *>=* keeps items greater than or equal to `value` *[]* keeps items inside `value[0]` to `value[1]` including both bounds *()* keeps items inside `value[0]` to `value[1]` excluding both bounds *[)* keeps items inside `value[0]` to `value[1]` including `value[0]` but excluding `value[1] *(]* keeps items inside `value[0]` to `value[1]` excluding `value[0]` but including `value[1] *][* keeps items outside `value[0]` to `value[1]` and equal to both bounds *)(* keeps items outside `value[0]` to `value[1]` *](* keeps items outside `value[0]` to `value[1]` and equal to `value[0]` *)[* keeps items outside `value[0]` to `value[1]` and equal to `value[1]` *{}* keeps items present in a set of values *}{* keeps items not present in a set of values"",
          ""dflt"": ""="",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""="",
            ""!="",
            ""<"",
            "">="",
            "">"",
            ""<="",
            ""[]"",
            ""()"",
            ""[)"",
            ""(]"",
            ""]["",
            "")("",
            ""]("",
            "")["",
            ""{}"",
            ""}{""
          ]
        },
        ""preservegaps"": {
          ""description"": ""Determines whether or not gaps in data arrays produced by the filter operation are preserved. Setting this to *true* might be useful when plotting a line chart with `connectgaps` set to *false*."",
          ""dflt"": false,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        },
        ""target"": {
          ""arrayOk"": true,
          ""description"": ""Sets the filter target by which the filter is applied. If a string, `target` is assumed to be a reference to a data array in the parent trace object. To filter about nested variables, use *.* to access them. For example, set `target` to *marker.color* to filter about the marker color array. If an array, `target` is then the data array by which the filter is applied."",
          ""dflt"": ""x"",
          ""editType"": ""calc"",
          ""noBlank"": true,
          ""strict"": true,
          ""valType"": ""string""
        },
        ""targetcalendar"": {
          ""description"": ""WARNING: All transforms are deprecated and may be removed from the API in next major version. Sets the calendar system to use for `target`, if it is an array of dates. If `target` is a string (eg *x*) we use the corresponding trace attribute (eg `xcalendar`) if it exists, even if `targetcalendar` is provided."",
          ""dflt"": ""gregorian"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""chinese"",
            ""coptic"",
            ""discworld"",
            ""ethiopian"",
            ""gregorian"",
            ""hebrew"",
            ""islamic"",
            ""jalali"",
            ""julian"",
            ""mayan"",
            ""nanakshahi"",
            ""nepali"",
            ""persian"",
            ""taiwan"",
            ""thai"",
            ""ummalqura""
          ]
        },
        ""targetsrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `target`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""value"": {
          ""description"": ""Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,<,>=,>,<=) `value` is expected to be a number or a string. When `operation` is set to one of the interval values ([],(),[),(],][,)(,](,)[) `value` is expected to be 2-item array where the first item is the lower bound and the second item is the upper bound. When `operation`, is set to one of the set values ({},}{) `value` is expected to be an array with as many items as the desired set elements."",
          ""dflt"": 0,
          ""editType"": ""calc"",
          ""valType"": ""any""
        },
        ""valuecalendar"": {
          ""description"": ""WARNING: All transforms are deprecated and may be removed from the API in next major version. Sets the calendar system to use for `value`, if it is a date."",
          ""dflt"": ""gregorian"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""chinese"",
            ""coptic"",
            ""discworld"",
            ""ethiopian"",
            ""gregorian"",
            ""hebrew"",
            ""islamic"",
            ""jalali"",
            ""julian"",
            ""mayan"",
            ""nanakshahi"",
            ""nepali"",
            ""persian"",
            ""taiwan"",
            ""thai"",
            ""ummalqura""
          ]
        }
      }
    },
    ""groupby"": {
      ""attributes"": {
        ""editType"": ""calc"",
        ""enabled"": {
          ""description"": ""Determines whether this group-by transform is enabled or disabled."",
          ""dflt"": true,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        },
        ""groups"": {
          ""description"": ""Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4]."",
          ""dflt"": [],
          ""editType"": ""calc"",
          ""valType"": ""data_array""
        },
        ""groupssrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `groups`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        },
        ""nameformat"": {
          ""description"": ""Pattern by which grouped traces are named. If only one trace is present, defaults to the group name (`\""%{group}\""`), otherwise defaults to the group name with trace name (`\""%{group} (%{trace})\""`). Available escape sequences are `%{group}`, which inserts the group name, and `%{trace}`, which inserts the trace name. If grouping GDP data by country when more than one trace is present, for example, the default \""%{group} (%{trace})\"" would return \""Monaco (GDP per capita)\""."",
          ""editType"": ""calc"",
          ""valType"": ""string""
        },
        ""styles"": {
          ""items"": {
            ""style"": {
              ""editType"": ""calc"",
              ""role"": ""object"",
              ""target"": {
                ""description"": ""The group value which receives these styles."",
                ""editType"": ""calc"",
                ""valType"": ""string""
              },
              ""value"": {
                ""_compareAsJSON"": true,
                ""description"": ""Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red."",
                ""dflt"": {},
                ""editType"": ""calc"",
                ""valType"": ""any""
              }
            }
          },
          ""role"": ""object""
        }
      }
    },
    ""sort"": {
      ""attributes"": {
        ""editType"": ""calc"",
        ""enabled"": {
          ""description"": ""Determines whether this sort transform is enabled or disabled."",
          ""dflt"": true,
          ""editType"": ""calc"",
          ""valType"": ""boolean""
        },
        ""order"": {
          ""description"": ""Sets the sort transform order."",
          ""dflt"": ""ascending"",
          ""editType"": ""calc"",
          ""valType"": ""enumerated"",
          ""values"": [
            ""ascending"",
            ""descending""
          ]
        },
        ""target"": {
          ""arrayOk"": true,
          ""description"": ""Sets the target by which the sort transform is applied. If a string, *target* is assumed to be a reference to a data array in the parent trace object. To sort about nested variables, use *.* to access them. For example, set `target` to *marker.size* to sort about the marker size array. If an array, *target* is then the data array by which the sort transform is applied."",
          ""dflt"": ""x"",
          ""editType"": ""calc"",
          ""noBlank"": true,
          ""strict"": true,
          ""valType"": ""string""
        },
        ""targetsrc"": {
          ""description"": ""Sets the source reference on Chart Studio Cloud for `target`."",
          ""editType"": ""none"",
          ""valType"": ""string""
        }
      }
    }
  }
}";
    }
}
