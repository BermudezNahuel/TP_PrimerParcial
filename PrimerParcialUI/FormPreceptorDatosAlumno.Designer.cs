namespace PrimerParcialUI
{
    partial class FormPreceptorDatosAlumno
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
            dtg_info = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dtg_notas = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Btn_Actualizar = new Button();
            Btn_DarBaja = new Button();
            Btn_Salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_notas).BeginInit();
            SuspendLayout();
            // 
            // dtg_info
            // 
            dtg_info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_info.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtg_info.Location = new Point(123, 98);
            dtg_info.Name = "dtg_info";
            dtg_info.RowHeadersWidth = 62;
            dtg_info.RowTemplate.Height = 33;
            dtg_info.Size = new Size(816, 133);
            dtg_info.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Apellido";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Dni";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Curso";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // dtg_notas
            // 
            dtg_notas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_notas.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9 });
            dtg_notas.Location = new Point(123, 232);
            dtg_notas.Name = "dtg_notas";
            dtg_notas.RowHeadersWidth = 62;
            dtg_notas.RowTemplate.Height = 33;
            dtg_notas.Size = new Size(816, 377);
            dtg_notas.TabIndex = 1;
            // 
            // Column6
            // 
            Column6.HeaderText = "Materia";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 300;
            // 
            // Column7
            // 
            Column7.HeaderText = "Nota Primer Cuatrimestre";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Nota Segundo Cuatrimestre";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 150;
            // 
            // Column9
            // 
            Column9.HeaderText = "Nota Final";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 150;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.Location = new Point(325, 19);
            Btn_Actualizar.Name = "Btn_Actualizar";
            Btn_Actualizar.Size = new Size(149, 34);
            Btn_Actualizar.TabIndex = 2;
            Btn_Actualizar.Text = "ACTUALIZAR";
            Btn_Actualizar.UseVisualStyleBackColor = true;
            Btn_Actualizar.Click += Btn_Actualizar_Click;
            // 
            // Btn_DarBaja
            // 
            Btn_DarBaja.Location = new Point(622, 19);
            Btn_DarBaja.Name = "Btn_DarBaja";
            Btn_DarBaja.Size = new Size(112, 34);
            Btn_DarBaja.TabIndex = 3;
            Btn_DarBaja.Text = "DAR BAJA";
            Btn_DarBaja.UseVisualStyleBackColor = true;
            Btn_DarBaja.Click += Btn_DarBaja_Click;
            // 
            // Btn_Salir
            // 
            Btn_Salir.Location = new Point(16, 19);
            Btn_Salir.Name = "Btn_Salir";
            Btn_Salir.Size = new Size(112, 34);
            Btn_Salir.TabIndex = 4;
            Btn_Salir.TabStop = false;
            Btn_Salir.Text = "Volver";
            Btn_Salir.UseVisualStyleBackColor = true;
            Btn_Salir.Click += Btn_Salir_Click;
            // 
            // FormPreceptorDatosAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(Btn_Salir);
            Controls.Add(Btn_DarBaja);
            Controls.Add(Btn_Actualizar);
            Controls.Add(dtg_notas);
            Controls.Add(dtg_info);
            Name = "FormPreceptorDatosAlumno";
            Text = "FormPreceptorDatosAlumno";
            Load += FormPreceptorDatosAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_notas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_info;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dtg_notas;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button Btn_Actualizar;
        private Button Btn_DarBaja;
        private Button Btn_Salir;
    }
}