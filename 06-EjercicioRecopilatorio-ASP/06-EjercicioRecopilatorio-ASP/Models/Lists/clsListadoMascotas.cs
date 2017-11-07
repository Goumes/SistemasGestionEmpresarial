using _06_EjercicioRecopilatorio_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06_EjercicioRecopilatorio_ASP.Models.Lists
{
    public class clsListadoMascotas
    {
        public List<clsMascota> mascotas { get; set; }

        public clsListadoMascotas()
        {
            this.mascotas = new List<clsMascota>();
            this.cargar();
        }

        public clsListadoMascotas(List<clsMascota> mascotas)
        {
            this.mascotas = mascotas;
        }

        public void cargar()
        {
            this.mascotas.Add(new clsMascota(1, "javita1", new DateTime (2001, 1, 1)));
            this.mascotas.Add(new clsMascota(2, "javita2", new DateTime(2002, 2, 2)));
            this.mascotas.Add(new clsMascota(3, "javita3", new DateTime(2003, 3, 3)));
            this.mascotas.Add(new clsMascota(4, "javita4", new DateTime(2004, 4, 4)));
            this.mascotas.Add(new clsMascota(5, "javita5", new DateTime(2005, 5, 5)));
            this.mascotas.Add(new clsMascota(6, "javita6", new DateTime(2006, 6, 6)));
            this.mascotas.Add(new clsMascota(7, "javita7", new DateTime(2007, 7, 7)));
            this.mascotas.Add(new clsMascota(8, "javita8", new DateTime(2008, 8, 8)));
            this.mascotas.Add(new clsMascota(9, "javita9", new DateTime(2009, 9, 9)));
            this.mascotas.Add(new clsMascota(10, "javita10", new DateTime(2010, 10, 10)));
            this.mascotas.Add(new clsMascota(11, "javita11", new DateTime(2011, 11, 11)));
            this.mascotas.Add(new clsMascota(12, "javita12", new DateTime(2012, 12, 12)));
        }

        public string getNombreMascota (int idMascota)
        {
            string resultado = "";

            for (int i = 0; i < mascotas.Count; i++)
            {
                if (this.mascotas[i].idMascota == idMascota)
                {
                    resultado = this.mascotas[i].nombre;
                }
            }

            return resultado;
        }

    }
}