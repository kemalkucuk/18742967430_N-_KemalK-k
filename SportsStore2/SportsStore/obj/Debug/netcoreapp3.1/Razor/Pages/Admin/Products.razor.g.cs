#pragma checksum "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f31bb8fbf92851dcfb6bf3b055a990e65a4de417"
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
#line 1 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Products : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<thead>\n        <tr>\n            <th>ID</th><th>Name</th>\n            <th>Category</th><th>Price</th><td></td>\n        </tr>\n    </thead>\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 13 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
         if (ProductData?.Count() > 0) {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
             foreach (Product p in ProductData) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 16 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
                         p.ProductID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 17 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
                         p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 18 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
                         p.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 19 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
                         p.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddMarkupContent(22, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 22 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
                                        GetDetailsUrl(p.ProductID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "\n                            Details\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 26 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
                                        GetEditUrl(p.ProductID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "\n                            Edit\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n                        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
                                             e => DeleteProduct(p)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\n                            Delete\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
#nullable restore
#line 35 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
             
        } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "            ");
            __builder.AddMarkupContent(43, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Products</td>\n            </tr>\n");
#nullable restore
#line 40 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "btn btn-primary");
            __builder.AddAttribute(49, "href", "/admin/products/create");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(51, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Admin\Products.razor"
       

    public IStoreRepository Repository => Service;

    public IEnumerable<Product> ProductData { get; set; }

    protected async override Task OnInitializedAsync() {
        await UpdateData();
    }

    public async Task UpdateData() {
        ProductData = await Repository.Products.ToListAsync();
    }

    public async Task DeleteProduct(Product p) {
        Repository.DeleteProduct(p);
        await UpdateData();
    }

    public string GetDetailsUrl(long id) => $"/admin/products/details/{id}";
    public string GetEditUrl(long id) => $"/admin/products/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
