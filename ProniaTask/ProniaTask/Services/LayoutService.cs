﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProniaTask.DAL;
using ProniaTask.Models;
using ProniaTask.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ProniaTask.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _http;

        public BasketVM JsonContext { get; private set; }

        public LayoutService(AppDbContext context, IHttpContextAccessor http)
        {
            _context = context;
            _http = http;
        }

        public List<Setting> GetSettings()
        {
            List<Setting> settings = _context.Settings.ToList();
            return settings;
        }

        public LayoutBasketVM GetBasket()
        {
            //BasketVM basket = new BasketVM();

            string basketStr = _http.HttpContext.Request.Cookies["Basket"];

            if (!string.IsNullOrEmpty(basketStr))
            {
                BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketStr);
                LayoutBasketVM layoutBasket = new LayoutBasketVM();
                layoutBasket.BasketItemVMs = new List<BasketItemVM>();
                foreach (BasketCookieItemVM cookie in basket.BasketCookieItemVMs)
                {
                    Plant existed = _context.Plants.Include(p => p.PlantImages).FirstOrDefault(p => p.Id == cookie.Id);
                    if (existed == null)
                    {
                        basket.BasketCookieItemVMs.Remove(cookie);
                        continue;
                    }
                    BasketItemVM basketItem = new BasketItemVM()
                    {
                        Plant = existed,
                        Quantity = cookie.Quantity
                    };
                    layoutBasket.BasketItemVMs.Add(basketItem);
                }
                layoutBasket.TotalPrice = basket.TotalPrice;
                return layoutBasket;
            }
            return null;
        }
    }
}
