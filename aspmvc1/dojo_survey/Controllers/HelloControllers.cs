using Microsoft.AspNetCore.Mvc;

namespace dojo_survey.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost]       //type of request
        [Route("result")]     //associated route string (exclude the leading /)
        public IActionResult Method(string name, string location ,string language,string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location= location;
            ViewBag.Language= language;
            ViewBag.Comment = comment;
            return View("result");
        }
    }
}