#pragma checksum "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a3db8f6b83acef8f6714693822bbaa1f932977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
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
#line 1 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\_ViewImports.cshtml"
using DynamicEcommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\_ViewImports.cshtml"
using DynamicEcommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Profile\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Profile\Detail.cshtml"
using DynamicEcommerce.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0a3db8f6b83acef8f6714693822bbaa1f932977", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d051744500b5155bf713078e99aaa77fd74a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DynamicEcommerce.Models.ApplicationUser.ProfileModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h1>User Profile</h1>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <p>\r\n                ");
#nullable restore
#line 14 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Profile\Detail.cshtml"
           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Profile\Detail.cshtml"
                 if (Model.IsEmployee)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-primary ml-2\">Employee</span>\r\n");
#nullable restore
#line 18 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Profile\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DynamicEcommerce.Models.ApplicationUser.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
