using Microsoft.AspNetCore.Mvc;

namespace portfolio2.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpGet]       //type of request
        [Route("/projects")]     //associated route string (exclude the leading /)
        public ViewResult Project()
        {
            return View("project");
        }

        [HttpGet]       //type of request
        [Route("/contact")]     //associated route string (exclude the leading /)
        public ViewResult Contact()
        {
            return View("contact");
        }
    }
}