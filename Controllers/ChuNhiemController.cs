using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using demo.Data;
using demo.Models;

namespace demo.Controllers
{
    public class ChuNhiemController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ChuNhiemController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: ChuNhiem
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChuNhiem.ToListAsync());
        }

        // GET: ChuNhiem/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuNhiem = await _context.ChuNhiem
                .FirstOrDefaultAsync(m => m.TeacherName == id);
            if (chuNhiem == null)
            {
                return NotFound();
            }

            return View(chuNhiem);
        }

        // GET: ChuNhiem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChuNhiem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherName,NgaySinh")] ChuNhiem chuNhiem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuNhiem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuNhiem);
        }

        // GET: ChuNhiem/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuNhiem = await _context.ChuNhiem.FindAsync(id);
            if (chuNhiem == null)
            {
                return NotFound();
            }
            return View(chuNhiem);
        }

        // POST: ChuNhiem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TeacherName,NgaySinh")] ChuNhiem chuNhiem)
        {
            if (id != chuNhiem.TeacherName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuNhiem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuNhiemExists(chuNhiem.TeacherName))
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
            return View(chuNhiem);
        }

        // GET: ChuNhiem/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuNhiem = await _context.ChuNhiem
                .FirstOrDefaultAsync(m => m.TeacherName == id);
            if (chuNhiem == null)
            {
                return NotFound();
            }

            return View(chuNhiem);
        }

        // POST: ChuNhiem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chuNhiem = await _context.ChuNhiem.FindAsync(id);
            _context.ChuNhiem.Remove(chuNhiem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChuNhiemExists(string id)
        {
            return _context.ChuNhiem.Any(e => e.TeacherName == id);
        }
    }
}
