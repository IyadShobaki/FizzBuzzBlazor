#pragma checksum "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74e4b927dbea0bb3230a5d91e0024815f1de79f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FizzBuzzBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using FizzBuzzBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\_Imports.razor"
using FizzBuzzBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\C#Projects\FizzBuzzBlazor\FizzBuzzBlazor\FizzBuzzBlazor\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
