namespace PrimerParcialUI
{
    partial class FormIngresoAlumno
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
            txt_anio = new TextBox();
            txt_telefono = new TextBox();
            txt_dni = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            lbl_dni = new Label();
            lbl_apellido = new Label();
            lbl_telefono = new Label();
            lbl_anio = new Label();
            lbl_nombre = new Label();
            btn_crear = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // txt_anio
            // 
            txt_anio.Location = new Point(402, 163);
            txt_anio.Name = "txt_anio";
            txt_anio.Size = new Size(188, 31);
            txt_anio.TabIndex = 21;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(180, 163);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(188, 31);
            txt_telefono.TabIndex = 20;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(641, 39);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(199, 31);
            txt_dni.TabIndex = 19;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(402, 39);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(197, 31);
            txt_apellido.TabIndex = 18;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(180, 44);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(188, 31);
            txt_nombre.TabIndex = 17;
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(666, 11);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(43, 25);
            lbl_dni.TabIndex = 16;
            lbl_dni.Text = "DNI";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(450, 11);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(78, 25);
            lbl_apellido.TabIndex = 15;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(229, 121);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(79, 25);
            lbl_telefono.TabIndex = 14;
            lbl_telefono.Text = "Telefono";
            // 
            // lbl_anio
            // 
            lbl_anio.AutoSize = true;
            lbl_anio.Location = new Point(450, 121);
            lbl_anio.Name = "lbl_anio";
            lbl_anio.Size = new Size(45, 25);
            lbl_anio.TabIndex = 13;
            lbl_anio.Text = "Año";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(229, 11);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 12;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(386, 224);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(303, 34);
            btn_crear.TabIndex = 22;
            btn_crear.Text = "Dar Alta Alumno\r\n\r\n";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += btn_crear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(386, 442);
            button1.Name = "button1";
            button1.Size = new Size(303, 34);
            button1.TabIndex = 23;
            button1.Text = "Dar Baja Alumno";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(439, 378);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 31);
            textBox1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(519, 316);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 24;
            label1.Text = "DNI";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 34);
            btn_salir.TabIndex = 26;
            btn_salir.Text = "Volver";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += button2_Click;
            // 
            // FormIngresoAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(btn_salir);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btn_crear);
            Controls.Add(txt_anio);
            Controls.Add(txt_telefono);
            Controls.Add(txt_dni);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_dni);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_telefono);
            Controls.Add(lbl_anio);
            Controls.Add(lbl_nombre);
            Name = "FormIngresoAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIngreso";
            Load += PlanillaInscripcionUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_anio;
        private TextBox txt_telefono;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label lbl_dni;
        private Label lbl_apellido;
        private Label lbl_telefono;
        private Label lbl_anio;
        private Label lbl_nombre;
        private Button btn_crear;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button btn_salir;
    }
}