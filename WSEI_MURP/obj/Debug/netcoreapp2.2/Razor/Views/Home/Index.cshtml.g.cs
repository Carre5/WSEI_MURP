#pragma checksum "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d817a7a4b4370730553054afb2d545623394058f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\_ViewImports.cshtml"
using WSEI_MURP;

#line default
#line hidden
#line 2 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\_ViewImports.cshtml"
using WSEI_MURP.Models;

#line default
#line hidden
#line 1 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml"
using WSEI_MURP.Models.DataModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d817a7a4b4370730553054afb2d545623394058f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aba69402d1b4e8c15a0e7eb9f74e5787386070c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WSEI_MURP.Models.Account.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(81, 33, true);
            WriteLiteral("\r\n\r\n    <ul class=\"list-group\">\r\n");
            EndContext();
#line 8 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml"
         foreach (OrderModel order in ViewBag.Orders)
        {

#line default
#line hidden
            BeginContext(180, 237, true);
            WriteLiteral("            <li class=\"list-group-item\">\r\n                <div class=\"media\">\r\n                    <img src=\"...\" class=\"mr-3\" alt=\"...\">\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0 mb-1\">ORDER ");
            EndContext();
            BeginContext(418, 13, false);
#line 14 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml"
                                               Write(order.OrderID);

#line default
#line hidden
            EndContext();
            BeginContext(431, 31, true);
            WriteLiteral("</h5>\r\n                        ");
            EndContext();
            BeginContext(463, 18, false);
#line 15 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml"
                   Write(order.Localization);

#line default
#line hidden
            EndContext();
            BeginContext(481, 52, true);
            WriteLiteral("\r\n                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 533, "\"", 595, 1);
#line 16 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml"
WriteAttributeValue("", 540, Url.Action("Order","Home", new { id = order.OrderID }), 540, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(596, 96, true);
            WriteLiteral(" role=\"button\">Open</a>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
            EndContext();
#line 20 "C:\Users\mpyjos\source\repos\WSEI_MURP\WSEI_MURP\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(703, 9, true);
            WriteLiteral("    </ul>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WSEI_MURP.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
