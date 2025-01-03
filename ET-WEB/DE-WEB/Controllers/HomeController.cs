using System.Diagnostics;
using DE_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace DE_WEB.Controllers
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
           
            ViewData["CurrentController"] = this.ControllerContext.RouteData.Values["controller"]?.ToString();
            return View();
        }


    }
}
