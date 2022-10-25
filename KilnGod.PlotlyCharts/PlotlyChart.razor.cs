//***********************************************************************************
// KilnGod.PlotlyCharts
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: PlotlyChart.razor.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************



using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace KilnGod.PlotlyCharts
{
    public partial class PlotlyChart
    {


#nullable disable
        private IJSObjectReference asyncModule = null;

        private IJSInProcessObjectReference module = null;

        protected IJSRuntime _jsRuntime;

        protected IJSInProcessRuntime _jsInProcessRuntime = null;

        public event Action<PlotlyChart> PlotlyInitComplete = null;

#nullable enable

        [Parameter]
        public string PlotlyId { get; set; } = Guid.NewGuid().ToString();

        protected ElementReference _plotlyChartRef;

        public ElementReference PlotlyChartRef => this._plotlyChartRef;

        public bool IsWebAssembley { get { return (_jsRuntime is IJSInProcessRuntime); } }


        [Inject]
        public IJSRuntime jsRuntime
        {
            get
            {
                return _jsRuntime;
            }
            set
            {
                _jsRuntime = value;

                if (IsWebAssembley)
                {
                    _jsInProcessRuntime = (IJSInProcessRuntime)value;

                }
            }
        }



        /// <summary>
        /// OnAfterRenderAsync
        /// 
        /// Once the component is loaded in the web browser we want to initialize the isolated JavaScript module to call Plotly.js module functions.
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {

                try
                {
                    if (IsWebAssembley)
                    {

                        module = await _jsInProcessRuntime.InvokeAsync<IJSInProcessObjectReference>("import", "./_content/KilnGod.PlotlyCharts/PlotlyCharting.js");

                        module.InvokeVoid("initializePlotlyChart", PlotlyId, IsWebAssembley);
                    }
                    else
                    {
                        asyncModule = await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/KilnGod.PlotlyCharts/PlotlyCharting.js");

                        await asyncModule.InvokeVoidAsync("initializePlotlyChart", PlotlyId, IsWebAssembley);

                    }

                    if (PlotlyInitComplete != null)
                        PlotlyInitComplete(this);

                }
                catch (Exception ex)
                {
                    var crap = ex.Message;
                }

            }

        }


        public async ValueTask SetValuePlotlyChart(string ValueName, params object?[]? args)
        {
            if (module != null)
            {
                module.InvokeVoid("setValuePlotlyChart", PlotlyChartRef, ValueName, args);
            }
            else
            {
                await asyncModule.InvokeVoidAsync("setValuePlotlyChart", PlotlyChartRef, ValueName, args);
            }
        }


        public async ValueTask<T> GetValuePlotlyChart<T>(string ValueName, params object?[]? args)
        {
            if (module != null)
            {
                return module.Invoke<T>("getValuePlotlyChart", PlotlyChartRef, ValueName, args);
            }
            else
            {
                return await asyncModule.InvokeAsync<T>("getValuePlotlyChart", PlotlyChartRef, ValueName, args);
            }
        }


        /// <summary>
        /// SetFunctionPlotlyChart
        /// 
        /// This is a one direction call directly to Plotly.js module passing multiple parameters, this avoids mapping individual functions.
        /// </summary>
        /// <param name="FunctionName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async ValueTask SetFunctionPlotlyChart(string FunctionName, params object?[]? args)
        {
            if (module != null)
            {
                module.InvokeVoid("setFunctionPlotlyChart", PlotlyChartRef, FunctionName, args);
            }
            else
            {
                await asyncModule.InvokeVoidAsync("setFunctionPlotlyChart", PlotlyChartRef, FunctionName, args);
            }
        }


        public async ValueTask<T> GetFunctionPlotlyChart<T>(string FunctionName, params object?[]? args)
        {
            if (module != null)
            {
                return module.Invoke<T>("getFunctionPlotlyChart", PlotlyChartRef, FunctionName, args);
            }
            else
            {
                return await asyncModule.InvokeAsync<T>("getFunctionPlotlyChart", PlotlyChartRef, FunctionName, args);
            }
        }



        /// <summary>
        /// SetFunctionPlotlyBasis
        /// 
        /// In order to "use" Plotly.js we maintain our own custom "PlotlyBasis" object in the browser with references to browser stored objects.
        /// For performace reasons we must pass browser object references to "Plotly.js" and minimize sending information accross the wire between 
        /// the server and the browser. Therefor if we load an image we load it to the browser then display the image from local storage.
        /// </summary>
        /// <param name="FunctionName"></param>
        /// <param name="args"></param>
        /// <returns></returns>

        public async ValueTask SetFunctionPlotlyBasis(string FunctionName, params object?[]? args)
        {
            if (module != null)
            {
                module.InvokeVoid("setFunctionPlotlyBasis", PlotlyChartRef, FunctionName, args);
            }
            else
            {
                await asyncModule.InvokeVoidAsync("setFunctionPlotlyBasis", PlotlyChartRef, FunctionName, args);
            }
        }



        /// <summary>
        /// GetFunctionPlotlyBasis
        /// 
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="FunctionName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async ValueTask<T> GetFunctionPlotlyBasis<T>(string FunctionName, params object?[]? args)
        {
            if (module != null)
            {
                return module.Invoke<T>("getFunctionPlotlyBasis", PlotlyChartRef, FunctionName, args);
            }
            else
            {
                return await asyncModule.InvokeAsync<T>("getFunctionPlotlyBasis", PlotlyChartRef, FunctionName, args);
            }
        }

    }
}
