#pragma checksum "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0b073cf3a6f0644d59431c5f86ae5878b679f16"
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
#line 1 "C:\Users\Ognjen\source\repos\GRM_Task\Views\_ViewImports.cshtml"
using GRM_Task;

#line default
#line hidden
#line 2 "C:\Users\Ognjen\source\repos\GRM_Task\Views\_ViewImports.cshtml"
using GRM_Task.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b073cf3a6f0644d59431c5f86ae5878b679f16", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be0a56884bda184155f371d3dc72910c68aaa4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GRM_Task.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Items Comparing";

#line default
#line hidden
            BeginContext(94, 102, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h2>");
            EndContext();
            BeginContext(197, 17, false);
#line 9 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(214, 45, true);
            WriteLiteral("</h2>\r\n            <p>Number Of Combinations ");
            EndContext();
            BeginContext(260, 28, false);
#line 10 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                                 Write(ViewData["CombinationCount"]);

#line default
#line hidden
            EndContext();
            BeginContext(288, 312, true);
            WriteLiteral(@"</p>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead class=""bg-light"">
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(601, 44, false);
#line 20 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(645, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(749, 40, false);
#line 23 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(789, 122, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th class=\"text-right\">\r\n                                ");
            EndContext();
            BeginContext(912, 41, false);
#line 26 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
            EndContext();
            BeginContext(953, 127, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1161, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1270, 43, false);
#line 35 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1429, 39, false);
#line 38 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 134, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-right\">\r\n                                    ");
            EndContext();
            BeginContext(1603, 40, false);
#line 41 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 44 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1746, 302, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <hr />
    <div class=""row"">
        <div class=""col-12"">
            <button class=""btn btn-primary"" type=""button"" id=""btnStartCompare"">Start Comparing</button>
        </div>
    </div>
");
            EndContext();
#line 56 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
     if ((int)ViewData["CombinationCount"] != 0)
    {

#line default
#line hidden
            BeginContext(2105, 150, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div id=\"itemComparePartial\"></div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 63 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2262, 176, true);
            WriteLiteral("</div>\r\n\r\n<script>\r\n    document.getElementById(\"btnStartCompare\").onclick = function () { myFunction() };\r\n    function myFunction() {\r\n        $(\"#itemComparePartial\").load(\'");
            EndContext();
            BeginContext(2439, 45, false);
#line 69 "C:\Users\Ognjen\source\repos\GRM_Task\Views\Home\Index.cshtml"
                                  Write(Url.Action("ItemsComparePartialView", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(2484, 23, true);
            WriteLiteral("\');\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GRM_Task.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
