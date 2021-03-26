using Medico.Models;
using Medico.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Medico.Controllers
{
    public class DiagnosisController : Controller
    {

        const string SessionId = "_Name";
        const string SessionAge = "_Age";
        const string SessionGender= "_Gender";
        Data.MedicoContext db;
        public DiagnosisController(Medico.Data.MedicoContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            DiagnosisViewModel viewModel = new DiagnosisViewModel();
            return View(viewModel);
        }
       
        
        
        [HttpPost]
        public IActionResult Index(DiagnosisViewModel viewModel)
        {
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult GetAge(DiagnosisViewModel viewModel)
        {
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult GetGender(DiagnosisViewModel viewModel)
        {
            HttpContext.Session.SetInt32(SessionAge, viewModel.Age);
            return View(viewModel);
        }
        

        [HttpPost]
        public JsonResult GetQuestions(string[] SymptomsList)
        {
            var symptoms = db.Symptoms.Where(x => SymptomsList.Contains(x.SymptomId.ToString())).ToList();
            if (symptoms.Count > 0)
            {
                Diagnosis diag = new Diagnosis
                {
                    Age = HttpContext.Session.GetInt32(SessionAge) ?? 0,
                    Symptoms = symptoms,
                    User = db.Users.FirstOrDefault(x => x.Id == this.User.FindFirstValue(ClaimTypes.NameIdentifier)),
                    Date = DateTime.UtcNow,
                };

                

                db.Diagnoses.Add(diag);
                db.SaveChanges();
                HttpContext.Session.SetInt32(SessionId, diag.DiagnosisId);
                return Json(db.SymptomQuestions.Where(x => symptoms.Contains(x.Symptom)).ToList());
            }
            return Json(new String[0]);
        }

        [HttpPost]
        public JsonResult GetResults(cSymptomQuestion[] questions, string[] answers)
        {
            try
            {
                var _quests = new List<cSymptomQuestion>(questions);
                for (int i = questions.Length-1; i >= 0; i--)
                {
                    if (Convert.ToInt32(answers[i]) == 0)
                    {
                        _quests.RemoveAt(i);
                    }
                }
                List<int> SympIds = new List<int>();
                
                List<Disease> diseases = new List<Disease>();
                _quests.ForEach(x =>
            {
                SympIds.Add(x.Id);

            });
                List<cSymptomQuestion> symptomQuestions = 
                    db.SymptomQuestions
                    .Include(x => x.Symptom.Diseases)
                    .Where(x => SympIds.Contains(x.Id)).ToList();

                symptomQuestions.ForEach(x =>
                {
                    diseases.AddRange(x.Symptom.Diseases);
                });
                var id = HttpContext.Session.GetInt32(SessionId)??0;
                if (id > 0)
                {
                    var diag = db.Diagnoses.Find(id);
                    diag.Diseases = diseases;
                    db.Diagnoses.Update(diag);
                    db.SaveChanges();
                }

                return Json(diseases.Select(x=>new { x.Name, x.Id }));
            }catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public IActionResult GetSymptoms(DiagnosisViewModel viewModel)
        {
            ViewBag.symptoms = db.Symptoms.Select(x => new SelectListItem { Value = x.SymptomId.ToString(), Text = x.Name }).ToList();
            return View(viewModel);
        }

        public IActionResult Diagnosis()
        {
            return View();
        }
    }
}
