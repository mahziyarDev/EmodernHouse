#pragma checksum "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d947e16028cb5601c0b8d3108a5583c6dfba218a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d947e16028cb5601c0b8d3108a5583c6dfba218a", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\jalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "ورود";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main class=""page-content"">
    <div class=""container"">
        <div class=""auth-wrapper"">
            <div class=""auth-form shadow-around"">
                <div class=""site-logo"">
                    <a href=""#"">
                        <img src=""./assets/images/logo.png"" alt=""logo"">
                    </a>
                </div>
                <div class=""auth-form-title"">
                    ورود به سایت
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d947e16028cb5601c0b8d3108a5583c6dfba218a4384", async() => {
                WriteLiteral(@"
                    <div class=""form-element-row"">
                        <label for=""phone-number"" class=""label-element"">شماره موبایل</label>
                        <div class=""form-element-with-icon"">
                            <input type=""text"" class=""input-element"" id=""phone-number"">
                            <i class=""fad fa-mobile-alt""></i>
                        </div>
                    </div>
                    <div class=""form-element-row"">
                        <label for=""password"" class=""label-element"">
                            <span class=""d-flex justify-content-between"">
                                <span>کلمه عبور</span>
                                <a href=""#"" class=""link--with-border-bottom"">رمز عبور خود را فراموش کرده‌ام</a>
                            </span>
                        </label>
                        <div class=""form-element-with-icon"">
                            <input type=""text"" class=""input-element"" id=""password"">
                  ");
                WriteLiteral(@"          <i class=""fad fa-key-skeleton""></i>
                        </div>
                    </div>
                    <div class=""form-element-row"">
                        <label class=""container-checkbox"">
                            مرا به خاطر داشته باش
                            <input type=""checkbox"" checked=""checked"">
                            <span class=""checkmark""></span>
                        </label>
                    </div>
                    <div class=""form-element-row text-left"">
                        <button class=""btn-element btn-info-element"">
                            <i class=""fad fa-sign-in-alt""></i>
                            ورود به همتا
                        </button>
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
                <div class=""auth-form-footer"">
                    <span>کاربر جدید هستید؟</span>
                    <a href=""#"" class=""link--with-border-bottom"">ثبت نام در همتا</a>
                </div>
            </div>
        </div>
    </div>
</main>");
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
