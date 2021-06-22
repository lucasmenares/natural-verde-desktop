using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_NATURAL_VERDE.Clases;
using APP_NATURAL_VERDE.Dao;

namespace APP_NATURAL_VERDE
{
    public partial class Servicios : MetroFramework.Forms.MetroForm
    {
        ServicioDao dao = new ServicioDao();

        public Servicios()
        {
            InitializeComponent();
            //Cargar grilla del Servicio
            dgServicios.DataSource = dao.listadoServicio();
        }

        private void btnGuardarGE_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio servicio = new Servicio();
                servicio.nombre = txtNombreServicio.Text;

                if (txtNombreServicio.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "EL CAMPO NO DEBE ESTAR VACIO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dao.agregarServicio(servicio))
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "SERVICIO GUARDADO ", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgServicios.DataSource = dao.listadoServicio();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "SERVICIO NO GUARDADO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNombreServicio.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void btnEliminarGE_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;
                if (txtCodigoServicio.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "EL CAMPO NO DEBE ESTAR VACIO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Int32.Parse(txtCodigoServicio.Text);
                    ResultadoBD resultado = dao.eliminarServicio(codigo);
                    if (resultado.respuesta)
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgServicios.DataSource = dao.listadoServicio();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtCodigoServicio.Text = "0";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void txtFiltrarServicio_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFiltrarServicio_KeyUp(object sender, KeyEventArgs e)
        {
            String nombre = txtFiltrarServicio.Text;
            if (txtFiltrarServicio.Text == "")
            {
                dgServicios.DataSource = new ServicioDao().listadoServicio();
            }
            else
            {
                dgServicios.DataSource = new ServicioDao().listadoServicioFiltrar(nombre);
            }
        }
    }
}
