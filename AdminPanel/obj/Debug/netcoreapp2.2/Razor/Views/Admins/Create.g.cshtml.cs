#pragma checksum "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53649a9fea2c506c99fb269529ad36d328862c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Create), @"mvc.1.0.view", @"/Views/Admins/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Create.cshtml", typeof(AspNetCore.Views_Admins_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53649a9fea2c506c99fb269529ad36d328862c35", @"/Views/Admins/Create.cshtml")]
    public class Views_Admins_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Admins>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Create.cshtml"
  
    ViewData["Title"] = "Create Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 89, true);
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
            EndContext();
            BeginContext(226, 17, false);
#line 11 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Create.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(243, 1590, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <!-- general form elements -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Add New Admin</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/Admins/Create"">
                    <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Full Name</label>
                            <input type=""text"" class=""form-control"" id=""FullName"" name=""FullName"" placeholder=""Enter Full Name"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Email</label>
                            <input typ");
            WriteLiteral(@"e=""email"" class=""form-control"" id=""Email"" name=""Email"" placeholder=""Enter Email"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Password</label>
                            <input type=""password"" class=""form-control"" id=""Password"" name=""Password"" placeholder=""Enter Password"">
                        </div>
                        <div class=""form-group"">
                            <label asp-for=""RolesId"" class=""control-label""></label>
                            ");
            EndContext();
            BeginContext(1834, 83, false);
#line 42 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Admins\Create.cshtml"
                       Write(Html.DropDownList("RolesId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 364, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                </form>
            </div>
            <!-- /.box -->
        </div>
    </div>
</section>
");
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