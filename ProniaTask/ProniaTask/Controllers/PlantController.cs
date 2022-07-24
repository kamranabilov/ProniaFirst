using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProniaTask.DAL;
using ProniaTask.Models;
using ProniaTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Controllers
{
    public class PlantController:Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public PlantController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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

            ViewBag.Plants = await _context.Plants.Include(p => p.PlantImages).ToListAsync();

            // Relation Category start
            List<Plant> plants = new List<Plant>();
            List<Plant> plantsRange = new List<Plant>();
            foreach (var item in plant.PlantCategories)
            {
                plants = _context.Plants.Where(x => x.PlantCategories.Any(z => z.CategoryId == item.CategoryId))
                    .Include(x => x.PlantImages).ToList();

                plantsRange.AddRange(plants);
            }           

            ViewBag.Plants = plantsRange.Distinct().ToList();           

            if (plant == null)
            {
                return NotFound();
            }
            return View(plant);
            // Relation Category end
        }


        //PartialView
        public async Task<IActionResult> Partial()
        {
            List<Plant> plants = await _context.Plants.Include(p => p.PlantImages).ToListAsync();

            return PartialView("_PlantsPartialView", plants);
        }

        // ModalPartial
        public async Task<IActionResult> ModalDetailView(int? id)
        {
            Plant plant = await _context.Plants.Include(p => p.PlantImages).Include(p => p.PlantInformation)
                .FirstOrDefaultAsync(p => p.Id == id);

            return PartialView("_ModalDetailView", plant);
        }

        // Basket Mentiiqi
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Plant plant = await _context.Plants.FirstOrDefaultAsync(p => p.Id == id);
            if (plant == null) NotFound();

            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null) return NotFound();
                BasketItem existed = await _context.BasketItems.FirstOrDefaultAsync(b => b.AppUserId == user.Id && b.PlantId == plant.Id);
                if (existed == null)
                {
                    existed = new BasketItem
                    {
                        Plant = plant,
                        AppUser = user,
                        Quantity = 1,
                        Price = plant.Price
                    };
                    _context.BasketItems.Add(existed);
                }
                else
                {
                    existed.Quantity++;
                }
                await _context.SaveChangesAsync();               

            }
            else
            {
                string basketStr = HttpContext.Request.Cookies["Basket"];

                BasketVM basket;

                if (string.IsNullOrEmpty(basketStr))
                {
                    basket = new BasketVM();
                    BasketCookieItemVM cookieItem = new BasketCookieItemVM
                    {
                        Id = plant.Id,
                        Quantity = 1
                    };
                    basket.BasketCookieItemVMs = new List<BasketCookieItemVM>();
                    basket.BasketCookieItemVMs.Add(cookieItem);
                    basket.TotalPrice = plant.Price;
                }
                else
                {
                    basket = JsonConvert.DeserializeObject<BasketVM>(basketStr);
                    BasketCookieItemVM existed = basket.BasketCookieItemVMs.Find(p => p.Id == id);
                    if (existed == null)
                    {
                        BasketCookieItemVM cookieItem = new BasketCookieItemVM
                        {
                            Id = plant.Id,
                            Quantity = 1
                        };
                        basket.BasketCookieItemVMs.Add(cookieItem);
                        basket.TotalPrice += plant.Price;
                    }
                    else
                    {
                        basket.TotalPrice += plant.Price;
                        existed.Quantity++;
                    }

                }

                basketStr = JsonConvert.SerializeObject(basket);

                HttpContext.Response.Cookies.Append("Basket", basketStr);
            }
            return RedirectToAction("Index", "Home");       
        }

        public IActionResult ShowBasket()
        {
            if (HttpContext.Request.Cookies["Basket"]==null)
            {
                return NotFound();
            }
            BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(HttpContext.Request.Cookies["Basket"]);
            return Json(basket);
        }

        public async Task<IActionResult> RemoveFromPlant(int? id)
        {
            if (id is null || id == 0)
            {
                NotFound();
            }
            Plant plant = await _context.Plants.FirstOrDefaultAsync(p => p.Id == id);
            if (plant is null)
            {
                NotFound();
            }
            string basketStr = HttpContext.Request.Cookies["Basket"];
            if (string.IsNullOrEmpty(basketStr))
            {
                NotFound();
            }
            BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketStr);
            BasketCookieItemVM existed = basket.BasketCookieItemVMs.FirstOrDefault(p => p.Id == id);
            basket.BasketCookieItemVMs.Remove(existed);
            basket.TotalPrice -= (existed.Quantity * plant.Price);

            basketStr = JsonConvert.SerializeObject(basket);
            HttpContext.Response.Cookies.Append("Basket", basketStr);
                return RedirectToAction("Index", "Home");
        }
        
    }
}
