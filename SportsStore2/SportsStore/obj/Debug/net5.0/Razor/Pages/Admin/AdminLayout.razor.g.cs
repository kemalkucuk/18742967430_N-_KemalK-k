#pragma checksum "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7dc7a67c4de508b9439c4de182601c77c07fdc3"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""bg-info text-white p-2""><div class=""container-fluid""><div class=""row""><div class=""col""><span class=""navbar-brand ml-2"">Haberler Admin</span></div>
            <div class=""col-2 text-right""><a class=""btn btn-sm btn-primary"" href=""/account/logout"">Log Out</a></div></div></div></div>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row p-2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(9, "href", "/admin/products");
            __builder.AddAttribute(10, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\AdminLayout.razor"
                               NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\n                Haberler\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col");
            __builder.AddContent(17, 
#nullable restore
#line 27 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Admin\AdminLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
