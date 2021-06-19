using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefNDish.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefNDish.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {   
            ViewBag.AllChef = _context.Chefs.Include(l => l.AllDishes).ToList();
            
            return View();
        }

        public IActionResult New()
        {
            return View();
        }   
        public IActionResult NewDish()
        {
            ViewBag.AllChef = _context.Chefs.ToList();
            return View();
        }   

        public IActionResult Dishes()
        {
            ViewBag.AllDish=_context.Dishes.Include(l => l.creater).ToList();
            return View();
        }


        [HttpPost("Create")]
        public IActionResult Create(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }   
        [HttpPost("CreateDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewDish");
            }
        }   




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
