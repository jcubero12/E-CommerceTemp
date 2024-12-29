using Microsoft.AspNetCore.Mvc;

namespace DE_WEB.Controllers
{
    public class CheckoutController : Controller
    {

        [HttpGet]
        public ActionResult IndexCheckout()
        {
            return View();
        }

    }
}
