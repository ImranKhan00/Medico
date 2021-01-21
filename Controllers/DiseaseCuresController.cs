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
    public class DiseaseCuresController : Controller
    {
        private readonly MedicoContext _context;

        public DiseaseCuresController(MedicoContext context)
        {
            _context = context;
        }

        // GET: DiseaseCures
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiseaseCure.ToListAsync());
        }

        // GET: DiseaseCures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseaseCure = await _context.DiseaseCure
                .FirstOrDefaultAsync(m => m.DiseaseCureId == id);
            if (diseaseCure == null)
            {
                return NotFound();
            }

            return View(diseaseCure);
        }

        // GET: DiseaseCures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiseaseCures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiseaseCureId")] DiseaseCure diseaseCure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diseaseCure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diseaseCure);
        }

        // GET: DiseaseCures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseaseCure = await _context.DiseaseCure.FindAsync(id);
            if (diseaseCure == null)
            {
                return NotFound();
            }
            return View(diseaseCure);
        }

        // POST: DiseaseCures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiseaseCureId")] DiseaseCure diseaseCure)
        {
            if (id != diseaseCure.DiseaseCureId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diseaseCure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiseaseCureExists(diseaseCure.DiseaseCureId))
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
            return View(diseaseCure);
        }

        // GET: DiseaseCures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diseaseCure = await _context.DiseaseCure
                .FirstOrDefaultAsync(m => m.DiseaseCureId == id);
            if (diseaseCure == null)
            {
                return NotFound();
            }

            return View(diseaseCure);
        }

        // POST: DiseaseCures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diseaseCure = await _context.DiseaseCure.FindAsync(id);
            _context.DiseaseCure.Remove(diseaseCure);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiseaseCureExists(int id)
        {
            return _context.DiseaseCure.Any(e => e.DiseaseCureId == id);
        }
    }
}
