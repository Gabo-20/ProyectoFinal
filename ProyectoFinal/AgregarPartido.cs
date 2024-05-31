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
    public partial class AgregarPartido : Form
    {
        private Form1 form1;
        private TablaHashGenerica miTabla;
        private ListaEnlazadHash ListaEnlazadHash;
        public AgregarPartido(Form1 form1, TablaHashGenerica miTabla)
        {
            InitializeComponent();
            this.form1 = form1;
            this.miTabla = miTabla;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_asistencia.Text != "" && txt_estado.Text !="" && txt_fecha.Text != "" && txt_golLocal.Text != ""
                && txt_golVisitante.Text != "" && txt_Local.Text !="" && txt_refeere.Text != "" &&
                txt_visitante.Text != "")
            {
                Match NuevoPartido = new Match(txt_fecha.Text, txt_estado.Text, txt_visitante.Text,
                                txt_Local.Text, int.Parse(txt_golVisitante.Text), int.Parse(txt_golLocal.Text),
                                txt_refeere.Text, int.Parse(txt_asistencia.Text));
                miTabla.Insertar(NuevoPartido, int.Parse(txt_asistencia.Text));
                MessageBox.Show($"Partido agregado con exito en la posición: " +
                    $"{miTabla.DispersionMod(int.Parse(txt_asistencia.Text))}");
                form1.RefreshDataGridViewMatch();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Faltan datos...");
            }
            
        }
    }
}
