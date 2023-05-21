namespace PrimerParcialUI
{
    partial class Profesor_01UI
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
            btn_salir = new Button();
            lbl_materia = new Label();
            lbl_anio = new Label();
            cbo_materia = new ComboBox();
            cbo_anio = new ComboBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            btn_calificar = new Button();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(676, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 34);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // lbl_materia
            // 
            lbl_materia.AutoSize = true;
            lbl_materia.Location = new Point(353, 145);
            lbl_materia.MinimumSize = new Size(182, 33);
            lbl_materia.Name = "lbl_materia";
            lbl_materia.Size = new Size(182, 33);
            lbl_materia.TabIndex = 1;
            lbl_materia.Text = "Materia";
            lbl_materia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_anio
            // 
            lbl_anio.AutoSize = true;
            lbl_anio.Location = new Point(48, 145);
            lbl_anio.MinimumSize = new Size(182, 33);
            lbl_anio.Name = "lbl_anio";
            lbl_anio.Size = new Size(182, 33);
            lbl_anio.TabIndex = 2;
            lbl_anio.Text = "Año";
            lbl_anio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbo_materia
            // 
            cbo_materia.FormattingEnabled = true;
            cbo_materia.Location = new Point(353, 205);
            cbo_materia.Name = "cbo_materia";
            cbo_materia.Size = new Size(182, 33);
            cbo_materia.TabIndex = 3;
            // 
            // cbo_anio
            // 
            cbo_anio.FormattingEnabled = true;
            cbo_anio.Location = new Point(48, 205);
            cbo_anio.Name = "cbo_anio";
            cbo_anio.Size = new Size(182, 33);
            cbo_anio.TabIndex = 4;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(48, 72);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(182, 31);
            txt_apellido.TabIndex = 5;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(353, 72);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(182, 31);
            txt_nombre.TabIndex = 6;
            // 
            // btn_calificar
            // 
            btn_calificar.Location = new Point(364, 359);
            btn_calificar.Name = "btn_calificar";
            btn_calificar.Size = new Size(244, 34);
            btn_calificar.TabIndex = 7;
            btn_calificar.Text = "Calificar";
            btn_calificar.UseVisualStyleBackColor = true;
            btn_calificar.Click += btn_calificar_Click;
            // 
            // Profesor_01UI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(btn_calificar);
            Controls.Add(txt_nombre);
            Controls.Add(txt_apellido);
            Controls.Add(cbo_anio);
            Controls.Add(cbo_materia);
            Controls.Add(lbl_anio);
            Controls.Add(lbl_materia);
            Controls.Add(btn_salir);
            Name = "Profesor_01UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profesor_01UI";
            Load += Profesor_01UI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salir;
        private Label lbl_materia;
        private Label lbl_anio;
        private ComboBox cbo_materia;
        private ComboBox cbo_anio;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Button btn_calificar;
    }
}