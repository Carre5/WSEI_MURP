#pragma checksum "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ce681dbe5eac9ecdf6d3fb9b1c31c64ace0a3ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\_ViewImports.cshtml"
using WSEI_MURP;

#line default
#line hidden
#line 2 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\_ViewImports.cshtml"
using WSEI_MURP.Models;

#line default
#line hidden
#line 1 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
using WSEI_MURP.Models.DataModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ce681dbe5eac9ecdf6d3fb9b1c31c64ace0a3ee", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aba69402d1b4e8c15a0e7eb9f74e5787386070c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
  
    ViewData["Title"] = "User Dashboard";

#line default
#line hidden
            BeginContext(124, 91, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">User Dashboard</h1>\r\n    <h4>Hello, ");
            EndContext();
            BeginContext(216, 16, false);
#line 11 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
          Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(232, 97, true);
            WriteLiteral(" !</h4>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n");
            EndContext();
#line 17 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
             if (ViewBag.OrderHistory != null && ViewBag.OrderHistory.Count > 0)
            {

#line default
#line hidden
            BeginContext(426, 41, true);
            WriteLiteral("                <ul class=\"list-group\">\r\n");
            EndContext();
#line 20 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
                     foreach (OrderModel order in ViewBag.OrderHistory)
                    {

#line default
#line hidden
            BeginContext(563, 297, true);
            WriteLiteral(@"                        <li class=""list-group-item"">
                            <div class=""media"">
                                <img src=""..."" class=""mr-3"" alt=""..."">
                                <div class=""media-body"">
                                    <h5 class=""mt-0 mb-1"">ORDER ");
            EndContext();
            BeginContext(861, 13, false);
#line 26 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
                                                           Write(order.OrderID);

#line default
#line hidden
            EndContext();
            BeginContext(874, 43, true);
            WriteLiteral("</h5>\r\n                                    ");
            EndContext();
            BeginContext(918, 12, false);
#line 27 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
                               Write(order.Status);

#line default
#line hidden
            EndContext();
            BeginContext(930, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
                                     if (order.Status == "IN PROGRESS")
                                    {

#line default
#line hidden
            BeginContext(1044, 73, true);
            WriteLiteral("                                        <a class=\"btn btn-ouline-warning\"");
            EndContext();
            BeginWriteAttribute("href", " \r\n                                           href=\"", 1117, "\"", 1243, 1);
#line 31 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
WriteAttributeValue("", 1169, Url.Action("ResolveAndRateOrder","User", new { orderID = order.OrderID }), 1169, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1244, 14, true);
            WriteLiteral(">Resolve</a>\r\n");
            EndContext();
#line 32 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1297, 107, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </li>\r\n");
            EndContext();
#line 36 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1427, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
#line 38 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1465, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 39 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
             if (ViewBag.IsCompany)
            {

#line default
#line hidden
            BeginContext(1517, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1535, "\"", 1572, 1);
#line 41 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
WriteAttributeValue("", 1542, Url.Action("Index","Company"), 1542, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1573, 24, true);
            WriteLiteral(">Company Dashboard</a>\r\n");
            EndContext();
#line 42 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1645, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1663, "\"", 1710, 1);
#line 45 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
WriteAttributeValue("", 1670, Url.Action("RegisterCompany","Company"), 1670, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1711, 23, true);
            WriteLiteral(">Register Company</a>\r\n");
            EndContext();
#line 46 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\User\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1749, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
