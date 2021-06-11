using Microsoft.AspNetCore.Mvc;
using System;

namespace timedisplay.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Example = CurrentTime;
            return View("index");
        }
    }
}