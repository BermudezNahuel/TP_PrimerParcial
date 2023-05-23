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
using static PrimerParcialBiblioteca.ClaseEnum;

namespace PrimerParcialUI
{
    public partial class FormProfesorCalificar : Form
    {
        private int _curso;
        private string _materia;
        private List<Alumno> _listaAlumnos;

        public FormProfesorCalificar()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.NavajoWhite;
        }


        /// <summary>
        /// Toma como parametro un curso y una materia de la Clase Alumno y completa
        /// completa el data grid con la nota de los alumnos de un curso determinado
        /// </summary>
        /// <param name="curso"></param>
        /// <param name="materia"></param>
        public void CursoYMateria(int curso, string materia)
        {
            _curso = curso;
            _materia = materia;

            lbl_curso.Text = Convert.ToString(_curso);
            lbl_materia.Text = _materia;

            var listaAlumnos = Buscar.ListarAlumnoPorCurso(_curso);
            _listaAlumnos = listaAlumnos;
            _listaAlumnos.Sort((x, y) => x.Apellido.CompareTo(y.Apellido));

            foreach (var alumno in listaAlumnos)
            {
                var mat = alumno.Notas[_materia];

                dtg_notas.Rows.Add((alumno.Apellido + " " + alumno.Nombre), mat[0], mat[1], mat[2]);

            }
        }


        /// <summary>
        /// Guarda la informacion modificada de cada alumno en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            foreach (var _alumno in _listaAlumnos)
            {
                var materia = _alumno.Notas[_materia];

                foreach (DataGridViewRow fila in dtg_notas.Rows)
                {
                    try
                    {
                        if (fila.Cells[0].Value.ToString() == (_alumno.Apellido + " " + _alumno.Nombre))
                        {
                            materia[0] = Convert.ToInt32(fila.Cells[1].Value.ToString());
                            materia[1] = Convert.ToInt32(fila.Cells[2].Value.ToString());
                            materia[2] = Convert.ToInt32(fila.Cells[3].Value.ToString());
                        }
                    }
                    catch
                    {

                    }

                }
                Datos.ActualizarDatosAlumno(_alumno);
            }
            MessageBox.Show("Se guardaron los cambios correctamente", "CAMBIOS GUARDADOS", MessageBoxButtons.OK);
        }


        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
