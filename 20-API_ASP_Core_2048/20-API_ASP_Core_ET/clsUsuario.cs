using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_API_ASP_Core_ET
{
    public class clsUsuario
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public int highscore { get; set; }

        public clsUsuario()
        {
            this.id = 0;
            this.nombre = "";
            this.highscore = 0;
        }
    }
}
