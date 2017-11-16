using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05_PersonaModificada_ASP.Models.Entities
{
    public class clsPersona
    {
        public int idPersona { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Apellidos")]
        [MaxLength(40)]
        public string apellidos { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaNac { get; set; }
        [MaxLength(200)]
        public string direccion { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[9|6|7][0-9]{8}$", ErrorMessage = "Not a valid Phone number")]
        public string telefono { get; set; }
        public int idDepartamento { get; set; }

        public clsPersona()
        {
            this.idPersona = 0;
            this.nombre = "Alejandro";
            this.apellidos = "Gómez";
            this.direccion = "Mi casa";
            this.telefono = "954224444";
            this.idDepartamento = 3;
        }

        public clsPersona(String nombre, String apellidos, String direccion, String telefono)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
        }

    }
}

  