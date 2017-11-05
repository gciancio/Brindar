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
            List<Provincias> provincias = proMng.TraerProvincias();
            ViewBag.provincias = provincias;
            List<Localidades> localidades = locMng.TraerLocalidades();
            ViewBag.localidades = localidades;
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarUsuarios(Usuarios o)
        {
            usrMng.RegistrarUsuario(o);
            return RedirectToAction("Index", "Home");
        }

        // GET: /Home/RegistrarOrganizador
        public ActionResult RegistrarOrganizador()
        {
            List<Provincias> provincias = proMng.TraerProvincias();
            ViewBag.provincias = provincias;
            List<Localidades> localidades = locMng.TraerLocalidades();
            ViewBag.localidades = localidades;
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarOrganizador(Usuarios o)
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

            Usuarios datos = new Usuarios();
            datos = usrMng.ObtenerDatosUsuario(usr.Email);
            int IdTipo = datos.TipoUsuario;

            Models.GlobalVar.IdUsuario = datos.IdUsuario;
            Models.GlobalVar.Nombre = datos.Nombre;
            Models.GlobalVar.TipoUsuario = usrMng.ObtenerTipoUsuario(IdTipo);
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
            ViewData["Servicios"] = serMng.TraerServiciosPorProveedor(Models.GlobalVar.IdUsuario);
            ViewData["Salones"] = salMng.TraerSalonPorProveedor(Models.GlobalVar.IdUsuario);
            //List<Servicios> servicios = serMng.TraerServiciosPorProveedor(Models.GlobalVar.IdUsuario);
            //List<Salones> salones = salMng.TraerSalonPorProveedor(Models.GlobalVar.IdUsuario);
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

            ViewBag.TipoUser = Models.GlobalVar.TipoUsuario;

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

            return RedirectToAction("Servicios", "Usuario");
        }

        // GET: /Home/EditarServicio
        public ActionResult EditarServicio(int? id)
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }

            List<Categorias> categorias = catMng.TraerCategorias();
            ViewBag.categorias = categorias;
            Servicios s = serMng.BuscarServicioPorId(id);
            return View(s);
        }

        // POST: /Home/EditarServicio
        [HttpPost]
        public ActionResult EditarServicio(int id, Servicios s)
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }

            s.IdServicio = id;
            List<Categorias> categorias = catMng.TraerCategorias();
            ViewBag.categorias = categorias;
            serMng.EditarServicio(s.IdServicio,s);

            return RedirectToAction("Servicios", "Usuario");
        }

        // POST: /Home/EliminarServicio
        public ActionResult EliminarServicio(int id)
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }

            serMng.BorrarServicio(id);
            return RedirectToAction("Servicios", "Usuario");
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

            return RedirectToAction("Servicios", "Usuario");
        }

        // GET: /Home/EditarSalon
        public ActionResult EditarSalon(int? id)
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
            Salones s = salMng.BuscarSalonPorId(id);
            return View(s);
        }

        // POST: /Home/EditarSalon
        [HttpPost]
        public ActionResult EditarSalon(int id, Salones s)
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }

            s.IdSalon = id;
            List<Provincias> provincias = proMng.TraerProvincias();
            ViewBag.provincias = provincias;
            List<Localidades> localidades = locMng.TraerLocalidades();
            ViewBag.localidades = localidades;
            salMng.EditarSalon(s.IdSalon, s);

            return RedirectToAction("Servicios", "Usuario");
        }

        // POST: /Home/EliminarSalon
        public ActionResult EliminarSalon(int id)
        {
            if (Session["logeado"] == null)
            {
                Session["url"] = Request.Url.AbsoluteUri;
                return RedirectToAction("login", "Usuario");
            }

            salMng.BorrarSalon(id);
            return RedirectToAction("Servicios", "Usuario");
        }

        public ActionResult Desconectarse()
        {
            Models.GlobalVar.IdUsuario = 0;
            Models.GlobalVar.Nombre = null;
            Models.GlobalVar.TipoUsuario = null;

            return RedirectToAction("Index", "Home");
        }

        public ActionResult CargarLocalidades(int idProvincia)
        {
            List<Localidades> localidades = locMng.TraerLocalidades();
            ViewBag.localidades = localidades;
            return Json(localidades.Where(l => l.IdProvincia == idProvincia).Select(l => new
            {
                IdLocalidad = l.IdLocalidad,
                Descripcion = l.Descripcion
            }).ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}
