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
    public class DiseaseSymptomsController : Controller
    {
        private readonly MedicoContext _context;

        public DiseaseSymptomsController(MedicoContext context)
        {
            _context = context;
        }

        // GET: DiseaseSymptoms
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiseaseSymptoms.ToListAsync());
        }

        // GET: DiseaseSymptoms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseaseSymptoms = await _context.DiseaseSymptoms
                .FirstOrDefaultAsync(m => m.DiseaseSymptomsId == id);
            if (diseaseSymptoms == null)
            {
                return NotFound();
            }

            return View(diseaseSymptoms);
        }

        // GET: DiseaseSymptoms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiseaseSymptoms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiseaseSymptomsId,Severity")] DiseaseSymptoms diseaseSymptoms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diseaseSymptoms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diseaseSymptoms);
        }

        // GET: DiseaseSymptoms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseaseSymptoms = await _context.DiseaseSymptoms.FindAsync(id);
            if (diseaseSymptoms == null)
            {
                return NotFound();
            }
            return View(diseaseSymptoms);
        }

        // POST: DiseaseSymptoms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiseaseSymptomsId,Severity")] DiseaseSymptoms diseaseSymptoms)
        {
            if (id != diseaseSymptoms.DiseaseSymptomsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diseaseSymptoms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiseaseSymptomsExists(diseaseSymptoms.DiseaseSymptomsId))
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
            return View(diseaseSymptoms);
        }

        // GET: DiseaseSymptoms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseaseSymptoms = await _context.DiseaseSymptoms
                .FirstOrDefaultAsync(m => m.DiseaseSymptomsId == id);
            if (diseaseSymptoms == null)
            {
                return NotFound();
            }

            return View(diseaseSymptoms);
        }

        // POST: DiseaseSymptoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diseaseSymptoms = await _context.DiseaseSymptoms.FindAsync(id);
            _context.DiseaseSymptoms.Remove(diseaseSymptoms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiseaseSymptomsExists(int id)
        {
            return _context.DiseaseSymptoms.Any(e => e.DiseaseSymptomsId == id);
        }
    }
}
