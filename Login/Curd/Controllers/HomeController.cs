using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Curd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Curd.Controllers
{
    public class HomeController : Controller
    {
        private UsersContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(UsersContext context)
        {
            dbContext = context;
        }
     
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                return RedirectToAction("Success");
            }
            return View();
        }
        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "is taken.");
                }
            }
            if (ModelState.IsValid == false)
            {
                return View("Index");
            }
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("Success");
        }
        [HttpGet("Success")]
        public IActionResult Success()
        {   
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                return View();
            }
            return RedirectToAction("Index");
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginUser loginUser)
        {
            if (ModelState.IsValid == false)
            {
                return View("Index");
            }

            User dbUser = dbContext.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);
            if (dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", "email not found.");
                return View("Index"); // Display errors.
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
            if (pwCompareResult == 0)
            {
                ModelState.AddModelError("LoginEmail", "incorrect credentials.");
                return View("Index"); // Display Errors.
            }
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            return RedirectToAction("Success");
        }
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
