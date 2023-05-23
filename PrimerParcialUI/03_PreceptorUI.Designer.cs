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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreceptorUI));
            Btn_AlumnoGestionar = new Button();
            Btn_ProfesorDarAlta = new Button();
            Btn_Salir = new Button();
            Btn_ProfesorBuscar = new Button();
            Btn_AlumnoDarAlta = new Button();
            Btn_ProfesorGestionar = new Button();
            SuspendLayout();
            // 
            // Btn_AlumnoGestionar
            // 
            Btn_AlumnoGestionar.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            Btn_AlumnoGestionar.Location = new Point(584, 260);
            Btn_AlumnoGestionar.Name = "Btn_AlumnoGestionar";
            Btn_AlumnoGestionar.Size = new Size(164, 70);
            Btn_AlumnoGestionar.TabIndex = 1;
            Btn_AlumnoGestionar.Text = "Gestionar Alumno";
            Btn_AlumnoGestionar.UseVisualStyleBackColor = true;
            Btn_AlumnoGestionar.Click += Btn_AlumnoGestionar_Click;
            // 
            // Btn_ProfesorDarAlta
            // 
            Btn_ProfesorDarAlta.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            Btn_ProfesorDarAlta.Location = new Point(804, 136);
            Btn_ProfesorDarAlta.Name = "Btn_ProfesorDarAlta";
            Btn_ProfesorDarAlta.Size = new Size(164, 70);
            Btn_ProfesorDarAlta.TabIndex = 2;
            Btn_ProfesorDarAlta.Text = "Agregar Profesor";
            Btn_ProfesorDarAlta.UseVisualStyleBackColor = true;
            Btn_ProfesorDarAlta.Click += Btn_ProfesorDarAlta_Click;
            // 
            // Btn_Salir
            // 
            Btn_Salir.Location = new Point(12, 12);
            Btn_Salir.Name = "Btn_Salir";
            Btn_Salir.Size = new Size(112, 34);
            Btn_Salir.TabIndex = 27;
            Btn_Salir.Text = "Volver";
            Btn_Salir.UseVisualStyleBackColor = true;
            Btn_Salir.Click += Btn_salir_Click;
            // 
            // Btn_ProfesorBuscar
            // 
            Btn_ProfesorBuscar.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            Btn_ProfesorBuscar.Location = new Point(804, 397);
            Btn_ProfesorBuscar.Name = "Btn_ProfesorBuscar";
            Btn_ProfesorBuscar.Size = new Size(164, 70);
            Btn_ProfesorBuscar.TabIndex = 29;
            Btn_ProfesorBuscar.Text = "Buscar Profesor";
            Btn_ProfesorBuscar.UseVisualStyleBackColor = true;
            // 
            // Btn_AlumnoDarAlta
            // 
            Btn_AlumnoDarAlta.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            Btn_AlumnoDarAlta.Location = new Point(584, 136);
            Btn_AlumnoDarAlta.Name = "Btn_AlumnoDarAlta";
            Btn_AlumnoDarAlta.Size = new Size(164, 70);
            Btn_AlumnoDarAlta.TabIndex = 30;
            Btn_AlumnoDarAlta.Text = "Dar Alta Alumno";
            Btn_AlumnoDarAlta.UseVisualStyleBackColor = true;
            Btn_AlumnoDarAlta.Click += Btn_AlumnoDarAlta_Click;
            // 
            // Btn_ProfesorGestionar
            // 
            Btn_ProfesorGestionar.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            Btn_ProfesorGestionar.Location = new Point(804, 260);
            Btn_ProfesorGestionar.Name = "Btn_ProfesorGestionar";
            Btn_ProfesorGestionar.Size = new Size(164, 70);
            Btn_ProfesorGestionar.TabIndex = 31;
            Btn_ProfesorGestionar.Text = "Actualizar/Dar Baja Profesor";
            Btn_ProfesorGestionar.UseVisualStyleBackColor = true;
            // 
            // PreceptorUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1059, 621);
            Controls.Add(Btn_ProfesorGestionar);
            Controls.Add(Btn_AlumnoDarAlta);
            Controls.Add(Btn_ProfesorBuscar);
            Controls.Add(Btn_Salir);
            Controls.Add(Btn_ProfesorDarAlta);
            Controls.Add(Btn_AlumnoGestionar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PreceptorUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preceptor";
            ResumeLayout(false);
        }

        #endregion
        private Button Btn_AlumnoGestionar;
        private Button Btn_ProfesorDarAlta;
        private Button Btn_Salir;
        private Button Btn_ProfesorBuscar;
        private Button Btn_AlumnoDarAlta;
        private Button Btn_ProfesorGestionar;
    }
}