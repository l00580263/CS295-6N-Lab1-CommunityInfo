#pragma checksum "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\Locations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baad0067a245bfae75c5f99e4139bed03e077e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_Locations), @"mvc.1.0.view", @"/Views/Info/Locations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/Locations.cshtml", typeof(AspNetCore.Views_Info_Locations))]
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
#line 1 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\_ViewImports.cshtml"
using CommunityInformation;

#line default
#line hidden
#line 2 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\_ViewImports.cshtml"
using CommunityInformation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baad0067a245bfae75c5f99e4139bed03e077e3c", @"/Views/Info/Locations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffa799a70419aec2cd173beee98bc5576b95231", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_Locations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Cameron Files\School\LCC\CS 295n\Lab 1\CommunityInfo\CommunityInformation\CommunityInformation\Views\Info\Locations.cshtml"
  
    //Layout = null;

#line default
#line hidden
            BeginContext(29, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n\r\n");
            EndContext();
            BeginContext(60, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32ff85ed822b43e0adb696c4d03b4553", async() => {
                BeginContext(66, 103, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Donbass Locations</title>\r\n    ");
                EndContext();
                BeginContext(169, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da5fd5325d204487b4be97ffd6d9ecee", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(238, 16, true);
                WriteLiteral("\r\n    <link />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(261, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(267, 2929, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd12ed986823454ea180a97e194d7c23", async() => {
                BeginContext(273, 2916, true);
                WriteLiteral(@"
    <h1 class=""text-center text-primary"">Must See Locations of Donbass</h1>
    <br>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""thumbnail"">
                    <img class=""img-rounded img-responsive"" src=""https://upload.wikimedia.org/wikipedia/commons/c/ce/Ruins_of_Donetsk_International_airport_%2816%29.jpg"" alt=""Donetsk Airport"" />
                    <div class=""caption"">
                        Ruins of Donetsk Sergey Prokofiev International Airport, December 24, 2014. by <a href=""https://www.youtube.com/channel/UCB6qcolOfP23ckDu3Bd8fvw"">Правда ДНР</a> is licensed under <a href=""https://creativecommons.org/licenses/by/3.0/deed.en"">CC BY 3.0</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <h3>Donetsk International Airport</h3>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore
");
                WriteLiteral(@"                et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
                ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
                nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id
                est laborum.
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""thumbnail"">
                    <img class=""img-rounded img-responsive"" src=""https://upload.wikimedia.org/wikipedia/commons/9/9d/%D0%94%D0%BE%D1%80%D0%BE%D0%B3%D0%B0_%D0%BD%D0%B0_%D0%94%D0%B5%D0%B1%D0%B0%D0%BB%D1%8C%D1%86%D0%B5%D0%B2%D0%B5_%2816170898900%29.jpg"" alt=""Debaltseve"" />
                    <div class=""caption"">
                        The road is in rocket holes and craters, with broken bridges and empty without transport by <a href=""https://www.flickr.com/peopl");
                WriteLiteral(@"e/83934818@N03"">Viktor Kovalenko</a> is licensed under <a href=""https://creativecommons.org/licenses/by-sa/2.0/deed.en"">CC BY-SA 2.0</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <h3>Debaltseve</h3>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore
                et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip
                ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
                nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id
                est laborum.
            </div>
        </div>
    </div>



");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3196, 9, true);
            WriteLiteral("\r\n</html>");
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
