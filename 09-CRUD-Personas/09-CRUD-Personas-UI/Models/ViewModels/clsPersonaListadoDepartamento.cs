using _09_CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09_CRUD_Personas_UI.Models.ViewModels
{
    public class clsPersonaListadoDepartamento
    {
        public List<clsDepartamento> listadoDepartamento { get; set; }
        public clsPersona persona { get; set; }

        public clsPersonaListadoDepartamento ()
        {
            this.listadoDepartamento = new List<clsDepartamento>();
            this.persona = new clsPersona();
        }

        public clsPersonaListadoDepartamento (List <clsDepartamento> departamentos, clsPersona persona)
        {
            this.listadoDepartamento = departamentos;
            this.persona = persona;
        }
    }
}