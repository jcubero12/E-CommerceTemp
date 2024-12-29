using Microsoft.AspNetCore.Mvc;

namespace DE_WEB.Controllers
{
    public class CategoriesController : Controller
    {
        [HttpGet]
        public ActionResult Perfumes()
        {
            ViewData["CurrentAction"] = this.ControllerContext.RouteData.Values["action"]?.ToString();
            ViewData["CurrentController"] = this.ControllerContext.RouteData.Values["controller"]?.ToString();
            return View();
        }
        [HttpGet]
        public IActionResult CuidadoCorporal()
        {
            ViewData["CurrentAction"] = this.ControllerContext.RouteData.Values["action"]?.ToString();
            ViewData["CurrentController"] = this.ControllerContext.RouteData.Values["controller"]?.ToString();
            return View();
        }
        [HttpGet]
        public IActionResult Cabello()
        {
            ViewData["CurrentAction"] = this.ControllerContext.RouteData.Values["action"]?.ToString();
            ViewData["CurrentController"] = this.ControllerContext.RouteData.Values["controller"]?.ToString();
            return View();
        }
    }

}