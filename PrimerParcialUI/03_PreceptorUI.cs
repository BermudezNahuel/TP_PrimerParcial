using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerParcialBiblioteca;

namespace PrimerParcialUI
{
    public partial class PreceptorUI : Form
    {
        public PreceptorUI()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.PaleGreen;
            Btn_Salir.Font = new Font("Bahnschrift", 12, FontStyle.Bold, GraphicsUnit.Point);
        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_AlumnoDarAlta_Click(object sender, EventArgs e)
        {
            FormIngresoAlumno formAlumno = new FormIngresoAlumno();
            formAlumno.Show();
        }

        private void Btn_AlumnoGestionar_Click(object sender, EventArgs e)
        {
            FormPreceptorBuscarAlumno form = new FormPreceptorBuscarAlumno();
            form.Show();
        }
    }
}
