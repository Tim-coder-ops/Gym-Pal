using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymPal.Models;
using GymPal.ViewModel;

namespace GymPal.Controllers
{
    public class SetsController : Controller
    {
        private readonly GymPalDbContext _context;

        public SetsController(GymPalDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> UserHome()
        {
            var gymPalDbContext = _context.Sets.Include(s => s.ExerciseNavigation).Include(s => s.Workout);
            return View(await gymPalDbContext.ToListAsync());
        }

        

        // GET: Sets
        public async Task<IActionResult> Index()
        {
            var gymPalDbContext = _context.Sets.Include(s => s.ExerciseNavigation).Include(s => s.Workout);
            return View(await gymPalDbContext.ToListAsync());
        }

        // GET: Sets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sets = await _context.Sets
                .Include(s => s.ExerciseNavigation)
                .Include(s => s.Workout)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sets == null)
            {
                return NotFound();
            }

            return View(sets);
        }

        // GET: Sets/Create
        public IActionResult Create()
        {
            ViewData["Exercise"] = new SelectList(_context.Exercises, "Exercise", "Exercise");
            ViewData["WorkoutId"] = new SelectList(_context.Workout, "Id", "Id");
            return View();
        }

        // POST: Sets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Exercise,NumberOfReps,Weight,WorkoutId")] Sets sets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(LogNewWorkout));
            }
            ViewData["Exercise"] = new SelectList(_context.Exercises, "Exercise", "Exercise", sets.Exercise);
            ViewData["WorkoutId"] = new SelectList(_context.Workout, "Id", "Id", sets.WorkoutId);
            //return View(sets);
            return RedirectToAction(nameof(LogNewWorkout));
        }

        // GET: Sets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sets = await _context.Sets.FindAsync(id);
            if (sets == null)
            {
                return NotFound();
            }
            ViewData["Exercise"] = new SelectList(_context.Exercises, "Exercise", "Exercise", sets.Exercise);
            ViewData["WorkoutId"] = new SelectList(_context.Workout, "Id", "Id", sets.WorkoutId);
            return View(sets);
        }

        // POST: Sets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Exercise,NumberOfReps,Weight,WorkoutId")] Sets sets)
        {
            if (id != sets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SetsExists(sets.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(UserHome));
            }
            ViewData["Exercise"] = new SelectList(_context.Exercises, "Exercise", "Exercise", sets.Exercise);
            ViewData["WorkoutId"] = new SelectList(_context.Workout, "Id", "Id", sets.WorkoutId);
            return View(sets);
        }

        // GET: Sets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sets = await _context.Sets
                .Include(s => s.ExerciseNavigation)
                .Include(s => s.Workout)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sets == null)
            {
                return NotFound();
            }

            return View(sets);
        }

        // POST: Sets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sets = await _context.Sets.FindAsync(id);
            _context.Sets.Remove(sets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserHome));
        }

        private bool SetsExists(int id)
        {
            return _context.Sets.Any(e => e.Id == id);
        }

        public IActionResult LogNewWorkout()
        {
            LogNewWorkoutView logNewWorkoutView = new LogNewWorkoutView()
            {
                exercises = _context.Exercises.Select(r => r).ToList(),
                sets = _context.Sets.FirstOrDefault()
            };

            //var gymPalDbContext = _context.Sets.Include(s => s.ExerciseNavigation).Include(s => s.Workout);
            //return View(await gymPalDbContext.ToListAsync());

            return View(logNewWorkoutView);
        }



    }


}
