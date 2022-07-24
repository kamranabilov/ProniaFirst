using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32.SafeHandles;
using ProniaTask.DAL;
using ProniaTask.Extensinos;
using ProniaTask.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> model = _context.Sliders.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            //if (slider.Photo is null)
            //{
            //    ModelState.AddModelError("Photo", "must be choose 1 image");
            //    return View();
            //}
            if (!slider.Photo.ImageIsOkey(2))
            {
                ModelState.AddModelError("Photo", "choose image file");
                return View();
            }

            slider.Image = await slider.Photo.FileCreate(_env.WebRootPath, "assets/images/website-images");

            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            //return Content(_environment.ContentRootPath);
            return RedirectToAction(nameof(Index));        
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == 0 || id == null) return NotFound();
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            if (id == 0 || id == null) return NotFound();
            Slider existed = await _context.Sliders.FindAsync(id);
            if (existed == null) return NotFound();
            if (!ModelState.IsValid) return View(existed);
            if (slider.Photo == null)
            {
                string filename = existed.Image;
                _context.Entry(existed).CurrentValues.SetValues(slider);
                existed.Image = filename;
            }
            else
            {
                if (!slider.Photo.ImageIsOkey(2))
                {
                    ModelState.AddModelError("Photo", "Choose image file");
                    return View(existed);
                }
                FileExtension.FileDelete(_env.WebRootPath, "assets/images/website-images", existed.Image);
                _context.Entry(existed).CurrentValues.SetValues(slider);
                existed.Image = await slider.Photo.FileCreate(_env.WebRootPath, "assets/images/website-images");
            }
            //_context.Sliders.Add(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
