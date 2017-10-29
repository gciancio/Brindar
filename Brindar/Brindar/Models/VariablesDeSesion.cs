using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brindar.Models
{
    public static class VariablesDeSesion
    {
        public static Usuarios getSessionUser()
        {
            if (HttpContext.Current.Session["usuario"] != null)
            {
                return (Usuarios)HttpContext.Current.Session["usuario"];
            }
            return null;
        }

        public static void setSessionUser(Usuarios usuario)
        {
            HttpContext.Current.Session["usuario"] = usuario;
        }

        public static void setSessionPaginaPrevia(String paginaprevia)
        {
            HttpContext.Current.Session["paginaprevia"] = paginaprevia;
        }

        public static string getSessionPaginaPrevia()
        {
            if (HttpContext.Current.Session["paginaprevia"] == null)
            {
                return null;
            }
            return (string)HttpContext.Current.Session["paginaprevia"];
        }

        public static void destroySessionPaginaPrevia()
        {
            HttpContext.Current.Session.Remove("paginaprevia");
        }

        public static void RemoveAllSessionVariables()
        {
            HttpContext.Current.Session.RemoveAll();
        }
    }
}