using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medico.Data;
using Medico.Models;

namespace Medico.Controllers
{
    public class DiagnoseDiseasesController : Controller
    {
        private readonly MedicoContext _context;

        public DiagnoseDiseasesController(MedicoContext context)
        {
            _context = context;
        }

        // GET: DiagnoseDiseases
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiagnoseDisease.ToListAsync());
        }

        // GET: DiagnoseDiseases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnoseDisease = await _context.DiagnoseDisease
                .FirstOrDefaultAsync(m => m.DiagnoseDiseaseId == id);
            if (diagnoseDisease == null)
            {
                return NotFound();
            }

            return View(diagnoseDisease);
        }

        // GET: DiagnoseDiseases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiagnoseDiseases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiagnoseDiseaseId,Severity")] DiagnoseDisease diagnoseDisease)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diagnoseDisease);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diagnoseDisease);
        }

        // GET: DiagnoseDiseases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnoseDisease = await _context.DiagnoseDisease.FindAsync(id);
            if (diagnoseDisease == null)
            {
                return NotFound();
            }
            return View(diagnoseDisease);
        }

        // POST: DiagnoseDiseases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiagnoseDiseaseId,Severity")] DiagnoseDisease diagnoseDisease)
        {
            if (id != diagnoseDisease.DiagnoseDiseaseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diagnoseDisease);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiagnoseDiseaseExists(diagnoseDisease.DiagnoseDiseaseId))
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
            return View(diagnoseDisease);
        }

        // GET: DiagnoseDiseases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnoseDisease = await _context.DiagnoseDisease
                .FirstOrDefaultAsync(m => m.DiagnoseDiseaseId == id);
            if (diagnoseDisease == null)
            {
                return NotFound();
            }

            return View(diagnoseDisease);
        }

        // POST: DiagnoseDiseases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diagnoseDisease = await _context.DiagnoseDisease.FindAsync(id);
            _context.DiagnoseDisease.Remove(diagnoseDisease);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiagnoseDiseaseExists(int id)
        {
            return _context.DiagnoseDisease.Any(e => e.DiagnoseDiseaseId == id);
        }
    }
}
