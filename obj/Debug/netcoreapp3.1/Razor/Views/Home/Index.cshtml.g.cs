#pragma checksum "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4a7475356435a98b3b469f0ba66a4280e1b4ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/_ViewImports.cshtml"
using SquareRootComparer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/_ViewImports.cshtml"
using SquareRootComparer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4a7475356435a98b3b469f0ba66a4280e1b4ab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c39ebf9a6b6da30fff315d72674ce118ecd8c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Square Root Comparer Web App";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Compare Me!</h1>\r\n</div>\r\n<div class =\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4a7475356435a98b3b469f0ba66a4280e1b4ab4382", async() => {
                WriteLiteral("\r\n        <input type=\"number\" placeholder=\"First Number\" name=\"firstNumber\">\r\n        <input type=\"number\" placeholder=\"Second Number\" name=\"secondNumber\">\r\n        <button type=\"submit\">COMPARE</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 16 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
  
    if(ViewBag.FirstNumber != null && ViewBag.SecondNumber != null)
    {
        if(ViewBag.FirstNumber > 0 && ViewBag.SecondNumber > 0){
            double firstSqRt = Math.Sqrt(ViewBag.FirstNumber);
            double secondSqRt = Math.Sqrt(ViewBag.SecondNumber);
            if(firstSqRt == secondSqRt)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center\">\r\n                    <p>The Square Root are equal. ENTER ANOTHER VALUE!</p>\r\n                </div>\r\n");
#nullable restore
#line 27 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
            }
            else
            {
                int greaterNumber = 0;
                int lesserNumber = 0;
                double greaterSqRt = 0.0;
                double lesserSqRt = 0.0;
                if(ViewBag.FirstNumber > ViewBag.SecondNumber)
                {
                    greaterNumber = ViewBag.FirstNumber;
                    lesserNumber = ViewBag.SecondNumber;
                    greaterSqRt = firstSqRt;
                    lesserSqRt = secondSqRt;
                }
                else
                {
                    greaterNumber = ViewBag.SecondNumber;
                    lesserNumber = ViewBag.FirstNumber;
                    greaterSqRt = secondSqRt;
                    lesserSqRt = firstSqRt;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center\">\r\n                    <p>The number ");
#nullable restore
#line 49 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
                             Write(greaterNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with Square root ");
#nullable restore
#line 49 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
                                                             Write(greaterSqRt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 49 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
                                                                                                                   Write(lesserNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with square root ");
#nullable restore
#line 49 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
                                                                                                                                                  Write(lesserSqRt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 51 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\">\r\n                <p>Error! Invalid Input. Try with better input(*~*)!</p>\r\n            </div>\r\n");
#nullable restore
#line 58 "/Users/mymac/start.ng/backend/SquareRootComparer/Views/Home/Index.cshtml"
        }
    }
    

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
