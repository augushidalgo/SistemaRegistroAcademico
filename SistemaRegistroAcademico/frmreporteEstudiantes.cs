using Microsoft.Reporting.WinForms;
using SistemaRegistroAcademico.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroAcademico
{
    public partial class frmreporteEstudiantes : Form
    {
        // Creamos un objeto de la clase donde están
        // los métodos de CRUD a la base de datos
        CD_Estudiantes oCD_Estudiantes;
        public frmreporteEstudiantes()
        {
            // Instanciamos el objeto
            oCD_Estudiantes = new CD_Estudiantes();
            InitializeComponent();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            rvestudlocal.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsreporteestudlocal", oCD_Estudiantes.leerEstudiantes());
            rvestudlocal.LocalReport.ReportPath = "reportesEstudiantes.rdlc";
            rvestudlocal.LocalReport.DataSources.Add(rds);
            rvestudlocal.RefreshReport();
        }
    }
}
