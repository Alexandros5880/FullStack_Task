#pragma checksum "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2649ce09264846d32ed6030d7ed327cb3e97ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_AccountM_Register), @"mvc.1.0.view", @"/Areas/Identity/Views/AccountM/Register.cshtml")]
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
#line 2 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
using FullStack_Task.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
using FullStack_Task.HorizontalClasses;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b2649ce09264846d32ed6030d7ed327cb3e97ae", @"/Areas/Identity/Views/AccountM/Register.cshtml")]
    public class Areas_Identity_Views_AccountM_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FullStack_Task.Areas.Identity.Models.ViewModels.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Register.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/servicies/RegistrationServicies.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Register.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.13.0/css/all.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b2649ce09264846d32ed6030d7ed327cb3e97ae5260", async() => {
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
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"




<div class=""container registration-div"">

    <h3>New User Registration</h3>
    <h6 class=""display-screen""></h6>

    <div class=""row my-form"">
        <!-- Left Side Proccess Bar -->
        <div class=""col-lg-2 progress-container"">
            <div class=""card1"">
                <ul id=""progressbar"" class=""text-center"">
                    <li class=""active one"" data-counter=""1""></li>
                    <li class=""step0 tow"" data-counter=""2""></li>
                    <li class=""step0 three"" data-counter=""3""></li>
                    <li class=""step0 four"" data-counter=""4""></li>
                    <li class=""step0 five"" data-counter=""5""></li>
                </ul>
                <div id=""progressbar-titles"">
                    <h6 class=""mb-5"" data-counter=""1"">Contact Info</h6>
                    <h6 class=""mb-5"" data-counter=""2"">Areas</h6>
                    <h6 class=""mb-5"" data-counter=""3"">Address</h6>
                    <h6 class=""mb-5"" data-counter=""4"">Password</h6>");
            WriteLiteral(@"
                    <h6 class=""mb-5"" data-counter=""5"">Completed</h6>
                </div>
            </div>
        </div>
        <!-- Steps Container -->
        <div class=""col-lg-10 steps-container"">

            <!-- Contact Info -->
            <div class=""card2 first-screen show ml-2"" data-counter=""1"">
                <input name=""title"" type=""hidden"" value=""STEP 1: Contact Info"" />
");
#nullable restore
#line 49 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                 if (Model != null && Model.Contact != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_ContactInfo", Model.Contact));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                                           
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_ContactInfo"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                            
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <!-- Areas -->\r\n            <div class=\"card2 ml-2\" data-counter=\"2\">\r\n                <input name=\"title\" type=\"hidden\" value=\"STEP 2: Areas\" />\r\n");
#nullable restore
#line 63 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                 if (Model != null && Model.Areas != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_Areas", Model.Areas));

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                                   
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_Areas"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                      
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <!-- Address -->\r\n            <div class=\"card2 ml-2\" data-counter=\"3\">\r\n                <input name=\"title\" type=\"hidden\" value=\"STEP 3: Address\" />\r\n");
#nullable restore
#line 76 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                 if (Model != null && Model.Address != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_Address", Model.Address));

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                                       
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_Address"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                        
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <!-- Password -->\r\n            <div class=\"card2 ml-2\" data-counter=\"4\">\r\n                <input name=\"title\" type=\"hidden\" value=\"STEP 4: Password\" />\r\n");
#nullable restore
#line 89 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                 if (Model != null && Model.Password != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_Password", Model.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                                         
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
               Write(await Html.PartialAsync("_Password"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
                                                         
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <!-- Completed -->
            <div class=""card2 ml-2 last-screen"" data-counter=""5"">
                <input name=""title"" type=""hidden"" value=""STEP 5: Completed"" />
                <div class=""row"">
                    <div class=""row"">
                        <div class=""col-md-1"">
                            <img alt=""check""");
            BeginWriteAttribute("src", " src=\"", 3866, "\"", 3906, 1);
#nullable restore
#line 105 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
WriteAttributeValue("", 3872, Url.Content("~/images/check.jpg"), 3872, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""33"" height=""33"" />
                        </div>
                        <div class=""col-md-11"">
                            <h3>Thank you for registering!</h3>
                            <p>
                                A registration confirmation email was sent to the email address provided. Your registration will be sent
                                for approval and activation to the Administrator. <strong>
                                    You will receive an email when your account is ready
                                    to use.
                                </strong>
                            </p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <br/>

    <!-- Back | To Login -->
    <div id=""back-login"">
        <div style=""width: 100%; height: 40px;"">
            <!-- Go To Login -->
            <a href=""/Identity/Account/Login"">Back to login</a>
            <!-- Go ");
            WriteLiteral(@"Back -->
            <div style=""display: flex; float: right;"">
                <button class=""prev btn btn-light"">Back</button>
                <button class=""next-button btn btn-primary"">Next</button>
            </div>
        </div>
    </div>

</div>








");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 151 "F:\Programming\Pojects\WORKING\FULLSTACK_TASK_PROJECT\FullStack_Task\FullStack_Task\Areas\Identity\Views\AccountM\Register.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b2649ce09264846d32ed6030d7ed327cb3e97ae17493", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b2649ce09264846d32ed6030d7ed327cb3e97ae18680", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FullStack_Task.Areas.Identity.Models.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
