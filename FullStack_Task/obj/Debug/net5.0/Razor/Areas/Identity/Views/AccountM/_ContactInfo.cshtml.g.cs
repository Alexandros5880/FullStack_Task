#pragma checksum "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df98e55e1ff82a9719b0e04c18837e3b24b470a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_AccountM__ContactInfo), @"mvc.1.0.view", @"/Areas/Identity/Views/AccountM/_ContactInfo.cshtml")]
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
#line 2 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
using FullStack_Task.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
using FullStack_Task.HorizontalClasses;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df98e55e1ff82a9719b0e04c18837e3b24b470a9", @"/Areas/Identity/Views/AccountM/_ContactInfo.cshtml")]
    public class Areas_Identity_Views_AccountM__ContactInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FullStack_Task.Areas.Identity.Models.ViewModels.ContactValidViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
   
    var salutations = ViewData["Salutations"] as IList<Salutation>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<iframe name=\"forms_iframe\" style=\"display: none;\"></iframe>\r\n\r\n<form action=\"/identity/api/validation/v1/ContactValid\" class=\"registration-form\" method=\"post\" target=\"forms_iframe\" >\r\n    ");
#nullable restore
#line 14 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

    <div class=""row"">

        <div class=""col-md-6"">
            <div class=""form-group my-form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 23 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("SALUTATION:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 26 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.DropDownListFor(m => m.SalutationId, new SelectList(@salutations, "ID", "Name"), "select", new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("EMAIL WILL BE YOUR LOGIN", null, new { @class = "details hidden" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 29 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.SalutationId, null, new { @class = "text-danger" }));

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
#line 37 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("FIRSTNAME:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 40 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 42 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.FirstName, null, new { @class = "text-danger" }));

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
#line 50 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("MIDDLE NAME:", null, new { @class = " my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 53 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.MiddleName, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 55 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.MiddleName, null, new { @class = "text-danger" }));

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
#line 63 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("LAST NAME:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 66 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 68 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.LastName, null, new { @class = "text-danger" }));

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
#line 76 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("COMPANY:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 79 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.Company, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 81 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Company, null, new { @class = "text-danger" }));

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
#line 89 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("TITLE:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 92 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.Title, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 94 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Title, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""form-group my-form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 105 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("EMAIL:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 108 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 109 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("EMAIL WILL BE YOUR LOGIN", null, new { @class = "details" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 111 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Email, null, new { @class = "text-danger" }));

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
#line 119 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("CONFIRM EMAIL:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 122 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.ConfirmEmail, new { @class = "form-control myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 124 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.ConfirmEmail, null, new { @class = "text-danger" }));

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
#line 132 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("PHONE:", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 135 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control phone myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 137 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Phone, null, new { @class = "text-danger" }));

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
#line 145 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("FAX:", null, new { @class = " my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 148 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.Fax, new { @class = "form-control fax myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 150 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Fax, null, new { @class = "text-danger" }));

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
#line 158 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.Label("MOBILE:", null, new { @class = " my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 161 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                   Write(Html.TextBoxFor(m => m.Mobile, new { @class = "form-control mobile myinput" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"target\">\r\n                            ");
#nullable restore
#line 163 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_ContactInfo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Mobile, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>
            <div class=""form-group my-form-group"" style=""display: none;"">
                <input type=""submit"" value=""Save"" />
            </div>
        </div>

    </div>
</form>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FullStack_Task.Areas.Identity.Models.ViewModels.ContactValidViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
