using Microsoft.AspNetCore.Mvc;
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
        private readonly object _context;

        public PlantController(AppDbContext context)
        {
            _context = context;
        }

        public  IActionResult Detail(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }          
            return View();
        }
        
    }
}
