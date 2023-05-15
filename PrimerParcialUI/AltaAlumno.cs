using PrimerParcialBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialUI
{
    public partial class FormIngresoAlumno : Form
    {
        public FormIngresoAlumno()
        {
            InitializeComponent();
        }

        private void PlanillaInscripcionUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            CrearUsuario.CrearAlumno(txt_nombre.Text, txt_apellido.Text, Convert.ToInt32(txt_dni.Text), txt_telefono.Text, Convert.ToInt32(txt_anio.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
