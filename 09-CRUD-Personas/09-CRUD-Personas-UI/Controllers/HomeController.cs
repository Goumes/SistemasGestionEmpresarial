using _09_CRUD_Personas_BL.Listados;
using _09_CRUD_Personas_BL.Manejadoras;
using _09_CRUD_Personas_DAL.Manejadoras;
using _09_CRUD_Personas_Entidades;
using _09_CRUD_Personas_UI.Models.ViewModels;
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
            personas = listadoPersonasBL.getListadoPersonasBL();
            List<clsPersonaNombreDepartamento> listaPersonaNombreDepartamento = new List<clsPersonaNombreDepartamento> ();
            clsGestoraDepartamentoBL gestoraDepartamentoBL = new clsGestoraDepartamentoBL();

            for (int i = 0; i < personas.Count;i++)
            {
                listaPersonaNombreDepartamento.Add(new clsPersonaNombreDepartamento (gestoraDepartamentoBL.getDepartamentoPorId(personas[i].idDepartamento).nombre, personas[i]));
            }

            return View(listaPersonaNombreDepartamento);
        }

        public ActionResult Edit(int id)
        {
            clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();
            clsPersonaListadoDepartamento personaListadoDepartamento;
            List<clsDepartamento> departamentos;
            clsListadoDepartamentosBL listadoDepartamentosBL = new clsListadoDepartamentosBL();
            departamentos = listadoDepartamentosBL.getListadoDepartamentosBL();
            clsPersona persona = gestoraPersonaBL.getPersonaEditar(id);

            personaListadoDepartamento = new clsPersonaListadoDepartamento(departamentos, persona);

            return View(personaListadoDepartamento);
        }

        [HttpPost]
        public ActionResult Edit(clsPersona persona)
        {
            int i = 0;

            clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();
            clsGestoraDepartamentoBL gestoraDepartamentoBL = new clsGestoraDepartamentoBL();

            if (!ModelState.IsValid)
            {
                return View(persona);
            }

            else
            {
                i = gestoraPersonaBL.getGuardarPersona(persona);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details (int id)
        {
            clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();
            clsPersona persona = gestoraPersonaBL.getPersonaEditar(id);

            return View(persona);
        }

        public ActionResult Delete(int id)
        {
            clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();
            clsPersona persona = gestoraPersonaBL.getPersonaEditar(id);

            return View(persona);
        }

        [HttpPost] [ActionName ("Delete")]
        public ActionResult DeletePost(int id)
        {
            int i = 0;

            clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();

            if (!ModelState.IsValid)
            {
                return View();
            }

            else
            {
                try
                {
                    i = gestoraPersonaBL.getBorrarPersona(id);
                }
                catch (Exception)
                {

                    return View("PgnError");
                }
                
            }

            return RedirectToAction("Index");
        }

        public ActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create (clsPersona clsPersona)
        {
            int i = 0;

            clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();

            if (!ModelState.IsValid)
            {
                return View();
            }

            else
            {
                try
                {
                    i = gestoraPersonaBL.getAddPersona(clsPersona);
                }
                catch (Exception)
                {

                    return View("PgnError");
                }

            }

            return RedirectToAction("Index");
        }
    }
}