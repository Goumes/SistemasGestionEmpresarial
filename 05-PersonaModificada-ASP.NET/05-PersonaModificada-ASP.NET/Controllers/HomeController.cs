using _05_PersonaModificada_ASP.Models.Entities;
using _05_PersonaModificada_ASP.Models.ViewModels;
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
            PersonasDepartamentos personasDepartamentos = new PersonasDepartamentos();

            return View(personasDepartamentos);
        }

        [HttpPost]
        public ActionResult Edit(PersonasDepartamentos personasDepartamentos)
        {
            clsPersonaNombreDepartamento pnd = new clsPersonaNombreDepartamento();
            pnd.nombreDepartamento = personasDepartamentos.listado.getNombreDepartamento (personasDepartamentos.idDepartamento);
            return View("PersonaModificada", pnd);
        }
    }
}