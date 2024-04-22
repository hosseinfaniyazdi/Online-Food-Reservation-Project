#pragma checksum "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9243f37951b9f8a09e434cd5a61c767ea8a60301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_CreateRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/CreateRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/CreateRole.cshtml", typeof(AspNetCore.Pages_Admin_Roles_CreateRole), null)]
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
#line 2 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
using cmsyasix.Data.Entities.Permission;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9243f37951b9f8a09e434cd5a61c767ea8a60301", @"/Pages/Admin/Roles/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_CreateRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
  
    ViewData["Title"] = "افزودن نقش";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
            BeginContext(231, 177, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">افزودن نقش جدید</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(408, 3065, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9243f37951b9f8a09e434cd5a61c767ea8a603015184", async() => {
                BeginContext(458, 379, true);
                WriteLiteral(@"
        <div class=""col-md-8"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                    نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label>عنوان نقش</label>
                        ");
                EndContext();
                BeginContext(837, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9243f37951b9f8a09e434cd5a61c767ea8a603015953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitle);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(902, 514, true);
                WriteLiteral(@"
                    </div>
                    <input type=""submit"" value=""ذخیره اطلاعات"" class=""btn btn-success"" />
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    دسترسی های نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <ul>
");
                EndContext();
#line 43 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                         foreach (var item in permissions.Where(p => p.ParentID == null))
                        {

#line default
#line hidden
                BeginContext(1534, 114, true);
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1648, "\"", 1674, 1);
#line 46 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 1656, item.PermissionId, 1656, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1675, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(1679, 20, false);
#line 46 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                         Write(item.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1699, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                 if (permissions.Any(p => p.ParentID == item.PermissionId))
                                {

#line default
#line hidden
                BeginContext(1829, 42, true);
                WriteLiteral("                                    <ul>\r\n");
                EndContext();
#line 50 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                         foreach (var sub in permissions.Where(p => p.ParentID == item.PermissionId))
                                        {

#line default
#line hidden
                BeginContext(2033, 146, true);
                WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2179, "\"", 2204, 1);
#line 53 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2187, sub.PermissionId, 2187, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2205, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(2209, 19, false);
#line 53 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                        Write(sub.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2228, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 54 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                 if (permissions.Any(p => p.ParentID == sub.PermissionId))
                                                {

#line default
#line hidden
                BeginContext(2389, 58, true);
                WriteLiteral("                                                    <ul>\r\n");
                EndContext();
#line 57 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                         foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionId))
                                                        {

#line default
#line hidden
                BeginContext(2641, 170, true);
                WriteLiteral("                                                        <li>\r\n                                                            <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2811, "\"", 2837, 1);
#line 60 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2819, sub2.PermissionId, 2819, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2838, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(2842, 20, false);
#line 60 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                     Write(sub2.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2862, 67, true);
                WriteLiteral("\r\n\r\n                                                        </li>\r\n");
                EndContext();
#line 63 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(2988, 59, true);
                WriteLiteral("                                                    </ul>\r\n");
                EndContext();
#line 65 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                }

#line default
#line hidden
                BeginContext(3098, 51, true);
                WriteLiteral("                                            </li>\r\n");
                EndContext();
#line 67 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                        }

#line default
#line hidden
                BeginContext(3192, 43, true);
                WriteLiteral("                                    </ul>\r\n");
                EndContext();
#line 69 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                                }

#line default
#line hidden
                BeginContext(3270, 35, true);
                WriteLiteral("                            </li>\r\n");
                EndContext();
#line 71 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Pages\Admin\Roles\CreateRole.cshtml"
                        }

#line default
#line hidden
                BeginContext(3332, 134, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3473, 18, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cmsyasix.web.Pages.Admin.Roles.CreateRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<cmsyasix.web.Pages.Admin.Roles.CreateRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<cmsyasix.web.Pages.Admin.Roles.CreateRoleModel>)PageContext?.ViewData;
        public cmsyasix.web.Pages.Admin.Roles.CreateRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
