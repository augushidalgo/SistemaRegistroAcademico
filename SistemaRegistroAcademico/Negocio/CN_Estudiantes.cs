using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroAcademico.Negocio
{
    public class CN_Estudiantes
    {
        public int Id_alumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string F_nacimiento { get; set; }
        public string Localidad { get; set; }
        public byte[] FotoEstudiante { get; set; }
    }
}
