#pragma checksum "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35a9c8d1057660790f86febef256445705623145"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drivers_Details), @"mvc.1.0.view", @"/Views/Drivers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Drivers/Details.cshtml", typeof(AspNetCore.Views_Drivers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a9c8d1057660790f86febef256445705623145", @"/Views/Drivers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c636c00436f8ccba5b0958541652b1ee009d4f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Drivers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
  var dDetails = ViewBag.DriverDetails; 

#line default
#line hidden
#line 8 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
  var dPassport = ViewBag.DriverPassport; 

#line default
#line hidden
            BeginContext(180, 225, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n\r\n        <!-- Profile Image -->\r\n        <div class=\"card card-primary card-outline\">\r\n            <div class=\"card-body box-profile\">\r\n                <div class=\"text-left\">\r\n");
            EndContext();
#line 16 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                     if (dPassport != null)
                    {
                        var base64 = Convert.ToBase64String(dPassport.PassportData);
                        var imgType = dPassport.ImageType;
                        var imgSrc = String.Format("data:image/" + @imgType + ";base64,{0}", base64);

#line default
#line hidden
            BeginContext(722, 47, true);
            WriteLiteral("                        <img class=\"img-fluid \"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 769, "\"", 782, 1);
#line 21 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
WriteAttributeValue("", 775, imgSrc, 775, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(783, 51, true);
            WriteLiteral(" alt=\"User profile picture\" style=\"width: 100%;\">\r\n");
            EndContext();
#line 22 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(857, 83, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <h3 class=\"profile-username text-left\">");
            EndContext();
            BeginContext(941, 18, false);
#line 26 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                  Write(dDetails.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(959, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(962, 16, false);
#line 26 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                       Write(dDetails.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(978, 104, true);
            WriteLiteral(" </h3>\r\n                <hr />\r\n                <h3 class=\"profile-username text-left\">Uber Name:<small>");
            EndContext();
            BeginContext(1083, 17, false);
#line 28 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                   Write(dDetails.UberName);

#line default
#line hidden
            EndContext();
            BeginContext(1100, 111, true);
            WriteLiteral("</small> </h3>\r\n                <hr />\r\n                <h3 class=\"profile-username text-left\">Uber Id:<small> ");
            EndContext();
            BeginContext(1212, 15, false);
#line 30 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                  Write(dDetails.UberId);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 115, true);
            WriteLiteral(" </small> </h3>\r\n                <hr />\r\n                <h3 class=\"profile-username text-left\">Uber Score:<small> ");
            EndContext();
            BeginContext(1343, 18, false);
#line 32 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                     Write(dDetails.UberScore);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 115, true);
            WriteLiteral("</small> </h3>\r\n                <hr />\r\n                <h3 class=\"profile-username text-left\">Moove Score:<small> ");
            EndContext();
            BeginContext(1477, 14, false);
#line 34 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                      Write(dDetails.Score);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 937, true);
            WriteLiteral(@"</small> </h3>

            </div>
            <!-- /.card-body -->
        </div>
    </div>
    <!-- /.col -->
    <div class=""col-md-9"">
        <div class=""card card-primary card-outline"">
            <div class=""card-header p-2"">
                <ul class=""nav nav-pills"">
                    <li class=""nav-item""><a class=""nav-link active"" href=""#driverdetails"" data-toggle=""tab"">Driver Details</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#guarantordetails"" data-toggle=""tab"">Guarantor Details</a></li>
                </ul>
            </div>
            <div class=""card-body"">
                <div class=""tab-content"">
                    <div class=""active tab-pane"" id=""driverdetails"">
                        <table class=""table table-bordered table-striped"">
                            <tbody>
                                <tr><td class=""text-bold"">Fullname: </td><td>");
            EndContext();
            BeginContext(2429, 18, false);
#line 54 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                        Write(dDetails.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2447, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2449, 16, false);
#line 54 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                            Write(dDetails.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(2465, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2467, 19, false);
#line 54 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                              Write(dDetails.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(2486, 44, true);
            WriteLiteral("</td><td class=\"text-bold\">Gender: </td><td>");
            EndContext();
            BeginContext(2531, 15, false);
#line 54 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                                              Write(dDetails.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(2546, 86, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Email: </td><td>");
            EndContext();
            BeginContext(2633, 14, false);
#line 55 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                     Write(dDetails.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 50, true);
            WriteLiteral("</td><td class=\"text-bold\">Phone Number: </td><td>");
            EndContext();
            BeginContext(2698, 15, false);
#line 55 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                      Write(dDetails.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(2713, 91, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">MaidenName: </td><td>");
            EndContext();
            BeginContext(2805, 19, false);
#line 56 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                          Write(dDetails.MaidenName);

#line default
#line hidden
            EndContext();
            BeginContext(2824, 41, true);
            WriteLiteral("</td><td class=\"text-bold\">BVN: </td><td>");
            EndContext();
            BeginContext(2866, 12, false);
#line 56 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                       Write(dDetails.Bvn);

#line default
#line hidden
            EndContext();
            BeginContext(2878, 102, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Driver License Number: </td><td>");
            EndContext();
            BeginContext(2981, 28, false);
#line 57 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                     Write(dDetails.DriverLicenseNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3009, 64, true);
            WriteLiteral("</td><td class=\"text-bold\">Driver License Expiry Date: </td><td>");
            EndContext();
            BeginContext(3074, 32, false);
#line 57 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                                                  Write(dDetails.DriverLicenseExpiryDate);

#line default
#line hidden
            EndContext();
            BeginContext(3106, 95, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Marital Status: </td><td>");
            EndContext();
            BeginContext(3202, 22, false);
#line 58 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                              Write(dDetails.MaritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(3224, 51, true);
            WriteLiteral("</td><td class=\"text-bold\">Date Of Birth: </td><td>");
            EndContext();
            BeginContext(3276, 20, false);
#line 58 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                        Write(dDetails.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(3296, 89, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Religion: </td><td>");
            EndContext();
            BeginContext(3386, 17, false);
#line 59 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                        Write(dDetails.Religion);

#line default
#line hidden
            EndContext();
            BeginContext(3403, 53, true);
            WriteLiteral("</td><td class=\"text-bold\">State Of Origin: </td><td>");
            EndContext();
            BeginContext(3457, 22, false);
#line 59 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                               Write(dDetails.StateOfOrigin);

#line default
#line hidden
            EndContext();
            BeginContext(3479, 84, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">LGA: </td><td>");
            EndContext();
            BeginContext(3564, 28, false);
#line 60 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                   Write(dDetails.LocalGovernmentArea);

#line default
#line hidden
            EndContext();
            BeginContext(3592, 49, true);
            WriteLiteral("</td><td class=\"text-bold\">Nationality: </td><td>");
            EndContext();
            BeginContext(3642, 20, false);
#line 60 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                 Write(dDetails.Nationality);

#line default
#line hidden
            EndContext();
            BeginContext(3662, 88, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Address: </td><td>");
            EndContext();
            BeginContext(3751, 16, false);
#line 61 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                       Write(dDetails.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3767, 42, true);
            WriteLiteral("</td><td class=\"text-bold\">City: </td><td>");
            EndContext();
            BeginContext(3810, 13, false);
#line 61 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                  Write(dDetails.City);

#line default
#line hidden
            EndContext();
            BeginContext(3823, 86, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">State: </td><td>");
            EndContext();
            BeginContext(3910, 14, false);
#line 62 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                     Write(dDetails.State);

#line default
#line hidden
            EndContext();
            BeginContext(3924, 54, true);
            WriteLiteral("</td><td class=\"text-bold\">LGA Of Residence: </td><td>");
            EndContext();
            BeginContext(3979, 23, false);
#line 62 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                          Write(dDetails.LgaofResidence);

#line default
#line hidden
            EndContext();
            BeginContext(4002, 98, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">LCDA Of Residence: </td><td>");
            EndContext();
            BeginContext(4101, 24, false);
#line 63 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                 Write(dDetails.LcdaofResidence);

#line default
#line hidden
            EndContext();
            BeginContext(4125, 52, true);
            WriteLiteral("</td><td class=\"text-bold\">Postal Address: </td><td>");
            EndContext();
            BeginContext(4178, 22, false);
#line 63 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                              Write(dDetails.PostalAddress);

#line default
#line hidden
            EndContext();
            BeginContext(4200, 97, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Next Of Kin Name: </td><td>");
            EndContext();
            BeginContext(4298, 22, false);
#line 64 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                Write(dDetails.NextOfKinName);

#line default
#line hidden
            EndContext();
            BeginContext(4320, 62, true);
            WriteLiteral("</td><td class=\"text-bold\">Next Of Kin Relationship: </td><td>");
            EndContext();
            BeginContext(4383, 30, false);
#line 64 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                                     Write(dDetails.NextOfKinRelationship);

#line default
#line hidden
            EndContext();
            BeginContext(4413, 101, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Address Of NextOfKin: </td><td>");
            EndContext();
            BeginContext(4515, 27, false);
#line 65 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                    Write(dDetails.AddressOfNextOfKin);

#line default
#line hidden
            EndContext();
            BeginContext(4542, 60, true);
            WriteLiteral("</td><td class=\"text-bold\">Next Of Kin Occupation: </td><td>");
            EndContext();
            BeginContext(4603, 28, false);
#line 65 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                                            Write(dDetails.NextOfKinOccupation);

#line default
#line hidden
            EndContext();
            BeginContext(4631, 109, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Next Of Kin Telephone Number: </td><td>");
            EndContext();
            BeginContext(4741, 33, false);
#line 66 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                            Write(dDetails.NextOfKinTelephoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4774, 60, true);
            WriteLiteral("</td><td class=\"text-bold\">Next Of Kin Occupation: </td><td>");
            EndContext();
            BeginContext(4835, 28, false);
#line 66 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                                                          Write(dDetails.NextOfKinOccupation);

#line default
#line hidden
            EndContext();
            BeginContext(4863, 97, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Assigned Vehicle: </td><td>");
            EndContext();
            BeginContext(4961, 24, false);
#line 67 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                Write(dDetails.AssignedVehicle);

#line default
#line hidden
            EndContext();
            BeginContext(4985, 60, true);
            WriteLiteral("</td><td class=\"text-bold\">Assigned Vehicle RegNo: </td><td>");
            EndContext();
            BeginContext(5046, 29, false);
#line 67 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                                     Write(dDetails.AssignedVehicleRegNo);

#line default
#line hidden
            EndContext();
            BeginContext(5075, 108, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Vehicle Assignment DateTime: </td><td>");
            EndContext();
            BeginContext(5184, 34, false);
#line 68 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                           Write(dDetails.VehicleAssignmentDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(5218, 62, true);
            WriteLiteral("</td><td class=\"text-bold\">Assigned Vehicle Details: </td><td>");
            EndContext();
            BeginContext(5281, 31, false);
#line 68 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                                                            Write(dDetails.AssignedVehicleDetails);

#line default
#line hidden
            EndContext();
            BeginContext(5312, 93, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Created Date: </td><td>");
            EndContext();
            BeginContext(5406, 24, false);
#line 69 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                            Write(dDetails.CreatedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(5430, 56, true);
            WriteLiteral("</td><td class=\"text-bold\">Application Status: </td><td>");
            EndContext();
            BeginContext(5487, 26, false);
#line 69 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                                             Write(dDetails.ApplicationStatus);

#line default
#line hidden
            EndContext();
            BeginContext(5513, 87, true);
            WriteLiteral("</td></tr>\r\n                                <tr><td class=\"text-bold\">Remark: </td><td>");
            EndContext();
            BeginContext(5601, 15, false);
#line 70 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                      Write(dDetails.Remark);

#line default
#line hidden
            EndContext();
            BeginContext(5616, 51, true);
            WriteLiteral("</td><td class=\"text-bold\">Remark Reason: </td><td>");
            EndContext();
            BeginContext(5668, 21, false);
#line 70 "C:\Users\temidayo.uji\source\repos\DriverOnboarding\DriverOnboarding\Views\Drivers\Details.cshtml"
                                                                                                                                         Write(dDetails.RemarkReason);

#line default
#line hidden
            EndContext();
            BeginContext(5689, 471, true);
            WriteLiteral(@"</td></tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""tab-pane"" id=""guarantordetails"">
                        <table class=""table table-bordered table-striped"">
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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