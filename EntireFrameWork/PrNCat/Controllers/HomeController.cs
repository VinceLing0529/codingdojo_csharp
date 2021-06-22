using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PrNCat.Models;

namespace PrNCat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Products()
        {
            ViewBag.Products = _context.Products.ToList();
            return View();
        }


        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("");
            }
            else
            {
            return RedirectToAction("");

            }
            
        }

        public IActionResult Categories()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }


        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category NEW)
        {
            if(ModelState.IsValid)
            {
            _context.Add(NEW);
            _context.SaveChanges();
            return RedirectToAction("Categories");
            }
            else
            {
            return RedirectToAction("Categories");

            }
            
        }

        [HttpGet("Products/{ProductId}")]
        public IActionResult Product(int ProductId)
        {
            ViewBag.Products = _context.Products.FirstOrDefault(l => l.ProductId==ProductId);
            ViewBag.Product = _context.Categories
            .Include(l=>l.Pro)
            .ThenInclude(l => l.Product)
            .Where(l => l.Pro.Any(l => l.Product.ProductId == ProductId))
            .ToList();

            
            
            ViewBag.Categories=_context.Categories
            
            .ToList();

            return View();
        }

            [HttpGet("Home/Categories/{CategoryId}")]
        public IActionResult Category(int CategoryId)
        {
            ViewBag.Categories = _context.Categories.FirstOrDefault(l => l.CategoryId==CategoryId);
            ViewBag.Product = _context.Products
            .Include(l=>l.Cat)
            .ThenInclude(l => l.Category)
            .Where(l => l.Cat.Any(l => l.Category.CategoryId == CategoryId))
            .ToList();

        
            ViewBag.Products=_context.Products.
            ToList();

            return View();
        }

        [HttpPost("AddCat")]
        public IActionResult AddCat(Association Nn)
        {
            _context.Add(Nn);
            _context.SaveChanges();
            int ProductId = Nn.ProductId;
            return RedirectToAction("");

            }
            
        }




    }
