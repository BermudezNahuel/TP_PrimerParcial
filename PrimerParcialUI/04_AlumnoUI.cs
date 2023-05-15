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
    public partial class AlumnoUI : Form
    {
        public AlumnoUI()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AlumnoUI_OnLoad(object sender, EventArgs e)
        {
            var listaAlumnos = Datos<List<Alumno>>.Abrir("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            foreach (var alumno in listaAlumnos)
            {
                if (alumno.Activo)
                {
                    string nombre = alumno.Nombre;
                    string apellido = alumno.Apellido;
                    txt_apellido.Text = nombre;
                    txt_nombre.Text = apellido;

                    MessageBox.Show(alumno.MostrarInfo());
                    alumno.Activo = false;
                }
            }
            Datos<Alumno>.Guardar(listaAlumnos, "C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listaAlumnos = Datos<List<Alumno>>.Abrir("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            foreach (var alumno in listaAlumnos)
            {
                if (alumno.Activo)
                {
                    string nombre = alumno.Nombre;
                    string apellido = alumno.Apellido;
                    txt_apellido.Text = nombre;
                    txt_nombre.Text = apellido;

                    MessageBox.Show(alumno.MostrarInfo());
                }
            }
            MessageBox.Show("Hasta aca llego");
        }
    }
}
