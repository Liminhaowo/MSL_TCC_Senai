﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_1._0
{
    public partial class FormIntroducao : Form
    {
        public FormIntroducao()
        {
            InitializeComponent();
        }

        private void FormIntroducao_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            FormCantina formCantina = new FormCantina();
            formCantina.Show();
        }
    }
}
