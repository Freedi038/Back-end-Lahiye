#pragma checksum "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dc414cba207d2d83ead70ab6b0e75164c717945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Detail.cshtml", typeof(AspNetCore.Views_Teacher_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dc414cba207d2d83ead70ab6b0e75164c717945", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5238128e7434fdaf904d8fd4d124de92181853c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;height:400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(54, 779, true);
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            EndContext();
            BeginContext(833, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3816dd08ab384ad4a065caa3913c3234", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 843, "~/img/teacher/", 843, 14, true);
#line 29 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 857, Model.Image, 857, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(918, 181, true);
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\n                <div class=\"teacher-details-content ml-50\">\n                    <h2>");
            EndContext();
            BeginContext(1100, 14, false);
#line 34 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 30, true);
            WriteLiteral("</h2>\n                    <h5>");
            EndContext();
            BeginContext(1145, 14, false);
#line 35 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                   Write(Model.Position);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 67, true);
            WriteLiteral("</h5>\n                    <h4>about me</h4>\n                    <p>");
            EndContext();
            BeginContext(1227, 13, false);
#line 37 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                  Write(Model.AboutMe);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 79, true);
            WriteLiteral("</p>\n                    <ul>\n                        <li><span>degree: </span>");
            EndContext();
            BeginContext(1320, 12, false);
#line 39 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(1332, 59, true);
            WriteLiteral("</li>\n                        <li><span>experience: </span>");
            EndContext();
            BeginContext(1392, 16, false);
#line 40 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1408, 56, true);
            WriteLiteral("</li>\n                        <li><span>hobbies: </span>");
            EndContext();
            BeginContext(1465, 11, false);
#line 41 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                                             Write(Model.Hobby);

#line default
#line hidden
            EndContext();
            BeginContext(1476, 56, true);
            WriteLiteral("</li>\n                        <li><span>faculty: </span>");
            EndContext();
            BeginContext(1533, 13, false);
#line 42 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 300, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
            EndContext();
            BeginContext(1847, 10, false);
#line 51 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                                         Write(Model.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(1857, 55, true);
            WriteLiteral("</p>\n                    <p><span>make a call : </span>");
            EndContext();
            BeginContext(1913, 17, false);
#line 52 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                                             Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1930, 49, true);
            WriteLiteral("</p>\n                    <p><span>skype : </span>");
            EndContext();
            BeginContext(1980, 11, false);
#line 53 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
                                       Write(Model.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(1991, 60, true);
            WriteLiteral("</p>\n                    <ul>\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2051, "\"", 2073, 1);
#line 55 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2058, Model.Facebook, 2058, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2074, 75, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2149, "\"", 2172, 1);
#line 56 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2156, Model.Pinterest, 2156, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2173, 76, true);
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2249, "\"", 2271, 1);
#line 57 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2256, Model.VContact, 2256, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2272, 72, true);
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2344, "\"", 2365, 1);
#line 58 "C:\Users\ASUS\Downloads\BackEndProjectCodeAcademy-main\BackEndProjectCodeAcademy-main\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2351, Model.Twitter, 2351, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2366, 4685, true);
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">85%</span>
                                    </div>
                                </div>
                            </div>
                   ");
            WriteLiteral(@"     </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 90%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">90%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""");
            WriteLiteral(@"width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">85%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">95%</span>
                                    </div>
                                </div>
    ");
            WriteLiteral(@"                        </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">85%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div dat");
            WriteLiteral(@"a-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">95%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
<!-- Subscribe Start -->
");
            EndContext();
            BeginContext(7051, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6de827ab4d7a4c9fa3c48f1dc6df87de", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7086, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
