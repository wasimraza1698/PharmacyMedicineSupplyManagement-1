#pragma checksum "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17606b39e9cd9939f68cd5da4fa1022448c8dd0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_Schedule), @"mvc.1.0.view", @"/Views/Schedule/Schedule.cshtml")]
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
#nullable restore
#line 1 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\_ViewImports.cshtml"
using PharmacyMedicineSupply;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\_ViewImports.cshtml"
using PharmacyMedicineSupply.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17606b39e9cd9939f68cd5da4fa1022448c8dd0a", @"/Views/Schedule/Schedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57414d98da45554cbfe6fe83a2b6b80ad0b224c", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_Schedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmacyMedicineSupply.Models.RepSchedule>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
  
    ViewData["Title"] = "Schedule";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered table-hover mt-5\">\r\n    <thead  class=\"table-danger\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.RepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.TreatingAilment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.Medicine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.MeetingSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfMeeting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.RepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.TreatingAilment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.Medicine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.MeetingSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfMeeting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\wasim\OneDrive\Desktop\MFPE Local\PharmacyMedicineSupplyManagement-1\PharmacyMedicineSupplyApp\Views\Schedule\Schedule.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmacyMedicineSupply.Models.RepSchedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
