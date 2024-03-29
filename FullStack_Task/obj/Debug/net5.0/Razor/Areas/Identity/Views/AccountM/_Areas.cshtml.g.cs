#pragma checksum "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da54e3ab3fe756f4b1d2b13a8e0dd5eacb775302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_AccountM__Areas), @"mvc.1.0.view", @"/Areas/Identity/Views/AccountM/_Areas.cshtml")]
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
#line 2 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
using FullStack_Task.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
using FullStack_Task.HorizontalClasses;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da54e3ab3fe756f4b1d2b13a8e0dd5eacb775302", @"/Areas/Identity/Views/AccountM/_Areas.cshtml")]
    public class Areas_Identity_Views_AccountM__Areas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FullStack_Task.Areas.Identity.Models.ViewModels.AreasValidViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 7 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
  
    var areas = ViewData["Areas"] as IList<BusinessArea>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<iframe name=\"forms_iframe\" style=\"display: none;\"></iframe>\r\n\r\n\r\n<form action=\"/identity/api/validation/v1/AreasValid\" class=\"registration-form\" method=\"post\" target=\"forms_iframe\">\r\n    ");
#nullable restore
#line 17 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div asp-validation-summary=""All"" class=""text-danger""></div>

    <div class=""row"" style=""margin-left: 5%; padding-left: 5%;"">
        <div class=""col-md-6"">
            <span class=""target"">
                <span asp-validation-for=""BusinessAreas"" class=""text-danger areas-validation-message"">At list one Buisnes Area must be selected.</span>
            </span>
            ");
#nullable restore
#line 25 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
       Write(Html.Label("Business Areas", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
             foreach (var area in areas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"margin-left: 5%;\">\r\n                    <input type=\"checkbox\" class=\"area\" id=\"area\" name=\"Areas.BusinessAreas\"");
            BeginWriteAttribute("value", " value=\"", 1115, "\"", 1131, 1);
#nullable restore
#line 29 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
WriteAttributeValue("", 1123, area.ID, 1123, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    ");
#nullable restore
#line 30 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
               Write(Html.Label(area.Name, null, new { @class = "my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 32 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 36 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
           Write(Html.Label("Business Areas", null, new { @class = "required my-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
           Write(Html.TextAreaFor(m => m.Comment, new { @class = "form-control required my-label", @cols = 3, @rows = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
           Write(Html.Label("LET US KNOW FOR WHICH NETWORK YOU ARE REQUESTING ACCESS, AND ANY OTHER COMMENTS YOU'D LIKE TO LEAV US", null, new { @class = "details" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"target\">\r\n                    ");
#nullable restore
#line 40 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\_Areas.cshtml"
               Write(Html.ValidationMessageFor(m => m.Comment, null, new { @class = "text-danger", @style = "margin: auto 0;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group my-form-group\" style=\"display: none;\">\r\n            <input type=\"submit\" value=\"Save\" />\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FullStack_Task.Areas.Identity.Models.ViewModels.AreasValidViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
