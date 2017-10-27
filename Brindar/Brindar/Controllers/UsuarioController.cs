using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brindar.DAL.Repositorio;
using Brindar.Logica.Modelo;
using Brindar.Logica.Servicio;

namespace Brindar.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(Usuarios u)
        {
            Usuarios usr = new Usuarios();
            UsuariosDALImple usrMng = new UsuariosDALImple();
            usr.Email = u.Email;
            usr.Password = u.Password;
            if (usrMng.ValidarLogin(usr)==0)
            {
                TempData["Mensaje"] = "Usuario / Contraseña invalida";
                return RedirectToAction("Login", "Usuario");
            }
            Session["logeado"] = true;
            return RedirectToAction("CrearServicio", "Home");
        }
    }
}
