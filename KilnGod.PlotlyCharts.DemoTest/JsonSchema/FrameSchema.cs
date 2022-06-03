using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.JsonSchema
{
    public static partial class PlotlySchema
    {
        public const string FramesSchema = @"
{
  ""frames"": {
    ""items"": {
      ""frames_entry"": {
        ""baseframe"": {
          ""description"": ""The name of the frame into which this frame's properties are merged before applying. This is used to unify properties and avoid needing to specify the same values for the same properties in multiple frames."",
          ""valType"": ""string""
        },
        ""data"": {
          ""description"": ""A list of traces this frame modifies. The format is identical to the normal trace definition."",
          ""valType"": ""any""
        },
        ""group"": {
          ""description"": ""An identifier that specifies the group to which the frame belongs, used by animate to select a subset of frames."",
          ""valType"": ""string""
        },
        ""layout"": {
          ""description"": ""Layout properties which this frame modifies. The format is identical to the normal layout definition."",
          ""valType"": ""any""
        },
        ""name"": {
          ""description"": ""A label by which to identify the frame"",
          ""valType"": ""string""
        },
        ""role"": ""object"",
        ""traces"": {
          ""description"": ""A list of trace indices that identify the respective traces in the data attribute"",
          ""valType"": ""any""
        }
      }
    },
    ""role"": ""object""
  }
}";
    }
}
