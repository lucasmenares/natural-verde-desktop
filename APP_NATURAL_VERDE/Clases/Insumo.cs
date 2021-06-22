using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_NATURAL_VERDE.Clases
{
    public class Insumo
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public int stock { get; set; }
        public int precio { get; set; }
        public int codigo_insumo { get; set; }
        public int codigo_proyecto { get; set; }
        public String nombre_proyecto { get; set; }
        public Insumo()
        {

        }
    }
}
