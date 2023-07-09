using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRegistroAcademico.Presentacion;

namespace SistemaRegistroAcademico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlocalidad_Click(object sender, EventArgs e)
        {
            // Crear y mostrar objeto del formulario localidad
            frmLocalidad formlocalidad = new frmLocalidad();
            formlocalidad.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
