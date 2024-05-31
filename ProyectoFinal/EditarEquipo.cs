using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class EditarEquipo : Form
    {
        private Form1 form1;
        public Team EquipoEditado;
        public EditarEquipo(Form1 form1, Team equipo)
        {
            InitializeComponent();
            this.form1 = form1;
            txt_nombre.Text = equipo.nombre;
            txt_nombre.Enabled = false;
            txt_DifGoles.Text = equipo.diferenciaGoles.ToString();
            txt_golesAFavor.Text = equipo.golesAFavor.ToString();
            txt_GolesEnContra.Text = equipo.golesEnContra.ToString();
            txt_pais.Text = equipo.pais;
            txt_partidosEmpates.Text = equipo.empates.ToString();
            txt_partidosganados.Text = equipo.ganados.ToString();
            txt_partidosJugados.Text = equipo.jugados.ToString();
            txt_partidosPerdidos.Text = equipo.perdidos.ToString();
            txt_posicion.Text = equipo.posicion.ToString();

            EquipoEditado = equipo;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EquipoEditado.diferenciaGoles = int.Parse(txt_DifGoles.Text);
            EquipoEditado.golesAFavor = int.Parse(txt_golesAFavor.Text);
            EquipoEditado.golesEnContra = int.Parse(txt_GolesEnContra.Text);
            EquipoEditado.pais = txt_pais.Text;
            EquipoEditado.empates = int.Parse(txt_partidosEmpates.Text);
            EquipoEditado.ganados = int.Parse(txt_partidosganados.Text);
            EquipoEditado.jugados = int.Parse(txt_partidosJugados.Text);
            EquipoEditado.perdidos = int.Parse(txt_partidosPerdidos.Text);
            EquipoEditado.posicion = int.Parse(txt_posicion.Text);

            MessageBox.Show("Se actualizó los datos del equipo!");
            form1.RefreshDataGridViewTeams();
            this.Close();
        }
    }
}
