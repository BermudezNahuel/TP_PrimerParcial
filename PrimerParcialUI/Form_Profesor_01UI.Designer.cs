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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesor_01UI));
            lbl_materia = new Label();
            lbl_anio = new Label();
            cbo_materia = new ComboBox();
            cbo_anio = new ComboBox();
            btn_calificar = new Button();
            btn_salir = new Button();
            lbl_mensaje = new Label();
            lbl_errorMateriaAnio = new Label();
            SuspendLayout();
            // 
            // lbl_materia
            // 
            lbl_materia.AutoSize = true;
            lbl_materia.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_materia.Location = new Point(786, 221);
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
            lbl_anio.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_anio.Location = new Point(521, 221);
            lbl_anio.MinimumSize = new Size(182, 33);
            lbl_anio.Name = "lbl_anio";
            lbl_anio.Size = new Size(182, 33);
            lbl_anio.TabIndex = 2;
            lbl_anio.Text = "Curso";
            lbl_anio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbo_materia
            // 
            cbo_materia.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_materia.FormattingEnabled = true;
            cbo_materia.Location = new Point(731, 257);
            cbo_materia.Name = "cbo_materia";
            cbo_materia.Size = new Size(300, 37);
            cbo_materia.TabIndex = 3;
            // 
            // cbo_anio
            // 
            cbo_anio.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_anio.FormattingEnabled = true;
            cbo_anio.Location = new Point(557, 257);
            cbo_anio.Name = "cbo_anio";
            cbo_anio.Size = new Size(100, 37);
            cbo_anio.TabIndex = 4;
            // 
            // btn_calificar
            // 
            btn_calificar.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calificar.Location = new Point(670, 391);
            btn_calificar.Name = "btn_calificar";
            btn_calificar.Size = new Size(244, 34);
            btn_calificar.TabIndex = 7;
            btn_calificar.Text = "Calificar";
            btn_calificar.UseVisualStyleBackColor = true;
            btn_calificar.Click += Btn_calificar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 34);
            btn_salir.TabIndex = 27;
            btn_salir.Text = "Volver";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += Button1_Click;
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mensaje.Location = new Point(579, 108);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(432, 29);
            lbl_mensaje.TabIndex = 28;
            lbl_mensaje.Text = "Ingrese el curso y la materia a calificar\r\n";
            lbl_mensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_errorMateriaAnio
            // 
            lbl_errorMateriaAnio.AutoSize = true;
            lbl_errorMateriaAnio.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_errorMateriaAnio.Location = new Point(525, 499);
            lbl_errorMateriaAnio.Name = "lbl_errorMateriaAnio";
            lbl_errorMateriaAnio.Size = new Size(522, 29);
            lbl_errorMateriaAnio.TabIndex = 29;
            lbl_errorMateriaAnio.Text = "Ha ingresado un curso o una materia incorrecta";
            lbl_errorMateriaAnio.Visible = false;
            // 
            // Profesor_01UI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1059, 621);
            Controls.Add(lbl_errorMateriaAnio);
            Controls.Add(lbl_mensaje);
            Controls.Add(btn_salir);
            Controls.Add(btn_calificar);
            Controls.Add(cbo_anio);
            Controls.Add(cbo_materia);
            Controls.Add(lbl_anio);
            Controls.Add(lbl_materia);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Profesor_01UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profesor_01UI";
            Load += Profesor_01UI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_materia;
        private Label lbl_anio;
        private ComboBox cbo_materia;
        private ComboBox cbo_anio;
        private Button btn_calificar;
        private Button btn_salir;
        private Label lbl_mensaje;
        private Label lbl_errorMateriaAnio;
    }
}