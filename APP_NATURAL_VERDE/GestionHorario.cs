using APP_NATURAL_VERDE.Clases;
using APP_NATURAL_VERDE.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NATURAL_VERDE
{
    public partial class GestionHorario : MetroFramework.Forms.MetroForm
    {
        private List<Dia> dias { get; set; }
        public GestionHorario()
        {
            InitializeComponent();
            DiaDao dao = new DiaDao();
            dias = dao.listadoDia();
            metroComboBox1.DataSource = dias;
            metroComboBox1.ValueMember = "codigo";
            metroComboBox1.DisplayMember = "dia";
        }

        private void GestionHorario_Load(object sender, EventArgs e)
        {

        }
    }
}
