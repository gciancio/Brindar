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
        CategoriasDALImple catMng = new CategoriasDALImple();
        UsuariosDALImple usrMng = new UsuariosDALImple();
        ServiciosDALImple serMng = new ServiciosDALImple();

        // GET: /Home/RegistrarUsuario
        public ActionResult RegistrarUsuarios()
        {
            return View("RegistrarUsuarios");
        }

        [HttpPost]
        public ActionResult RegistrarUsuarios(Usuarios o)
        {
            usrMng.RegistrarUsuario(o);
            return RedirectToAction("Index", "Home");
        }

        // GET: /Home/Login
        public ActionResult Login()
        {
            ViewBag.Url = Session["url"];

            return View();
        }

        // POST: /Home/Login
        [HttpPost]
        public ActionResult Login(Usuarios u)
        {
            string url = String.IsNullOrEmpty((string)Session["Url"]) ? "/Home" : (string)Session["Url"];
            Usuarios usr = new Usuarios();
            usr.Email = u.Email;
            usr.Password = u.Password;
            if (!ModelState.IsValid || usrMng.ValidarLogin(usr) == 0)
            {
                TempData["Mensaje"] = "Usuario y/o Contraseña invalida";
                return RedirectToAction("Login", "Usuario");
            }
            Session["logeado"] = true;
            return Redirect(url);
        }

        // GET: /Home/Servicios
        public ActionResult Servicios()
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }
            
            //List<Servicios> servicios = serMng.TraerServiciosPorProveedor();
            //ViewBag.servicios = servicios;
            return View();
        }

        // GET: /Home/AltaServicio
        public ActionResult AltaServicio()
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }
            List<Categorias> categorias = catMng.TraerCategorias();
            ViewBag.categorias = categorias;

            return View();
        }

        // POST: /Home/AltaServicio
        [HttpPost]
        public ActionResult AltaServicios(Servicios s)
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }
            List<Categorias> categorias = catMng.TraerCategorias();
            ViewBag.categorias = categorias;
            Servicios servicio = new Servicios();
            servicio.Proveedor = s.Proveedor;
            servicio.Categoria = s.Categoria;
            servicio.Precio = s.Precio;
            serMng.RegistrarServicio(servicio);

            return View("Index");
        }
        
    }
}
