#pragma checksum "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3df804e58cf1801181d3be0ee4b911c2b377244f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
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
#line 3 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
using Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df804e58cf1801181d3be0ee4b911c2b377244f", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9603523de66aae69f725aa75b5417c97c3108d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Playground>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/dialog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("playground"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("checkBooking()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/BookingJs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
  
    //var periods = (List<PlayGroundTimesViewModel>)ViewBag.times;
    var selectedDate = DateTime.Now.Date;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3df804e58cf1801181d3be0ee4b911c2b377244f6896", async() => {
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
            WriteLiteral("\r\n<div class=\"fullWidth\">\r\n    <img class=\"center-fit\" style=\"width: 100%; height: 50vh;\"");
            BeginWriteAttribute("src", " src=\"", 449, "\"", 529, 1);
#nullable restore
#line 13 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
WriteAttributeValue("", 455, string.Concat(@config.GetSection("AdminPanelUrl").Value,@Model.ImagePath), 455, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
</div>

<div class=""row"">
    <div class=""col-md-5"">
        <h1>Overview</h1>
        <p class=""d-block"">
            Finswimming is an underwater sport consisting of four techniques involving swimming with
            the use of fins either on the water's surface using a snorkel
        </p>
        <div>
            <i id=""1"" onclick=""updateRate(this)"" class=""fa fa-star"" style=""color:aliceblue;cursor:pointer;font-size: 45px;""></i>
            <i id=""2"" onclick=""updateRate(this)"" class=""fa fa-star"" style=""color:aliceblue;cursor:pointer;font-size: 45px;""></i>
            <i id=""3"" onclick=""updateRate(this)"" class=""fa fa-star"" style=""color:aliceblue;cursor:pointer;font-size: 45px;""></i>
            <i id=""4"" onclick=""updateRate(this)"" class=""fa fa-star"" style=""color:aliceblue;cursor:pointer;font-size: 45px;""></i>
            <i id=""5"" onclick=""updateRate(this)"" class=""fa fa-star"" style=""color:aliceblue;cursor:pointer;font-size: 45px;""></i>
        </div>
    </div>

    <div class=""col-");
            WriteLiteral("md-2\" id=\"bookDetails\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3df804e58cf1801181d3be0ee4b911c2b377244f9664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 33 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PlaygroundId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"date\" class=\"control-label\"></label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3df804e58cf1801181d3be0ee4b911c2b377244f11507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 36 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => selectedDate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"period\" class=\"control-label\">Select period</label>\r\n            <select name=\"period\" class=\"form-control\" id=\"periods\" onchange=\"onChangeSelectedPeriod(this.value)\">\r\n");
            WriteLiteral(@"            </select>
            <label id=""message""></label>
        </div>
        <div class=""form-group"">
            <input type=""submit"" id=""bookBtn"" value=""Book"" onclick=""Confirm.render()"" class=""btn btn-primary"" />
        </div>
    </div>

    <div class=""col-md-5"">

        <table style=""width:50%;position:relative;left:22%"">
            <tbody>
                <tr>
                    <th>Name</th>
                    <td>");
#nullable restore
#line 59 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>City</th>\r\n                    <td>");
#nullable restore
#line 63 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                   Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Area</th>\r\n                    <td>");
#nullable restore
#line 67 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                   Write(Model.StadiumArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Number Of Players</th>\r\n                    <td>");
#nullable restore
#line 71 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                   Write(Model.NumOfPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>AM Price</th>\r\n                    <td>");
#nullable restore
#line 76 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                   Write(Model.AmPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>PM Price</th>\r\n                    <td>");
#nullable restore
#line 81 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                   Write(Model.PmPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Rate</th>\r\n                    <td class=\"Stars\"");
            BeginWriteAttribute("style", " style=\"", 3562, "\"", 3592, 3);
            WriteAttributeValue("", 3570, "--rating:", 3570, 9, true);
#nullable restore
#line 86 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
WriteAttributeValue(" ", 3579, Model.Rate, 3580, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3591, ";", 3591, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-label", " aria-label=\"", 3593, "\"", 3653, 9);
            WriteAttributeValue("", 3606, "Rating", 3606, 6, true);
            WriteAttributeValue(" ", 3612, "of", 3613, 3, true);
            WriteAttributeValue(" ", 3615, "this", 3616, 5, true);
            WriteAttributeValue(" ", 3620, "product", 3621, 8, true);
            WriteAttributeValue(" ", 3628, "is", 3629, 3, true);
#nullable restore
#line 86 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
WriteAttributeValue(" ", 3631, Model.Rate, 3632, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3643, "out", 3644, 4, true);
            WriteAttributeValue(" ", 3647, "of", 3648, 3, true);
            WriteAttributeValue(" ", 3650, "5.", 3651, 3, true);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th>Status</th>\r\n                    <td>");
#nullable restore
#line 91 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                   Write(Model.PlaygroundStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n");
#nullable restore
#line 94 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                 if (Model.Services != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>Services</th>\r\n                        <td>");
#nullable restore
#line 98 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"
                       Write(Model.Services);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "D:\Courses\Intake41\MVC\MVCProject\La3bni\La3bni.UI\Views\Booking\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div id=""dialogoverlay""></div>
<div id=""dialogbox"">
    <div>
        <div id=""dialogboxhead""></div>
        <div id=""dialogboxbody""></div>
        <div id=""dialogboxfoot""></div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3df804e58cf1801181d3be0ee4b911c2b377244f19233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration config { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Playground> Html { get; private set; }
    }
}
#pragma warning restore 1591
