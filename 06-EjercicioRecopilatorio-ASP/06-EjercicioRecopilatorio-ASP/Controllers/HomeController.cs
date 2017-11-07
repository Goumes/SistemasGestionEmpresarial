using _06_EjercicioRecopilatorio_ASP.Models.Entities;
using _06_EjercicioRecopilatorio_ASP.Models.Lists;
using _06_EjercicioRecopilatorio_ASP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_EjercicioRecopilatorio_ASP.Views.Home
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Personas personas = new Personas();

            return View(personas);
        }

        [HttpPost]
        public ActionResult Index (Personas personas)
        {
            PersonaNombreMascota pnm = new PersonaNombreMascota();
            clsListadoMascotas listado = new clsListadoMascotas();
            clsListadoPersonas personas2 = new clsListadoPersonas();

            pnm.nombreMascota = listado.getNombreMascota(personas2.getPersonaPorId(personas.idPersona).idMascota);

            pnm.nombre = personas2.getPersonaPorId(personas.idPersona).nombre;
            pnm.apellido1 = personas2.getPersonaPorId(personas.idPersona).apellido1;
            pnm.apellido2 = personas2.getPersonaPorId(personas.idPersona).apellido2;
            pnm.direccion = personas2.getPersonaPorId(personas.idPersona).direccion;
            pnm.idPersona = personas2.getPersonaPorId(personas.idPersona).idPersona;
            pnm.telefono = personas2.getPersonaPorId(personas.idPersona).telefono;


            return View ("DatosMascota", pnm);
        }
    }
}