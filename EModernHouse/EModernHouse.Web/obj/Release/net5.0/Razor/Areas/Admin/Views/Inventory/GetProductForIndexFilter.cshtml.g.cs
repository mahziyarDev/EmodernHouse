#pragma checksum "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7598c4ee086ca4629a6160824fc363d73702452e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Inventory_GetProductForIndexFilter), @"mvc.1.0.view", @"/Areas/Admin/Views/Inventory/GetProductForIndexFilter.cshtml")]
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
#line 1 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\_ViewImports.cshtml"
using EModernHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
using EModernHouse.Application.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7598c4ee086ca4629a6160824fc363d73702452e", @"/Areas/Admin/Views/Inventory/GetProductForIndexFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae773dd58c9e3f2d5b9fe49aacec7381e98e734", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Inventory_GetProductForIndexFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EModernHouse.DataLayer.DTOs.Product.PopularProductsFilterDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormFilterUSer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inventory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProductPopular", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePopular", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
  
    ViewData["Title"] = "مدیریت محصولات صفحه اصلی سایت";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7598c4ee086ca4629a6160824fc363d73702452e6440", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"pageId\" id=\"PageId\"");
                BeginWriteAttribute("value", " value=\"", 297, "\"", 320, 1);
#nullable restore
#line 9 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
WriteAttributeValue("", 305, ViewBag.PageId, 305, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12\">\r\n        <div class=\"alert alert-info\">\r\n            <p class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7598c4ee086ca4629a6160824fc363d73702452e8401", async() => {
                WriteLiteral("افزودن");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"well with-header with-footer\">\r\n            <div class=\"header bordered-sky\">\r\n                ");
#nullable restore
#line 22 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 24 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
             if (Model.ProductForShowIndices != null && Model.ProductForShowIndices.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>
                                تصویر محصول
                            </th>
                            <th>
                                نام محصول
                            </th>
                            <th>
                                قیمت محصول
                            </th>
                            <th>
                                قسمت نمایشی
                            </th>
                            <th>
                                دستورات
                            </th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 48 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                         foreach (var popularProducts in Model.ProductForShowIndices)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td class=\"text-center\">\r\n                                    <img style=\"width: 80px; height: 80px\"");
            BeginWriteAttribute("src", " src=\"", 1964, "\"", 2041, 1);
#nullable restore
#line 54 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
WriteAttributeValue("", 1970, PathExtensions.ProductImageThumb + popularProducts.Product.ImageName, 1970, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 57 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                               Write(popularProducts.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 60 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                               Write(popularProducts.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 63 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                               Write(popularProducts.Priority.GetEnumName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7598c4ee086ca4629a6160824fc363d73702452e13968", async() => {
                WriteLiteral("\r\n                                        حذف\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                                                                                                                WriteLiteral(popularProducts.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 73 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 77 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    <p>اطلاعاتی یافت نشد</p>\r\n                </div>\r\n");
#nullable restore
#line 83 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <div class=\"dataTables_paginate paging_bootstrap text-center\" id=\"simpledatatable_paginate\">\r\n                <ul class=\"pagination\">\r\n");
#nullable restore
#line 87 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                     if (Model.PageId > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"prev\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 3494, "\"", 3533, 3);
            WriteAttributeValue("", 3504, "SendPage(", 3504, 9, true);
#nullable restore
#line 89 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
WriteAttributeValue("", 3513, Model.PageId - 1, 3513, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3532, ")", 3532, 1, true);
            EndWriteAttribute();
            WriteLiteral(">قبل</a></li>\r\n");
#nullable restore
#line 90 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                     for (int spage = Model.StartPage; spage <= Model.EndPage; spage++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3711, "\"", 3761, 1);
#nullable restore
#line 93 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
WriteAttributeValue("", 3719, (spage == Model.PageId) ? "active" : "", 3719, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3774, "\"", 3800, 3);
            WriteAttributeValue("", 3784, "SendPage(", 3784, 9, true);
#nullable restore
#line 93 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
WriteAttributeValue("", 3793, spage, 3793, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3799, ")", 3799, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                                                                                                                 Write(spage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 94 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 97 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                     if (Model.PageId < Model.PageCount)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"next\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 3970, "\"", 4009, 3);
            WriteAttributeValue("", 3980, "SendPage(", 3980, 9, true);
#nullable restore
#line 99 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
WriteAttributeValue("", 3989, Model.PageId + 1, 3989, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4008, ")", 4008, 1, true);
            EndWriteAttribute();
            WriteLiteral(">بعد</a></li>\r\n");
#nullable restore
#line 100 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\GetProductForIndexFilter.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EModernHouse.DataLayer.DTOs.Product.PopularProductsFilterDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
