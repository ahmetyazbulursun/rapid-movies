#pragma checksum "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Shared\Components\_FooterComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc8190ae3836a2ed2f90ebb34139fc2f9f85911f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__FooterComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_FooterComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc8190ae3836a2ed2f90ebb34139fc2f9f85911f", @"/Views/Shared/Components/_FooterComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__FooterComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer class=""footer"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""footer__content"" style=""display: block;"">
                    <span class=""footer__copyright"" style=""display: block; text-align: center;"">© Rapid Movie, ");
#nullable restore
#line 6 "C:\Users\Ahmet Hakan Eroğlu\Desktop\rapid-movies\Presentation\Views\Shared\Components\_FooterComponent\Default.cshtml"
                                                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(". Developed by <a href=\"https://ahmetyazbulursun.com\" target=\"_blank\">Ahmet Hakan Eroğlu</a>.</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
