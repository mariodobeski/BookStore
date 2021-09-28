#pragma checksum "C:\Users\JORGOS\Desktop\OnlineBookstore\BookStore\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ce2c9bf2340fc7b34a34057cfcb19f3cae9d6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "C:\Users\JORGOS\Desktop\OnlineBookstore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JORGOS\Desktop\OnlineBookstore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ce2c9bf2340fc7b34a34057cfcb19f3cae9d6d", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStore.Data.Entities.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success m-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JORGOS\Desktop\OnlineBookstore\BookStore\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"bg-dark text-white text-center p-3\">Bookstore List</h1>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54ce2c9bf2340fc7b34a34057cfcb19f3cae9d6d4562", async() => {
                WriteLiteral("\r\n                <i class=\"fas fa-plus\"></i> Create\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>


<div class=""custom-container"">





    <table id=""booksDataTable"" class=""table table-striped row-border"" style=""width:100%"">
        <thead class=""thead-dark"">
            <tr>
                <th> Book Cover </th>
                <th> Title </th>
                <th> Author </th>
                <th> Year Of Issue </th>
                <th> Pages </th>
                <th> Genre </th>
                <th> Category</th>
                <th> Price </th>
                <th> Book Type </th>
                <th> Actions </th>
            </tr>
        </thead>
    </table>












    <!-- Details Modal -->
    <div class=""modal fade"" id=""detailsModal"" tabindex=""-1"" role=""dialog""
         aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" id=""modalDialogStyle"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=");
            WriteLiteral(@"""modal-title""> <span id=""detailsTitle""></span> Details</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <table class=""detailsTable table table-striped table-bordered"">
                        <tr>
                            <td> Title: </td>
                            <td><span id=""detailsTitle2""></span></td>
                        </tr>
                        <tr>
                            <td> Author: </td>
                            <td><span id=""detailsAuthor""></span></td>
                        </tr>
                        <tr>
                            <td> Year Of Issue: </td>
                            <td><span id=""detailsYearOfIssue""></span></td>
                        </tr>
                        <tr>
                            <td> Page");
            WriteLiteral(@"s: </td>
                            <td><span id=""detailsPages""></span></td>
                        </tr>
                        <tr>
                            <td> Publisher: </td>
                            <td><span id=""detailsPublisher""></span></td>
                        </tr>
                        <tr>
                            <td> Genre: </td>
                            <td><span id=""detailsGenre""></span></td>
                        </tr>
                        <tr>
                            <td> Category: </td>
                            <td><span id=""detailsCategory""></span></td>
                        </tr>
                        <tr>
                            <td> Price: </td>
                            <td><span id=""detailsPrice""></span></td>
                        </tr>
                        <tr>
                            <td> Book Type: </td>
                            <td><span id=""detailsBookType""></span></td>
                        </tr>
  ");
            WriteLiteral(@"                      <tr>
                            <td> Country: </td>
                            <td><span id=""detailsCountry""></span></td>
                        </tr>
                        <tr>
                            <td> Edition: </td>
                            <td><span id=""detailsEdition""></span></td>
                        </tr>
                        <tr>
                            <td> Language: </td>
                            <td><span id=""detailsLanguage""></span></td>
                        </tr>
                        <tr>
                            <td> Dimensions: </td>
                            <td><span id=""detailsDimensions""></span></td>
                        </tr>
                        <tr>
                            <td> Weight: </td>
                            <td><span id=""detailsWeight""></span></td>
                        </tr>
                        <tr>
                            <td> Copies: </td>
                            <td>");
            WriteLiteral(@"<span id=""detailsCopies""></span></td>
                        </tr>
                        <tr>
                            <td> Shipping: </td>
                            <td><span id=""detailsShipping""></span></td>
                        </tr>
                        <tr>
                            <td> Sold Items: </td>
                            <td><span id=""detailsSoldItems""></span></td>
                        </tr>
                        <tr>
                            <td> Description: </td>
                            <td><span id=""detailsDescription""></span></td>
                        </tr>
                    </table>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
       
        $(document).ready(function () {
            var table = $(""#booksDataTable"").DataTable({
                ajax: {
                    url: ""/Books/FillBooksDataTable"",
                    type: ""GET"",
                    datatype: ""json"",
                    success: function (data) {
                        console.log(data);
                    },
                    error: function () {
                        alert(""error"");
                    }
                }
            });
        });

       
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStore.Data.Entities.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
