using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaTask.DAL;
using ProniaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Controllers
{
    public class PlantController:Controller
    {
        private readonly AppDbContext _context;

        public PlantController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Plant plant =await _context.Plants.Include(p => p.PlantImages)
                .Include(p => p.PlantInformation)
                .Include(p => p.PlantTags).ThenInclude(p => p.Tag)
                .Include(p => p.PlantCategories).ThenInclude(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (plant == null)
            {
                return NotFound();
            }
            return View(plant);
        }

    }
}
