using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20_API_ASP_Core_BL.Listados;
using _20_API_ASP_Core_BL.Manejadoras;
using _20_API_ASP_Core_ET;
using Microsoft.AspNetCore.Mvc;

namespace _20_API_ASP_Core_UI.Controllers
{
    [Route("api/[controller]")]
    public class PersonasController : Controller
    {
        clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();
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
            clsPersona persona = gestoraPersonaBL.getPersonaPorId(id);
            return persona;
        }

        // POST api/personas
        [HttpPost]
        public void Post([FromBody]clsPersona persona)
        {
            gestoraPersonaBL.getAddPersona(persona);
        }

        // PUT api/personas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]clsPersona persona)
        {
            persona.idPersona = id;
            gestoraPersonaBL.getUpdatePersona(persona);
        }

        // DELETE api/personas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            gestoraPersonaBL.getBorrarPersona(id);
        }
    }
}
