#pragma checksum "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b601010f1c85781825d8a1cfe8a093d448d71a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GamePcDetails), @"mvc.1.0.view", @"/Views/Admin/GamePcDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b601010f1c85781825d8a1cfe8a093d448d71a", @"/Views/Admin/GamePcDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_GamePcDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.ViewModels.ComputerDetailsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container TechSpecs\" style=\"margin-top:5%; margin-bottom:20%;\">\r\n    ");
#nullable restore
#line 10 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
Write(Html.ActionLink("Terug","GamePc","Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <img src=\"/images/computer.jpg\" style=\"height:auto; width:100%;\"/>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <p>\r\n                <b>Id:</b> ");
#nullable restore
#line 17 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Naam:</b> ");
#nullable restore
#line 21 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                        Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Prijs:</b> ");
#nullable restore
#line 25 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                         Write(Model.Prijs);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>OperatingSystem:</b> ");
#nullable restore
#line 29 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                                   Write(Model.OperatingSystem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Ram:</b> ");
#nullable restore
#line 33 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                       Write(Model.Ram);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Moederbord:</b> ");
#nullable restore
#line 37 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                              Write(Model.Moederbord);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <p>\r\n                <b>CpuCooler:</b> ");
#nullable restore
#line 43 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                             Write(Model.CpuCooler);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Behuizing:</b> ");
#nullable restore
#line 47 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                             Write(Model.Behuizing);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Opslag:</b> ");
#nullable restore
#line 51 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                          Write(Model.Opslag);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Cpu:</b> ");
#nullable restore
#line 55 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                       Write(Model.Cpu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n            <p>\r\n                <b>Gpu:</b> ");
#nullable restore
#line 59 "C:\Users\Jordy's Laptop\Desktop\test_webapp\ProjectWebApplicaties\Project\Project\Views\Admin\GamePcDetails.cshtml"
                       Write(Model.Gpu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
