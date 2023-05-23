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
            btn_salir = new Button();
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
            // 
            // AltaDocenteUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(btn_salir);
            Name = "AltaDocenteUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaDocenteUI";
            Load += AltaDocenteUI_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_salir;
    }
}