#pragma checksum "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0378b6299707620aba1aaa78a1f44024a83b18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Comment__ShowComments), @"mvc.1.0.view", @"/Views/Shared/Comment/_ShowComments.cshtml")]
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
#line 1 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\_ViewImports.cshtml"
using EModernHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\_ViewImports.cshtml"
using EModernHouse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
using EModernHouse.Application.EntitiesExtensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
using EModernHouse.Application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f0378b6299707620aba1aaa78a1f44024a83b18", @"/Views/Shared/Comment/_ShowComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8665317206f0ad895d4dffc33d206eed2acdb025", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Comment__ShowComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EModernHouse.DataLayer.Entities.ProductComment.ProductComment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    \r\n");
#nullable restore
#line 6 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
 if (Model.Any() && Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
     foreach (var comment in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-3 aside\">\r\n                <ul class=\"comments-user-shopping\">\r\n                    <li>\r\n                        <div class=\"cell cell-name\">\r\n                             کاربر : ");
#nullable restore
#line 15 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
                                Write(comment.User.GetUserShowName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </li>\r\n                    <li>\r\n                        <div class=\"cell\">\r\n                            ");
#nullable restore
#line 21 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
                       Write(comment.CreateDate.ToStringShamsiDate());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ساعت ");
#nullable restore
#line 21 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
                                                                     Write(comment.CreateDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </li>\r\n                </ul>\r\n\r\n\r\n            </div>\r\n            <div class=\"col-md-9 article\">\r\n                <div class=\"header\">\r\n                    <div>");
#nullable restore
#line 30 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
                    Write(comment.TitleComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <p>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
               Write(comment.TextComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-warning\">\r\n    <p>هیچ کامنتی برای این محصول ثبت نشده است .\r\n        <br/>\r\n        شما اولین نفر باشید...\r\n    </p>\r\n</div>\r\n");
#nullable restore
#line 48 "C:\Users\Mahziyar\Desktop\ProjectJalili\EmodernHouse\EModernHouse\EModernHouse.Web\Views\Shared\Comment\_ShowComments.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EModernHouse.DataLayer.Entities.ProductComment.ProductComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
