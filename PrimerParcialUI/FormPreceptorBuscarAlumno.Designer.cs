namespace PrimerParcialUI
{
    partial class FormPreceptorBuscarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreceptorBuscarAlumno));
            btn_buscar = new Button();
            textBox_dni = new TextBox();
            label1 = new Label();
            Btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(726, 294);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(112, 34);
            btn_buscar.TabIndex = 0;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += Btn_buscar_Click;
            // 
            // textBox_dni
            // 
            textBox_dni.Location = new Point(706, 214);
            textBox_dni.Name = "textBox_dni";
            textBox_dni.Size = new Size(150, 31);
            textBox_dni.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 146);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 2;
            label1.Text = "Introducir DNI del alumno";
            // 
            // Btn_salir
            // 
            Btn_salir.Location = new Point(12, 11);
            Btn_salir.Name = "Btn_salir";
            Btn_salir.Size = new Size(106, 38);
            Btn_salir.TabIndex = 3;
            Btn_salir.Text = "Volver";
            Btn_salir.UseVisualStyleBackColor = true;
            Btn_salir.Click += Btn_salir_Click;
            // 
            // FormPreceptorBuscarAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1059, 621);
            Controls.Add(Btn_salir);
            Controls.Add(label1);
            Controls.Add(textBox_dni);
            Controls.Add(btn_buscar);
            Name = "FormPreceptorBuscarAlumno";
            Text = "FormPreceptorBuscarAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscar;
        private TextBox textBox_dni;
        private Label label1;
        private Button Btn_salir;
    }
}