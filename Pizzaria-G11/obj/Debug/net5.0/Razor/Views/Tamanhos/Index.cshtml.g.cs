#pragma checksum "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\Tamanhos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a009677385c08ab1a8102be2e770e60acb67bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tamanhos_Index), @"mvc.1.0.view", @"/Views/Tamanhos/Index.cshtml")]
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
#line 1 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\_ViewImports.cshtml"
using PizzariAtv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\_ViewImports.cshtml"
using PizzariAtv.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a009677385c08ab1a8102be2e770e60acb67bb9", @"/Views/Tamanhos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d319472cbff997eb978735568c5317924518b9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Tamanhos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tamanho>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\Tamanhos\Index.cshtml"
   ViewData["Title"] = "Detalhes"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\Tamanhos\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-bg-info mb-3\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-header\">");
#nullable restore
#line 10 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\Tamanhos\Index.cshtml"
                                Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\Tamanhos\Index.cshtml"
                                  Write(item.Pedacos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\Tamanhos\Index.cshtml"
                                Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\guilherme.srocha11\Desktop\Pizzaria-G11\Pizzaria-G11\Views\Tamanhos\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tamanho>> Html { get; private set; }
    }
}
#pragma warning restore 1591
