#pragma checksum "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b1ec6fc76419b4f3daaded2159dbee0d331b4da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBooK), @"mvc.1.0.view", @"/Views/Book/GetBooK.cshtml")]
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
#line 1 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b1ec6fc76419b4f3daaded2159dbee0d331b4da", @"/Views/Book/GetBooK.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7405129f38e4334088c9f99aab64f77db16eae6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetBooK : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("bookk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/02.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/03.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml"
  
  ViewData["Title"] = "GetBook " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <h3 class=""display-4"">Book</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                  <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                  <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                  <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                  <div class=""carousel-item active"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b1ec6fc76419b4f3daaded2159dbee0d331b4da6006", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                  </div>\n                  <div class=\"carousel-item\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b1ec6fc76419b4f3daaded2159dbee0d331b4da7280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                  </div>\n                  <div class=\"carousel-item\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b1ec6fc76419b4f3daaded2159dbee0d331b4da8554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                  <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                  <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                  <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                  <span class=""sr-only"">Next</span>
                </a>
              </div>
        </div>

        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 42 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                </div>\n            </div>\n            <div class=\"row\">\n                <div class=\"col-md-12 text-primary\">\n                    <span class=\"lable lable-primary\">By:</span>\n                    <span class=\"monospaced\">");
#nullable restore
#line 48 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml"
                                        Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n            <div class=\"row\">\n                <div class=\"col-md-12\">\n                    <p class=\"description\">");
#nullable restore
#line 53 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <button class=""btn btn-outline-primary"">Read Now</button>
                </div>
            </div>
            <hr>
            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category -</span>");
#nullable restore
#line 63 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml"
                                                                                       Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages -</span>");
#nullable restore
#line 64 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml"
                                                                                          Write(Model.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language -</span>");
#nullable restore
#line 65 "/home/lokesh/ProjectsAsp/BookStore/BookStore/Views/Book/GetBooK.cshtml"
                                                                                       Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>
</div>
<hr>
<div class=""container"">
  <h3 class=""display-4"">Similar Books</h3>
  <div class=""row"">
    <div class=""col-md-4"">
        <div class=""card mb-4 shadow-sm"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <div class=""d-flex justify-content-between aling-items-center"">
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Detail</a>
                    </div>
                    <small class=""text-mutes"">
                        Author name
                    </small>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-4"">
        <div class=""card mb-");
            WriteLiteral(@"4 shadow-sm"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <div class=""d-flex justify-content-between aling-items-center"">
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Detail</a>
                    </div>
                    <small class=""text-mutes"">
                        Author name
                    </small>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-4"">
        <div class=""card mb-4 shadow-sm"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">Som");
            WriteLiteral(@"e quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <div class=""d-flex justify-content-between aling-items-center"">
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Detail</a>
                    </div>
                    <small class=""text-mutes"">
                        Author name
                    </small>
                </div>
            </div>
        </div>
    </div>
<div class=""row"">
    <div class=""col-md-4"">
        <div class=""card mb-4 shadow-sm"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <div class=""d-flex justify-content-");
            WriteLiteral(@"between aling-items-center"">
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Detail</a>
                    </div>
                    <small class=""text-mutes"">
                        Author name
                    </small>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-4"">
        <div class=""card mb-4 shadow-sm"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <div class=""d-flex justify-content-between aling-items-center"">
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Detail</a>
                    </div>
           ");
            WriteLiteral(@"         <small class=""text-mutes"">
                        Author name
                    </small>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-4"">
        <div class=""card mb-4 shadow-sm"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <div class=""d-flex justify-content-between aling-items-center"">
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Detail</a>
                    </div>
                    <small class=""text-mutes"">
                        Author name
                    </small>
                </div>
            </div>
        </div>
    </div>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
