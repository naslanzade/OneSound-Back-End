﻿using Microsoft.AspNetCore.Mvc;
using OneSoundApp.Models;
using OneSoundApp.Services.Interfaces;
using OneSoundApp.ViewModels.Shop;

namespace OneSoundApp.Controllers
{
    public class ShopController : Controller
    {
        
        private readonly ICategoryService _categoryService;
     
        public ShopController(ICategoryService categoryService)
        {
                        
            _categoryService = categoryService;
        
        }
        public async Task<IActionResult> Index()
        {


            List<Category> categories = await _categoryService.GetAll();

            ShopVM model = new()
            {
               Categories= categories,
                     
            };



            return View(model);
        }





    }
}
