using Microsoft.AspNetCore.Mvc;

namespace DE_WEB.Controllers
{
    public class ProductoController : Controller
    {
        [HttpGet]
        public ActionResult ProductoDetail()
        {
            ViewData["CurrentAction"] = this.ControllerContext.RouteData.Values["action"]?.ToString();
            ViewData["CurrentController"] = this.ControllerContext.RouteData.Values["controller"]?.ToString();
            return View();
        }

        [HttpGet]
        public ActionResult Resenas()
        {
            ViewData["CurrentAction"] = this.ControllerContext.RouteData.Values["action"]?.ToString();
            ViewData["CurrentController"] = this.ControllerContext.RouteData.Values["controller"]?.ToString();
            return View();
        }

    }
}
