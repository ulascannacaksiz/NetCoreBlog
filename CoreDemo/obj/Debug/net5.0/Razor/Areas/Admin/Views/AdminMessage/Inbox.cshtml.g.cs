#pragma checksum "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c44b77b475d172121448b31d4f4e1f80f0d17a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessage_Inbox), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessage/Inbox.cshtml")]
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
#line 1 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c44b77b475d172121448b31d4f4e1f80f0d17a", @"/Areas/Admin/Views/AdminMessage/Inbox.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminMessage_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <div class=""wrapper wrapper-content"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""ibox "">
                    <div class=""ibox-content mailbox-content"">
                        <div class=""file-manager"">
                            <a class=""btn btn-block btn-primary compose-mail"" href=""mail_compose.html"">Mesaj Kutusu</a>
                            <div class=""space-25""></div>
                            <h5>Klasörler</h5>
                            <ul class=""folder-list m-b-md"" style=""padding: 0"">
                                <li><a href=""/Admin/AdminMessage/Inbox""> <i class=""fa fa-inbox ""></i> Gelen Mesajlar <span class=""label label-warning float-right"">16</span> </a></li>
                                <li><a href=""/Admin/AdminMessage/Sendbox""> <i class=""fa fa-envelope-o""></i> Giden Mesajlar</a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-certificate""></i> Önemli</a></li>
                        ");
            WriteLiteral(@"        <li><a href=""mailbox.html""> <i class=""fa fa-file-text-o""></i> Taslaklar <span class=""label label-danger float-right"">2</span></a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i> Çöp kutusu</a></li>
                            </ul>
                            <h5>Kategoriler</h5>
                            <ul class=""category-list"" style=""padding: 0"">
                                <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> İş </a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Dokümanlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Sosysal</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Tanıtımlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Yıldızlı</a></li>
                            </ul>
                            <div ");
            WriteLiteral(@"class=""clearfix""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 animated fadeInRight"">
                <div class=""mail-box-header"">

                    <form method=""get"" action=""index.html"" class=""float-right mail-search"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control form-control-sm"" name=""search"" placeholder=""Mail Ara"">
                            <div class=""input-group-btn"">
                                <button type=""submit"" class=""btn btn-sm btn-primary"">
                                    Ara
                                </button>
                            </div>
                        </div>
                    </form>
                    <h2>
                        Gelen kutusu (0)
                    </h2>
                    <div class=""mail-tools tooltip-demo m-t-md"">
                        <div class");
            WriteLiteral(@"=""btn-group float-right"">
                            <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-left""></i></button>
                            <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-right""></i></button>

                        </div>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""left"" title=""Refresh inbox""><i class=""fa fa-refresh""></i> Yenile</button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Okunmuş olarak işaretle""><i class=""fa fa-eye""></i> </button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Önemli olarak işaretle""><i class=""fa fa-exclamation""></i> </button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Çöp kutusuna taşı""><i class=""fa fa-trash-o""></i> </button>

                    </div>
                </");
            WriteLiteral("div>\r\n                <div class=\"mail-box\">\r\n\r\n                    <table class=\"table table-hover table-mail\">\r\n                        <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr class=""unread"">
                                    <td class=""check-mail"">
                                        <input type=""checkbox"" class=""i-checks"">
                                    </td>
                                    <td class=""mail-ontact""><a href=""mail_detail.html"">");
#nullable restore
#line 79 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml"
                                                                                  Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                    <td class=\"mail-subject\"><a href=\"mail_detail.html\">");
#nullable restore
#line 80 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml"
                                                                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                    <td class=\"text-right mail-date\">");
#nullable restore
#line 81 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml"
                                                                 Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 83 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\Inbox.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
