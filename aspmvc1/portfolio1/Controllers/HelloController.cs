using Microsoft.AspNetCore.Mvc;

namespace portfolio1.Controllers
{
    public class HelloController
    {
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index!";
        }

        [HttpGet]       //type of request
        [Route("/projects")]     //associated route string (exclude the leading /)
        public string Project()
        {
            return "These are my projects!";
        }

        [HttpGet]       //type of request
        [Route("/contact")]     //associated route string (exclude the leading /)
        public string Contact()
        {
            return "This is my contact!";
        }
    }
}