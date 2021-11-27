#pragma checksum "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044a3f06d9178728e740576aa311496179ed783c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Order_UserOpenOrder), @"mvc.1.0.view", @"/Areas/User/Views/Order/UserOpenOrder.cshtml")]
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
#line 1 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\_ViewImports.cshtml"
using EModernHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\_ViewImports.cshtml"
using EModernHouse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"044a3f06d9178728e740576aa311496179ed783c", @"/Areas/User/Views/Order/UserOpenOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Order_UserOpenOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EModernHouse.DataLayer.Entities.ProductOrder.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
  
    ViewData["Title"] = "سبد خرید";
  
        var totalPrice = 0;
        if (Model.OrderDetails != null && Model.OrderDetails.Any())
        {
            foreach (var detail in Model.OrderDetails)
            {
                totalPrice = totalPrice + (detail.Count * (detail.Product.Price + detail.ProductColor.Price));
            }
        }
    
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"}

<main class=""page-content"" style=""margin-top: 235.5px; transform: none;"">
    <div class=""container"" style=""transform: none;"">
        <div class=""row mb-5"" style=""transform: none;"">
            <div class=""col-lg-3 col-md-4 mb-md-0 mb-3 sticky-sidebar"" style=""position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;"">

                ");
#nullable restore
#line 23 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
           Write(await Component.InvokeAsync("UserSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-8\">\r\n                <div class=\"row mb-4\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"section-title mb-2\">\r\n                            ");
#nullable restore
#line 30 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <section class=\"table--order shadow-around mt-4\">\r\n                            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 35 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                 if (Model.OrderDetails.Any() && Model.OrderDetails != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <table class=""table"">
                                        <thead>
                                        <tr>
                                            <th>---</th>
                                            <th>عکس محصول </th>
                                            <th>نام محصول</th>
                                            <th>قیمت محصول</th>
                                            <th>رنگ محصول</th>
                                            <th>قیمت مضاف رنگ</th>
                                            <th>تعداد محصول</th>
                                            <th> درصد تخفیف</th>
                                            <th>جمع نهایی قیمت بدون تخفیف</th>
                                            <th>جمع نهایی قیمت با تخفیف</th>
                                        </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 53 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                         foreach (var order in Model.OrderDetails)
                                        {
                                            var discount = order.Product.ProductDisCounts?.OrderByDescending(s=>s.CreateDate).FirstOrDefault(s=>s.ExpireDate>DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    <a");
            BeginWriteAttribute("DeleteItemInBag", "  DeleteItemInBag=\"", 2874, "\"", 2902, 1);
#nullable restore
#line 58 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
WriteAttributeValue("", 2893, order.Id, 2893, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-trash-alt""></i></a>
                                                </td>
                                                <td>
                                                    <img class=""img-responsive"" style=""width: 60px; height: 40px""");
            BeginWriteAttribute("title", "\r\n                                                         title=\"", 3164, "\"", 3250, 1);
#nullable restore
#line 62 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
WriteAttributeValue("", 3230, order.Product.Title, 3230, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 3251, "\"", 3318, 1);
#nullable restore
#line 62 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
WriteAttributeValue("", 3257, PathExtensions.ProductImageThumb + order.Product.ImageName, 3257, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 64 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                               Write(order.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 65 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                               Write(order.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 66 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                               Write(order.ProductColor.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 67 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                               Write(order.ProductColor.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">\r\n                                                    <input class=\"text-center form-control pr-1 pl-1\" type=\"number\" min=\"1\"");
            BeginWriteAttribute("value", " value=\"", 3905, "\"", 3925, 1);
#nullable restore
#line 69 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
WriteAttributeValue("", 3913, order.Count, 3913, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                                </td>\r\n                                                <td>\r\n");
#nullable restore
#line 72 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                     if (discount != null)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                   Write(discount?.Percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span>%</span>\r\n");
#nullable restore
#line 76 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span> ندارد</span>\r\n");
#nullable restore
#line 80 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 83 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                Write((order.Count * (order.Product.Price + order.ProductColor.Price)).ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</td>\r\n");
#nullable restore
#line 84 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                 if (discount != null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>");
#nullable restore
#line 86 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                    Write((order.Count * (order.Product.Price + order.ProductColor.Price) * discount.Percentage / 100).ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</td>\r\n");
#nullable restore
#line 87 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>ندارد</td>\r\n");
#nullable restore
#line 91 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </tr>\r\n");
#nullable restore
#line 94 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n");
#nullable restore
#line 98 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </section>
                    </div>
                </div>
                <div class=""row mt-3 checkout-section shadow-around"">
                    <div class=""col-lg-6 col-md-6"">
                        
                        <div class=""checkout-section-title"">کد تخفیف</div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "044a3f06d9178728e740576aa311496179ed783c15999", async() => {
                WriteLiteral(@"
                            <div class=""d-flex align-items-center"">
                                <div class=""form-element-row flex-grow-1"">
                                    <input type=""text"" class=""input-element"" id=""phone-number"" placeholder=""کد تخفیف را وارد کنید"">
                                </div>
                                <div class=""form-element-row mr-3"">
                                    <button class=""btn-element btn-info-element"">
                                        <i class=""fad fa-sync""></i>
                                        ثبت
                                    </button>
                                </div>
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
            WriteLiteral(@"
                        
                    </div>
                    <div class=""col-lg-6 col-md-6"">
                        <span class=""d-block text-center mb-3"">
                            مبلغ کل:
                            <span class=""total"">");
#nullable restore
#line 126 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\UserOpenOrder.cshtml"
                                           Write(totalPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n         </div>\r\n     </div>\r\n</main>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EModernHouse.DataLayer.Entities.ProductOrder.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
