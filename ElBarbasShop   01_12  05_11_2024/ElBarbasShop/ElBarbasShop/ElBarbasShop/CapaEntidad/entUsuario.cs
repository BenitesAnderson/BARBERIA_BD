using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public string IdUsuario { get; set; }
        public string IdCliente { get; set; }
        public string IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public byte[] Contrasena { get; set; }
        public string Rol { get; set; }
        public DateTime? LastLogin { get; set; }

        public entCliente Cliente { get; set; }
        public entEmpleado Empleado { get; set; }
    }
}
