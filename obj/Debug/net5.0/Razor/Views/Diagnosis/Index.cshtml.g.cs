#pragma checksum "C:\Users\Imran Khan\source\repos\MedicoCopy\Medico\Views\Diagnosis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92eb0c697136706fc61cab0e885a60e8be7a5701"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagnosis_Index), @"mvc.1.0.view", @"/Views/Diagnosis/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92eb0c697136706fc61cab0e885a60e8be7a5701", @"/Views/Diagnosis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c49fea8670ff10236ab95a5d37cf3d944379fdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagnosis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medico.ViewModel.DiagnosisViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""main""></div>

<input type=""button"" onclick=""next()"" value=""Next"" />
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.css"" integrity=""sha512-0nkKORjFgcyxv3HbE4rzFUlENUMNqic/EzDIeYCgsKa/nwqr2B91Vu/tNAu4Q0cBuG4Xe/D1f/freEci/7GDRA=="" crossorigin=""anonymous"" />
<script src=""https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"" integrity=""sha512-rMGGF4wg1R73ehtnxXBt5mbUfN9JUJwbk21KMlnLZDJh7BkPmeovBuddZCENJddHYYMkCh9hPFnPmS9sspki8g=="" crossorigin=""anonymous""></script>

<script>
    var gender;
    var age = 0;
    var questions = [];
    var answers = [];
    var symptoms = [];
    $(document).ready(function () {
        //load get gender

        getPreviousScan();
       
    });
    var step = 0;//0 step indicates user is on gender stage
    function next() {
        switch (step) {
            case 0: getAge(); break;
            case 1: getSymptoms(); break;
            case 2: getNextQuestion(); break;
            cas");
            WriteLiteral(@"e 3: askQuestions();break;
            default:
        }
    }

    function getAge() {
        gender = $(""input[name=gender]:checked"").val();
        if (!gender) return;
        Ajax({ url: ""/diagnosis/getage"" })
            .then(x => {
                document.getElementById(""main"").innerHTML = x;
                step = 1;
            })
    }
    function getSymptoms() {
        age = $(""#ageCount"").text();
        if (!age) return;
        Ajax({ url: ""/diagnosis/getSymptoms"" })
            .then(x => {
                document.getElementById(""main"").innerHTML = x;

                step = 2;
                $(""#symptoms"").chosen({ no_results_text: ""Oops, nothing found!"" });
            })
    }

    function getNextQuestion() {
        var symptoms = $(""#symptoms"").val();
        Ajax({ url: ""/diagnosis/getQuestions"", data: { SymptomsList: symptoms } })
            .then(x => {
                console.log(x);
                if (x.length == 0) return;
                qu");
            WriteLiteral(@"estions = x;
                
                step = 3;
                if (x.length>0)document.getElementById(""main"").innerHTML = `
                    <label>${questions[0].question}</label>
                    <br />
                    <input type=""radio"" value=""1"" name=""answer"" />
                    <label>Yes</label>
                    <br />
                    <input type=""radio"" value=""0"" name=""answer"" />
                    <label>No</label>`
            })
    }

    function askQuestions() {
        if (questions.length > 0) {
            let answer = $(""input[name=answer]:checked"").val();
            if (!answer) return;
            answers.push(answer);
            let questionNumber = answers.length;
            if (questions[questionNumber]) {
                document.getElementById(""main"").innerHTML = `
                    <label>${questions[questionNumber].question}</label>
                    <br />
                    <input type=""radio"" value=""1"" name=""answer"" />");
            WriteLiteral(@"
                    <label>Yes</label>
                    <br />
                    <input type=""radio"" value=""0"" name=""answer"" />
                    <label>No</label>`
            }
            else {
                //list ended
                document.getElementById(""main"").innerHTML = ""<p>Loading Results...</p>""
                Ajax({ url: ""/diagnosis/GetResults"", data: {questions, answers} })
                    .then(x => {

                        setCookie('result', x);
                        processResult(x);
                        //document.getElementById(""main"").innerHTML = x;
                        
                    })
            }
        }
    }


    function processResult(x) {
        var result = count(x);
        result.sort((a, b) => a.count > b.count ? 1 : -1);
        //debugger
        //dispaly
        var total = 0;
        result.forEach(x => total += x.count)
        var html = ""<h5>Result</h5><ul>""
        result.forEach(x => {
           ");
            WriteLiteral(@" html += `<li>${x.obj.name}<span style='text-align:right'><a href='/diseases/cure/${x.obj.id}'>Cure</a></span>
<input type=""range"" max=""100"" value=""${(x.count / total) * 100}""></li>`
        })
        html += ""</ul>"";


        document.getElementById(""main"").innerHTML = html;
    }

    function getPreviousScan() {
        var cookieRes = getCookie('result');
        if (cookieRes) {
            processResult(JSON.parse(cookieRes));
        }
        else {
            Ajax({ url: ""/diagnosis/getgender"" })
                .then(x => {
                    document.getElementById(""main"").innerHTML = x;
                    step = 0;
                });
        }
    }
    function count(array_elements) {

        var result__ = [];
        array_elements.sort();

        var current = null;
        var cnt = 0;
        for (var i = 0; i < array_elements.length; i++) {
            if (array_elements[i] != current) {
                if (cnt > 0) {
                    result__.push");
            WriteLiteral(@"({ obj: current, count: cnt, })
                }
                current = array_elements[i];
                cnt = 1;
            } else {
                cnt++;
            }
        }
        if (cnt > 0) {
            result__.push({ obj: current, count: cnt })
        }
        return result__;
    }
    

    function Ajax({ url, data }) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url,
                data,
                type: ""POST"",
                content: ""Application/json"",
                success: function (data) { resolve(data) },
                error: function (request) { reject(request) }
            })
        })
    }
    function updateAge() {
        // document.getElementById(""ageCount"").innerText = document.getElementById(""age-range"").value;
        var slider = document.getElementById(""age-range"");
        var output = document.getElementById(""ageCount"");
        output.innerHTML = slider.value; // Display th");
            WriteLiteral(@"e default slider value

        // Update the current slider value (each time you drag the slider handle)
        slider.oninput = function () {
            output.innerHTML = this.value;
        }
    }

    function setCookie(name, value) {
        var expires = """";
        days = 1;
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = ""; expires="" + date.toUTCString();
        }
        document.cookie = name + ""="" + (JSON.stringify(value) || """") + expires + ""; path=/"";
    }
    function getCookie(name) {
        var nameEQ = name + ""="";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') c = c.substring(1, c.length);
            if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
        }
        return null;
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medico.ViewModel.DiagnosisViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
