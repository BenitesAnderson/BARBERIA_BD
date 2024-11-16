using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTelefonoEmpleado
    {
        public int IdTelefono { get; set; }
        public string IdEmpleado { get; set; }
        public string NumeroTelefono { get; set; }
        public string Operador { get; set; }

        public entEmpleado Empleado { get; set; }
    }
}

