namespace ProyectoFinal
{
    partial class EliminarJugador
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
            txt_jugadorEliminar = new TextBox();
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
            label3.Location = new Point(30, 225);
            label3.Name = "label3";
            label3.Size = new Size(476, 36);
            label3.TabIndex = 46;
            label3.Text = "Ingresa el nombre del jugador";
            // 
            // btn_EliminarJugador
            // 
            btn_EliminarJugador.BackColor = Color.FromArgb(255, 128, 128);
            btn_EliminarJugador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EliminarJugador.Location = new Point(44, 357);
            btn_EliminarJugador.Name = "btn_EliminarJugador";
            btn_EliminarJugador.Size = new Size(164, 73);
            btn_EliminarJugador.TabIndex = 45;
            btn_EliminarJugador.Text = "ELIMINAR";
            btn_EliminarJugador.UseVisualStyleBackColor = false;
            btn_EliminarJugador.Click += btn_EliminarJugador_Click;
            // 
            // btn_CancelarJugador
            // 
            btn_CancelarJugador.BackColor = Color.FromArgb(128, 255, 128);
            btn_CancelarJugador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CancelarJugador.Location = new Point(282, 357);
            btn_CancelarJugador.Name = "btn_CancelarJugador";
            btn_CancelarJugador.Size = new Size(164, 73);
            btn_CancelarJugador.TabIndex = 44;
            btn_CancelarJugador.Text = "CANCELAR";
            btn_CancelarJugador.UseVisualStyleBackColor = false;
            btn_CancelarJugador.Click += btn_CancelarJugador_Click;
            // 
            // txt_jugadorEliminar
            // 
            txt_jugadorEliminar.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_jugadorEliminar.Location = new Point(30, 274);
            txt_jugadorEliminar.Multiline = true;
            txt_jugadorEliminar.Name = "txt_jugadorEliminar";
            txt_jugadorEliminar.Size = new Size(449, 58);
            txt_jugadorEliminar.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 60);
            label2.Name = "label2";
            label2.Size = new Size(284, 36);
            label2.TabIndex = 41;
            label2.Text = "PREMIER LEAGUE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 24);
            label1.Name = "label1";
            label1.Size = new Size(436, 36);
            label1.TabIndex = 40;
            label1.Text = "ELIMINAR JUGADOR DE LA ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.premier_league_0;
            pictureBox1.Location = new Point(144, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // EliminarJugador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 450);
            Controls.Add(label3);
            Controls.Add(btn_EliminarJugador);
            Controls.Add(btn_CancelarJugador);
            Controls.Add(txt_jugadorEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EliminarJugador";
            Text = "EliminarJugador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btn_EliminarJugador;
        private Button btn_CancelarJugador;
        private TextBox txt_jugadorEliminar;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}