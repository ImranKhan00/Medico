#pragma checksum "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25e8a11d6bee22433e5be4db9bb695aad484a013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagnosis_GetSymptoms), @"mvc.1.0.view", @"/Views/Diagnosis/GetSymptoms.cshtml")]
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
#line 1 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\_ViewImports.cshtml"
using Medico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\_ViewImports.cshtml"
using Medico.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25e8a11d6bee22433e5be4db9bb695aad484a013", @"/Views/Diagnosis/GetSymptoms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c49fea8670ff10236ab95a5d37cf3d944379fdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagnosis_GetSymptoms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medico.ViewModel.DiagnosisViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<select name=\"SymptomsList\" id=\"symptoms\" multiple>\r\n");
#nullable restore
#line 4 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
     foreach (SelectListItem item in ViewBag.symptoms)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25e8a11d6bee22433e5be4db9bb695aad484a0133454", async() => {
#nullable restore
#line 6 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
                               Write(item.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
           WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</select>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
Write(Html.HiddenFor(x => x.Symptoms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
Write(Html.HiddenFor(x => x.Questions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
Write(Html.HiddenFor(x => x.Answers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
Write(Html.HiddenFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetSymptoms.cshtml"
Write(Html.HiddenFor(x => x.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medico.ViewModel.DiagnosisViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
