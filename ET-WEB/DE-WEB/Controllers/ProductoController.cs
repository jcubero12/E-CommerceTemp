using Microsoft.AspNetCore.Mvc;

namespace DE_WEB.Controllers
{
    public class ProductoController : Controller
    {
        [HttpGet]
        public ActionResult ProductoDetail()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Resenas()
        {
            return View();
        }

    }
}
