#pragma checksum "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\ImageSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "902481e0c7c12143230c1368547fcbc51c4f1664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HelpPage_Views_Help_DisplayTemplates_ImageSample), @"mvc.1.0.view", @"/Areas/HelpPage/Views/Help/DisplayTemplates/ImageSample.cshtml")]
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
#line 1 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\ImageSample.cshtml"
using KomunikatorTekstowy.Areas.HelpPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902481e0c7c12143230c1368547fcbc51c4f1664", @"/Areas/HelpPage/Views/Help/DisplayTemplates/ImageSample.cshtml")]
    public class Areas_HelpPage_Views_Help_DisplayTemplates_ImageSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageSample>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<img");
            BeginWriteAttribute("src", " src=\"", 69, "\"", 85, 1);
#nullable restore
#line 4 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\ImageSample.cshtml"
WriteAttributeValue("", 75, Model.Src, 75, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageSample> Html { get; private set; }
    }
}
#pragma warning restore 1591
