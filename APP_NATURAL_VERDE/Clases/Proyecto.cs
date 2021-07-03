using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_NATURAL_VERDE.Clases
{
    public class Proyecto
    {
        public int codigo { get; set; }
        public int codigo_usuario { get; set; }
        public int codigo_servicio { get; set; }
        public int codigo_horario { get; set; }
        public String nombre { get; set; }
        public String presupuesto { get; set; }
        public String estado { get; set; }
        public String direccion { get; set; }
        public String descripcion { get; set; }
        public int precio { get; set; }

        public Proyecto()
        {

        }
    }
}
