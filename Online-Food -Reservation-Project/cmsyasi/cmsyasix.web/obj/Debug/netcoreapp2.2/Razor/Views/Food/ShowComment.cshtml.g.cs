#pragma checksum "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4dad0013c9dd208836ef42dec8c04d0898dbed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_ShowComment), @"mvc.1.0.view", @"/Views/Food/ShowComment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/ShowComment.cshtml", typeof(AspNetCore.Views_Food_ShowComment))]
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
#line 1 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
using cmsyasix.Core.Convertors;

#line default
#line hidden
#line 2 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
using cmsyasix.Data.Entities.Food;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4dad0013c9dd208836ef42dec8c04d0898dbed", @"/Views/Food/ShowComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_ShowComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<cmsyasix.Data.Entities.Food.FoodComment>, int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(164, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
 foreach (var item in Model.Item1)
{

#line default
#line hidden
            BeginContext(205, 61, true);
            WriteLiteral("    <!-- row -->\r\n    <div class=\"comment-row\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 266, "\"", 305, 2);
            WriteAttributeValue("", 272, "/UserAvatar/", 272, 12, true);
#line 13 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
WriteAttributeValue("", 284, item.User.UserAvatar, 284, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(306, 52, true);
            WriteLiteral(">\r\n        <div class=\"left-col\">\r\n            <h3> ");
            EndContext();
            BeginContext(359, 18, false);
#line 15 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
            Write(item.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(377, 26, true);
            WriteLiteral(" </h3>\r\n            <span>");
            EndContext();
            BeginContext(404, 26, false);
#line 16 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
             Write(item.CreateDate.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(430, 42, true);
            WriteLiteral("</span>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(473, 12, false);
#line 18 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
           Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(485, 67, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n    <!-- /row -->\r\n");
            EndContext();
#line 23 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
}

#line default
#line hidden
            BeginContext(555, 92, true);
            WriteLiteral("\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n\r\n");
            EndContext();
#line 28 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
         for (int i = 1; i <= Model.Item2; i++)
        {

#line default
#line hidden
            BeginContext(707, 54, true);
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 761, "\"", 786, 3);
            WriteAttributeValue("", 771, "pageComment(", 771, 12, true);
#line 30 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
WriteAttributeValue("", 783, i, 783, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 785, ")", 785, 1, true);
            EndWriteAttribute();
            BeginContext(787, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(789, 1, false);
#line 30 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
                                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(790, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 31 "C:\Users\hossein\source\repos\cmsyasix\cmsyasix.web\Views\Food\ShowComment.cshtml"
        }

#line default
#line hidden
            BeginContext(812, 23, true);
            WriteLiteral("\r\n    </ul>\r\n</nav>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<cmsyasix.Data.Entities.Food.FoodComment>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591