using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroAcademico.Datos
{
    public class CD_Estudiantes
    {
        public DataTable leerEstudiantes()
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable dtAlumnoLocalidad = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM viewalumnoLocalidad;";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = cmd;
                    dtAlumnoLocalidad = new DataTable();
                    adaptador.Fill(dtAlumnoLocalidad);

                    oconexion.Close();

                    return dtAlumnoLocalidad;
                }

                catch (Exception)
                {

                    dtAlumnoLocalidad = new DataTable();
                    MessageBox.Show("Error al seleccionar los registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

        }
    }
}
