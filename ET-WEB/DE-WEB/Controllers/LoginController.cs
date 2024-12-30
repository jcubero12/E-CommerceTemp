using Microsoft.AspNetCore.Mvc;
using DE_WEB.Entities;


namespace DE_WEB.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult IndexLogin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ForgotPass()
        {
            return View();
        }

    }
}
