#pragma checksum "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d258247eec80de1f5c4efadb9fd2f7a8b82687c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Delete), @"mvc.1.0.view", @"/Views/Admins/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Delete.cshtml", typeof(AspNetCore.Views_Admins_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d258247eec80de1f5c4efadb9fd2f7a8b82687c", @"/Views/Admins/Delete.cshtml")]
    public class Views_Admins_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Admins>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
  
    ViewData["Title"] = "Delete Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 89, true);
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
            EndContext();
            BeginContext(226, 17, false);
#line 11 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(243, 338, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <h3>Are you sure you want to delete this?</h3>
            <div>
                <dl class=""dl-horizontal"">
                    <dt>
                        ");
            EndContext();
            BeginContext(582, 44, false);
#line 23 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(626, 76, true);
            WriteLiteral("\n                    </dt>\n                    <dd>\n                        ");
            EndContext();
            BeginContext(703, 40, false);
#line 26 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(743, 76, true);
            WriteLiteral("\n                    </dd>\n                    <dt>\n                        ");
            EndContext();
            BeginContext(820, 41, false);
#line 29 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(861, 76, true);
            WriteLiteral("\n                    </dt>\n                    <dd>\n                        ");
            EndContext();
            BeginContext(938, 37, false);
#line 32 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(975, 76, true);
            WriteLiteral("\n                    </dd>\n                    <dt>\n                        ");
            EndContext();
            BeginContext(1052, 41, false);
#line 35 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 76, true);
            WriteLiteral("\n                    </dt>\n                    <dd>\n                        ");
            EndContext();
            BeginContext(1170, 43, false);
#line 38 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Roles.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 170, true);
            WriteLiteral("\n                    </dd>\n                </dl>\n\n                <form method=\"post\" action=\"/Admins/DeleteConfirmed\">\n                    <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1383, "\"", 1400, 1);
#line 43 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Delete.cshtml"
WriteAttributeValue("", 1391, Model.Id, 1391, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1401, 166, true);
            WriteLiteral(" />\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" />\n                </form>\n            </div>\n        </div>\n    </div>\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.Admins> Html { get; private set; }
    }
}
#pragma warning restore 1591
