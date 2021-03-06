#pragma checksum "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ddb29a73eceb0d6b37c9ed5e97fbb2035077af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ddb29a73eceb0d6b37c9ed5e97fbb2035077af6", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 569, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        Dashboard
        <small>Control panel</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li class=""active"">Dashboard</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <!-- Small boxes (Stat box) -->
    <div class=""row"">
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-aqua"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(631, 19, false);
#line 21 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Home\Index.cshtml"
                   Write(Model.doctors_count);

#line default
#line hidden
            EndContext();
            BeginContext(650, 532, true);
            WriteLiteral(@"</h3>
                    <p>Doctors</p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-users""></i>
                </div>
                <a href=""/Doctors"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-green"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(1183, 18, false);
#line 35 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Home\Index.cshtml"
                   Write(Model.admins_count);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 566, true);
            WriteLiteral(@"<sup style=""font-size: 20px""></sup></h3>
                    <p>Admins</p>
                </div>
                <div class=""icon"">
                    <i class=""fa fa-users""></i>
                </div>
                <a href=""/Admins"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-yellow"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(1768, 17, false);
#line 49 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Home\Index.cshtml"
                   Write(Model.roles_count);

#line default
#line hidden
            EndContext();
            BeginContext(1785, 3122, true);
            WriteLiteral(@"</h3>
                    <p>Roles</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-person""></i>
                </div>
                <a href=""/Roles"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-red"">
                <div class=""inner"">
                    <h3>65</h3>
                    <p>This Month</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-pie-graph""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
    </div>
    <!-- /.row -->
    <!-- Main row -->
    <div class=""row"">
        <!-- Left col -->
        <section class=""col-lg-7 c");
            WriteLiteral(@"onnectedSortable"">
            <!-- Custom tabs (Charts with tabs)-->
            <!-- DONUT CHART -->
            <div class=""box box-danger"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Statistics</h3>
                    <div class=""box-tools pull-right"">
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                            <i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                    </div>
                </div>
                <div class=""box-body chart-responsive"">
                    <div class=""chart"" id=""sales-chart"" style=""height: 300px; position: relative;""></div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.nav-tabs-custom -->
        </section>
        <!-- /.Left col -->
   ");
            WriteLiteral(@"     <!-- right col (We are only adding the ID to make the widgets sortable)-->
        <section class=""col-lg-5 connectedSortable"">
            <!-- TO DO List -->
            <div class=""box box-primary"">
                <div class=""box-header"">
                    <i class=""ion ion-clipboard""></i>
                    <h3 class=""box-title"">To Do List</h3>
                    <div class=""box-tools pull-right"">
                        <ul class=""pagination pagination-sm inline"">
                            <li><a href=""#"">«</a></li>
                            <li><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a href=""#"">»</a></li>
                        </ul>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <!-- See dist/js/pages/dashboard.js to activate the todoList plugin -");
            WriteLiteral("->\r\n                    <ul class=\"todo-list\">\r\n\r\n");
            EndContext();
            BeginContext(5695, 3801, true);
            WriteLiteral(@"                        <li>
                            <span class=""handle"">
                                <i class=""fa fa-ellipsis-v""></i>
                                <i class=""fa fa-ellipsis-v""></i>
                            </span>
                            <input type=""checkbox"" value="""">
                            <span class=""text"">New Admin Operation</span>
                            <small class=""label label-warning""><i class=""fa fa-clock-o""></i> 1 day</small>
                            <div class=""tools"">
                                <i class=""fa fa-edit""></i>
                                <i class=""fa fa-trash-o""></i>
                            </div>
                        </li>
                        <li>
                            <span class=""handle"">
                                <i class=""fa fa-ellipsis-v""></i>
                                <i class=""fa fa-ellipsis-v""></i>
                            </span>
                            <input type=");
            WriteLiteral(@"""checkbox"" value="""">
                            <span class=""text"">Ward Visit</span>
                            <small class=""label label-success""><i class=""fa fa-clock-o""></i> 3 days</small>
                            <div class=""tools"">
                                <i class=""fa fa-edit""></i>
                                <i class=""fa fa-trash-o""></i>
                            </div>
                        </li>
                        <li>
                            <span class=""handle"">
                                <i class=""fa fa-ellipsis-v""></i>
                                <i class=""fa fa-ellipsis-v""></i>
                            </span>
                            <input type=""checkbox"" value="""">
                            <span class=""text"">Any other Activity</span>
                            <small class=""label label-primary""><i class=""fa fa-clock-o""></i> 1 week</small>
                            <div class=""tools"">
                                <i class=""fa");
            WriteLiteral(@" fa-edit""></i>
                                <i class=""fa fa-trash-o""></i>
                            </div>
                        </li>
                        <li>
                            <span class=""handle"">
                                <i class=""fa fa-ellipsis-v""></i>
                                <i class=""fa fa-ellipsis-v""></i>
                            </span>
                            <input type=""checkbox"" value="""">
                            <span class=""text"">Any other Activity</span>
                            <small class=""label label-default""><i class=""fa fa-clock-o""></i> 1 month</small>
                            <div class=""tools"">
                                <i class=""fa fa-edit""></i>
                                <i class=""fa fa-trash-o""></i>
                            </div>
                        </li>
                    </ul>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer clearfix no-bord");
            WriteLiteral(@"er"">
                    <button type=""button"" class=""btn btn-default pull-right""><i class=""fa fa-plus""></i> Add item</button>
                </div>
            </div>
            <!-- /.box -->
        </section>
        <!-- right col -->
    </div>
    <!-- /.row (main row) -->
</section>

<!-- Morris.js charts -->
<script src=""bower_components/raphael/raphael.min.js""></script>
<script src=""bower_components/morris.js/morris.min.js""></script>
<script>
  $(function () {
    ""use strict"";
    //DONUT CHART
    var donut = new Morris.Donut({
      element: 'sales-chart',
      resize: true,
      colors: [""#3c8dbc"", ""#f56954"", ""#00a65a""],
      data: [
        {label: ""Registered Doctors"", value: ");
            EndContext();
            BeginContext(9497, 19, false);
#line 212 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Home\Index.cshtml"
                                        Write(Model.doctors_count);

#line default
#line hidden
            EndContext();
            BeginContext(9516, 48, true);
            WriteLiteral("},\r\n        {label: \"Registered Admins\", value: ");
            EndContext();
            BeginContext(9565, 18, false);
#line 213 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Home\Index.cshtml"
                                       Write(Model.admins_count);

#line default
#line hidden
            EndContext();
            BeginContext(9583, 47, true);
            WriteLiteral("},\r\n        {label: \"Registered Roles\", value: ");
            EndContext();
            BeginContext(9631, 17, false);
#line 214 "D:\Projet 2020\Version Intial PFE\AdminPanel\AdminPanel\Views\Home\Index.cshtml"
                                      Write(Model.roles_count);

#line default
#line hidden
            EndContext();
            BeginContext(9648, 65, true);
            WriteLiteral("}\r\n      ],\r\n      hideHover: \'auto\'\r\n    });\r\n  });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
