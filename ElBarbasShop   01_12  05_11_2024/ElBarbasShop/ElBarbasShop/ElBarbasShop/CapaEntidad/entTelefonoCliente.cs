using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTelefonoCliente
    {
        public string idCliente { get; set; }
        public string numeroTelefono { get; set; }
        public string operador { get; set; }

        // Constructor vacío
        public entTelefonoCliente() { }

        // Constructor con parámetros
        public entTelefonoCliente(string idCliente, string numeroTelefono, string operador)
        {
            this.idCliente = idCliente;
            this.numeroTelefono = numeroTelefono;
            this.operador = operador;
        }
    }





}
