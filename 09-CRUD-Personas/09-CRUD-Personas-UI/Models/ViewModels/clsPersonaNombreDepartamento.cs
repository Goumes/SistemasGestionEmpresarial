using _09_CRUD_Personas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09_CRUD_Personas_UI.Models.ViewModels
{
    public class clsPersonaNombreDepartamento
    {
        public String nombreDepartamento { get; set; }
        public clsPersona persona { get; set; }

        public clsPersonaNombreDepartamento ()
        {
            nombreDepartamento = "Marketing";
            persona = new clsPersona();
        }

        public clsPersonaNombreDepartamento (String departamento, clsPersona persona)
        {
            this.nombreDepartamento = departamento;
            this.persona = persona;
        }
    }
}