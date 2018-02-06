using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20_API_ASP_Core_DAL.Listados;
using _20_API_ASP_Core_ET;

namespace _20_API_ASP_Core_BL.Listados
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
