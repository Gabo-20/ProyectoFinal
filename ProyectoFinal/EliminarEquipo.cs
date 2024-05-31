namespace ProyectoFinal
{
    public partial class EliminarEquipo : Form
    {
        private ArbolAVL arbolAVL;
        private Form1 form1;
        public EliminarEquipo(Form1 form1, ArbolAVL arbolAVL)
        {
            InitializeComponent();
            this.form1 = form1;
            this.arbolAVL = arbolAVL;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_EliminarEquipo_Click(object sender, EventArgs e)
        {
            if (txt_EquipoEliminar.Text != "")
            {
                try
                {
                    Team equipo = new Team(txt_EquipoEliminar.Text, "", 0, 0, 0, 0, 0, 0, 0, 0);
                    form1.arbolAVL.eliminar(equipo);
                    form1.RefreshDataGridViewTeams();
                    MessageBox.Show("¡Equipo eliminado!");
                    this.Close();
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("No se encuentra el equipo");
                    txt_EquipoEliminar.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Ingrese el equipo a eliminar");
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
