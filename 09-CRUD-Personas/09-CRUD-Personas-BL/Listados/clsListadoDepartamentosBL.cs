﻿using _09_CRUD_Personas_DAL.Listados;
using _09_CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CRUD_Personas_BL.Listados
{
    public class clsListadoDepartamentosBL
    {
        public List<clsDepartamento> getListadoDepartamentosBL()
        {
            List<clsDepartamento> lista;

            clsListadoDepartamentosDAL listadoDepartamentosDAL = new clsListadoDepartamentosDAL();

            lista = listadoDepartamentosDAL.getListadoDepartamentosDAL();

            return lista;

        }
    }
}
