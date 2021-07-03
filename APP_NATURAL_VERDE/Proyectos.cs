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
    public partial class Proyectos : MetroFramework.Forms.MetroForm
    {
        ProyectoDao dao = new ProyectoDao();
        public Proyectos()
        {
            InitializeComponent();
            dgProyectos.DataSource = dao.listarProyectos();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            int codigo_proyecto = Convert.ToInt32(numericCodigoProyecto2.Value);
            ResultadoBD resultado = dao.terminarProyecto(codigo_proyecto);

            if (resultado.respuesta)
            {
                MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarPresupuesto_Click(object sender, EventArgs e)
        {
            int codigo_proyecto = Convert.ToInt32(numericCodigoProyecto.Value);
            int precio = Convert.ToInt32(numericPresupuesto.Value);

            ResultadoBD resultado = dao.agregarPresupuesto(codigo_proyecto, precio);
            if (resultado.respuesta)
            {
                MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
