using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDateViewBag.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            String saludo;
            ViewData["fecha"] = DateTime.Now;

            if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 14)
            {
                saludo = "Buenos dias";
            }

            else if (DateTime.Now.Hour > 14 && DateTime.Now.Hour < 20)
            {
                saludo = "Buenas tardes";
            }

            else
            {
                saludo = "Buenas noches";
            }

            ViewData["saludo"] = saludo;



            ViewBag.fecha = DateTime.Now;
            String fecha = DateTime.Now.ToString("MM/dd/yyyy");

            ViewBag.fecha = fecha;



            clsPersona oPersona = new clsPersona();
            oPersona.idPersona = 1;
            oPersona.nombre = "Fran";
            oPersona.apellidos = "Carmona";
            oPersona.fechaNac = new DateTime(1995, 09, 08);
            oPersona.direccion = "Mi calle 2";
            oPersona.telefono = "98787654";

            return View(oPersona);
        }
    }
}