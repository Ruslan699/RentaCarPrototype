#pragma checksum "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e2e1780a4fb1bc9032f3d49ecb94cb0720ec08b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RentaTransport.AdminUI.Pages.Shared.TemplatePartials.Views_Shared_TemplatePartials__SidebarMenuPartial), @"mvc.1.0.view", @"/Views/Shared/TemplatePartials/_SidebarMenuPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/TemplatePartials/_SidebarMenuPartial.cshtml", typeof(RentaTransport.AdminUI.Pages.Shared.TemplatePartials.Views_Shared_TemplatePartials__SidebarMenuPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e2e1780a4fb1bc9032f3d49ecb94cb0720ec08b", @"/Views/Shared/TemplatePartials/_SidebarMenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2ad6c7c2ff271adbade331ff9dc9c9248d64af", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_TemplatePartials__SidebarMenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 736, true);
            WriteLiteral(@"<div class=""card card-sidebar-mobile"">
    <ul class=""nav nav-sidebar"" data-nav-type=""accordion"">
        <li class=""nav-item-header""><div class=""text-uppercase font-size-xs line-height-xs"">Main</div> <i class=""icon-menu"" title=""Main""></i></li>
        <li class=""nav-item"">
            <a href=""#"" class=""nav-link active"">
                <i class=""icon-home4""></i>
                <span>
                    Dashboard
                </span>
            </a>
        </li>
        <li class=""nav-item nav-item-submenu"">
            <a href=""#"" class=""nav-link""><i class=""icon-copy""></i> <span>Cars</span></a>
            <ul class=""nav nav-group-sub"" data-submenu-title=""Layouts"">
                <li class=""nav-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 736, "", 770, 1);
#line 15 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 742, Url.Action("Index", "City"), 742, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(770, 74, true);
            WriteLiteral(" class=\"nav-link\">Cities</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 844, "", 889, 1);
#line 16 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 850, Url.Action("Index","AnnouncementType"), 850, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(889, 86, true);
            WriteLiteral(" class=\"nav-link\">Announcement Types</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 975, "", 1016, 1);
#line 17 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 981, Url.Action("Index","PropertyType"), 981, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1016, 82, true);
            WriteLiteral(" class=\"nav-link\">Property Types</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1098, "", 1139, 1);
#line 18 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 1104, Url.Action("Index","DocumentType"), 1104, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1139, 82, true);
            WriteLiteral(" class=\"nav-link\">Document Types</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1221, "", 1256, 1);
#line 19 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 1227, Url.Action("Index","Repair"), 1227, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1256, 75, true);
            WriteLiteral(" class=\"nav-link\">Repairs</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1331, "", 1367, 1);
#line 20 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 1337, Url.Action("Index", "Region"), 1337, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1367, 75, true);
            WriteLiteral(" class=\"nav-link\">Regions</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1442, "", 1482, 1);
#line 21 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 1448, Url.Action("Index", "Department"), 1448, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1482, 79, true);
            WriteLiteral(" class=\"nav-link\">Departments</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1561, "", 1607, 1);
#line 22 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 1567, Url.Action("Index", "RegionDepartment"), 1567, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1607, 91, true);
            WriteLiteral(" class=\"nav-link\">Regions and Departments</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1698, "", 1742, 1);
#line 23 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 1704, Url.Action("Index", "DepartmentCity"), 1704, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1742, 90, true);
            WriteLiteral(" class=\"nav-link\">Departments and Cities</a></li>\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1832, "", 1866, 1);
#line 24 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 1838, Url.Action("Index", "City"), 1838, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1866, 326, true);
            WriteLiteral(@" class=""nav-link"">Cities</a></li>
            </ul>
        </li>

        <li class=""nav-item nav-item-submenu"">
            <a href=""#"" class=""nav-link""><i class=""icon-copy""></i> <span>Customers</span></a>
            <ul class=""nav nav-group-sub"" data-submenu-title=""Layouts"">
                <li class=""nav-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 2192, "", 2230, 1);
#line 31 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 2198, Url.Action("Index", "Customer"), 2198, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2230, 331, true);
            WriteLiteral(@" class=""nav-link"">Customers</a></li>
            </ul>
        </li>

        <li class=""nav-item nav-item-submenu"">
            <a href=""#"" class=""nav-link""><i class=""icon-copy""></i> <span>Price Plans</span></a>
            <ul class=""nav nav-group-sub"" data-submenu-title=""Layouts"">
                <li class=""nav-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 2561, "", 2600, 1);
#line 38 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 2567, Url.Action("Index", "PricePlan"), 2567, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2600, 171, true);
            WriteLiteral(" class=\"nav-link\">Price Plans</a></li>\r\n            </ul>\r\n            <ul class=\"nav nav-group-sub\" data-submenu-title=\"Layouts\">\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 2771, "", 2810, 1);
#line 41 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 2777, Url.Action("Index", "Frequency"), 2777, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2810, 171, true);
            WriteLiteral(" class=\"nav-link\">Frequencies</a></li>\r\n            </ul>\r\n            <ul class=\"nav nav-group-sub\" data-submenu-title=\"Layouts\">\r\n                <li class=\"nav-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 2981, "", 3027, 1);
#line 44 "C:\Users\Lenovo\Desktop\Vesait\Proyektler\rentacar\UI\RentaTransport.AdminUI\Views\Shared\TemplatePartials\_SidebarMenuPartial.cshtml"
WriteAttributeValue("", 2987, Url.Action("Index", "PricePlanHistory"), 2987, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3027, 100, true);
            WriteLiteral(" class=\"nav-link\">Price Plan Histories</a></li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n</div>");
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
