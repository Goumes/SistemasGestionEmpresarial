using System;
using System.Collections.Generic;
using System.Web;

namespace ViewDateViewBag.Models
{
    public class clsListaPersonas
    {
        /// <summary>
        /// Funcion que rellena una lista de personas y la envia
        /// </summary>
        /// <typeparam name="clsPersona"></typeparam>
        /// <param name=""></param>
        /// <returns></returns>
        public List <clsPersona> enviarListado()
        {
            List<clsPersona> personaList = new List<clsPersona>();
            clsPersona persona = new clsPersona();

            persona.idPersona = 1;
            persona.nombre = "pepe";
            persona.apellidos = "java";
            persona.direccion = "Su casa";
            persona.telefono = "987664756";

            personaList.Add(persona);

            persona = new clsPersona();

            persona.idPersona = 2;
            persona.nombre = "asdasd";
            persona.apellidos = "bvcbcv";
            persona.direccion = "Si";
            persona.telefono = "543534253";

            personaList.Add(persona);

            persona = new clsPersona();

            persona.idPersona = 3;
            persona.nombre = "kjhkhj";
            persona.apellidos = "java";
            persona.direccion = "Su casa";
            persona.telefono = "9876545654664756";

            personaList.Add(persona);

            persona = new clsPersona();

            persona.idPersona = 4;
            persona.nombre = "xxxxxxxxx";
            persona.apellidos = "aaaaaaaaaa";
            persona.direccion = "cccccccccc casa";
            persona.telefono = "65t4354";

            personaList.Add(persona);

            persona = new clsPersona();

            persona.idPersona = 5;
            persona.nombre = "ddddddddd";
            persona.apellidos = "ssssssssss";
            persona.direccion = "cccccccc cccc";
            persona.telefono = "123123";

            personaList.Add(persona);

            return personaList;
        }
    }
}
