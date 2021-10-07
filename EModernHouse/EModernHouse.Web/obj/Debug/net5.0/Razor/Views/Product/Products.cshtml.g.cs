#pragma checksum "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ab45af379e686732abcf4c94a4e265f81fdbb13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Products), @"mvc.1.0.view", @"/Views/Product/Products.cshtml")]
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
#line 1 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\_ViewImports.cshtml"
using EModernHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\_ViewImports.cshtml"
using EModernHouse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
using EModernHouse.DataLayer.Entities.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ab45af379e686732abcf4c94a4e265f81fdbb13", @"/Views/Product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EModernHouse.DataLayer.DTOs.Filter.ProductUserFilterDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("filter-price"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
  
    ViewData["Title"] = "ارشیو محصولات";
    var category = ViewBag.category as List<ProductCategory>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!---Main content--->
<main class=""page-content"" style=""margin-top: 235.5px; transform: none;"">
    <div class=""container"" style=""transform: none;"">
        <div class=""row mb-5"" style=""transform: none;"">
            <div class=""col-lg-9 col-md-8"">
                <div class=""d-md-none"">
                    <button class=""btn-filter-sidebar"">
                        جستجوی پیشرفته <i class=""fad fa-sliders-h""></i>
                    </button>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        <!-- breadcrumb -->
                        <div class=""breadcrumb mb-2 pt-2"">
                            <nav>
                                <a href=""#"">فروشگاه اینترنتی</a>
                                <a href=""#"">کتاب، لوازم تحریر و هنر</a>
                                <a href=""#"">لوازم تحریر</a>
                            </nav>
                        </div>
                        <!-- end breadcrumb -->
    ");
            WriteLiteral("                </div>\r\n                </div>\r\n                <div class=\"listing-items row\">\r\n");
#nullable restore
#line 37 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                     if (Model.Products.Any() && Model.Products != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-3 col-md-4 col-sm-6 px-0"">
                                <div class=""product-card"">
                                    <div class=""product-card-top"">
                                        <a href=""#"" class=""product-image"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 1905, "\"", 1964, 1);
#nullable restore
#line 45 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 1911, PathExtensions.ProductImageThumb+product.ImageName, 1911, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1965, "\"", 1985, 1);
#nullable restore
#line 45 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 1971, product.Title, 1971, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        </a>
                                        <div class=""product-card-actions"">
                                            <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                        </div>
                                    </div>
                                    <div class=""product-card-middle"">
                                        <div class=""ratings-container"">

                                        </div>
                                        <h6 class=""product-name text-center"">
                                            <a href=""#"">
                                                ");
#nullable restore
#line 57 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                           Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </h6>\r\n                                        <div class=\"product-price product-price-clone\">");
#nullable restore
#line 60 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                                                                  Write(product.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                    <div class=\"product-card-bottom\">\r\n                                        <div class=\"product-price\">\r\n                                            ");
#nullable restore
#line 64 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                       Write(product.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                        <a href=""#"" class=""btn-add-to-cart col-12"">
                                            <i class=""fad fa-cart-plus""></i>
                                            افزودن به سبد خرید
                                        </a>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 73 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-warning col-12\">\r\n                            <p>هیچ چیزی برا نمایش وجود ندارد</p>\r\n                        </div>\r\n");
#nullable restore
#line 80 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"col-12 px-0\">\r\n                        <div class=\"pagination\">\r\n");
#nullable restore
#line 85 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                             if (Model.PageId > 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#\" class=\"prev\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4162, "\"", 4201, 3);
            WriteAttributeValue("", 4172, "sendPage(", 4172, 9, true);
#nullable restore
#line 87 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 4181, Model.PageId - 1, 4181, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4200, ")", 4200, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-arrow-from-left\"></i></a>\r\n");
#nullable restore
#line 88 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                             for (int spage = Model.StartPage; spage <= Model.EndPage; spage++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 4451, "\"", 4498, 1);
#nullable restore
#line 92 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 4459, (spage == Model.PageId)?"current":"", 4459, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4499, "\"", 4525, 3);
            WriteAttributeValue("", 4509, "sendPage(", 4509, 9, true);
#nullable restore
#line 92 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 4518, spage, 4518, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4524, ")", 4524, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                                                                                                  Write(spage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 93 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 95 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                             if (Model.PageId < Model.PageCount)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#\" class=\"next\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4725, "\"", 4764, 3);
            WriteAttributeValue("", 4735, "sendPage(", 4735, 9, true);
#nullable restore
#line 97 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 4744, Model.PageId + 1, 4744, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4763, ")", 4763, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-arrow-to-left\"></i></a>\r\n");
#nullable restore
#line 98 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 sticky-sidebar filter-options-sidebar"" style=""position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;"">


                <div class=""theiaStickySidebar"" style=""padding-top: 0px; padding-bottom: 1px; position: static; transform: none;"">
                    <div class=""d-md-none"">
                        <div class=""header-filter-options"">
                            <span>جستجوی پیشرفته <i class=""fad fa-sliders-h""></i></span>
                            <button class=""btn-close-filter-sidebar""><i class=""fal fa-times""></i></button>
                        </div>
                    </div>
                    <div class=""sidebar-widget"">
