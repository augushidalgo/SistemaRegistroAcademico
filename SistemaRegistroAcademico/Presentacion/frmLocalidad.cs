using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaRegistroAcademico.Negocio;
using SistemaRegistroAcademico.Datos;

namespace SistemaRegistroAcademico.Presentacion
{
    public partial class frmLocalidad : Form
    {
        CD_Localidad oCD_Localidad;
          public frmLocalidad()
        {
            oCD_Localidad = new CD_Localidad();
            InitializeComponent();
            dgvLocalidad.DataSource = oCD_Localidad.Listar().ToList();
            dgvLocalidad.Columns[0].HeaderText = "ID";
            dgvLocalidad.Columns[1].HeaderText = "Localidad";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNombre.Text != "")
            {

                if (oCD_Localidad.Agregar(RecuperarInfo()))
                {
                    MessageBox.Show("Registro almacenado correctamente.", "Aviso", MessageBoxButtons.OK);
                    dgvLocalidad.DataSource = oCD_Localidad.Listar().ToList();
                    dgvLocalidad.Columns[0].HeaderText = "ID";
                    dgvLocalidad.Columns[1].HeaderText = "Localidad";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un ID y un nombre", "Aviso", MessageBoxButtons.OK);
            }

            
        }
        // Obtener la información desde la interfaz
        private CN_Localidad RecuperarInfo()
        {
            CN_Localidad oLocalidad = new CN_Localidad();
            
            oLocalidad.Id_localidad = txtID.Text ;
            oLocalidad.Nombre = txtNombre.Text;

            return oLocalidad;
        }

        private void dgvLocalidad_Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                txtID.Text = dgvLocalidad.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvLocalidad.Rows[indice].Cells[1].Value.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (oCD_Localidad.Eliminar(RecuperarInfo()))
            {
                MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK);
                dgvLocalidad.DataSource = oCD_Localidad.Listar().ToList();
                dgvLocalidad.Columns[0].HeaderText = "ID";
                dgvLocalidad.Columns[1].HeaderText = "Localidad";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (oCD_Localidad.Modificar(RecuperarInfo()))
            {
                MessageBox.Show("Registro actualizado correctamente.", "Aviso", MessageBoxButtons.OK);
                dgvLocalidad.DataSource = oCD_Localidad.Listar().ToList();
                dgvLocalidad.Columns[0].HeaderText = "ID";
                dgvLocalidad.Columns[1].HeaderText = "Localidad";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
