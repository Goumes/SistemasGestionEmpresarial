using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_PersonaModificada_ASP.Models.Entities
{
    public class clsDepartamentos
    {
       public int idDepartamento { get; set; }
       public string nombre { get; set; }

        public clsDepartamentos()
        {
            this.idDepartamento = 1;
            this.nombre = "";
        }

        public clsDepartamentos(int idDepartamento, string nombre)
        {
            this.idDepartamento = idDepartamento;
            this.nombre = nombre;
        }
    }
}

  