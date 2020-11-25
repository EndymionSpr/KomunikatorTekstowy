#pragma checksum "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a913816114ea5c1ce3020f942068b7c48ce8dbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HelpPage_Views_Help_DisplayTemplates_HelpPageApiModel), @"mvc.1.0.view", @"/Areas/HelpPage/Views/Help/DisplayTemplates/HelpPageApiModel.cshtml")]
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
#line 1 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
using System.Web.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
using System.Web.Http.Description;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
using KomunikatorTekstowy.Areas.HelpPage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
using KomunikatorTekstowy.Areas.HelpPage.ModelDescriptions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a913816114ea5c1ce3020f942068b7c48ce8dbf", @"/Areas/HelpPage/Views/Help/DisplayTemplates/HelpPageApiModel.cshtml")]
    public class Areas_HelpPage_Views_Help_DisplayTemplates_HelpPageApiModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelpPageApiModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
  
    ApiDescription description = Model.ApiDescription;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 10 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
Write(description.HttpMethod.Method);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
                              Write(description.RelativePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
  Write(description.Documentation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <h2>Request Information</h2>\r\n\r\n    <h3>URI Parameters</h3>\r\n    ");
#nullable restore
#line 17 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
Write(Html.DisplayFor(m => m.UriParameters, "Parameters"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h3>Body Parameters</h3>\r\n\r\n    <p>");
#nullable restore
#line 21 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
  Write(Model.RequestDocumentation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
     if (Model.RequestModelDescription != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
   Write(Html.DisplayFor(m => m.RequestModelDescription.ModelType, "ModelDescriptionLink", new { modelDescription = Model.RequestModelDescription }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
                                                                                                                                                    
        if (Model.RequestBodyParameters != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
       Write(Html.DisplayFor(m => m.RequestBodyParameters, "Parameters"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
                                                                        
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>None.</p>\r\n");
#nullable restore
#line 34 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
     if (Model.SampleRequests.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Request Formats</h3>\r\n");
#nullable restore
#line 39 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
   Write(Html.DisplayFor(m => m.SampleRequests, "Samples"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>Response Information</h2>\r\n\r\n    <h3>Resource Description</h3>\r\n\r\n    <p>");
#nullable restore
#line 46 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
  Write(description.ResponseDescription.Documentation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
     if (Model.ResourceDescription != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
   Write(Html.DisplayFor(m => m.ResourceDescription.ModelType, "ModelDescriptionLink", new { modelDescription = Model.ResourceDescription }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
                                                                                                                                            
        if (Model.ResourceProperties != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
       Write(Html.DisplayFor(m => m.ResourceProperties, "Parameters"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
                                                                     
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>None.</p>\r\n");
#nullable restore
#line 59 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
     if (Model.SampleResponses.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Response Formats</h3>\r\n");
#nullable restore
#line 64 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
   Write(Html.DisplayFor(m => m.SampleResponses, "Samples"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Dawid\source\repos\KomunikatorTextowy\Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml"
                                                           
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelpPageApiModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
