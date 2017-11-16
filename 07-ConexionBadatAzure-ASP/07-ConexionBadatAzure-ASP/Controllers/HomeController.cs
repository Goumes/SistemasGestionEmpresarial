using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_ConexionBadatAzure_ASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           return View();
        }

        [HttpPost]
        public ActionResult Index(String abrir)
        {
            SqlConnection miConexion = new SqlConnection();

            try
            {
                miConexion.ConnectionString = "server = personasbdserver.database.windows.net;database = PersonasDB; uid = agomez; pwd = Password123;";
                miConexion.Open();
            }
            catch (ArgumentException e) { }

            ViewBag.conexionAbierta = miConexion.State;
            return View();
        }

    }
}