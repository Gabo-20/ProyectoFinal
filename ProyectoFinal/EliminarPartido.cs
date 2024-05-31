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
    public partial class EliminarPartido : Form
    {
        TablaHashGenerica miTabla;
        ListaEnlazadHash LEHash;
        private Form1 form1;
        public EliminarPartido(Form1 form1, TablaHashGenerica miTabla)
        {
            InitializeComponent();
            this.form1 = form1;
            miTabla = new TablaHashGenerica();
            LEHash = new ListaEnlazadHash();
        }

        private void btn_EliminarJugador_Click(object sender, EventArgs e)
        {
            if (txt_partidoEliminar.Text != "")
            {
                
                int clave = int.Parse(txt_partidoEliminar.Text);
                form1.miTabla.Eliminar(clave);
                if (true)
                {

                }
                form1.LEHash.Eliminar(clave);
                MessageBox.Show("¡Partido Eliminado correctamente!");
                this.Close();
                form1.RefreshDataGridViewMatch();
            }
            else
            {
                txt_partidoEliminar.Text = "";
                MessageBox.Show("Ingrese la asistencia del partido a eliminar");
            }
        }

        private void btn_CancelarJugador_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
