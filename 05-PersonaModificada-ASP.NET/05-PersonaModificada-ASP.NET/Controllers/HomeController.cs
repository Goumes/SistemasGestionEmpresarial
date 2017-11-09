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
        // GET: Home
        public ActionResult Edit()
        {
            PersonasDepartamentos personasDepartamentos = new PersonasDepartamentos();

            return View(personasDepartamentos);
        }

        [HttpPost]
        public ActionResult Edit(PersonasDepartamentos personasDepartamentos)
        {
            if (!ModelState.IsValid)
            {
                return View(personasDepartamentos);
            }

            else
            {
                clsPersonaNombreDepartamento pnd = new clsPersonaNombreDepartamento();
                pnd.nombreDepartamento = personasDepartamentos.listado.getNombreDepartamento(personasDepartamentos.idDepartamento);
                pnd.nombre = personasDepartamentos.nombre;
                pnd.apellidos = personasDepartamentos.apellidos;
                pnd.idPersona = personasDepartamentos.idPersona;
                pnd.telefono = personasDepartamentos.telefono;
                pnd.direccion = personasDepartamentos.direccion;

                return View("PersonaModificada", pnd);
            }
        }
    }
}