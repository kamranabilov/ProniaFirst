using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProniaTask.DAL;
using ProniaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;

        public ColorController(AppDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            List<Color> model = _context.Colors.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Color color)
        {
            if (!ModelState.IsValid) return View();
            Color existed =  _context.Colors.FirstOrDefault(x => x.Name.ToLower().Trim() == color.Name.ToLower().Trim());
            if (existed != null)
            {
                ModelState.AddModelError("Name", "Color name must be unique");
                return View();
            }
            _context.Colors.Add(color);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Color color = _context.Colors.FirstOrDefault(c => c.Id == id);
            if (color == null) return NotFound();
            return View(color);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(int? id, Color newColor)
        {
            if (id == 0 || id == null) return NotFound();
            if (!ModelState.IsValid) return View();
            Color existed = _context.Colors.FirstOrDefault(c => c.Id == id);
            if (existed == null) return NotFound();
            bool color2 = _context.Colors.Any(c => c.Name == newColor.Name);
            if (color2)
            {
                ModelState.AddModelError("Name", "Ad tek olmalidir");
                return View();
            }
            _context.Entry(existed).CurrentValues.SetValues(newColor);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == 0 || id == null) return NotFound();
            Color color = await _context.Colors.FindAsync(id);
            if (color == null) return NotFound();
            _context.Colors.Remove(color);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
       
    }
}
