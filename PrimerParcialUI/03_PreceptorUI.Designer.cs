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
            btn_profesor = new Button();
            SuspendLayout();
            // 
            // btn_AgregarAlumno
            // 
            btn_AgregarAlumno.Location = new Point(391, 214);
            btn_AgregarAlumno.Name = "btn_AgregarAlumno";
            btn_AgregarAlumno.Size = new Size(236, 70);
            btn_AgregarAlumno.TabIndex = 1;
            btn_AgregarAlumno.Text = "Agregar Alumno";
            btn_AgregarAlumno.UseVisualStyleBackColor = true;
            btn_AgregarAlumno.Click += button1_Click;
            // 
            // btn_profesor
            // 
            btn_profesor.Location = new Point(391, 383);
            btn_profesor.Name = "btn_profesor";
            btn_profesor.Size = new Size(236, 70);
            btn_profesor.TabIndex = 2;
            btn_profesor.Text = "Agregar Profesor";
            btn_profesor.UseVisualStyleBackColor = true;
            // 
            // PreceptorUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(btn_profesor);
            Controls.Add(btn_AgregarAlumno);
            Name = "PreceptorUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreceptorUI";
            Load += PreceptorUI_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_AgregarAlumno;
        private Button btn_profesor;
    }
}