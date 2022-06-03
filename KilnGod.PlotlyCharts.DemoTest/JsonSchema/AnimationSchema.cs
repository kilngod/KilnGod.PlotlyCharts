using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.JsonSchema
{
    public static partial class PlotlySchema
    {
        public const string AnimationSchema =

        @"{
  ""animation"": {
    ""direction"": {
      ""description"": ""The direction in which to play the frames triggered by the animation call"",
      ""dflt"": ""forward"",
      ""valType"": ""enumerated"",
      ""values"": [
        ""forward"",
        ""reverse""
      ]
    },
    ""frame"": {
      ""duration"": {
        ""description"": ""The duration in milliseconds of each frame. If greater than the frame duration, it will be limited to the frame duration."",
        ""dflt"": 500,
        ""min"": 0,
        ""valType"": ""number""
      },
      ""redraw"": {
        ""description"": ""Redraw the plot at completion of the transition. This is desirable for transitions that include properties that cannot be transitioned, but may significantly slow down updates that do not require a full redraw of the plot"",
        ""dflt"": true,
        ""valType"": ""boolean""
      },
      ""role"": ""object""
    },
    ""fromcurrent"": {
      ""description"": ""Play frames starting at the current frame instead of the beginning."",
      ""dflt"": false,
      ""valType"": ""boolean""
    },
    ""mode"": {
      ""description"": ""Describes how a new animate call interacts with currently-running animations. If `immediate`, current animations are interrupted and the new animation is started. If `next`, the current frame is allowed to complete, after which the new animation is started. If `afterall` all existing frames are animated to completion before the new animation is started."",
      ""dflt"": ""afterall"",
      ""valType"": ""enumerated"",
      ""values"": [
        ""immediate"",
        ""next"",
        ""afterall""
      ]
    },
    ""transition"": {
      ""duration"": {
        ""description"": ""The duration of the transition, in milliseconds. If equal to zero, updates are synchronous."",
        ""dflt"": 500,
        ""editType"": ""none"",
        ""min"": 0,
        ""valType"": ""number""
      },
      ""easing"": {
        ""description"": ""The easing function used for the transition"",
        ""dflt"": ""cubic-in-out"",
        ""editType"": ""none"",
        ""valType"": ""enumerated"",
        ""values"": [
          ""linear"",
          ""quad"",
          ""cubic"",
          ""sin"",
          ""exp"",
          ""circle"",
          ""elastic"",
          ""back"",
          ""bounce"",
          ""linear-in"",
          ""quad-in"",
          ""cubic-in"",
          ""sin-in"",
          ""exp-in"",
          ""circle-in"",
          ""elastic-in"",
          ""back-in"",
          ""bounce-in"",
          ""linear-out"",
          ""quad-out"",
          ""cubic-out"",
          ""sin-out"",
          ""exp-out"",
          ""circle-out"",
          ""elastic-out"",
          ""back-out"",
          ""bounce-out"",
          ""linear-in-out"",
          ""quad-in-out"",
          ""cubic-in-out"",
          ""sin-in-out"",
          ""exp-in-out"",
          ""circle-in-out"",
          ""elastic-in-out"",
          ""back-in-out"",
          ""bounce-in-out""
        ]
      },
      ""ordering"": {
        ""description"": ""Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change."",
        ""dflt"": ""layout first"",
        ""editType"": ""none"",
        ""valType"": ""enumerated"",
        ""values"": [
          ""layout first"",
          ""traces first""
        ]
      },
      ""role"": ""object""
    }
  }
}";

    }

}
