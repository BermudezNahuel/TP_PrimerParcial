﻿using System;
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



        }

        private void Lbl_agregar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
