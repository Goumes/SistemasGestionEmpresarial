using _06_EjercicioRecopilatorio_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06_EjercicioRecopilatorio_ASP.Models.ViewModels
{
    public class PersonaNombreMascota : clsPersona
    {
        public string nombreMascota { get; set; }

        public PersonaNombreMascota () : base ()
        {
            this.nombreMascota = "javita0";
        }

        public PersonaNombreMascota (string nombreMascota) :base ()
        {
            this.nombreMascota = nombreMascota;
        }
    }
}