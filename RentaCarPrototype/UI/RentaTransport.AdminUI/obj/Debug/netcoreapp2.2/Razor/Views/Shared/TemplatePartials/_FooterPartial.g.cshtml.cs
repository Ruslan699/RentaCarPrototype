#pragma checksum "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5ec901edafe7390fadb6145fb1776123c58753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RentaTransport.AdminUI.Pages.Shared.TemplatePartials.Views_Shared_TemplatePartials__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/TemplatePartials/_FooterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/TemplatePartials/_FooterPartial.cshtml", typeof(RentaTransport.AdminUI.Pages.Shared.TemplatePartials.Views_Shared_TemplatePartials__FooterPartial))]
namespace RentaTransport.AdminUI.Pages.Shared.TemplatePartials
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using RentaTransport.AdminUI;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using RentaTransport.AdminUI.Data;

#line default
#line hidden
#line 6 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5ec901edafe7390fadb6145fb1776123c58753", @"/Views/Shared/TemplatePartials/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2ad6c7c2ff271adbade331ff9dc9c9248d64af", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_TemplatePartials__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 440, true);
            WriteLiteral(@"
<div class=""navbar navbar-expand-lg navbar-light"">
    <div class=""text-center d-lg-none w-100"">
        <button type=""button"" class=""navbar-toggler dropdown-toggle"" data-toggle=""collapse"" data-target=""#navbar-footer"">
            <i class=""icon-unfold mr-2""></i>
            Footer
        </button>
    </div>

    <div class=""navbar-collapse collapse"" id=""navbar-footer"">
        <span class=""navbar-text"">
            &copy;");
            EndContext();
            BeginContext(441, 17, false);
#line 12 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_FooterPartial.cshtml"
             Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(458, 88, true);
            WriteLiteral(" <a href=\"#\">Rent a Transport  <b>by Team</b></a>\r\n        </span>\r\n    </div>\r\n</div>\r\n");
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
