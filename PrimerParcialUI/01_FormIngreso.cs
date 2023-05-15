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

            var lista = Datos<List<Alumno>>.Abrir("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            if (Validar.ValidarIngresoAlumno(lista, Convert.ToInt32(txt_usuario.Text), Convert.ToInt32(txt_password.Text)))
            {
                AlumnoUI alumnoUI = new AlumnoUI();
                alumnoUI.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos");

            }


        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {   
            
        }
    }


}