// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebAssemblyBlazorChromeExtension.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using WebAssemblyBlazorChromeExtension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using WebAssemblyBlazorChromeExtension.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\Desktop\HoodBool\_Imports.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index.html")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\User\Desktop\HoodBool\Pages\Index.razor"
       
    // Количество потраченого времени.
    public string seconds = "";

    //Финальное количество времени
    public string secondsFinaly = "00:00";

    // Описывает состояние.
    private bool recordStatus = false;

    // Завершение записи.
    private void stopRecord()
    {
        secondsFinaly =  seconds;
        recordStatus = false;
    }
    
    // Начало записи.
    private void startRecord()
    {
        seconds = "00:00";
        StopWatch.StartTime();
        recordStatus = true;
    }

    // Обновление секундомера.
    private async Task updateStopWatch()
    {
        seconds = StopWatch.GetCurrentTime();
    }

    // Открытие папки с последним видео.
    private void openLastEntry()
    {
        Console.WriteLine("It Feature;");
    }

    private string Time { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        // Таймер для секундомера.
        var timer = new System.Threading.Timer((_) =>
        {
            InvokeAsync( async ()  =>
            {
                await updateStopWatch();
                StateHasChanged();
            });
        }, null, 0, 1000);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.StopWatch StopWatch { get; set; }
    }
}
#pragma warning restore 1591
