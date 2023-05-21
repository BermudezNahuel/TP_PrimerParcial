using PrimerParcialBiblioteca;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace PrimerParcialUI
{
    public partial class FormularioLog : Form
    {
        public FormularioLog()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.NavajoWhite;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            PreceptorUI preceptorUI = new PreceptorUI();
            preceptorUI.Show();
        }


        private void btn_ingreso_Click(object sender, EventArgs e)
        {
          
            var listaAlumnos = Datos.Abrir().Alumnos;
            var listaProfesores = Datos.Abrir().Profesores;
            var listaAdmin = Datos.Abrir().Admin;
            txt_usuario_TextChanged();

            try
            {
                var usuario = Convert.ToInt32(txt_usuario.Text);
                var password = Convert.ToInt32(txt_password.Text);

                if (Validar.ValidarUsuario(listaAlumnos, usuario, password))
                {
                    foreach (var item in listaAlumnos)
                    {
                        if (item.Dni == Convert.ToInt32(txt_usuario.Text))
                        {
                            AlumnoUI alumnoUI = new AlumnoUI();
                            alumnoUI.Info_alumno(item);
                            alumnoUI.Show();
                        }
                    }
                }
                else if (Validar.ValidarUsuario(listaAdmin, usuario, password))
                {
                    foreach (var item in listaAdmin)
                    {
                        if (item.Dni == Convert.ToInt32(txt_usuario.Text))
                        {
                            PreceptorUI preceptorUI = new PreceptorUI(); ;
                            //preceptorUI.Info_preceptor(item);
                            preceptorUI.Show();
                        }
                    }

                }
                else if (Validar.ValidarUsuario(listaProfesores, usuario, password))
                {
                    foreach (var item in listaProfesores)
                    {
                        if (item.Dni == Convert.ToInt32(txt_usuario.Text))
                        {
                            Profesor_01UI ingresoProfes = new Profesor_01UI();
                            ingresoProfes.Info_profesor(item);
                            ingresoProfes.Show();
                        }
                    }
                }
                throw new Exception();



            }
            catch (FormatException ex)
            {

                lbl_errorFormat.Visible = true;
                txt_usuario.Text = "";
                txt_password.Text = "";
                //MessageBox.Show(ex.Message.ToString());

            }
            catch (Exception ex)
            {
                lbl_errorContraseña.Visible = true;
                txt_usuario.Text = "";
                txt_password.Text = "";
            }
        }

        private void txt_usuario_TextChanged()
        {
            lbl_errorFormat.Visible = false;
            lbl_errorContraseña.Visible = false;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

