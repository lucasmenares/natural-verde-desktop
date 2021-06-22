using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_NATURAL_VERDE.Clases
{
    public class Horario
    {
        public int codigo { get; set; }
        public String hora { get; set; }
        public int codigo_dia { get; set; }
        public int codigo_equipo { get; set; }
        public int codigo_proyecto { get; set; }
        public DateTime dia { get; set; }
        public String equipo { get; set; }
        public String proyecto { get; set; }

        public Horario()
        {

        }
    }
}
