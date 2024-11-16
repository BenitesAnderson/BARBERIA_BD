using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTelefonoCliente
    {
        public int IdTelefono { get; set; }
        public string IdCliente { get; set; }
        public string NumeroTelefono { get; set; }
        public string Operador { get; set; }
        
        public entCliente Cliente { get; set; }
    }
}
