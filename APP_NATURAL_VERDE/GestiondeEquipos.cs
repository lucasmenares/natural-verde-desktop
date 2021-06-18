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
    public partial class GestiondeEquipos : MetroFramework.Forms.MetroForm

    {
        EquipoDao dao = new EquipoDao();
        public GestiondeEquipos()
        {
            InitializeComponent();
            //Cargar Grid de la gestion de equipo
            dgGestionEquipo.DataSource = dao.listadoEquipo();
        }

        private void btnGuardarGE_Click(object sender, EventArgs e)
        {
            try
            {
                Equipo equipo = new Equipo();
                equipo.nombre = txtNombreGE.Text;

                if (txtNombreGE.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "EL CAMPO NO DEBE ESTAR VACIO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ( dao.AgregarEquipo(equipo))
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm,"EQUIPO GUARDADO " , "Notificación", MessageBoxButtons.OK , MessageBoxIcon.Information );
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "EQUIPO NO GUARDADO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNombreGE.Text = "";
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
                if (txtCodigoEquipo.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "EL CAMPO NO DEBE ESTAR VACIO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Int32.Parse(txtCodigoEquipo.Text);
                    if (dao.eliminarEquipo(codigo))
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, "EQUIPO ELIMINADO ", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, "EL EQUIPO CON EL CODIGO INGRESADO NO EXISTE", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtCodigoEquipo.Text = "0";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void txtFiltrarNombre_KeyUp(object sender, KeyEventArgs e)
        {
            String nombre = txtFiltrarNombre.Text;
            if (txtFiltrarNombre.Text == "")
            {
                dgGestionEquipo.DataSource = new EquipoDao().listadoEquipo();
            }
            else
            {
                dgGestionEquipo.DataSource = new EquipoDao().listadoEquipoFiltrar(nombre);
            }
        }

        private void txtNombreGE_Click(object sender, EventArgs e)
        {

        }
    }
}
