#pragma checksum "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756eb6d0d52b9a6835ecfed04de51bac9d942ba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756eb6d0d52b9a6835ecfed04de51bac9d942ba3", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialBanner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(99, 32, true);
            WriteLiteral("\n<!-- Banner Area Start -->\n    ");
            EndContext();
            BeginContext(131, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f371e928f09347c7821afc70af9688e3", async() => {
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
            BeginContext(164, 252, true);
            WriteLiteral("\n<!-- Banner Area End -->\n<!-- About Start -->\n<div class=\"about-area pt-145 pb-155\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-6 col-sm-6\">\n                <div class=\"about-content\">\n                    <h2>");
            EndContext();
            BeginContext(417, 34, false);
#line 16 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                   Write(Html.Raw(Model.WelcomeAbout.Title));

#line default
#line hidden
            EndContext();
            BeginContext(451, 29, true);
            WriteLiteral("</h2>\n                    <p>");
            EndContext();
            BeginContext(481, 30, false);
#line 17 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                  Write(Model.WelcomeAbout.Description);

#line default
#line hidden
            EndContext();
            BeginContext(511, 413, true);
            WriteLiteral(@"</p>
                    <p class=""hidden-sm"">I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system</p>
                    <a class=""default-btn"" href=""#"">view courses</a>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-img"">
                    ");
            EndContext();
            BeginContext(924, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ba8effeec1c462794178ceb0b97a736", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 934, "~/img/about/", 934, 12, true);
#line 24 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 946, Model.WelcomeAbout.Image, 946, 25, false);

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
            BeginContext(985, 318, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Teacher Start -->
<div class=""teacher-area pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            EndContext();
            BeginContext(1303, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b74217fdedf4adeb1a913e279a25d8e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1349, 143, true);
            WriteLiteral("\n                    <h2>meet our teachers</h2>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\">\n            ");
            EndContext();
            BeginContext(1493, 41, false);
#line 43 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
       Write(await Component.InvokeAsync("Teacher", 4));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 526, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Teacher End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
                <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                    <div class=""single-testimonial"">
                        <div class=""testimonial-info"">
                            <div class=""testimonial-img"">
                                ");
            EndContext();
            BeginContext(2060, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92eda529fa3f46bc89718921dc9a4d06", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2070, "~/img/testimonial/", 2070, 18, true);
#line 57 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2088, Model.Testimonial.Image, 2088, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2132, 134, true);
            WriteLiteral("\n                            </div>\n                            <div class=\"testimonial-content\">\n                                <p> ");
            EndContext();
            BeginContext(2267, 23, false);
#line 60 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                               Write(Model.Testimonial.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2290, 41, true);
            WriteLiteral("</p>\n                                <h4>");
            EndContext();
            BeginContext(2332, 22, false);
#line 61 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                               Write(Model.Testimonial.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2354, 42, true);
            WriteLiteral("</h4>\n                                <h5>");
            EndContext();
            BeginContext(2397, 26, false);
#line 62 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                               Write(Model.Testimonial.Position);

#line default
#line hidden
            EndContext();
            BeginContext(2423, 469, true);
            WriteLiteral(@"</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>");
            EndContext();
            BeginContext(2893, 21, false);
#line 78 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                   Write(Model.VideoTour.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2914, 164, true);
            WriteLiteral("</h3>\n                    <div class=\"notice-video\">\n                        <div class=\"video-icon video-hover\">\n                            <a class=\"video-popup\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3078, "\"", 3111, 1);
#line 81 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
WriteAttributeValue("", 3085, Model.VideoTour.VideoLink, 3085, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3112, 390, true);
            WriteLiteral(@">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
");
            EndContext();
#line 92 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                         foreach (var notice in Model.NoticeBoards)
                        {

#line default
#line hidden
            BeginContext(3596, 101, true);
            WriteLiteral("                        <div class=\"single-notice-left mb-23 pb-20\">\n                            <h4>");
            EndContext();
            BeginContext(3698, 42, false);
#line 95 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                           Write(notice.Date.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3740, 37, true);
            WriteLiteral("</h4>\n                            <p>");
            EndContext();
            BeginContext(3778, 18, false);
#line 96 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"
                          Write(notice.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3796, 36, true);
            WriteLiteral("</p>\n                        </div>\n");
            EndContext();
#line 98 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\About\Index.cshtml"

                        }

#line default
#line hidden
            BeginContext(3859, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5141, 152, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n<!-- Notice End -->\n<!-- Subscribe Start -->\n");
            EndContext();
            BeginContext(5293, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4ebff702b5749689bcc6e83d66165d0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5329, 24, true);
            WriteLiteral("\n<!-- Subscribe End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
