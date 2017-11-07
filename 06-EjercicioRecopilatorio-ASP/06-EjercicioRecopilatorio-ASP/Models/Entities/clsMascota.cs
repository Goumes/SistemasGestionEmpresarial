using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06_EjercicioRecopilatorio_ASP.Models.Entities
{
    public class clsMascota
    {
        public int idMascota { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNac { get; set; }

        public clsMascota()
        {
            this.idMascota = 0;
            this.nombre = "Lucas";
            this.fechaNac = new DateTime();
        }

        public clsMascota (int idMascota, string nombre, DateTime fechaNac)
        {
            this.idMascota = idMascota;
            this.nombre = nombre;
            this.fechaNac = fechaNac;
        }
    }

   
}