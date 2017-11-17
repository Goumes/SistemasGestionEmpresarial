using _09_CRUD_Personas_BL.Listados;
using _09_CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_CRUD_Personas_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<clsPersona> personas;
            clsListadoPersonasBL listadoPersonasBL = new clsListadoPersonasBL();

            personas = listadoPersonasBL.getListadoPersonasBL ();

            return View(personas);
        }
    }
}