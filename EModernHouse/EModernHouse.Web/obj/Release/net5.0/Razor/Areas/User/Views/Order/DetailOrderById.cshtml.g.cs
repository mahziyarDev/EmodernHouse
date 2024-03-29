#pragma checksum "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d007b038c47ea18f3f2ee9cdff481211c5d51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Order_DetailOrderById), @"mvc.1.0.view", @"/Areas/User/Views/Order/DetailOrderById.cshtml")]
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
#line 1 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d007b038c47ea18f3f2ee9cdff481211c5d51f", @"/Areas/User/Views/Order/DetailOrderById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Order_DetailOrderById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EModernHouse.DataLayer.Entities.ProductOrder.OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
  
    ViewData["Title"] = "جزییات فاکتور";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""page-content"" style=""margin-top: 235.5px; transform: none;"">
    <div class=""container"" style=""transform: none;"">
        <div class=""row mb-5"" style=""transform: none;"">
            <div class=""col-lg-3 col-md-4 mb-md-0 mb-3 sticky-sidebar"" style=""position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;"">

                ");
#nullable restore
#line 12 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
           Write(await Component.InvokeAsync("UserSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-8\">\r\n                <div class=\"row mb-4\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"section-title mb-2\">\r\n                            ");
#nullable restore
#line 19 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                       \r\n                        <section class=\"table--order shadow-around mt-4\">\r\n                            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 24 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                 if (Model.Any() && Model != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>عکس محصول </th>
                                                <th>نام محصول</th>
                                                <th>قیمت محصول</th>
                                                <th>رنگ محصول</th>
                                                <th>قیمت مضاف رنگ</th>
                                                <th>تعداد محصول</th>
                                                <th>جمع نهایی قیمت</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 39 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                         foreach (var order in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    <img class=\"img-responsive\" style=\"width: 100px; height: 80px\"");
            BeginWriteAttribute("title", "\r\n                                                         title=\"", 2250, "\"", 2336, 1);
#nullable restore
#line 44 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
WriteAttributeValue("", 2316, order.Product.Title, 2316, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2337, "\"", 2404, 1);
#nullable restore
#line 44 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
WriteAttributeValue("", 2343, PathExtensions.ProductImageThumb + order.Product.ImageName, 2343, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 46 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                               Write(order.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 47 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                               Write(order.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 48 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                               Write(order.ProductColor.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 49 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                               Write(order.ProductColor.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <th>");
#nullable restore
#line 50 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                               Write(order.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td>");
#nullable restore
#line 51 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                                Write((order.Count*(order.Product.Price + order.ProductColor.Price)).ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 53 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                    
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n");
#nullable restore
#line 57 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Order\DetailOrderById.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </section>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EModernHouse.DataLayer.Entities.ProductOrder.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
