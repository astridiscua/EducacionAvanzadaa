using EducacionAvanzada.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EducacionAvanzada.Web.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        SeguridaBL _seguridadBL;
        AlumnosBL _alumnosBL;
        PadresBL _padresBL;
        public LoginController()
        {
            _seguridadBL = new SeguridaBL();
            _alumnosBL = new AlumnosBL();
            _padresBL = new PadresBL();
        }

     

        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
           
            var nombreUsuario = data["usuario"];
            var contrasena = data["Contrasena"];

            var usuarioValido = _seguridadBL
                .Autorizar(nombreUsuario, contrasena);
            
           
            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreUsuario, true);
                
                return RedirectToAction("Index", "Alumnos", new { });
                
            }

            ModelState.AddModelError("", "Usuario o contraseña invalido");

            return View();
        }
    }
}