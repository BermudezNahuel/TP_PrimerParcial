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
    public partial class FormPreceptorBuscarAlumno : Form
    {
        public FormPreceptorBuscarAlumno()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.CornflowerBlue;
        }


        /// <summary>
        /// Busca por dni en la lista de alumnos y luego abre el formulario
        /// con los datos del alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            var listaA = Datos.Abrir().Alumnos;
            var dni = Convert.ToInt32(textBox_dni.Text);

            try
            {
                foreach (var item in listaA)
                {
                    if (item.Dni == dni)
                    {
                        FormPreceptorDatosAlumno form = new FormPreceptorDatosAlumno();
                        form.CargarInfoAlumno(item);
                        form.Show();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
