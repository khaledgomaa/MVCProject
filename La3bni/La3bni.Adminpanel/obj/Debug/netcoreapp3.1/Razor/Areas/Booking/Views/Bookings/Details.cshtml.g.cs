#pragma checksum "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80222e61c5a01836a4d618b17c690e8350e9ff27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Booking_Views_Bookings_Details), @"mvc.1.0.view", @"/Areas/Booking/Views/Bookings/Details.cshtml")]
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
#line 3 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80222e61c5a01836a4d618b17c690e8350e9ff27", @"/Areas/Booking/Views/Bookings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00e932f77369a96fc1656e69a59900646d64ade7", @"/Areas/Booking/Views/_ViewImports.cshtml")]
    public class Areas_Booking_Views_Bookings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Booking</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Playground));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Playground.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlaygroundTimes.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlaygroundTimes.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlaygroundTimes.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlaygroundTimes.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.BookingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxNumOfPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.Adminpanel\Areas\Booking\Views\Bookings\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxNumOfPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80222e61c5a01836a4d618b17c690e8350e9ff279308", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
