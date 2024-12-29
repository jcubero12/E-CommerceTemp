using Microsoft.AspNetCore.Mvc;
using DE_WEB.Entities;
using DE_WEB.Interface;

namespace DE_WEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUsuarioModel _usuarioModel;
        public LoginController(IConfiguration configuration, IUsuarioModel usuarioModel)
        {
            _configuration = configuration;
            _usuarioModel = usuarioModel;
        }

        public ActionResult IndexLogin()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignUp(UsuarioEnt usuario)
        {
            var resp = _usuarioModel.SignUp(usuario);
            
            if (resp != 0)
            {
                return RedirectToAction("IndexLogin", "Login");
            }
            ViewBag.MensajePantalla = "No se pudo registrar el usuario, intente nuevamente.";
            return RedirectToAction("IdnexLogin", "Login");
        }

        [HttpPost]
        public IActionResult SignIn(UsuarioEnt usuario)
        {
            var resp = _usuarioModel.SignIn(usuario);
        
            if (resp != null)
            {
                //Variables de sesion Nombre y Token.
                HttpContext.Session.SetString("NombreCompleto", resp.nombreCompleto);
                HttpContext.Session.SetString("Token", resp.token);

                return RedirectToAction("Index", "Home");
            }
            ViewBag.MensajePantalla = "No se pudo iniciar sesión, intente nuevamente.";
            return RedirectToAction("IndexLogin", "Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ForgotPass()
        {
            return View();
        }

    }
}
