#pragma checksum "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2a91e4d27b3d5be3858b7d59e1dd9cb5b66e396"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDapperSPA.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using BlazorDapperSPA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using BlazorDapperSPA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\_Imports.razor"
using C1.Blazor.Grid;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorDapperSPA.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"https://codewithsarath.com\" target=\"_blank\">Developed By Nicholas</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "C:\Users\Nicol\source\repos\BlazorDapperSPA\BlazorDapperSPA\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591