using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_NATURAL_VERDE.Clases
{
    public class ResultadoBD
    {
        public bool respuesta { get; set; }
        public String mensaje { get; set; }

        public ResultadoBD()
        {
            respuesta = false;
            mensaje = "No se pudo ejecutar";
        }
    }
}
