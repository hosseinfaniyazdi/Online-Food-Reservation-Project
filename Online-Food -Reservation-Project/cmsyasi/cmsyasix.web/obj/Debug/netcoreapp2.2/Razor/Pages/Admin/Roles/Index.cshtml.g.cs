#pragma checksum "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4450af84d47afedcc98f1d682ca1f9df76bf8737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/Index.cshtml", typeof(AspNetCore.Pages_Admin_Roles_Index), null)]
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
#line 2 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml"
using cmsyasix.Core.Convertors;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4450af84d47afedcc98f1d682ca1f9df76bf8737", @"/Pages/Admin/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml"
  
    ViewData["Title"] = "لیست نقش ها";

#line default
#line hidden
            BeginContext(137, 672, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست نقش ها</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست نقش های سایت
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""col-md-12"" style=""margin: 10px 0;"">

                            ");
            EndContext();
            BeginContext(809, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4450af84d47afedcc98f1d682ca1f9df76bf87374633", async() => {
                BeginContext(870, 15, true);
                WriteLiteral("افزودن نقش جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(889, 510, true);
            WriteLiteral(@"

                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr>
                                    <th>عنوان نقش</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 38 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml"
                                 foreach (var role in Model.RolesList)
                                {

#line default
#line hidden
            BeginContext(1506, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1593, 14, false);
#line 41 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml"
                                       Write(role.RoleTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1607, 99, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1706, "\"", 1747, 2);
            WriteAttributeValue("", 1713, "/Admin/Roles/EditRole/", 1713, 22, true);
#line 43 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 1735, role.RoleId, 1735, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1748, 186, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                                ویرایش\r\n                                            </a>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1934, "\"", 1977, 2);
            WriteAttributeValue("", 1941, "/Admin/Roles/DeleteRole/", 1941, 24, true);
#line 46 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 1965, role.RoleId, 1965, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1978, 226, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                                                حذف\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 51 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2239, 267, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cmsyasix.web.Pages.Admin.Roles.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<cmsyasix.web.Pages.Admin.Roles.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<cmsyasix.web.Pages.Admin.Roles.IndexModel>)PageContext?.ViewData;
        public cmsyasix.web.Pages.Admin.Roles.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591