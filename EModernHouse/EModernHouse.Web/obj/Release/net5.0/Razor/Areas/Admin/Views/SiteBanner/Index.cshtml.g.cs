#pragma checksum "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4171f23fc137e181bca8f6fd8d5f6dace26df8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SiteBanner_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SiteBanner/Index.cshtml")]
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
#line 1 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\_ViewImports.cshtml"
using EModernHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
using EModernHouse.DataLayer.Entities.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
using EModernHouse.Application.EntitiesExtensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4171f23fc137e181bca8f6fd8d5f6dace26df8d", @"/Areas/Admin/Views/SiteBanner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae773dd58c9e3f2d5b9fe49aacec7381e98e734", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SiteBanner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EModernHouse.DataLayer.Entities.Site.SiteBanner>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SiteBanner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateBanner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBanner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EDitBanner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
  
    ViewData["Title"] = "تنظیمات بنر سایت";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4171f23fc137e181bca8f6fd8d5f6dace26df8d6714", async() => {
                WriteLiteral("افزودن بنر جدید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <hr class=""wide""/>
    <div class=""col-md-12"">
        <div class=""widget"">
            <div class=""widget-header"">
                <span class=""widget-caption"">
                    لیست بنر ها
                </span>
            </div>
            <div class=""widget-body"">
                <table class=""table table-bordered table-hover"">
                    <tr>
                        <th>
                            تصویر محصول
                        </th>
                        <th>
                            بخش سایت
                        </th>
                        <th>
                            مقدار alt
                        </th>
                        <th>
                            سایز بوت استرپ
                        </th>
                        <th>
                            لینک بنر
                        </th>
                        <th>دستورات</th>
                    </tr>
");
#nullable restore
#line 40 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                     foreach (var banners in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <img style=\"width: 100px; height: 80px\"");
            BeginWriteAttribute("src", " src=\"", 1561, "\"", 1603, 1);
#nullable restore
#line 44 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
WriteAttributeValue("", 1567, banners.GetBannerMainImageAddress(), 1567, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 47 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                 switch (banners.BannerPlacement)
                                {
                                    case BannerPlacement.Home_1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>بنر قسمت اول</span>\r\n");
#nullable restore
#line 51 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                        break;
                                    case BannerPlacement.Home_2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>بنر قسمت دوم</span>\r\n");
#nullable restore
#line 54 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                        break;
                                    case BannerPlacement.Home_3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>بنر قسمت سوم</span>\r\n");
#nullable restore
#line 57 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                        break;
                                    case BannerPlacement.Home_4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>بنر قسمت چهارم</span>\r\n");
#nullable restore
#line 60 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                        break;
                                    case BannerPlacement.Home_5:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>بنر قسمت بالایی سایت</span>\r\n");
#nullable restore
#line 63 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                        break;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                           Write(banners.Alt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                           Write(banners.ColSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                           Write(banners.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4171f23fc137e181bca8f6fd8d5f6dace26df8d13791", async() => {
                WriteLiteral("حذف");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bannerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                                                                                                                         WriteLiteral(banners.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bannerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bannerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bannerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4171f23fc137e181bca8f6fd8d5f6dace26df8d16622", async() => {
                WriteLiteral("\r\n                                    ویرایش\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bannerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                                                                                                                                        WriteLiteral(banners.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bannerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bannerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bannerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                   \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\Admin\Views\SiteBanner\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EModernHouse.DataLayer.Entities.Site.SiteBanner>> Html { get; private set; }
    }
}
#pragma warning restore 1591