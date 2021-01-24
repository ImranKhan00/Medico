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
    public class PrecautionsController : Controller
    {
        private readonly MedicoContext _context;

        public PrecautionsController(MedicoContext context)
        {
            _context = context;
        }

        // GET: Precautions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Precautions.ToListAsync());
        }

        // GET: Precautions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precaution = await _context.Precautions
                .FirstOrDefaultAsync(m => m.PrecautionId == id);
            if (precaution == null)
            {
                return NotFound();
            }

            return View(precaution);
        }

        // GET: Precautions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Precautions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrecautionId,Name")] Precaution precaution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(precaution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(precaution);
        }

        // GET: Precautions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precaution = await _context.Precautions.FindAsync(id);
            if (precaution == null)
            {
                return NotFound();
            }
            return View(precaution);
        }

        // POST: Precautions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrecautionId,Name")] Precaution precaution)
        {
            if (id != precaution.PrecautionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(precaution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrecautionExists(precaution.PrecautionId))
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
            return View(precaution);
        }

        // GET: Precautions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precaution = await _context.Precautions
                .FirstOrDefaultAsync(m => m.PrecautionId == id);
            if (precaution == null)
            {
                return NotFound();
            }

            return View(precaution);
        }

        // POST: Precautions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var precaution = await _context.Precautions.FindAsync(id);
            _context.Precautions.Remove(precaution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrecautionExists(int id)
        {
            return _context.Precautions.Any(e => e.PrecautionId == id);
        }
    }
}
