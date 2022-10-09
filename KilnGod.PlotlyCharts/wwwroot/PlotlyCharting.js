//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyCharting.js
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************


import * as Plotly from 'https://cdn.plot.ly/plotly-2.11.1.min.js'


export function initializePlotlyChart(plotlyId, isWebassemblyClient) {
    // strict mode on by default in modules


    const plotlyChart = window.document.getElementById(plotlyId); // this is a div

    plotlyChart.plotlyBasis = new PlotlyBasis(plotlyChart, isWebassemblyClient);

 //   window.Plotly.newPlot(plotlyChart, [{ y: [1, 2, 3] }]);
   
    return;
}


export function callFormMethod(elementId, methodName, values)
{
    const htmlObject = window.document.getElementById(elementId);

    htmlObject[methodName]();

    return;
}

export function InjectScript(scriptText) {
    // strict mode on by default in modules
    eval(scriptText);

}

// does this make sense?
export function setValuePlotlyChart(plotlyChart, valueName, values) {
    // strict mode on by default in modules
    if (plotlyChart) {

        // Blazor "params object?[]? args" as values can be passed as an array of arrays. 
        // When the first element is an array substitute the first element as the array.
        if (Array.isArray(values)) {

            if (Array.isArray(values[0])) {

                values = values[0];
            }
        }
        plotlyChart[valueName] = values;
    }
}


export function setFunctionPlotlyChart(plotlyChart, functionName, values) {
    // strict mode on by default in modules
    if (plotlyChart) {       

        if (Array.isArray(values)) {

            /* plotly expects several object, the first being an array

            // Blazor "params object?[]? args" as values can be passed as an array of arrays. 
            // When the first element is an array substitute the first element as the array.
            if (Array.isArray(values[0])) {
                values = values[0];
            }
            */
            // call the named webgl function
            switch (values.length) {
                case 0: //no parameters empty array
                    window.Plotly[functionName](plotlyChart);
                    break;
                case 1:
                    window.Plotly[functionName](plotlyChart, values[0]);
                    break;
                case 2:
                    window.Plotly[functionName](plotlyChart, values[0], values[1]);
                    break;
                case 3:
                    window.Plotly[functionName](plotlyChart, values[0], values[1], values[2]);
                    break;
                case 4:
                    window.Plotly[functionName](plotlyChart, values[0], values[1], values[2], values[3]);
                    break;
                case 5:
                    window.Plotly[functionName](plotlyChart, values[0], values[1], values[2], values[3], values[4]);
                    break;
                case 6:
                    window.Plotly[functionName](plotlyChart, values[0], values[1], values[2], values[3], values[4], values[5]);
                    break;
                case 7:
                    window.Plotly[functionName](plotlyChart, values[0], values[1], values[2], values[3], values[4], values[5], values[6]);
                    break;
                default:
                    window.Plotly[functionName](plotlyChart, values); // arrays longer than 7 terms have to be managed by the receiving function
                    break;
            }
        }
        else {
            context[functionName](values);
        }
    }
}



export class PlotlyBasis {
    // strict mode on by default in modules
    constructor(plotlyCanvas, isWebAssemblyClient) {

        this.plotlyCanvas = plotlyCanvas;
        this.isWebassemblyClient = this.isWebassemblyClient;

        this.templateStorage = [];
    }

    validate(data, layout) {

        return window.Plotly.validate(data, layout);

    }

    makeTemplate(templateName, plotObject) {
        this.templateStorage[templateName] = window.Plotly.makeTemplate(plotObject);
    }

    validateTemplate(templateName, plotObject) {
        return window.Plotly.validateTemplate(plotObject, this.templateStorage[templateName]);
    }



}


