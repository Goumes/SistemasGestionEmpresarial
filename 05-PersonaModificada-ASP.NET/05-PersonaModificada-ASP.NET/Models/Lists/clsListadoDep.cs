using _05_PersonaModificada_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_PersonaModificada_ASP.NET.Models.Lists
{
    public class clsListadoDep : clsDepartamentos
    {
        List<clsDepartamentos> departamentos { get; set; }

        public clsListadoDep ()
        {
            this.departamentos = new List<clsDepartamentos>();
        }

        public void cargarListado()
        {
            this.departamentos.Add(new clsDepartamentos (1, "Marketing"));
            this.departamentos.Add(new clsDepartamentos (2, "Finanzas"));
            this.departamentos.Add(new clsDepartamentos (3, "Programación"));
            this.departamentos.Add(new clsDepartamentos (4, "Limpieza"));
        }
    }
}