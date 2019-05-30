#pragma checksum "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\CarAddition\_GridPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc25171bf1f11af3e5b394049d1e167a66855a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RentaTransport.AdminUI.Pages.CarAddition.Views_CarAddition__GridPartial), @"mvc.1.0.view", @"/Views/CarAddition/_GridPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarAddition/_GridPartial.cshtml", typeof(RentaTransport.AdminUI.Pages.CarAddition.Views_CarAddition__GridPartial))]
namespace RentaTransport.AdminUI.Pages.CarAddition
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
#line 1 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\CarAddition\_GridPartial.cshtml"
using RentaTransport.Common.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc25171bf1f11af3e5b394049d1e167a66855a15", @"/Views/CarAddition/_GridPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2ad6c7c2ff271adbade331ff9dc9c9248d64af", @"/Views/_ViewImports.cshtml")]
    public class Views_CarAddition__GridPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 2067, false);
#line 3 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\CarAddition\_GridPartial.cshtml"
Write(Html.DevExtreme().DataGrid<RentaTransport.BLL.DTOs.CarAdditionDTO>()
            .ID("usersGridContainer")
            .DataSource(d => d.Mvc().Controller("CarAddition").LoadAction("Data").Key("Id"))
            .RemoteOperations(false)
            .AllowColumnReordering(true)
            .RowAlternationEnabled(true)
            .FilterRow(filterRow => filterRow.Visible(true).ApplyFilter(GridApplyFilterMode.Auto))
            .ShowBorders(true)
            .Paging(p => p.PageSize(10))
            .Pager(p => p.ShowPageSizeSelector(true).AllowedPageSizes(new int[] { 10, 20, 50 }))
            //.SearchPanel(s => s.Visible(true).HighlightCaseSensitive(true))
            .Scrolling(scrolling => scrolling.Mode(GridScrollingMode.Standard))
            //.Export(e => e.Enabled(true).FileName($"UserRolesGrid-{DateTime.Now.ToString()}"))
            .ColumnMinWidth(120)
            //.HeaderFilter(headerFilter => headerFilter.Visible(true))
            .Columns(columns =>
            {

                columns.AddFor(m => m.Name)
                    .Caption(UI.Name);

                columns.AddFor(m => m.Description)
                    .Caption(UI.Description);

                columns.AddFor(m => m.CreatedDate)
                   .Caption(UI.CreatedDate);

                columns.AddFor(m => m.Id)
                    .Caption(UI.Operations)
                    .Width(50)
                    .AllowFiltering(false)
                    .AllowSorting(false)
                    .CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1591, 73, true);
    WriteLiteral("\r\n                        <a class=\"btn bg-teal-400 btn-icon legitRipple\"");
    EndContext();
    BeginWriteAttribute("onclick", " onclick=\"", 1664, "\"", 1732, 4);
    WriteAttributeValue("", 1674, "HrefMe(\'", 1674, 8, true);
#line 36 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\CarAddition\_GridPartial.cshtml"
WriteAttributeValue("", 1682, Url.Action("Form", "CarAddition"), 1682, 34, false);

#line default
#line hidden
    WriteAttributeValue("", 1716, "\',", 1716, 2, true);
    WriteAttributeValue(" ", 1718, "\'<%=value%>\')", 1719, 14, true);
    EndWriteAttribute();
    BeginContext(1733, 160, true);
    WriteLiteral(">\r\n                            <i class=\"icon-pencil4\"></i>\r\n                        </a>\r\n                        <a class=\"btn bg-danger btn-icon legitRipple\"");
    EndContext();
    BeginWriteAttribute("onclick", " onclick=\"", 1893, "\"", 1972, 4);
    WriteAttributeValue("", 1903, "ShowRemoveModal(\'", 1903, 17, true);
#line 39 "C:\Users\PC\Desktop\RentaCar\rentacar\UI\RentaTransport.AdminUI\Views\CarAddition\_GridPartial.cshtml"
WriteAttributeValue("", 1920, Url.Action("Remove", "CarAddition"), 1920, 36, false);

#line default
#line hidden
    WriteAttributeValue("", 1956, "\',", 1956, 2, true);
    WriteAttributeValue(" ", 1958, "\'<%=value%>\')", 1959, 14, true);
    EndWriteAttribute();
    BeginContext(1973, 109, true);
    WriteLiteral(">\r\n                            <i class=\"icon-trash\"></i>\r\n                        </a>\r\n                    ");
    EndContext();
    PopWriter();
}
));
                            })
);

#line default
#line hidden
            EndContext();
            BeginContext(2126, 2, true);
            WriteLiteral("\r\n");
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