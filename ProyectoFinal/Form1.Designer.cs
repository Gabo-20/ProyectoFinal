namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_DatosJugadores = new Button();
            btn_DatosEquipos = new Button();
            btn_DatosPartidos = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txt_vista = new TextBox();
            dataGridViewTeams = new DataGridView();
            btn_InsertarEquipo = new Button();
            btn_EliminarEquipo = new Button();
            txt_buscar = new TextBox();
            btn_buscar = new Button();
            button1 = new Button();
            btn_VerJugadores = new Button();
            btn_VerEquipos = new Button();
            btn_VerPartidos = new Button();
            txt_BuscarJugador = new TextBox();
            btn_BuscarJugador = new Button();
            btn_regresarJugador = new Button();
            btn_TablaJugadores = new Button();
            button2 = new Button();
            btn_AgregarJugador = new Button();
            btn_EliminarJugador = new Button();
            txt_buscarPartidos = new TextBox();
            btn_buscarPartido = new Button();
            btn_verTablaLiga = new Button();
            btn_editarJugador = new Button();
            label3 = new Label();
            btn_editarEquipo = new Button();
            lbl_nameEquipo = new Label();
            btn_AgregarPartido = new Button();
            btn_EliminarPartido = new Button();
            btn_editarPartido = new Button();
            lbl_asistencia = new Label();
            btn_regresarPartido = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeams).BeginInit();
            SuspendLayout();
            // 
            // btn_DatosJugadores
            // 
            btn_DatosJugadores.BackColor = Color.FromArgb(128, 255, 128);
            btn_DatosJugadores.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DatosJugadores.Location = new Point(1675, 111);
            btn_DatosJugadores.Name = "btn_DatosJugadores";
            btn_DatosJugadores.Size = new Size(215, 85);
            btn_DatosJugadores.TabIndex = 0;
            btn_DatosJugadores.Text = "Cargar Datos JUGADORES";
            btn_DatosJugadores.UseVisualStyleBackColor = false;
            btn_DatosJugadores.Click += btn_DatosJugadores_Click;
            // 
            // btn_DatosEquipos
            // 
            btn_DatosEquipos.BackColor = Color.FromArgb(128, 255, 255);
            btn_DatosEquipos.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DatosEquipos.Location = new Point(1675, 202);
            btn_DatosEquipos.Name = "btn_DatosEquipos";
            btn_DatosEquipos.Size = new Size(215, 85);
            btn_DatosEquipos.TabIndex = 1;
            btn_DatosEquipos.Text = "Cargar Datos EQUIPOS";
            btn_DatosEquipos.UseVisualStyleBackColor = false;
            btn_DatosEquipos.Click += btn_DatosEquipos_Click;
            // 
            // btn_DatosPartidos
            // 
            btn_DatosPartidos.BackColor = Color.FromArgb(255, 128, 255);
            btn_DatosPartidos.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DatosPartidos.Location = new Point(1675, 293);
            btn_DatosPartidos.Name = "btn_DatosPartidos";
            btn_DatosPartidos.Size = new Size(215, 85);
            btn_DatosPartidos.TabIndex = 2;
            btn_DatosPartidos.Text = "Cargar Datos PARTIDOS";
            btn_DatosPartidos.UseVisualStyleBackColor = false;
            btn_DatosPartidos.UseWaitCursor = true;
            btn_DatosPartidos.Click += btn_DatosPartidos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(676, 26);
            label1.Name = "label1";
            label1.Size = new Size(773, 48);
            label1.TabIndex = 3;
            label1.Text = "CONSULTAR DATOS Y ESTADISTíCAS ";
           
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.premier_league_0;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-145, -137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(785, 463);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(858, 88);
            label2.Name = "label2";
            label2.Size = new Size(381, 48);
            label2.TabIndex = 5;
            label2.Text = "PREMIER LEAGUE";
            // 
            // txt_vista
            // 
            txt_vista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_vista.Location = new Point(3, 195);
            txt_vista.Multiline = true;
            txt_vista.Name = "txt_vista";
            txt_vista.ScrollBars = ScrollBars.Vertical;
            txt_vista.Size = new Size(820, 480);
            txt_vista.TabIndex = 6;
           
            // 
            // dataGridViewTeams
            // 
            dataGridViewTeams.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeams.Location = new Point(3, 195);
            dataGridViewTeams.Name = "dataGridViewTeams";
            dataGridViewTeams.RowHeadersWidth = 51;
            dataGridViewTeams.Size = new Size(1092, 832);
            dataGridViewTeams.TabIndex = 7;
            // 
            // btn_InsertarEquipo
            // 
            btn_InsertarEquipo.BackColor = Color.FromArgb(255, 255, 192);
            btn_InsertarEquipo.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_InsertarEquipo.Location = new Point(1675, 293);
            btn_InsertarEquipo.Name = "btn_InsertarEquipo";
            btn_InsertarEquipo.Size = new Size(215, 85);
            btn_InsertarEquipo.TabIndex = 8;
            btn_InsertarEquipo.Text = "Insertar Equipo";
            btn_InsertarEquipo.UseVisualStyleBackColor = false;
            btn_InsertarEquipo.Visible = false;
            btn_InsertarEquipo.Click += btn_InsertarEquipo_Click;
            // 
            // btn_EliminarEquipo
            // 
            btn_EliminarEquipo.BackColor = Color.FromArgb(255, 192, 192);
            btn_EliminarEquipo.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EliminarEquipo.Location = new Point(1675, 384);
            btn_EliminarEquipo.Name = "btn_EliminarEquipo";
            btn_EliminarEquipo.Size = new Size(215, 85);
            btn_EliminarEquipo.TabIndex = 9;
            btn_EliminarEquipo.Text = "Eliminar Equipo";
            btn_EliminarEquipo.UseVisualStyleBackColor = false;
            btn_EliminarEquipo.Visible = false;
            btn_EliminarEquipo.Click += btn_EliminarEquipo_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_buscar.Location = new Point(1121, 417);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(449, 58);
            txt_buscar.TabIndex = 10;
            txt_buscar.Visible = false;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(128, 128, 255);
            btn_buscar.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(1139, 497);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(215, 85);
            btn_buscar.TabIndex = 11;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Visible = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1675, 202);
            button1.Name = "button1";
            button1.Size = new Size(215, 85);
            button1.TabIndex = 13;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // btn_VerJugadores
            // 
            btn_VerJugadores.BackColor = Color.FromArgb(128, 255, 128);
            btn_VerJugadores.Enabled = false;
            btn_VerJugadores.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerJugadores.Location = new Point(1663, 750);
            btn_VerJugadores.Name = "btn_VerJugadores";
            btn_VerJugadores.Size = new Size(215, 85);
            btn_VerJugadores.TabIndex = 14;
            btn_VerJugadores.Text = "Ver Datos JUGADORES";
            btn_VerJugadores.UseVisualStyleBackColor = false;
            btn_VerJugadores.Click += btn_VerJugadores_Click;
            // 
            // btn_VerEquipos
            // 
            btn_VerEquipos.BackColor = Color.FromArgb(128, 255, 255);
            btn_VerEquipos.Enabled = false;
            btn_VerEquipos.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerEquipos.Location = new Point(1663, 851);
            btn_VerEquipos.Name = "btn_VerEquipos";
            btn_VerEquipos.Size = new Size(215, 85);
            btn_VerEquipos.TabIndex = 15;
            btn_VerEquipos.Text = "Ver Datos EQUIPOS";
            btn_VerEquipos.UseVisualStyleBackColor = false;
            btn_VerEquipos.Click += btn_VerEquipos_Click;
            // 
            // btn_VerPartidos
            // 
            btn_VerPartidos.BackColor = Color.FromArgb(255, 128, 255);
            btn_VerPartidos.Enabled = false;
            btn_VerPartidos.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerPartidos.Location = new Point(1663, 942);
            btn_VerPartidos.Name = "btn_VerPartidos";
            btn_VerPartidos.Size = new Size(215, 85);
            btn_VerPartidos.TabIndex = 16;
            btn_VerPartidos.Text = "Ver Datos PARTIDOS";
            btn_VerPartidos.UseVisualStyleBackColor = false;
            btn_VerPartidos.Click += btn_VerPartidos_Click;
            // 
            // txt_BuscarJugador
            // 
            txt_BuscarJugador.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_BuscarJugador.Location = new Point(1121, 421);
            txt_BuscarJugador.Multiline = true;
            txt_BuscarJugador.Name = "txt_BuscarJugador";
            txt_BuscarJugador.Size = new Size(449, 58);
            txt_BuscarJugador.TabIndex = 17;
            txt_BuscarJugador.Visible = false;
            // 
            // btn_BuscarJugador
            // 
            btn_BuscarJugador.BackColor = Color.FromArgb(255, 192, 128);
            btn_BuscarJugador.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BuscarJugador.Location = new Point(1139, 497);
            btn_BuscarJugador.Name = "btn_BuscarJugador";
            btn_BuscarJugador.Size = new Size(215, 85);
            btn_BuscarJugador.TabIndex = 18;
            btn_BuscarJugador.Text = "BUSCAR";
            btn_BuscarJugador.UseVisualStyleBackColor = false;
            btn_BuscarJugador.Visible = false;
            btn_BuscarJugador.Click += btn_BuscarJugador_Click;
            // 
            // btn_regresarJugador
            // 
            btn_regresarJugador.BackColor = Color.FromArgb(255, 128, 255);
            btn_regresarJugador.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresarJugador.Location = new Point(1675, 202);
            btn_regresarJugador.Name = "btn_regresarJugador";
            btn_regresarJugador.Size = new Size(215, 85);
            btn_regresarJugador.TabIndex = 19;
            btn_regresarJugador.Text = "Regresar";
            btn_regresarJugador.UseVisualStyleBackColor = false;
            btn_regresarJugador.Visible = false;
            btn_regresarJugador.Click += btn_regresarJugador_Click;
            // 
            // btn_TablaJugadores
            // 
            btn_TablaJugadores.BackColor = Color.FromArgb(255, 192, 192);
            btn_TablaJugadores.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TablaJugadores.Location = new Point(1675, 293);
            btn_TablaJugadores.Name = "btn_TablaJugadores";
            btn_TablaJugadores.Size = new Size(215, 85);
            btn_TablaJugadores.TabIndex = 20;
            btn_TablaJugadores.Text = "Ver Tabla Jugadores";
            btn_TablaJugadores.UseVisualStyleBackColor = false;
            btn_TablaJugadores.Visible = false;
            btn_TablaJugadores.Click += btn_TablaJugadores_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1675, 111);
            button2.Name = "button2";
            button2.Size = new Size(215, 85);
            button2.TabIndex = 21;
            button2.Text = "Ver Tabla Equipos";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // btn_AgregarJugador
            // 
            btn_AgregarJugador.BackColor = Color.FromArgb(128, 255, 128);
            btn_AgregarJugador.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AgregarJugador.Location = new Point(1675, 475);
            btn_AgregarJugador.Name = "btn_AgregarJugador";
            btn_AgregarJugador.Size = new Size(215, 85);
            btn_AgregarJugador.TabIndex = 22;
            btn_AgregarJugador.Text = "Agregar Jugador";
            btn_AgregarJugador.UseVisualStyleBackColor = false;
            btn_AgregarJugador.Visible = false;
            btn_AgregarJugador.Click += button3_Click;
            // 
            // btn_EliminarJugador
            // 
            btn_EliminarJugador.BackColor = Color.FromArgb(255, 128, 128);
            btn_EliminarJugador.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EliminarJugador.Location = new Point(1675, 566);
            btn_EliminarJugador.Name = "btn_EliminarJugador";
            btn_EliminarJugador.Size = new Size(215, 85);
            btn_EliminarJugador.TabIndex = 23;
            btn_EliminarJugador.Text = "Eliminar Jugador";
            btn_EliminarJugador.UseVisualStyleBackColor = false;
            btn_EliminarJugador.Visible = false;
            btn_EliminarJugador.Click += btn_EliminarJugador_Click;
            // 
            // txt_buscarPartidos
            // 
            txt_buscarPartidos.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_buscarPartidos.Location = new Point(1121, 605);
            txt_buscarPartidos.Multiline = true;
            txt_buscarPartidos.Name = "txt_buscarPartidos";
            txt_buscarPartidos.Size = new Size(449, 58);
            txt_buscarPartidos.TabIndex = 24;
            txt_buscarPartidos.Visible = false;
            // 
            // btn_buscarPartido
            // 
            btn_buscarPartido.BackColor = Color.FromArgb(255, 255, 128);
            btn_buscarPartido.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscarPartido.Location = new Point(1139, 688);
            btn_buscarPartido.Name = "btn_buscarPartido";
            btn_buscarPartido.Size = new Size(215, 85);
            btn_buscarPartido.TabIndex = 25;
            btn_buscarPartido.Text = "BUSCAR";
            btn_buscarPartido.UseVisualStyleBackColor = false;
            btn_buscarPartido.Visible = false;
            btn_buscarPartido.Click += btn_buscarPartido_Click;
            // 
            // btn_verTablaLiga
            // 
            btn_verTablaLiga.BackColor = Color.FromArgb(255, 192, 192);
            btn_verTablaLiga.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_verTablaLiga.Location = new Point(1675, 293);
            btn_verTablaLiga.Name = "btn_verTablaLiga";
            btn_verTablaLiga.Size = new Size(215, 85);
            btn_verTablaLiga.TabIndex = 26;
            btn_verTablaLiga.Text = "Ver Tabla de la Liga";
            btn_verTablaLiga.UseVisualStyleBackColor = false;
            btn_verTablaLiga.Visible = false;
            btn_verTablaLiga.Click += btn_verTablaLiga_Click;
            // 
            // btn_editarJugador
            // 
            btn_editarJugador.BackColor = Color.FromArgb(0, 192, 192);
            btn_editarJugador.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editarJugador.Location = new Point(1373, 497);
            btn_editarJugador.Name = "btn_editarJugador";
            btn_editarJugador.Size = new Size(215, 85);
            btn_editarJugador.TabIndex = 27;
            btn_editarJugador.Text = "Editar Jugador";
            btn_editarJugador.UseVisualStyleBackColor = false;
            btn_editarJugador.Visible = false;
            btn_editarJugador.Click += btn_editarJugador_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1139, 370);
            label3.Name = "label3";
            label3.Size = new Size(408, 48);
            label3.TabIndex = 28;
            label3.Text = "NOMBRE JUGADOR";
            label3.Visible = false;
            // 
            // btn_editarEquipo
            // 
            btn_editarEquipo.BackColor = Color.FromArgb(255, 255, 128);
            btn_editarEquipo.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editarEquipo.Location = new Point(1373, 497);
            btn_editarEquipo.Name = "btn_editarEquipo";
            btn_editarEquipo.Size = new Size(215, 85);
            btn_editarEquipo.TabIndex = 29;
            btn_editarEquipo.Text = "EDITAR";
            btn_editarEquipo.UseVisualStyleBackColor = false;
            btn_editarEquipo.Visible = false;
            btn_editarEquipo.Click += btn_editarEquipo_Click;
            // 
            // lbl_nameEquipo
            // 
            lbl_nameEquipo.AutoSize = true;
            lbl_nameEquipo.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nameEquipo.Location = new Point(1139, 370);
            lbl_nameEquipo.Name = "lbl_nameEquipo";
            lbl_nameEquipo.Size = new Size(373, 48);
            lbl_nameEquipo.TabIndex = 30;
            lbl_nameEquipo.Text = "NOMBRE EQUIPO";
            lbl_nameEquipo.Visible = false;
            // 
            // btn_AgregarPartido
            // 
            btn_AgregarPartido.BackColor = Color.FromArgb(128, 255, 128);
            btn_AgregarPartido.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AgregarPartido.Location = new Point(1675, 202);
            btn_AgregarPartido.Name = "btn_AgregarPartido";
            btn_AgregarPartido.Size = new Size(215, 85);
            btn_AgregarPartido.TabIndex = 31;
            btn_AgregarPartido.Text = "Agregar Partido";
            btn_AgregarPartido.UseVisualStyleBackColor = false;
            btn_AgregarPartido.Visible = false;
            btn_AgregarPartido.Click += btn_AgregarPartido_Click;
            // 
            // btn_EliminarPartido
            // 
            btn_EliminarPartido.BackColor = Color.FromArgb(255, 128, 128);
            btn_EliminarPartido.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EliminarPartido.Location = new Point(1675, 111);
            btn_EliminarPartido.Name = "btn_EliminarPartido";
            btn_EliminarPartido.Size = new Size(215, 85);
            btn_EliminarPartido.TabIndex = 32;
            btn_EliminarPartido.Text = "Eliminar Partido";
            btn_EliminarPartido.UseVisualStyleBackColor = false;
            btn_EliminarPartido.Visible = false;
            btn_EliminarPartido.Click += btn_EliminarPartido_Click;
            // 
            // btn_editarPartido
            // 
            btn_editarPartido.BackColor = Color.FromArgb(255, 192, 128);
            btn_editarPartido.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editarPartido.Location = new Point(1360, 688);
            btn_editarPartido.Name = "btn_editarPartido";
            btn_editarPartido.Size = new Size(215, 85);
            btn_editarPartido.TabIndex = 33;
            btn_editarPartido.Text = "EDITAR";
            btn_editarPartido.UseVisualStyleBackColor = false;
            btn_editarPartido.Visible = false;
            btn_editarPartido.Click += btn_editarPartido_Click;
            // 
            // lbl_asistencia
            // 
            lbl_asistencia.AutoSize = true;
            lbl_asistencia.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_asistencia.Location = new Point(1121, 544);
            lbl_asistencia.Name = "lbl_asistencia";
            lbl_asistencia.Size = new Size(559, 48);
            lbl_asistencia.TabIndex = 34;
            lbl_asistencia.Text = "ASISTENCIA DEL PARTIDO";
            lbl_asistencia.Visible = false;
            // 
            // btn_regresarPartido
            // 
            btn_regresarPartido.BackColor = Color.FromArgb(192, 192, 0);
            btn_regresarPartido.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresarPartido.Location = new Point(1675, 384);
            btn_regresarPartido.Name = "btn_regresarPartido";
            btn_regresarPartido.Size = new Size(215, 85);
            btn_regresarPartido.TabIndex = 35;
            btn_regresarPartido.Text = "REGRESAR";
            btn_regresarPartido.UseVisualStyleBackColor = false;
            btn_regresarPartido.Visible = false;
            btn_regresarPartido.Click += btn_regresarPartido_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1055);
            Controls.Add(btn_regresarPartido);
            Controls.Add(lbl_asistencia);
            Controls.Add(btn_editarPartido);
            Controls.Add(btn_EliminarPartido);
            Controls.Add(btn_AgregarPartido);
            Controls.Add(lbl_nameEquipo);
            Controls.Add(btn_editarEquipo);
            Controls.Add(btn_editarJugador);
            Controls.Add(btn_verTablaLiga);
            Controls.Add(btn_buscarPartido);
            Controls.Add(txt_buscarPartidos);
            Controls.Add(btn_EliminarJugador);
            Controls.Add(btn_AgregarJugador);
            Controls.Add(button2);
            Controls.Add(btn_TablaJugadores);
            Controls.Add(btn_regresarJugador);
            Controls.Add(btn_BuscarJugador);
            Controls.Add(txt_BuscarJugador);
            Controls.Add(btn_VerPartidos);
            Controls.Add(btn_VerEquipos);
            Controls.Add(btn_VerJugadores);
            Controls.Add(button1);
            Controls.Add(btn_buscar);
            Controls.Add(txt_buscar);
            Controls.Add(btn_InsertarEquipo);
            Controls.Add(dataGridViewTeams);
            Controls.Add(txt_vista);
            Controls.Add(label2);
            Controls.Add(btn_DatosEquipos);
            Controls.Add(label1);
            Controls.Add(btn_DatosPartidos);
            Controls.Add(btn_DatosJugadores);
            Controls.Add(pictureBox1);
            Controls.Add(btn_EliminarEquipo);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Estadísticas Premier League";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DatosJugadores;
        private Button btn_DatosEquipos;
        private Button btn_DatosPartidos;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txt_vista;
        private DataGridView dataGridViewTeams;
        private Button btn_InsertarEquipo;
        private Button btn_EliminarEquipo;
        private TextBox txt_buscar;
        private Button btn_buscar;
        private Button button1;
        private Button btn_VerJugadores;
        private Button btn_VerEquipos;
        private Button btn_VerPartidos;
        private TextBox txt_BuscarJugador;
        private Button btn_BuscarJugador;
        private Button btn_regresarJugador;
        private Button btn_TablaJugadores;
        private Button button2;
        private Button btn_AgregarJugador;
        private Button btn_EliminarJugador;
        private TextBox txt_buscarPartidos;
        private Button btn_buscarPartido;
        private Button btn_verTablaLiga;
        private Button btn_editarJugador;
        private Label label3;
        private Button btn_editarEquipo;
        private Label lbl_nameEquipo;
        private Button btn_AgregarPartido;
        private Button btn_EliminarPartido;
        private Button btn_editarPartido;
        private Label lbl_asistencia;
        private Button btn_regresarPartido;
    }
}
