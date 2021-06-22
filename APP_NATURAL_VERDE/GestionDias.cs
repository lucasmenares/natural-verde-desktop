using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using APP_NATURAL_VERDE.Clases;
using APP_NATURAL_VERDE.Dao;
using System.Globalization;

namespace APP_NATURAL_VERDE
{
    public partial class GestionDias : MetroFramework.Forms.MetroForm

    {

        DiaDao dao = new DiaDao();


        public GestionDias()
        {
            InitializeComponent();
            //Cargar Grid de la gestion de equipo
            dgDiasDisponibles.DataSource = dao.listadoDia();
            dgDiasDisponibles.Columns["dia"].DefaultCellStyle.Format = "dddd, d MMMM yyyy";
        }

        private void btnAgregarDias_Click(object sender, EventArgs e)
        {
            try
            {
                Dia dia  = new Dia();
                dia.dia = dateTimeDia.Value;

                if (dao.agregarDia(dia))
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "DIA GUARDADO ", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgDiasDisponibles.DataSource = dao.listadoDia();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "NO SE PUDO GUARDAR EL DIA", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void btnEliminarDias_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;
                if (txtCodigoDia.Text=="")
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "EL CAMPO NO DEBE ESTAR VACIO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Int32.Parse(txtCodigoDia.Text);
                    ResultadoBD resultado = dao.eliminarDia(codigo);
                    if (resultado.respuesta)
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgDiasDisponibles.DataSource = dao.listadoDia();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtCodigoDia.Text = "0";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void txtDia_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoDia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String diaFiltrado = dateTimeFiltrar.Value.ToString("yyyy/MM/dd");
            dgDiasDisponibles.DataSource = new DiaDao().listadoDiaFiltrar(diaFiltrado);
        }
    }
}
