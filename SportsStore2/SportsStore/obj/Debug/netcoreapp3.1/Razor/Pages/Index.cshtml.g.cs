#pragma checksum "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fbbcff988365db045e54e1591dab6735702fa95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportsStore.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SportsStore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fbbcff988365db045e54e1591dab6735702fa95", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5cd140a63a3e465973e0b3b840d16d3cffe19c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Index.cshtml"
  
    ViewData["Title"] = "Haberlere Hoş Geldiniz";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <style>
                .slider {
                    width: 900px;
                    height: 600px;
                    margin-left: auto;
                    margin-right: auto;
                    margin-top: 0px;
                    text-align: center;
                    overflow: hidden;
                }

                .image-container {
                    width: 1500px;
                    height: 300px;
                    clear: both;
                    position: relative;
                    -webkit-transition: left 2s;
                    -moz-transition: left 2s;
                    -o-transition: left 2s;
                    transition: left 2s;
                }

                .slide {
                    float: left;
                    margin: 0px;
                    padding: 0px;
                    position: relative;
                }

                #slide-1:target ~ .image-container {
                    left: 0px;
                }

          ");
            WriteLiteral(@"      #slide-2:target ~ .image-container {
                    left: -500px;
                }

                #slide-3:target ~ .image-container {
                    left: -1000px;
                }

                .buttons {
                    position: relative;
                    top: -20px;
                }

                    .buttons a {
                        display: inline-block;
                        height: 15px;
                        width: 15px;
                        border-radius: 50px;
                        background-color: lightgreen;
                    }
            </style>
<div class=""text-center"">
    <h1 class=""display-4"">");
#nullable restore
#line 61 "C:\Users\Mert\Desktop\SportsStore2\SportsStore\Pages\Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <div class=""row"">
        <div class=""col-md-1"">
            
        </div>
        <div class=""col-md-10"">
           
          
           
                <div class=""slider"">
                    <span id=""slide-1""></span>
                    <span id=""slide-2""></span>
                    <span id=""slide-3""></span>
                    <div class=""image-container"">
                        <img src=""https://i.nethaber.com/storage/files/images/2021/03/01/whatsapp-image-2020-01-09-at-14-rwJX_cover.jpg"" class=""slide"" width=""900"" height=""600"" />
                        <img src=""https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"" class=""slide"" width=""900"" height=""600"" />
                        <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQnlgInACecJS4ABFpmwN49TqJImiTkjhmMtkDoNn5OVG-mobnZcQxlK88XE2zYGPunLpo&usqp=CAU"" class=""slide"" width=""900"" height=""600"" />
                    </div>
                </div>
        </div>
        <div class=""col-md-1");
            WriteLiteral("\">\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
