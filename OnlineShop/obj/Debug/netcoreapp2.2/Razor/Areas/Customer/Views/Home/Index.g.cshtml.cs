#pragma checksum "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1776e969f153561f34ae2c7cb39663a9af07e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Index))]
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
#line 1 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 2 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#line 3 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 1 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1776e969f153561f34ae2c7cb39663a9af07e26", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a7abc8cec0f3c900f1d6218624481cd1cfb43f0", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("card image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success fa-pull-right btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/AlertifyJS/alertify.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(117, 34, true);
            WriteLiteral("<br /><br />\r\n<div class=\"row \">\r\n");
            EndContext();
#line 8 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(195, 309, true);
            WriteLiteral(@"        <div class=""col-lg-4 col-sm-12 col-md-6 col-xl-4"">
            <div class=""card mb-3 offset-1"">
                <div class=""card-header "">
                    <h4 class=""my-0 font-weight-normal"">
                        <label style=""font-size:23px; color:steelblue"">
                            ");
            EndContext();
            BeginContext(505, 12, false);
#line 15 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
                       Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(517, 103, true);
            WriteLiteral("\r\n                        </label>\r\n                    </h4>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(620, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1776e969f153561f34ae2c7cb39663a9af07e267540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 630, "~/", 630, 2, true);
#line 19 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 632, product.Image, 632, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(719, 262, true);
            WriteLiteral(@"
                <div class=""card-header"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <label style=""font-size:20px;color:#a51313""><b>Price : ");
            EndContext();
            BeginContext(982, 13, false);
#line 23 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
                                                                              Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(995, 70, true);
            WriteLiteral("</b></label>\r\n                        </div>\r\n                        ");
            EndContext();
            BeginContext(1065, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1776e969f153561f34ae2c7cb39663a9af07e2610127", async() => {
                BeginContext(1193, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
                                                                        WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1204, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 30 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1301, 53, true);
            WriteLiteral("</div>\r\n<div>\r\n    <strong style=\"font-size:large\">  ");
            EndContext();
            BeginContext(1355, 116, false);
#line 33 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
                                 Write(Html.PagedListPager(Model, c => Href("~/Customer/Home/Index?page=" + c), PagedListRenderOptionsBase.PageNumbersOnly));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 22, true);
            WriteLiteral(" </strong>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1510, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1516, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1776e969f153561f34ae2c7cb39663a9af07e2613873", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1572, 82, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    $(function ()\r\n    {\r\n    var save =\'");
                EndContext();
                BeginContext(1655, 16, false);
#line 42 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
          Write(TempData["Save"]);

#line default
#line hidden
                EndContext();
                BeginContext(1671, 124, true);
                WriteLiteral("\'\r\n    if(save !=\'\')\r\n    {\r\n        alertify.success(save);\r\n    }\r\n    })\r\n      $(function ()\r\n    {\r\n        var save =\'");
                EndContext();
                BeginContext(1796, 18, false);
#line 50 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
              Write(TempData["Update"]);

#line default
#line hidden
                EndContext();
                BeginContext(1814, 130, true);
                WriteLiteral("\'\r\n    if(save !=\'\')\r\n    {\r\n        alertify.message(save);    }\r\n        })\r\n\r\n        $(function ()\r\n    {\r\n        var save =\'");
                EndContext();
                BeginContext(1945, 18, false);
#line 58 "C:\Users\AshrafKotb\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\Home\Index.cshtml"
              Write(TempData["Delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(1963, 100, true);
                WriteLiteral("\'\r\n    if(save !=\'\')\r\n    {\r\n        alertify.error(save);\r\n    }\r\n        })\r\n\r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
