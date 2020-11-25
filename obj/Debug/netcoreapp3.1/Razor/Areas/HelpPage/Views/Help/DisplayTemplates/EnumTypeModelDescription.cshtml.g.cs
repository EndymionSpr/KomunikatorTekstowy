#pragma checksum "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39dc54ce8f0e61c55ac0aa148e84d759438d9970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HelpPage_Views_Help_DisplayTemplates_EnumTypeModelDescription), @"mvc.1.0.view", @"/Areas/HelpPage/Views/Help/DisplayTemplates/EnumTypeModelDescription.cshtml")]
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
#line 1 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml"
using KomunikatorTekstowy.Areas.HelpPage.ModelDescriptions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39dc54ce8f0e61c55ac0aa148e84d759438d9970", @"/Areas/HelpPage/Views/Help/DisplayTemplates/EnumTypeModelDescription.cshtml")]
    public class Areas_HelpPage_Views_Help_DisplayTemplates_EnumTypeModelDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnumTypeModelDescription>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Possible enumeration values:</p>\r\n\r\n<table class=\"help-page-table\">\r\n    <thead>\r\n        <tr><th>Name</th><th>Value</th><th>Description</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 11 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml"
         foreach (EnumValueDescription value in Model.Values)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"enum-name\"><b>");
#nullable restore
#line 14 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml"
                                    Write(value.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td class=\"enum-value\">\r\n                    <p>");
#nullable restore
#line 16 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml"
                  Write(value.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </td>\r\n                <td class=\"enum-description\">\r\n                    <p>");
#nullable restore
#line 19 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml"
                  Write(value.Documentation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnumTypeModelDescription> Html { get; private set; }
    }
}
#pragma warning restore 1591