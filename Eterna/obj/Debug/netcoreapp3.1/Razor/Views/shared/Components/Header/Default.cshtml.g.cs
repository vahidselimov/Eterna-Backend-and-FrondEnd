#pragma checksum "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc786b4e9944ebacb728b7d10877b33bfd3405bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\_ViewImports.cshtml"
using Eterna.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
using Eterna.Properties.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc786b4e9944ebacb728b7d10877b33bfd3405bd", @"/Views/shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86394773dd3cd7fc70c65eab423085b76db27e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header>\r\n        <div class=\"header\">\r\n            <div class=\"container \">\r\n                <div class=\"row\">\r\n                    <div class=\"contact col-lg-6 col-md-6 d-flex align-items-center\">\r\n                        <div class=\"gmail\"><i><i");
            BeginWriteAttribute("class", " class=\"", 300, "\"", 333, 1);
#nullable restore
#line 8 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 308, Model.Settings.GmailIcon, 308, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></i>");
#nullable restore
#line 8 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
                                                                                      Write(Model.Settings.Gmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span></span>\r\n                        </div>\r\n\r\n                        <div class=\"phone\"><i><i");
            BeginWriteAttribute("class", " class=\"", 462, "\"", 495, 1);
#nullable restore
#line 11 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 470, Model.Settings.PhoneIcon, 470, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></i><span>");
#nullable restore
#line 11 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
                                                                                            Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                    </div>\r\n                    <div class=\"socialmedias col-md-6 d-md-flex   justify-content-end\">\r\n");
#nullable restore
#line 14 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
                         foreach (HeaderSocialMedias socialMedias in Model.headerSocialMedias)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <a");
            BeginWriteAttribute("href", " href=\"", 813, "\"", 820, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", "\r\n                                class=\"", 824, "\"", 888, 1);
#nullable restore
#line 17 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 865, socialMedias.SocialUrl, 865, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\n");
#nullable restore
#line 18 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
                       }         

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""eterna d-flex justify-content-between align-items-center "">
                    <div class=""logo col-lg-6 col-md-6"">

                       <h1><span>");
#nullable restore
#line 28 "C:\Users\Asus\Desktop\Eternaa\Eterna\Views\shared\Components\Header\Default.cshtml"
                            Write(Model.AnotherSettings.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n                    </div>\r\n                    <nav class=\"navbar col-lg-6 col-md-6\">\r\n                        <ul class=\"d-flex\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1465, "\"", 1472, 0);
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\r\n                            <li> <a");
            BeginWriteAttribute("href", " href=\"", 1524, "\"", 1531, 0);
            EndWriteAttribute();
            WriteLiteral(">About</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1583, "\"", 1590, 0);
            EndWriteAttribute();
            WriteLiteral(">Services</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1645, "\"", 1652, 0);
            EndWriteAttribute();
            WriteLiteral(">Portfoilo</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1708, "\"", 1715, 0);
            EndWriteAttribute();
            WriteLiteral(">Team</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1766, "\"", 1773, 0);
            EndWriteAttribute();
            WriteLiteral(">Pricing</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1827, "\"", 1834, 0);
            EndWriteAttribute();
            WriteLiteral(">Blog</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1885, "\"", 1892, 0);
            EndWriteAttribute();
            WriteLiteral(">Contact</a></li>\r\n                        </ul>\r\n                    </nav>\r\n                    <div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
