#pragma checksum "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f53dca792dac53966619ad7145cfe0c87bb4b1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Cars), @"mvc.1.0.view", @"/Views/Company/Cars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Cars.cshtml", typeof(AspNetCore.Views_Company_Cars))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f53dca792dac53966619ad7145cfe0c87bb4b1f", @"/Views/Company/Cars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aba69402d1b4e8c15a0e7eb9f74e5787386070c", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Cars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WSEI_MURP.Models.Account.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
  
    ViewData["Title"] = "Cars";

#line default
#line hidden
            BeginContext(40, 19, true);
            WriteLiteral("\r\n<h1>Cars</h1>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
 if (ViewBag.Cars.Length == 0)
{

#line default
#line hidden
            BeginContext(94, 118, true);
            WriteLiteral("    <div class=\"alert alert-light\" role=\"alert\">\r\n        There is no cars associated with your company.\r\n    </div>\r\n");
            EndContext();
#line 12 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(224, 23, true);
            WriteLiteral("    <div class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
         foreach (var car in ViewBag.Cars)
        {

#line default
#line hidden
            BeginContext(302, 164, true);
            WriteLiteral("            <div class=\"col-sm-6\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(467, 9, false);
#line 21 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
                                          Write(car.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(476, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(478, 9, false);
#line 21 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
                                                     Write(car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(487, 58, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">Load: ");
            EndContext();
            BeginContext(546, 8, false);
#line 22 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
                                              Write(car.Load);

#line default
#line hidden
            EndContext();
            BeginContext(554, 12, true);
            WriteLiteral(", Category: ");
            EndContext();
            BeginContext(567, 12, false);
#line 22 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
                                                                   Write(car.Category);

#line default
#line hidden
            EndContext();
            BeginContext(579, 61, true);
            WriteLiteral(", </p>\r\n                        <p class=\"card-text\">Status: ");
            EndContext();
            BeginContext(641, 10, false);
#line 23 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
                                                Write(car.Status);

#line default
#line hidden
            EndContext();
            BeginContext(651, 78, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 27 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
        }

#line default
#line hidden
            BeginContext(740, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 29 "C:\Users\Konrad\Desktop\WSEI_MURP\WSEI_MURP\Views\Company\Cars.cshtml"
}

#line default
#line hidden
            BeginContext(755, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(757, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f53dca792dac53966619ad7145cfe0c87bb4b1f8135", async() => {
                BeginContext(844, 7, true);
                WriteLiteral("Add Car");
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
