namespace PrimerParcialUI
{
    partial class AlumnoUI
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
            dtg_notas = new DataGridView();
            Materias = new DataGridViewTextBoxColumn();
            Notas = new DataGridViewTextBoxColumn();
            Col_SegundoCuatri = new DataGridViewTextBoxColumn();
            Col_NotaFinal = new DataGridViewTextBoxColumn();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            txt_apellido = new TextBox();
            lbl_apellido = new Label();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_notas).BeginInit();
            SuspendLayout();
            // 
            // dtg_notas
            // 
            dtg_notas.AllowUserToAddRows = false;
            dtg_notas.AllowUserToDeleteRows = false;
            dtg_notas.AllowUserToResizeColumns = false;
            dtg_notas.AllowUserToResizeRows = false;
            dtg_notas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_notas.Columns.AddRange(new DataGridViewColumn[] { Materias, Notas, Col_SegundoCuatri, Col_NotaFinal });
            dtg_notas.Location = new Point(104, 179);
            dtg_notas.Name = "dtg_notas";
            dtg_notas.RowHeadersWidth = 62;
            dtg_notas.RowTemplate.Height = 33;
            dtg_notas.Size = new Size(865, 338);
            dtg_notas.TabIndex = 0;
            // 
            // Materias
            // 
            Materias.HeaderText = "Materias";
            Materias.MinimumWidth = 350;
            Materias.Name = "Materias";
            Materias.ReadOnly = true;
            Materias.Width = 350;
            // 
            // Notas
            // 
            Notas.HeaderText = "Primer Cuatrimestre";
            Notas.MinimumWidth = 8;
            Notas.Name = "Notas";
            Notas.ReadOnly = true;
            Notas.Width = 150;
            // 
            // Col_SegundoCuatri
            // 
            Col_SegundoCuatri.HeaderText = "Segundo Cuatrimestre";
            Col_SegundoCuatri.MinimumWidth = 8;
            Col_SegundoCuatri.Name = "Col_SegundoCuatri";
            Col_SegundoCuatri.ReadOnly = true;
            Col_SegundoCuatri.Width = 150;
            // 
            // Col_NotaFinal
            // 
            Col_NotaFinal.HeaderText = "Nota Final";
            Col_NotaFinal.MinimumWidth = 8;
            Col_NotaFinal.Name = "Col_NotaFinal";
            Col_NotaFinal.ReadOnly = true;
            Col_NotaFinal.Width = 150;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(146, 99);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(150, 31);
            txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(150, 64);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(464, 99);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(150, 31);
            txt_apellido.TabIndex = 3;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(464, 64);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(78, 25);
            lbl_apellido.TabIndex = 4;
            lbl_apellido.Text = "Apellido";
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
            // AlumnoUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(btn_salir);
            Controls.Add(lbl_apellido);
            Controls.Add(txt_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_nombre);
            Controls.Add(dtg_notas);
            Name = "AlumnoUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerNotasUI";
            ((System.ComponentModel.ISupportInitialize)dtg_notas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_notas;
        private TextBox txt_nombre;
        private Label lbl_nombre;
        private TextBox txt_apellido;
        private Label lbl_apellido;
        private Button btn_salir;
        private DataGridViewTextBoxColumn Materias;
        private DataGridViewTextBoxColumn Notas;
        private DataGridViewTextBoxColumn Col_SegundoCuatri;
        private DataGridViewTextBoxColumn Col_NotaFinal;
    }
}