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
    public partial class EditarPartido : Form
    {
        private Form1 Form1;
        private TablaHashGenerica miTabla;
        private ListaEnlazadHash LEHash;
        public Match equipoEditado;
        public EditarPartido(Form1 form1, TablaHashGenerica miTabla, int clave)
        {
            InitializeComponent();
            txt_asistencia.Enabled = false;
            this.Form1 = form1;
            this.miTabla = miTabla;
            //equipoEditado = null;
            LEHash = (ListaEnlazadHash)miTabla.Consultar(clave);
            if (LEHash != null)
            {
                Match partidoBuscado = new Match("", "", "", "", 0, 0, "", clave);
                Object encontrado = LEHash.BuscarNodo(partidoBuscado);

                if (encontrado != null)
                {
                    Match partido = encontrado as Match;

                    if (partido != null)
                    {
                        txt_fecha.Text = partido.fecha;
                        txt_estado.Text = partido.estado;
                        txt_visitante.Text = partido.visitante;
                        txt_Local.Text = partido.local;
                        txt_golVisitante.Text = partido.golVisitante.ToString();
                        txt_golLocal.Text = partido.golLocal.ToString();
                        txt_refeere.Text = partido.referee;
                        txt_asistencia.Text = partido.asistencia.ToString();
                        txt_asistencia.Enabled = false;

                        equipoEditado = partido;
                    }
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            equipoEditado.fecha = txt_fecha.Text;
            equipoEditado.estado = txt_estado.Text;
            equipoEditado.visitante = txt_visitante.Text;
            equipoEditado.local = txt_Local.Text;
            equipoEditado.golVisitante = int.Parse(txt_golVisitante.Text);
            equipoEditado.golLocal = int.Parse(txt_golLocal.Text);
            equipoEditado.referee = txt_refeere.Text;
            equipoEditado.asistencia = int.Parse(txt_asistencia.Text);
            Form1.RefreshDataGridViewMatch();
            MessageBox.Show("Partido actualizado correctamente");
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarPartido_Load(object sender, EventArgs e)
        {

        }
    }
}
