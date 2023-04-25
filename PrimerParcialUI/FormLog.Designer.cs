namespace PrimerParcialUI
{
    partial class FormularioLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ingresar = new Button();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(434, 367);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(112, 34);
            btn_ingresar.TabIndex = 0;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // FormularioLog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 750);
            Controls.Add(btn_ingresar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormularioLog";
            Text = "FormularioLog";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ingresar;
    }
}