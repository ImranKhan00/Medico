#pragma checksum "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a90030e222f1244008408f49b2326209fad09cda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Login), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Login.cshtml")]
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
#line 1 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\_ViewImports.cshtml"
using Medico.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\_ViewImports.cshtml"
using Medico.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Medico.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90030e222f1244008408f49b2326209fad09cda", @"/Areas/Identity/Pages/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6536a6cb3a24b268e897674451f20bba3ec4b94f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67817beebd74486bd74f3f0070208e37e82cc68", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://themesbrand.com/skote/layouts/vertical/index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\Account\Login.cshtml"
  
    ViewData["Title"] = "Log in";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n\r\n<!-- Mirrored from themesbrand.com/skote/layouts/vertical/auth-login.html by HTTrack Website Copier/3.x [XR&CO\'2014], Fri, 21 Feb 2020 09:12:15 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a90030e222f1244008408f49b2326209fad09cda5905", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Login | Skote - Responsive Bootstrap 4 Admin Dashboard</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta content=""Premium Multipurpose Admin & Dashboard Template"" name=""description"" />
    <meta content=""Themesbrand"" name=""author"" />
    <!-- App favicon -->
    <link rel=""shortcut icon"" href=""assets/images/favicon.ico"">

    <!-- Bootstrap Css -->
    <link href=""assets/css/bootstrap.min.css"" id=""bootstrap-style"" rel=""stylesheet"" type=""text/css"" />
    <!-- Icons Css -->
    <link href=""assets/css/icons.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- App Css-->
    <link href=""assets/css/app.min.css"" id=""app-style"" rel=""stylesheet"" type=""text/css"" />

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a90030e222f1244008408f49b2326209fad09cda7679", async() => {
                WriteLiteral(@"
    <div class=""home-btn d-none d-sm-block"">
        <a href=""index-2.html"" class=""text-dark""><i class=""fas fa-home h2""></i></a>
    </div>
    <div class=""account-pages my-5 pt-sm-5"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-8 col-lg-6 col-xl-5"">
                    <div class=""card overflow-hidden"">
                        <div class=""bg-soft-primary"">
                            <div class=""row"">
                                <div class=""col-7"">
                                    <div class=""text-primary p-4"">
                                        <h5 class=""text-primary"">Welcome Back !</h5>
                                        <p>Sign in to continue to Skote.</p>
                                    </div>
                                </div>
                                <div class=""col-5 align-self-end"">
                                    <img src=""assets/images/profile-img.png""");
                BeginWriteAttribute("alt", " alt=\"", 2059, "\"", 2065, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid"">
                                </div>
                            </div>
                        </div>
                        <div class=""card-body pt-0"">
                            <div>
                                <a href=""index-2.html"">
                                    <div class=""avatar-md profile-user-wid mb-4"">
                                        <span class=""avatar-title rounded-circle bg-light"">
                                            <img src=""assets/images/logo.svg""");
                BeginWriteAttribute("alt", " alt=\"", 2594, "\"", 2600, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle"" height=""34"">
                                        </span>
                                    </div>
                                </a>
                            </div>
                            <div class=""p-2"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a90030e222f1244008408f49b2326209fad09cda10105", async() => {
                    WriteLiteral(@"

                                    <div class=""form-group"">
                                        <label for=""username"">Username</label>
                                        <input type=""text"" class=""form-control"" id=""username"" placeholder=""Enter username"">
                                    </div>

                                    <div class=""form-group"">
                                        <label for=""userpassword"">Password</label>
                                        <input type=""password"" class=""form-control"" id=""userpassword"" placeholder=""Enter password"">
                                    </div>

                                    <div class=""custom-control custom-checkbox"">
                                        <input type=""checkbox"" class=""custom-control-input"" id=""customControlInline"">
                                        <label class=""custom-control-label"" for=""customControlInline"">Remember me</label>
                                    </div>

            ");
                    WriteLiteral(@"                        <div class=""mt-3"">
                                        <button class=""btn btn-primary btn-block waves-effect waves-light"" type=""submit"">Log In</button>
                                    </div>

                                    <div class=""mt-4 text-center"">
                                        <a href=""auth-recoverpw.html"" class=""text-muted""><i class=""mdi mdi-lock mr-1""></i> Forgot your password?</a>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>

                        </div>
                    </div>
                    <div class=""mt-5 text-center"">
                        <p>Don't have an account ? <a href=""auth-register.html"" class=""font-weight-medium text-primary""> Signup now </a> </p>
                        <p>© 2020 Skote. Crafted with <i class=""mdi mdi-heart text-danger""></i> by Themesbrand</p>
                    </div>

                </div>
            </div>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from themesbrand.com/skote/layouts/vertical/auth-login.html by HTTrack Website Copier/3.x [XR&CO\'2014], Fri, 21 Feb 2020 09:12:15 GMT -->\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a90030e222f1244008408f49b2326209fad09cda14768", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel>)PageContext?.ViewData;
        public LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
