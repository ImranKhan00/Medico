using Medico.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medico.Controllers
{
    public class DiseaseCuresController : Controller
    {
        private readonly MedicoContext _context;

        public DiseaseCuresController(MedicoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var diseases = _context.Diseases.ToList();
            var cures = _context.Cures.ToList();
            ViewBag.diseases = diseases;
            ViewBag.cures = cures;
            return View();
        }
        [HttpPost]
        public IActionResult Create(int DiseaseId, int CureId)
        {
            if (ModelState.IsValid)
            {
                var disease = _context.Diseases.Find(DiseaseId);
                var cure = _context.Cures.Find(CureId);
                if (disease.Cures.Contains(cure)) throw new Exception("Duplicate cures");
                disease.Cures.Add(cure);
                _context.Entry(disease).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            return View();
        }

    }
}
