#pragma checksum "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7aaeedd2687296028217adc3bef62da84675a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7aaeedd2687296028217adc3bef62da84675a0", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5d051744500b5155bf713078e99aaa77fd74a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DynamicEcommerce.Models.ProductIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row product-content\">\r\n");
#nullable restore
#line 5 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Product\Index.cshtml"
         foreach (var image in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product-image\"");
            BeginWriteAttribute("style", " style=\"", 213, "\"", 255, 3);
            WriteAttributeValue("", 221, "background-image:url(", 221, 21, true);
#nullable restore
#line 7 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Product\Index.cshtml"
WriteAttributeValue("", 242, image.Image, 242, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 254, ")", 254, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 8 "C:\Users\Brody's PC\Desktop\Coding\Varsity\Year 3\Semester 1\Programming\Task2\DynamicEcommerce\DynamicEcommerce\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DynamicEcommerce.Models.ProductIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
