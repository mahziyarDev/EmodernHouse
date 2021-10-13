#pragma checksum "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "534630b5bce9031ea0b3785504411f9679fe49e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserOrder_UserOrder), @"mvc.1.0.view", @"/Views/Shared/Components/UserOrder/UserOrder.cshtml")]
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
#line 1 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534630b5bce9031ea0b3785504411f9679fe49e1", @"/Views/Shared/Components/UserOrder/UserOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserOrder_UserOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EModernHouse.DataLayer.Entities.ProductOrder.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserOpenOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
  
    var totalPrice = 0;
    if (Model.OrderDetails != null && Model.OrderDetails.Any())
    {
        foreach (var detail in Model.OrderDetails)
        {
            totalPrice += detail.Count * (detail.Product.Price + detail.ProductColor.Price);
        }
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"user-item cart-list\">\n    <a href=\"#\">\n        <i class=\"fal fa-shopping-basket\"></i>\n        <span class=\"bag-items-number\">");
#nullable restore
#line 18 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                  Write(Model.OrderDetails.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    </a>\n    <ul>\n        <li class=\"cart-items\">\n            <ul class=\"do-nice-scroll\" style=\"overflow: hidden; outline: currentcolor none medium;\" tabindex=\"1\">\n");
#nullable restore
#line 23 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                 if (Model.OrderDetails != null && Model.OrderDetails.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                     foreach (var order in Model.OrderDetails)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"cart-item\">\n                    <span class=\"d-flex align-items-center mb-2\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534630b5bce9031ea0b3785504411f9679fe49e17628", async() => {
                WriteLiteral("\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1209, "\"", 1274, 1);
#nullable restore
#line 30 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
WriteAttributeValue("", 1215, PathExtensions.ProductImageThumb+order.Product.ImageName, 1215, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1275, "\"", 1301, 1);
#nullable restore
#line 30 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
WriteAttributeValue("", 1281, order.Product.Title, 1281, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                                                                                    WriteLiteral(order.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                                                                                                                        WriteLiteral(order.Product.Title.FixTextForUrl());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <span>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534630b5bce9031ea0b3785504411f9679fe49e112177", async() => {
                WriteLiteral("\n                                <span class=\"title-item\">\n                                    ");
#nullable restore
#line 35 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                               Write(order.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </span>\n                            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                                                                                        WriteLiteral(order.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                                                                                                                            WriteLiteral(order.Product.Title.FixTextForUrl());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <span class=\"color d-flex align-items-center\">\n                                رنگ:\n                                <span");
            BeginWriteAttribute("style", " style=\"", 1892, "\"", 1948, 3);
            WriteAttributeValue("", 1900, "background-color:", 1900, 17, true);
#nullable restore
#line 40 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
WriteAttributeValue(" ", 1917, order.ProductColor.ColorCode, 1918, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1947, ";", 1947, 1, true);
            EndWriteAttribute();
            WriteLiteral("></span>\n                            </span>\n                        </span>\n                    </span>\n                    <span");
            BeginWriteAttribute("class", " class=\"", 2079, "\"", 2087, 0);
            EndWriteAttribute();
            WriteLiteral(">قیمت محصول : ");
#nullable restore
#line 44 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                           Write(order.Product.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("تومان </span>\n                    <br />\n                    <span");
            BeginWriteAttribute("class", " class=\"", 2204, "\"", 2212, 0);
            EndWriteAttribute();
            WriteLiteral("> رنگ : ");
#nullable restore
#line 46 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                     Write(order.ProductColor.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> <span>قیمت مضاف رنگ : ");
#nullable restore
#line 46 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                                                                                 Write(order.ProductColor.Price.ToString("#,0 تومان"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    <br />\n                    <span");
            BeginWriteAttribute("class", " class=\"", 2388, "\"", 2396, 0);
            EndWriteAttribute();
            WriteLiteral(">تعداد : ");
#nullable restore
#line 48 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                      Write(order.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    <br />\n                    <span>جمع کل این محصول : ");
#nullable restore
#line 50 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                                         Write(((order.Product.Price + order.ProductColor.Price) * order.Count).ToString("#,0 تومان"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    <br/>\n                    <button class=\"remove-item\">\n                        <i class=\"far fa-trash-alt\"></i>\n                    </button>\n                </li>\n");
#nullable restore
#line 56 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </ul>\n        </li>\n        <li class=\"cart-footer\">\n            <span class=\"d-block text-center mb-3\">\n                مبلغ کل:\n                <span class=\"total\">");
#nullable restore
#line 66 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\UserOrder\UserOrder.cshtml"
                               Write(totalPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\n            </span>\n            <span class=\"d-block text-center px-2\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534630b5bce9031ea0b3785504411f9679fe49e120816", async() => {
                WriteLiteral("\n                    مشاهده سبد خرید\n                    <i class=\"mi mi-ShoppingCart\"></i>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
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
            </span>
        </li>
        <div id=""ascrail2000"" class=""nicescroll-rails nicescroll-rails-vr"" style=""width: 8px; z-index: 1000; cursor: default; position: absolute; top: 0px; left: 0px; height: 250px; display: block; opacity: 0;""><div style=""position: relative; top: 37px; float: right; width: 6px; height: 213px; background-color: rgb(66, 66, 66); border: 1px solid rgb(255, 255, 255); background-clip: padding-box; border-radius: 5px;"" class=""nicescroll-cursors""></div></div>
        <div id=""ascrail2000-hr"" class=""nicescroll-rails nicescroll-rails-hr"" style=""height: 8px; z-index: 1000; top: 242px; left: 0px; position: absolute; cursor: default; display: none; width: 292px; opacity: 0;""><div style=""position: absolute; top: 0px; height: 6px; width: 300px; background-color: rgb(66, 66, 66); border: 1px solid rgb(255, 255, 255); background-clip: padding-box; border-radius: 5px; left: 8px;"" class=""nicescroll-cursors""></div></div>
    </ul>
</div>");
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
