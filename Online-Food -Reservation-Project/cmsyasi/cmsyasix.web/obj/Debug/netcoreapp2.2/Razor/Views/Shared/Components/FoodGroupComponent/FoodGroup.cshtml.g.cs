#pragma checksum "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "647e8fa53de6172fd2c8245b3d4e9a548b555410"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FoodGroupComponent_FoodGroup), @"mvc.1.0.view", @"/Views/Shared/Components/FoodGroupComponent/FoodGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/FoodGroupComponent/FoodGroup.cshtml", typeof(AspNetCore.Views_Shared_Components_FoodGroupComponent_FoodGroup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647e8fa53de6172fd2c8245b3d4e9a548b555410", @"/Views/Shared/Components/FoodGroupComponent/FoodGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FoodGroupComponent_FoodGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cmsyasix.Data.Entities.Food.FoodGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 168, true);
            WriteLiteral("<div class=\"main-menu\">\r\n    <div class=\"container\">\r\n        <nav>\r\n            <span class=\"responsive-sign\"><i class=\"zmdi zmdi-menu\"></i></span>\r\n            <ul>\r\n");
            EndContext();
#line 7 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                 foreach (var group in Model.Where(g => g.ParentId == null))
                {

#line default
#line hidden
            BeginContext(324, 52, true);
            WriteLiteral("                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 376, "\"", 418, 2);
            WriteAttributeValue("", 383, "/food?selectedgroups=", 383, 21, true);
#line 10 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
WriteAttributeValue("", 404, group.GroupId, 404, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(422, 16, false);
#line 10 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                                                                  Write(group.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(438, 7, true);
            WriteLiteral(" </a>\r\n");
            EndContext();
#line 11 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                         if (Model.Any(g => g.ParentId == group.GroupId))
                        {

#line default
#line hidden
            BeginContext(547, 34, true);
            WriteLiteral("                            <ul>\r\n");
            EndContext();
#line 14 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                                 foreach (var sub in Model.Where(g => g.ParentId == group.GroupId))
                                {

#line default
#line hidden
            BeginContext(717, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 759, "\"", 799, 2);
            WriteAttributeValue("", 766, "/food?selectedgroups=", 766, 21, true);
#line 16 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
WriteAttributeValue("", 787, sub.GroupId, 787, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(800, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(803, 14, false);
#line 16 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                                                                                Write(sub.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(817, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 17 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                                }

#line default
#line hidden
            BeginContext(864, 35, true);
            WriteLiteral("                            </ul>\r\n");
            EndContext();
#line 19 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                        }

#line default
#line hidden
            BeginContext(926, 27, true);
            WriteLiteral("                    </li>\r\n");
            EndContext();
#line 21 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Shared\Components\FoodGroupComponent\FoodGroup.cshtml"
                }

#line default
#line hidden
            BeginContext(972, 55, true);
            WriteLiteral("\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cmsyasix.Data.Entities.Food.FoodGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591