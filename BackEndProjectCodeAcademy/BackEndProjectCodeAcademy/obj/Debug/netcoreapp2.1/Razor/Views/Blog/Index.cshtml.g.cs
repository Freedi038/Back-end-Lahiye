#pragma checksum "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63740cd2bb3fd9d0d89a81415dc15dc86893e40d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
#line 1 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63740cd2bb3fd9d0d89a81415dc15dc86893e40d", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialBanner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    if (ViewBag.Page == null)
    {
        ViewBag.Page = 1;
    }

#line default
#line hidden
            BeginContext(177, 80, true);
            WriteLiteral("    <input type=\"hidden\" id=\"hidden\" value=\"blog\" />\n<!-- Banner Area Start -->\n");
            EndContext();
            BeginContext(257, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cccecbd5d375439e84d0a8c27ca696f4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(289, 138, true);
            WriteLiteral("\n<!-- Banner Area End -->\n<!-- Blog Start -->\n<div class=\"blog-area pt-150 pb-150\">\n    <div class=\"container\">\n        <div class=\"row\">\n");
            EndContext();
#line 19 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
             foreach (var blog in Model)
            {

#line default
#line hidden
            BeginContext(538, 236, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12 mt-4\" style=\"margin-top:50px\">\n                    <div class=\"single-blog\">\n                        <div class=\"blog-img\">\n                            <a href=\"blog-details.html\">");
            EndContext();
            BeginContext(774, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28cfc673d574423fbc4fa48321648c75", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 784, "~/img/blog/", 784, 11, true);
#line 24 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 795, blog.Image, 795, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(819, 355, true);
            WriteLiteral(@"</a>
                            <div class=""blog-hover"">
                                <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                            </div>
                        </div>
                        <div class=""blog-content"">
                            <div class=""blog-top"">
                                <p>By ");
            EndContext();
            BeginContext(1175, 11, false);
#line 31 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                                 Write(blog.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(1192, 14, false);
#line 31 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                                                  Write(blog.WriteTime);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 196, true);
            WriteLiteral(" /  <i class=\"fa fa-comments-o\"></i> 4</p>\n                            </div>\n                            <div class=\"blog-bottom\">\n                                <h2><a href=\"blog-details.html\">");
            EndContext();
            BeginContext(1403, 10, false);
#line 34 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                                                           Write(blog.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1413, 43, true);
            WriteLiteral(" </a></h2>\n                                ");
            EndContext();
            BeginContext(1456, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39722bd648d44661aef0a774a305d519", async() => {
                BeginContext(1525, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                                                                               WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1538, 117, true);
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 40 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(1670, 159, true);
            WriteLiteral("\n        </div>\n        <div class=\"row mt-5 justify-content-center\">\n            <nav aria-label=\"...\">\n                <ul class=\"pagination pagination-sm\">\n");
            EndContext();
#line 47 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                     for (int i = 1; i <= ViewBag.PageCount; i++)
                    {
                        if (ViewBag.Page == i)
                        {

#line default
#line hidden
            BeginContext(1990, 89, true);
            WriteLiteral("                            <li class=\"page-item disabled\"><a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(2080, 1, false);
#line 51 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                                                                                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2081, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 52 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2172, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(2222, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c756ab57b89245048fe662ae20b2f6ea", async() => {
                BeginContext(2306, 1, false);
#line 55 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                                                                                                                                Write(i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                                                                                                                     WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2311, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 56 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Blog\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2365, 117, true);
            WriteLiteral("                </ul>\n            </nav>\n        </div>\n    </div>\n</div>\n<!-- Blog End -->\n<!-- Subscribe Start -->\n");
            EndContext();
            BeginContext(2482, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12acc2fe3c5b43c8a479abac00de7df4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2518, 26, true);
            WriteLiteral("\n<!-- Subscribe End -->\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591