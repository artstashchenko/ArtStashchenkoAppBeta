#pragma checksum "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851d728c57010ba3bcef62addb8ec040ee5257d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Counters_Index), @"mvc.1.0.view", @"/Views/Counters/Index.cshtml")]
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
#line 1 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\_ViewImports.cshtml"
using Artstashchenko.PaymentsAppBeta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\_ViewImports.cshtml"
using Artstashchenko.PaymentsAppBeta.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851d728c57010ba3bcef62addb8ec040ee5257d4", @"/Views/Counters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fc20c877e7e1b98d8f3c85f1f14ae3337b97ffa", @"/Views/_ViewImports.cshtml")]
    public class Views_Counters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Artstashchenko.PaymentsAppBeta.Models.Counters>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
  
    ViewData["Title"] = "Counters";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Table with counters for - 20-richya Peremogy 55 app 222</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d728c57010ba3bcef62addb8ec040ee5257d43867", async() => {
                WriteLiteral("Add a new count");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 19 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Water));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Electricity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OSMD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JEK));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Trash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Internet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 52 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Water));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Electricity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OSMD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JEK));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Trash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Internet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { Id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 77 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { Id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 78 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { Id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "D:\solutions\learn\ArtStashchenkoAppBeta\Artstashchenko.PaymentsAppBeta\Views\Counters\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Artstashchenko.PaymentsAppBeta.Models.Counters>> Html { get; private set; }
    }
}
#pragma warning restore 1591
