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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLog));
            lbl_usuario = new Label();
            lbl_contrasenia = new Label();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            btn_ingreso = new Button();
            lbl_errorContraseña = new Label();
            lbl_errorFormat = new Label();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = SystemColors.Control;
            lbl_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuario.Location = new Point(489, 39);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(119, 32);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "USUARIO";
            // 
            // lbl_contrasenia
            // 
            lbl_contrasenia.AutoSize = true;
            lbl_contrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_contrasenia.Location = new Point(462, 187);
            lbl_contrasenia.Name = "lbl_contrasenia";
            lbl_contrasenia.Size = new Size(175, 32);
            lbl_contrasenia.TabIndex = 4;
            lbl_contrasenia.Text = "CONTRASEÑA";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(473, 90);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(150, 39);
            txt_usuario.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(473, 242);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(150, 39);
            txt_password.TabIndex = 6;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_ingreso
            // 
            btn_ingreso.FlatAppearance.BorderColor = Color.Black;
            btn_ingreso.FlatAppearance.BorderSize = 4;
            btn_ingreso.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ingreso.Location = new Point(395, 310);
            btn_ingreso.Name = "btn_ingreso";
            btn_ingreso.Size = new Size(307, 135);
            btn_ingreso.TabIndex = 9;
            btn_ingreso.Text = "INGRESAR";
            btn_ingreso.UseVisualStyleBackColor = true;
            btn_ingreso.Click += btn_ingreso_Click;
            // 
            // lbl_errorContraseña
            // 
            lbl_errorContraseña.AutoSize = true;
            lbl_errorContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_errorContraseña.ForeColor = Color.Violet;
            lbl_errorContraseña.Location = new Point(406, 513);
            lbl_errorContraseña.Name = "lbl_errorContraseña";
            lbl_errorContraseña.Size = new Size(285, 25);
            lbl_errorContraseña.TabIndex = 10;
            lbl_errorContraseña.Text = "Usuario o Contraseña incorrecta";
            lbl_errorContraseña.Visible = false;
            // 
            // lbl_errorFormat
            // 
            lbl_errorFormat.AutoSize = true;
            lbl_errorFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_errorFormat.ForeColor = Color.Violet;
            lbl_errorFormat.Location = new Point(418, 561);
            lbl_errorFormat.Name = "lbl_errorFormat";
            lbl_errorFormat.Size = new Size(260, 25);
            lbl_errorFormat.TabIndex = 11;
            lbl_errorFormat.Text = "Solo puede ingresar numeros";
            lbl_errorFormat.Visible = false;
            // 
            // FormularioLog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1059, 621);
            Controls.Add(lbl_errorFormat);
            Controls.Add(lbl_errorContraseña);
            Controls.Add(btn_ingreso);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_contrasenia);
            Controls.Add(lbl_usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormularioLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIS EES N°73";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_usuario;
        private Label lbl_contrasenia;
        private TextBox txt_usuario;
        private TextBox txt_password;
        private Button btn_ingreso;
        private Label lbl_errorContraseña;
        private Label lbl_errorFormat;
    }
}