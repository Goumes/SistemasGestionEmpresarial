using _05_PersonaModificada_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_PersonaModificada_ASP.NET.Views.Controllers
{
        public class HomeController : Controller
    {
        //[HttpPost]
        // GET: Home
        public ActionResult Edit()
        {
            clsPersona persona = new clsPersona();

            return View(persona);
        }

        [HttpPost]
        public ActionResult Edit(clsPersona persona)
        {
            return View("PersonaModificada", persona);
        }
    }
}