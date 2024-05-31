namespace ProyectoFinal
{
    public partial class AgregarEquipo : Form
    {
        private ArbolAVL arbolAVL;
        private Form1 form1;

        public AgregarEquipo(Form1 form1, ArbolAVL arbolAVL)
        {
            InitializeComponent();
            this.form1 = form1;
            this.arbolAVL = arbolAVL;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""
                && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != ""
                && textBox9.Text != "" && textBox10.Text != "")
            {
                try
                {
                    Team nuevoEquipo = new Team(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text),
                                  int.Parse(textBox4.Text), int.Parse(textBox5.Text),
                                  int.Parse(textBox6.Text), int.Parse(textBox7.Text),
                                  int.Parse(textBox8.Text), int.Parse(textBox9.Text),
                                  int.Parse(textBox10.Text));
                    arbolAVL.insertar(nuevoEquipo);
                    //form1.listaEquipos.Add(nuevoEquipo);
                    form1.RefreshDataGridViewTeams();
                    this.Close();
                    MessageBox.Show("¡Equipo agregado con éxito!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al ingresar el equipo");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Error: Faltan datos");
            }


        }

        private void AgregarEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}
