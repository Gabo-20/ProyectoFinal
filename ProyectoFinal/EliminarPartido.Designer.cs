namespace ProyectoFinal
{
    partial class EliminarPartido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            btn_EliminarJugador = new Button();
            btn_CancelarJugador = new Button();
            txt_partidoEliminar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 216);
            label3.Name = "label3";
            label3.Size = new Size(499, 36);
            label3.TabIndex = 53;
            label3.Text = "Ingresa la asistencia del partido";
            // 
            // btn_EliminarJugador
            // 
            btn_EliminarJugador.BackColor = Color.FromArgb(255, 128, 128);
            btn_EliminarJugador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EliminarJugador.Location = new Point(49, 348);
            btn_EliminarJugador.Name = "btn_EliminarJugador";
            btn_EliminarJugador.Size = new Size(164, 73);
            btn_EliminarJugador.TabIndex = 52;
            btn_EliminarJugador.Text = "ELIMINAR";
            btn_EliminarJugador.UseVisualStyleBackColor = false;
            btn_EliminarJugador.Click += btn_EliminarJugador_Click;
            // 
            // btn_CancelarJugador
            // 
            btn_CancelarJugador.BackColor = Color.FromArgb(128, 255, 128);
            btn_CancelarJugador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CancelarJugador.Location = new Point(287, 348);
            btn_CancelarJugador.Name = "btn_CancelarJugador";
            btn_CancelarJugador.Size = new Size(164, 73);
            btn_CancelarJugador.TabIndex = 51;
            btn_CancelarJugador.Text = "CANCELAR";
            btn_CancelarJugador.UseVisualStyleBackColor = false;
            btn_CancelarJugador.Click += btn_CancelarJugador_Click;
            // 
            // txt_partidoEliminar
            // 
            txt_partidoEliminar.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_partidoEliminar.Location = new Point(35, 265);
            txt_partidoEliminar.Multiline = true;
            txt_partidoEliminar.Name = "txt_partidoEliminar";
            txt_partidoEliminar.Size = new Size(449, 58);
            txt_partidoEliminar.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 51);
            label2.Name = "label2";
            label2.Size = new Size(284, 36);
            label2.TabIndex = 48;
            label2.Text = "PREMIER LEAGUE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 15);
            label1.Name = "label1";
            label1.Size = new Size(430, 36);
            label1.TabIndex = 47;
            label1.Text = "ELIMINAR PARTIDO DE LA ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.premier_league_0;
            pictureBox1.Location = new Point(149, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // EliminarPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(label3);
            Controls.Add(btn_EliminarJugador);
            Controls.Add(btn_CancelarJugador);
            Controls.Add(txt_partidoEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EliminarPartido";
            Text = "EliminarPartido";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btn_EliminarJugador;
        private Button btn_CancelarJugador;
        private TextBox txt_partidoEliminar;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}