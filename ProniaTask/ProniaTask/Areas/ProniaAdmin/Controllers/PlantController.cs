﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaTask.DAL;
using ProniaTask.Extensinos;
using ProniaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class PlantController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public PlantController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Plant> model = _context.Plants
                .Include(p => p.PlantInformation)
                .Include(p => p.PlantCategories).ThenInclude(pc => pc.Category)
                .Include(p => p.PlantImages).ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.Information = _context.PlantInformation.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Plant plant)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Information = _context.PlantInformation.ToList();
                ViewBag.Categories = _context.Categories.ToList();
                return View();
            }
            if (plant.MainPhoto == null || plant.HoverPhoto == null || plant.Photos == null)
            {

                ViewBag.Information = _context.PlantInformation.ToList();
                ViewBag.Categories = _context.Categories.ToList();
                ModelState.AddModelError(string.Empty, "must choose 1 main photo and 1 hover photo and other photo");
                return View();
            }

            if (!plant.MainPhoto.ImageIsOkey(2) || !plant.HoverPhoto.ImageIsOkey(2))
            {
                ViewBag.Information = _context.PlantInformation.ToList();
                ViewBag.Categories = _context.Categories.ToList();
                ModelState.AddModelError(string.Empty, "choose image file");
                return View();
            }

            TempData["FileName"] = "";
            foreach (var photo in plant.Photos)
            {
                if (!photo.ImageIsOkey(2))
                {
                    plant.Photos.Remove(photo);
                    TempData["FileName"] += photo.FileName + ",";
                }
            }

            PlantImage main = new PlantImage
            {
                Name = await plant.MainPhoto.FileCreate(_env.WebRootPath, "assets/images/slider"),
                IsMain = true,
                Alternative = plant.Name,
                Plant = plant
            };
            PlantImage hover = new PlantImage
            {
                Name = await plant.HoverPhoto.FileCreate(_env.WebRootPath, "assets/images/slider"),
                IsMain = null,
                Alternative = plant.Name,
                Plant = plant
            };



            return RedirectToAction(nameof(Index));
        } 
    }
}
