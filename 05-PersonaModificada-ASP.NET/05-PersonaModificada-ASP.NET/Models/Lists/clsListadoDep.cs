using _05_PersonaModificada_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_PersonaModificada_ASP.Models.Lists
{
    public class clsListadoDep
    {
        public List<clsDepartamentos> departamentos { get; set; }

        public clsListadoDep ()
        {
            this.departamentos = new List<clsDepartamentos>();
            this.cargarListado();
        }

        public void cargarListado()
        {
            this.departamentos.Add(new clsDepartamentos (1, "Marketing"));
            this.departamentos.Add(new clsDepartamentos (2, "Finanzas"));
            this.departamentos.Add(new clsDepartamentos (3, "Programación"));
            this.departamentos.Add(new clsDepartamentos (4, "Limpieza"));
        }

        public string getNombreDepartamento(int idDepartamento)
        {
            string resultado = "";

            for (int i = 0; i < departamentos.Count; i++)
            {
                if (this.departamentos [i].idDepartamento == idDepartamento)
                {
                    resultado = this.departamentos[i].nombre;
                }
            }
          
            return resultado;
        }
    }
}