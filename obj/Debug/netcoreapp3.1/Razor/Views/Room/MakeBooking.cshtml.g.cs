#pragma checksum "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adfe1a81e568ae425e90c5ff74e3268bf4eebbfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_MakeBooking), @"mvc.1.0.view", @"/Views/Room/MakeBooking.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adfe1a81e568ae425e90c5ff74e3268bf4eebbfd", @"/Views/Room/MakeBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c19b4ae3aad3d85338dd39d9633cbb35f62764b", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_MakeBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySite_MVC.Domain.Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml"
  
    ViewData["Title"] = "MakeBooking";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>You successfully created your booking!</h1>\r\n\r\n<div>\r\n    <h4>Details:</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml"
       Write(Html.DisplayNameFor(model => model.User_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml"
       Write(Html.DisplayFor(model => model.User_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml"
       Write(Html.DisplayNameFor(model => model.Rehearsal_Room_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml"
       Write(Html.DisplayFor(model => model.Rehearsal_Room_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml"
       Write(Html.DisplayNameFor(model => model.Booking_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "F:\codecool\C# Web\PA\MySite-MVC\Views\Room\MakeBooking.cshtml"
       Write(Html.DisplayFor(model => model.Booking_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <img src=\"https://cdn2.iconfinder.com/data/icons/internet-download-manager-1/64/11_Completed_check_tick_verified_approved-512.png\" width=\"100\" height=\"100\"/>\r\n</div>\r\n\r\n");
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
