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
    public partial class EditarJugador : Form
    {
        private Form1 form1;
        public Player jugadorEditado;
        public EditarJugador(Form1 form1, Player jugador)
        {
            InitializeComponent();
            this.form1 = form1;
            txt_NamePlayer.Text = jugador.fullName;
            txt_NamePlayer.Enabled = false;
            txt_AgePlayer.Text = jugador.edad.ToString();
            txt_Asisten.Text = jugador.asistencias.ToString();
            txt_club.Text = jugador.club;
            txt_Goles.Text = jugador.goles.ToString();
            txt_nacional.Text = jugador.nacionalidad;
            txt_pos.Text = jugador.posicion;
            txt_TarjetasAmarillas.Text = jugador.TarjetaAmarilla.ToString();
            txt_TarjetasRojas.Text = jugador.TarjetaRoja.ToString();

            jugadorEditado = jugador;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EditarPlayer_Click(object sender, EventArgs e)
        {
            if (jugadorEditado != null)
            {
                jugadorEditado.edad = int.Parse(txt_AgePlayer.Text);
                jugadorEditado.asistencias = int.Parse(txt_Asisten.Text);
                jugadorEditado.club = txt_club.Text;
                jugadorEditado.goles = int.Parse(txt_Goles.Text);
                jugadorEditado.nacionalidad = txt_nacional.Text;
                jugadorEditado.posicion = txt_pos.Text;
                jugadorEditado.TarjetaAmarilla = int.Parse(txt_TarjetasAmarillas.Text);
                jugadorEditado.TarjetaRoja = int.Parse(txt_TarjetasRojas.Text);
                MessageBox.Show("Jugador editado con éxito");
                
                form1.RefreshDataGridViewPlayers();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al intentar editar jugador");
                this.Close ();
            }
        }
    }
}
