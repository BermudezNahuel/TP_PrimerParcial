using PrimerParcialBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialUI
{
    public partial class Profesor_01UI : Form
    {
        private Profesor _profesor;

        public Profesor_01UI()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.NavajoWhite;
            btn_salir.Font = new Font("Bahnschrift", 12, FontStyle.Bold, GraphicsUnit.Point);

        }


        /// <summary>
        /// Cierra el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Completa los comboBox con la informacion de los cursos y la materias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Profesor_01UI_Load(object sender, EventArgs e)
        {

            for (int i = 1; i < 7; i++)
            {
                cbo_anio.Items.Add(i);

            }

            var materias = Datos.Abrir().Materias;

            var listaMaterias = new List<string>();

            foreach (var item in materias)
            {
                foreach (var mat in item.Materias)
                {
                    listaMaterias.Add(mat);
                }

            }

            var lista2 = listaMaterias.Distinct().ToList();

            foreach (var item in lista2)
            {
                cbo_materia.Items.Add(item);
            }

        }

        /// <summary>
        /// Asigna un valor al atributo _profesor
        /// </summary>
        /// <param name="profesor">Recibe un objeto tipo tipo Profesor</param>
        public void Info_profesor(Profesor profesor)
        {
            _profesor = profesor;
        }



        /// <summary>
        /// Filtra la lista de anos y materias disponibles, con la que son propias
        /// del profesor, si es correcto lo redirige a un nuevo formulario para calificar
        /// a los alumnos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_calificar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var mat in _profesor.MateriasDictadas)
                {

                    if ((int)mat.Curso == Convert.ToInt32(cbo_anio.SelectedIndex))
                    {
                        foreach (var item in mat.Materias)
                        {

                            if (cbo_materia.SelectedItem.ToString() == item)
                            {
                                FormProfesorCalificar formProfesorCalificar = new FormProfesorCalificar();
                                formProfesorCalificar.CursoYMateria((int)mat.Curso, item);
                                formProfesorCalificar.Show();
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                lbl_errorMateriaAnio.Visible = true;
            }

        }

        /// <summary>
        /// Cierra el fromulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
