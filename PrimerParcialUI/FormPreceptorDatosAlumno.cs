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
    public partial class FormPreceptorDatosAlumno : Form
    {
        private Alumno _alumno;

        public FormPreceptorDatosAlumno()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.NavajoWhite;
            Btn_Salir.Font = new Font("Bahnschrift", 12, FontStyle.Bold, GraphicsUnit.Point);
        }


        /// <summary>
        /// Carga los datagrid con la informacion del alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPreceptorDatosAlumno_Load(object sender, EventArgs e)
        {
            dtg_info.Rows.Add(_alumno.Apellido, _alumno.Nombre, _alumno.Dni, _alumno.Anio, _alumno.Telefono);

            foreach (var materia in _alumno.Notas)
            {
                dtg_notas.Rows.Add(materia.Key, materia.Value[0], materia.Value[1], materia.Value[2]);
            }
        }

        /// <summary>
        /// Recibe los datos de un alumno y se lo asigna al atributo _alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void CargarInfoAlumno(Alumno alumno)
        {
            _alumno = alumno;

        }


        /// <summary>
        /// Toma la informacion de las datagrid y reemplaza los datos del
        /// alumno por esta, luego actualizada el archivco Json con estos datos
        /// </summary>
        private void ActualizarInformacion()
        {
            foreach (var materia in _alumno.Notas)
            {
                foreach (DataGridViewRow fila in dtg_notas.Rows)
                {
                    try
                    {
                        if (fila.Cells[0].Value.ToString() == materia.Key)
                        {
                            materia.Value[0] = Convert.ToInt32(fila.Cells[1].Value.ToString());
                            materia.Value[1] = Convert.ToInt32(fila.Cells[2].Value.ToString());
                            materia.Value[2] = Convert.ToInt32(fila.Cells[3].Value.ToString());
                        }

                    }
                    catch
                    {

                    }

                }
            }

            _alumno.Apellido = dtg_info.Rows[0].Cells[0].Value.ToString();
            _alumno.Nombre = dtg_info.Rows[0].Cells[1].Value.ToString();
            _alumno.Dni = Convert.ToInt32(dtg_info.Rows[0].Cells[2].Value.ToString());
            _alumno.Anio = Convert.ToInt32(dtg_info.Rows[0].Cells[3].Value.ToString());
            _alumno.Telefono = dtg_info.Rows[0].Cells[4].ToString();


            AdministrarUsuario.ActualizarDatosUsuario(_alumno);
        }


        /// <summary>
        /// Muestra un mensaje, para corroborar la accion y luego ejecuta la eliminacion 
        /// toda la informacion del alumno del archivo Json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DarBaja_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("ESTA SEGURO DE DAR DE BAJA ALUMNO", "DAR BAJA", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                AdministrarUsuario.EliminarUsuario(_alumno);
            }
            else if (result == DialogResult.No)
            {
            }
        }


        /// <summary>
        /// Muestra un mensaje, para corroborar la accion y luego ejecuta la actualizacion de la 
        /// informacion del alumno en el archivo json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTA SEGURO", "ACTUALIZAR DATOS", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ActualizarInformacion();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
