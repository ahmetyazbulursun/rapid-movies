#pragma checksum "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0017a620ed9f2a808ab82303f17b14bc7238ae2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genre_Index), @"mvc.1.0.view", @"/Views/Genre/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0017a620ed9f2a808ab82303f17b14bc7238ae2f", @"/Views/Genre/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Genre_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Presentation.Models.Concrete.Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
  
    ViewData["Title"] = "Genre";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"catalog\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h1 style=\"display:inline-block; justify-content: center; color: #fff; text-align: center; border-bottom: 1px solid #fff;\">");
#nullable restore
#line 12 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
                                                                                                                                      Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Movies</h1>\r\n                <div class=\"row row--grid\">\r\n");
#nullable restore
#line 14 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-6 col-sm-4 col-lg-3 col-xl-2\">\r\n                            <div class=\"card\">\r\n                                <a href=\"details.html\" class=\"card__cover\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 787, "\"", 804, 1);
#nullable restore
#line 19 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
WriteAttributeValue("", 793, item.image, 793, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" alt=""cover image"">
                                    <svg width=""22"" height=""22"" viewBox=""0 0 22 22"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M11 1C16.5228 1 21 5.47716 21 11C21 16.5228 16.5228 21 11 21C5.47716 21 1 16.5228 1 11C1 5.47716 5.47716 1 11 1Z"" stroke-linecap=""round"" stroke-linejoin=""round"" /><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M14.0501 11.4669C13.3211 12.2529 11.3371 13.5829 10.3221 14.0099C10.1601 14.0779 9.74711 14.2219 9.65811 14.2239C9.46911 14.2299 9.28711 14.1239 9.19911 13.9539C9.16511 13.8879 9.06511 13.4569 9.03311 13.2649C8.93811 12.6809 8.88911 11.7739 8.89011 10.8619C8.88911 9.90489 8.94211 8.95489 9.04811 8.37689C9.07611 8.22089 9.15811 7.86189 9.18211 7.80389C9.22711 7.69589 9.30911 7.61089 9.40811 7.55789C9.48411 7.51689 9.57111 7.49489 9.65811 7.49789C9.74711 7.49989 10.1091 7.62689 10.2331 7.67589C11.2111 8.05589 13.2801 9.43389 14.0401 10.2439C14.1081 10.3169 14.2951 10.5129 14.3261 10.5529C");
            WriteLiteral(@"14.3971 10.6429 14.4321 10.7519 14.4321 10.8619C14.4321 10.9639 14.4011 11.0679 14.3371 11.1549C14.3041 11.1999 14.1131 11.3999 14.0501 11.4669Z"" stroke-linecap=""round"" stroke-linejoin=""round"" /></svg>
                                </a>
                                <span class=""card__rating""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M22,9.67A1,1,0,0,0,21.14,9l-5.69-.83L12.9,3a1,1,0,0,0-1.8,0L8.55,8.16,2.86,9a1,1,0,0,0-.81.68,1,1,0,0,0,.25,1l4.13,4-1,5.68A1,1,0,0,0,6.9,21.44L12,18.77l5.1,2.67a.93.93,0,0,0,.46.12,1,1,0,0,0,.59-.19,1,1,0,0,0,.4-1l-1-5.68,4.13-4A1,1,0,0,0,22,9.67Zm-6.15,4a1,1,0,0,0-.29.88l.72,4.2-3.76-2a1.06,1.06,0,0,0-.94,0l-3.76,2,.72-4.2a1,1,0,0,0-.29-.88l-3-3,4.21-.61a1,1,0,0,0,.76-.55L12,5.7l1.88,3.82a1,1,0,0,0,.76.55l4.21.61Z"" /></svg> ");
#nullable restore
#line 22 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(item.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                <h3 class=\"card__title\"><a href=\"details.html\">");
#nullable restore
#line 23 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
                                                                          Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <ul class=\"card__list\">\r\n                                    <li>");
#nullable restore
#line 25 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
                                   Write(item.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 29 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Genre\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Presentation.Models.Concrete.Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
