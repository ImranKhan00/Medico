#pragma checksum "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a567cf066a9202e9f135b339d518d40cc055f8c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagnosis_GetNextQuestion), @"mvc.1.0.view", @"/Views/Diagnosis/GetNextQuestion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a567cf066a9202e9f135b339d518d40cc055f8c8", @"/Views/Diagnosis/GetNextQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c49fea8670ff10236ab95a5d37cf3d944379fdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagnosis_GetNextQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medico.ViewModel.DiagnosisViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml"
     int count = -1;
    try { count = Model.Answers.Count; } catch { }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<label>");
#nullable restore
#line 6 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml"
  Write(Model.Questions.ElementAt(count).Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n<br />\r\n<input type=\"radio\" value=\"1\" name=\"answer\" />\r\n<label>Yes</label>\r\n<br />\r\n<input type=\"radio\" value=\"0\" name=\"answer\" />\r\n<label>No</label>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml"
Write(Html.HiddenFor(x => x.Symptoms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml"
Write(Html.HiddenFor(x => x.Questions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml"
Write(Html.HiddenFor(x => x.Answers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml"
Write(Html.HiddenFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\GetNextQuestion.cshtml"
Write(Html.HiddenFor(x => x.Gender));

#line default
#line hidden
#nullable disable
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
