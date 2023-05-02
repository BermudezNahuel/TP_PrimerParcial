namespace PrimerParcialUI
{
    partial class PreceptorUI
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
            btn_AgregarAlumno = new Button();
            lbl_nombre = new Label();
            lbl_anio = new Label();
            lbl_telefono = new Label();
            lbl_apellido = new Label();
            lbl_dni = new Label();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_dni = new TextBox();
            txt_telefono = new TextBox();
            txt_anio = new TextBox();
            SuspendLayout();
            // 
            // btn_AgregarAlumno
            // 
            btn_AgregarAlumno.Location = new Point(452, 247);
            btn_AgregarAlumno.Name = "btn_AgregarAlumno";
            btn_AgregarAlumno.Size = new Size(236, 70);
            btn_AgregarAlumno.TabIndex = 1;
            btn_AgregarAlumno.Text = "Agregar Alumno";
            btn_AgregarAlumno.UseVisualStyleBackColor = true;
            btn_AgregarAlumno.Click += button1_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(77, 35);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_anio
            // 
            lbl_anio.AutoSize = true;
            lbl_anio.Location = new Point(298, 145);
            lbl_anio.Name = "lbl_anio";
            lbl_anio.Size = new Size(45, 25);
            lbl_anio.TabIndex = 3;
            lbl_anio.Text = "Año";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(77, 145);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(79, 25);
            lbl_telefono.TabIndex = 4;
            lbl_telefono.Text = "Telefono";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(298, 35);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(78, 25);
            lbl_apellido.TabIndex = 5;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(514, 35);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(43, 25);
            lbl_dni.TabIndex = 6;
            lbl_dni.Text = "DNI";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(28, 68);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(188, 31);
            txt_nombre.TabIndex = 7;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(250, 63);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(197, 31);
            txt_apellido.TabIndex = 8;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(489, 63);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(199, 31);
            txt_dni.TabIndex = 9;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(28, 187);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(188, 31);
            txt_telefono.TabIndex = 10;
            // 
            // txt_anio
            // 
            txt_anio.Location = new Point(250, 187);
            txt_anio.Name = "txt_anio";
            txt_anio.Size = new Size(188, 31);
            txt_anio.TabIndex = 11;
            // 
            // PreceptorUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 339);
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
            Controls.Add(btn_AgregarAlumno);
            Name = "PreceptorUI";
            Text = "PreceptorUI";
            Load += PreceptorUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_AgregarAlumno;
        private Label lbl_nombre;
        private Label lbl_anio;
        private Label lbl_telefono;
        private Label lbl_apellido;
        private Label lbl_dni;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_dni;
        private TextBox txt_telefono;
        private TextBox txt_anio;
    }
}