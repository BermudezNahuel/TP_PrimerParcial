namespace PrimerParcialUI
{
    partial class FormIngresoAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoAlumno));
            txt_anio = new TextBox();
            txt_telefono = new TextBox();
            txt_dni = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            lbl_dni = new Label();
            lbl_apellido = new Label();
            lbl_telefono = new Label();
            lbl_anio = new Label();
            lbl_nombre = new Label();
            btn_crear = new Button();
            btn_salir = new Button();
            lbl_mensaje_error = new Label();
            lbl_messageNull = new Label();
            lbl_alumnoIngresado = new Label();
            SuspendLayout();
            // 
            // txt_anio
            // 
            txt_anio.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_anio.Location = new Point(792, 142);
            txt_anio.Name = "txt_anio";
            txt_anio.Size = new Size(200, 41);
            txt_anio.TabIndex = 21;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefono.Location = new Point(564, 229);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(200, 41);
            txt_telefono.TabIndex = 20;
            // 
            // txt_dni
            // 
            txt_dni.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dni.Location = new Point(564, 142);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(200, 41);
            txt_dni.TabIndex = 19;
            txt_dni.TextChanged += txt_dni_TextChanged;
            // 
            // txt_apellido
            // 
            txt_apellido.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_apellido.Location = new Point(792, 63);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(200, 41);
            txt_apellido.TabIndex = 18;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(564, 63);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(200, 41);
            txt_nombre.TabIndex = 17;

            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dni.Location = new Point(564, 105);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(52, 34);
            lbl_dni.TabIndex = 16;
            lbl_dni.Text = "DNI";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_apellido.Location = new Point(792, 21);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(123, 34);
            lbl_apellido.TabIndex = 15;
            lbl_apellido.Text = "Apellido/s";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefono.Location = new Point(564, 192);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(106, 34);
            lbl_telefono.TabIndex = 14;
            lbl_telefono.Text = "Telefono";
            // 
            // lbl_anio
            // 
            lbl_anio.AutoSize = true;
            lbl_anio.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_anio.Location = new Point(792, 105);
            lbl_anio.Name = "lbl_anio";
            lbl_anio.Size = new Size(57, 34);
            lbl_anio.TabIndex = 13;
            lbl_anio.Text = "Año";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(564, 26);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(122, 34);
            lbl_nombre.TabIndex = 12;
            lbl_nombre.Text = "Nombre/s";
            // 
            // btn_crear
            // 
            btn_crear.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btn_crear.Font = new Font("Bahnschrift Light SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_crear.Location = new Point(637, 371);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(303, 42);
            btn_crear.TabIndex = 22;
            btn_crear.Text = "Dar Alta Alumno\r\n\r\n";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += Btn_crear_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.PaleVioletRed;
            btn_salir.Location = new Point(12, 12);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 34);
            btn_salir.TabIndex = 26;
            btn_salir.Text = "Volver";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += Button2_Click;
            // 
            // lbl_mensaje_error
            // 
            lbl_mensaje_error.AutoSize = true;
            lbl_mensaje_error.Font = new Font("Bahnschrift Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_mensaje_error.ForeColor = SystemColors.ControlLightLight;
            lbl_mensaje_error.Location = new Point(520, 308);
            lbl_mensaje_error.Name = "lbl_mensaje_error";
            lbl_mensaje_error.Size = new Size(537, 29);
            lbl_mensaje_error.TabIndex = 27;
            lbl_mensaje_error.Text = "El número de DNI ya se encuentra registrado";
            lbl_mensaje_error.Visible = false;
            // 
            // lbl_messageNull
            // 
            lbl_messageNull.AutoSize = true;
            lbl_messageNull.Font = new Font("Bahnschrift Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_messageNull.ForeColor = SystemColors.ControlLightLight;
            lbl_messageNull.Location = new Point(584, 308);
            lbl_messageNull.Name = "lbl_messageNull";
            lbl_messageNull.Size = new Size(408, 29);
            lbl_messageNull.TabIndex = 28;
            lbl_messageNull.Text = "Debe completar todos los campos";
            lbl_messageNull.Visible = false;
            // 
            // lbl_alumnoIngresado
            // 
            lbl_alumnoIngresado.AutoSize = true;
            lbl_alumnoIngresado.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_alumnoIngresado.Location = new Point(613, 456);
            lbl_alumnoIngresado.Name = "lbl_alumnoIngresado";
            lbl_alumnoIngresado.Size = new Size(364, 29);
            lbl_alumnoIngresado.TabIndex = 29;
            lbl_alumnoIngresado.Text = "EL ALUMNO FUE INGRESADO CORRECTAMENTE";
            lbl_alumnoIngresado.Visible = false;
            // 
            // FormIngresoAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1059, 621);
            Controls.Add(lbl_alumnoIngresado);
            Controls.Add(lbl_messageNull);
            Controls.Add(lbl_mensaje_error);
            Controls.Add(btn_salir);
            Controls.Add(btn_crear);
            Controls.Add(txt_anio);
            Controls.Add(txt_telefono);
            Controls.Add(txt_dni);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_dni);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_telefono);
            Controls.Add(lbl_anio);
            Controls.Add(lbl_nombre);
            Name = "FormIngresoAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIngreso";
            Load += PlanillaInscripcionUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_anio;
        private TextBox txt_telefono;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label lbl_dni;
        private Label lbl_apellido;
        private Label lbl_telefono;
        private Label lbl_anio;
        private Label lbl_nombre;
        private Button btn_crear;
        private Button btn_salir;
        private Label lbl_mensaje_error;
        private Label lbl_messageNull;
        private Label lbl_alumnoIngresado;
    }
}