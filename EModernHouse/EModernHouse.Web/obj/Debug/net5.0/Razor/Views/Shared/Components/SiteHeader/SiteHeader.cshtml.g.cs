#pragma checksum "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27726e40eefe0ccd024d864b2b8fd293f3f68161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SiteHeader_SiteHeader), @"mvc.1.0.view", @"/Views/Shared/Components/SiteHeader/SiteHeader.cshtml")]
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
#line 1 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
using EModernHouse.DataLayer.Entities.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
using EModernHouse.DataLayer.Entities.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
using EModernHouse.Application.EntitiesExtensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
using EModernHouse.DataLayer.Entities.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27726e40eefe0ccd024d864b2b8fd293f3f68161", @"/Views/Shared/Components/SiteHeader/SiteHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SiteHeader_SiteHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown--btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
  
    var siteSetting = ViewBag.SiteSetting as SiteSetting;
    var user = ViewBag.user as User;
    var categories = ViewBag.Categories as List<ProductCategory>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page Header -->
<header class=""page-header"">
    <div class=""top-page-header"">
        <div class=""container"">
            <div class=""d-flex align-items-center justify-content-between"">
                <div class=""contact-list"">
                    <ul>
                        <li><i class=""fas fa-phone-rotary""></i><a");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 726, 2);
            WriteAttributeValue("", 703, "tel:", 703, 4, true);
