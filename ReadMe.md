# KilnGod.Plotly Blazor Library  

### by KilnGod (James Carpenter, yes I love ceramics)

![Alt text](./PlotlyGraph.png?raw=true "3D Chart goes here")

## Purpose
I needed a good 2D graphics library, seemed easy enough to make a Blazor wrapper around "plotly.js" library. 

## Status (alpha 0.1)
I'm only 20 hours in and have most charts plotting, still needs a lot of work. As I've worked through the "plotly.js" 
architecture creating c# wrapper objects, currently still a fiddly process. I will need to rerun though the automation 
process to reduce the manaual amount of work. "plotly.js" uses a lot of similarily "named" objects with slightly different
values, as well many diplicate objects with differnt names in their schema. Which make "plotly.js" schema an interesting 
test to wrap for Blazor interop.

## Supports both Blazor Server and WebAssembly clients.
After a lot of experimenting I determined a simple way to properly wrap any JavaScript ES6 module in a single "module" Blazor component 
that works in both Blazor Server and WebAssembly. One code base is always better.

## MIT open style license
I can see a lot of ways to improve this library. Currently I invest time on the ILGPU open source project on GitHub and I have 
not decided how much time I want to invest in "plotly" support.

## Architecture
One of my main complaints is I could not directly inherit from an ExpandoObject, this would have simplified this code base.
It might be I'll create my own ExpandoObject but for now I've not yet decided to put in that many hours. As goal one is a proof of
concept that we can create prettly graphs with this Blazor "plotly.js" wrapper.

Plotly internally uses json "sudo" code for ploting, I tried to keep the strongly typed c# plotting code with similar simplicity. 
```
// C# Code

	TraceList dataTraces = new TraceList(new HeatmapTrace()
	{
		X = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
		Y = new string[] { "Morning", "Afternoon", "Evening" },
		Z = new object[] { new object?[] { 1, null, 30, 50, 1 }, new object[] { 20, 1, 60, 80, 30 }, new object[] { 30, 60, 1, -10, 20 } },
		HoverOnGaps = false
	});

	await Chart1.newPlot(dataTraces, commonLayout, commonConfig);

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








