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
        public ActionResult login()
        {
            ViewBag.Url = Session["url"];

            return View();
        }


        [HttpPost]
        public ActionResult login(Usuarios u)
        {
            string url = String.IsNullOrEmpty((string)Session["Url"]) ? "/Home" : (string)Session["Url"];
            Usuarios usr = new Usuarios();
            UsuariosDALImple usrMng = new UsuariosDALImple();
            usr.Nombre = u.Nombre;
            usr.Password = u.Password;
            if (!ModelState.IsValid || !usrMng.ValidarLogin(usr))
            {
                TempData["Mensaje"] = "Usuario / Contraseña invalida";
                return RedirectToAction("login", "Usuario");
            }
            Session["logeado"] = true;
            return Redirect(url);
        }
    }
}
