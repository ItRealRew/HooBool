#pragma checksum "C:\Users\User\Desktop\HoodBool\Pages\Options.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2325d90f3a0e652d1930ace73071298c7bf98c53"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/options.html")]
    public partial class Options : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-options");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<h1>Settings</h1>\n    <hr>\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<span>Path to new file</span>\n        <br>\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\User\Desktop\HoodBool\Pages\Options.razor"
                      settings.SavePath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => settings.SavePath = __value, settings.SavePath));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.AddMarkupContent(12, "<div>\n        <span>Language</span>\n        <br>\n        <select>\n\n        </select>\n    </div>\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\User\Desktop\HoodBool\Pages\Options.razor"
       
    protected override void OnInitialized()
    {
        base.OnInitialized();

        // Получение данных настроек.
        settings.SavePath =  "ТЕСТ";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Models.Settings settings { get; set; }
    }
}
#pragma warning restore 1591
