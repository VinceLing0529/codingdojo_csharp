using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Users()
        {
        // to a View that has defined a model as @model string[]
        List<User> users = new List<User>();
        users.Add(new User() {Name= "Moose Phillips"});
        users.Add(new User() {Name= "Sarah"});
        users.Add(new User() {Name= "Jerry"});
        users.Add(new User() {Name= "Rene Ricky"});
        users.Add(new User() {Name= "Barbarah"});
        return View(users);
        }
        private readonly ILogger<HomeController> _logger;

        public IActionResult User()
        {
            User user = new User()
            {
                Name = "Moose Phillips"
            };
            return View(user);

        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View(model:"asdasdasad");
        }

        public IActionResult Numbers()
        {
            int[] num = new int[]
            {
                1,2,3,4,5,6,7
            };

            return View(num);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
