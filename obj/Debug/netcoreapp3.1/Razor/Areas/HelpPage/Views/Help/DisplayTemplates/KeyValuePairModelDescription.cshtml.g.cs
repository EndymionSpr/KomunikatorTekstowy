#pragma checksum "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\KeyValuePairModelDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b0f6b52e668c8907117f76b237c19df9321297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HelpPage_Views_Help_DisplayTemplates_KeyValuePairModelDescription), @"mvc.1.0.view", @"/Areas/HelpPage/Views/Help/DisplayTemplates/KeyValuePairModelDescription.cshtml")]
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
#line 1 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\KeyValuePairModelDescription.cshtml"
using KomunikatorTekstowy.Areas.HelpPage.ModelDescriptions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b0f6b52e668c8907117f76b237c19df9321297", @"/Areas/HelpPage/Views/Help/DisplayTemplates/KeyValuePairModelDescription.cshtml")]
    public class Areas_HelpPage_Views_Help_DisplayTemplates_KeyValuePairModelDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeyValuePairModelDescription>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("Pair of ");
#nullable restore
#line 3 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\KeyValuePairModelDescription.cshtml"
   Write(Html.DisplayFor(m => Model.KeyModelDescription.ModelType, "ModelDescriptionLink", new { modelDescription = Model.KeyModelDescription }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" [key]\r\nand ");
#nullable restore
#line 4 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\KeyValuePairModelDescription.cshtml"
Write(Html.DisplayFor(m => Model.ValueModelDescription.ModelType, "ModelDescriptionLink", new { modelDescription = Model.ValueModelDescription }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" [value]");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeyValuePairModelDescription> Html { get; private set; }
    }
}
#pragma warning restore 1591
