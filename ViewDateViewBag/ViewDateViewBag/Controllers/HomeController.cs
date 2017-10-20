using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDateViewBag.Models;

namespace ViewDateViewBag.Controllers
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
            oPersona.nombre = "Alejandro";
            oPersona.apellidos = "Gómez";
            oPersona.fechaNac = new DateTime(1996, 10, 28);
            oPersona.direccion = "Mi calle";
            oPersona.telefono = "954224444";

            return View(oPersona);
        }

        public ActionResult ListaPersonas()
        {
            clsListaPersonas listaPersonas = new clsListaPersonas();

            return View(listaPersonas);
        }
    }
}