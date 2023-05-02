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

            //2do Deserializo el Json en una lista de objetos
            var listaAlumnos = ManipularDatos.AbrirJsonAlumnos("C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");

            var listaDnis = ManipularDatos.TraerDnisAlumnos(listaAlumnos);

            //4to almacenar la info de las celdas en distintas variables 
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int anio = Convert.ToInt32(txt_anio.Text);

            int dni = Convert.ToInt32(txt_dni.Text);
            Validar.ValidarDniOrThrow(dni, listaDnis);

            string telefono = txt_telefono.Text;

            //5to Buscar el ultimo elemento de la lista de alumnos para obtener y asignar un nuevo numero de legajo al nuevo alumno
            int legajo = listaAlumnos[listaAlumnos.Count - 1].Legajo + 1;

            //6to Instanciar un nuevo objeto de la clase Alumno
            var alumno = new Alumno(nombre, apellido, dni, telefono, anio, legajo);

            //7mo Agregar el alumno, a la lista de alumnos
            listaAlumnos.Add(alumno);

            //8vo Guardar la lista modificada como un archivo Json
            ManipularDatos.GuardarAlumno(listaAlumnos, "C:\\Users\\Nahuel\\source\\repos\\TP_PrimerParcial\\PrimerParcial\\bin\\Debug\\net6.0\\datosAlumnos.json");


            MessageBox.Show(alumno.MostrarInfo());
        }

        private void PreceptorUI_Load(object sender, EventArgs e)
        {

        }
    }
}
