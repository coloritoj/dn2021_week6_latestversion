#pragma checksum "C:\Users\color\source\repos\dn2021_week6\MVCDemo\Views\Home\htmlpage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0165f271f920a3ef88d60b77d1788f9ad02770"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_htmlpage), @"mvc.1.0.view", @"/Views/Home/htmlpage.cshtml")]
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
#line 1 "C:\Users\color\source\repos\dn2021_week6\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\color\source\repos\dn2021_week6\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0165f271f920a3ef88d60b77d1788f9ad02770", @"/Views/Home/htmlpage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c82645f380a66647f653cb87c3f0bf90f91097", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_htmlpage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\color\source\repos\dn2021_week6\MVCDemo\Views\Home\htmlpage.cshtml"
  
    ViewData["Title"] = "htmlpage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome to my page!</h1>\r\nThis is my new webpage!\r\nThe date and time is ");
#nullable restore
#line 8 "C:\Users\color\source\repos\dn2021_week6\MVCDemo\Views\Home\htmlpage.cshtml"
                Write(ViewBag.RightNow);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2>");
#nullable restore
#line 9 "C:\Users\color\source\repos\dn2021_week6\MVCDemo\Views\Home\htmlpage.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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