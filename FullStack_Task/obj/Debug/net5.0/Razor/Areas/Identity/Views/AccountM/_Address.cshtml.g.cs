#pragma checksum "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85fa2b32863238d612aad4f44683b419a0463b2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_AccountM__Address), @"mvc.1.0.view", @"/Areas/Identity/Views/AccountM/_Address.cshtml")]
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
#line 2 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
using FullStack_Task.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
using FullStack_Task.HorizontalClasses;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85fa2b32863238d612aad4f44683b419a0463b2b", @"/Areas/Identity/Views/AccountM/_Address.cshtml")]
    public class Areas_Identity_Views_AccountM__Address : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FullStack_Task.Areas.Identity.Models.ViewModels.AddressValidViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
  
    var countries = ViewData["Countries"] as IList<Country>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-6"" style=""margin: 0 auto;"">

        <iframe name=""forms_iframe"" style=""display: none;""></iframe>

        <form action=""/identity/api/validation/v1/AddressValid"" class=""registration-form"" method=""post""=""forms_iframe"">
            ");
#nullable restore
#line 17 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div asp-validation-summary=\"All\" class=\"text-danger\"></div>\r\n\r\n            <div class=\"form-group my-form-group\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3\">\r\n                        ");
#nullable restore
#line 23 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.Label("COUNTRY:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n");
#nullable restore
#line 26 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                         if (countries != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                       Write(Html.DropDownListFor(m => m.Country, new SelectList(@countries, "Country_name", "Country_name"), "select", new { @class = "form-control dropdown", @id = "country-selection" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                                                                                                                                                                                                            
                        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3 class=\"text-danger\">Token has expired</h3>\r\n");
#nullable restore
#line 31 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-md-1\">\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 35 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Country, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>

            <div class=""form-group my-form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 44 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.Label("OFFICE NAME:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        ");
#nullable restore
#line 47 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.TextBoxFor(m => m.OfficeName, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-1\">\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 51 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                       Write(Html.ValidationMessageFor(m => m.OfficeName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>

            <div class=""form-group my-form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 60 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.Label("ADDRESS:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        ");
#nullable restore
#line 63 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.TextBoxFor(m => m.Street, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-1\">\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 67 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Street, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>

            <div class=""form-group my-form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 76 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.Label("POSTAL CODE:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        ");
#nullable restore
#line 79 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.TextBoxFor(m => m.PostalCode, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-1\">\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 83 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                       Write(Html.ValidationMessageFor(m => m.PostalCode, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>

            <div class=""form-group my-form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 92 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.Label("CITY", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        ");
#nullable restore
#line 95 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.TextBoxFor(m => m.City, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-1\">\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 99 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                       Write(Html.ValidationMessageFor(m => m.City, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>

            </div>

            <div class=""form-group my-form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 109 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                   Write(Html.Label("STATE:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n");
#nullable restore
#line 112 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                         if (countries != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div id=\"state-drop-down\">\r\n                            <select class=\"form-control dropdown\" id=\"State\" name=\"State\">\r\n                                <option");
            BeginWriteAttribute("value", " value=\"", 5161, "\"", 5169, 0);
            EndWriteAttribute();
            WriteLiteral(">Select Country</option>\r\n                            </select>\r\n                        </div>                        ");
#nullable restore
#line 118 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                                                      }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3 class=\"text-danger\">Token has expired</h3>\r\n");
#nullable restore
#line 122 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Address.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""col-md-1"">
                        <span class=""target"">
                            <span asp-validation-for=""Sate"" class=""text-danger state-validation-message"">State Is Requiered.</span>
                        </span>
                    </div>
                </div>
            </div>
            <div class=""form-group my-form-group"" style=""display: none;"">
                <input type=""submit"" value=""Save"" />
            </div>
        </form>

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FullStack_Task.Areas.Identity.Models.ViewModels.AddressValidViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
