#pragma checksum "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\Countries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd964fa94445bee2de4e705873d0940d32b6eda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Countries), @"mvc.1.0.view", @"/Views/Admin/Countries.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Countries.cshtml", typeof(AspNetCore.Views_Admin_Countries))]
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
#line 1 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\_ViewImports.cshtml"
using DriverOnboarding;

#line default
#line hidden
#line 2 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\_ViewImports.cshtml"
using DriverOnboarding.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd964fa94445bee2de4e705873d0940d32b6eda", @"/Views/Admin/Countries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c636c00436f8ccba5b0958541652b1ee009d4f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Countries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\Countries.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 169, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"card-title\">Countries</h3>\r\n    </div>\r\n    <!-- /.card-header -->\r\n    <div class=\"card-body\">\r\n");
            EndContext();
#line 13 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\Countries.cshtml"
         if (TempData["ErrorMsg"] != null)
        {

#line default
#line hidden
            BeginContext(314, 46, true);
            WriteLiteral("            <alert class=\"alert alert-danger\">");
            EndContext();
            BeginContext(361, 20, false);
#line 15 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\Countries.cshtml"
                                         Write(TempData["ErrorMsg"]);

#line default
#line hidden
            EndContext();
            BeginContext(381, 10, true);
            WriteLiteral("</alert>\r\n");
            EndContext();
#line 16 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\Countries.cshtml"
        }

#line default
#line hidden
            BeginContext(402, 721, true);
            WriteLiteral(@"        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
    <!-- /.card-body -->
</div>

<script>
    $(document).ready(function() {
        $('#example1').dataTable( {
            ""processing"": true,
            ""serverSide"": true,
            ""paging"": true,
            ""ordering"": true,
            ""info"": true,
            ""autoWidth"": false,
            ""responsive"": true,
            ""datatype"": ""json"",
            ""ajax"": {
                ""url"": """);
            EndContext();
            BeginContext(1124, 35, false);
#line 43 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\Countries.cshtml"
                   Write(Url.Action("GetCountries", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 273, true);
            WriteLiteral(@""",
                ""type"": ""GET""
            },
            ""columns"": [
                { ""data"": ""id"" },
                { ""data"": ""countryName"" },
            ],
           ""lengthMenu"": [[50, 100, 150, 200], [50, 100, 150, 200]],
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
