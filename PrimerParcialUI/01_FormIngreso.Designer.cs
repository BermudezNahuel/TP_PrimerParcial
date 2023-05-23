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
            Btn_Ingreso = new Button();
            lbl_errorContraseña = new Label();
            lbl_errorFormat = new Label();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.CornflowerBlue;
            lbl_usuario.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuario.ForeColor = SystemColors.ControlLight;
            lbl_usuario.Location = new Point(733, 63);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(127, 34);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "USUARIO";
            lbl_usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_contrasenia
            // 
            lbl_contrasenia.AutoSize = true;
            lbl_contrasenia.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_contrasenia.ForeColor = SystemColors.ControlLight;
            lbl_contrasenia.Location = new Point(703, 184);
            lbl_contrasenia.Name = "lbl_contrasenia";
            lbl_contrasenia.Size = new Size(190, 34);
            lbl_contrasenia.TabIndex = 4;
            lbl_contrasenia.Text = "CONTRASEÑA";
            lbl_contrasenia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(692, 115);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(220, 41);
            txt_usuario.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(692, 246);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(220, 41);
            txt_password.TabIndex = 6;
            // 
            // Btn_Ingreso
            // 
            Btn_Ingreso.FlatAppearance.BorderColor = Color.Black;
            Btn_Ingreso.FlatAppearance.BorderSize = 10;
            Btn_Ingreso.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            Btn_Ingreso.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Ingreso.Location = new Point(665, 320);
            Btn_Ingreso.Name = "Btn_Ingreso";
            Btn_Ingreso.Size = new Size(275, 96);
            Btn_Ingreso.TabIndex = 9;
            Btn_Ingreso.Text = "INGRESAR";
            Btn_Ingreso.UseVisualStyleBackColor = true;
            Btn_Ingreso.Click += Btn_ingreso_Click;
            // 
            // lbl_errorContraseña
            // 
            lbl_errorContraseña.AutoSize = true;
            lbl_errorContraseña.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_errorContraseña.ForeColor = Color.GhostWhite;
            lbl_errorContraseña.Location = new Point(577, 486);
            lbl_errorContraseña.Name = "lbl_errorContraseña";
            lbl_errorContraseña.Size = new Size(426, 34);
            lbl_errorContraseña.TabIndex = 10;
            lbl_errorContraseña.Text = "Usuario o Contraseña incorrecta";
            lbl_errorContraseña.Visible = false;
            // 
            // lbl_errorFormat
            // 
            lbl_errorFormat.AutoSize = true;
            lbl_errorFormat.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_errorFormat.ForeColor = Color.GhostWhite;
            lbl_errorFormat.Location = new Point(595, 486);
            lbl_errorFormat.Name = "lbl_errorFormat";
            lbl_errorFormat.Size = new Size(390, 34);
            lbl_errorFormat.TabIndex = 11;
            lbl_errorFormat.Text = "Solo puede ingresar numeros";
            lbl_errorFormat.Visible = false;
            // 
            // FormularioLog
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1076, 618);
            Controls.Add(lbl_errorFormat);
            Controls.Add(lbl_errorContraseña);
            Controls.Add(Btn_Ingreso);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_contrasenia);
            Controls.Add(lbl_usuario);
            Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormularioLog";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Usuarios";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_usuario;
        private Label lbl_contrasenia;
        private TextBox txt_usuario;
        private TextBox txt_password;
        private Button Btn_Ingreso;
        private Label lbl_errorContraseña;
        private Label lbl_errorFormat;
    }
}