#pragma checksum "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "008e5f7c6fff7c9ec5312d437dd44c7aaefbec53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/Index.cshtml", typeof(AspNetCore.Views_Team_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"008e5f7c6fff7c9ec5312d437dd44c7aaefbec53", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspnetfirst.Models.Teams.Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "teams";

#line default
#line hidden
            BeginContext(96, 165, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n<table class=\"table is-bordered is-striped is-narrow is-hoverable is-fullwidth\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(262, 42, false);
#line 15 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 40, false);
#line 18 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(400, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(456, 47, false);
#line 21 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(503, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(559, 41, false);
#line 24 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Coach));

#line default
#line hidden
            EndContext();
            BeginContext(600, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(656, 46, false);
#line 27 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalSkill));

#line default
#line hidden
            EndContext();
            BeginContext(702, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(758, 51, false);
#line 30 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalExperience));

#line default
#line hidden
            EndContext();
            BeginContext(809, 65, true);
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(923, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(984, 41, false);
#line 40 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1093, 39, false);
#line 43 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1200, 46, false);
#line 46 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1314, 40, false);
#line 49 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Coach));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1422, 45, false);
#line 52 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalSkill));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1535, 50, false);
#line 55 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalExperience));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Ali\source\repos\aspnetfirst\aspnetfirst\Views\Team\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1640, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspnetfirst.Models.Teams.Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591