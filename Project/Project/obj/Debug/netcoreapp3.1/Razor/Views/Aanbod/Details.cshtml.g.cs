#pragma checksum "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e7787915c0a186c5cb05963d810debe80e97f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aanbod_Details), @"mvc.1.0.view", @"/Views/Aanbod/Details.cshtml")]
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
#line 1 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e7787915c0a186c5cb05963d810debe80e97f1", @"/Views/Aanbod/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Aanbod_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.ViewModels.ComputerDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/computer.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:auto; width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container t"">
    <div class=""featured-product"" style=""margin: 100px 0 50px;
    display: flex;
    align-items: flex-start;
    justify-content: space-around;"">
        <div class=""row"">
            <div class=""col-md-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "95e7787915c0a186c5cb05963d810debe80e97f14257", async() => {
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <h1>");
#nullable restore
#line 18 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
               Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <p>$");
#nullable restore
#line 21 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
                       Write(Model.Prijs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>Hier komt de rating</p>
                    </div>
                </div>
                <hr />
                <p>Beschrijving</p>
                <h4>Model</h4>
                <p>Hier komt combobox</p>
                <hr />
                <a href=""#"" class=""btn btn-primary"">In winkelmandje</a>
            </div>
        </div>
    </div>
</div>
<div class=""TechSpecs text-white GamePcContent"" style=""background-color:#8D99AE;"">
    <div class=""container Specs"">
        <div class=""row"">
            <h1>Tech Specs</h1>
            <hr />
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>CPU</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>cpu input</p>
                    </div>
                </");
            WriteLiteral("div>\r\n                <hr />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <p>CPU Cooler</p>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <p>");
#nullable restore
#line 59 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
                      Write(Model.CpuCooler);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                    <hr />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>GPU</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>GPU input</p>
                    </div>
                </div>
                <hr />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Ram</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>");
#nullable restore
#line 77 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
                      Write(Model.Ram);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                    <hr />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Opslag</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>");
#nullable restore
#line 86 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
                      Write(Model.Opslag);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                    <hr />
            </div>
            <div class=""col-md-6"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Moederbord</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>");
#nullable restore
#line 97 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
                      Write(Model.Moederbord);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <hr />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Voeding</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>Voeding input</p>
                    </div>
                </div>
                <hr />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Behuizing</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>");
#nullable restore
#line 115 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
                      Write(Model.Behuizing);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <hr />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Operating System</p>
                    </div>
                    <div class=""col-md-6"">
                        <p>");
#nullable restore
#line 124 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Aanbod\Details.cshtml"
                      Write(Model.OperatingSystem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                    <hr />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.ViewModels.ComputerDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
