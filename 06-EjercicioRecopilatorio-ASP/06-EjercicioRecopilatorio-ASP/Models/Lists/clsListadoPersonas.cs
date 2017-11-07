using _06_EjercicioRecopilatorio_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06_EjercicioRecopilatorio_ASP.Models.Lists
{
    public class clsListadoPersonas
    {
        public List <clsPersona> personas { get; set; }

        public clsListadoPersonas ()
        {
            this.personas = new List <clsPersona> ();
            this.cargar();
        }

        public clsListadoPersonas (List <clsPersona> personas)
        {
            this.personas = personas;
        }

        public void cargar()
        {
            this.personas.Add(new clsPersona (1, "pepejava1", "apellido1_1", "apellido2_1", "direccion1", "111111111", 1));
            this.personas.Add(new clsPersona(2, "pepejava2", "apellido1_2", "apellido2_2", "direccion2", "222222222", 2));
            this.personas.Add(new clsPersona(3, "pepejava3", "apellido1_3", "apellido2_3", "direccion3", "333333333", 3));
            this.personas.Add(new clsPersona(4, "pepejava4", "apellido1_4", "apellido2_4", "direccion4", "444444444", 4));
            this.personas.Add(new clsPersona(5, "pepejava5", "apellido1_5", "apellido2_5", "direccion5", "555555555", 5));
            this.personas.Add(new clsPersona(6, "pepejava6", "apellido1_6", "apellido2_6", "direccion6", "666666666", 6));
            this.personas.Add(new clsPersona(7, "pepejava7", "apellido1_7", "apellido2_7", "direccion7", "777777777", 7));
            this.personas.Add(new clsPersona(8, "pepejava8", "apellido1_8", "apellido2_8", "direccion8", "888888888", 8));
            this.personas.Add(new clsPersona(9, "pepejava9", "apellido1_9", "apellido2_9", "direccion9", "999999999", 9));
            this.personas.Add(new clsPersona(10, "pepejava10", "apellido1_10", "apellido2_10", "direccion10", "101010101", 10));
            this.personas.Add(new clsPersona(11, "pepejava11", "apellido1_11", "apellido2_11", "direccion11", "110110110", 11));
            this.personas.Add(new clsPersona(12, "pepejava12", "apellido1_12", "apellido2_12", "direccion12", "121212121", 12));
        }

        public clsPersona getPersonaPorId (int idPersona)
        {
            clsPersona resultado = new clsPersona();

            for (int i = 0; i < this.personas.Count; i++)
            {
                if (this.personas[i].idPersona == idPersona)
                {
                    resultado = this.personas[i];
                }
            }

            return resultado;
        }

    }
}