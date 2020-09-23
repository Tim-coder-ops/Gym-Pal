using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymPal.Models;

namespace GymPal.Controllers
{
    public class ProgressesController : Controller
    {
        private readonly GymPalDbContext _context;

        public ProgressesController(GymPalDbContext context)
        {
            _context = context;
        }

        // GET: Progresses
        public async Task<IActionResult> Index()
        {
            var gymPalDbContext = _context.Progress.Include(p => p.User);
            return View(await gymPalDbContext.ToListAsync());
        }

        // GET: Progresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progress = await _context.Progress
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (progress == null)
            {
                return NotFound();
            }

            return View(progress);
        }

        // GET: Progresses/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Progresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,BodyWeight,UserId")] Progress progress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(progress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            return View(progress);
        }

        // GET: Progresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progress = await _context.Progress.FindAsync(id);
            if (progress == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            return View(progress);
        }

        // POST: Progresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,BodyWeight,UserId")] Progress progress)
        {
            if (id != progress.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(progress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgressExists(progress.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            return View(progress);
        }

        // GET: Progresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progress = await _context.Progress
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (progress == null)
            {
                return NotFound();
            }

            return View(progress);
        }

        // POST: Progresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var progress = await _context.Progress.FindAsync(id);
            _context.Progress.Remove(progress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgressExists(int id)
        {
            return _context.Progress.Any(e => e.Id == id);
        }
    }
}
