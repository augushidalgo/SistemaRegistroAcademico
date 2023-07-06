using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaRegistroAcademico.Datos
{
    public class CD_Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["Cadenaconexion"].ToString();
    }
}