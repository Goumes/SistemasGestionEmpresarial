using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11_Web_API_Personas_DAL.Listados;
using _11_Web_API_Personas_ET;

namespace _11_Web_API_Personas_BL.Listados
{
    public class clsListadoPersonasBL
    {
        public List<clsPersona> getListadoPersonasBL()
        {
            List<clsPersona> lista;

            clsListadoPersonasDAL listadoPersonasDAL = new clsListadoPersonasDAL();

            lista = listadoPersonasDAL.getListadoPersonasDAL();

            return lista;

        }
    }
}
