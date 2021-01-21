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
    public class DiseasePrecautionsController : Controller
    {
        private readonly MedicoContext _context;

        public DiseasePrecautionsController(MedicoContext context)
        {
            _context = context;
        }

        // GET: DiseasePrecautions
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiseasePrecaution.ToListAsync());
        }

        // GET: DiseasePrecautions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseasePrecaution = await _context.DiseasePrecaution
                .FirstOrDefaultAsync(m => m.DiseasePrecautionId == id);
            if (diseasePrecaution == null)
            {
                return NotFound();
            }

            return View(diseasePrecaution);
        }

        // GET: DiseasePrecautions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiseasePrecautions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiseasePrecautionId")] DiseasePrecaution diseasePrecaution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diseasePrecaution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diseasePrecaution);
        }

        // GET: DiseasePrecautions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseasePrecaution = await _context.DiseasePrecaution.FindAsync(id);
            if (diseasePrecaution == null)
            {
                return NotFound();
            }
            return View(diseasePrecaution);
        }

        // POST: DiseasePrecautions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiseasePrecautionId")] DiseasePrecaution diseasePrecaution)
        {
            if (id != diseasePrecaution.DiseasePrecautionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diseasePrecaution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiseasePrecautionExists(diseasePrecaution.DiseasePrecautionId))
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
            return View(diseasePrecaution);
        }

        // GET: DiseasePrecautions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseasePrecaution = await _context.DiseasePrecaution
                .FirstOrDefaultAsync(m => m.DiseasePrecautionId == id);
            if (diseasePrecaution == null)
            {
                return NotFound();
            }

            return View(diseasePrecaution);
        }

        // POST: DiseasePrecautions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diseasePrecaution = await _context.DiseasePrecaution.FindAsync(id);
            _context.DiseasePrecaution.Remove(diseasePrecaution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiseasePrecautionExists(int id)
        {
            return _context.DiseasePrecaution.Any(e => e.DiseasePrecautionId == id);
        }
    }
}
