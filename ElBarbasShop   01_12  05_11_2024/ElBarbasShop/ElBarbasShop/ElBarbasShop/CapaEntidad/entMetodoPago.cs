using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMetodoPago
    {
        public string IdMetodoPago { get; set; }
        public string Descripcion { get; set; }

        public ICollection<entVenta> Ventas { get; set; }
    }
}
