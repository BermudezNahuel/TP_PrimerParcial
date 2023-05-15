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
            btn_preceptor = new Button();
            btn_alumno = new Button();
            lbl_usuario = new Label();
            lbl_contrasenia = new Label();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            btn_profesor = new Button();
            btn_ingreso = new Button();
            SuspendLayout();
            // 
            // btn_preceptor
            // 
            btn_preceptor.Location = new Point(109, 318);
            btn_preceptor.Name = "btn_preceptor";
            btn_preceptor.Size = new Size(180, 67);
            btn_preceptor.TabIndex = 0;
            btn_preceptor.Text = "Ingreso Preceptor";
            btn_preceptor.UseVisualStyleBackColor = true;
            btn_preceptor.Click += btn_ingresar_Click;
            // 
            // btn_alumno
            // 
            btn_alumno.Location = new Point(628, 318);
            btn_alumno.Name = "btn_alumno";
            btn_alumno.Size = new Size(184, 67);
            btn_alumno.TabIndex = 2;
            btn_alumno.Text = "Ingreso Alumnos";
            btn_alumno.UseVisualStyleBackColor = true;
            btn_alumno.Click += btn_alumno_Click;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(413, 52);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(88, 25);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "USUARIO";
            // 
            // lbl_contrasenia
            // 
            lbl_contrasenia.AutoSize = true;
            lbl_contrasenia.Location = new Point(397, 182);
            lbl_contrasenia.Name = "lbl_contrasenia";
            lbl_contrasenia.Size = new Size(126, 25);
            lbl_contrasenia.TabIndex = 4;
            lbl_contrasenia.Text = "CONTRASEÑA";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(386, 94);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(150, 31);
            txt_usuario.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(386, 236);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(150, 31);
            txt_password.TabIndex = 6;
            // 
            // btn_profesor
            // 
            btn_profesor.Location = new Point(386, 318);
            btn_profesor.Name = "btn_profesor";
            btn_profesor.Size = new Size(180, 67);
            btn_profesor.TabIndex = 8;
            btn_profesor.Text = "Ingreso Profesor";
            btn_profesor.UseVisualStyleBackColor = true;
            btn_profesor.Click += btn_profesor_Click;
            // 
            // btn_ingreso
            // 
            btn_ingreso.FlatAppearance.BorderColor = Color.Black;
            btn_ingreso.FlatAppearance.BorderSize = 4;
            btn_ingreso.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ingreso.Location = new Point(324, 450);
            btn_ingreso.Name = "btn_ingreso";
            btn_ingreso.Size = new Size(307, 135);
            btn_ingreso.TabIndex = 9;
            btn_ingreso.Text = "INGRESAR";
            btn_ingreso.UseVisualStyleBackColor = true;
            btn_ingreso.Click += btn_ingreso_Click;
            // 
            // FormularioLog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(btn_ingreso);
            Controls.Add(btn_profesor);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_contrasenia);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_alumno);
            Controls.Add(btn_preceptor);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormularioLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioLog";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_preceptor;
        private Button btn_alumno;
        private Label lbl_usuario;
        private Label lbl_contrasenia;
        private TextBox txt_usuario;
        private TextBox txt_password;
        private Button btn_profesor;
        private Button btn_ingreso;
    }
}