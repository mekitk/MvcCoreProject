#pragma checksum "C:\Users\M3ki\source\repos\Northwind\DevExtremeAspNetCoreApp1\Views\Sorgu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1908a5e9a091d91e72141a8d6a414f4ab032222b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DevExtremeAspNetCoreApp1.Models.Sorgu.Views_Sorgu_Index), @"mvc.1.0.view", @"/Views/Sorgu/Index.cshtml")]
namespace DevExtremeAspNetCoreApp1.Models.Sorgu
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
#line 1 "C:\Users\M3ki\source\repos\Northwind\DevExtremeAspNetCoreApp1\Views\_ViewImports.cshtml"
using DevExtremeAspNetCoreApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\M3ki\source\repos\Northwind\DevExtremeAspNetCoreApp1\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1908a5e9a091d91e72141a8d6a414f4ab032222b", @"/Views/Sorgu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f18862e76c15ffed4329856b92adaa720a7d58", @"/Views/_ViewImports.cshtml")]
    public class Views_Sorgu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\M3ki\source\repos\Northwind\DevExtremeAspNetCoreApp1\Views\Sorgu\Index.cshtml"
Write(Html.DevExtreme().DataGrid<Northwind.Entities.Concrete.Customer>()
    .DataSource(ds => ds.Mvc()
        .Controller("Customers")
        .LoadAction("Get")
        .InsertAction("Post")
        .UpdateAction("Put")
        .DeleteAction("Delete")
        .Key("CustomerId")
    )
    .RemoteOperations(true)
    .Columns(columns => {

        columns.AddFor(m => m.CustomerId);

        columns.AddFor(m => m.CompanyName);

        columns.AddFor(m => m.ContactName);

        columns.AddFor(m => m.ContactTitle);

        columns.AddFor(m => m.Address);

        columns.AddFor(m => m.City);

        columns.AddFor(m => m.Region);

        columns.AddFor(m => m.Country);

        columns.AddFor(m => m.Phone);

        columns.AddFor(m => m.Fax);
    })
    .Editing(e => e
        .AllowAdding(true)
        .AllowUpdating(true)
        .AllowDeleting(true)
    )
);

#line default
#line hidden
#nullable disable
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
