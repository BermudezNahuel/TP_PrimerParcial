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
            dtg_alumno = new DataGridView();
            Alumno_Legajo = new DataGridViewTextBoxColumn();
            Alumno_Nombres = new DataGridViewTextBoxColumn();
            Alumno_Apellidos = new DataGridViewTextBoxColumn();
            Alumno_Año = new DataGridViewTextBoxColumn();
            btn_AgregarAlumno = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_alumno).BeginInit();
            SuspendLayout();
            // 
            // dtg_alumno
            // 
            dtg_alumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_alumno.Columns.AddRange(new DataGridViewColumn[] { Alumno_Legajo, Alumno_Nombres, Alumno_Apellidos, Alumno_Año });
            dtg_alumno.Location = new Point(12, 46);
            dtg_alumno.Name = "dtg_alumno";
            dtg_alumno.RowHeadersWidth = 62;
            dtg_alumno.RowTemplate.Height = 33;
            dtg_alumno.Size = new Size(1020, 257);
            dtg_alumno.TabIndex = 0;
            // 
            // Alumno_Legajo
            // 
            Alumno_Legajo.HeaderText = "Legajo";
            Alumno_Legajo.MinimumWidth = 8;
            Alumno_Legajo.Name = "Alumno_Legajo";
            Alumno_Legajo.Width = 150;
            // 
            // Alumno_Nombres
            // 
            Alumno_Nombres.HeaderText = "Nombres";
            Alumno_Nombres.MinimumWidth = 8;
            Alumno_Nombres.Name = "Alumno_Nombres";
            Alumno_Nombres.Width = 150;
            // 
            // Alumno_Apellidos
            // 
            Alumno_Apellidos.HeaderText = "Apellidos";
            Alumno_Apellidos.MinimumWidth = 8;
            Alumno_Apellidos.Name = "Alumno_Apellidos";
            Alumno_Apellidos.Width = 150;
            // 
            // Alumno_Año
            // 
            Alumno_Año.HeaderText = "Año";
            Alumno_Año.MinimumWidth = 8;
            Alumno_Año.Name = "Alumno_Año";
            Alumno_Año.Width = 150;
            // 
            // btn_AgregarAlumno
            // 
            btn_AgregarAlumno.Location = new Point(762, 518);
            btn_AgregarAlumno.Name = "btn_AgregarAlumno";
            btn_AgregarAlumno.Size = new Size(236, 70);
            btn_AgregarAlumno.TabIndex = 1;
            btn_AgregarAlumno.Text = "Agregar Alumno";
            btn_AgregarAlumno.UseVisualStyleBackColor = true;
            btn_AgregarAlumno.Click += button1_Click;
            // 
            // PreceptorUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 643);
            Controls.Add(btn_AgregarAlumno);
            Controls.Add(dtg_alumno);
            Name = "PreceptorUI";
            Text = "PreceptorUI";
            ((System.ComponentModel.ISupportInitialize)dtg_alumno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_alumno;
        private DataGridViewTextBoxColumn Alumno_Legajo;
        private DataGridViewTextBoxColumn Alumno_Nombres;
        private DataGridViewTextBoxColumn Alumno_Apellidos;
        private DataGridViewTextBoxColumn Alumno_Año;
        private Button btn_AgregarAlumno;
    }
}