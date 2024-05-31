namespace ProyectoFinal
{
    partial class EliminarEquipo
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
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txt_EquipoEliminar = new TextBox();
            btn_EliminarEquipo = new Button();
            btn_Cancelar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 55);
            label2.Name = "label2";
            label2.Size = new Size(284, 36);
            label2.TabIndex = 7;
            label2.Text = "PREMIER LEAGUE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(409, 36);
            label1.TabIndex = 6;
            label1.Text = "ELIMINAR EQUIPO DE LA ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.premier_league_0;
            pictureBox1.Location = new Point(126, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txt_EquipoEliminar
            // 
            txt_EquipoEliminar.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_EquipoEliminar.Location = new Point(12, 269);
            txt_EquipoEliminar.Multiline = true;
            txt_EquipoEliminar.Name = "txt_EquipoEliminar";
            txt_EquipoEliminar.Size = new Size(449, 58);
            txt_EquipoEliminar.TabIndex = 11;
            // 
            // btn_EliminarEquipo
            // 
            btn_EliminarEquipo.BackColor = Color.FromArgb(255, 128, 128);
            btn_EliminarEquipo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EliminarEquipo.Location = new Point(26, 352);
            btn_EliminarEquipo.Name = "btn_EliminarEquipo";
            btn_EliminarEquipo.Size = new Size(164, 73);
            btn_EliminarEquipo.TabIndex = 38;
            btn_EliminarEquipo.Text = "ELIMINAR";
            btn_EliminarEquipo.UseVisualStyleBackColor = false;
            btn_EliminarEquipo.Click += btn_EliminarEquipo_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(128, 255, 128);
            btn_Cancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(264, 352);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(164, 73);
            btn_Cancelar.TabIndex = 37;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(472, 36);
            label3.TabIndex = 39;
            label3.Text = "Ingresa el nombre del equipo:";
            label3.Click += label3_Click;
            // 
            // EliminarEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(label3);
            Controls.Add(btn_EliminarEquipo);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_EquipoEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EliminarEquipo";
            Text = "EliminarEquipo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txt_EquipoEliminar;
        private Button btn_EliminarEquipo;
        private Button btn_Cancelar;
        private Label label3;
    }
}