");
#nullable restore
#line 115 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                         if (category.Any() && category != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""widget widget-filter-options shadow-around"">
                                <div class=""widget-title"">دسته بندی</div>
                                <div class=""search-in-options form-element-row"">
                                    <div class=""form-element-with-icon"">
                                        <input type=""text"" class=""input-element"" placeholder=""جستجوی نام دسته بندی..."">
                                        <i class=""fad fa-file-search""></i>
                                    </div>
                                </div>
                                <div class=""widget-content"">
                                    <label class=""container-checkbox"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab45af379e686732abcf4c94a4e265f81fdbb1319284", async() => {
                WriteLiteral("همه دسته بندی ها");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </label>\r\n");
#nullable restore
#line 129 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                     foreach (var mainCategory in category.Where(s => s.ParentId == null))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                         foreach (var firstCategory in category.Where(s => s.ParentId == mainCategory.Id))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                             foreach (var twoCategory in category.Where(s => s.ParentId == firstCategory.Id))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <label class=\"container-checkbox\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab45af379e686732abcf4c94a4e265f81fdbb1322737", async() => {
#nullable restore
#line 136 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                                                                                                                                  Write(twoCategory.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                                                                                                          WriteLiteral(twoCategory.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </label>\r\n");
#nullable restore
#line 138 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 144 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"widget shadow-around\">\r\n                            <div class=\"widget-title\">محدوده قیمت</div>\r\n                            <div class=\"widget-content\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab45af379e686732abcf4c94a4e265f81fdbb1327195", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" id=\"pageId\" name=\"pageId\"");
                BeginWriteAttribute("value", " value=\"", 8146, "\"", 8169, 1);
#nullable restore
#line 150 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 8154, ViewBag.pageId, 8154, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <div class=""mt-2 mb-2"">
                                        <div class=""filter-slider"">
                                            <div id=""slider-non-linear-step"" class=""price-slider""></div>
                                        </div>
                                        <ul class=""filter-range"">
                                            <li data-label=""از"" data-currency="" تومان"">
                                                <label>
                                                    <input type=""number"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 8765, "\"", 8792, 1);
#nullable restore
#line 158 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 8773, ViewBag.startPrice, 8773, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""startPrice"" />
                                                </label>

                                            </li>
                                            <li data-label=""تا"" data-currency=""تومان"">
                                                <label>
                                                    <input type=""number"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 9165, "\"", 9190, 1);
#nullable restore
#line 164 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 9173, ViewBag.endPrice, 9173, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""endPrice"" />
                                                </label>
                                            </li>
                                        </ul>
                                    </div>
                                    <div class=""mt-3 mb-3"">
                                        <button class=""btn btn-primary d-inline-flex align-items-center"">
                                            <i class=""fad fa-funnel-dollar ml-2""></i>
                                            اعمال محدوده قیمت
                                        </button>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""d-md-none"">
                            <button class=""btn-filter-product-submit"">جستجوی پیشرفته</button>
                        </div>
                    </div><div class=""resize-sensor"" style=""position: absolute; inset: 0px; overflow: hidden; z-index: -1; visibility: hidden;""><div class=""resize-sensor-expand"" style=""position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: hidden; z-index: -1; visibility: hidden;""><div style=""position: absolute; left: 0px; top: 0px; transition: all 0s ease 0s; width: 352px; height: 1484px;""></div></div><div class=""resize-sensor-shrink"" style=""position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: hidden; z-index: -1; visibility: hidden;""><div style=""position: absolute; left: 0; top: 0; transition: 0s; width: 200%; height: 200%""></div></div></div>
                </div>
            </div>
        </div>
    </div>
</main>
<!---Main conte");
            WriteLiteral("nt--->\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $('.btn-filter-sidebar').on('click', function () {
            $('.filter-options-sidebar').addClass('toggled');
        });
        $('.btn-close-filter-sidebar').on('click', function () {
            $('.filter-options-sidebar').removeClass('toggled');
        });

        if ($('.search-in-options').length) {
            $("".search-in-options input[type=text]"").on(""keyup"", function () {
                var value = $(this).val();
                $(this).parents('.search-in-options').siblings('.widget-content').find('.container-checkbox').filter(function () {
                    $(this).toggle($(this).text().indexOf(value) > -1);
                });
            });
        }

        function sendPage(page) {
            $(""#pageId"").val(page);
            $(""#formFilter"").submit();
        }
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EModernHouse.DataLayer.DTOs.Filter.ProductUserFilterDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
