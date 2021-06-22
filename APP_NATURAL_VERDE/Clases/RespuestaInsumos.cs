using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_NATURAL_VERDE.Clases
{
    public class RespuestaInsumos
    {
        public bool respuesta { get; set; }
        public int stock { get; set; }
        public String mensaje { get; set; }
        public RespuestaInsumos()
        {
            respuesta = false;
            stock = 0;
        }
    }
}
