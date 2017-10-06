using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_ListadoProductos.Models
{
    public class ProductosController : Controller
    {
        // GET: Productos

        public ActionResult Listado()
        {
            return View();
        }
    }
}