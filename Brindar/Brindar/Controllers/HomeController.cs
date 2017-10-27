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
    public class HomeController : Controller
    {
        UsuariosDALImple usrMng = new UsuariosDALImple();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        // GET: /Home/CrearServicio
        public ActionResult CrearServicio()
        {
            return View("CrearServicio");
        }

        [HttpPost]
        public ActionResult Registracion(Usuarios o)
        {
            if (ModelState.IsValid)
            {
                usrMng.RegistrarUsuario(o);
            }
            return RedirectToAction("Index", "Home");
        }  
    }
}
