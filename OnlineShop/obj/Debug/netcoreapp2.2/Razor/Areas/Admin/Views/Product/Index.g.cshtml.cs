#pragma checksum "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b690a3191deb857ef1dec874a273720bc8e0a6cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 2 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#line 3 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop.Areas.Admin.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b690a3191deb857ef1dec874a273720bc8e0a6cc", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5057507d223f4c1fb82fb2a1698d5d9f4d612376", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/AlertifyJS/alertify.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(72, 181, true);
            WriteLiteral("<br />\r\n<div class=\"row\">\r\n    <div class=\"col-lg-6 col-sm-6\"> \r\n       <h3><strong> Product List</strong></h3>\r\n    </div>\r\n    <div class=\"col-lg-6 col-sm-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(253, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b690a3191deb857ef1dec874a273720bc8e0a6cc6163", async() => {
                BeginContext(297, 21, true);
                WriteLiteral("&nbsp;Add New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(322, 30, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n");
            EndContext();
            BeginContext(352, 696, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b690a3191deb857ef1dec874a273720bc8e0a6cc7667", async() => {
                BeginContext(372, 669, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-4 col-sm-3"">
            <input type=""number""  placeholder=""Minimum Price"" name=""lowAmount"" class=""form-control"" />
        </div>
        <div class=""col-4 col-sm-3"">
            <input type=""number"" name=""largeAmount"" placeholder="" Maximum Price"" class=""form-control"" />
        </div>
        <div class=""col-3 "">
            <div>
                <button type=""submit"" class=""btn btn-success"">
                    <i class=""fa fa-search text-capitalize "" style=""border-radius:10px""></i> Search
                </button>

            </div>
        </div>
        <div class=""col-3""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1048, 226, true);
            WriteLiteral("\r\n<br />\r\n<div>\r\n    <table id=\"example\" class=\"table table-striped border table-responsive-sm\" style=\"width:100% \">\r\n        <thead  class=\"table-light text-dark\">\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1275, 44, false);
#line 41 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1387, 45, false);
#line 44 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1500, 52, false);
#line 47 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.ProductColor));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1620, 51, false);
#line 50 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1739, 53, false);
#line 53 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.ProductTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1860, 52, false);
#line 56 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(expression: c => c.SpecialTagID));

#line default
#line hidden
            EndContext();
            BeginContext(1912, 109, true);
            WriteLiteral("\r\n                </th>\r\n                <td></td>\r\n            </tr>\r\n\r\n        </thead>\r\n        <tbody >\r\n");
            EndContext();
#line 63 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2078, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2125, 9, false);
#line 66 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2134, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2166, 10, false);
#line 67 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2176, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2208, 17, false);
#line 68 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(2225, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2257, 16, false);
#line 69 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.IsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(2273, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2305, 29, false);
#line 70 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductTypes.ProductType);

#line default
#line hidden
            EndContext();
            BeginContext(2334, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2366, 20, false);
#line 71 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.SpecialTag.name);

#line default
#line hidden
            EndContext();
            BeginContext(2386, 27, true);
            WriteLiteral("</td>\r\n                    ");
            EndContext();
            BeginContext(2413, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b690a3191deb857ef1dec874a273720bc8e0a6cc15717", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 72 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2463, 25, true);
            WriteLiteral("\r\n                </tr>\r\n");
            EndContext();
#line 74 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2503, 47, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n   \r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2567, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2573, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b690a3191deb857ef1dec874a273720bc8e0a6cc17918", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2629, 373, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(document).ready(function () {
            $('#example').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        });</script>
    <script type=""text/javascript"">

    $(function ()
    {
    var save ='");
                EndContext();
                BeginContext(3003, 16, false);
#line 95 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
          Write(TempData["Save"]);

#line default
#line hidden
                EndContext();
                BeginContext(3019, 124, true);
                WriteLiteral("\'\r\n    if(save !=\'\')\r\n    {\r\n        alertify.success(save);\r\n    }\r\n    })\r\n      $(function ()\r\n    {\r\n        var save =\'");
                EndContext();
                BeginContext(3144, 18, false);
#line 103 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
              Write(TempData["Update"]);

#line default
#line hidden
                EndContext();
                BeginContext(3162, 130, true);
                WriteLiteral("\'\r\n    if(save !=\'\')\r\n    {\r\n        alertify.message(save);    }\r\n        })\r\n\r\n        $(function ()\r\n    {\r\n        var save =\'");
                EndContext();
                BeginContext(3293, 18, false);
#line 111 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
              Write(TempData["Delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(3311, 105, true);
                WriteLiteral("\'\r\n    if(save !=\'\')\r\n    {\r\n        alertify.error(save);\r\n    }\r\n        })\r\n       \r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