#nullable restore
#line 17 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
WriteAttributeValue(" ", 707, siteSetting.Phone, 708, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                                                            Write(siteSetting.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li><i class=\"fas fa-envelope\"></i><a");
            BeginWriteAttribute("href", " href=\"", 818, "\"", 851, 2);
            WriteAttributeValue("", 825, "mailto:", 825, 7, true);
#nullable restore
#line 18 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
WriteAttributeValue(" ", 832, siteSetting.Email, 833, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                                                           Write(siteSetting.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                    </ul>
                </div>
                <div class=""top-header-menu"">
                    <ul>
                        <li><a href=""#"">خانه</a></li>
                        <li><a href=""#"">پیگیری سفارش</a></li>
                        <li><a href=""#"">فروشگاه</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""bottom-page-header"">
            <div class=""d-flex align-items-center"">
                <div class=""site-logo"">
                    <a href=""#"">
                        <img src=""/images/logo.png"" alt=""logo"">
                    </a>
                </div>
                <div class=""search-box"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27726e40eefe0ccd024d864b2b8fd293f3f6816110697", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" placeholder=\"نام محصول یا برند را جستجو کنید...\">\r\n                        <i class=\"far fa-search\"></i>\r\n                    ");
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
                    <div class=""search-result"">
                        <ul class=""search-result-list"">
                            <li><a href=""#"">موبایل</a></li>
                            <li><a href=""#"">سامسونگ</a></li>
                            <li><a href=""#"">مودم</a></li>
                            <li><a href=""#"">اپل</a></li>
                            <li><a href=""#"">تلویزیون</a></li>
                        </ul>
                        <ul class=""search-result-most-view"">
                            <li><a href=""#"">موبایل</a></li>
                            <li><a href=""#"">سامسونگ</a></li>
                            <li><a href=""#"">مودم</a></li>
                            <li><a href=""#"">اپل</a></li>
                            <li><a href=""#"">تلویزیون</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""user-items"">
                <div class=""user-item"">
                    <a href=""#"">
 ");
            WriteLiteral("                       <i class=\"fal fa-heart\"></i>\r\n                        <span class=\"bag-items-number\">3</span>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 69 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
               Write(await Component.InvokeAsync("UserOrder"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                             
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"user-item account\">\r\n");
#nullable restore
#line 75 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                     if (!User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <a class=""btn-auth"">
                            <i class=""fal fa-user-circle""></i>
                            ورود و عضویت
                        </a>
                        <ul class=""dropdown--wrapper"">
                            <li>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27726e40eefe0ccd024d864b2b8fd293f3f6816115047", async() => {
                WriteLiteral("وارد شوید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27726e40eefe0ccd024d864b2b8fd293f3f6816116600", async() => {
                WriteLiteral("ثبت نام");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 89 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>\r\n                            ");
#nullable restore
#line 94 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                       Write(user.GetUserShowName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <i class=\"fad fa-chevron-down text-sm mr-1\"></i>\r\n                        </a>\r\n                        <ul class=\"dropdown--wrapper\">\r\n\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27726e40eefe0ccd024d864b2b8fd293f3f6816119036", async() => {
                WriteLiteral("\r\n                                    ورود به حساب کاربری\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27726e40eefe0ccd024d864b2b8fd293f3f6816120796", async() => {
                WriteLiteral("\r\n                                    خروج از حساب کاربری\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n\r\n                        </ul>\r\n");
#nullable restore
#line 112 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <nav class=\"nav-wrapper\">\r\n            <ul>\r\n");
#nullable restore
#line 120 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                 if (categories != null && categories.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                     foreach (var mainGroup in categories.Where(s => s.ParentId == null))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"category-list\">\r\n                            <a href=\"#\">");
#nullable restore
#line 125 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                   Write(mainGroup.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <ul>\r\n");
#nullable restore
#line 127 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                 if (categories.Any(s => s.ParentId == mainGroup.Id))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                     foreach (var FirstGroup in categories.Where(s => s.ParentId == mainGroup.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            <a href=\"#\">");
#nullable restore
#line 132 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                   Write(FirstGroup.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <ul class=\"row\" style=\"overflow-y: scroll\">\r\n                                                <li class=\"col-12\">\r\n                                                    <a href=\"#\">همه دسته بندی های ");
#nullable restore
#line 135 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                                             Write(FirstGroup.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                    <ul class=""row"">
                                                        <li class=""col-4"">
                                                            <a href=""#"" class=""list-item--image my-3"">
                                                                <img src=""/images/mega-menu/01.jpg"" class=""img-fluid rounded""");
            BeginWriteAttribute("alt", " alt=\"", 6370, "\"", 6376, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            </a>\r\n                                                        </li>\r\n");
#nullable restore
#line 142 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                         foreach (var TwoGroup in categories.Where(s => s.ParentId == FirstGroup.Id))
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <li class=\"col-2\">\r\n                                                                <a href=\"#\">");
#nullable restore
#line 145 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                                       Write(TwoGroup.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                            </li>\r\n");
#nullable restore
#line 147 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </ul>\r\n                                                </li>\r\n                                            </ul>\r\n                                        </li>\r\n");
#nullable restore
#line 153 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 158 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </ul>
        </nav>
    </div>
</header>
<!-- header responsive -->
<div class=""header-responsive fixed--header-top"">
    <div class=""header-top"">
        <div class=""side-navigation-wrapper"">
            <button class=""btn-toggle-side-navigation""><i class=""far fa-bars""></i></button>
            <div class=""side-navigation"">
                <div class=""site-logo"">
                    <a href=""#"">
                        <img src=""/images/logo.png"" alt=""logo"">
                    </a>
                </div>
                <div class=""divider""></div>

                <ul class=""category-list"">
");
#nullable restore
#line 179 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                     if (categories != null && categories.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                         foreach (var MainCategory in categories.Where(s => s.ParentId == null))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"has-children\">\r\n                                <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 8349, "\"", 8357, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 184 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                Write(MainCategory.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 185 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                 if (categories.Any(s => s.ParentId == MainCategory.Id))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <ul style=\"display: none;\">\r\n");
#nullable restore
#line 188 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                         foreach (var FirstCategory in categories.Where(s => s.ParentId == MainCategory.Id))
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"has-children\">\r\n                                                <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 8875, "\"", 8883, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 192 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                                Write(FirstCategory.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 193 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                 if (categories.Any(s => s.ParentId == FirstCategory.Id))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <ul style=\"display: none;\">\r\n");
#nullable restore
#line 196 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                         foreach (var towCategory in categories.Where(s => s.ParentId == FirstCategory.Id))
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <li><a href=\"#\">");
#nullable restore
#line 198 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                                       Write(towCategory.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 199 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                            
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </ul>\r\n");
#nullable restore
#line 202 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </li>\r\n");
#nullable restore
#line 204 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"


                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n");
#nullable restore
#line 208 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 211 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 211 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                </ul>
            </div>
            <div class=""overlay-side-navigation""></div>
        </div>
        <div class=""site-logo"">
            <a href=""#"">
                <img src=""/images/logo.png"" alt=""logo"">
            </a>
        </div>
");
#nullable restore
#line 223 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
       if (User.Identity.IsAuthenticated)
      {
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
     Write(await Component.InvokeAsync("UserOrderResponsive"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Components\SiteHeader\SiteHeader.cshtml"
                                                             
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"header-bottom\">\r\n        <div class=\"search-box\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27726e40eefe0ccd024d864b2b8fd293f3f6816136965", async() => {
                WriteLiteral("\r\n                <input type=\"text\" placeholder=\"نام محصول یا برند را جستجو کنید...\">\r\n                <i class=\"far fa-search\"></i>\r\n            ");
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
            <div class=""search-result"">
                <ul class=""search-result-list"">
                    <li><a href=""#"">موبایل</a></li>
                    <li><a href=""#"">سامسونگ</a></li>
                    <li><a href=""#"">مودم</a></li>
                    <li><a href=""#"">اپل</a></li>
                    <li><a href=""#"">تلویزیون</a></li>
                </ul>
                <ul class=""search-result-most-view"">
                    <li><a href=""#"">موبایل</a></li>
                    <li><a href=""#"">سامسونگ</a></li>
                    <li><a href=""#"">مودم</a></li>
                    <li><a href=""#"">اپل</a></li>
                    <li><a href=""#"">تلویزیون</a></li>
                </ul>
            </div>
        </div>
        <div class=""header-tools"">
            <a href=""#""><i class=""far fa-user-circle""></i></a>
        </div>
    </div>
</div>
<!-- end header responsive -->
<!-- end Page Header -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
