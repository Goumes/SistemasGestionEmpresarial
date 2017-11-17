using _09_CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_CRUD_Personas_DAL.Listados;

namespace _09_CRUD_Personas_BL.Listados
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
