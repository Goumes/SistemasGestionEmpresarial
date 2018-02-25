using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_API.Personas_CORE_BL;
using System.Collections.ObjectModel;
using _20_CRUD_Personas_ET;

namespace WEB_API.Personas_CORE_UI.Controllers
{
    [Route("api/[controller]")]
    public class personasController : Controller
    {
        clsListadoPersonasBL listadoPersonasBL = new clsListadoPersonasBL();
        // GET api/personas
        [HttpGet]
        public IEnumerable<clsPersona> Get()
        {
            IEnumerable<clsPersona> personas = listadoPersonasBL.getListadoPersonasBL();
            return personas;
        }

		// GET api/personas/5
		[HttpGet("{id}")]
        public clsPersona Get(int id)
        {
            clsPersona persona = listadoPersonasBL.buscarPersonaPorId(id);
            return persona;
        }

		// POST api/personas
		[HttpPost]
        public void Post([FromBody]clsPersona nuevaPersona)
        {
			clsListadoPersonasBL personaCreada = new clsListadoPersonasBL();
			int resultado = personaCreada.crearPersona(nuevaPersona);
		}

		// PUT api/personas/5
		[HttpPut("{id}")]
        public void Put(int id, [FromBody]clsPersona persona)
        {
			clsListadoPersonasBL listado = new clsListadoPersonasBL();
			persona.idPersona = id;
			listado.obtenerPersonaEditada(persona);
		}

		// DELETE api/personas/5
		[HttpDelete("{id}")]
        public void Delete(int id)
        {
			clsListadoPersonasBL personaEliminar = new clsListadoPersonasBL();
			int resultado = personaEliminar.eliminarPersona(id);
		}
    }
}
