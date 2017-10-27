using _05_PersonaModificada_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_PersonaModificada_ASP.NET.Models.ViewModels
{
    public class PersonasDepartamentos
    {
        public clsPersona persona { get; set; }
        public clsDepartamentos departamento { get; set; }

        public PersonasDepartamentos()
        {
            persona = new clsPersona();
            departamento = new clsDepartamentos();
        }

        public PersonasDepartamentos(clsPersona persona, clsDepartamentos departamento)
        {
            this.persona = persona;
            this.departamento = departamento;
        }
    }
}