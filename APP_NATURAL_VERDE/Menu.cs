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
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AgregarEquipo(object formularioEquipo)
        {

            this.panelContenedor.Controls.Clear();

            Form f = formularioEquipo as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(f);
            this.panelContenedor.Tag = f;
            f.Show();
        }

        private void btnGestionEquipo_Click(object sender, EventArgs e)
        {

            AgregarEquipo(new GestiondeEquipos());

        }

        private void agregarDia(object formularioDia)
        {

            this.panelContenedor.Controls.Clear();

            Form fd = formularioDia as Form;
            fd.TopLevel = false;
            fd.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(fd);
            this.panelContenedor.Tag = fd;
            fd.Show();
        }

        private void verInsumos(object formularioInsumos)
        {

            this.panelContenedor.Controls.Clear();

            Form fd = formularioInsumos as Form;
            fd.TopLevel = false;
            fd.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(fd);
            this.panelContenedor.Tag = fd;
            fd.Show();
        }

        private void gestionHorario(object formularioHorario)
        {

            this.panelContenedor.Controls.Clear();

            Form fd = formularioHorario as Form;
            fd.TopLevel = false;
            fd.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(fd);
            this.panelContenedor.Tag = fd;
            fd.Show();
        }

        private void btnGestionDias_Click(object sender, EventArgs e)
        {
            agregarDia(new GestionDias());
        }

        private void agregarServicio(object formularioServicio)
        {

            this.panelContenedor.Controls.Clear();

            Form fs = formularioServicio as Form;
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(fs);
            this.panelContenedor.Tag = fs;
            fs.Show();
        }

        private void insumosAProyectos(object formularioInsumosAProyectos)
        {

            this.panelContenedor.Controls.Clear();

            Form fs = formularioInsumosAProyectos as Form;
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(fs);
            this.panelContenedor.Tag = fs;
            fs.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            agregarServicio(new Servicios());
        }

        private void btnGestionHorario_Click(object sender, EventArgs e)
        {
            gestionHorario(new GestionHorario());
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            verInsumos(new VerInsumos());
        }

        private void InsumosAProyectos_Click(object sender, EventArgs e)
        {
            insumosAProyectos(new InsumosAProyectos());
        }
    }
}
