#pragma checksum "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f37d2ab693bed58f725047344e738c07c2f8d051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Index.cshtml", typeof(AspNetCore.Views_Company_Index))]
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
#line 1 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
using WSEI_MURP.Models.DataModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f37d2ab693bed58f725047344e738c07c2f8d051", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aba69402d1b4e8c15a0e7eb9f74e5787386070c", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WSEI_MURP.Models.Account.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
  
    ViewData["Title"] = "Company Dashboard";

#line default
#line hidden
            BeginContext(89, 94, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Company Dashboard</h1>\r\n    <h4>Hello, ");
            EndContext();
            BeginContext(184, 20, false);
#line 8 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
          Write(ViewBag.Company_Name);

#line default
#line hidden
            EndContext();
            BeginContext(204, 44, true);
            WriteLiteral(" !</h4>\r\n</div>\r\n\r\n<div class=\"container\">\r\n");
            EndContext();
#line 12 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
     if (ViewBag.Company_Feadback_Total_Score > 0 && ViewBag.Company_Feedback_Amount > 0)
    {

#line default
#line hidden
            BeginContext(346, 97, true);
            WriteLiteral("        <div class=\"row\">\r\n            <h3>Statistics</h3>\r\n            <p>Feedback Total Score: ");
            EndContext();
            BeginContext(444, 36, false);
#line 16 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                                Write(ViewBag.Company_Feadback_Total_Score);

#line default
#line hidden
            EndContext();
            BeginContext(480, 38, true);
            WriteLiteral("</p>\r\n            <p>Feedback Amount: ");
            EndContext();
            BeginContext(519, 31, false);
#line 17 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                           Write(ViewBag.Company_Feedback_Amount);

#line default
#line hidden
            EndContext();
            BeginContext(550, 37, true);
            WriteLiteral("</p>\r\n            <p>Average Rating: ");
            EndContext();
            BeginContext(588, 32, false);
#line 18 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                          Write(ViewBag.Company_Feedback_Average);

#line default
#line hidden
            EndContext();
            BeginContext(620, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 20 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(649, 106, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            <div class=\"list-group\">\r\n                ");
            EndContext();
            BeginContext(755, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f37d2ab693bed58f725047344e738c07c2f8d0517484", async() => {
                BeginContext(920, 5, true);
                WriteLiteral(" Cars");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(929, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(947, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f37d2ab693bed58f725047344e738c07c2f8d0519359", async() => {
                BeginContext(1113, 7, true);
                WriteLiteral(" Orders");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1124, 67, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-9\">\r\n");
            EndContext();
#line 35 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
             if (ViewBag.Orders != null && ViewBag.Orders.Length > 0)
            {

#line default
#line hidden
            BeginContext(1277, 41, true);
            WriteLiteral("                <ul class=\"list-group\">\r\n");
            EndContext();
#line 38 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                     foreach (OrderModel order in ViewBag.Orders)
                    {

#line default
#line hidden
            BeginContext(1408, 297, true);
            WriteLiteral(@"                        <li class=""list-group-item"">
                            <div class=""media"">
                                <img src=""..."" class=""mr-3"" alt=""..."">
                                <div class=""media-body"">
                                    <h5 class=""mt-0 mb-1"">ORDER ");
            EndContext();
            BeginContext(1706, 13, false);
#line 44 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                                                           Write(order.OrderID);

#line default
#line hidden
            EndContext();
            BeginContext(1719, 43, true);
            WriteLiteral("</h5>\r\n                                    ");
            EndContext();
            BeginContext(1763, 12, false);
#line 45 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                               Write(order.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1775, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                                     if (order.Status == "IN PROGRESS")
                                    {

#line default
#line hidden
            BeginContext(1889, 73, true);
            WriteLiteral("                                        <a class=\"btn btn-ouline-warning\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                                           href=\"", 1962, "\"", 2087, 1);
#line 49 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
WriteAttributeValue("", 2013, Url.Action("ResolveAndRateOrder","User", new { orderID = order.OrderID }), 2013, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2088, 14, true);
            WriteLiteral(">Resolve</a>\r\n");
            EndContext();
#line 50 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2141, 107, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </li>\r\n");
            EndContext();
#line 54 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2271, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
#line 56 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2309, 36, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WSEI_MURP.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
