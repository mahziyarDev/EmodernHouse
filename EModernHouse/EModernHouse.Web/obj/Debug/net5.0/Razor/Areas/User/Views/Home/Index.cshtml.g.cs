#pragma checksum "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d424340c19443c9bf197ce5810376ce795b2e946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Home_Index), @"mvc.1.0.view", @"/Areas/User/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\_ViewImports.cshtml"
using EModernHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\_ViewImports.cshtml"
using EModernHouse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
using EModernHouse.DataLayer.Entities.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
using EModernHouse.Web.PresentationExtentions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d424340c19443c9bf197ce5810376ce795b2e946", @"/Areas/User/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUserAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "داشبورد";
    var userAddresses = ViewData["userAddress"];
    var userInf = ViewBag.UserInformation as UserAddress;

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
#line 17 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("UserSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-8\">\r\n                <div class=\"section-title mb-2\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"checkout-section shadow-around\">\r\n                    <div class=\"checkout-section-content\">\r\n                        <div class=\"row mx-0 pl-3 pr-3\">\r\n");
#nullable restore
#line 27 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
                             if ((bool)userAddresses)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-12"">
                                    <div class=""card text-center"">
                                        <div class=""card-header"">
                                            آدرس
                                        </div>
                                        <div class=""card-body"">
                                            <h5 class=""card-title"">");
#nullable restore
#line 35 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
                                                              Write(userInf.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                            <p class=""card-text"">مرسولات شما به این آدرس ارسال می شود (لطفا در ثبت ادرس دقت فرمایید مرسولات شما به این ادس ارسال می شود)</p>
                                            <br />
                                            <a data-toggle=""modal"" data-target=""#editmodal"" class=""btn btn-primary""");
            BeginWriteAttribute("editText", " editText=\"", 1899, "\"", 1926, 1);
#nullable restore
#line 38 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
WriteAttributeValue("", 1910, userInf.Address, 1910, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ویرایش آدرس</a>\r\n                                        </div>\r\n\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 43 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class="" col-md-12 alert alert-warning"">
                                    <p>
                                        کاربرگرامی لطفا ادرس سکونت خود را برای ارسال مرسولات خود واد نمایید .
                                    </p>

                                </div>
");
            WriteLiteral(@"                                <div class=""col-md-12"">
                                    <button type=""button"" class=""btn btn-sm btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                                        ثبت ادرس
                                    </button>
                                </div>
");
#nullable restore
#line 59 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <div class=""row mt-3 pl-4 pr-4"">
                            <div class=""col-sm-6"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">اطلاعات تماس</h5>
                                        <p class=""card-text"">");
#nullable restore
#line 68 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
                                                        Write(userInf.User.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 69 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
                                         if (userInf.User.Email != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"card-text\">");
#nullable restore
#line 71 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
                                                            Write(userInf.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 72 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">کامنت های شما در سایت</h5>
                                        <p class=""card-text"">این ویژگی به زودی به سایت اضافه خواهد شد</p>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</main>

<!-- Modal for create address -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""moda");
            WriteLiteral(@"l-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">ثبت ادرس</h5>
                <button type=""button"" onclick=""closeAddress()"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d424340c19443c9bf197ce5810376ce795b2e94613656", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <label>آدرس را وارد کنید</label>
                        <textarea  name=""address"" class=""form-control addAddress"" placeholder=""آدرس به صورت کامل نوشته شود هرگونه نقص در ادرس بر عهده کابر می باشد ..""></textarea>
                    </div>

                    <br />
                    <button onclick=""closeAddress()"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">بستن</button>
                    <button type=""submit"" class=""btn btn-primary"">ثبت ادرس</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
    </div>
</div>


<!-- Modal for edit address -->
<div class=""modal fade"" id=""editmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""editmodalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editmodalLabel"">ویرایش آدرس</h5>
                <button type=""button"" onclick=""closeAddress()"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d424340c19443c9bf197ce5810376ce795b2e94617020", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <label>آدرس را وارد کنید</label>
                        <textarea id=""EditAddressText"" name=""address"" class=""form-control addAddress""></textarea>
                    </div>

                    <br />
                    <button onclick=""closeAddress()"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">بستن</button>
                    <button type=""submit"" class=""btn btn-primary"">ثبت ادرس</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
