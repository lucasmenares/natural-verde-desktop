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
    public partial class VerInsumos : MetroFramework.Forms.MetroForm
    {
        InsumoDao dao = new InsumoDao();
        public VerInsumos()
        {
            InitializeComponent();
            dgInsumos.DataSource = dao.listarInsumos();
            dgInsumos.Columns["CODIGO_PROYECTO"].Visible = false;
            dgInsumos.Columns["CODIGO_INSUMO"].Visible = false;
            dgInsumos.Columns["NOMBRE_PROYECTO"].Visible = false;
        }

        private void VerInsumos_Load(object sender, EventArgs e)
        {

        }
    }
}
