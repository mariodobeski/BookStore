#pragma checksum "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69497cd0e29a1fddc54dce172404545259f982a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WishList_Index), @"mvc.1.0.view", @"/Views/WishList/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69497cd0e29a1fddc54dce172404545259f982a3", @"/Views/WishList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_WishList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Models.BookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GoToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""bg-dark text-white text-center p-3"">Wishlist</h1>

<div class=""custom-container"">
    <table class=""table table-hover"">
        <thead>
            <tr class=""wishlist-header"">
                <th>
                    <input type=""checkbox"" name=""addToCart"" id=""checkAll"" /> Select All
                </th>
                <th>
                    ");
#nullable restore
#line 17 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th colspan=\"2\">Actions</th>\r\n            </tr>\r\n        </thead>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
             foreach (var item in Model.AllBooksFromWishlistByLoggedInUser)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"addToCartSelected\"");
            BeginWriteAttribute("value", " value=\"", 1336, "\"", 1352, 1);
#nullable restore
#line 45 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
WriteAttributeValue("", 1344, item.Id, 1344, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69497cd0e29a1fddc54dce172404545259f982a38246", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1445, "~/images/", 1445, 9, true);
#nullable restore
#line 48 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
AddHtmlAttributeValue("", 1454, item.PhotoURL, 1454, 14, false);

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
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69497cd0e29a1fddc54dce172404545259f982a311314", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle\"></i> &nbsp; Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-block btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2302, "\"", 2344, 3);
            WriteAttributeValue("", 2312, "DeleteItemFromWishlist(", 2312, 23, true);
#nullable restore
#line 66 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
WriteAttributeValue("", 2335, item.Id, 2335, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2343, ")", 2343, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-trash-alt\"></i> &nbsp; Delete\r\n                        </button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"total-style\">\r\n                <td colspan=\"6\"></td>\r\n                <td>Total:</td>\r\n                <td> &#36; ");
#nullable restore
#line 75 "C:\Users\Mario\Desktop\Proekti\1. BookStore_cel\BookStore\Views\WishList\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => modelItem.WishlistTotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
            <tr class=""total-style"">
                <td colspan=""8"">
                    <button class=""btn btn-block btn-success"" id=""addToCartAction"" disabled>
                        <i class=""fas fa-cart-plus""></i> &nbsp; Add To Cart
                    </button>
                </td>
            </tr>
        </tbody>
    </table>


    <div class=""modal fade"" id=""actionChooseModal"" tabindex=""-1"" role=""dialog""
         aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" id=""modalDialogStyle"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title""> <span id=""detailsTitle""></span> Successfully Added Books To Cart</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
       ");
            WriteLiteral(@"         <div class=""modal-body"">
                    <h4>Choose option to continue:</h4>
                    <div class=""row"">
                        <div class=""col-12 col-md-6"">
                            <button type=""button"" class=""btn btn-outline-secondary btn-block"" id=""stayToWishlist"" data-dismiss=""modal"">Stay to Wishlist</button>
                        </div>
                        <div class=""col-12 col-md-6"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69497cd0e29a1fddc54dce172404545259f982a316659", async() => {
                WriteLiteral("Go to Shopping Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"modal-footer\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

        function DeleteItemFromWishlist(id) {
            $.ajax({
                type: ""POST"",
                url: ""/WishList/Delete/"" + id,
                success: function (data) {
                    //console.log(data);
                    new Noty({
                        type: 'alert',
                        layout: 'bottomLeft',
                        timeout: 1500,
                        progressBar: true,
                        text: 'Successfully Deleted Book: ' + data.data.title + ' From Wishlist',
                        theme: 'sunset'
                    }).show();

                    setTimeout(function () {
                        if (data) {
                            window.location = data.url;
                        }
                    }, 1800);
                },
                error: function () {
                    new Noty({
                        type: 'error',
                        layout: 'bottomLef");
                WriteLiteral(@"t',
                        timeout: 3000,
                        progressBar: true,
                        text: 'Error Delete Book From Wishlist',
                        theme: 'sunset'
                    }).show();
                }
            });
        };


        $(function () {

            $(""#checkAll"").click(function () {
                $(""input[name='addToCartSelected']"").prop(""checked"", this.checked);
                if ($(""input[name='addToCartSelected']:checked"").length > 0) {
                    $(""#addToCartAction"").prop(""disabled"", false);
                } else {
                    $(""#addToCartAction"").prop(""disabled"", true);
                }
            });


            $(""input[name='addToCartSelected']"").click(function () {
                if ($(""input[name='addToCartSelected']"").length == $(""input[name='addToCartSelected']:checked"").length) {
                    $(""#checkAll"").prop(""checked"", true);
                } else {
                    $(""#c");
                WriteLiteral(@"heckAll"").prop('checked', false);
                }
                if ($(""input[name='addToCartSelected']:checked"").length > 0) {
                    $(""#addToCartAction"").prop(""disabled"", false);
                } else {
                    $(""#addToCartAction"").prop(""disabled"", true);
                }
            });


            $(""#addToCartAction"").click(function () {
                var books = [];

                $.each($(""input[name='addToCartSelected']:checked""), function () {
                    books.push($(this).val());
                });
                // console.log(books);

                $.ajax({
                    type: ""POST"",
                    url: ""/WishList/AddToCartFromWishlist/"",
                    dataType: 'json',
                    data: { 'bookIds': books },
                    success: function (data) {
                        //console.log(data);
                        new Noty({
                            type: 'success',
                 ");
                WriteLiteral(@"           layout: 'bottomLeft',
                            timeout: 500,
                            progressBar: true,
                            text: 'Successfully Added Book To Cart',
                            theme: 'sunset'
                        }).show();

                        setTimeout(function () {
                            $('#actionChooseModal').modal('show');
                        }, 800);
                    },
                    error: function () {
                        new Noty({
                            type: 'error',
                            layout: 'bottomLeft',
                            timeout: 3000,
                            progressBar: true,
                            text: 'Error => Unsuccessfully Added Book From Wishlist To Shopping Cart',
                            theme: 'sunset'
                        }).show();
                    }
                });
            });


            $(""#stayToWishlist"").click(function () {
 ");
                WriteLiteral("               location.reload();\r\n            });\r\n\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Models.BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
