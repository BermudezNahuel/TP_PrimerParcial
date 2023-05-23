namespace PrimerParcialUI
{
    partial class AltaDocenteUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaDocenteUI));
            btn_salir = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_dni = new Label();
            lbl_telefono = new Label();
            Lbl_agregar = new Button();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 34);
            btn_salir.TabIndex = 27;
            btn_salir.Text = "Volver";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += Btn_salir_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(598, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(598, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(814, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 30;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(814, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 31;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(598, 66);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 32;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(814, 66);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(78, 25);
            lbl_apellido.TabIndex = 33;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(598, 166);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(39, 25);
            lbl_dni.TabIndex = 34;
            lbl_dni.Text = "Dni";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(814, 166);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(79, 25);
            lbl_telefono.TabIndex = 35;
            lbl_telefono.Text = "Telefono";
            // 
            // Lbl_agregar
            // 
            Lbl_agregar.Location = new Point(725, 441);
            Lbl_agregar.Name = "Lbl_agregar";
            Lbl_agregar.Size = new Size(112, 34);
            Lbl_agregar.TabIndex = 36;
            Lbl_agregar.Text = "Agregar";
            Lbl_agregar.UseVisualStyleBackColor = true;
            Lbl_agregar.Click += Lbl_agregar_Click;
            // 
            // AltaDocenteUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1059, 621);
            Controls.Add(Lbl_agregar);
            Controls.Add(lbl_telefono);
            Controls.Add(lbl_dni);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_salir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AltaDocenteUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaDocenteUI";
            Load += AltaDocenteUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salir;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_dni;
        private Label lbl_telefono;
        private Button Lbl_agregar;
    }
}