using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTelefonoEmpleado
    {
        // Propiedades
        public string idEmpleado { get; set; }
        public string numeroTelefono { get; set; }
        public string operador { get; set; }

        // Constructor vacío
        public entTelefonoEmpleado() { }

        // Constructor con parámetros
        public entTelefonoEmpleado(string idEmpleado, string numeroTelefono, string operador)
        {
            this.idEmpleado = idEmpleado;
            this.numeroTelefono = numeroTelefono;
            this.operador = operador;
        }
    }
}
