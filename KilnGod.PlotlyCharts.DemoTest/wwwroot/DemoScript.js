//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: DemoScript.js
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************



function callElementMethod(functionName, elementRef, values) {
    if (Array.isArray(values)) {
       
        switch (values.length) {
            case 0: //no parameters empty array
                elementRef[functionName]();
                break;
            case 1:
                elementRef[functionName](values[0]);
                break;
            case 2:
                elementRef[functionName](values[0], values[1]);
                break;
            case 3:
                elementRef[functionName](values[0], values[1], values[2]);
                break;
            case 4:
                elementRef[functionName](values[0], values[1], values[2], values[3]);
                break;
            case 5:
                elementRef[functionName](values[0], values[1], values[2], values[3], values[4]);
                break;
            case 6:
                elementRef[functionName](values[0], values[1], values[2], values[3], values[4], values[5]);
                break;
            case 7:
                elementRef[functionName](values[0], values[1], values[2], values[3], values[4], values[5], values[6]);
                break;
            default:
                elementRef[functionName](values); // arrays longer than 7 terms have to be managed by the receiving function
                break;
        }
    }
    else {
        elementRef[functionName]();
    }
    return;
}