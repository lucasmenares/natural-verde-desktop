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
    public partial class InsumosAProyectos : MetroFramework.Forms.MetroForm
    {
        InsumoDao dao = new InsumoDao();
        public InsumosAProyectos()
        {
            InitializeComponent();

            dgInsumosAProyectos.DataSource = dao.listarProyectoInsumo();

            // Insumos combobox           
            List<Insumo> insumos = new List<Insumo>();
            insumos = dao.listarInsumos();
            cbxInsumos.DataSource = insumos;
            cbxInsumos.ValueMember = "codigo";
            cbxInsumos.DisplayMember = "nombre";
        }

        private void InsumosAProyectos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            int codigo_proyecto = Convert.ToInt32(numericCodigoProyecto.Value);
            int codigo_insumo = Convert.ToInt32(cbxInsumos.SelectedValue);
            int cantidad = Convert.ToInt32(numericCantidadInsumo.Value);
            RespuestaInsumos respuesta = dao.agregaInsumoAProyecto(codigo_proyecto, codigo_insumo, cantidad);
            if (respuesta.respuesta)
            {
                MetroFramework.MetroMessageBox.Show(ActiveForm, respuesta.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(ActiveForm, respuesta.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int codigo_proyecto = Convert.ToInt32(numericCodigoProyectoFiltrar.Value);
            if(codigo_proyecto != null)
            {
                dgInsumosAProyectos.DataSource = dao.filtrarProyectoInsumo(codigo_proyecto);
            }
        }

        private void btnReiniciarFiltro_Click(object sender, EventArgs e)
        {
            dgInsumosAProyectos.DataSource = dao.listarProyectoInsumo();
        }
    }
}
