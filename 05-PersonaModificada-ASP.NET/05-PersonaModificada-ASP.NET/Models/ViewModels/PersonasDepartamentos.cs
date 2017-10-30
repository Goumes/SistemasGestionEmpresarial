using _05_PersonaModificada_ASP.Models.Entities;
using _05_PersonaModificada_ASP.Models.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_PersonaModificada_ASP.Models.ViewModels
{
    public class PersonasDepartamentos : clsPersona
    {
        public clsListadoDep listado { get; set; }
        public PersonasDepartamentos() : base () //Esto es como el super
        {
            listado = new clsListadoDep();
        }
    }
}