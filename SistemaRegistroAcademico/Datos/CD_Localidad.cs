using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRegistroAcademico.Negocio;
using System.Windows.Forms;
using System.Collections;

namespace SistemaRegistroAcademico.Datos
{
    public class CD_Localidad
    {
        // Metodo para SELECT
        public List<CN_Localidad> Listar()
        {
            List<CN_Localidad> lista = new List<CN_Localidad>();
            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string query = "select id_localidad,nombre from LOCALIDAD";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CN_Localidad
                            {
                                Id_localidad = dr["id_localidad"].ToString(),
                                Nombre = dr["nombre"].ToString(),
                            });
                        }
                    }

                }
                catch (Exception)
                {
                    lista = new List<CN_Localidad>();
                    MessageBox.Show("Error al seleccionar los registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista;
        }
        public DataTable leerLocalidad()
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable dtLocalidad = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string query = "select id_localidad,nombre from LOCALIDAD";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = cmd;
                    dtLocalidad = new DataTable();
                    adaptador.Fill(dtLocalidad);

                    oconexion.Close();

                    return dtLocalidad;
                }

                catch (Exception)
                {

                    dtLocalidad = new DataTable();
                    MessageBox.Show("Error al seleccionar los registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

        }
        public bool Agregar(CN_Localidad oCN_Localidad)
        {
            string consulta = "INSERT INTO LOCALIDAD(id_localidad,nombre) VALUES('" + oCN_Localidad.Id_localidad + "','" + oCN_Localidad.Nombre + "');";
            return ejecutarConsulta(consulta);

        }

        public bool Eliminar(CN_Localidad oCN_Localidad)
        {
            string consulta = "DELETE FROM LOCALIDAD WHERE id_localidad = '" + oCN_Localidad.Id_localidad + "'";
            return ejecutarConsulta(consulta);
        }

        public bool Modificar(CN_Localidad oCN_Localidad)
        {
            string consulta = "UPDATE LOCALIDAD SET nombre='" + oCN_Localidad.Nombre + "' WHERE id_localidad='" + oCN_Localidad.Id_localidad + "';";
            return ejecutarConsulta(consulta);
        }

        // Método para INSERT, UPDATE, DELETE
        public bool ejecutarConsulta(string query)
        {
            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, oconexion);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    oconexion.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al en la consulta, no se ha podido realizar la operación: " + e.ToString());
                    return false;
                }
            }
        }
    }
}
