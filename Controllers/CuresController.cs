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
    public class CuresController : Controller
    {
        private readonly MedicoContext _context;

        public CuresController(MedicoContext context)
        {
            _context = context;
        }

        // GET: Cures
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cures.ToListAsync());
        }

        // GET: Cures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cure = await _context.Cures
                .FirstOrDefaultAsync(m => m.CureId == id);
            if (cure == null)
            {
                return NotFound();
            }

            return View(cure);
        }

        // GET: Cures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CureId,Name,Description")] Cure cure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cure);
        }

        // GET: Cures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cure = await _context.Cures.FindAsync(id);
            if (cure == null)
            {
                return NotFound();
            }
            return View(cure);
        }

        // POST: Cures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CureId,Name,Description")] Cure cure)
        {
            if (id != cure.CureId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CureExists(cure.CureId))
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
            return View(cure);
        }

        // GET: Cures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cure = await _context.Cures
                .FirstOrDefaultAsync(m => m.CureId == id);
            if (cure == null)
            {
                return NotFound();
            }

            return View(cure);
        }

        // POST: Cures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cure = await _context.Cures.FindAsync(id);
            _context.Cures.Remove(cure);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CureExists(int id)
        {
            return _context.Cures.Any(e => e.CureId == id);
        }
    }
}
