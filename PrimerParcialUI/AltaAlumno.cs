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
            Size = new Size(1081, 677);
            BackColor = Color.CornflowerBlue;
            btn_salir.Font = new Font("Bahnschrift", 12, FontStyle.Bold, GraphicsUnit.Point);
        }


        /// <summary>
        /// Toma los datos de los textBox y los utiliza para
        /// crear un nuevo alumno, modficando el archivo Json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_crear_Click(object sender, EventArgs e)
        {
            try
            {
                var listaDni = Buscar.ListarDni(Datos.Abrir().Alumnos);
                var nombre = txt_nombre.Text;
                var apellido = txt_apellido.Text;
                var telefono = txt_telefono.Text;
                var dni = Convert.ToInt32(txt_dni.Text);
                var anio = Convert.ToInt32(txt_anio.Text);

                if (Validar.ValidarDni(dni, listaDni))
                {
                    AdministrarUsuario.AgregarUsuario("path", txt_nombre.Text, txt_apellido.Text, Convert.ToInt32(txt_dni.Text), txt_telefono.Text, Convert.ToInt32(txt_anio.Text));
                    
                    DialogResult result = MessageBox.Show("El alumno fue ingresado correctamente", "Nuevo Ingreso", MessageBoxButtons.OK);

                    txt_nombre.Clear();
                    txt_apellido.Clear();
                    txt_telefono.Clear();
                    txt_dni.Clear();
                    txt_anio.Clear();
                }
                else
                {
                    txt_nombre.Clear();
                    txt_apellido.Clear();
                    txt_telefono.Clear();
                    txt_dni.Clear();
                    txt_anio.Clear();
                    throw new Exception();

                }

            }
            catch (NullReferenceException)
            {
                lbl_mensaje_error.Visible = true;

            }
            catch (Exception)
            {
                lbl_mensaje_error.Visible = true;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
