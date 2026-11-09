# KilnGod.PlotlyCharts

KilnGod.PlotlyCharts is a Blazor component library that exposes Plotly.js chart
authoring through C# models via a thin JavaScript adapter. It supports Blazor Server
and Blazor WebAssembly applications. 

![Alt text](./PlotlyGraph.png?raw=true "3D Chart goes here")

## Current release contract November 9, 2026.

- Performance optimizations to significantly improve rendering performance. 
- Target framework: .NET 10 (`net10.0`).
- Language version: C# 14 (`LangVersion` 14.0).
- Plotly.js: vendored and pinned to v4.2.0.
- License: MIT for this project and Plotly.js; see `License.txt` and the bundled
  `PlotlyJsThirdPartyNotices.txt` asset for dependency notices.

The Plotly.js runtime is shipped as a local static web asset. The adapter resolves it
relative to its own module URL, so consuming applications do not need a CDN, local
machine path, Plotly Cloud account, telemetry service, or proprietary map provider.

## Sample application

The demo host contains representative simple, specialty, financial, map, statistical,
scientific, and 3D/WebGL charts.

## Compatibility notes

Plotly.js v4.2.0 uses the MapLibre trace family (`choroplethmap`, `densitymap`, and
`scattermap`) instead of the removed Mapbox trace names. The package includes samples
for the replacement traces and for Quiver vector fields. Legacy Point Cloud and old
Mapbox trace wrappers are not included.

## Basic usage

```csharp
var data = new TraceList(new HeatmapTrace
{
    X = new[] { "Monday", "Tuesday", "Wednesday" },
    Y = new[] { "Morning", "Afternoon" },
    Z = new object[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }
});

await Chart1.newPlot(data);
```

Place a `PlotlyChart` component in a Razor component and call chart operations after
the component has initialized. The public C# model mirrors Plotly data/layout objects
while the JavaScript boundary remains generic.

## Architecture

Plotly internally uses json "sudo" code for ploting, I tried to keep the strongly typed c# plotting code with similar simplicity. 
```
// C# Code

	var data = new TraceList(new HeatmapTrace()
	{
		X = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
		Y = new string[] { "Morning", "Afternoon", "Evening" },
		Z = new object[] { new object?[] { 1, null, 30, 50, 1 }, new object[] { 20, 1, 60, 80, 30 }, new object[] { 30, 60, 1, -10, 20 } },
		HoverOnGaps = false
	});

	await Chart1.newPlot(data);

// Original JavaScript

	var data = [{		
		x: ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday'],
		y: ['Morning', 'Afternoon', 'Evening'],
		z: [[1, null, 30, 50, 1], [20, 1, 60, 80, 30], [30, 60, 1, -10, 20]],
		type: 'heatmap',
		hoverongaps: false
		}];

	Plotly.newPlot('myDiv', data);

```

Please review the samples charts and enjoy!






