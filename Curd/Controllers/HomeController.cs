using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Curd.Models;
using Microsoft.EntityFrameworkCore;



namespace Curd.Controllers
{
    public class HomeController : Controller
    {
        private DishesContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(DishesContext context)
        {
            dbContext = context;
        }
     
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            ViewBag.All = AllDishes;
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Dish dish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else{
                return View("New");
            }
        }

        [HttpGet("{DishId}")]
        public IActionResult Detail(int DishId)
        {
           Dish onedish = dbContext.Dishes.FirstOrDefault(d => d.DishId == DishId); 
          
           return View("Info",onedish);
        }

        [HttpGet("{DishId}/delete")]
        public IActionResult Delete(int DishId)
        {
           Dish onedish = dbContext.Dishes.SingleOrDefault(d => d.DishId == DishId); 
           dbContext.Dishes.Remove(onedish);
           dbContext.SaveChanges();
    
           return RedirectToAction("Index");
        }

        [HttpGet("{DishId}/edit")]
        public IActionResult Edit(int DishId)
        {
           Dish onedish = dbContext.Dishes.FirstOrDefault(d => d.DishId == DishId); 
            
    
           return View("Edit",onedish);
        }

        [HttpPost("Update")]
        public IActionResult Update(Dish dishs,int DishId)
        {
           int id = int.Parse(Request.Form["id"]);
           Dish onedish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id); 
           onedish.Name = dishs.Name;
           onedish.Chef = dishs.Chef;
           onedish.Tastiness = dishs.Tastiness;
           onedish.Calories = dishs.Calories;
           onedish.Description = dishs.Description;
           onedish.UpdatedAt = DateTime.Now;

           dbContext.SaveChanges(); 
           return RedirectToAction("Index");
        }

    }
}
