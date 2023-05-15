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
    public partial class Profesor_01UI : Form
    {
        public Profesor_01UI()
        {
            InitializeComponent();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Profesor_01UI_Load(object sender, EventArgs e)
        {
            cbo_materia.Items.Add("Biología");
            cbo_materia.Items.Add("Físico Química");
            cbo_materia.Items.Add("Geografía");

            cbo_anio.Items.Add(1);
            cbo_anio.Items.Add(2);
            cbo_anio.Items.Add(3);
            cbo_anio.Items.Add(4);
            cbo_anio.Items.Add(5);
            cbo_anio.Items.Add(6);

            if (cbo_anio.SelectedIndex == 0)
            {
                cbo_materia.Items.Add("Ciencias Naturales");
                cbo_materia.Items.Add("Ciencias Sociales");
                cbo_materia.Items.Add("Educación Artística");
                cbo_materia.Items.Add("Educación Física");
                cbo_materia.Items.Add("Inglés");
                cbo_materia.Items.Add("Matemática");
                cbo_materia.Items.Add("Prácticas del Lenguaje");
                cbo_materia.Items.Add("Construcción Ciudadana");
            }

            else if (cbo_anio.SelectedIndex == 1)
            {
                cbo_materia.Items.Add("Biología");
                cbo_materia.Items.Add("Construcción Ciudadana");
                cbo_materia.Items.Add("Educación Artística");
                cbo_materia.Items.Add("Educación Física");
                cbo_materia.Items.Add("Físico Química");
                cbo_materia.Items.Add("Geografía");
                cbo_materia.Items.Add("Historia");
                cbo_materia.Items.Add("Inglés");
                cbo_materia.Items.Add("Matemática");
                cbo_materia.Items.Add("Prácticas del Lenguaje");
                cbo_materia.Items.Add("Construcción Ciudadana");
            }
            else
            {
                cbo_materia.Items.Add("Ciencias Naturales");
                cbo_materia.Items.Add("Ciencias Sociales");
                cbo_materia.Items.Add("Educación Artística");
                cbo_materia.Items.Add("Educación Física");
                cbo_materia.Items.Add("Inglés");
                cbo_materia.Items.Add("Matemática");
                cbo_materia.Items.Add("Prácticas del Lenguaje");
                cbo_materia.Items.Add("Construcción Ciudadana");
            }


        }
    }
}
