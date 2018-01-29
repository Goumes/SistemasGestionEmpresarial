using _11_Web_API_Personas_BL.Listados;
using _11_Web_API_Personas_BL.Manejadoras;
using _11_Web_API_Personas_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _11_Web_API_Personas_UI.Controllers
{
    public class PersonasController : ApiController
    {
        clsGestoraPersonaBL gestoraPersonaBL = new clsGestoraPersonaBL();
        clsListadoPersonasBL listadoPersonasBL = new clsListadoPersonasBL();
        // GET: api/Personas
        public IEnumerable<clsPersona> Get()
        {
            IEnumerable<clsPersona> personas =  listadoPersonasBL.getListadoPersonasBL();
            return personas;
        }

        // GET: api/Personas/5
        public clsPersona Get(int id)
        {
            clsPersona persona = new clsPersona();
            persona = gestoraPersonaBL.getPersonaEditar(id);
            return persona;
        }

        // POST: api/Personas
        public void Post([FromBody]clsPersona persona)
        {
            gestoraPersonaBL.getAddPersona(persona);
        }

        // PUT: api/Personas/5
        public void Put(int id, [FromBody]clsPersona persona)
        {
            persona.idPersona = id;
            gestoraPersonaBL.getGuardarPersona(persona);
        }

        // DELETE: api/Personas/5
        public void Delete(int id)
        {
            gestoraPersonaBL.getBorrarPersona(id);
        }
    }
}
