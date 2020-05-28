using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LWCustomer.Data;
using LWCustomer.Models;

namespace LWCustomer.Controllers
{
    public class EnquiredsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnquiredsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enquireds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enquired.ToListAsync());
        }

        // GET: Enquireds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquired = await _context.Enquired
                .FirstOrDefaultAsync(m => m.EnquiredId == id);
            if (enquired == null)
            {
                return NotFound();
            }

            return View(enquired);
        }

        // GET: Enquireds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enquireds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnquiredId,UserId,PropertyId,HasEnquired")] Enquired enquired)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enquired);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enquired);
        }

        // GET: Enquireds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquired = await _context.Enquired.FindAsync(id);
            if (enquired == null)
            {
                return NotFound();
            }
            return View(enquired);
        }

        // POST: Enquireds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnquiredId,PropertyId,HasEnquired")] Enquired enquired)
        {
            if (id != enquired.EnquiredId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enquired);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnquiredExists(enquired.EnquiredId))
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
            return View(enquired);
        }

        // GET: Enquireds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquired = await _context.Enquired
                .FirstOrDefaultAsync(m => m.EnquiredId == id);
            if (enquired == null)
            {
                return NotFound();
            }

            return View(enquired);
        }

        // POST: Enquireds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enquired = await _context.Enquired.FindAsync(id);
            _context.Enquired.Remove(enquired);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnquiredExists(int id)
        {
            return _context.Enquired.Any(e => e.EnquiredId == id);
        }
    }
}
