#pragma checksum "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c0868d7fa8578134d9e012c264fbbde711144ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Index), @"mvc.1.0.view", @"/Views/Patients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/Index.cshtml", typeof(AspNetCore.Views_Patients_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c0868d7fa8578134d9e012c264fbbde711144ba", @"/Views/Patients/Index.cshtml")]
    public class Views_Patients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminPanel.Models.Patients>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
  
    ViewData["Title"] = "Patients";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(267, 93, true);
            WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(361, 17, false);
#line 11 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(378, 915, true);
            WriteLiteral(@"
    </h1>
</section>

<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Patients Table</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example2"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>FirstName</th>
                                <th>LastName</th>
                                <th>Phone</th>
                                <th></th>

                            </tr>
                        </thead>
                        <tbody>
                        <tbody>
");
            EndContext();
#line 38 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1382, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1503, 37, false);
#line 42 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1668, 44, false);
#line 45 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1840, 43, false);
#line 48 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2011, 40, false);
#line 51 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2180, "\"", 2212, 2);
            WriteAttributeValue("", 2187, "/Patients/Update/", 2187, 17, true);
#line 54 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
WriteAttributeValue("", 2204, item.Id, 2204, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2213, 57, true);
            WriteLiteral(">Update</a> |\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2270, "\"", 2302, 2);
            WriteAttributeValue("", 2277, "/Patients/Delete/", 2277, 17, true);
#line 55 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
WriteAttributeValue("", 2294, item.Id, 2294, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2303, 95, true);
            WriteLiteral(">Delete</a>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 58 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Patients\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2429, 432, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>
<script>
    $(function () {
        $('#example2').DataTable({
            'paging': true,
            'lengthChange': true,
            'searching': true,
            'ordering': true,
            'info': true,
            'autoWidth': false
        })
    })</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminPanel.Models.Patients>> Html { get; private set; }
    }
}
#pragma warning restore 1591
