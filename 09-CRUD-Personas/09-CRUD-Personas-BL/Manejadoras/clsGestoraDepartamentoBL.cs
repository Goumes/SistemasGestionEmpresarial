using _09_CRUD_Personas_DAL.Manejadoras;
using _09_CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CRUD_Personas_BL.Manejadoras
{
    public class clsGestoraDepartamentoBL
    {
        public clsDepartamento getDepartamentoPorId(int id)
        {
            clsDepartamento departamento;
            clsGestoraDepartamentoDAL gestoraDepartamentoDAL = new clsGestoraDepartamentoDAL();
            departamento = gestoraDepartamentoDAL.buscarDepartamentoPorID(id);

            return departamento;
        }
        public clsDepartamento getDepartamentoPorNombre(String nombre)
        {
            clsDepartamento departamento;
            clsGestoraDepartamentoDAL gestoraDepartamentoDAL = new clsGestoraDepartamentoDAL();
            departamento = gestoraDepartamentoDAL.buscarDepartamentoPorNombre(nombre);

            return departamento;
        }
    }
}
