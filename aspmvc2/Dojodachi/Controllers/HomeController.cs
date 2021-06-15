using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;


namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }
        
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Happiness")==null)
            {
                HttpContext.Session.SetInt32("Happiness", 20);
                HttpContext.Session.SetInt32("Fullness", 20);
                HttpContext.Session.SetInt32("Meals", 3);
                HttpContext.Session.SetInt32("Energy", 50);

            }
            else if(HttpContext.Session.GetInt32("Happiness")>=100 && HttpContext.Session.GetInt32("Fullness")>=100)
            {   

                HttpContext.Session.SetInt32("Happiness", 100);
                HttpContext.Session.SetInt32("Fullness", 100);
                return RedirectToAction("Success");
            }
            else if(HttpContext.Session.GetInt32("Happiness")==0 || HttpContext.Session.GetInt32("Fullness")==0)
            {

                return RedirectToAction("Failed");
            }
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            return View();
            

        }

        public IActionResult Success()
        {
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            return View();
        }
        public IActionResult Failed()
        {
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            return View();
        }


        [HttpPost("feed")]
        public IActionResult Feed()
        {
            int? Meals = HttpContext.Session.GetInt32("Meals");
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            if(Meals>0)
            {
                HttpContext.Session.SetInt32("Meals", Meals-1 == null ? default(int) : Meals.Value-1);
                Random random= new Random();
                if(random.Next(1,5)!=1)
                {
                int ra = random.Next(5,11);
                Fullness += ra;
                HttpContext.Session.SetInt32("Fullness", Fullness == null ? default(int) : Fullness.Value);

                TempData["warning"]=String.Format("You success feed dojodachi , Fullness +{0}, meals -1",ra);
                }
                else{
                TempData["warning"]="You failed feed dojodachi, Fullness +0, meals - 1. ";
                }
            }
            else
            {
                TempData["warning"]="No meals";
            }
            return RedirectToAction("Index");
        }


        [HttpPost("play")]
        public IActionResult Play()
        {
            int? Energy = HttpContext.Session.GetInt32("Energy");
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            if(Energy>=5)
            {
            Energy -=5;
            HttpContext.Session.SetInt32("Energy", Energy == null ? default(int) : Energy.Value);

            Random random= new Random();
                if(random.Next(1,5)!=1)
                {
                int ra= random.Next(5,11);
                Happiness += ra;
                HttpContext.Session.SetInt32("Happiness", Happiness == null ? default(int) : Happiness.Value);
                TempData["warning"]=String.Format("You successed to play dojodachi , Happiness +{0}, Energy -5",ra);
                }
                else{
                TempData["warning"]="You failed to play with dojodachi, Happiness +0, Energy -5. ";
                }
                
            }
            else
            {
                TempData["warning"]="No Energy";
            }
            return RedirectToAction("Index");

        }

        [HttpPost("work")]
        public IActionResult Work()
        {
            int? Energy = HttpContext.Session.GetInt32("Energy");
            int? Meals = HttpContext.Session.GetInt32("Meals");
            Random rand = new Random();
            int ra = rand.Next(1,4);
            Meals+=ra;
            Energy -=5;
            HttpContext.Session.SetInt32("Energy", Energy == null ? default(int) : Energy.Value);
            HttpContext.Session.SetInt32("Meals", Meals == null ? default(int) : Meals.Value);
            TempData["Warning"]=String.Format("dojodachi worked , Meals +{0}, Energy -5",ra);;
            return RedirectToAction("Index");
        }

        [HttpPost("sleep")]
        public IActionResult sleep()
        {
            int? Energy = HttpContext.Session.GetInt32("Energy");
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            Fullness-=5;
            Happiness-=5;
            Energy +=15;
            HttpContext.Session.SetInt32("Energy", Energy == null ? default(int) : Energy.Value);
            HttpContext.Session.SetInt32("Happiness", Happiness == null ? default(int) : Happiness.Value);
            HttpContext.Session.SetInt32("Fullness", Fullness == null ? default(int) : Fullness.Value);

            TempData["Warning"]=String.Format("dojodachi sleeped , Fullness-5,Happiness-5, Energy +15");
            return RedirectToAction("Index");
        }

        [HttpPost("restart")]
        public IActionResult restart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
