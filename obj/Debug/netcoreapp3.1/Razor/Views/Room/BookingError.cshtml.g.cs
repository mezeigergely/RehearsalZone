#pragma checksum "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\BookingError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "621a536d535ab4accba240a42055b7301e2009ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_BookingError), @"mvc.1.0.view", @"/Views/Room/BookingError.cshtml")]
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
#line 1 "F:\codecool\C# Web\PA\MySite-MVC\Views\_ViewImports.cshtml"
using MySite_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\codecool\C# Web\PA\MySite-MVC\Views\_ViewImports.cshtml"
using MySite_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"621a536d535ab4accba240a42055b7301e2009ff", @"/Views/Room/BookingError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c19b4ae3aad3d85338dd39d9633cbb35f62764b", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_BookingError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySite_MVC.Domain.Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\BookingError.cshtml"
  
    ViewData["Title"] = "MakeBooking";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Wrong input!</h1>

<div>
    <h4>Please check Rehearsal Room ID / Booking date!</h4>
    <hr />
</div>
<div>
    <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Red_X.svg/1200px-Red_X.svg.png"" width=""100"" height=""100""/>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MySite_MVC.Domain.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591