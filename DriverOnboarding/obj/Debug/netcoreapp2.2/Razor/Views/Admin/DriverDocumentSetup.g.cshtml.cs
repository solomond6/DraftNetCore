#pragma checksum "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd74abffaf2644be84ef9cd8b6e7f6ac01f8715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DriverDocumentSetup), @"mvc.1.0.view", @"/Views/Admin/DriverDocumentSetup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DriverDocumentSetup.cshtml", typeof(AspNetCore.Views_Admin_DriverDocumentSetup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd74abffaf2644be84ef9cd8b6e7f6ac01f8715", @"/Views/Admin/DriverDocumentSetup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c636c00436f8ccba5b0958541652b1ee009d4f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DriverDocumentSetup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Mandatory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Optional", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateDriverDocumentSetup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 171, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"card-title\">Driver Doc.</h3>\r\n    </div>\r\n    <!-- /.card-header -->\r\n    <div class=\"card-body\">\r\n");
            EndContext();
#line 13 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
         if (TempData["ErrorMsg"] != null)
        {

#line default
#line hidden
            BeginContext(316, 46, true);
            WriteLiteral("            <alert class=\"alert alert-danger\">");
            EndContext();
            BeginContext(363, 20, false);
#line 15 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
                                         Write(TempData["ErrorMsg"]);

#line default
#line hidden
            EndContext();
            BeginContext(383, 10, true);
            WriteLiteral("</alert>\r\n");
            EndContext();
#line 16 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
        }

#line default
#line hidden
            BeginContext(404, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 17 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
         if (TempData["SuccessMsg"] != null)
        {

#line default
#line hidden
            BeginContext(461, 47, true);
            WriteLiteral("            <alert class=\"alert alert-success\">");
            EndContext();
            BeginContext(509, 22, false);
#line 19 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
                                          Write(TempData["SuccessMsg"]);

#line default
#line hidden
            EndContext();
            BeginContext(531, 10, true);
            WriteLiteral("</alert>\r\n");
            EndContext();
#line 20 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
        }

#line default
#line hidden
            BeginContext(552, 940, true);
            WriteLiteral(@"        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Document Name</th>
                    <th>Document Type</th>
                    <th>Mandatory</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
    <!-- /.card-body -->
</div>
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Edit Document</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(1492, 1694, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd74abffaf2644be84ef9cd8b6e7f6ac01f87158970", async() => {
                BeginContext(1574, 1026, true);
                WriteLiteral(@"
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Document Name</label>
                            <input type=""hidden"" class=""form-control paramsId"" name=""id"" id=""paramsId"">
                            <input type=""text"" class=""form-control docName"" name=""docName"" id=""docName"" placeholder=""Enter Scheme"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Document Type</label>
                            <input type=""text"" class=""form-control docType"" name=""docType"" id=""docType"" placeholder=""Enter Scheme"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Required Statues</label>
                            <select class=""form-control docStatus"" name=""docStatus"" id=""docStatus"" required>
                              ");
                WriteLiteral("  ");
                EndContext();
                BeginContext(2600, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd74abffaf2644be84ef9cd8b6e7f6ac01f871510462", async() => {
                    BeginContext(2617, 13, true);
                    WriteLiteral("Select Option");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2639, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2673, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd74abffaf2644be84ef9cd8b6e7f6ac01f871511968", async() => {
                    BeginContext(2699, 9, true);
                    WriteLiteral("Mandatory");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2717, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2751, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dd74abffaf2644be84ef9cd8b6e7f6ac01f871513469", async() => {
                    BeginContext(2776, 8, true);
                    WriteLiteral("Optional");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2793, 386, true);
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <div class=""card-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3186, 503, true);
            WriteLiteral(@"
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
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
            BeginContext(3690, 45, false);
#line 90 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Admin\DriverDocumentSetup.cshtml"
                   Write(Url.Action("GetDriverDocumentSetup", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(3735, 1372, true);
            WriteLiteral(@""",
                ""type"": ""GET""
            },
            ""columns"": [
                { ""data"": ""id"" },
                { ""data"": ""docName"" },
                { ""data"": ""docType"" },
                { ""data"": ""docStatus"" },
                {}
            ],
            columnDefs: [
            {
                ""searchable"": false,
                ""orderable"": false,
                ""targets"": -1
            },{
                ""data"": null,
                ""defaultContent"": """",
                ""targets"": -1
            },
            { targets : [4],
                mRender: function (data, type, row, meta) {
                    return '<button class=""btn btn-danger updateBtn"" id=""activeBtn"" data-pid=""' + row.id + '"" data-doctype=""' + row.docType + '"" data-docname=""' + row.docName + '""data-statusid=""1"" data-toggle=""modal"" data-target=""#modal-default"">Edit</button>';
                }
            }
            ],
            ""lengthMenu"": [[50, 100, 150, 200], [50, 100, 150, 200]]");
            WriteLiteral(@",
        });
    });

    $(document).on('click', '.updateBtn', function () {
        var pid = $(this).data('pid');
        var docType = $(this).data('doctype');
        var docName = $(this).data('docname');

        $(""#paramsId"").val(pid);
        $(""#docName"").val(docName);
        $(""#docType"").val(docType);
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
