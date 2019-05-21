#pragma checksum "C:\BookApi\BookApi\BookApi\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0416bf0172086a1ca7253cd574e5bb6c76f56a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit), @"mvc.1.0.view", @"/Views/Book/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Edit.cshtml", typeof(AspNetCore.Views_Book_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0416bf0172086a1ca7253cd574e5bb6c76f56a6d", @"/Views/Book/Edit.cshtml")]
    public class Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksApi.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\BookApi\BookApi\BookApi\Views\Book\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(71, 1594, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Book</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""BookName"" class=""control-label""></label>
                <input asp-for=""BookName"" class=""form-control"" />
                <span asp-validation-for=""BookName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Category"" class=""control-label""></label>
                <input asp-for=""Category"" class=""form-control"" />
                <span asp-validation-for=");
            WriteLiteral(@"""Category"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Author"" class=""control-label""></label>
                <input asp-for=""Author"" class=""form-control"" />
                <span asp-validation-for=""Author"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1683, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\BookApi\BookApi\BookApi\Views\Book\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksApi.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
