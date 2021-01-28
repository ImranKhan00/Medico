using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FYP.Models;
using Medico.Data;

namespace Medico.Controllers
{
    public class DiseasesController : Controller
    {
        private readonly MedicoContext _context;

        public DiseasesController(MedicoContext context)
        {
            _context = context;
        }

        // GET: Diseases
        public async Task<IActionResult> Index()
        {
            return View(await _context.Diseases.ToListAsync());
        }

        // GET: Diseases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disease = await _context.Diseases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disease == null)
            {
                return NotFound();
            }

            return View(disease);
        }

        // GET: Diseases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Diseases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Disease disease)
        {
            if (ModelState.IsValid)
            {
                _context.Add(disease);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(disease);
        }

        // GET: Diseases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disease = await _context.Diseases.FindAsync(id);
            if (disease == null)
            {
                return NotFound();
            }
            return View(disease);
        }

        // POST: Diseases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Disease disease)
        {
            if (id != disease.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(disease);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiseaseExists(disease.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(disease);
        }

        // GET: Diseases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disease = await _context.Diseases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disease == null)
            {
                return NotFound();
            }

            return View(disease);
        }

        // POST: Diseases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disease = await _context.Diseases.FindAsync(id);
            _context.Diseases.Remove(disease);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiseaseExists(int id)
        {
            return _context.Diseases.Any(e => e.Id == id);
        }


        [HttpGet]
        public ActionResult BindDisease(int id)
        {
            ViewBag.cures = _context.Cures.ToList();
            ViewBag.precautions = _context.Precautions.ToList();
            ViewBag.symptoms = _context.Symptoms.ToList();
            var disease = _context.Diseases.Include(x=>x.Cures).Include(x=>x.Precautions).Include(x=>x.Symptoms).FirstOrDefault(x=>x.Id==id);
            return View(disease);
        }

        [HttpPost]
        public JsonResult AddCure(int cureId, int diseaseId)
        {
            try
            {
                var cure = _context.Cures.Find(cureId);
                var disease = _context.Diseases.Find(diseaseId);
                if(cure==null) return Json(new { StatusCode = 204,  Message = "Invalid Cure id" });
                if(disease==null) return Json(new { StatusCode = 204,  Message = "Invalid Disease id" });
                if (disease.Cures == null) disease.Cures = new List<Cure>();
                disease.Cures.Add(cure);
                _context.Entry(disease).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { StatusCode = 201,Data=cure.Name });
            }
            catch(Exception e)
            {
                return Json(new { StatusCode = 500, Data = e.StackTrace, Message = e.Message });
            }
        }
        [HttpPost]
        public JsonResult AddPrecaution(int precautionId, int diseaseId)
        {
            try
            {
                var precaution = _context.Precautions.Find(precautionId);
                var disease = _context.Diseases.Find(diseaseId);
                if(precaution == null) return Json(new { StatusCode = 204,  Message = "Invalid precaution  id" });
                if(disease==null) return Json(new { StatusCode = 204,  Message = "Invalid Disease id" });
                if (disease.Precautions == null) disease.Precautions = new List<Precaution>();
                disease.Precautions.Add(precaution);
                _context.Entry(disease).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { StatusCode = 201,Data= precaution.Name });
            }
            catch(Exception e)
            {
                return Json(new { StatusCode = 500, Data = e.StackTrace, Message = e.Message });
            }
        }
        [HttpPost]
        public JsonResult AddSymptom(int symptomId, int diseaseId)
        {
            try
            {
                var symptom = _context.Symptoms.Find(symptomId);
                var disease = _context.Diseases.Find(diseaseId);
                if(symptom == null) return Json(new { StatusCode = 204,  Message = "Invalid symptom id" });
                if(disease==null) return Json(new { StatusCode = 204,  Message = "Invalid Disease id" });
                if (disease.Symptoms == null) disease.Symptoms = new List<Symptoms>();
                disease.Symptoms.Add(symptom);
                _context.Entry(disease).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { StatusCode = 201,Data=symptom.Name });
            }
            catch(Exception e)
            {
                return Json(new { StatusCode = 500, Data = e.StackTrace, Message = e.Message });
            }
        }

    }
}
