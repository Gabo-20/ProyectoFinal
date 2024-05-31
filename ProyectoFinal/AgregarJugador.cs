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
    public partial class AgregarJugador : Form
    {
        
        private Form1 form1;
        public AgregarJugador(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btn_InsertarPlayer_Click(object sender, EventArgs e)
        {
            if (txt_NamePlayer.Text !="" && txt_AgePlayer.Text != "" && txt_pos.Text!="" && txt_club.Text != ""
                && txt_nacional.Text != "" && txt_Goles.Text != "" && txt_Asisten.Text != "" &&
                txt_TarjetasAmarillas.Text != "" && txt_TarjetasRojas.Text != "")
            {
                
                Player jugador = new Player(txt_NamePlayer.Text, int.Parse(txt_AgePlayer.Text), txt_pos.Text,
                txt_club.Text, txt_nacional.Text, int.Parse(txt_Goles.Text), int.Parse(txt_Asisten.Text),
                int.Parse(txt_TarjetasAmarillas.Text), int.Parse(txt_TarjetasRojas.Text));
                if (jugador != null)
                {
                    form1.listaS.AgregarAlInicio(jugador);                   
                    form1.RefreshDataGridViewPlayers();
                    MessageBox.Show("¡Jugador Agregado con éxito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al añadir jugador");
                }
                
            }
            else
            {
                MessageBox.Show("Error: Faltan datos");
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
