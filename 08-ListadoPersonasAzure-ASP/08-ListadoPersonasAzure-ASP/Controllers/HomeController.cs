using _05_PersonaModificada_ASP.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08_ListadoPersonasAzure_ASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SqlConnection miConexion = new SqlConnection();

            List<clsPersona> listadoPersonas = new List<clsPersona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clsPersona oPersona;


            miConexion.ConnectionString = "server = personasbdserver.database.windows.net;database = PersonasDB; uid = agomez; pwd = Password123;";


            try
            {
                miConexion.Open();

                //Creamos el comando (Creamos el comando, le pasamos la sentencia y la conexion, y lo ejecutamos)

                miComando.CommandText = "SELECT * FROM personas";
                
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();

                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.idPersona = (int)miLector["IDPersona"];
                        oPersona.nombre = (string)miLector["nombre"];
                        oPersona.apellidos = (string)miLector["apellidos"];
                        oPersona.fechaNac = (DateTime)miLector["fechaNac"];
                        oPersona.direccion = (string)miLector["direccion"];
                        oPersona.telefono = (string)miLector["telefono"];
                        listadoPersonas.Add(oPersona);
                    }
                }

                miLector.Close();
                miConexion.Close();
            }

            catch (SqlException exSql)
            {
                throw exSql;
            }

            return View(listadoPersonas);
        }
    }
}