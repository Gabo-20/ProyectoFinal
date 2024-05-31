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
    public partial class EliminarJugador : Form
    {
        private Form1 form1;
        public EliminarJugador(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btn_CancelarJugador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EliminarJugador_Click(object sender, EventArgs e)
        {
            string nombreJugador = txt_jugadorEliminar.Text.Trim();

            if (!string.IsNullOrEmpty(nombreJugador))
            {              
                Player jugadorAEliminar = null;
                NodoLE actual = form1.listaS.cabeza;
                while (actual != null)
                {
                    Player jugador = actual.Valor;
                    if (jugador.fullName.Equals(nombreJugador, StringComparison.OrdinalIgnoreCase))
                    {
                        jugadorAEliminar = jugador;
                        break;
                    }
                    actual = actual.Siguiente;
                }

                if (jugadorAEliminar != null)
                {                   
                    form1.listaS.Eliminar(jugadorAEliminar);
                    form1.RefreshDataGridViewPlayers();
                    MessageBox.Show("¡Jugador eliminado correctamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Jugador no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del Jugador a eliminar...");
            }
        }
    }
}
