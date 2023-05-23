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
            BackColor = Color.CornflowerBlue;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            PreceptorUI preceptorUI = new PreceptorUI();
            preceptorUI.Show();
        }


        /// <summary>
        /// Valida que que la el usuario y la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ingreso_Click(object sender, EventArgs e)
        {

            var listaAlumnos = Datos.Abrir().Alumnos;
            var listaProfesores = Datos.Abrir().Profesores;
            var listaAdmin = Datos.Abrir().Admin;


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
                            //alumnoUI.MdiParent = this;
                            alumnoUI.Info_alumno(item);
                            alumnoUI.Show();
                            txt_password.Clear();
                            txt_usuario.Clear();
                        }
                    }
                }
                else if (Validar.ValidarUsuario(listaAdmin, usuario, password))
                {
                    foreach (var item in listaAdmin)
                    {
                        if (item.Dni == Convert.ToInt32(txt_usuario.Text))
                        {
                            PreceptorUI preceptorUI = new PreceptorUI();
                            //preceptorUI.MdiParent = this;
                            //preceptorUI.Info_preceptor(item);
                            preceptorUI.Show();
                            txt_password.Clear();
                            txt_usuario.Clear();
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
                            //ingresoProfes.MdiParent = this;
                            ingresoProfes.Info_profesor(item);
                            ingresoProfes.Show();
                            txt_password.Clear();
                            txt_usuario.Clear();
                        }
                    }
                }
                txt_password.Clear();
                txt_usuario.Clear();

            }
            catch (FormatException)
            {

                lbl_errorFormat.Visible = true;
                txt_usuario.Clear();
                txt_password.Clear();

            }
            catch (Exception)
            {
                lbl_errorContraseña.Visible = true;
                txt_usuario.Clear();
                txt_password.Clear();
            }
        }

        
    }
}

