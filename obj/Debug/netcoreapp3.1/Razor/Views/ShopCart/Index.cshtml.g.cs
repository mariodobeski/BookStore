#pragma checksum "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0d04d8a7602e2ba614a47a7d0f5d6ec855835ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
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
#line 1 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0d04d8a7602e2ba614a47a7d0f5d6ec855835ed", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Models.ShopCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"custom-container mt-4\">\r\n        <h1>Shopping Cart (");
#nullable restore
#line 9 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                      Write(Model.AllBooksAddedToCartByLoggedInUser.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-12 col-md-9\">\r\n");
#nullable restore
#line 13 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                 foreach (var book in Model.AllBooksAddedToCartByLoggedInUser)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card mt-3\">\r\n                        <div class=\"card-body row\">\r\n                            <div class=\"col-2 col-md-2 borderStyle\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0d04d8a7602e2ba614a47a7d0f5d6ec855835ed5550", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 686, "~/images/", 686, 9, true);
#nullable restore
#line 18 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
AddHtmlAttributeValue("", 695, book.PhotoURL, 695, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-10 col-md-10\">\r\n                                <h4 class=\"card-title\"> ");
#nullable restore
#line 21 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col-12 col-md-12\">\r\n                                        <h6>Author: ");
#nullable restore
#line 24 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => book.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                                        <h6>BookType: ");
#nullable restore
#line 25 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => book.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <h6>Dimensions: ");
#nullable restore
#line 26 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => book.Dimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <h6>Weight: ");
#nullable restore
#line 27 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => book.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                                        <h6>Shipping: ");
#nullable restore
#line 28 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => book.Shipping));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer text-muted"">
                            <div class=""row"">
                                <div class=""col-9 col-md-9"">
");
            WriteLiteral("                                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2092, "\"", 2130, 3);
            WriteAttributeValue("", 2102, "DeleteItemFromCart(", 2102, 19, true);
#nullable restore
#line 38 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
WriteAttributeValue("", 2121, book.Id, 2121, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2129, ")", 2129, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-trash-alt""></i> &nbsp; Delete
                                    </button>
                                </div>
                                <div class=""col-3 col-md-3 text-right"">
                                    <h6 class=""pt-1"">Price: &#36; ");
#nullable restore
#line 43 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => book.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""col-12 col-md-3"">
                <div class=""card mt-3"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Order Summary</h4>
                        <table class=""table table-borderless"">
                            <tbody>
                                <tr>
                                    <td>Subtotal</td>
                                    <td>");
#nullable restore
#line 59 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                   Write(Model.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Shipping</td>\r\n                                    <td>");
#nullable restore
#line 63 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                   Write(Model.ShippingTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Total</td>\r\n                                    <td>");
#nullable restore
#line 67 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\ShopCart\Index.cshtml"
                                   Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0d04d8a7602e2ba614a47a7d0f5d6ec855835ed13240", async() => {
                WriteLiteral(" <i class=\"far fa-credit-card\"></i> &nbsp; Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

        function DeleteItemFromCart(id) {
            $.ajax({
                type: ""POST"",
                url: ""/ShopCart/Delete/"" + id,
                success: function (data) {
                    console.log(data);
                    new Noty({
                        type: 'warning',
                        layout: 'bottomLeft',
                        timeout: 700,
                        progressBar: true,
                        text: 'Successfully Deleted Book: ' + data.data.title + ' From Wishlist',
                        theme: 'sunset'
                    }).show();

                    setTimeout(function () {
                        if (data) {
                            window.location = data.url;
                        }
                    }, 850);

                },
                error: function () {
                    new Noty({
                        type: 'error',
                        layout: 'bottomLeft',");
                WriteLiteral(@"
                        timeout: 3000,
                        progressBar: true,
                        text: 'Error Delete Book From Wishlist',
                        theme: 'sunset'
                    }).show();
                }
            });
        };
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Models.ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
