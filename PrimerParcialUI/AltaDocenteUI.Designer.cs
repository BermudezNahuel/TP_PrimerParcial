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
            txt_nombre = new TextBox();
            txt_dni = new TextBox();
            txt_apellido = new TextBox();
            txt_telefono = new TextBox();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_dni = new Label();
            lbl_telefono = new Label();
            Lbl_agregar = new Button();
            dtg_AnioYMateria = new DataGridView();
            Col_anio = new DataGridViewTextBoxColumn();
            Col_materia = new DataGridViewTextBoxColumn();
            Btn_AsignarMateria = new Button();
            cbo_anio = new ComboBox();
            cbo_materia = new ComboBox();
            lbl_anio = new Label();
            lbl_materia = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_AnioYMateria).BeginInit();
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
            // txt_nombre
            // 
            txt_nombre.Location = new Point(569, 131);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(150, 31);
            txt_nombre.TabIndex = 28;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(569, 212);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(150, 31);
            txt_dni.TabIndex = 29;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(785, 131);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(150, 31);
            txt_apellido.TabIndex = 30;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(785, 212);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(150, 31);
            txt_telefono.TabIndex = 31;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(569, 89);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 32;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(785, 89);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(78, 25);
            lbl_apellido.TabIndex = 33;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(569, 173);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(39, 25);
            lbl_dni.TabIndex = 34;
            lbl_dni.Text = "Dni";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(785, 173);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(79, 25);
            lbl_telefono.TabIndex = 35;
            lbl_telefono.Text = "Telefono";
            // 
            // Lbl_agregar
            // 
            Lbl_agregar.Location = new Point(726, 22);
            Lbl_agregar.Name = "Lbl_agregar";
            Lbl_agregar.Size = new Size(112, 34);
            Lbl_agregar.TabIndex = 36;
            Lbl_agregar.Text = "Agregar";
            Lbl_agregar.UseVisualStyleBackColor = true;
            Lbl_agregar.Click += Lbl_agregar_Click;
            // 
            // dtg_AnioYMateria
            // 
            dtg_AnioYMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_AnioYMateria.Columns.AddRange(new DataGridViewColumn[] { Col_anio, Col_materia });
            dtg_AnioYMateria.Location = new Point(12, 80);
            dtg_AnioYMateria.Name = "dtg_AnioYMateria";
            dtg_AnioYMateria.RowHeadersWidth = 62;
            dtg_AnioYMateria.RowTemplate.Height = 33;
            dtg_AnioYMateria.Size = new Size(515, 450);
            dtg_AnioYMateria.TabIndex = 37;
            // 
            // Col_anio
            // 
            Col_anio.HeaderText = "Año";
            Col_anio.MinimumWidth = 8;
            Col_anio.Name = "Col_anio";
            Col_anio.Resizable = DataGridViewTriState.True;
            Col_anio.SortMode = DataGridViewColumnSortMode.NotSortable;
            Col_anio.Width = 150;
            // 
            // Col_materia
            // 
            Col_materia.HeaderText = "Asigantura";
            Col_materia.MinimumWidth = 8;
            Col_materia.Name = "Col_materia";
            Col_materia.Resizable = DataGridViewTriState.True;
            Col_materia.SortMode = DataGridViewColumnSortMode.NotSortable;
            Col_materia.Width = 300;
            // 
            // Btn_AsignarMateria
            // 
            Btn_AsignarMateria.Location = new Point(943, 301);
            Btn_AsignarMateria.Name = "Btn_AsignarMateria";
            Btn_AsignarMateria.Size = new Size(89, 190);
            Btn_AsignarMateria.TabIndex = 38;
            Btn_AsignarMateria.Text = "Asignar Curso Y Materia";
            Btn_AsignarMateria.UseVisualStyleBackColor = true;
            Btn_AsignarMateria.Click += Btn_AsignarMateria_Click;
            // 
            // cbo_anio
            // 
            cbo_anio.FormattingEnabled = true;
            cbo_anio.Location = new Point(569, 301);
            cbo_anio.Name = "cbo_anio";
            cbo_anio.Size = new Size(64, 33);
            cbo_anio.TabIndex = 39;
            // 
            // cbo_materia
            // 
            cbo_materia.FormattingEnabled = true;
            cbo_materia.Location = new Point(671, 301);
            cbo_materia.Name = "cbo_materia";
            cbo_materia.Size = new Size(231, 33);
            cbo_materia.TabIndex = 40;
            // 
            // lbl_anio
            // 
            lbl_anio.AutoSize = true;
            lbl_anio.Location = new Point(569, 266);
            lbl_anio.Name = "lbl_anio";
            lbl_anio.Size = new Size(45, 25);
            lbl_anio.TabIndex = 41;
            lbl_anio.Text = "Año";
            // 
            // lbl_materia
            // 
            lbl_materia.AutoSize = true;
            lbl_materia.Location = new Point(671, 266);
            lbl_materia.Name = "lbl_materia";
            lbl_materia.Size = new Size(71, 25);
            lbl_materia.TabIndex = 42;
            lbl_materia.Text = "Materia";
            // 
            // AltaDocenteUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1059, 621);
            Controls.Add(lbl_materia);
            Controls.Add(lbl_anio);
            Controls.Add(cbo_materia);
            Controls.Add(cbo_anio);
            Controls.Add(Btn_AsignarMateria);
            Controls.Add(dtg_AnioYMateria);
            Controls.Add(Lbl_agregar);
            Controls.Add(lbl_telefono);
            Controls.Add(lbl_dni);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_telefono);
            Controls.Add(txt_apellido);
            Controls.Add(txt_dni);
            Controls.Add(txt_nombre);
            Controls.Add(btn_salir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AltaDocenteUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaDocenteUI";
            Load += AltaDocenteUI_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_AnioYMateria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salir;
        private TextBox txt_nombre;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_telefono;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_dni;
        private Label lbl_telefono;
        private Button Lbl_agregar;
        private DataGridView dtg_AnioYMateria;
        private Button Btn_AsignarMateria;
        private DataGridViewTextBoxColumn Col_anio;
        private DataGridViewTextBoxColumn Col_materia;
        private ComboBox cbo_anio;
        private ComboBox cbo_materia;
        private Label lbl_anio;
        private Label lbl_materia;
    }
}