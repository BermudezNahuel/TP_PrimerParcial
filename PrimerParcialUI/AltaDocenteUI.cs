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
    public partial class AltaDocenteUI : Form
    {
        public AltaDocenteUI()
        {
            InitializeComponent();
            Size = new Size(1081, 677);
            BackColor = Color.NavajoWhite;
            btn_salir.Font = new Font("Bahnschrift", 12, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void AltaDocenteUI_Load(object sender, EventArgs e)
        {
            AsignarValoresComboBox();


        }

        private void Lbl_agregar_Click(object sender, EventArgs e)
        {
            var nombre = txt_nombre.Text;
            var apellido = txt_apellido.Text;
            var telefono = txt_telefono.Text;
            var dni = Convert.ToInt32(txt_dni.Text);
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignarValoresComboBox()
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

        private void Btn_AsignarMateria_Click(object sender, EventArgs e)
        {
            dtg_AnioYMateria.Rows.Add(cbo_anio.SelectedItem.ToString(),
                                        cbo_materia.SelectedItem.ToString());
        }

        private void TomarValoresDgt()
        {
            var lista = new List<string>();
            var dicc = new Dictionary<string, List<string>>();
            foreach (DataGridViewRow fila in dtg_AnioYMateria.Rows)
            {
                lista.Add(fila.Cells[1].Value.ToString());
                dicc.Add(fila.Cells[0].Value.ToString(), lista);
            }

            
        }
    }
}
