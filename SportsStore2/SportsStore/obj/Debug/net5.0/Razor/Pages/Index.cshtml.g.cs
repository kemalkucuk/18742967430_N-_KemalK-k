#pragma checksum "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7644e85b1294adac427e1e4111cd64c35e0fccb1"
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
#line 2 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7644e85b1294adac427e1e4111cd64c35e0fccb1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5cd140a63a3e465973e0b3b840d16d3cffe19c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Index.cshtml"
  
    ViewData["Title"] = "Haberlere Hoş Geldiniz";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- anasayfa sayfası-->
<style>
    * {
        box-sizing: border-box
    }

    body {
        font-family: Verdana, sans-serif;
        margin: 0
    }

    .mySlides {
        display: none
    }

    /* Slideshow container */
    .slideshow-container {
        max-width: 1000px;
        position: relative;
        margin: auto;
    }

    /* Next & previous buttons */
    .prev, .next {
        cursor: pointer;
        position: absolute;
        top: 50%;
        width: auto;
        padding: 16px;
        margin-top: -22px;
        color: white;
        font-weight: bold;
        font-size: 18px;
        transition: 0.6s ease;
        border-radius: 0 3px 3px 0;
    }

    /* Position the ""next button"" to the right */
    .next {
        right: 0;
        border-radius: 3px 0 0 3px;
    }

        /* On hover, add a black background color with a little bit see-through */
        .prev:hover, .next:hover {
            background-color: rgba(0,0,0,0.8);
    ");
            WriteLiteral(@"    }

    /* Caption text */
    .text {
        color: #f2f2f2;
        font-size: 15px;
        padding: 8px 12px;
        position: absolute;
        bottom: 8px;
        width: 100%;
        text-align: center;
    }

    /* Number text (1/3 etc) */
    .numbertext {
        color: #f2f2f2;
        font-size: 12px;
        padding: 8px 12px;
        position: absolute;
        top: 0;
    }

    /* The dots/bullets/indicators */
    .dot {
        cursor: pointer;
        height: 15px;
        width: 15px;
        margin: 0 2px;
        background-color: #bbb;
        border-radius: 50%;
        display: inline-block;
        transition: background-color 0.6s ease;
    }

        .active, .dot:hover {
            background-color: #717171;
        }

    /* Fading animation */

</style>
<div class=""container"">
    <div class=""row"">
        <div class=""col-1""></div>
        <div class=""col-10"">
            <div class=""slideshow-container"">

                <d");
            WriteLiteral(@"iv class=""mySlides "">
                    <div class=""numbertext"">1 / 3</div>
                    <img src=""https://i.nethaber.com/storage/files/images/2021/03/01/whatsapp-image-2020-01-09-at-14-rwJX_cover.jpg"" width=""900"">
                    <div class=""text"">Haber 1</div>
                </div>
                <div class=""mySlides "">
                    <div class=""numbertext"">2 / 3</div>
                    <img src=""https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"" width=""900"">
                    <div class=""text"">Haber 2</div>
                </div>
                <div class=""mySlides "">
                    <div class=""numbertext"">3 / 3</div>
                    <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQnlgInACecJS4ABFpmwN49TqJImiTkjhmMtkDoNn5OVG-mobnZcQxlK88XE2zYGPunLpo&usqp=CAU"" width=""900"">
                    <div class=""text"">Haber 3</div>
                </div>

                <a class=""prev"" onclick=""plusSlides(-1)"">❮</a>
                <a");
            WriteLiteral(@" class=""next"" onclick=""plusSlides(1)"">❯</a>

            </div>
            <br>

            <div style=""text-align:center"">
                <span class=""dot"" onclick=""currentSlide(1)""></span>
                <span class=""dot"" onclick=""currentSlide(2)""></span>
                <span class=""dot"" onclick=""currentSlide(3)""></span>
            </div>
        </div>
        <div class=""col-1""></div>
    </div>
</div>
<script>

    let slideIndex = 0;
    showSlides(slideIndex);

    function plusSlides(n) {
        showSlides(slideIndex += n);
    }

    function currentSlide(n) {
        showSlides(slideIndex = n);
    }

    function showSlides(n) {
        console.log(""ok"")
        let i;
        let slides = document.getElementsByClassName(""mySlides"");
        let dots = document.getElementsByClassName(""dot"");
        if (n > slides.length) { slideIndex = 1 }
        if (n < 1) { slideIndex = slides.length }
        for (i = 0; i < slides.length; i++) {
            slides[i].");
            WriteLiteral(@"style.display = ""none"";
        }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace("" active"", """");
        }
        slides[slideIndex - 1].style.display = ""block"";
        dots[slideIndex - 1].className += "" active"";
    }
</script>

");
#nullable restore
#line 161 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Index.cshtml"
 foreach (var p in Haber.Lines)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 163 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Index.cshtml"
  Write(p.adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 164 "C:\Users\Kemal\Desktop\18742967430_NÖ_KemalKüçük\SportsStore2\SportsStore\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-10\">");
            WriteLiteral("</div>\r\n    <div class=\"col-2\">\r\n        <a href=\"/Admin\" target=\"_blank\"><small>Admin Paneline Git</small></a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Haber> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Haber> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Haber>)PageContext?.ViewData;
        public Haber Model => ViewData.Model;
    }
}
#pragma warning restore 1591