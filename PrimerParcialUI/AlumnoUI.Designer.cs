namespace PrimerParcialUI
{
    partial class VerNotasUI
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_notas).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_notas
            // 
            dataGridView_notas.AllowUserToOrderColumns = true;
            dataGridView_notas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_notas.Columns.AddRange(new DataGridViewColumn[] { Materias, Notas });
            dataGridView_notas.Location = new Point(12, 201);
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
            // VerNotasUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 551);
            Controls.Add(dataGridView_notas);
            Name = "VerNotasUI";
            Text = "VerNotasUI";
            ((System.ComponentModel.ISupportInitialize)dataGridView_notas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_notas;
        private DataGridViewTextBoxColumn Materias;
        private DataGridViewTextBoxColumn Notas;
    }
}