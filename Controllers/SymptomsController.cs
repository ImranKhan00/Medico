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
    public class SymptomsController : Controller
    {
        private readonly MedicoContext _context;

        public SymptomsController(MedicoContext context)
        {
            _context = context;
        }

        // GET: Symptoms
        public async Task<IActionResult> Index()
        {
            return View(await _context.Symptoms.ToListAsync());
        }

        // GET: Symptoms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptoms = await _context.Symptoms
                .FirstOrDefaultAsync(m => m.SymtomsId == id);
            if (symptoms == null)
            {
                return NotFound();
            }

            return View(symptoms);
        }

        // GET: Symptoms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Symptoms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SymtomsId,Name,Description")] Symptoms symptoms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(symptoms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(symptoms);
        }

        // GET: Symptoms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptoms = await _context.Symptoms.FindAsync(id);
            if (symptoms == null)
            {
                return NotFound();
            }
            return View(symptoms);
        }

        // POST: Symptoms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SymtomsId,Name,Description")] Symptoms symptoms)
        {
            if (id != symptoms.SymtomsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(symptoms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SymptomsExists(symptoms.SymtomsId))
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
            return View(symptoms);
        }

        // GET: Symptoms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptoms = await _context.Symptoms
                .FirstOrDefaultAsync(m => m.SymtomsId == id);
            if (symptoms == null)
            {
                return NotFound();
            }

            return View(symptoms);
        }

        // POST: Symptoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var symptoms = await _context.Symptoms.FindAsync(id);
            _context.Symptoms.Remove(symptoms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SymptomsExists(int id)
        {
            return _context.Symptoms.Any(e => e.SymtomsId == id);
        }
    }
}
