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

        public Profesor ProfesorIngresado;

        public Profesor_01UI()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.NavajoWhite;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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


        public void Info_profesor(Profesor profesor)
        {
            string nombre = profesor.Nombre;
            string apellido = profesor.Apellido;
            txt_apellido.Text = nombre;
            txt_nombre.Text = apellido;
            _profesor = profesor;



        }

        private void btn_calificar_Click(object sender, EventArgs e)
        {

            foreach (var mat in _profesor.MateriasDictadas)
            {
                
                if ((int)mat.Curso == Convert.ToInt32(cbo_anio.SelectedIndex))
                {
                    foreach (var item in mat.Materias)
                    {
        
                        if (cbo_materia.SelectedItem.ToString() == item)
                        {
                            Profesor_02UI profeNotas = new Profesor_02UI();
                            profeNotas.Show();
                        }
                    }
                }
            }
            MessageBox.Show("Año o materia incorrecta");

        }
    }
}
