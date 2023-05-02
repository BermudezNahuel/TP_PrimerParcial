using PrimerParcialBiblioteca;

namespace PrimerParcialUI
{
    public partial class FormularioLog : Form
    {
        public FormularioLog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            PreceptorUI preceptorUI = new PreceptorUI();
            preceptorUI.Show();
        }

        private void btn_profesor_Click(object sender, EventArgs e)
        {
            Profesor_01UI profesorUI = new Profesor_01UI();
            profesorUI.Show();

        }

        private void btn_alumno_Click(object sender, EventArgs e)
        {
            int usuario = Convert.ToInt32(txt_usuario.Text);
            int password = Convert.ToInt32(txt_password.Text);

            var listaAlumnos = ManipularDatos.AbrirJsonAlumnos("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            if (BuscarUsuario(listaAlumnos,usuario,password))
            {
                AlumnoUI alumnoUI = new AlumnoUI();
                alumnoUI.Show();

            }
            
            MessageBox.Show("El usuario o contraseña son incorrectos");
            
        }

        public static bool BuscarUsuario (List<Alumno> listaAlumno, int usuario, int password)
        {
            var listaAlumnos = ManipularDatos.AbrirJsonAlumnos("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            foreach (var alumno in listaAlumnos)
            {
                if (alumno.Dni == usuario && alumno.Password == password)
                {
                    return true;
                }

            }
            return false;
        }
    }


}