#pragma checksum "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AddRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52a0155d9dc6012b9abaf2a7a8be994c727d252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_AddRole), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/AddRole.cshtml")]
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
#line 1 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AddRole.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52a0155d9dc6012b9abaf2a7a8be994c727d252", @"/Areas/Admin/Views/AdminRole/AddRole.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminRole_AddRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\UlasCan\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\AddRole.cshtml"
  
    ViewData["Title"] = "AddRole";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Role Ekleme Sayfası</h1>\r\n\r\n<form method=\"post\">\r\n    <div class=\"form-group\">\r\n        <label>Rol başlığı</label>\r\n        <input type=\"text\" name=\"Name\" class=\"form-control\" />\r\n    </div>\r\n");
            WriteLiteral("    <button class=\"btn btn-info\">Kaydet</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591