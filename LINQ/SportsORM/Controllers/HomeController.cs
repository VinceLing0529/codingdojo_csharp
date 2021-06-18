using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomenLeagues= _context.Leagues
                .Where(l => l.Name.Contains("Women"))
                .ToList();
            
            ViewBag.HockeyLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Hockey"))
                .ToList();
            

            ViewBag.NonFootball = _context.Leagues
                .Except(_context.Leagues
                .Where(l => l.Sport.Contains("Football")))
                .ToList();

            ViewBag.Conference= _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();  

            ViewBag.Atlanta= _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList(); 

            ViewBag.Dallas= _context.Teams
                .Where(l => l.Location.Contains("Dallas"))
                .ToList();            

            ViewBag.Raptors= _context.Teams
                .Where(l => l.TeamName.Contains("Raptors"))
                .ToList();   

            ViewBag.City= _context.Teams
                .Where(l => l.Location.Contains("City"))
                .ToList();    

            ViewBag.TTeams= _context.Teams
                .Where(l => l.TeamName.StartsWith("T"))
                .ToList();     

            ViewBag.Allteamsbylocation= _context.Teams
                .OrderBy(l => l.Location)
                .ToList();     

            ViewBag.Allteamsbynames= _context.Teams
                .OrderByDescending(l => l.TeamName)
                .ToList();     

            ViewBag.Cooper= _context.Players
                .Where(l => l.LastName.Contains("Cooper"))
                .ToList();     

            ViewBag.Joshua= _context.Players
                .Where(l => l.FirstName.Contains("Joshua"))
                .ToList(); 

            ViewBag.CooperWOJoshus= _context.Players
                .Except(_context.Players.Where(l => l.FirstName.Contains("Joshua")))
                .Where(l => l.LastName.Contains("Cooper"))
                .ToList();

            ViewBag.AlexOrWyatt= _context.Players
                .Where(l => l.FirstName.Contains("Alexander") ||l.FirstName.Contains("Wyatt") )
                .ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            ViewBag.AASC= _context.Teams
            .Include(l => l.CurrLeague)
            .Where(l => l.CurrLeague.Name == "Atlantic Soccer Conference")
            .ToList();
            
            ViewBag.ABP =_context.Players
            .Where(i => i.TeamId==28)
            .ToList();
            
            var Icbc =_context.Teams.Where(l => l.LeagueId == 2).ToList();
            List<Player> allplayer = new List<Player>();
           foreach(var i in Icbc)
           {
               List<Player> current = _context.Players.Where(l=>l.TeamId == i.TeamId).ToList();
               allplayer.AddRange(current);
               
           }
           ViewBag.IC = allplayer;


            
        ViewBag.ACAF =_context.Players
            .Include(l => l.CurrentTeam.CurrLeague)
            .Where(l => l.CurrentTeam.CurrLeague.Name == "American Conference of Amateur Football")
            .Where(l => l.LastName == "Lopez")
            .ToList();
                

        ViewBag.Allfootball =_context.Players
            .Include(l => l.CurrentTeam.CurrLeague)
            .Where(l => l.CurrentTeam.CurrLeague.Sport == "Football")
            .ToList();
                
        ViewBag.ATeamOfSophia = _context.Teams
            .Include(l =>l.CurrentPlayers)
            .Where(l => l.CurrentPlayers.Any(j => j.LastName =="Sophia" || j.FirstName=="Sophia"))
            .ToList();

        ViewBag.AleagueOfSophia = _context.Leagues
            .Include(l =>l.Teams)
            .Where(l => l.Teams.Any(j => j.CurrentPlayers.Any(x => x.LastName=="Sophia" || x.FirstName=="Sophia")))
            .ToList();

        ViewBag.Flores = _context.Players
            .Include(l => l.CurrentTeam)
            .Where(l => l.CurrentTeam.TeamName!= "Roughriders" && l.CurrentTeam.Location!="Washington")
            .Where(l => l.LastName =="Flores")
            .ToList();

            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}