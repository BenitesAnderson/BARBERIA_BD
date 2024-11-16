using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleVentaProducto
    {
        public int idDetalle { get; set; }
        public string idVenta { get; set; }
        public string idProducto { get; set; }
        public int cantidad { get; set; }
        
        public entVenta venta { get; set; }
        public entProducto producto { get; set; }
    }
}

