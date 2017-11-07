using _06_EjercicioRecopilatorio_ASP.Models.Entities;
using _06_EjercicioRecopilatorio_ASP.Models.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06_EjercicioRecopilatorio_ASP.Models.ViewModels
{
    public class Personas : clsPersona
    {
        public clsListadoPersonas listado { get; set; }

        public Personas() : base()
        {
            listado = new clsListadoPersonas();
        }
    }
}