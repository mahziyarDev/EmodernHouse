#pragma checksum "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc22c7f77863661defee9025df7cf658482ef70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Ticket_TicketDetail), @"mvc.1.0.view", @"/Areas/User/Views/Ticket/TicketDetail.cshtml")]
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
#line 1 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
using EModernHouse.DataLayer.DTOs.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
using EModernHouse.DataLayer.Entities.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc22c7f77863661defee9025df7cf658482ef70", @"/Areas/User/Views/Ticket/TicketDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Ticket_TicketDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EModernHouse.DataLayer.DTOs.Contacts.TicketDetailDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AnswerTicketPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
  
    ViewData["Title"] = Model.Ticket.Title;
    var user = ViewBag.user as User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/ChatRoom.css\" />\r\n");
            }
            );
            WriteLiteral(@"<main class=""page-content"" style=""margin-top: 235.5px; transform: none;"">
    <div class=""container"" style=""transform: none;"">
        <div class=""row mb-5"" style=""transform: none;"">
            <div class=""col-lg-3 col-md-4 mb-md-0 mb-3 sticky-sidebar"" style=""position: relative; overflow: visible; box-sizing: border-box; min-height: 1px;"">

                ");
#nullable restore
#line 20 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
           Write(await Component.InvokeAsync("UserSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-8\">\r\n                <div class=\"row mb-4\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"section-title mb-2\">\r\n                            عنوان تیکت : ");
#nullable restore
#line 27 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                    Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <section class=""shadow-around p-3"">

                            <div class=""tab-content"" id=""orders-tab"">
                                <div class=""tab-pane fade show active"" id=""wait-for-payment"" role=""tabpanel"" aria-labelledby=""wait-for-payment-tab"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bc22c7f77863661defee9025df7cf658482ef706781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 33 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (new AnswerTicketDTO{Id = Model.Ticket.Id});

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <hr />\r\n                                    <ul class=\"messages\" id=\"messages\">\r\n");
#nullable restore
#line 37 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                         if (Model.TicketMessages != null && Model.TicketMessages.Any())
                                        {
                                            foreach (var message in Model.TicketMessages)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li");
            BeginWriteAttribute("class", " class=\"", 1983, "\"", 2070, 3);
            WriteAttributeValue("", 1991, "message", 1991, 7, true);
#nullable restore
#line 41 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
WriteAttributeValue(" ", 1998, message.SenderId == Model.Ticket.OwnerId ? "right" : "left", 1999, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2061, "appeared", 2062, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <div class=\"avatar\">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 2208, "\"", 2334, 1);
#nullable restore
#line 43 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
WriteAttributeValue("", 2214, message.SenderId == Model.Ticket.OwnerId ? PathExtensions.UserAvatarThumb + user.Avatar : PathExtensions.SupportImage, 2214, 120, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"">
                                                    </div>
                                                    <div class=""text_wrapper"">
                                                        
                                                        <div class=""time"">
                                                            ");
#nullable restore
#line 48 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                                       Write(message.CreateDate.ToStringShamsiDate());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ساعت ");
#nullable restore
#line 48 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                                                                                     Write(message.CreateDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </div>\r\n                                                        <div class=\"text\" style=\"font-size: 16px\">\r\n                                                            / <span>");
#nullable restore
#line 51 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                                                Write(message.SenderId == Model.Ticket.OwnerId ? "شما" : "پشتیبانی");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                            ");
#nullable restore
#line 52 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                                       Write(Html.Raw(message.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </li>\r\n");
#nullable restore
#line 56 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>

                                </div>

                            </div>
                        </section>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EModernHouse.DataLayer.DTOs.Contacts.TicketDetailDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
