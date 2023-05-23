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
        private Alumno _alumno;
        public AlumnoUI()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.CornflowerBlue;
        }

        /// <summary>
        /// Carga la informacion del alumno apsado por paramtero en un data grid
        /// </summary>
        /// <param name="alumno"></param>
        public void Info_alumno(Alumno alumno)
        {
            string nombre = alumno.Nombre;
            string apellido = alumno.Apellido;
            txt_apellido.Text = nombre;
            txt_nombre.Text = apellido;
            _alumno = alumno;

            foreach (var materia in _alumno.Notas)
            {
                dtg_notas.Rows.Add(materia.Key, materia.Value[0], materia.Value[1], materia.Value[2]);
            }

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
