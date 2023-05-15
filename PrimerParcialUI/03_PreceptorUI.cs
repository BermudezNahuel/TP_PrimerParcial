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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormIngresoAlumno altaAlumno = new FormIngresoAlumno();
            altaAlumno.Show();
        }

        private void PreceptorUI_Load(object sender, EventArgs e)
        {

        }
    }
}
