using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto3.Data;
using Projeto3.Models;

namespace Projeto3.Controllers
{
    public class LocadorasController : Controller
    {
        private readonly Projeto3Context _context;

        public LocadorasController(Projeto3Context context)
        {
            _context = context;
        }

        // GET: Locadoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locadora.ToListAsync());
        }

        // GET: Locadoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locadora = await _context.Locadora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locadora == null)
            {
                return NotFound();
            }

            return View(locadora);
        }

        // GET: Locadoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locadoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Locadora locadora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locadora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locadora);
        }

        // GET: Locadoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locadora = await _context.Locadora.FindAsync(id);
            if (locadora == null)
            {
                return NotFound();
            }
            return View(locadora);
        }

        // POST: Locadoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Locadora locadora)
        {
            if (id != locadora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locadora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocadoraExists(locadora.Id))
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
            return View(locadora);
        }

        // GET: Locadoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locadora = await _context.Locadora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locadora == null)
            {
                return NotFound();
            }

            return View(locadora);
        }

        // POST: Locadoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locadora = await _context.Locadora.FindAsync(id);
            _context.Locadora.Remove(locadora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocadoraExists(int id)
        {
            return _context.Locadora.Any(e => e.Id == id);
        }
    }
}
