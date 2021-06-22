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
    public partial class GestionHorario : MetroFramework.Forms.MetroForm
    {
        HorarioDao horarioDao = new HorarioDao();
        public GestionHorario()
        {
            InitializeComponent();
            
            dgHorario.DataSource = horarioDao.listarHorario();
            dgHorario.Columns["dia"].DefaultCellStyle.Format = "dddd, d MMMM yyyy";
            dgHorario.AutoGenerateColumns = false;
            dgHorario.Columns["codigo_dia"].Visible = false;
            dgHorario.Columns["codigo_equipo"].Visible = false;
            dgHorario.Columns["codigo_proyecto"].Visible = false;

            // (dgHorario.DataSource as DataTable).DefaultView.RowFilter = string.Format("dia = '{0}'", "test");

            // Dia combobox
            DiaDao dao = new DiaDao();
            List<Dia> dias = new List<Dia>();
            dias = dao.listadoDia();
            cbxDia.DataSource = dias;
            cbxDia.ValueMember = "codigo";
            cbxDia.DisplayMember = "dia";
            cbxDia.FormatString = "dddd, d MMMM yyyy";


            // Equipo combobox
            EquipoDao equipoDao = new EquipoDao();
            List<Equipo> equipos = new List<Equipo>();
            equipos = equipoDao.listadoEquipo();
            cbxEquipo.DataSource = equipos;
            cbxEquipo.ValueMember = "codigo";
            cbxEquipo.DisplayMember = "nombre";

            List<FiltroHorario> listaFiltroHorario = new List<FiltroHorario>();
            FiltroHorario todos = new FiltroHorario()
            {
                valor = 0,
                texto = "Todos"
            };
            FiltroHorario disponibles = new FiltroHorario()
            {
                valor = 1,
                texto = "Disponibles"
            };
            FiltroHorario noDisponibles = new FiltroHorario()
            {
                valor = 2,
                texto = "No Disponibles"
            };
            listaFiltroHorario.Add(todos);
            listaFiltroHorario.Add(disponibles);
            listaFiltroHorario.Add(noDisponibles);
            cbDisponible.DataSource = listaFiltroHorario;
            cbDisponible.ValueMember = "valor";
            cbDisponible.DisplayMember = "texto";
        }

        private void GestionHorario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarGH_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.hora = txtHora.Text;
            horario.codigo_dia = Convert.ToInt32(cbxDia.SelectedValue);
            horario.codigo_equipo = Convert.ToInt32(cbxEquipo.SelectedValue);

            if (horarioDao.agregarHorario(horario)){
                MetroFramework.MetroMessageBox.Show(ActiveForm, "HORARIO AGREGADO CORRECTAMENTE", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(ActiveForm, "HUBO UN ERROR AL AGREGAR, INTENTA NUEVAMENTE", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtHora.Text = "";
            cbxDia.SelectedIndex = 0;
            cbxEquipo.SelectedIndex = 0;
            dgHorario.DataSource = horarioDao.listarHorario();
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;
                if (txtCodigoHorario.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(ActiveForm, "EL CAMPO NO DEBE ESTAR VACIO", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Int32.Parse(txtCodigoHorario.Text);
                    ResultadoBD resultado = horarioDao.eliminarHorario(codigo);
                    if (resultado.respuesta)
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgHorario.DataSource = horarioDao.listarHorario();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(ActiveForm, resultado.mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtCodigoHorario.Text = "0";
                dgHorario.DataSource = horarioDao.listarHorario();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            dgHorario.DataSource = horarioDao.listarHorario();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String dia = dateTimeFiltro.Value.ToString("yyyy/MM/dd");
            String hora = txtFiltroHora.Text;
            int disponible = Convert.ToInt32(cbDisponible.SelectedValue);
            dgHorario.DataSource = horarioDao.filtrarHorario(dia, hora, disponible);
        }
    }
}
