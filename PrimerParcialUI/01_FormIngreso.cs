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
    }
    

}