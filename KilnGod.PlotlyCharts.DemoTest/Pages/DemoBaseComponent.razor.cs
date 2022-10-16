using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace KilnGod.PlotlyCharts.DemoTest.Pages
{
    public partial class DemoBaseComponent : ComponentBase
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


        public async ValueTask CallElementMethod( string functionName, ElementReference elementRef, params object?[]? args)
        {
            if (IsWebAssembley)
            {
                _jsInProcessRuntime.InvokeVoid("callElementMethod", functionName, elementRef, args);
            }
            else
            {
                await _jsRuntime.InvokeVoidAsync("callElementMethod", functionName, elementRef, args);
            }
        }


    }
}
