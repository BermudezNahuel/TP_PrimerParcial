namespace PrimerParcialUI
{
    partial class FormProfesorCalificar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_guardar = new Button();
            lbl_materia = new Label();
            lbl_curso = new Label();
            dtg_notas = new DataGridView();
            NombreApellido = new DataGridViewTextBoxColumn();
            Notas = new DataGridViewTextBoxColumn();
            Col_SegundoCuatri = new DataGridViewTextBoxColumn();
            Col_NotaFinal = new DataGridViewTextBoxColumn();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_notas).BeginInit();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guardar.Location = new Point(917, 19);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(130, 76);
            btn_guardar.TabIndex = 36;
            btn_guardar.Text = "Guardar Cambios";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += Btn_guardar_Click;
            // 
            // lbl_materia
            // 
            lbl_materia.AutoSize = true;
            lbl_materia.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_materia.Location = new Point(578, 65);
            lbl_materia.Name = "lbl_materia";
            lbl_materia.Size = new Size(97, 29);
            lbl_materia.TabIndex = 35;
            lbl_materia.Text = "materia";
            // 
            // lbl_curso
            // 
            lbl_curso.AutoSize = true;
            lbl_curso.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_curso.Location = new Point(378, 65);
            lbl_curso.Name = "lbl_curso";
            lbl_curso.Size = new Size(52, 29);
            lbl_curso.TabIndex = 34;
            lbl_curso.Text = "año";
            // 
            // dtg_notas
            // 
            dtg_notas.AllowUserToOrderColumns = true;
            dtg_notas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_notas.Columns.AddRange(new DataGridViewColumn[] { NombreApellido, Notas, Col_SegundoCuatri, Col_NotaFinal });
            dtg_notas.GridColor = SystemColors.ActiveCaption;
            dtg_notas.Location = new Point(38, 120);
            dtg_notas.Name = "dtg_notas";
            dtg_notas.RowHeadersWidth = 62;
            dtg_notas.RowTemplate.Height = 33;
            dtg_notas.Size = new Size(964, 489);
            dtg_notas.TabIndex = 33;
            // 
            // NombreApellido
            // 
            NombreApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            NombreApellido.DefaultCellStyle = dataGridViewCellStyle1;
            NombreApellido.HeaderText = "Apellido y Nombre";
            NombreApellido.MinimumWidth = 350;
            NombreApellido.Name = "NombreApellido";
            NombreApellido.Width = 350;
            // 
            // Notas
            // 
            Notas.HeaderText = "Primer Cuatrimestre";
            Notas.MinimumWidth = 200;
            Notas.Name = "Notas";
            Notas.Width = 200;
            // 
            // Col_SegundoCuatri
            // 
            Col_SegundoCuatri.HeaderText = "Segundo Cuatrimestre";
            Col_SegundoCuatri.MinimumWidth = 200;
            Col_SegundoCuatri.Name = "Col_SegundoCuatri";
            Col_SegundoCuatri.Width = 200;
            // 
            // Col_NotaFinal
            // 
            Col_NotaFinal.HeaderText = "Nota Final";
            Col_NotaFinal.MinimumWidth = 8;
            Col_NotaFinal.Name = "Col_NotaFinal";
            Col_NotaFinal.Width = 150;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.Location = new Point(12, 19);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 42);
            btn_salir.TabIndex = 32;
            btn_salir.Text = "Volver";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += Btn_salir_Click;
            // 
            // FormProfesorCalificar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 621);
            Controls.Add(btn_guardar);
            Controls.Add(lbl_materia);
            Controls.Add(lbl_curso);
            Controls.Add(dtg_notas);
            Controls.Add(btn_salir);
            Name = "FormProfesorCalificar";
            Text = "FormProfesorCalificar";
            ((System.ComponentModel.ISupportInitialize)dtg_notas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private Label lbl_materia;
        private Label lbl_curso;
        private DataGridView dtg_notas;
        private DataGridViewTextBoxColumn NombreApellido;
        private DataGridViewTextBoxColumn Notas;
        private DataGridViewTextBoxColumn Col_SegundoCuatri;
        private DataGridViewTextBoxColumn Col_NotaFinal;
        private Button btn_salir;
    }
}