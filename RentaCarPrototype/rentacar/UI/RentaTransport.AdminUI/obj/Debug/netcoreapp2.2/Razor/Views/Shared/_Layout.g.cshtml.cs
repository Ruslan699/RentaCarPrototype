#pragma checksum "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eb6311f8d85220e38ae9af9153862ba7200ac1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RentaTransport.AdminUI.Pages.Shared.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(RentaTransport.AdminUI.Pages.Shared.Views_Shared__Layout))]
namespace RentaTransport.AdminUI.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using RentaTransport.AdminUI;

#line default
#line hidden
#line 3 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using RentaTransport.AdminUI.Data;

#line default
#line hidden
#line 6 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb6311f8d85220e38ae9af9153862ba7200ac1e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2ad6c7c2ff271adbade331ff9dc9c9248d64af", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 392, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb6311f8d85220e38ae9af9153862ba7200ac1e3827", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 35, true);
                WriteLiteral(" - Rent a Transport</title>\r\n\r\n    ");
                EndContext();
                BeginContext(206, 54, false);
#line 8 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("StylesPartial/_StylePartial"));

#line default
#line hidden
                EndContext();
                BeginContext(260, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(269, 65, false);
#line 10 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("StylesPartial/_DevExtremeStylesPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(334, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(341, 67, false);
#line 11 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptPartials/_DevExtremeScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(408, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(419, 682, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb6311f8d85220e38ae9af9153862ba7200ac1e6745", async() => {
                BeginContext(425, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(432, 58, false);
#line 14 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("TemplatePartials/_HeaderPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(490, 42, true);
                WriteLiteral("\r\n    <div class=\"page-content\">\r\n        ");
                EndContext();
                BeginContext(533, 59, false);
#line 16 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("TemplatePartials/_SidebarPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(592, 53, true);
                WriteLiteral("\r\n        <div class=\"content-wrapper\">\r\n            ");
                EndContext();
                BeginContext(646, 62, false);
#line 18 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("TemplatePartials/_PageHeaderPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(708, 53, true);
                WriteLiteral("\r\n            <div class=\"content\">\r\n                ");
                EndContext();
                BeginContext(762, 12, false);
#line 20 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(774, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(793, 63, false);
#line 21 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
           Write(await Html.PartialAsync("TemplatePartials/_RemoveModalPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(856, 34, true);
                WriteLiteral("\r\n            </div>\r\n            ");
                EndContext();
                BeginContext(891, 58, false);
#line 23 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("TemplatePartials/_FooterPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(949, 36, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(986, 56, false);
#line 27 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptPartials/_ScriptPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1042, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1051, 41, false);
#line 29 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1092, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1101, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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