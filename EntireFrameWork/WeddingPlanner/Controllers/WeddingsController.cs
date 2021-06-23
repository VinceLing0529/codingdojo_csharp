using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingsController : Controller
    {
         private WeddingPlannerContext _context;
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        
        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }
        public WeddingsController(WeddingPlannerContext context)
        {
            _context = context;
        }

        
        public IActionResult Dashboard()
        {
            if(isLoggedIn){
            ViewBag.AllWedding = _context.Weddings
            .Include(l => l.Guest)
            .ToList();

            foreach(var i in ViewBag.AllWedding)
            {
                if(i.Date < DateTime.Now)
                {
                _context.Weddings.Remove(i);
                 _context.SaveChanges();              
              }
            }

             ViewBag.Exceptions = _context.Weddings
            .Include(l => l.Guest)
            .ThenInclude(l =>l.User)
            .Where(l => l.Guest.Any(l => l.User.UserId == uid ))
            .ToList();

            ViewBag.Id= uid;

            return View();
            }
            return RedirectToAction("Index","Home");
        }

        public IActionResult New()
        {   
            if(isLoggedIn){
            ViewBag.Id= uid;
            return View();
            }
            return RedirectToAction("Index","Home");

        }

        
        [HttpPost("Create")]
        public IActionResult Create(Wedding n)
        {
             if (ModelState.IsValid == false)
            {
                // Show form again to display errors.
                Console.WriteLine("Not valid");
                return View("New");
            }
            
            _context.Weddings.Add(n);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");

        }
        [HttpPost("Reserve")]
        public IActionResult Reserve(Guest n)
        {
            
            _context.Guests.Add(n);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");

        }
        [HttpPost("UnReserve")]
        public IActionResult UnReserve(Guest n)
        {
            Guest one =_context.Guests
            .SingleOrDefault(d => d.WeddingId == n.WeddingId && d.UserId == n.UserId); 
            _context.Guests.Remove(one);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");

        }

        [HttpGet("{WeddingId}/delete")]
        public IActionResult Delete(int WeddingId)
        {
            Wedding one = _context.Weddings
            .SingleOrDefault(d => d.WeddingId == WeddingId); 
           _context.Weddings.Remove(one);
           _context.SaveChanges();
           return RedirectToAction("Dashboard");
        }

        [HttpGet("{WeddingId}")]
        public IActionResult Detail(int WeddingId)
        {

            ViewBag.Wed = _context.Weddings
            .Include(l => l.Guest)
            .ThenInclude(l => l.User)
            .FirstOrDefault(d => d.WeddingId == WeddingId)
            ;
            
           
           return View("Detail");
        }
    }
}