using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
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
        ProvinciasDALImple proMng = new ProvinciasDALImple();
        LocalidadesDALImple locMng = new LocalidadesDALImple();
        SalonesDALImple salMng = new SalonesDALImple();

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
            Models.GlobalVar.IdUsuario = usrMng.ObtenerIdUsuario(usr.Email);
            Models.GlobalVar.Nombre = usr.Nombre;
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

            List<Servicios> servicios = serMng.TraerServiciosPorProveedor(Models.GlobalVar.IdUsuario);
            return View(servicios);
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
            
            Servicios servicio = new Servicios();
            servicio.Proveedor = Models.GlobalVar.IdUsuario;
            servicio.Categoria = s.Categoria;
            servicio.Precio = s.Precio;
            serMng.RegistrarServicio(servicio);

            return View("Servicios");
        }

        // GET: /Home/AltaSalon
        public ActionResult AltaSalon()
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }
            List<Provincias> provincias = proMng.TraerProvincias();
            ViewBag.provincias = provincias;
            List<Localidades> localidades = locMng.TraerLocalidades();
            ViewBag.localidades = localidades;

            return View();
        }

        // POST: /Home/AltaSalon
        [HttpPost]
        public ActionResult AltaSalon(Salones s)
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }

            Salones salon = new Salones();
            salon.Proveedor = Models.GlobalVar.IdUsuario;
            salon.Nombre = s.Nombre;
            salon.Precio = s.Precio;
            salon.Telefono = s.Telefono;
            salon.Provincia = s.Provincia;
            salon.Localidad = s.Localidad;
            salon.Direccion = s.Direccion;
            salon.URLFacebook = s.URLFacebook;
            salon.URLPagina = s.URLPagina;
            salMng.RegistrarSalon(salon);

            return View("Servicios");
        }
        
    }
}
