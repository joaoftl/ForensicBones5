using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForensicBones5.Models;

namespace ForensicBones5.Controllers
{
    public class InventarioEsqueletoesController : Controller
    {
        private readonly AppDbContext _context;

        public InventarioEsqueletoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventarioEsqueletoes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.InventarioEsqueleto_1.Include(i => i.Relatorio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: InventarioEsqueletoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InventarioEsqueleto_1 == null)
            {
                return NotFound();
            }

            var inventarioEsqueleto = await _context.InventarioEsqueleto_1
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioEsqueletoId == id);
            if (inventarioEsqueleto == null)
            {
                return NotFound();
            }

            return View(inventarioEsqueleto);
        }

        // GET: InventarioEsqueletoes/Create
        public IActionResult Create()
        {
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.Set<Relatorio>(), "RelatorioId", "Codigo");
            return View();
        }

        // POST: InventarioEsqueletoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventarioEsqueletoId,RelatorioId,FotoEsqueleto,Observacoes")] InventarioEsqueleto inventarioEsqueleto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventarioEsqueleto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.Set<Relatorio>(), "RelatorioId", "Codigo", inventarioEsqueleto.InventarioEsqueletoId);
            return View(inventarioEsqueleto);
        }

        // GET: InventarioEsqueletoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InventarioEsqueleto_1 == null)
            {
                return NotFound();
            }

            var inventarioEsqueleto = await _context.InventarioEsqueleto_1.FindAsync(id);
            if (inventarioEsqueleto == null)
            {
                return NotFound();
            }
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.Set<Relatorio>(), "RelatorioId", "Codigo", inventarioEsqueleto.InventarioEsqueletoId);
            return View(inventarioEsqueleto);
        }

        // POST: InventarioEsqueletoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventarioEsqueletoId,RelatorioId,FotoEsqueleto,Observacoes")] InventarioEsqueleto inventarioEsqueleto)
        {
            if (id != inventarioEsqueleto.InventarioEsqueletoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventarioEsqueleto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioEsqueletoExists(inventarioEsqueleto.InventarioEsqueletoId))
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
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.Set<Relatorio>(), "RelatorioId", "Codigo", inventarioEsqueleto.InventarioEsqueletoId);
            return View(inventarioEsqueleto);
        }

        // GET: InventarioEsqueletoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InventarioEsqueleto_1 == null)
            {
                return NotFound();
            }

            var inventarioEsqueleto = await _context.InventarioEsqueleto_1
                .Include(i => i.Relatorio)
                .FirstOrDefaultAsync(m => m.InventarioEsqueletoId == id);
            if (inventarioEsqueleto == null)
            {
                return NotFound();
            }

            return View(inventarioEsqueleto);
        }

        // POST: InventarioEsqueletoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InventarioEsqueleto_1 == null)
            {
                return Problem("Entity set 'AppDbContext.InventarioEsqueleto_1'  is null.");
            }
            var inventarioEsqueleto = await _context.InventarioEsqueleto_1.FindAsync(id);
            if (inventarioEsqueleto != null)
            {
                _context.InventarioEsqueleto_1.Remove(inventarioEsqueleto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioEsqueletoExists(int id)
        {
          return _context.InventarioEsqueleto_1.Any(e => e.InventarioEsqueletoId == id);
        }
    }
}
