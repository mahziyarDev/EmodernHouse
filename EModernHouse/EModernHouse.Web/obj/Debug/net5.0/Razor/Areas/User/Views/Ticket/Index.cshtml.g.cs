#pragma checksum "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de168e133b30c30b0e779f9bc684376b1f3abbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Ticket_Index), @"mvc.1.0.view", @"/Areas/User/Views/Ticket/Index.cshtml")]
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
#line 1 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
using EModernHouse.Application.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de168e133b30c30b0e779f9bc684376b1f3abbc", @"/Areas/User/Views/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EModernHouse.DataLayer.DTOs.Contacts.FilterTicketDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TicketDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NoItemFound", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
  
    ViewData["Title"] = "لیست تیکت ها";

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
#line 13 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
           Write(await Component.InvokeAsync("UserSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-8\">\r\n                <div class=\"row mb-4\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"section-title mb-2\">\r\n                           ");
#nullable restore
#line 20 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <section class=""shadow-around p-3"">

                            <div class=""tab-content"" id=""orders-tab"">
                                <div class=""tab-pane fade show active"" id=""wait-for-payment"" role=""tabpanel"" aria-labelledby=""wait-for-payment-tab"">
                                    <section class=""table--order shadow-around mt-4"">
                                        <div class=""table-responsive"">
");
#nullable restore
#line 28 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                         if (Model.Tickets != null && Model.Tickets.Any())
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <table class=""table"">
                                                <thead>
                                                    <tr>
                                                        <th>کد تیکت</th>
                                                        <th>عنوان تیکت</th>
                                                        <th>وضعیت تیکت</th>
                                                        <th>دستورات</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
#nullable restore
#line 40 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                                 foreach (var ticket in Model.Tickets)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                            <td>");
#nullable restore
#line 43 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                                           Write(ticket.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 44 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                                           Write(ticket.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 45 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                                           Write(ticket.TicketState.GetEnumName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de168e133b30c30b0e779f9bc684376b1f3abbc8901", async() => {
                WriteLiteral("\r\n                                                                <i class=\"far fa-chevron-left\"></i>\r\n                                                                نمایش تیکت\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ticketId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                                                                                                             WriteLiteral(ticket.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ticketId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ticketId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ticketId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                    \r\n                                                        </tr>\r\n");
#nullable restore
#line 52 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                \r\n                                                </tbody>\r\n                                            </table>\r\n");
#nullable restore
#line 57 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5de168e133b30c30b0e779f9bc684376b1f3abbc12549", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\Project\EmodernHouse\EModernHouse\EModernHouse.Web\Areas\User\Views\Ticket\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EModernHouse.DataLayer.DTOs.Contacts.FilterTicketDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
