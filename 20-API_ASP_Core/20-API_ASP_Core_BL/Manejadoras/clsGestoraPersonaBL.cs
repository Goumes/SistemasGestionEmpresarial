using _20_API_ASP_Core_DAL.Manejadoras;
using _20_API_ASP_Core_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_API_ASP_Core_BL.Manejadoras
{
    public class clsGestoraPersonaBL
    {
        clsGestoraPersonaDAL gestoraPersonaDAL;
        public clsPersona getPersonaPorId(int id)
        {
            clsPersona persona;
            gestoraPersonaDAL = new clsGestoraPersonaDAL();
            persona = gestoraPersonaDAL.buscarPersonaPorId(id);

            return persona;
        }

        public int getUpdatePersona(clsPersona persona)
        {
            int resultado = 0;
            clsGestoraPersonaDAL gestoraPersonaDAL = new clsGestoraPersonaDAL();
            resultado = gestoraPersonaDAL.updatePersonaDAL(persona);
                        
            return resultado;
        }

        public int getBorrarPersona(int id)
        {
            int resultado = 0;
            clsGestoraPersonaDAL gestoraPersonaDAL = new clsGestoraPersonaDAL();
            resultado = gestoraPersonaDAL.deletePersona(id);

            return resultado;
        }

        public int getAddPersona (clsPersona persona)
        {
            int resultado = 0;

            clsGestoraPersonaDAL gestoraPersonaDAL = new clsGestoraPersonaDAL();
            resultado = gestoraPersonaDAL.addPersonaDAL(persona);

            return resultado;
        }
    }
}
