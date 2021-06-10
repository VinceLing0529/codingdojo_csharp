using Microsoft.AspNetCore.Mvc;

namespace razorfun.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            // will attempt to serve 
                // Views/Hello/Index.cshtml
            // or if that file isn't there:
                // Views/Shared/Index.cshtml
            return View();
        }
        [HttpGet]
        [Route("info")]
        public ViewResult Info()
        {
            // Same logic for serving a view applies
            // if we provide the exact view name
            return View("Info");
        }
        // You may also serve the same view twice from additional actions
        [HttpGet("elsewhere")]
        public ViewResult Elsewhere()
        {
            // This would be a case where we have to specify the file name
            return View("Index");
        }
    }
}