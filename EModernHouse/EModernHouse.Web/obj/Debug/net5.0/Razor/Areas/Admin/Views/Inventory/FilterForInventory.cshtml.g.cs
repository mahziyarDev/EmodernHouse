#pragma checksum "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ba5c064e54cbce9a1cd0b2d08bb14bbe59f12b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Inventory_FilterForInventory), @"mvc.1.0.view", @"/Areas/Admin/Views/Inventory/FilterForInventory.cshtml")]
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
#line 1 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ba5c064e54cbce9a1cd0b2d08bb14bbe59f12b8", @"/Areas/Admin/Views/Inventory/FilterForInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae773dd58c9e3f2d5b9fe49aacec7381e98e734", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Inventory_FilterForInventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EModernHouse.DataLayer.DTOs.Filter.InventoryFilterDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormFilterUSer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inventory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowProductById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
  
    ViewData["Title"] = "FilterForInventory";

#line default
#line hidden
#nullable disable
            DefineSection("script", async() => {
                WriteLiteral("\r\n    <script src=\"/Admin/js/custom.js\"></script>\r\n");
            }
            );
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12\">\r\n        <div class=\"well with-header\">\r\n            <div class=\"header bordered-sky\">\r\n                جست و جو کردن\r\n            </div>\r\n            <div class=\"row\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba5c064e54cbce9a1cd0b2d08bb14bbe59f12b85918", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"pageId\" id=\"PageId\"");
                BeginWriteAttribute("value", " value=\"", 566, "\"", 589, 1);
#nullable restore
#line 19 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
WriteAttributeValue("", 574, ViewBag.PageId, 574, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"col-md-12 col-sm-12\">\r\n                        <label>نام محصول</label>\r\n                        <input type=\"text\" name=\"productName\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 782, "\"", 810, 1);
#nullable restore
#line 22 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
WriteAttributeValue("", 790, ViewBag.ProducrName, 790, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>

                    <div class=""col-md-12 col-sm-12"">
                        <br />
                        <button onclick=""SendPage(ViewBag.pageId)"" class=""btn btn-primary mt-4"">جست و جو</button>
                    </div>

                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-md-12 col-sm-12\">\r\n        <div class=\"well with-header with-footer\">\r\n            <div class=\"header bordered-sky\">\r\n                ");
#nullable restore
#line 38 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 40 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
             if (Model.Products != null && Model.Products.Any())
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
                            موجودی در انبار
                        </th>
                    </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 61 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                     foreach (var product in Model.Products)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                               \r\n                            <td class=\"text-center\">\r\n                                <img style=\"width: 80px;height: 80px\"");
            BeginWriteAttribute("src", " src=\"", 2319, "\"", 2381, 1);
#nullable restore
#line 67 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
WriteAttributeValue("", 2325, PathExtensions.ProductImageThumb + product.ImageName , 2325, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                           Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 73 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba5c064e54cbce9a1cd0b2d08bb14bbe59f12b811847", async() => {
                WriteLiteral("نمایش");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                                                                                                                  WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 82 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 86 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    <p>اطلاعاتی یافت نشد</p>\r\n                </div>\r\n");
#nullable restore
#line 92 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <div class=\"dataTables_paginate paging_bootstrap text-center\" id=\"simpledatatable_paginate\">\r\n                <ul class=\"pagination\">\r\n");
#nullable restore
#line 96 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                     if (Model.PageId > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"prev\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 3553, "\"", 3592, 3);
            WriteAttributeValue("", 3563, "sendPage(", 3563, 9, true);
#nullable restore
#line 98 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
WriteAttributeValue("", 3572, Model.PageId - 1, 3572, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3591, ")", 3591, 1, true);
            EndWriteAttribute();
            WriteLiteral(">قبل</a></li>\r\n");
#nullable restore
#line 99 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                     for (int spage = Model.StartPage; spage <= Model.EndPage; spage++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3770, "\"", 3816, 1);
#nullable restore
#line 102 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
WriteAttributeValue("", 3778, (spage == Model.PageId)?"active":"", 3778, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3829, "\"", 3855, 3);
            WriteAttributeValue("", 3839, "sendPage(", 3839, 9, true);
#nullable restore
#line 102 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
WriteAttributeValue("", 3848, spage, 3848, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3854, ")", 3854, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 102 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                                                                                                             Write(ViewBag.pageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 103 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 106 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                     if (Model.PageId < Model.PageCount)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"next\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 4034, "\"", 4073, 3);
            WriteAttributeValue("", 4044, "sendPage(", 4044, 9, true);
#nullable restore
#line 108 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
WriteAttributeValue("", 4053, Model.PageId + 1, 4053, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4072, ")", 4072, 1, true);
            EndWriteAttribute();
            WriteLiteral(">بعد</a></li>\r\n");
#nullable restore
#line 109 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\Inventory\FilterForInventory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EModernHouse.DataLayer.DTOs.Filter.InventoryFilterDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
