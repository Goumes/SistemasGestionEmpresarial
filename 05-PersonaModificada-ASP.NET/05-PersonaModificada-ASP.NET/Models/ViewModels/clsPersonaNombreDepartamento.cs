using _05_PersonaModificada_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_PersonaModificada_ASP.Models.ViewModels
{
    public class clsPersonaNombreDepartamento : clsPersona
    {
        public String nombreDepartamento { get; set; }

        public clsPersonaNombreDepartamento() : base() //Esto es como el super
        {
            nombreDepartamento = "Marketing";
        }

        public clsPersonaNombreDepartamento(String departamento) : base()
        {
            this.nombreDepartamento = departamento;
        }
    }
}