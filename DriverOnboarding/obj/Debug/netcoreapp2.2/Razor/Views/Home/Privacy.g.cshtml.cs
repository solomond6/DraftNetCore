#pragma checksum "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02719090cf3e5d9d86b0caffdae993fb7c7be637"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02719090cf3e5d9d86b0caffdae993fb7c7be637", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c636c00436f8ccba5b0958541652b1ee009d4f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "New Driver";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(93, 1477, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <!-- Left col -->
        <section class=""col-lg-12 connectedSortable"">
            <!-- Custom tabs (Charts with tabs)-->
            <div class=""card"">
                <div class=""card-header"">
                    <h3 class=""card-title"">
                        <i class=""fas fa-chart-pie mr-1""></i>
                        New Driver
                    </h3>
                </div><!-- /.card-header -->
                <div class=""card-body"">
                    <div class=""stepwizard"">
                        <div class=""stepwizard-row setup-panel"">
                            <div class=""stepwizard-step"">
                                <a href=""#step-1"" type=""button"" class=""btn btn-primary btn-circle"">1</a>
                                <p>Step 1</p>
                            </div>
                            <div class=""stepwizard-step"">
                                <a href=""#step-2"" type=""button"" class=""btn btn-def");
            WriteLiteral(@"ault btn-circle disabled"">2</a>
                                <p>Step 2</p>
                            </div>
                            <div class=""stepwizard-step"">
                                <a href=""#step-3"" type=""button"" class=""btn btn-default btn-circle disabled"">3</a>
                                <p>Step 3</p>
                            </div>
                        </div>
                    </div>
                    ");
            EndContext();
            BeginContext(1570, 2894, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02719090cf3e5d9d86b0caffdae993fb7c7be6375855", async() => {
                BeginContext(1598, 2859, true);
                WriteLiteral(@"
                        <div class=""setup-content"" id=""step-1"">
                            <div class=""col-xs-12"">
                                <div class=""col-md-11"">
                                    <h3> Step 1</h3>
                                    <div class=""form-group"">
                                        <label class=""control-label"">Email</label>
                                        <input maxlength=""100"" type=""email"" required class=""form-control"" placeholder=""Enter Email Address"" id=""firstName"" />
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""control-label"">Last Name</label>
                                        <input maxlength=""100"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Last Name"" />
                                    </div>
                                    <button class=""btn btn-primary nextBtn pull-right"" type=""button""");
                WriteLiteral(@">Next</button>
                                </div>
                            </div>
                        </div>
                        <div class=""setup-content"" id=""step-2"">
                            <div class=""col-xs-12"">
                                <div class=""col-md-11"">
                                    <h3> Step 2</h3>
                                    <div class=""form-group"">
                                        <label class=""control-label"">Company Name</label>
                                        <input maxlength=""200"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Company Name"" />
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""control-label"">Company Address</label>
                                        <input maxlength=""200"" type=""text"" class=""form-control"" placeholder=""Enter Company Address"" />
                             ");
                WriteLiteral(@"       </div>
                                    <button class=""btn btn-primary nextBtn pull-right"" type=""button"">Next</button>
                                </div>
                            </div>
                        </div>
                        <div class=""setup-content"" id=""step-3"">
                            <div class=""col-xs-12"">
                                <div class=""col-md-11"">
                                    <h3> Step 3</h3>
                                    <p>Take a moment to review the form, and edit any information.</p>
                                    <button class=""btn btn-success pull-right"" type=""submit"">Finish!</button>
                                </div>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4464, 100, true);
            WriteLiteral("\r\n                </div><!-- /.card-body -->\r\n            </div>\r\n        </section>\r\n    </div>\r\n\r\n");
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
