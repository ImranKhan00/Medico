#pragma checksum "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d644a3295e3747278490f25b7c63ca2a68bb94a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Register), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d644a3295e3747278490f25b7c63ca2a68bb94a", @"/Areas/Identity/Pages/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6536a6cb3a24b268e897674451f20bba3ec4b94f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67817beebd74486bd74f3f0070208e37e82cc68", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Identity/Account/Register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Areas\Identity\Pages\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n\r\n<!-- Mirrored from themesbrand.com/skote/layouts/vertical/auth-register.html by HTTrack Website Copier/3.x [XR&CO\'2014], Fri, 21 Feb 2020 09:12:15 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d644a3295e3747278490f25b7c63ca2a68bb94a6165", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Register | Skote - Responsive Bootstrap 4 Admin Dashboard</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d644a3295e3747278490f25b7c63ca2a68bb94a7942", async() => {
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
                                        <h5 class=""text-primary"">Free Register</h5>
                                        <p>Get your free Skote account now.</p>
                                    </div>
                                </div>
                                <div class=""col-5 align-self-end"">
                                    <img src=""assets/images/profile-img.png""");
                BeginWriteAttribute("alt", " alt=\"", 2074, "\"", 2080, 0);
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
                BeginWriteAttribute("alt", " alt=\"", 2609, "\"", 2615, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle"" height=""34"">
                                        </span>
                                    </div>
                                </a>
                            </div>
                            <div class=""p-2"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d644a3295e3747278490f25b7c63ca2a68bb94a10370", async() => {
                    WriteLiteral(@"

                                    <div class=""form-group"">
                                        <label for=""useremail"">Email</label>
                                        <input type=""email"" class=""form-control"" id=""useremail"" placeholder=""Enter email"">
                                    </div>

                                    <div class=""form-group"">
                                        <label for=""username"">Username</label>
                                        <input type=""text"" class=""form-control"" id=""username"" placeholder=""Enter username"">
                                    </div>

                                    <div class=""form-group"">
                                        <label for=""userpassword"">Password</label>
                                        <input type=""password"" class=""form-control"" id=""userpassword"" placeholder=""Enter password"">
                                    </div>

                                    <div class=""mt-4"">
                ");
                    WriteLiteral(@"                        <button class=""btn btn-primary btn-block waves-effect waves-light"" type=""submit"">Register</button>
                                    </div>

                                    <div class=""mt-4 text-center"">
                                        <p class=""mb-0"">By registering you agree to the Skote <a href=""#"" class=""text-primary"">Terms of Use</a></p>
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                        <p>Already have an account ? <a href=""/Identity/Account/Login"" class=""font-weight-medium text-primary""> Login</a> </p>
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
            WriteLiteral("\r\n\r\n<!-- Mirrored from themesbrand.com/skote/layouts/vertical/auth-register.html by HTTrack Website Copier/3.x [XR&CO\'2014], Fri, 21 Feb 2020 09:12:15 GMT -->\r\n</html>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d644a3295e3747278490f25b7c63ca2a68bb94a15166", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel>)PageContext?.ViewData;
        public RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
