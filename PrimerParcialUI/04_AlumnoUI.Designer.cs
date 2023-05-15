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
            dataGridView_notas = new DataGridView();
            Materias = new DataGridViewTextBoxColumn();
            Notas = new DataGridViewTextBoxColumn();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            txt_apellido = new TextBox();
            lbl_apellido = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_notas).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_notas
            // 
            dataGridView_notas.AllowUserToOrderColumns = true;
            dataGridView_notas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_notas.Columns.AddRange(new DataGridViewColumn[] { Materias, Notas });
            dataGridView_notas.Location = new Point(72, 124);
            dataGridView_notas.Name = "dataGridView_notas";
            dataGridView_notas.RowHeadersWidth = 62;
            dataGridView_notas.RowTemplate.Height = 33;
            dataGridView_notas.Size = new Size(726, 338);
            dataGridView_notas.TabIndex = 0;
            dataGridView_notas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Materias
            // 
            Materias.HeaderText = "Materias";
            Materias.MinimumWidth = 8;
            Materias.Name = "Materias";
            Materias.Width = 150;
            // 
            // Notas
            // 
            Notas.HeaderText = "Notas";
            Notas.MinimumWidth = 8;
            Notas.Name = "Notas";
            Notas.Width = 150;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(99, 49);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(150, 31);
            txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(103, 14);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(417, 49);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(150, 31);
            txt_apellido.TabIndex = 3;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(417, 14);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(78, 25);
            lbl_apellido.TabIndex = 4;
            lbl_apellido.Text = "Apellido";
            // 
            // button1
            // 
            button1.Location = new Point(634, 27);
            button1.Name = "button1";
            button1.Size = new Size(174, 53);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AlumnoUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(button1);
            Controls.Add(lbl_apellido);
            Controls.Add(txt_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_nombre);
            Controls.Add(dataGridView_notas);
            Name = "AlumnoUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerNotasUI";
            Load += AlumnoUI_OnLoad;
            ((System.ComponentModel.ISupportInitialize)dataGridView_notas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_notas;
        private DataGridViewTextBoxColumn Materias;
        private DataGridViewTextBoxColumn Notas;
        private TextBox txt_nombre;
        private Label lbl_nombre;
        private TextBox txt_apellido;
        private Label lbl_apellido;
        private Button button1;
    }
}