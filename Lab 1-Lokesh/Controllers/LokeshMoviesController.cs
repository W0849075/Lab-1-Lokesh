using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab_1_Lokesh.Data;
using Lab_1_Lokesh.Models;

namespace Lab_1_Lokesh.Controllers
{
    public class LokeshMoviesController : Controller
    {
        private readonly Lab_1_LokeshContext _context;

        public LokeshMoviesController(Lab_1_LokeshContext context)
        {
            _context = context;
        }

        // GET: LokeshMovies
        public async Task<IActionResult> Index()
        {
            return View(await _context.LokeshMovie.ToListAsync());
        }

        // GET: LokeshMovies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lokeshMovie = await _context.LokeshMovie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lokeshMovie == null)
            {
                return NotFound();
            }

            return View(lokeshMovie);
        }

        // GET: LokeshMovies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LokeshMovies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,price")] LokeshMovie lokeshMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lokeshMovie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lokeshMovie);
        }

        // GET: LokeshMovies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lokeshMovie = await _context.LokeshMovie.FindAsync(id);
            if (lokeshMovie == null)
            {
                return NotFound();
            }
            return View(lokeshMovie);
        }

        // POST: LokeshMovies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,price")] LokeshMovie lokeshMovie)
        {
            if (id != lokeshMovie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lokeshMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LokeshMovieExists(lokeshMovie.Id))
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
            return View(lokeshMovie);
        }

        // GET: LokeshMovies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lokeshMovie = await _context.LokeshMovie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lokeshMovie == null)
            {
                return NotFound();
            }

            return View(lokeshMovie);
        }

        // POST: LokeshMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lokeshMovie = await _context.LokeshMovie.FindAsync(id);
            if (lokeshMovie != null)
            {
                _context.LokeshMovie.Remove(lokeshMovie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LokeshMovieExists(int id)
        {
            return _context.LokeshMovie.Any(e => e.Id == id);
        }
    }
}
