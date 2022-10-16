using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.Pages
{
    public class ChartPage
    {
#nullable disable

        protected IJSRuntime _jsRuntime;

        protected IJSInProcessRuntime _jsInProcessRuntime = null;

#nullable enable


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


        public async Task callGlobalMethod(ElementReference refID, string globalMethodName, params object?[]? args)
        {
            if (IsWebAssembley)
            {
                _jsInProcessRuntime.InvokeVoid(globalMethodName, refID, args);
            }
            else
            {
                await jsRuntime.InvokeVoidAsync(globalMethodName, refID, args);
            }
        }



    }
}
