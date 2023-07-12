using SistemaRegistroAcademico.Datos;
using SistemaRegistroAcademico.Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroAcademico.Presentacion
{
    public partial class frmEstudiantes : Form
    {
        CD_Localidad oCD_Localidad;
        CD_Estudiantes oCD_Estudiantes;
        public frmEstudiantes()
        {
            oCD_Localidad = new CD_Localidad();
            oCD_Estudiantes = new CD_Estudiantes();
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            // Llenado del ComboBox para mostrar las localidades
            cbxLocalidad.DataSource = oCD_Localidad.leerLocalidad();
            cbxLocalidad.DisplayMember = "nombre";
            cbxLocalidad.ValueMember = "id_localidad";

            // Llenado del DataGridView con la tabla estudiantes
            dgvEstudiantes.DataSource = oCD_Estudiantes.leerEstudiantes();
            dgvEstudiantes.Columns["id_alumno"].Visible = false;
            //dgvEstudiantes.AllowUserToAddRows = false;
        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbxLocalidad.SelectedValue.ToString());
        }

        private void dtpf_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtFNacimiento.Text = dtpf_nacimiento.Value.Date.ToShortDateString();
            txtFNacimiento.Text = dtpf_nacimiento.Value.ToString("MM-dd-yyyy");
        }
    }
}
